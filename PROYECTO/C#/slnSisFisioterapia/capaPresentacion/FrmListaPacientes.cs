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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace capaPresentacion
{
    public partial class FrmListaPacientes : Form
    {
        private PacienteBll _pacientebll;
        private FrmPaciente paciente;

        public string accion { get; set; } = null!;
        public FrmListaPacientes(string gest, string con)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _pacientebll = new PacienteBll(gest, con);
            paciente = new FrmPaciente(gest, con);

            InitializeComponent();
            cbxBuscar.Items.AddRange(new string[] { "Seleccione", "DNI", "Nombre", "Apellido" });
            cbxBuscar.SelectedIndex = 0;
            listarPacientes();
            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            boton.HeaderText = "MODIFICAR";
            boton.Text = "☑";
            boton.Name = "btnModificar";
            boton.UseColumnTextForButtonValue = true;
            dgvPacientes.Columns.Add(boton);



        }

        public void listarPacientes()
        {
            List<ListaPacienteHistoria> pacientes = _pacientebll.ObtenerListaPacientes();
            dgvPacientes.DataSource = pacientes;
            dgvPacientes.Columns["HISTORIA"].Visible = false;
            dgvPacientes.Columns["IDHistoria"].Visible = false;
            dgvPacientes.Columns["observaciones"].Visible = false;
            dgvPacientes.Columns["ANTECEDENTES"].Visible = false;
            //dgvPacientes.Columns["PESO"].Visible = false;
            //dgvPacientes.Columns["TALLA"].Visible = false;
            //dgvPacientes.Columns["DIRECCION"].Visible = false;
            //dgvPacientes.Columns["CELULAR"].Visible = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            paciente.accion = "I";
            paciente.ShowDialog();
            listarPacientes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = textBox1.Text;

            if (string.IsNullOrWhiteSpace(valorBusqueda))
            {

                listarPacientes();
                return;
            }
            try
            {
                List<ListaPacienteHistoria> pacientes = null!;
                switch (cbxBuscar.SelectedItem.ToString())
                {
                    case "DNI":
                        pacientes = _pacientebll.BuscarPacientePorDNI(valorBusqueda);
                        break;
                    case "Nombre":
                        pacientes = _pacientebll.BuscarPacientePorNombre(valorBusqueda);
                        break;
                    case "Apellido":
                        pacientes = _pacientebll.BuscarPacientePorApellido(valorBusqueda);
                        break;
                }
                dgvPacientes.DataSource = pacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los pacientes: " + ex.Message);
            }
        }



        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.Columns[e.ColumnIndex].Name == "btnModificar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    paciente.lblCodigo.Text = dgvPacientes.CurrentRow.Cells[1].Value.ToString();
                    paciente.txtDniPaciente.Text = dgvPacientes.CurrentRow.Cells[2].Value.ToString();
                    paciente.txtNombres.Text = dgvPacientes.CurrentRow.Cells[3].Value.ToString();
                    paciente.txtApellidos.Text = dgvPacientes.CurrentRow.Cells[4].Value.ToString();
                    paciente.txtDireccion.Text = dgvPacientes.CurrentRow.Cells[5].Value.ToString();
                    paciente.dtpFechaNacimiento.Text = dgvPacientes.CurrentRow.Cells[6].Value.ToString();
                    paciente.txtCelular.Text = dgvPacientes.CurrentRow.Cells[7].Value.ToString();
                    paciente.txtAntecedentes.Text = dgvPacientes.CurrentRow.Cells[8].Value.ToString();
                    paciente.txtPeso.Text = dgvPacientes.CurrentRow.Cells[9].Value.ToString();
                    paciente.txtTalla.Text = dgvPacientes.CurrentRow.Cells[10].Value.ToString();
                    paciente.txtImc.Text = dgvPacientes.CurrentRow.Cells[11].Value.ToString();
                    paciente.lblIdHist.Text = dgvPacientes.CurrentRow.Cells[12].Value.ToString();
                    paciente.lblobserv.Text = dgvPacientes.CurrentRow.Cells[13].Value.ToString();
                    paciente.txtDniPaciente.Enabled = false;
                    paciente.accion = "U";
                    paciente.ShowDialog();
                    listarPacientes();

                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowser.SelectedPath;
                string fileName = string.Format("{0}_{1}.pdf", this.Name, DateTime.Now.ToString("ddMMyyyyHHmmss"));
                string filePath = Path.Combine(folderPath, fileName);

                string paginahtml_texto = Properties.Resources.plantilla.ToString();
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                // decimal total = 0;
                foreach (DataGridViewRow row in dgvPacientes.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["DNI"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["NOMBRES"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["APELLIDOS"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["DIRECCION"].Value.ToString() + "</td>";
                    filas += "<td>" + ((DateTime)row.Cells["FNACIMIENTO"].Value).ToShortDateString() + "</td>";
                    filas += "<td>" + row.Cells["CELULAR"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["PESO"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["TALLA"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["IMC"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

                try
                {
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A3, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoReport, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(160, 160);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);

                        using (MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(paginahtml_texto)))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, new StreamReader(memStream, Encoding.UTF8));
                        }

                        pdfDoc.Close();
                        stream.Close();

                        MessageBox.Show("PDF guardado exitosamente.", "Guardar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el PDF: " + ex.Message, "Guardar PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
