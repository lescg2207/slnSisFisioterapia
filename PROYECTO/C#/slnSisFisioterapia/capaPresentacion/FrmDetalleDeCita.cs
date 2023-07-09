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
    public partial class FrmDetalleDeCita : Form
    {
        string gestor, conexion;
        private ProductosBll _productoBll;
        decimal subtotal2;
        public FrmDetalleDeCita(string get, string con)
        {
            this.gestor = get;
            this.conexion = con;
            _productoBll = new ProductosBll(get, con);
            InitializeComponent();
            this.Load += FrmDetalleDeCita_Load!;
            ListarProducto();
            subtotal2 = 100;
            lbltotalCita.Text = subtotal2.ToString();


        }
        private void FrmDetalleDeCita_Load(object sender, EventArgs e)
        {
            if (ckbPruductos.Checked == false)
            {
                pProductos.Visible = false;
                dgvListaProductos.Rows.Clear();
                decimal total = 0;

                lbltotal.Text = total.ToString();
            }
            else
            {
                pProductos.Visible = true;
            }

        }

        private void ListarProducto()
        {
            /* List<ListaProductos> prod = _productoBll.ObtenerProductos();
             dgvListaProductos.DataSource = prod;

             DataGridViewTextBoxColumn columnaCantidad = new DataGridViewTextBoxColumn();
             columnaCantidad.HeaderText = "Cantidad";
             columnaCantidad.Name = "Cantidad";
             columnaCantidad.DefaultCellStyle.NullValue = "0"; // Valor por defecto de 0
             dgvListaProductos.Columns.Add(columnaCantidad);

             DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
             boton.HeaderText = "AGREGAR";
             boton.Name = "btnAgregar";
             boton.UseColumnTextForButtonValue = true;
             dgvListaProductos.Columns.Add(boton);

             DataGridViewButtonColumn boton2 = new DataGridViewButtonColumn();
             boton2.HeaderText = "QUITAR";
             boton2.Name = "btnQuitar";
             boton2.UseColumnTextForButtonValue = true;
             dgvListaProductos.Columns.Add(boton2);*/

            List<ListaProductos> prod = _productoBll.ObtenerProductos();

            // Asignar la lista de productos como origen de datos del ComboBox
            comboBoxProductos.DataSource = prod;
            comboBoxProductos.DisplayMember = "NOMBRE"; // Mostrar el nombre del producto en el ComboBox
            comboBoxProductos.ValueMember = "PRECIO"; // El precio del producto se utilizará para calcular el subtotal en el DataGridView

        }

        private void ckbPruductos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPruductos.Checked == false)
            {
                pProductos.Visible = false;
                dgvListaProductos.Rows.Clear();
                decimal total = 0;

                lbltotal.Text = total.ToString();
            }
            else
            {
                pProductos.Visible = true;
            }
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
             {
                 DataGridViewRow filaSeleccionada = dgvListaProductos.Rows[e.RowIndex];

                 int cantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);

                 if (dgvListaProductos.Columns[e.ColumnIndex].Name == "btnAgregar")
                 {
                     if (cantidad <= 0)
                     {
                         MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return; // Detener la operación si la cantidad es menor o igual a 0
                     }

                     // Obtener los datos necesarios de la fila seleccionada
                     int idProducto = Convert.ToInt32(filaSeleccionada.Cells["CODIGO"].Value);
                     decimal precioUnitario = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value);

                     // Calcular el subtotal
                     decimal subtotal = precioUnitario * cantidad;

                     // Insertar los datos en la tabla DetalleCita
                     // ... Aquí puedes usar el código para insertar los datos en la base de datos o en la capa de acceso a datos

                     // Actualizar el valor total en el formulario
                     decimal total = Convert.ToDecimal(lbltotal.Text) + subtotal;
                     lbltotal.Text = total.ToString();
                 }
                 else if (dgvListaProductos.Columns[e.ColumnIndex].Name == "btnQuitar")
                 {
                     // Verificar si el total es mayor a cero antes de quitar el producto
                     decimal total = Convert.ToDecimal(lbltotal.Text);
                     if (total <= 0)
                     {
                         MessageBox.Show("No se puede quitar un producto si el total es igual a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return; // Detener la operación si el total es igual o menor a 0
                     }

                     // Obtener los datos necesarios de la fila seleccionada
                     int idProducto = Convert.ToInt32(filaSeleccionada.Cells["CODIGO"].Value);
                     decimal precioUnitario = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value);

                     // Calcular el subtotal
                     decimal subtotal = precioUnitario * cantidad;

                     // Eliminar los datos de la tabla DetalleCita
                     // ... Aquí puedes usar el código para eliminar los datos de la base de datos o en la capa de acceso a datos

                     // Actualizar el valor total en el formulario
                     total -= subtotal;
                     lbltotal.Text = total.ToString();
                 }
             }*/

        }

        private void dgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal total;

            if (dgvListaProductos.RowCount > 0)
            {
                // Obtener el producto seleccionado del ComboBox
                ListaProductos productoSeleccionado = (ListaProductos)comboBoxProductos.SelectedItem;

                // Obtener la cantidad del TextBox
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                // Calcular el subtotal
                decimal subtotal = productoSeleccionado.PRECIO * cantidad;

                // Agregar la fila al DataGridView
                dgvListaProductos.Rows.Add(productoSeleccionado.NOMBRE, productoSeleccionado.PRECIO, cantidad, subtotal);

                // Calcular el total
                total = 0;
                foreach (DataGridViewRow fila in dgvListaProductos.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                }

                // Actualizar el total en el TextBox
                lbltotal.Text = total.ToString();

            }
            else
            {
                total = 0;
                lbltotal.Text = total.ToString();
            }
            decimal totalCita = total + 100;

            // Actualizar el valor en el TextBox
            lbltotalCita.Text = totalCita.ToString();
            // lbltotalCita.Text = lbltotal+ subtotal2.ToString();
        }
    }
}
