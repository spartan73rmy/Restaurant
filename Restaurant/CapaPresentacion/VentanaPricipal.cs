using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Clientes;
using CapaPresentacion.Comanda;
using CapaPresentacion.Mesas;
using CapaPresentacion.Trabajadores;
using CapaPresentacion.Productos;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Reporte;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using CapaPresentacion.Utilerias;

namespace CapaPresentacion
{
    public partial class VentanaPricipal : MaterialForm
    {

        private Trabajador trabajador;
        private bool firstTime;
        public VentanaPricipal(Trabajador trabajador)
        {
            firstTime = true;
            this.trabajador = trabajador;
            var asForm = System.Windows.Automation.AutomationElement.FromHandle(this.Handle);

            InitializeComponent();
            ScrollIni();
            MaterialSkinManager.AddFormToManage(this);
            MaximizeWindow(true);

            Permiso();
        }

        private void Permiso()
        {
            if (trabajador != null)
            {

                switch (trabajador.Puesto.nombre_puesto)
                {
                    case "Cajero":
                        //Falta Implementar
                        break;
                    case "Administrador":
                        //All is permitted
                        break;
                    case "Mesero":
                        ControlesPropios.Tarjeta[] v ={ tarjetaMesas ,tarjetaTrabajadores,
                        tarjetaProductos,tarjetaCliente1,tarjetaCliente2,tarjetaReporte};

                        DesactivarTarjetas(v);
                        break;
                    case "Cocinero":
                        ControlesPropios.Tarjeta[] vc ={ tarjetaMesas ,tarjetaTrabajadores,
                        tarjetaCliente1,tarjetaCliente2,tarjetaReporte};

                        DesactivarTarjetas(vc);
                        break;
                }
            }
        }
        private void DesactivarTarjetas(ControlesPropios.Tarjeta[] v)
        {
            foreach (var item in v)
            {
                item.Visible = false;
            }
        }

        private void ScrollIni()
        {

            contenedorTarjetas.AutoScroll = false;
            contenedorTarjetas.HorizontalScroll.Visible = false;
            contenedorTarjetas.HorizontalScroll.Enabled = false;
            contenedorTarjetas.HorizontalScroll.Maximum = 0;
            contenedorTarjetas.AutoScroll = true;
        }

        private void tarjetaProductos_Click(object sender, EventArgs e)
        {
            List<CategoriaProducto> categorias = ControlCategorias.Instance.GetLista();
            if (categorias == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            using (ProductosFrm productos = new ProductosFrm(Maximized, categorias))
                productos.ShowDialog(this);
        }

        private void tarjetaMesas_Click(object sender, EventArgs e)
        {
            var listaMesas = ControlMesas.Instance.GetLista();
            if (listaMesas == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            using (MesasFrm mesas = new MesasFrm(Maximized, listaMesas))
                mesas.ShowDialog(this);
        }

        private void tarjetaTrabajador_Click(object sender, EventArgs e)
        {
            using (TrabajadorFrm trabajador = new TrabajadorFrm(Maximized, ControlTrabajadores.Instance.GetLista()))
                trabajador.ShowDialog(this);
        }



        private void tarjeta2_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = ControlClientes.Instance.GetLista();
            if (clientes == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            using (ClienteForm clienteFrm = new ClienteForm(Maximized, clientes))
            {
                clienteFrm.ShowDialog(this);
            }
        }

        private void Clientes2_MouseClick(object sender, MouseEventArgs e)
        {
            List<Cliente> clientes = ControlClientes.Instance.GetLista();
            if (clientes == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            using (ClienteForm2 clienteFrm = new ClienteForm2(Maximized, clientes))
            {
                clienteFrm.ShowDialog(this);
            }
        }

        private void tarjetaComanda_Click(object sender, EventArgs e)
        {
            using (ComandaFrm comanda = new ComandaFrm(Maximized))
            {
                comanda.ShowDialog(this);
            }
        }

        private void VentanaPricipal_Load(object sender, EventArgs e)
        {
            opciones.quitButtons();
            //Argumentos(Texto a mostrar, Icono a mostrar, Evento o que el control al hacer clik en él)
            opciones.AgregarOpcion("Salir", Properties.Resources.F_baseline_clear_white_18,
                new MouseEventHandler((o, args) =>
                {
                    this.Close();
                }));

            opciones.AgregarOpcion("Configuracion", Properties.Resources.F_B_baseline_weekend_black_48,
                new MouseEventHandler((o, args) =>
                {
                    using (CapaPresentacion.Configuracion.Configuracion config = new CapaPresentacion.Configuracion.Configuracion(true))
                    {
                        config.ShowDialog(this);
                    }
                }));
        }


        private void tarjetaReporte_Click(object sender, EventArgs e)
        {
            using (CorteCaja reporte = new CorteCaja(true))
            {
                reporte.ShowDialog(this);
            }
            return;
            using (ReporteFrm reporte = new ReporteFrm(true))
            {
                reporte.ShowDialog(this);
            }
        }


        private void tarjetaReporte_Load(object sender, EventArgs e)
        {

        }

        public class OrdenProductoSerializable : IComparable<OrdenProductoSerializable>
        {
            public int Id_orden { get; set; }
            public int Id_orden_producto { get; set; }
            public int Id_tipo_producto { get; set; }
            public int Id_categoria { get; set; }
            public string Nombre_producto { get; set; }
            public string Nombre_tipo { get; set; }
            public string Categoria { get; set; }
            public int Cantidad { get; set; }
            public string Comentarios { get; set; }
            public string Mesa { get; set; }
            public decimal Precio { get; set; }
            public string Status { get; set; }
            public List<VarianteSerializable> Variantes { get; set; }



            public static OrdenProductoSerializable FromOrdenProducto(OrdenProducto op)
            {
                return new OrdenProductoSerializable()
                {
                    Id_orden = op.id_orden,
                    Id_orden_producto = op.id_orden_producto,
                    Id_tipo_producto = (int)op.id_tipo_producto,
                    Nombre_producto = op.TipoProducto.Producto.nombre_producto,
                    Nombre_tipo = op.TipoProducto.nombre_tipo,
                    Cantidad = op.cantidad,
                    Id_categoria = op.TipoProducto.Producto.id_categoria,
                    Comentarios = op.comentarios,
                    Precio = op.precio,
                    Status = op.status,
                    Mesa = op.Orden.Mesa.nombre_mesa,
                    Categoria = op.TipoProducto.Producto.CategoriaProducto.nombre_categoria,
                    Variantes = VarianteSerializable.FromListVariantes(op.ProductoVariante)
                };
            }

            public int CompareTo(OrdenProductoSerializable other)
            {
                return Id_orden_producto - other.Id_orden_producto;
            }

            public override bool Equals(object obj)
            {
                var serializable = obj as OrdenProductoSerializable;
                return serializable != null &&
                       Id_orden_producto == serializable.Id_orden_producto;
            }

            public override string ToString()
            {
                return Categoria + " " + Nombre_producto + " " + Nombre_tipo;
            }
        }
        public class VarianteSerializable
        {
            public string Nombre { get; set; }
            public static List<VarianteSerializable> FromListVariantes(ICollection<ProductoVariante> productoVariante)
            {
                List<VarianteSerializable> lista = new List<VarianteSerializable>();

                foreach (ProductoVariante pv in productoVariante)
                {
                    lista.Add(new VarianteSerializable() { Nombre = pv.nombre_variante });
                }
                return lista;
            }
        }

        private void limpiarOrdenesEliminadas(List<OrdenProductoSerializable> lista, List<Orden> ordenesActivas)
        {
            List<OrdenProductoSerializable> toDelete = new List<OrdenProductoSerializable>();
            foreach (OrdenProductoSerializable ops in lista)
            {
                if (!(ordenesActivas.Any(prod => prod.id_orden == ops.Id_orden)))
                {
                    toDelete.Add(ops);
                }
            }
            foreach (OrdenProductoSerializable del in toDelete)
            {
                OrdenProductoSerializable elem = lista.Find(op => op.Id_orden == del.Id_orden);
                lista.Remove(elem);
            }
        }


        private List<OrdenProductoSerializable> ordenesNuevas(List<OrdenProductoSerializable> viejas, List<OrdenProductoSerializable> nuevas)
        {
            return nuevas.Where(p => !viejas.Any(p2 => p2.Id_orden_producto == p.Id_orden_producto)).ToList();
        }

        private List<OrdenProductoSerializable> ordenesEliminadas(List<OrdenProductoSerializable> viejas, List<OrdenProductoSerializable> nuevas)
        {
            return viejas.Where(p => !nuevas.Any(p2 => p2.Id_orden_producto == p.Id_orden_producto)).ToList();
        }
        private List<OrdenProductoSerializable> ordenesEditadas(List<OrdenProductoSerializable> eliminadas, List<OrdenProductoSerializable> agregadas)
        {
            List<OrdenProductoSerializable> editadas = new List<OrdenProductoSerializable>();

            List<OrdenProductoSerializable> toDeleteEliminadas = new List<OrdenProductoSerializable>();
            List<OrdenProductoSerializable> toDeleteAgregadas = new List<OrdenProductoSerializable>();

            foreach (OrdenProductoSerializable productoEliminado in eliminadas)
            {
                foreach (OrdenProductoSerializable productoAgregado in agregadas)
                {
                    if (productoEliminado.Id_orden == productoAgregado.Id_orden && productoEliminado.Nombre_producto == productoAgregado.Nombre_producto)
                    {
                        toDeleteEliminadas.Add(productoEliminado);
                        toDeleteAgregadas.Add(productoAgregado);
                        editadas.Add(productoAgregado);
                        break;
                    }
                }
            }

            foreach (OrdenProductoSerializable producto in toDeleteAgregadas)
            {
                agregadas.Remove(producto);
            }

            foreach (OrdenProductoSerializable producto in toDeleteEliminadas)
            {
                eliminadas.Remove(producto);
            }
            return editadas;
        }


        private bool actualizando = false;
        private void timerActualizar_Tick(object sender, EventArgs e)
        {
            if (actualizando) return; // Si sigue actualizando retorna
            actualizando = true;
            Console.WriteLine("Aqui");

            // Obtiene todas las ordenes activas y comprueba errores
            List<Orden> ordenesActivas = ControlOrdenes.Instance.GetLista();
            if (ordenesActivas == null)
            {
                MessageBox.Show("Comprueba tu conexion");
                actualizando = false;
                return;
            }
            // Path para el archivo donde se guardan los pedidos activos
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Restaurant";
            string file = path + "\\PedidosActivos.json";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                if (!File.Exists(file))
                {
                    File.WriteAllText(file, "[]");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el fichero");
                actualizando = false;
                return;
            }

            try
            {
                // SE cargan todas las pedidos previas
                string ordenesViejas = File.ReadAllText(file);
                List<OrdenProductoSerializable> listVieja = JsonConvert.DeserializeObject<List<OrdenProductoSerializable>>(ordenesViejas);
                // Se limpian los pedidos que ya no se necesitan
                limpiarOrdenesEliminadas(listVieja, ordenesActivas);

                // Se cargan todos los pedidos actuales y se crean los objetos serializables de estos
                List<OrdenProducto> lista = ControlOrdenProductos.Instance.GetLista();

                List<OrdenProductoSerializable> list2 = new List<OrdenProductoSerializable>();
                foreach (OrdenProducto op in lista)
                {
                    OrdenProductoSerializable s = OrdenProductoSerializable.FromOrdenProducto(op);
                    list2.Add(s);
                }

                // Sew guardan los nuevos pedidos
                File.WriteAllText(file, JsonConvert.SerializeObject(list2));


                // Pedidos eliminado, nuevos y editados
                List<OrdenProductoSerializable> nuevas = ordenesNuevas(listVieja, list2);
                List<OrdenProductoSerializable> eliminadas = ordenesEliminadas(listVieja, list2);
                List<OrdenProductoSerializable> editadas = ordenesEditadas(eliminadas, nuevas);

                // Si existen pedidos pendientes
                if (eliminadas.Count > 0 || nuevas.Count > 0 || editadas.Count > 0)
                {
                    // Si es la primer vez que se entra al metodo se pergunta si se quiere imprimir los pendientes
                    if (firstTime)
                    {
                        DialogResult result = MessageBox.Show(this, "Existen ordenes pendientes, Imprimir?", "Advertencia", MessageBoxButtons.YesNo);
                        firstTime = false;
                        if (result != DialogResult.Yes)
                        {
                            actualizando = false;
                            return;
                        };

                    }

                    // Se carga la configuracion de las categorias que se dean imprimir
                    string configFile = path + "\\Impresiones.config";
                    List<CategoriaProducto> categoriasParaImprimir = JsonConvert.DeserializeObject<List<CategoriaProducto>>(File.ReadAllText(configFile));
                    List<Orden> ordenesActivas2 = ControlOrdenes.Instance.GetLista();

                    // Se imprime si es necesario
                    foreach (OrdenProductoSerializable nueva in nuevas)
                    {
                        Console.WriteLine("Se ha agregado " + nueva);
                        if (categoriasParaImprimir.Any(cpi => cpi.id_categoria == nueva.Id_categoria))
                        {
                            if (ordenesActivas2.Where(oa => oa.id_orden == nueva.Id_orden).ToList().Count > 0)
                                imprimirTicketNuevo(nueva);
                        }

                    }
                    foreach (OrdenProductoSerializable nueva in eliminadas)
                    {
                        Console.WriteLine("Se ha eliminado " + nueva);
                        if (categoriasParaImprimir.Any(cpi => cpi.id_categoria == nueva.Id_categoria))
                            if (ordenesActivas2.Where(oa => oa.id_orden == nueva.Id_orden).ToList().Count > 0)
                                imprimirTicketEliminado(nueva);
                    }

                    foreach (OrdenProductoSerializable nueva in editadas)
                    {
                        OrdenProductoSerializable viejo = listVieja.Find(ops => ops.Id_orden_producto == nueva.Id_orden_producto - 1);
                        Console.WriteLine("Se ha editado " + nueva);
                        if (categoriasParaImprimir.Any(cpi => cpi.id_categoria == nueva.Id_categoria))
                        {
                            if (ordenesActivas2.Where(oa => oa.id_orden == nueva.Id_orden).ToList().Count > 0)
                                imprimirTicketEditado(viejo, nueva);
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                try
                {
                    File.WriteAllText(file, "[]");
                }
                catch { }
                MessageBox.Show("Error desconocido");

            }

            firstTime = false;
            actualizando = false;
        }

        private void imprimirTicketEditado(OrdenProductoSerializable viejo, OrdenProductoSerializable nueva)
        {
            Console.WriteLine("Imprimiendo ticket editado viejo " + viejo + " nuevo " + nueva);
            ImprimePedido ip = new ImprimePedido();
            ip.ImprimirEditado(viejo, nueva);
        }

        private void imprimirTicketEliminado(OrdenProductoSerializable nueva)
        {
            Console.WriteLine("Imprimiendo ticket eliminado " + nueva);
            ImprimePedido ip = new ImprimePedido();
            ip.ImprimirEliminado(nueva);
        }

        private void imprimirTicketNuevo(OrdenProductoSerializable nueva)
        {

            Console.WriteLine("Imprimiendo ticket nuevo " + nueva);
            ImprimePedido ip = new ImprimePedido();
            ip.ImprimirNuevo(nueva);
        }
    }

}
