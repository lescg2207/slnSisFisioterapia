using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
using System.Runtime.InteropServices;

namespace capaPresentacion
{
    public partial class FrmListaCitaPac : Form
    {
        private CitasBll _citaBll;
        private string gestor, conexion;

        public decimal total;
        public FrmListaCitaPac(string gest, string cone)
        {
            _citaBll = new CitasBll(gest, cone);
            this.gestor = gest;
            this.conexion = cone;
            InitializeComponent();

            CargarCitas();
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            boton.HeaderText = "EDITAR";
            boton.Name = "btnEditar";
            boton.UseColumnTextForButtonValue = true;
            dgvCitas.Columns.Add(boton);
            DataGridViewButtonColumn botonVer = new DataGridViewButtonColumn();
            botonVer.HeaderText = "BOLETA";
            botonVer.Name = "btnBoleta";
            botonVer.UseColumnTextForButtonValue = true;
            dgvCitas.Columns.Add(botonVer);
        }

        void CargarCitas()
        {
            List<ListaCitaPacHorario> tabla = _citaBll.ListarCitaEmPaHo();
            dgvCitas.DataSource = tabla;
            dgvCitas.Columns["DESCUENTO"].Visible = false;
            dgvCitas.Columns["IMPUESTO"].Visible = false;



        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas(gestor, conexion);
            citas.ShowDialog();
            CargarCitas();
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCitas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    FrmDetalleDeCita detalleDeCita = new FrmDetalleDeCita(gestor, conexion);
                    detalleDeCita.lblIdCita.Text = dgvCitas.CurrentRow.Cells[2].Value.ToString();
                    detalleDeCita.ckbEstadoCita.Checked = true;
                    detalleDeCita.ShowDialog();
                    CargarCitas();
                }
            }else if (dgvCitas.Columns[e.ColumnIndex].Name == "btnBoleta")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    decimal subtotal;
                    decimal descuento;
                    decimal impuesto;
                    decimal descuento2;
                    decimal impuesto3;
                    frmBoleta Boleta = new frmBoleta(gestor, conexion);
                    Boleta.lblid.Text = dgvCitas.CurrentRow.Cells[2].Value.ToString();
                    subtotal = decimal.Parse(dgvCitas.CurrentRow.Cells[8].Value.ToString()!);
                    impuesto = decimal.Parse(dgvCitas.CurrentRow.Cells[10].Value.ToString()!);
                    descuento = decimal.Parse(dgvCitas.CurrentRow.Cells[9].Value.ToString()!);
                    

                    decimal total1;                                      
                    impuesto3 = subtotal * impuesto;                   
                    total1 = impuesto3 + subtotal;
                    descuento2 = total1 * descuento;
                    total=total1-descuento2;
                    Boleta.lblTOtalCIta.Text = subtotal.ToString("0.00");
                    Boleta.lbldescuento.Text = descuento2.ToString("0.00");
                    Boleta.lblImpuesto.Text = impuesto3.ToString("0.00");
                    Boleta.lbltotal.Text = total.ToString("0.00");
                    Boleta.lblPorDesc.Text = (descuento*100).ToString();
                    Boleta.lblPorImp.Text = (impuesto*100).ToString();

                    Boleta.ShowDialog();
                }
            }
        }
    }
}
