﻿using System;
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
            string password = textBoxPassword.Text;

            if (comboBoxDatabase.SelectedItem.ToString() == "SqlServer")
            {
                _gestorSeleccionado = "SqlServer";

            }
            else if (comboBoxDatabase.SelectedItem.ToString() == "MySql")
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
