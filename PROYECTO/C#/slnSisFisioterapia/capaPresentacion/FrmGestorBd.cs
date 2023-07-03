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
    public partial class FrmGestorBd : Form
    {
        private string _gestorSeleccionado;
        public string connectionString;
        public FrmGestorBd()
        {
            InitializeComponent();
            comboBoxDatabase.Items.AddRange(new object[] { "Seleccione...", "SqlServer", "MySQL", "Oracle", "Access" });
            comboBoxDatabase.SelectedIndex = 0;
        }

        private string GetConnectionString(string selectedDatabase, string server, string database, string username, string password)
        {

            if (selectedDatabase == "SqlServer")
            {
                connectionString = $"Data Source={server};Initial Catalog={database};User ID={username};Password={password};TrustServerCertificate=true;";
            }
            else if (selectedDatabase == "MySql")
            {
                connectionString = $"Server={server};Database={database};Uid={username};Pwd={password}";
            }
            else if (selectedDatabase == "Oracle")
            {
                connectionString = $"Data Source={server};User ID={username};Password={password}";

            }
            else if (selectedDatabase == "Access")
            {

                connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={database};Persist Security Info=False;";
            }

            return connectionString;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string server = textBoxServer.Text;
            string database = textBoxDatabase.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (comboBoxDatabase.SelectedItem == "SqlServer")
            {
                _gestorSeleccionado = "SqlServer";

            }
            else if (comboBoxDatabase.SelectedItem == "MySql")
            {
                _gestorSeleccionado = "MySql";

            }

            connectionString = GetConnectionString(_gestorSeleccionado, server, database, username, password);
            FrmPaciente paciente = new FrmPaciente(_gestorSeleccionado, connectionString);
            paciente.ShowDialog();
            this.Hide();
        }
    }
}
