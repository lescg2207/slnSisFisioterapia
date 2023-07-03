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
        //PacienteBll pacientesDll = new PacienteBll();
        #region MouseDowmn
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparan);
        #endregion
        public FrmMenu()
        {
            InitializeComponent();
        }
        #region Abrir Formularios
        public void AbrirFrm(object FrmContenedor)
        {
            if (this.frmContenedor.Controls.Count > 0)
                this.frmContenedor.Controls.RemoveAt(0);
            Form fh = FrmContenedor as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.frmContenedor.Controls.Add(fh);
            this.frmContenedor.Tag = fh;
            fh.Show();

        }
        #endregion

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            /*FrmPaciente frmPaciente = new FrmPaciente(pacientesDll);
            AbrirFrm(frmPaciente);
            lbltitulo.Text = "Registro de Pacientes";*/
        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm tt");
            lblDia.Text = DateTime.Now.ToString("dd");
            lblMesAño.Text = DateTime.Now.ToString("Y");
        }
    }
}
