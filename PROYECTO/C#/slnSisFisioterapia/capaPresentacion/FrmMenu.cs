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
    public partial class FrmMenu : Form
    {
        private string gestor;
        private string conexion;
        #region MouseDowmn
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparan);
        #endregion
        public FrmMenu(string providerName, string connectionString)
        {
            InitializeComponent();
            this.gestor = providerName;
            this.conexion = connectionString;

        }
        #region Abrir Formularios
        public void AbrirFrm(object FrmContenedor)
        {
            if (this.frmContenedor.Controls.Count > 0)
                this.frmContenedor.Controls.RemoveAt(0);
            Form? fh = FrmContenedor as Form;
            fh!.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.frmContenedor.Controls.Add(fh);
            this.frmContenedor.Tag = fh;
            fh.Show();

        }
        #endregion

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FrmListaPacientes frmPaciente = new FrmListaPacientes(gestor, conexion);
            AbrirFrm(frmPaciente);

        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm tt");
            lblDia.Text = DateTime.Now.ToString("dd");
            lblMesAño.Text = DateTime.Now.ToString("Y");
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FrmCitas citas = new FrmCitas(gestor, conexion);
            AbrirFrm(citas);

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Frmtreeview tre = new Frmtreeview(gestor, conexion);
            AbrirFrm(tre);


        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FrmListaEmpleado emple = new FrmListaEmpleado(gestor, conexion);
            AbrirFrm(emple);
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            FrmProductos prod = new FrmProductos(gestor, conexion);
            AbrirFrm(prod);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
