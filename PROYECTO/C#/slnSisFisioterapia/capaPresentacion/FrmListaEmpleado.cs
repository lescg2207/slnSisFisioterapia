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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace capaPresentacion
{
    public partial class FrmListaEmpleado : Form
    {
        private EmpleadoBll _empleadoBll;
        public FrmListaEmpleado(string gest, string con)
        {
            _empleadoBll = new EmpleadoBll(gest, con);
            InitializeComponent();
            ListarEmpleado();
            cbxBuscar.SelectedIndex = 0;
            ListarCargo();
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
            btnAgregar.Enabled = true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Usuario = txtusuarios.Text,
                Contraseña = txtxContraseña.Text,
                IdCargo = int.Parse(cbxCargo.SelectedValue.ToString()!),
            };

            _empleadoBll.InsertarEmpleado(empleado);
            Limpiar();
            MessageBox.Show("Empleado agregado");
            ListarEmpleado();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //txtNombre.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
            txtusuarios.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
            txtxContraseña.Text = dgvEmpleado.CurrentRow.Cells[6].Value.ToString();
            cbxCargo.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
            btnAgregar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
            ListarEmpleado();
            txtNombre.Focus();


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
    }
}
