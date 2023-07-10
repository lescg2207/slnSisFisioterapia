using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using entidades;
using System.Windows.Forms;
using capaDatos;

namespace capaPresentacion
{
    public partial class frmBoleta : Form
    {
        private CitasBll _citaBll;
        private PacienteBll _pacienteBll;
        private string gestor, conexion;
        private DetalleCitaBll _detalleCitaBll;

        public frmBoleta(string gest, string cone)
        {
            _citaBll = new CitasBll(gest, cone);
            _pacienteBll = new PacienteBll(gest, cone);
            _detalleCitaBll = new DetalleCitaBll(gest, cone);
            this.gestor = gest;
            this.conexion = cone;
            InitializeComponent();
        }

        private void frmBoleta_Load(object sender, EventArgs e)
        {
            // Paso 1: Obtener el idCita seleccionado (por ejemplo, desde un DataGridView)
            int idCitaSeleccionada = int.Parse(lblid.Text.ToString()); // Reemplaza con tu lógica para obtener el idCita seleccionado

            // Paso 2: Obtener la lista de citas con sus pacientes
            List<ListaCitaPacHorario> citasConPacientes = _citaBll.ListarCitaEmPaHo();

            // Paso 3: Buscar la cita con el idCita seleccionado en la lista de citas
            ListaCitaPacHorario citaSeleccionada = citasConPacientes.FirstOrDefault(c => c.CODIGO == idCitaSeleccionada);



            int idCita = int.Parse(lblid.Text.ToString());

            // Obtén la lista de productos relacionados con el idCita
            List<DetalleCita> productos = _detalleCitaBll.ListarProductos(idCita);

            // Asigna la lista de productos al DataGridView
            dataGridView2.DataSource = productos;


            // Paso 4: Asignar el dniPaciente al TextBox correspondiente en tu formulario
            if (citaSeleccionada != null)
            {
                txtdni.Text = citaSeleccionada.PACIENTE;

                // Paso 5: Obtener los nombres y apellidos del paciente correspondiente al DNI
                string dniPaciente = txtdni.Text;

                // Paso 6: Obtener la fecha correspondiente a la cita seleccionada
                DateTime fechaCita = citaSeleccionada.FECHA;

                // Paso 7: Asignar la fecha al control correspondiente en tu formulario
                txtfecha.Text = fechaCita.ToString("dd/MM/yyyy");

                // Paso 8: Obtener los nombres y apellidos del paciente correspondiente al dniPaciente
                List<ListaPacienteHistoria> pacientes = _pacienteBll.ObtenerListaPacientes();
                ListaPacienteHistoria paciente = pacientes.FirstOrDefault(p => p.DNI == dniPaciente);

                if (paciente != null)
                {
                    string nombres = paciente.NOMBRES;
                    string apellidos = paciente.APELLIDOS;

                    // Paso 9: Asignar los nombres y apellidos a los TextBox correspondientes en tu formulario
                    txtnombres.Text = nombres;
                    txtapellidos.Text = apellidos;
                }
                else
                {
                    // No se encontró ningún paciente con el DNI especificado
                    // Realiza alguna acción de manejo de errores o muestra un mensaje al usuario
                }
            }
            else
            {
                // La cita seleccionada no se encontró en la lista, realiza alguna acción de manejo de errores
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
