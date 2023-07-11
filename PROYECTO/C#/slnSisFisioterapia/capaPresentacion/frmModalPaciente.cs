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
    public partial class frmModalPaciente : Form
    {
        public string dniPaciente { get; set; } = null!;
        public string nombrePaciente { get; set; } = null!;
        private readonly PacienteBll _pacientebll;
        #region MouseDowmn
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparan);
        #endregion
        public frmModalPaciente(string providerName, string connectionString)
        {
            InitializeComponent();
            _pacientebll = new PacienteBll(providerName, connectionString);


        }

        void listarPacientes()
        {
            List<ListaPacienteHistoria> pacientes = _pacientebll.ObtenerListaPacientes();
            dgvPaciente.DataSource = pacientes;
            dgvPaciente.Columns["HISTORIA"].Visible = false;
            dgvPaciente.Columns["DIRECCION"].Visible = false;
            dgvPaciente.Columns["ANTECEDENTES"].Visible = false;
            dgvPaciente.Columns["PESO"].Visible = false;
            dgvPaciente.Columns["TALLA"].Visible = false;
            dgvPaciente.Columns["IMC"].Visible = false;
            dgvPaciente.Columns["FNACIMIENTO"].Visible = false;
            dgvPaciente.Columns["CELULAR"].Visible = false;
            dgvPaciente.Columns["IDHistoria"].Visible = false;
            dgvPaciente.Columns["observaciones"].Visible = false;

            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            boton.HeaderText = "Seleccionar";
            boton.Text = "☑";
            boton.Name = "btnModificar";
            boton.UseColumnTextForButtonValue = true;
            dgvPaciente.Columns.Add(boton);




        }

        private void frmModalPaciente_Load(object sender, EventArgs e)
        {
            listarPacientes();
        }

        private void dgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPaciente.Columns[e.ColumnIndex].Name == "btnModificar")
            {

                int index = e.RowIndex;
                if (index >= 0)
                {
                    dniPaciente = dgvPaciente.Rows[index].Cells["DNI"].Value.ToString()!;
                    string nombreCompleto = dgvPaciente.Rows[index].Cells["NOMBRES"].Value.ToString()!;
                    string apellidoPaciente = dgvPaciente.Rows[index].Cells["APELLIDOS"].Value.ToString()!;

                    string[] nombres = nombreCompleto.Split(' ');
                    string primerNombre = nombres[0];
                    string primerApellido = apellidoPaciente.Split(' ')[0];

                    nombrePaciente = $"{primerNombre} {primerApellido}";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
