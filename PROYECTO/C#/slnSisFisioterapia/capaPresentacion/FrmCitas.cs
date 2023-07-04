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
            _empleadoBll=new EmpleadoBll(providerName, connectionString);
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
            var tabla=_empleadoBll.ObtenerEmpleado();
            if(tabla.Count > 0)
            {
                cbxDoctor.DataSource = tabla;
                cbxDoctor.DisplayMember = "Nombres";
                cbxDoctor.ValueMember = "IdEmpleado";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
