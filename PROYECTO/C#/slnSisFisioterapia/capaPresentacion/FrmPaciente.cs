using capaDatos;
using capaNegocios;
using entidades;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FrmPaciente : Form
    {

        private readonly PacienteBll _pacientebll;
        ApisPeru ApisPeru = new ApisPeru();

        public FrmPaciente(string providerName, string connectionString)
        {
            InitializeComponent();
            _pacientebll = new PacienteBll(providerName, connectionString);
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listarPacientes();
            CCriterioBusqueda.Items.AddRange(new string[] { "Seleccione", "DNI", "Nombre", "Apellido" });
            CCriterioBusqueda.SelectedIndex = 0; // Establecer la opción por defecto
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
            List<ListaPacienteHistoria> pacientes = _pacientebll.ObtenerListaPacientes();
            dgvPaciente.DataSource = pacientes;


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
            txtDniPaciente.Enabled = true;
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


                }

                else
                {
                    MessageBox.Show("Ingrese un número de documento válido.", "Documento inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese un número de documento válido.", "Documento inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbxConsurDni_Click(object sender, EventArgs e)
        {
            consultarCliente();
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDniPaciente.Text = dgvPaciente.CurrentRow.Cells[1].Value.ToString();
            txtNombres.Text = dgvPaciente.CurrentRow.Cells[2].Value.ToString();
            txtApellidos.Text = dgvPaciente.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvPaciente.CurrentRow.Cells[4].Value.ToString();
            dtpFechaNacimiento.Text = dgvPaciente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dgvPaciente.CurrentRow.Cells[6].Value.ToString();
            txtAntecedentes.Text = dgvPaciente.CurrentRow.Cells[7].Value.ToString();
            txtPeso.Text = dgvPaciente.CurrentRow.Cells[8].Value.ToString();
            txtTalla.Text = dgvPaciente.CurrentRow.Cells[9].Value.ToString();
            txtImc.Text = dgvPaciente.CurrentRow.Cells[10].Value.ToString();
            txtDniPaciente.Enabled = false;



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string criterio = CCriterioBusqueda.SelectedItem.ToString();
            string valorBusqueda = textBox1.Text;

            // Validar que se haya ingresado un valor de búsqueda
            if (string.IsNullOrWhiteSpace(valorBusqueda))
            {
                // Si el valor de búsqueda está vacío, puedes limpiar la lista de resultados o
                // realizar alguna otra acción en la interfaz de usuario
                dgvPaciente.DataSource = null;
                return;
            }

            try
            {
                List<ListaPacienteHistoria> pacientes = null;

                // Realizar la búsqueda según el criterio seleccionado
                switch (criterio)
                {
                    case "DNI":
                        pacientes = _pacientebll.BuscarPacientePorDNI(valorBusqueda);
                        break;
                    case "Nombre":
                        pacientes = _pacientebll.BuscarPacientePorNombre(valorBusqueda);
                        break;
                    case "Apellido":
                        pacientes = _pacientebll.BuscarPacientePorApellido(valorBusqueda);
                        break;
                }

                // Mostrar los resultados en una lista, DataGridView o cualquier otro control
                // según la estructura de tu interfaz de usuario

                // Por ejemplo, asumiendo que tienes un DataGridView llamado dataGridViewPacientes
                dgvPaciente.DataSource = pacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los pacientes: " + ex.Message);
            }
        }
    }
}