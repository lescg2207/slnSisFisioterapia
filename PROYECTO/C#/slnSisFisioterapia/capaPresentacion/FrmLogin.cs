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
        public FrmLogin()
        {
            InitializeComponent();
        }


        /*void LoginMultiGestor(string selectedData, string conexion)
        {
            frmMenu frmMenu = new frmMenu(connectionString, selectedDatabase);
            string username = txtusuario.Text;
            string password = txtcontraseña.Text;

            if (username != "USUARIO")
            {
                if (password != "CONTRASEÑA")
                {
                    if (selectedData == "SQL Server")
                    {
                        sqlser = new SqlServerBusinessLayer(new SqlServerConnector(conexion));
                        ouser = sqlser.ValidateLogin(username, password);

                    }
                    else if (selectedData == "MySQL")
                    {
                        mysql = new mySqlBusinessLayer(new MySqlConnector(conexion));
                        ouser = mysql.ValidateLogin(username, password);

                    }
                    else if (selectedData == "Oracle")
                    {
                        orcsql = new OracleBusinessLayer(new OracleConnector(conexion));
                        ouser = orcsql.ValidateLogin(username, password);

                    }
                    else if (selectedData == "Access")
                    {
                        accesql = new AccessBusinessLayer(new AccessConnector(conexion));
                        ouser = accesql.ValidateLogin(username, password);

                    }
                    else
                    {
                        MessageBox.Show("Gestor de base de datos no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    if (ouser != null)
                    {

                        MessageBox.Show("Bienvenid@"+" "+ ouser.usuario+" ", "BIENVENIDO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (ouser.cargo == 2)
                        {
                            frmMenu.pEnfermera.Visible = true;
                        }
                        else if (ouser.cargo == 1)
                        {
                            frmMenu.pDoctor.Visible = true;
                        }
                        else
                        {
                            frmMenu.pAdmin.Visible = true;
                        }
                        frmMenu.Show();
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
        }*/

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
                //ingresar();
                //LoginMultiGestor(selectedDatabase, connectionString);
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
    }
}
