using capaNegocios;
using entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FrmDetalleCita : Form
    {
        private DetalleCitaBll _detalleBll;
        private ListadoProductos productos;
        private ListaCitas citas;
        private ListaServicio servicio;
       
        public string accion { get; set; } = null!;

    public FrmDetalleCita(string gest, string con)
        {
            _detalleBll = new DetalleCitaBll(gest, con);
            InitializeComponent();
            productos = new ListadoProductos(gest, con);
            citas = new ListaCitas(gest, con);
            servicio = new ListaServicio(gest, con);
        }

        private void InsertarDetalle()
        {
            var det = new DetalleCita
            {
                idCita = int.Parse(txtIDcita.Text),
                idServicio = int.Parse(lblservicios.Text),
                idProducto = int.Parse(txtidProd.Text),
                cantidad = int.Parse(txtcantidad.Text),
                precioU = decimal.Parse(txtprec.Text),
                subtotal = decimal.Parse(lblsubtotal.Text),
                //idImpuesto = int.Parse(txtstock.Text)
            };

            _detalleBll.InsertarDetalle(det);
            MessageBox.Show("Detalle de Cita agregado");
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            {
                if (productos.ShowDialog() == DialogResult.OK)
                {
                    txtidProd.Text = ListadoProductos.idSeleccionado.ToString();
                    txtprod.Text = ListadoProductos.ProductoSeleccionado;
                    txtprec.Text = ListadoProductos.PrecioSeleccionado.ToString();
                }
            }
        }

        private void txtidProd_Click(object sender, EventArgs e)
        {

        }

        private void btnservicios_Click(object sender, EventArgs e)
        {
            {
                if (servicio.ShowDialog() == DialogResult.OK)
                {
                    lblservicios.Text = ListaServicio.idSeleccionado.ToString();
                    txtservicios.Text = ListaServicio.servicioSeleccionado;
                    txtprecServ.Text = ListaServicio.precioSeleccionado.ToString();
                }
            }
        }

        private void btncitas_Click(object sender, EventArgs e)
        {
            {
                if (citas.ShowDialog() == DialogResult.OK)
                {
                    txtIDcita.Text = ListaCitas.idSeleccionado.ToString();
                    txtDNI.Text = ListaCitas.PacienteSeleccionado;
                }
            }
        }

        private void lblsubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtcantidad.Text, out decimal cantidad) && decimal.TryParse(txtprec.Text, out decimal precio))
            {
                decimal subtotal = cantidad * precio;
                lblsubtotal.Text = subtotal.ToString("0.00"); // Mostrar el subtotal con dos decimales
            }
            else
            {
                lblsubtotal.Text = "0.00";
            }
        }

        private void txtprecServ_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtprecServ.Text, out decimal precioServ))
            {
                if (decimal.TryParse(lblsubtotal.Text, out decimal subtotal))
                {
                    decimal nuevoSubtotal = subtotal + precioServ;
                    lblsubtotal.Text = nuevoSubtotal.ToString("0.00"); // Mostrar el subtotal con dos decimales
                }
                else
                {
                    lblsubtotal.Text = precioServ.ToString("0.00"); // Mostrar el precioServ como nuevo subtotal con dos decimales
                }
            }
        }       
    }
}
