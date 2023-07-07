using capaNegocios;
using entidades;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FrmPaciente : Form
    {
        private readonly PacienteBll _pacientebll;
        ApisPeru ApisPeru = new ApisPeru();
        public string accion { get; set; } = null!;
        public string dniPaciente { get; set; } = null!;


        #region MouseDowmn
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparan);
        #endregion

        public FrmPaciente(string providerName, string connectionString)
        {
            InitializeComponent();
            _pacientebll = new PacienteBll(providerName, connectionString);
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            if (accion == "I")
            {
                Limpiar();
                btnGuardar.Text = "Nuevo";
                lbltitulo.Text = "Nuevo Paciente";

            }
            else if (accion == "U")
            {
                btnGuardar.Text = "Actualizar";
                lbltitulo.Text = "Modificar Paciente";

            }
        }

        #region InsertarPac
        private void InsertarPaciente()
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
            MessageBox.Show("Paciente guardado correctamente.");

        }
        #endregion


        private void ActualizarPaciente()
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
            var histori = new HistoriaClinica
            {
                Id = int.Parse(lblIdHist.Text),
                idHistoria = lblCodigo.Text,
                dniPaciente = txtDniPaciente.Text,
                antecedentes = txtAntecedentes.Text,
                peso = decimal.Parse(txtPeso.Text),
                talla = decimal.Parse(txtTalla.Text),
                imc = decimal.Parse(txtImc.Text),
                observaciones = lblobserv.Text,
            };
            _pacientebll.ActualizarPaciente(paciente);
            _pacientebll.ActualizarHistoria(histori);
            Limpiar();

            MessageBox.Show("Paciente Actualizado con exito");
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarPaciente();
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
        #region ConsultarDNI
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
        #endregion
        private void pbxConsurDni_Click(object sender, EventArgs e)
        {
            consultarCliente();
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                double peso = double.Parse(txtPeso.Text);
                double talla = double.Parse(txtTalla.Text);
                double r = 0;
                r = peso / (talla * talla);
                txtImc.Text = Math.Round(r).ToString();
                txtTalla.Focus();
                e.Handled = true;
            }
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                double peso = double.Parse(txtPeso.Text);
                double talla = double.Parse(txtTalla.Text);
                double r = 0;
                r = peso / (talla * talla);
                txtImc.Text = Math.Round(r).ToString();
                txtImc.Focus();
                e.Handled = true;
            }
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (txtTalla.Text == string.Empty)
            {
                txtImc.Text = 0.ToString();
                txtTalla.Text = 0.ToString();
            }

            else if (txtPeso.Text == string.Empty)
            {
                txtImc.Text = txtTalla.Text;
            }
            else
            {
                double peso = double.Parse(txtPeso.Text);

                double r = 0;
                r = peso;
                txtImc.Text = Math.Round(r).ToString();
            }
        }

        private void txtTalla_TextChanged(object sender, EventArgs e)
        {
            if (txtPeso.Text == string.Empty)
            {
                txtImc.Text = 0.ToString();
                txtPeso.Text = 0.ToString();
            }
            else if (txtTalla.Text == string.Empty)
            {
                txtImc.Text = txtPeso.Text;
            }
            else
            {
                double peso = double.Parse(txtPeso.Text);
                double talla = double.Parse(txtTalla.Text);
                double r = 0;
                r = peso / (talla * talla);
                txtImc.Text = Math.Round(r).ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "I")
            {
                InsertarPaciente();
                this.Close();
                

            }
            else if (accion == "U")
            {
                ActualizarPaciente();
                this.Close();
            }

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}