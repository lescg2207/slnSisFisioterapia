using capaNegocios;
using entidades;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        int intentos = 0;
        private readonly PacienteBll _pacientebll;
        public FrmLogin(string providerName, string connectionString)
        {
            InitializeComponent();
            this.gestor = providerName;
            this.conexion = connectionString;
            _pacientebll = new PacienteBll(providerName, connectionString);
        }
        #region Login
        private void MsgError(string Msh)
        {
            label1.Text = "   " + Msh;
            label1.Visible = true;
        }
        private void Validarlogin()
        {
            FrmMenu menu= new FrmMenu(gestor,conexion);
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text;
            Empleado empleado = new Empleado();

            empleado = _pacientebll.ValidarCredenciales(usuario, contraseña);
            if (usuario != "USUARIO")
            {
                if (contraseña != "CONTRASEÑA")
                {
                    if (empleado != null)
                    {
                        MessageBox.Show("Bienvenid@" + " " + empleado.Nombres + " ", "BIENVENIDO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (empleado.IdCargo == 2)
                        {
                            menu.pEnfermera.Visible = true;
                        }
                        else if (empleado.IdCargo==1)
                        {
                            menu.pbDoctor.Visible = true;
                        }
                        else
                        {
                            menu.pbAdmin.Visible = true;
                        }
                        menu.Show();
                        this.Hide();
                    }
                    else if (intentos == 2)
                    {
                        MessageBox.Show("Has excedido el numero de intentos para ingresar al sistema", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MsgError("Usuario o contraseña inválidos");
                        txtcontraseña.Clear();
                        txtusuario.Focus();
                        intentos = intentos + 1;
                    }
                }
                else
                {
                    MsgError(" " + "  Falta ingresar contraseña");
                }

            }
            else
            {
                MsgError(" " + "   Falta ingresar usuario");
                txtusuario.Focus();
            }


        }
        #endregion

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
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Validarlogin();
        }
    }
}
