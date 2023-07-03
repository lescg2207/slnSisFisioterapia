using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;
using entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using static entidades.Enums;

namespace capaPresentacion
{
    public partial class frmEleccionBD : Form
    {
        private GestorBaseDatos _selectedGestor;
        public frmEleccionBD()
        {
            InitializeComponent();
            comboBoxGestor.DataSource = Enum.GetValues(typeof(GestorBaseDatos));
            comboBoxGestor.SelectedIndexChanged += ComboBoxGestor_SelectedIndexChanged;
        }

        private void ComboBoxGestor_SelectedIndexChanged(object? sender, EventArgs e)
        {
            _selectedGestor = (GestorBaseDatos)comboBoxGestor.SelectedItem;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new BDFisioContext(_selectedGestor))
                {
                    if (_selectedGestor == GestorBaseDatos.SqlServer)
                    {
                        dbContext.Database.SetConnectionString("Server=DESKTOP-E593S88\\SQLEXPRESS;Database=BDFisio;integrated security= true;TrustServerCertificate=true;");
                    }
                    else if (_selectedGestor == GestorBaseDatos.MySql)
                    {
                        dbContext.Database.SetConnectionString("Server=localhost;Uid=root;Pwd=admin;Database=bdfisio");
                    }

                    // Realizar una consulta de prueba, por ejemplo, obtener la lista de pacientes
                    var pacientes = dbContext.Pacientes.ToList();

                    // Verificar que se obtengan los datos correctamente
                    foreach (var paciente in pacientes)
                    {
                        MessageBox.Show(paciente.Nombres);
                    }

                    MessageBox.Show("Conexión exitosa al gestor de base de datos seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar al gestor de base de datos: " + ex.Message);
            }
        }
    }
}
