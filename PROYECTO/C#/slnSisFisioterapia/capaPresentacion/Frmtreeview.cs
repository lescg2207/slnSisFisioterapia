using capaDatos;
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
    public partial class Frmtreeview : Form
    {
        //private string gestor;
        //private string conexion;
        private PacienteBll pacBll;

        public Frmtreeview(string ges, string conex)
        {
            InitializeComponent();
            pacBll = new PacienteBll(ges, conex);
            CargarDatosTreeView(tPac);
        }

        public void CargarDatosTreeView(TreeView treeView)
        {

            List<ListaPacienteHistoria> pacientes = pacBll.ObtenerListaPacientes();

            TreeNode nodoPadre = new TreeNode("Pacientes");

            foreach (var paciente in pacientes)
            {
                TreeNode pacienteNode = new TreeNode($"{paciente.NOMBRES} {paciente.APELLIDOS}");

                TreeNode historiaNode = new TreeNode($"Historia: {paciente.HISTORIA}");
                TreeNode dniNode = new TreeNode($"DNI: {paciente.DNI}");
                TreeNode direccionNode = new TreeNode($"Dirección: {paciente.DIRECCION}");
                // Agregar más nodos según tus necesidades

                pacienteNode.Nodes.Add(historiaNode);
                pacienteNode.Nodes.Add(dniNode);
                pacienteNode.Nodes.Add(direccionNode);
                // Agregar más nodos según tus necesidades

                nodoPadre.Nodes.Add(pacienteNode);
            }

            treeView.Nodes.Add(nodoPadre);
        }
    }
}
