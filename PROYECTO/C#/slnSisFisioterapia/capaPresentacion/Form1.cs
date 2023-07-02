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

            var historia = new HistoriaClinica
            {
                dniPaciente = txtDniPaciente.Text,
                antecedentes = txtAntecedentes.Text,
                peso = decimal.Parse(txtPeso.Text),
                talla = decimal.Parse(txtTalla.Text),
                imc = decimal.Parse(txtImc.Text),
                observaciones = txtObserva.Text,
            };

            _pacientebll.InsertarPacientHistoria(paciente, historia);

            MessageBox.Show("Paciente guardado correctamente.");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
            _pacientebll.ActualizarPaciente(paciente);
            MessageBox.Show("Paciente Actualizado con exito");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Paciente> listaPacientes = _pacientebll.ObtenerListaPacientes();
            dgvPaciente.DataSource = listaPacientes;
        }
    }
}