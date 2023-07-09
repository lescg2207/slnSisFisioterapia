using capaNegocios;
using entidades;
using entidades.Vistas;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Microsoft.VisualBasic.Logging;
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
    public partial class FrmListaEmpleado : Form
    {
        private EmpleadoBll _empleadoBll;
        private string accion { get; set; } = null!;
        public FrmListaEmpleado(string gest, string con)
        {
            _empleadoBll = new EmpleadoBll(gest, con);
            InitializeComponent();
            cbxBuscar.SelectedIndex = 0;
            ListarCargo();
            ListarEmpleado();

            if (!dgvEmpleado.Columns.Contains("MODIFICAR"))
            {
                DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
                boton.HeaderText = "MODIFICAR";
                boton.Name = "btnModificar";
                boton.UseColumnTextForButtonValue = true;
                dgvEmpleado.Columns.Add(boton);
            }

            if (!dgvEmpleado.Columns.Contains("ELIMINAR"))
            {
                DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
                boton.HeaderText = "ELIMINAR";
                boton.Name = "btnEliminar";
                boton.UseColumnTextForButtonValue = true;
                dgvEmpleado.Columns.Add(boton);
            }

        }

        private void ListarEmpleado()
        {
            List<ListaEmpleadoCargo> emp = _empleadoBll.ListaEmpleadoCargo();
            dgvEmpleado.DataSource = emp;
            dgvEmpleado.Columns["CONTRASEÑA"].Visible = false;
            dgvEmpleado.Columns["IDCARGO"].Visible = false;


        }

        private void ListarCargo()
        {
            var tabla = _empleadoBll.ObtenerEmpleadoCargo();

            if (tabla.Count > 0)
            {
                cbxCargo.DataSource = tabla;
                cbxCargo.DisplayMember = "cargo";
                cbxCargo.ValueMember = "idCargo";
            }

        }

        private void cbxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscar.SelectedIndex == 1)
            {
                lbltitu.Text = "Ingrese cargo :";

            }
            else
            {
                lbltitu.Text = "Ingrese nombre :";

            }

        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtusuarios.Text = "";
            txtxContraseña.Text = "";
            cbxBuscar.SelectedIndex = 0;
            cbxCargo.SelectedIndex = 0;
            accion = "N";
            btnAgregar.Text = "AGREGAR";
        }
        private void AgregarEmpleado()
        {
            var empleado = new Empleado
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Usuario = txtusuarios.Text,
                Contraseña = txtxContraseña.Text,
                estadoEmp = true,
                IdCargo = int.Parse(cbxCargo.SelectedValue.ToString()!),
            };

            _empleadoBll.InsertarEmpleado(empleado);
            Limpiar();
            MessageBox.Show("Empleado agregado");
        }
        private void ActualizarEmpleado()
        {
            var empleado = new Empleado
            {
                IdEmpleado = int.Parse(lblId.Text),
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Usuario = txtusuarios.Text,
                Contraseña = txtxContraseña.Text,
                IdCargo = int.Parse(cbxCargo.SelectedValue.ToString()!),
            };
            _empleadoBll.ActualizarEmpleado(empleado);
            Limpiar();
            MessageBox.Show("Empleado actualizado");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (accion == "N")
            {
                AgregarEmpleado();

            }
            else if (accion == "U")
            {
                ActualizarEmpleado();

            }
            accion = "N";
            btnAgregar.Text = "AGREGAR";
            ListarEmpleado();
            txtNombre.Focus();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvEmpleado.Columns[e.ColumnIndex].Name == "btnModificar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    accion = "U";
                    lblId.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
                    txtNombre.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
                    txtApellidos.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
                    txtusuarios.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString();
                    txtxContraseña.Text = dgvEmpleado.CurrentRow.Cells[8].Value.ToString();
                    cbxCargo.Text = dgvEmpleado.CurrentRow.Cells[6].Value.ToString();
                    btnAgregar.Text = "MODIFICAR";

                }
            }
            else if (dgvEmpleado.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    int idEmpl = int.Parse(dgvEmpleado.CurrentRow.Cells[2].Value.ToString()!);
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        var empleado = new Empleado
                        {
                            IdEmpleado = idEmpl,
                            estadoEmp = false
                        };

                        _empleadoBll.EliminarEmpleado(empleado);
                        MessageBox.Show("Empleado eliminado");
                        ListarEmpleado();

                    }
                }

            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string valorBusqueda = txtbuscar.Text;

            if (string.IsNullOrWhiteSpace(valorBusqueda))
            {

                ListarEmpleado();
                return;
            }
            try
            {
                List<ListaEmpleadoCargo> pacientes = null!;
                switch (cbxBuscar.SelectedItem.ToString())
                {
                    case "NOMBRE":
                        pacientes = _empleadoBll.BuscarEmpleadoNombre(valorBusqueda);
                        break;
                    case "CARGO":
                        pacientes = _empleadoBll.BuscarEmpleadoCargo(valorBusqueda);
                        break;

                }
                dgvEmpleado.DataSource = pacientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los empledos: " + ex.Message);
            }
        }

        private void FrmListaEmpleado_Load(object sender, EventArgs e)
        {
            accion = "N";
            if (accion == "N")
            {
                btnAgregar.Text = "AGREGAR";
            }
        }

        public void GenerarReporteEmpleados()
        {
            List<ListaEmpleadoCargo> empleados = _empleadoBll.ListaEmpleadoCargo(); // Obtén la lista de empleados desde tu método existente

            // Crear un nuevo objeto ReportDataSource con los datos de empleados
            /* ReportDataSource rds = new ReportDataSource("DataSetEmpleados", empleados);

             // Limpiar el control ReportViewer
             reportViewer1.LocalReport.DataSources.Clear();

             // Asignar el objeto ReportDataSource al control ReportViewer
             reportViewer1.LocalReport.DataSources.Add(rds);

             // Establecer la ruta del archivo de diseño del informe (.rdlc)
             reportViewer1.LocalReport.ReportPath = "ruta_del_archivo_de_diseno_del_informe.rdlc";

             // Actualizar el informe en el control ReportViewer
             reportViewer1.RefreshReport();*/
        }

        private void dgvEmpleado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvEmpleado.Columns[e.ColumnIndex].Name == "btnEliminar" && e.RowIndex >= 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell? cellBoton = this.dgvEmpleado.Rows[e.RowIndex].Cells["btnEliminar"] as DataGridViewButtonCell;
                Icon icono = new Icon(Environment.CurrentDirectory + @"\\eliminar_b.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 30, e.CellBounds.Top + 3);

                this.dgvEmpleado.Rows[e.RowIndex].Height = icono.Height + 6;
                this.dgvEmpleado.Columns[e.ColumnIndex].Width = icono.Width + 60;

                e.Handled = true;


            }

            if (e.ColumnIndex >= 0 && this.dgvEmpleado.Columns[e.ColumnIndex].Name == "btnModificar" && e.RowIndex >= 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell? cellBoton = this.dgvEmpleado.Rows[e.RowIndex].Cells["btnModificar"] as DataGridViewButtonCell;
                Icon icono = new Icon(Environment.CurrentDirectory + @"\\editar.ico");
                e.Graphics.DrawIcon(icono, e.CellBounds.Left + 30, e.CellBounds.Top + 3);

                this.dgvEmpleado.Rows[e.RowIndex].Height = icono.Height + 6;
                this.dgvEmpleado.Columns[e.ColumnIndex].Width = icono.Width + 60;

                e.Handled = true;

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

                string paginahtml_texto = Properties.Resources.plantillaempl.ToString();
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;
                //decimal total = 0;
                foreach (DataGridViewRow row in dgvEmpleado.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["CODIGO"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["NOMBRE"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["APELLIDOS"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["USUARIO"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["CARGO"].Value.ToString() + "</td>";
                    filas += "<td>" + (Convert.ToBoolean(row.Cells["ESTADO"].Value) ? "Activo" : "Inactivo") + "</td>";
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
