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
    public partial class FrmListaPacientes : Form
    {
        private PacienteBll _pacientebll;
        private FrmPaciente paciente;

        public string accion { get; set; } = null!;
        public FrmListaPacientes(string gest, string con)
        {
            _pacientebll = new PacienteBll(gest, con);
            paciente = new FrmPaciente(gest, con);

            InitializeComponent();
            cbxBuscar.Items.AddRange(new string[] { "Seleccione", "DNI", "Nombre", "Apellido" });
            cbxBuscar.SelectedIndex = 0;
            listarPacientes();
            if (!dgvPacientes.Columns.Contains("Accion"))
            {
                DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
                boton.HeaderText = "Accion";
                boton.Text = "☑";
                boton.Name = "btnModificar";
                boton.UseColumnTextForButtonValue = true;
                dgvPacientes.Columns.Add(boton);
            }


        }

        public void listarPacientes()
        {
            List<ListaPacienteHistoria> pacientes = _pacientebll.ObtenerListaPacientes();
            dgvPacientes.DataSource = pacientes;
            dgvPacientes.Columns["HISTORIA"].Visible = false;
            dgvPacientes.Columns["IDHistoria"].Visible = false;
            dgvPacientes.Columns["observaciones"].Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            paciente.accion = "I";
            paciente.ShowDialog();
            listarPacientes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = textBox1.Text;

            if (string.IsNullOrWhiteSpace(valorBusqueda))
            {

                listarPacientes();
                return;
            }
            try
            {
                List<ListaPacienteHistoria> pacientes = null!;
                switch (cbxBuscar.SelectedItem.ToString())
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
                dgvPacientes.DataSource = pacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los pacientes: " + ex.Message);
            }
        }

      

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.Columns[e.ColumnIndex].Name == "btnModificar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    paciente.lblCodigo.Text = dgvPacientes.CurrentRow.Cells[1].Value.ToString();
                    paciente.txtDniPaciente.Text = dgvPacientes.CurrentRow.Cells[2].Value.ToString();
                    paciente.txtNombres.Text = dgvPacientes.CurrentRow.Cells[3].Value.ToString();
                    paciente.txtApellidos.Text = dgvPacientes.CurrentRow.Cells[4].Value.ToString();
                    paciente.txtDireccion.Text = dgvPacientes.CurrentRow.Cells[5].Value.ToString();
                    paciente.dtpFechaNacimiento.Text = dgvPacientes.CurrentRow.Cells[6].Value.ToString();
                    paciente.txtCelular.Text = dgvPacientes.CurrentRow.Cells[7].Value.ToString();
                    paciente.txtAntecedentes.Text = dgvPacientes.CurrentRow.Cells[8].Value.ToString();
                    paciente.txtPeso.Text = dgvPacientes.CurrentRow.Cells[9].Value.ToString();
                    paciente.txtTalla.Text = dgvPacientes.CurrentRow.Cells[10].Value.ToString();
                    paciente.txtImc.Text = dgvPacientes.CurrentRow.Cells[11].Value.ToString();
                    paciente.lblIdHist.Text = dgvPacientes.CurrentRow.Cells[12].Value.ToString();
                    paciente.lblobserv.Text= dgvPacientes.CurrentRow.Cells[13].Value.ToString();
                    paciente.txtDniPaciente.Enabled = false;
                    paciente.accion = "U";
                    paciente.ShowDialog();
                    listarPacientes();

                }
            }
        }
    }
}
