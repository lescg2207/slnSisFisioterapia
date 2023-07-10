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
        private List<DetalleCita> listaProductos = new List<DetalleCita>();
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
            ListarServicios();
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

        private void ListarProducto()
        {

            List<ListaProductos> prod = _productoBll.ObtenerProductos();
            comboBoxProductos.DataSource = prod;
            comboBoxProductos.DisplayMember = "PRODUCTO";
            comboBoxProductos.ValueMember = "PRECIO";



        }
        private void ListarServicios()
        {
            List<Servicio> serv = servBll.ObtenerServicios();
            cbxServicio.DataSource = serv;
            cbxServicio.DisplayMember = "servicio";
            cbxServicio.ValueMember = "idServicio";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ListaProductos productoSeleccionado = (ListaProductos)comboBoxProductos.SelectedItem;
            int cantidad = int.Parse(txtCantidad.Text);
            decimal precioUnitario = productoSeleccionado.PRECIO;
            decimal subtotal = cantidad * precioUnitario;

            DetalleCita detProducto = new DetalleCita
            {
                idCita = int.Parse(lblIdCita.Text),
                idProducto = productoSeleccionado.CODIGO,
                cantidad = cantidad,
                precioU = precioUnitario,
                subtotal = subtotal,
                estado = true,
            };

            // Agrega el objeto DetProducto a la lista existente en memoria
            listaProductos.Add(detProducto);

            // Actualiza el DataGridView con la lista de productos en memoria
            dgvListaProductos.DataSource = null;
            dgvListaProductos.DataSource = listaProductos;
            dgvListaProductos.Columns["idCita"].Visible = false;
            dgvListaProductos.Columns["idDetalle"].Visible = false;
            dgvListaProductos.Columns["idServicio"].Visible = false;
            dgvListaProductos.Columns["estado"].Visible = false;
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



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Declarar una lista para almacenar los detalles de la cita
            List<DetalleCita> detallesCita = new List<DetalleCita>();

            // Verificar si se seleccionaron productos
            if (ckbPruductos.Checked)
            {
                // Obtener los productos seleccionados del DataGridView
                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    // Crear un objeto DetalleCita para cada producto seleccionado
                    DetalleCita detalleProducto = new DetalleCita
                    {
                        idCita = int.Parse(lblIdCita.Text),
                        idProducto = int.Parse(row.Cells["idProducto"].Value.ToString()!),
                        cantidad = int.Parse(row.Cells["cantidad"].Value.ToString()!),
                        precioU = decimal.Parse(row.Cells["precioU"].Value.ToString()!),
                        subtotal = decimal.Parse(row.Cells["subtotal"].Value.ToString()!),
                        estado = true
                    };

                    // Agregar el detalle del producto a la lista
                    detallesCita.Add(detalleProducto);
                }
            }
            Servicio servicioSelecc = (Servicio)cbxServicio.SelectedItem;
            Sesiones sesionselecci=(Sesiones)cbxSesiones.SelectedItem;
            decimal precio;

            if (servicioSelecc.servicio == "Paquete")
            {
                precio = sesionselecci.precio;
            }
            else
            {
                precio=servicioSelecc.precio;
            }



            // Verificar si se seleccionó el servicio
            if (ckbServicio.Checked)
            {
                // Crear un objeto DetalleCita para el servicio seleccionado
                DetalleCita detalleServicio = new DetalleCita
                {
                    idCita = int.Parse(lblIdCita.Text),
                    idServicio = servicioSelecc.IdServicio, // Reemplazar con el ID correcto del servicio
                    cantidad = 1,
                    precioU = precio,
                    subtotal = precio,
                    estado = true
                };

                // Agregar el detalle del servicio a la lista
                detallesCita.Add(detalleServicio);
            }

            // Insertar los detalles de la cita en la base de datos
            foreach (DetalleCita detalle in detallesCita)
            {
                detCita.InsertarDetalle(detalle);
            }

            // Mostrar mensaje de éxito u otra acción necesaria
            MessageBox.Show("Detalles de cita guardados correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void CargarSesion(int idTipo)
        {

            idTipo = int.Parse(cbxServicio.SelectedValue.ToString()!);
            var sesiones = servBll.ObtenerSesiones(idTipo);

            cbxSesiones.DataSource = sesiones;
            cbxSesiones.DisplayMember = "sesiones";
            cbxSesiones.ValueMember = "idSesion";



        }


        private void cbxServicio_SelectedValueChanged(object sender, EventArgs e)
        {

            int idTipo;
            if (int.TryParse(cbxServicio.SelectedValue.ToString(), out idTipo))
            {
                CargarSesion(idTipo);
            }


        }
    }
}
