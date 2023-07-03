using capaDatos;
using capaNegocios;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FrmLogin : Form
    {
        private readonly PacienteBll _pacientebll;

        public FrmLogin(string providerName, string connectionString)
        {
            InitializeComponent();
            _pacientebll = new PacienteBll(providerName, connectionString);
        }

        #region diseñoControls
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcontraseña.Focus();
                e.Handled = true;
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //ingresar();
                //LoginMultiGestor(selectedDatabase, connectionString);
                e.Handled = true;
            }
        }

        private void txtingresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text;

            bool isValidCredentials = _pacientebll.ValidarCredenciales(usuario, contraseña);

            if (isValidCredentials)
            {
                // Credenciales válidas, iniciar sesión
                // Por ejemplo, puedes abrir el formulario principal
                //prueba prueba = new prueba();
                //prueba.Show();

                // Cerrar el formulario de inicio de sesión si es necesario
                MessageBox.Show("Se inicio sesion");
            }
            else
            {
                // Credenciales inválidas, mostrar un mensaje de error
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        }
    }
}
