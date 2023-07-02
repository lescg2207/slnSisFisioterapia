using capaNegocios;
using entidades;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        
        private readonly PacienteBll _pacientebll;

        public Form1(PacienteBll pacientesBll)
        {
            InitializeComponent();
            _pacientebll = new PacienteBll();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            var paciente = new Paciente
            {
                dniPaciente = txtDniPaciente.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Direccion = txtDireccion.Text,
                FNacimiento = dtpFechaNacimiento.Value,
                Celular = txtCelular.Text
            };

            _pacientebll.InsertarPaciente(paciente);

            MessageBox.Show("Paciente guardado correctamente.");
            
        }
    }
}