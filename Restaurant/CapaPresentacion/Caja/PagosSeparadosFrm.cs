using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Caja
{
    public partial class PagosSeparadosFrm : MaterialForm
    {
        private Orden orden;
        // Indice 0 para restantes
        private List<List<ProductoOrdenUC>> cuentas;
        private int currentIndex = 0; // Indice de la persona actual
        public PagosSeparadosFrm(bool maximized, Orden orden)
        {
            this.cuentas = new List<List<ProductoOrdenUC>>();
            this.orden = orden;
            InitializeComponent();
            if (maximized)
                MaximizeWindow(maximized);
            MaterialSkinManager.AddFormToManage(this);



            // Agregar restantes
            cuentas.Add(new List<ProductoOrdenUC>()); // Restantes
            listPersonas.Items.Add("Restantes");
            opciones1.AgregarOpcion("Restantes", Properties.Resources.F_baseline_person_outline_white_18, new MouseEventHandler(
                (s, a) =>
                {
                    currentIndex = 0;
                    Actualiza();
                }
                ));
            // Restantes agregadas


            var listaProductos = ControlOrdenProductos.Instance.GetLista(orden);
            if ( listaProductos == null)
            {
                return;
            }
            foreach (OrdenProducto producto in listaProductos)
            {
                for (int i = 0; i < producto.cantidad; i++)
                {
                    ProductoOrdenUC nuevo = new ProductoOrdenUC(producto);
                    nuevo.Cantidad = 1;
                    nuevo.BtnVisible = true;
                    nuevo.Width = contenedor.Width - 10;
                    nuevo.Anchor = AnchorStyles.Right;
                    nuevo.Anchor = AnchorStyles.Left;
                    contenedor.Controls.Add(nuevo);
                    nuevo.AgregarClicked += ProductoAPersona;
                    nuevo.TextChangedA += new EventHandler(ControlUpdated);
                    cuentas[0].Add(nuevo);

                }
            }
            Actualiza();
        }

        private void ControlUpdated(object sender, EventArgs e)
        {
            ActualizaTotal();
            ActualizaSubTotal();
        }

        private void ProductoAPersona(object sende, EventArgs e)
        {
            if (listPersonas.SelectedItems.Count < 1)
            {
                MessageBox.Show("Seleccione a una persona");
                return;
            }

            ProductoOrdenUC sender = sende as ProductoOrdenUC;
            int index = listPersonas.SelectedIndices[0];

            cuentas[currentIndex].Remove(sender);
            cuentas[index].Add(sender);
            Actualiza();
        }
        private decimal ActualizaSubTotal()
        {
            return ActualizaSubTotal(currentIndex);
        }
        private decimal ActualizaSubTotal(int index)
        {
            decimal total = 0;
            foreach (ProductoOrdenUC po in cuentas[index])
            {
                total += po.Precio;
            }
            lbSubtotal.Text = total.ToString();
            return total;
        }

        private decimal ActualizaTotal()
        {
            decimal total = 0;
            foreach (var cuenta in cuentas)
            {
                foreach (var producto in cuenta)
                {
                    total += producto.Precio;
                }
            }
            lbTotal.Text = total.ToString();
            return total;
        }

        private void Actualiza()
        {
            contenedor.Controls.Clear();
            foreach (ProductoOrdenUC po in cuentas[currentIndex])
            {
                contenedor.Controls.Add(po);
            }
            ActualizaTotal();
            ActualizaSubTotal();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int noPersonass = listPersonas.Items.Count;
            cuentas.Add(new List<ProductoOrdenUC>());
            opciones1.AgregarOpcion("Persona " + listPersonas.Items.Count, Properties.Resources.F_baseline_person_outline_white_18, new MouseEventHandler(
                (s, a) =>
                {
                    currentIndex = noPersonass;
                    Actualiza();
                }
                ));
            listPersonas.Items.Add("Persona " + noPersonass);

        }

        private void txtPagar_Click(object sender, EventArgs e)
        {
            if (cuentas[0].Count > 0)
            {
                MessageBox.Show("Error no has asignado todos los productos");
                return;
            }
            DialogResult boton = MessageBox.Show("¿Esta seguro?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (boton != DialogResult.OK) return;
            Imprimir();

            var listaProductos = ControlOrdenProductos.Instance.GetLista(orden);
            if (listaProductos == null)
            {
                MessageBox.Show("Revisa tu coneccion"); return;
            }
            foreach (OrdenProducto op in listaProductos)
            {
                OrdenProducto op2 = ControlOrdenProductos.Instance.Cargar(op);
                RegistroProducto nueva = new RegistroProducto()
                {
                    cantidad = op2.cantidad,
                    fecha = DateTime.Now,
                    id_producto = op2.TipoProducto.id_producto,
                    id_tipo_producto = (int)op2.id_tipo_producto,
                    nombre_producto = op2.TipoProducto.Producto.nombre_producto,
                    nombre_tipo = op2.TipoProducto.nombre_tipo,
                    precio_tipo = op2.TipoProducto.precio_tipo

                };
                ControlRegistroProducto.Instance.Agregar(nueva);
            }

            //MessageBox.Show("Impresos");
            orden.total = 0;
            orden.activa = false;
            orden.total = ActualizaTotal();
            ControlOrdenes.Instance.Editar(orden);
            MessageBox.Show("Llevar a caja total: " + orden.total);
            ControlOrdenes.Instance.Eliminar(orden);
            orden = null;

            Owner.Owner.Close();
            Owner.Close();
            Close();
        }

        private void Imprimir()
        {
            for (int i = 1; i < cuentas.Count; i++)
            {
                ImprimeTicket imprime = new ImprimeTicket(cuentas[i]);
                imprime.Imprimir();
            }
            
        }
    }



}

