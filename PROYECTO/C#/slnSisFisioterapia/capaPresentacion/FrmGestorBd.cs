using Microsoft.Data.SqlClient;
using MySqlConnector;
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

        string GetSqlServerConnectionString(string server, string database, string username, string password)
        {
            // Construye y devuelve la cadena de conexión de SQL Server
            return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", server, database, username, password);
        }

        string GetMySqlConnectionString(string server, string database, string username, string password)
        {
            // Construye y devuelve la cadena de conexión de MySQL
            return string.Format("Server={0};Database={1};Uid={2};Pwd={3}", server, database, username, password);
        }

        // Método para obtener la instancia correcta de IDbConnection en función del gestor seleccionado
        IDbConnection GetDbConnection(string selectedDatabase, string connectionString)
        {
            if (selectedDatabase == "SqlServer")
            {
                return new SqlConnection(connectionString);
            }
            else if (selectedDatabase == "MySql")
            {
                return new MySqlConnection(connectionString);
            }
            else
            {
                throw new ArgumentException("Gestor de base de datos no válido");
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string server = textBoxServer.Text;
            string database = textBoxDatabase.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text.Trim();

            string selectedDatabase = comboBoxDatabase.SelectedItem.ToString();
            string connectionString;

            if (selectedDatabase == "SqlServer")
            {
                connectionString = GetSqlServerConnectionString(server, database, username, password);
            }
            else if (selectedDatabase == "MySql")
            {
                connectionString = GetMySqlConnectionString(server, database, username, password);
            }
            else
            {
                MessageBox.Show("Selecciona un gestor de base de datos válido", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = GetDbConnection(selectedDatabase, connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa");
                    FrmLogin paciente = new FrmLogin(selectedDatabase, connectionString);
                    paciente.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
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

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
