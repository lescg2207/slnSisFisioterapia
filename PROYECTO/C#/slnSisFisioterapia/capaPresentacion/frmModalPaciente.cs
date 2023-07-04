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
    public partial class frmModalPaciente : Form
    {
        public string dniPaciente { get; set; } = null!;
        private readonly PacienteBll _pacientebll;
        public frmModalPaciente(string providerName, string connectionString)
        {
            InitializeComponent();
            _pacientebll = new PacienteBll(providerName, connectionString);

            DiseñoInicial();

        }
        private void DiseñoInicial()
        {
            dgvPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaciente.MultiSelect = false;
            dgvPaciente.ReadOnly = true;
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaciente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaciente.MultiSelect = false;
            dgvPaciente.ReadOnly = true;
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaciente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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

            bool te = dgvPaciente.Columns.Contains("Accion");

            if (!dgvPaciente.Columns.Contains("Accion"))
            {
                DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
                boton.HeaderText = "Accion";
                boton.Text = "☑";
                boton.Name = "btnModificar";
                boton.UseColumnTextForButtonValue = true;
                dgvPaciente.Columns.Add(boton);
            }



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
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
