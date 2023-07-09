using capaNegocios;
using entidades;
using entidades.Vistas;
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
    public partial class ListaCitas : Form
    {
        private CitasBll _citastebll;
        public static int idSeleccionado { get; set; }
        public static string PacienteSeleccionado { get; set; } = null!;

        public ListaCitas(string gest, string con)
        {
            _citastebll = new CitasBll(gest, con);

            InitializeComponent();
            listarCit();
        }

        public void listarCit()
        {
            List<Cita> cit = _citastebll.ObtenerCita();
            dgvcitas.DataSource = cit;
        }

        private void dgvcitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow fila = dgvcitas.Rows[e.RowIndex];
                ListaCitas.idSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                ListaCitas.PacienteSeleccionado = fila.Cells[1].Value.ToString()!;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
