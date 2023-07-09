using capaNegocios;
using entidades;
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
    public partial class ListaServicio : Form
    {
        private ServicioBll _serviciotebll;
        public static int idSeleccionado { get; set; }
        public static string servicioSeleccionado { get; set; } = null!;
        public static decimal precioSeleccionado { get; set; } = 0!;

        public ListaServicio(string gest, string con)
        {
            _serviciotebll = new ServicioBll(gest, con);

            InitializeComponent();
            listarServ();
        }

        public void listarServ()
        {
            List<Servicio> serv = _serviciotebll.ObtenerServicios();
            dgvServicios.DataSource = serv;
        }

        private void dgvcitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow fila = dgvServicios.Rows[e.RowIndex];
                ListaServicio.idSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                ListaServicio.servicioSeleccionado = fila.Cells[1].Value.ToString();
                ListaServicio.precioSeleccionado = Convert.ToDecimal(fila.Cells[2].Value);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
