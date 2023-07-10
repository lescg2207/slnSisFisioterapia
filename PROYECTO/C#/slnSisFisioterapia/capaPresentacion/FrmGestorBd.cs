using Microsoft.Data.SqlClient;
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
        private string _gestorSeleccionado = null!;
        public string connectionString = null!;
        public FrmGestorBd()
        {
            InitializeComponent();
            comboBoxDatabase.Items.AddRange(new object[] { "SqlServer", "MySql" });
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
                connectionString = $"server={server};database={database};user={username};password={password}";
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
            string password = textBoxPassword.Text.Trim();

            if (comboBoxDatabase.SelectedItem.ToString() == "SqlServer")
            {
                _gestorSeleccionado = "SqlServer";
            }
            else if (comboBoxDatabase.SelectedItem.ToString() == "MySql")
            {
                _gestorSeleccionado = "MySql";
            }

            connectionString = GetConnectionString(_gestorSeleccionado, server, database, username, password);

            try
            {
                using (var connection = new SqlConnection(connectionString)) // Cambia SqlConnection por MySqlConnection si estás utilizando MySQL
                {
                    connection.Open();
                    MessageBox.Show("Conexion exitosa");
                    FrmLogin paciente = new FrmLogin(_gestorSeleccionado, connectionString);
                    paciente.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                // Se produjo una excepción al intentar establecer la conexión
                MessageBox.Show("Error al establecer la conexión: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxDatabase.SelectedIndex == 0)
            {
                textBoxUsername.Text = "sis";
                textBoxServer.Text = "bdfisioterapia.database.windows.net";
                textBoxPassword.Text = "proyFisio22";
                textBoxDatabase.Text = "bdFisioterapia";
                textBoxServer.Enabled = true;
                textBoxUsername.Enabled = true;
                textBoxPassword.Enabled = true;
                textBoxDatabase.Enabled = false;
                textBoxPassword.Focus();
            }
            else
            {
                textBoxUsername.Text = "root";
                textBoxServer.Text = "localhost";
                textBoxPassword.Text = "";
                textBoxDatabase.Text = "bdFisioterapia";
                textBoxServer.Enabled = true;
                textBoxUsername.Enabled = true;
                textBoxPassword.Enabled = true;
                textBoxDatabase.Enabled = false;
                textBoxPassword.Focus();
            }

        }
    }
}
