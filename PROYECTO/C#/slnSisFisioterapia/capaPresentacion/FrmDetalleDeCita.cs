using capaNegocios;
using entidades;
using entidades.Vistas;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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
using System.Runtime.InteropServices;

namespace capaPresentacion
{
    public partial class FrmDetalleDeCita : Form
    {
        string gestor, conexion;
        private ProductosBll _productoBll;
        private ServicioBll servBll;
        private DetalleCitaBll detCita;
        private List<DetalleCita> listaProductos = new List<DetalleCita>();

        #region MouseDowmn
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparan);
        #endregion
        public FrmDetalleDeCita(string get, string con)
        {
            this.gestor = get;
            this.conexion = con;
            _productoBll = new ProductosBll(get, con);
            servBll = new ServicioBll(get, con);
            detCita = new DetalleCitaBll(get, con);
            InitializeComponent();
            this.Load += FrmDetalleDeCita_Load!;
            ListarProducto();
            ListarServicios();


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
                lblPrecio.Text = "0.00";
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

            };

            listaProductos.Add(detProducto);
            dgvListaProductos.DataSource = null;
            dgvListaProductos.DataSource = listaProductos;
            dgvListaProductos.Columns["idCita"].Visible = false;
            dgvListaProductos.Columns["idDetalle"].Visible = false;
            dgvListaProductos.Columns["idServicio"].Visible = false;

            decimal total = 0;

            foreach (DataGridViewRow fila in dgvListaProductos.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["subtotal"].Value);
            }

            lbltotal.Text = total.ToString();

        }

        private void ckbServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbServicio.Checked)
            {
                pServicios.Visible = true;

                Servicio servicioSeleccionado = (Servicio)cbxServicio.SelectedItem;
                decimal precioServicio = servicioSeleccionado.precio;
                lblPrecio.Text = precioServicio.ToString();
            }
            else
            {
                pServicios.Visible = false;
                lblPrecio.Text = "0.00";
            }

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            List<DetalleCita> detallesCita = new List<DetalleCita>();


            if (ckbPruductos.Checked)
            {

                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {

                    DetalleCita detalleProducto = new DetalleCita
                    {
                        idCita = int.Parse(lblIdCita.Text),
                        idProducto = int.Parse(row.Cells["idProducto"].Value.ToString()!),
                        cantidad = int.Parse(row.Cells["cantidad"].Value.ToString()!),
                        precioU = decimal.Parse(row.Cells["precioU"].Value.ToString()!),
                        subtotal = decimal.Parse(row.Cells["subtotal"].Value.ToString()!),

                    };

                    detallesCita.Add(detalleProducto);
                }
            }
            Servicio servicioSelecc = (Servicio)cbxServicio.SelectedItem;
            Sesiones sesionselecci = (Sesiones)cbxSesiones.SelectedItem;
            decimal precio;

            if (servicioSelecc.servicio == "Paquete")
            {
                precio = sesionselecci.precio;
            }
            else
            {
                precio = servicioSelecc.precio;
            }

            if (ckbServicio.Checked)
            {

                DetalleCita detalleServicio = new DetalleCita
                {
                    idCita = int.Parse(lblIdCita.Text),
                    idServicio = servicioSelecc.IdServicio,
                    cantidad = 1,
                    precioU = precio,
                    subtotal = precio,

                };

                detallesCita.Add(detalleServicio);


            }

            foreach (DetalleCita detalle in detallesCita)
            {
                detCita.InsertarDetalle(detalle);
            }


            var cita = new Cita
            {
                idCita = int.Parse(lblIdCita.Text),
                total = decimal.Parse(lbltotalCita.Text),
                estadoCita = ckbEstadoCita.Checked,

            };
            detCita.ActualizarTotalCita(cita);
            MessageBox.Show("Detalles de cita guardados correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        void CargarSesion(int idTipo)
        {

            idTipo = int.Parse(cbxServicio.SelectedValue.ToString()!);
            var sesiones = servBll.ObtenerSesiones(idTipo);

            cbxSesiones.DataSource = sesiones;
            cbxSesiones.DisplayMember = "sesiones";
            cbxSesiones.ValueMember = "precio";
            decimal precioServicio = Convert.ToDecimal(sesiones.FirstOrDefault()?.precio ?? 0);
            lblPrecio.Text = precioServicio.ToString("0.00");


        }


        private void cbxServicio_SelectedValueChanged(object sender, EventArgs e)
        {

            int idTipo;
            if (int.TryParse(cbxServicio.SelectedValue.ToString(), out idTipo))
            {
                CargarSesion(idTipo);
            }


        }

        private void cbxSesiones_SelectedIndexChanged(object sender, EventArgs e)
        {

            Sesiones sesionSeleccionada = (Sesiones)cbxSesiones.SelectedItem;
            decimal precioSesion = sesionSeleccionada.precio;

            lblPrecio.Text = precioSesion.ToString("0.00");


        }

        private void cbxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

            Servicio servicioSeleccionado = (Servicio)cbxServicio.SelectedItem;
            decimal precioServicio = servicioSeleccionado.precio;
            lblPrecio.Text = precioServicio.ToString();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal tProductos = decimal.Parse(lbltotal.Text);
            decimal tServicio = decimal.Parse(lblPrecio.Text);
            decimal total = tProductos + tServicio;
            lbltotalCita.Text = total.ToString();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
