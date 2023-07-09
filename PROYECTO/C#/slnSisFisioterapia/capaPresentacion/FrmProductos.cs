using capaNegocios;
using entidades;
using entidades.Vistas;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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
    public partial class FrmProductos : Form
    {
        private ProductosBll _productoBll;
        private string accion { get; set; } = null!;
        public FrmProductos(string gest, string con)
        {
            _productoBll = new ProductosBll(gest, con);
            InitializeComponent();
            ListarProducto();

            if (!dgvProducto.Columns.Contains("Modificar"))
            {
                DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
                boton.HeaderText = "Modificar";
                boton.Text = "✎";
                boton.Name = "btnModificar";
                boton.UseColumnTextForButtonValue = true;
                dgvProducto.Columns.Add(boton);
            }

            if (!dgvProducto.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
                boton.HeaderText = "Eliminar";
                boton.Text = "❌";
                boton.Name = "btnEliminar";
                boton.UseColumnTextForButtonValue = true;
                dgvProducto.Columns.Add(boton);
            }

        }

        private void ListarProducto()
        {
            List<ListaProductos> prod = _productoBll.ObtenerProductos();
            dgvProducto.DataSource = prod;
        }

        private void Limpiar()
        {
            txtNombres.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            accion = "N";
            btnregistrar.Text = "AGREGAR";
        }
        private void InsertarProducto()
        {
            var prod = new Productos
            {
                nomProducto = txtNombres.Text,
                precio = decimal.Parse(txtprecio.Text),
                stock = int.Parse(txtstock.Text)
            };

            _productoBll.InsertarProducto(prod);
            Limpiar();
            MessageBox.Show("Producto agregado");
        }
        private void ActualizarProducto()
        {
            var prod = new Productos
            {
                idProducto = int.Parse(lblId.Text),
                nomProducto = txtNombres.Text,
                precio = decimal.Parse(txtprecio.Text),
                stock = int.Parse(txtstock.Text)
            };
            _productoBll.ActualizarProducto(prod);
            Limpiar();
            MessageBox.Show("Producto actualizado");
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            accion = "N";
            if (accion == "N")
            {
                btnregistrar.Text = "AGREGAR";
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (accion == "N")
            {
                InsertarProducto();

            }
            else if (accion == "U")
            {
                ActualizarProducto();

            }
            accion = "N";
            btnregistrar.Text = "AGREGAR";
            ListarProducto();
            txtNombres.Focus();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducto.Columns[e.ColumnIndex].Name == "btnModificar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    accion = "U";
                    lblId.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
                    txtNombres.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();
                    txtprecio.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
                    txtstock.Text = dgvProducto.CurrentRow.Cells[5].Value.ToString();
                    btnregistrar.Text = "MODIFICAR";

                }
            }
            else if (dgvProducto.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    int idProd = int.Parse(dgvProducto.CurrentRow.Cells[2].Value.ToString()!);
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        var prod = new Productos
                        {
                            idProducto = idProd
                        };

                        _productoBll.EliminarProducto(prod);
                        MessageBox.Show("Producto eliminado");
                        ListarProducto();

                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = textBox1.Text;

            if (string.IsNullOrWhiteSpace(valorBusqueda))
            {

                ListarProducto();
                return;
            }
            try
            {
                List<ListaProductos> productos = null!;
                productos = _productoBll.BuscarProdNombre(valorBusqueda);

                dgvProducto.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los productos: " + ex.Message);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowser.SelectedPath;
                string fileName = string.Format("{0}_{1}.pdf", this.Name, DateTime.Now.ToString("ddMMyyyyHHmmss"));
                string filePath = Path.Combine(folderPath, fileName);

                string paginahtml_texto = Properties.Resources.plantillaprod.ToString();
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                decimal total = 0;
                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["CODIGO"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["NOMBRE"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["PRECIO"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["STOCK"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
                paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

                try
                {
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
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
