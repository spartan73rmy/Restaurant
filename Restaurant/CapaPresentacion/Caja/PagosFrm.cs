using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Caja
{
    public partial class PagosFrm : MaterialForm
    {
        private Orden orden;
        public PagosFrm(bool maximized, Orden orden)
        {
            this.orden = orden;
            InitializeComponent();
            if (maximized)
                MaximizeWindow(maximized);
            MaterialSkinManager.AddFormToManage(this);

            opciones1.AgregarOpcion("Cuenta separada", Properties.Resources.F_baseline_vertical_split_white_18, new MouseEventHandler(
                (sender, args) =>
                {
                    CuentaSeparada();
                }
                ));

            var listaProductos = ControlOrdenProductos.Instance.GetLista(orden);
            if (listaProductos==null)
            {
                 MessageBox.Show("Revisa tu coneccion"); return; 
            }
            foreach (OrdenProducto producto in listaProductos)
            {
                ProductoOrdenUC nuevo = new ProductoOrdenUC(producto);
                nuevo.Width = contenedor.Width - 10;
                nuevo.Anchor = AnchorStyles.Right;
                nuevo.Anchor = AnchorStyles.Left;
                contenedor.Controls.Add(nuevo);
                nuevo.TextChangedA += new EventHandler(ControlUpdated);
            }
            ActualizaTotal();
            
        }
        
        private void ControlUpdated(object sender, EventArgs events)
        {
            ActualizaTotal();
        }

        private decimal ActualizaTotal()
        {
            decimal total = 0;
            foreach (ProductoOrdenUC producto in contenedor.Controls)
            {
                total += producto.Precio;
            }
            txtTotal.Text = total.ToString();
            return total;
        }

        private void CuentaSeparada()
        {
            using (PagosSeparadosFrm pagosSeparados = new PagosSeparadosFrm(Maximized, orden))
            {
                Close();
                pagosSeparados.ShowDialog(Owner);
            }
        }

        private void txtPagar_Click(object sender, EventArgs e)
        {
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

            orden.total = 0;
            orden.activa = false;
            orden.total = ActualizaTotal();
            ControlOrdenes.Instance.Editar(orden);
            MessageBox.Show("Llevar a caja total: " + orden.total);

            

            if (!ControlOrdenes.Instance.Eliminar(orden))
            {
                MessageBox.Show("La orden no se pudo eliminar");
            }
            orden = null;

            Owner.Owner.Close();
            Owner.Close();
            Close();
        }

        private bool Imprimir()
        {
            List<ProductoOrdenUC> lista = new List<ProductoOrdenUC>();
            ImprimeTicket imprime = new ImprimeTicket(lista);
            foreach (ProductoOrdenUC producto in contenedor.Controls)
            {
                lista.Add(producto);
            }
            return imprime.Imprimir();
        }
    }
}
