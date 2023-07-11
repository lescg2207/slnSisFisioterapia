using capaDatos;
using capaNegocios;
using entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace capaPresentacion
{
    public partial class Frmtreeview : Form
    {
        //private string gestor;
        //private string conexion;
        private PacienteBll pacBll;
        private ServicioBll servBll;
        private DescuentoBll descBll;
        private string gestor;
        private string conexion;

        public Frmtreeview(string ges, string conex)
        {
            this.gestor = ges;
            this.conexion = conex;
            InitializeComponent();
            pacBll = new PacienteBll(ges, conex);
            servBll = new ServicioBll(ges, conex);
            descBll = new DescuentoBll(ges, conex);
            CargarDatosTreeView(tPac);
            Mostrarcombopadre();
        }

        public void CargarDatosTreeView(System.Windows.Forms.TreeView treeView)
        {

            // Crear listas de nodos para servicios y descuentos
            List<TreeNode> nodosServicios = new List<TreeNode>();
            List<TreeNode> nodosDescuentos = new List<TreeNode>();
            List<TreeNode> nodosiMPUESTO = new List<TreeNode>();

            // Obtener servicios y descuentos
            List<ServicioSesiones> servicios = servBll.ObtenerTreeNodes();
            List<Descuento> descuentos = descBll.ObtenerDescuentos();
            List<Impuesto> impuesto = descBll.ObtenerImpuesto();

            // Crear el nodo "Paquete"
            TreeNode paqueteNode = new TreeNode("Paquete");

            // Obtener las sesiones del servicio "Paquete" y agregarlas como subnodos
            var sesionesPaquete = servicios.Where(servicio => servicio.SERVICIO == "Paquete");

            foreach (var sesion in sesionesPaquete)
            {
                TreeNode sesionNode = new TreeNode($"Sesiones: {sesion.SESIONES}");
                TreeNode precioNode = new TreeNode($"Precio: {sesion.PRECIO}");

                sesionNode.Nodes.Add(precioNode);
                paqueteNode.Nodes.Add(sesionNode);
            }

            nodosServicios.Add(paqueteNode);

            foreach (var servicio in servicios)
            {
                if (servicio.SERVICIO != "Paquete")
                {
                    TreeNode servicioNode = new TreeNode(servicio.SERVICIO);

                    if (servicios.IndexOf(servicio) < 2)
                    {
                        TreeNode precioNodeS = new TreeNode($"Precio: {servicio.PRECIOServ}");
                        servicioNode.Nodes.Add(precioNodeS);
                    }
                    else
                    {
                        TreeNode sesionesNode = new TreeNode($"Sesiones: {servicio.SESIONES}");
                        TreeNode precioNode = new TreeNode($"Precio: {servicio.PRECIO}");

                        servicioNode.Nodes.Add(sesionesNode);
                        servicioNode.Nodes.Add(precioNode);
                    }

                    nodosServicios.Add(servicioNode);
                }
            }

            foreach (var descuento in descuentos)
            {
                TreeNode nombreNode = new TreeNode(descuento.nombreDescuento);
                TreeNode valorNode = new TreeNode($"Valor: {descuento.valorDescuento}");

                nombreNode.Nodes.Add(valorNode);
                nodosDescuentos.Add(nombreNode);
            }
            foreach (var impuestos in impuesto)
            {
                TreeNode nombreNode = new TreeNode(impuestos.impuesto);
                TreeNode valorNode = new TreeNode($"Valor: {impuestos.porcentaje}");

                nombreNode.Nodes.Add(valorNode);
                nodosiMPUESTO.Add(nombreNode);
            }

            // Limpiar el TreeView
            treeView.Nodes.Clear();

            // Construir la estructura del TreeView agregando los nodos padres y sus respectivos nodos hijos
            TreeNode nodoPadreserv = new TreeNode("Servicios", nodosServicios.ToArray());
            TreeNode rootNode = new TreeNode("Descuentos", nodosDescuentos.ToArray());
            TreeNode rootNodeImpu = new TreeNode("Impuesto", nodosiMPUESTO.ToArray());

            // Agregar los nodos padres al TreeView
            treeView.Nodes.Add(nodoPadreserv);
            treeView.Nodes.Add(rootNode);
            treeView.Nodes.Add(rootNodeImpu);
        }

        private void tPac_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void Mostrarcombopadre()
        {
            comboBox1.Items.AddRange(new string[] { "Seleccione", "Servicios", "Descuentos", "Productos" ,"Impuesto"});
            comboBox1.SelectedIndex = 0;
        }

        private void Mostrarcombohijo()
        {
            // Obtener la opción seleccionada del primer ComboBox
            string opcionSeleccionada = comboBox1.SelectedItem.ToString()!;

            // Limpiar el segundo ComboBox
            comboBox2.Items.Clear();

            List<ServicioSesiones> servicios = servBll.ObtenerTreeNodes();
            List<Descuento> descuentos = descBll.ObtenerDescuentos();
            List<Impuesto> impuestos = descBll.ObtenerImpuesto();

            bool paqueteAgregado = false; // Variable para controlar si se ha agregado el elemento "Paquete"

            // Cargar los datos correspondientes en el segundo ComboBox según la opción seleccionada
            foreach (var servicio in servicios)
            {
                if (opcionSeleccionada == "Servicios")
                {
                    if (servicio.SERVICIO == "Paquete")
                    {
                        if (!paqueteAgregado)
                        {
                            comboBox2.Items.Add($"{servicio.SERVICIO}");
                            paqueteAgregado = true; // Marcar el elemento "Paquete" como agregado
                            btnactualizar.Text = "Actualizar"; btnactualizar.Enabled = false; btnagregar.Text = "Agregar";
                            textBox1.Enabled = false;
                            textBox1.Text = string.Empty;
                            textBox2.Enabled = false;
                            textBox2.Text = string.Empty;
                            lbl1.Visible = false;
                            lbl2.Visible = false;
                            comboBox3.Items.Clear();
                        }
                    }
                    else
                    {
                        comboBox2.Items.Add($"{servicio.SERVICIO}");
                    }
                }
            }

            foreach (var descuento in descuentos)
            {
                if (opcionSeleccionada == "Descuentos")
                {
                    comboBox2.Items.Add($"{descuento.nombreDescuento}");
                    btnagregar.Enabled = true; btnagregar.Text = "Agregar Descuento";
                    btnactualizar.Enabled = false;
                    textBox1.Enabled = true; textBox1.Text = string.Empty;
                    textBox2.Enabled = true; textBox2.Text = string.Empty;
                    lbl1.Visible = true; lbl1.Text = ": Agregue aqui el nombre del Descuento";
                    lbl2.Visible = true; lbl2.Text = ": Agregue aqui el valor del Descuento";
                }



                else if (opcionSeleccionada == "Selecciones")
                {
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    label1.Visible = false; label2.Visible = false;
                    textBox1.Text = string.Empty; textBox2.Text = string.Empty;
                    btnagregar.Text = "Agregar"; btnagregar.Enabled = false;
                    btnactualizar.Text = "Actualizar"; btnactualizar.Enabled = false;

                }
            }
            foreach (var impuesto in impuestos)
            {
                if (opcionSeleccionada == "Impuesto")
                {
                    comboBox2.Items.Add($"{impuesto.impuesto}");
                    btnagregar.Enabled = true; btnagregar.Text = "Agregar Impuesto";
                    btnactualizar.Enabled = false;
                    textBox1.Enabled = true; textBox1.Text = string.Empty;
                    textBox2.Enabled = true; textBox2.Text = string.Empty;
                    lbl1.Visible = true; lbl1.Text = ": Agregue aqui el nombre del Impuesto";
                    lbl2.Visible = true; lbl2.Text = ": Agregue aqui el valor del Impuesto";
                }



                else if (opcionSeleccionada == "Selecciones")
                {
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    label1.Visible = false; label2.Visible = false;
                    textBox1.Text = string.Empty; textBox2.Text = string.Empty;
                    btnagregar.Text = "Agregar"; btnagregar.Enabled = false;
                    btnactualizar.Text = "Actualizar"; btnactualizar.Enabled = false;

                }
            }

        }

        private void Mostrarcombohijito()
        {

            // Obtener la opción seleccionada del primer ComboBox
            string opcionSeleccionada = comboBox2.SelectedItem.ToString()!;

            // Limpiar el segundo ComboBox
            comboBox3.Items.Clear();

            List<ServicioSesiones> servicios = servBll.ObtenerTreeNodes();
            List<Descuento> descuentos = descBll.ObtenerDescuentos();

            List<Impuesto> impuestos = descBll.ObtenerImpuesto();

            // Cargar el precio correspondiente a "Diario" en el TextBox
            if (opcionSeleccionada == "Diario")
            {
                // Buscar el servicio correspondiente a "Diario"
                var servicioDiario = servicios.FirstOrDefault(servicio => servicio.SERVICIO == "Diario");

                if (servicioDiario != null)
                {
                    textBox1.Enabled = true;
                    btnagregar.Enabled = false;
                    textBox1.Text = servicioDiario.PRECIOServ.ToString();
                    btnactualizar.Enabled = true; btnactualizar.Text = "Actualizar Servicio";
                    lbl1.Visible = true; lbl2.Visible = false;
                    lbl1.Text = ": Actualice aqui el Costo del Servicio";
                    textBox2.Enabled = false; textBox2.Text = string.Empty;
                }
            }
            else if (opcionSeleccionada == "Domiciliario")
            {
                // Buscar el servicio correspondiente a "Diario"
                var servicioDomiciliario = servicios.FirstOrDefault(servicio => servicio.SERVICIO == "Domiciliario");

                if (servicioDomiciliario != null)
                {
                    textBox1.Enabled = true;
                    btnagregar.Enabled = false;
                    textBox1.Text = servicioDomiciliario.PRECIOServ.ToString();
                    btnactualizar.Enabled = true; btnactualizar.Text = "Actualizar Servicio";
                    lbl1.Visible = true; lbl2.Visible = false;
                    lbl1.Text = ": Actualice aqui el Costo del Servicio";
                    textBox2.Enabled = false; textBox2.Text = string.Empty;
                }
            }
            else if (opcionSeleccionada == "Paquete")
            {
                var serviciosPaquete = servicios.Where(servicio => servicio.SERVICIO == "Paquete");

                foreach (var servicio in serviciosPaquete)
                {
                    comboBox3.Items.Add($"{servicio.SESIONES}");
                    btnagregar.Enabled = true; btnagregar.Text = "Agregar Paquete";
                    btnactualizar.Enabled = false;
                    textBox1.Text = string.Empty; textBox1.Enabled = true;
                    textBox2.Text = string.Empty; textBox2.Enabled = true;
                    lbl1.Visible = true;
                    lbl1.Text = ": Agregue aqui el numero de Sesiones del Paquete Nuevo";
                    lbl2.Visible = true;
                    lbl2.Text = ": Agregue aqui el costo total del Paquete Nuevo";
                }
            }
            foreach (var descuento in descuentos)
            {
                if (descuento.nombreDescuento == opcionSeleccionada)
                {
                    textBox1.Text = ($"{descuento.valorDescuento}");
                    btnactualizar.Enabled = true; btnactualizar.Text = "Actualizar Descuento";
                    btnagregar.Enabled = false;
                    textBox2.Enabled = false; textBox2.Text = string.Empty;
                    lbl1.Visible = true; lbl1.Text = ": Actualice el Descuento";
                    lbl2.Visible = false;
                }
            }
            foreach (var impuesto in impuestos)
            {
                if (impuesto.impuesto == opcionSeleccionada)
                {
                    textBox1.Text = ($"{impuesto.porcentaje}");
                    btnactualizar.Enabled = true; btnactualizar.Text = "Actualizar Impuesto";
                    btnagregar.Enabled = false;
                    textBox2.Enabled = false; textBox2.Text = string.Empty;
                    lbl1.Visible = true; lbl1.Text = ": Actualice el Impuesto";
                    lbl2.Visible = false;
                }
            }
        }
        private void AgregarDescuento()
        {
            string nombreDescuento = textBox1.Text;
            decimal valorDescuento = decimal.Parse(textBox2.Text);

            // Crear una instancia de la clase Descuento y asignar los valores
            Descuento nuevoDescuento = new Descuento
            {
                nombreDescuento = nombreDescuento,
                valorDescuento = valorDescuento
            };

            // Llamar al método en tu capa de acceso a datos para agregar el descuento
            descBll.AgregarDescuento(nuevoDescuento);

            // Mostrar un mensaje de éxito o realizar cualquier otra acción necesaria
            MostrarLabelPorUnTiempo();
            label1.Text = "EL DESCUENTO AÑADIDO SE APLICARA GLOBALMENTE.";
        }

        private void AgregarServicio()
        {
            // Obtener los valores de los campos de entrada
            string servicio = comboBox2.SelectedItem.ToString()!;
            string sesiones = textBox1.Text;
            string precio = textBox2.Text;

            // Crear una instancia de la entidad ServicioSesiones y asignar los valores
            ServicioSesiones servicioSesiones = new ServicioSesiones
            {
                SERVICIO = servicio,
                SESIONES = sesiones,
                PRECIO = precio
            };

            // Llamar al método en tu capa de negocios para agregar el servicio
            servBll.AgregarServicio(servicioSesiones);

            // Mostrar un mensaje de éxito o realizar cualquier otra acción necesaria
            MostrarLabelPorUnTiempo();
            label1.Text = "EL SERVICIO AÑADIDO SE APLICARA GLOBALMENTE.";


        }

        private void AgregarImpuesto()
        {
            string nombreImpuesto = textBox1.Text;
            decimal valorImpuesto = decimal.Parse(textBox2.Text);

            // Crear una instancia de la clase Descuento y asignar los valores
            Impuesto nuevoImpuesto = new Impuesto
            {
                impuesto = nombreImpuesto,
                porcentaje = valorImpuesto
            };

            // Llamar al método en tu capa de acceso a datos para agregar el descuento
            descBll.AgregarImpuesto(nuevoImpuesto);

            // Mostrar un mensaje de éxito o realizar cualquier otra acción necesaria
            MostrarLabelPorUnTiempo();
            label1.Text = "EL IMPUESTO AÑADIDO SE APLICARA GLOBALMENTE.";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrarcombohijo();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrarcombohijito();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ServicioSesiones> servicios = servBll.ObtenerTreeNodes();
            string sesionSeleccionada = comboBox3.SelectedItem.ToString()!;

            // Itera sobre la lista de objetos ServicioSesiones y encuentra los precios correspondientes
            foreach (var servicio in servicios)
            {
                if (servicio.SESIONES == sesionSeleccionada)
                {
                    textBox2.Text = ($"{servicio.PRECIO}");
                    textBox1.Text = string.Empty;
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                    lbl1.Visible = false;
                    lbl2.Text = ": Actualice aqui el costo de la Sesion";
                    btnagregar.Enabled = false;
                    btnactualizar.Enabled = true; btnactualizar.Text = "Actualizar Paquete";
                }
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            if (btnactualizar.Text == "Actualizar Descuento")
            {
                var descuento = new Descuento
                {
                    nombreDescuento = comboBox2.SelectedItem.ToString()!,
                    valorDescuento = Convert.ToDecimal(textBox1.Text)
                };
                descBll.ActualizarDescuento(descuento);
                MostrarLabelPorUnTiempo();
                label1.Text = "EL VALOR DEL DESCUENTO SE ACTUALIZARA GLOBALMENTE.";
                CargarDatosTreeView(tPac);
            }
            else if (btnactualizar.Text == "Actualizar Paquete")
            {
                if (int.TryParse(comboBox3.SelectedItem.ToString(), out int sesionesSeleccionadas))
                {
                    var sesionesActualizadas = new Sesiones
                    {
                        sesiones = sesionesSeleccionadas,
                        precio = Convert.ToDecimal(textBox2.Text)
                    };

                    servBll.ActualizarCostoSesiones(sesionesActualizadas);
                    MostrarLabelPorUnTiempo();
                    label1.Text = "EL COSTO DE LA SESION SE ACTUALIZÓ GLOBALMENTE.";
                    CargarDatosTreeView(tPac);
                }
                else
                {
                    MostrarLabelPorUnTiempo();
                    MessageBox.Show("EL NUMERO DE LAS SESIONES SELECCIONADA NO ES VALIDO.");
                }
            }
            else if (btnactualizar.Text == "Actualizar Servicio")
            {
                string nombreServicio = comboBox2.SelectedItem.ToString()!;
                if (decimal.TryParse(textBox1.Text, out decimal nuevoPrecio))
                {
                    servBll.ActualizarCostoServicio(nombreServicio, nuevoPrecio);
                    MostrarLabelPorUnTiempo();
                    label1.Text = "EL COSTO DEL SERVICIO SE ACTUALIZÓ GLOBALMENTE.";
                    CargarDatosTreeView(tPac);
                }
                else
                {
                    MostrarLabelPorUnTiempo();
                    label1.Text = "ASEGÚRATE DE INGRESAR UN NUMERO DECIMAL VALIDO";
                }
            }else if (btnactualizar.Text == "Actualizar Impuesto")
            {
                var impuesto = new Impuesto
                {
                    impuesto = comboBox2.SelectedItem.ToString()!,
                    porcentaje = Convert.ToDecimal(textBox1.Text)
                };
                descBll.ActualizarImpuesto(impuesto);
                MostrarLabelPorUnTiempo();
                label1.Text = "EL VALOR DEL IMPUESTO SE ACTUALIZARA GLOBALMENTE.";
                CargarDatosTreeView(tPac);
            }
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Agregar Descuento")
            {
                AgregarDescuento();
            }
            else if (btnagregar.Text == "Agregar Paquete")
            {
                AgregarServicio();
            }else if(btnagregar.Text=="Agregar Impuesto")
            { 
                AgregarImpuesto();
            }

            CargarDatosTreeView(tPac);
        }


        //
        private void MostrarLabelPorUnTiempo()
        {
            label1.Visible = true;
            timer1.Start();
        }

        private void OcultarLabel()
        {
            label1.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            OcultarLabel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            OcultarLabel();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarDatosTreeView(tPac);
            comboBox1.SelectionStart = 0;
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            lbl1.Visible = false; lbl2.Visible = false;
            textBox1.Text = string.Empty; textBox2.Text = string.Empty;
            textBox1.Enabled = false; textBox2.Enabled = false;
            btnagregar.Text = "Agregar"; btnagregar.Enabled = false;
            btnactualizar.Text = "Actualizar"; btnactualizar.Enabled = false;

        }
    }
}
