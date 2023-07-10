using capaNegocios;
using entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        #region MouseDowmn
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparan);
        #endregion
        public FrmCitas(string providerName, string connectionString)
        {
            this.gestor = providerName;
            this.conexion = connectionString;
            _citaBll = new CitasBll(providerName, connectionString);
            _empleadoBll = new EmpleadoBll(providerName, connectionString);
            InitializeComponent();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var form = new frmModalPaciente(gestor, conexion))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lblDniPac.Text = form.dniPaciente;
                    lblNombre.Text = form.nombrePaciente;
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

        private void InsertarCitas()
        {
            var citas = new Cita
            {
                dniPaciente = lblDniPac.Text,
                idEmpleado = int.Parse(cbxDoctor.SelectedValue.ToString()!),
                fCita = dtpfecha.Value,
                estadoPago = 0,
                total = 0,
                estadoCita = false,
                hCita = int.Parse(cbxHorario.SelectedValue.ToString()!)
            };
            var horari = new Horario
            {
                idHorario = int.Parse(cbxHorario.SelectedValue.ToString()!),
                estado = false,
            };
            _citaBll.InsertarCitas(citas);
            _citaBll.actualizarEstadoHorario(horari);

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarCitas();
            MessageBox.Show("Cita guardada correctamente");
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            CargarHorario();
            CargarEmpleado();

        }

       

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
