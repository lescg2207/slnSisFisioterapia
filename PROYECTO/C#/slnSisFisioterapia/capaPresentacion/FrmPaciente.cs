using capaNegocios;
using entidades;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FrmPaciente : Form
    {

        private readonly PacienteBll _pacientebll;
        ApisPeru ApisPeru = new ApisPeru();

        public FrmPaciente(PacienteBll pacientesBll)
        {
            InitializeComponent();
            _pacientebll = new PacienteBll();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listarPacientes();
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
                observaciones = "",
            };

            _pacientebll.InsertarPaciente(paciente);
            _pacientebll.InsertarPacienteHistoria(historia);
            Limpiar();
            listarPacientes();

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
            Limpiar();
            listarPacientes();
            MessageBox.Show("Paciente Actualizado con exito");
        }
        void listarPacientes()
        {
            List<Paciente> listaPacientes = _pacientebll.ObtenerListaPacientes();
            dgvPaciente.DataSource = listaPacientes;
        }
        private void Limpiar()
        {
            txtNombres.Text = "";
            txtDniPaciente.Text = "";
            txtApellidos.Text = "";
            dtpFechaNacimiento.Text = DateTime.Now.ToString("d");
            txtAntecedentes.Text = "";
            txtPeso.Text = "";
            txtTalla.Text = "";
            txtImc.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
        }

        private void consultarCliente()
        {

            try
            {
                if (txtDniPaciente.Text.Length == 8)
                {
                    dynamic respuesta = ApisPeru.Get("https://dniruc.apisperu.com/api/v1/dni/" + txtDniPaciente.Text + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6InF1aXNwZXJlbmF0bzIyMDRAZ21haWwuY29tIn0.x7Rn6yw2jGolXveQVb_vSDUvj46gB1fTWNekVJaCE0M");
                    txtNombres.Text = respuesta.nombres.ToString();
                    txtApellidos.Text = respuesta.apellidoPaterno.ToString() + " " + respuesta.apellidoMaterno.ToString();
                    /*dtpFechaNacimiento.Text = DateTime.Now.ToString("d");
                    txtAntecedentes.Text = "";
                    txtPeso.Text = "";
                    txtTalla.Text = "";
                    txtImc.Text = "";
                    txtCelular.Text = "";
                    txtDireccion.Text = "";*/


                }

                else
                {
                    MessageBox.Show("Ingrese un n�mero de documento v�lido.", "Documento inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un n�mero de documento v�lido.", "Documento inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbxConsurDni_Click(object sender, EventArgs e)
        {
            consultarCliente();
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDniPaciente.Text = dgvPaciente.CurrentRow.Cells[0].Value.ToString();
            txtNombres.Text = dgvPaciente.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvPaciente.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvPaciente.CurrentRow.Cells[3].Value.ToString();
            dtpFechaNacimiento.Text = dgvPaciente.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = dgvPaciente.CurrentRow.Cells[5].Value.ToString();

        }
    }
}