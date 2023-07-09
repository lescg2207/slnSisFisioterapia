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
    public partial class FrmCitas : Form
    {
        private string gestor;
        private string conexion;
        private CitasBll _citaBll;
        private EmpleadoBll _empleadoBll;
        public FrmCitas(string providerName, string connectionString)
        {
            this.gestor = providerName;
            this.conexion = connectionString;
            _citaBll = new CitasBll(providerName, connectionString);
            _empleadoBll = new EmpleadoBll(providerName, connectionString);
            InitializeComponent();
            CargarHorario();
            CargarEmpleado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var form = new frmModalPaciente(gestor, conexion))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtDniPaciente.Text = form.dniPaciente;
                }
            }
        }
        void CargarHorario()
        {
            var tabla = _citaBll.ObtenerHorario();

            if (tabla.Count > 0)
            {
                cbxHorario.DataSource = tabla;
                cbxHorario.DisplayMember = "horario";
                cbxHorario.ValueMember = "idHorario";
            }

        }
        void CargarEmpleado()
        {
            var tabla = _empleadoBll.ObtenerEmpleado();
            if (tabla.Count > 0)
            {
                cbxDoctor.DataSource = tabla;
                cbxDoctor.DisplayMember = "Nombres";
                cbxDoctor.ValueMember = "IdEmpleado";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Ingresa nombre del doctor")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Ingresa nombre del doctor";
                txtBuscar.ForeColor = Color.DimGray;
            }
        }
        private void InsertarCitas()
        {
            var citas = new Cita
            {
                dniPaciente = txtDniPaciente.Text,
                idEmpleado = int.Parse(cbxDoctor.SelectedValue.ToString()!),
                fCita = dtpfecha.Value,
                estadoPago = int.Parse(lblEstadopago.Text),
                descuento = 10,
                total = double.Parse(lblTotal.Text),
                estadoCita = "Activa",
                hCita = int.Parse(cbxDoctor.SelectedValue.ToString()!)
            };
            _citaBll.InsertarCitas(citas);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarCitas();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
