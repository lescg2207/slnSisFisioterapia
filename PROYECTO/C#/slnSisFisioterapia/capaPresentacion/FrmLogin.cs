using capaNegocios;
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
    public partial class FrmLogin : Form
    {
        #region MouseDowmn
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparan);
        #endregion
        private string gestor;
        private string conexion;
        private readonly PacienteBll _pacientebll;
        public FrmLogin(string providerName, string connectionString)
        {
            InitializeComponent();
            this.gestor = providerName;
            this.conexion = connectionString;
            _pacientebll = new PacienteBll(providerName, connectionString);
        }

        private void Validarlogin()
        {
            FrmMenu menu= new FrmMenu(gestor,conexion);
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text;

            bool isValidCredentials = _pacientebll.ValidarCredenciales(usuario, contraseña);

            if (isValidCredentials)
            {
                menu.Show();                     
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        #region diseñoControls

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
                Validarlogin();            
                e.Handled = true;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusuario_Enter_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Validarlogin();
        }
    }
}
