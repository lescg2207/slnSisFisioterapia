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
    public partial class FormGestor : Form
    {
        private string _gestorSeleccionado;
        public FormGestor()
        {
            InitializeComponent();
        }

        private void FormGestor_Load(object sender, EventArgs e)
        {
            cbxGestor.Items.Add("SqlServer");
            cbxGestor.Items.Add("MySql");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _gestorSeleccionado = cbxGestor.SelectedItem.ToString();

            // Cerrar el formulario
            this.Close();
        }
        public string ObtenerGestorSeleccionado()
        {
            return _gestorSeleccionado;
        }
    }
}
