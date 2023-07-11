using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using entidades;
using System.Windows.Forms;
using capaDatos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.Runtime.InteropServices;

namespace capaPresentacion
{
    public partial class frmBoleta : Form
    {
        private CitasBll _citaBll;
        private PacienteBll _pacienteBll;
        private string gestor, conexion;
        private DetalleCitaBll _detalleCitaBll;

        public frmBoleta(string gest, string cone)
        {
            _citaBll = new CitasBll(gest, cone);
            _pacienteBll = new PacienteBll(gest, cone);
            _detalleCitaBll = new DetalleCitaBll(gest, cone);
            this.gestor = gest;
            this.conexion = cone;
            InitializeComponent();
        }

        private void frmBoleta_Load(object sender, EventArgs e)
        {
            // Paso 1: Obtener el idCita seleccionado (por ejemplo, desde un DataGridView)
            int idCitaSeleccionada = int.Parse(lblid.Text.ToString()); // Reemplaza con tu lógica para obtener el idCita seleccionado

            // Paso 2: Obtener la lista de citas con sus pacientes
            List<ListaCitaPacHorario> citasConPacientes = _citaBll.ListarCitaEmPaHo();

            // Paso 3: Buscar la cita con el idCita seleccionado en la lista de citas
            ListaCitaPacHorario citaSeleccionada = citasConPacientes.FirstOrDefault(c => c.CODIGO == idCitaSeleccionada)!;



            int idCita = int.Parse(lblid.Text.ToString());

            List<DetalleCitaProductos> productos = _detalleCitaBll.ListarProductosCita(idCita);
            dgvProductos.DataSource = productos;

            List<DtalleCitaServicios> serevicios = _detalleCitaBll.ListarServiciosCita(idCita);
            dgvServicio.DataSource = serevicios;

            if (citaSeleccionada != null)
            {
                txtdni.Text = citaSeleccionada.PACIENTE;

                string dniPaciente = txtdni.Text;
                DateTime fechaCita = citaSeleccionada.FECHA;
                txtfecha.Text = fechaCita.ToString("dd/MM/yyyy");
                List<ListaPacienteHistoria> pacientes = _pacienteBll.ObtenerListaPacientes();
                ListaPacienteHistoria paciente = pacientes.FirstOrDefault(p => p.DNI == dniPaciente)!;

                if (paciente != null)
                {
                    string nombres = paciente.NOMBRES;
                    string apellidos = paciente.APELLIDOS;
                    txtnombres.Text = nombres;
                    txtapellidos.Text = apellidos;
                }
                else
                {

                }
            }
            else
            {

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.reporte_plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DNI", txtdni.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOMBRES", txtnombres.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@APELLIDOS", txtapellidos.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", txtfecha.Text.ToString());


            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvServicio.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["CODIGO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SERVICIO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["CANTIDAD"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PRECIO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SUBTOTAL"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            filas += "<tr><td colspan='5'></td></tr>";

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["CODIGO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PRODUCTO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["CANTIDAD"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PRECIO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SUBTOTAL"].Value.ToString() + "</td>";
                filas += "</tr>";
                //total += decimal.Parse(row.Cells["SUBTOTAL"].Value.ToString()!);
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUBTOTAL", lblTOtalCIta.Text.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@IGV", lblImpuesto.Text.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCUENTO", lbldescuento.Text.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", lbltotal.Text.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A3, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoReport, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(160, 160);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region MouseDowmn
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparan);
        #endregion
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
