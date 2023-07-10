using capaNegocios;
using entidades;
using entidades.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace capaPresentacion
{
    public partial class FrmDetalleDeCita : Form
    {
        string gestor, conexion;
        private ProductosBll _productoBll;
        private PacienteBll pacBll;
        private ServicioBll servBll;
        private DescuentoBll descBll;
        private DetalleCitaBll detCita;
        decimal subtotal2;
        public FrmDetalleDeCita(string get, string con)
        {
            this.gestor = get;
            this.conexion = con;
            _productoBll = new ProductosBll(get, con);
            pacBll = new PacienteBll(get, con);
            servBll = new ServicioBll(get, con);
            descBll = new DescuentoBll(get, con);
            detCita = new DetalleCitaBll(get, con);
            InitializeComponent();
            this.Load += FrmDetalleDeCita_Load!;
            ListarProducto();
            subtotal2 = 100;
            lbltotalCita.Text = subtotal2.ToString();
            CargarDatosTreeView(tServicio);
            tServicio.AfterSelect += tServicio_AfterSelect!;
            //ListarProductos();


        }
        private void FrmDetalleDeCita_Load(object sender, EventArgs e)
        {
            if (ckbPruductos.Checked == false)
            {
                pProductos.Visible = false;
                dgvListaProductos.Rows.Clear();
                decimal total = 0;

                lbltotal.Text = total.ToString();
            }
            else
            {
                pServicios.Visible = true;
            }
            if (ckbServicio.Checked == false)
            {

                pServicios.Visible = false;
            }
            else
            {
                pServicios.Visible = true;
            }

        }

        public void CargarDatosTreeView(System.Windows.Forms.TreeView treeView)
        {
            List<TreeNode> nodosServicios = new List<TreeNode>();
            List<ServicioSesiones> servicios = servBll.ObtenerTreeNodes();
            TreeNode paqueteNode = new TreeNode("Paquete");
            var sesionesPaquete = servicios.Where(servicio => servicio.SERVICIO == "Paquete");

            foreach (var sesion in sesionesPaquete)
            {
                TreeNode sesionNode = new TreeNode($"Sesiones: {sesion.SESIONES}");
                TreeNode precioNode = new TreeNode($"Precio: {sesion.PRECIO}");

                sesionNode.Nodes.Add(precioNode);
                paqueteNode.Nodes.Add(sesionNode);
            }

            nodosServicios.Add(paqueteNode);

            foreach (var servicio in servicios)
            {
                if (servicio.SERVICIO != "Paquete")
                {
                    TreeNode servicioNode = new TreeNode(servicio.SERVICIO);

                    if (servicios.IndexOf(servicio) < 2)
                    {
                        TreeNode precioNodeS = new TreeNode($"Precio: {servicio.PRECIOServ}");
                        servicioNode.Nodes.Add(precioNodeS);
                    }
                    else
                    {
                        TreeNode sesionesNode = new TreeNode($"Sesiones: {servicio.SESIONES}");
                        TreeNode precioNode = new TreeNode($"Precio: {servicio.PRECIO}");

                        servicioNode.Nodes.Add(sesionesNode);
                        servicioNode.Nodes.Add(precioNode);
                    }

                    nodosServicios.Add(servicioNode);
                }
            }

            treeView.Nodes.Clear();
            TreeNode nodoPadreserv = new TreeNode("Servicios", nodosServicios.ToArray());
            treeView.Nodes.Add(nodoPadreserv);

        }
        private void ListarProducto()
        {

            List<ListaProductos> prod = _productoBll.ObtenerProductos();
            comboBoxProductos.DataSource = prod;
            comboBoxProductos.DisplayMember = "PRODUCTO";
            comboBoxProductos.ValueMember = "PRECIO";

        }

        private void ckbPruductos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPruductos.Checked == false)
            {
                pProductos.Visible = false;
                dgvListaProductos.Rows.Clear();
                decimal total = decimal.Parse(lbltotal.Text); lbltotal.Text = "0.00";
                decimal totalCita = decimal.Parse(lbltotalCita.Text);
                txtCantidad.Text = string.Empty;
                decimal valorResta = totalCita - total;
                lbltotalCita.Text = valorResta.ToString();

            }
            else
            {
                pProductos.Visible = true;
            }
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ListaProductos productoSeleccionado = (ListaProductos)comboBoxProductos.SelectedItem;
            int cantidad = int.Parse(txtCantidad.Text);
            decimal precioUnitario = productoSeleccionado.PRECIO;
            decimal subtotal = cantidad * precioUnitario;

            var DetProducto = new DetalleCita
            {
                idCita = int.Parse(lblIdCita.Text),
                idProducto = productoSeleccionado.CODIGO,
                cantidad = cantidad,
                precioU = precioUnitario,
                subtotal = subtotal,
                estado = true,
            };

            detCita.InsertarDetalleProducto(DetProducto);
            ListarProductos(int.Parse(lblIdCita.Text));

        }
        void ListarProductos(int idCita)
        {
            List<DetalleCita> listaProductos = detCita.ListarProductos(idCita);
            dgvListaProductos.DataSource = listaProductos;
            dgvListaProductos.Columns["idCita"].Visible = false;
        }

        private void ckbServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbServicio.Checked == false)
            {
                pServicios.Visible = false;
                //dgvListaProductos.Rows.Clear();
                //decimal total = 0;

                // lbltotal.Text = total.ToString();
            }
            else
            {
                pServicios.Visible = true;
            }
        }

        private void tServicio_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                // Verificar si el nodo seleccionado tiene un precio asociado
                if (e.Node.Text.StartsWith("Precio: "))
                {
                    // Extraer el precio del nodo seleccionado
                    string precioTexto = e.Node.Text.Replace("Precio: ", "");
                    decimal precio = decimal.Parse(precioTexto);

                    // Hacer algo con el precio (por ejemplo, mostrarlo en un TextBox)
                    txtPrecio.Text = precio.ToString();

                }
                else
                {
                    // Si el nodo seleccionado no tiene un precio asociado, limpiar el TextBox
                    txtPrecio.Text = "0.00";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ckbPruductos.Checked)
            {

            }
            else
            {

            }
            if (ckbServicio.Checked)
            {

                var detServico = new DetalleCita
                {
                    idCita = int.Parse(lblIdCita.Text),
                    idServicio = 2,
                    cantidad = 1,
                    precioU = decimal.Parse(txtPrecio.Text),
                    subtotal = decimal.Parse(txtPrecio.Text),


                };

                detCita.InsertarDetalleServicio(detServico);

            }
            else
            {

            }
        }
    }
}
