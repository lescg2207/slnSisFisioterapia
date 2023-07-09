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
    public partial class ListadoProductos : Form
    {
        private ProductosBll _productostebll;
        public static decimal PrecioSeleccionado { get; set; }
        public static int idSeleccionado { get; set; }
        public static string ProductoSeleccionado { get; set; } = null!;

        public ListadoProductos(string gest, string con)
        {
            _productostebll = new ProductosBll(gest, con);

            InitializeComponent();
            listarProd();
        }

        public void listarProd()
        {
            List<ListaProductos> productos = _productostebll.ObtenerProductos();

            dgvpoductos.AutoGenerateColumns = false;
            dgvpoductos.DataSource = productos;

            // Configurar las columnas manualmente
            dgvpoductos.Columns.Clear();

            DataGridViewTextBoxColumn codigoColumn = new DataGridViewTextBoxColumn();
            codigoColumn.DataPropertyName = "CODIGO";
            codigoColumn.HeaderText = "Código";
            dgvpoductos.Columns.Add(codigoColumn);

            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "PRODUCTO";
            nombreColumn.HeaderText = "Producto";
            dgvpoductos.Columns.Add(nombreColumn);

            DataGridViewTextBoxColumn precioColumn = new DataGridViewTextBoxColumn();
            precioColumn.DataPropertyName = "PRECIO";
            precioColumn.HeaderText = "Precio Unitario";
            dgvpoductos.Columns.Add(precioColumn);

            DataGridViewTextBoxColumn stockColumn = new DataGridViewTextBoxColumn();
            stockColumn.DataPropertyName = "STOCK";
            stockColumn.HeaderText = "Stock";
            dgvpoductos.Columns.Add(stockColumn);
        }

        private void dgvpoductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow fila = dgvpoductos.Rows[e.RowIndex];
                ListadoProductos.idSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                ListadoProductos.ProductoSeleccionado = fila.Cells[1].Value.ToString()!;
                ListadoProductos.PrecioSeleccionado = Convert.ToDecimal(fila.Cells[2].Value);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
