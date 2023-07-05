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
        private ServicioBll servBll;

        public Frmtreeview(string ges, string conex)
        {
            InitializeComponent();
            pacBll = new PacienteBll(ges, conex);
            servBll = new ServicioBll(ges, conex);
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

            List<ServicioSesiones> servicios = servBll.ObtenerTreeNodes();

            TreeNode nodoPadreserv = new TreeNode("Servicios");

            int contadorServicio = 0; // Variable para contar el número de servicios procesados

            foreach (var servicio in servicios)
            {
                TreeNode servicioNode = new TreeNode(servicio.SERVICIO);

                // Agregar nodo Precio para los primeros dos servicios
                if (contadorServicio < 2)
                {
                    TreeNode precioNodeS = new TreeNode($"Precio: {servicio.PRECIOServ}");
                    servicioNode.Nodes.Add(precioNodeS);
                }
                else
                {
                    // Agregar nodo Sesiones para todos los servicios, excepto los primeros dos
                    TreeNode sesionesNode = new TreeNode($"Sesiones: {servicio.SESIONES}");
                    servicioNode.Nodes.Add(sesionesNode);
                }



                // Agregar precio específico para el servicio "Paquetes"
                if (servicio.SERVICIO == "Paquete")
                {
                    // Agregar nodo Precio para todos los servicios
                    TreeNode precioNode = new TreeNode($"Precio: {servicio.PRECIO}");
                    servicioNode.Nodes.Add(precioNode);
                }
                else 
                {
                    TreeNode precioNode = new TreeNode($"Precio: {servicio.PRECIO}");
                    servicioNode.Nodes.Remove(precioNode);
                }

                nodoPadreserv.Nodes.Add(servicioNode);
                contadorServicio++;
            }

            treeView.Nodes.Add(nodoPadreserv);
        }
    }
    }
