using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaLogica.ControlEntidades;

namespace CapaPresentacion.Comanda
{
    public partial class OrdenUserControl : UserControl
    {
        private OrdenProducto ordenProducto;
        public OrdenUserControl(OrdenProducto ordenProducto)
        {
            this.ordenProducto = ordenProducto;
            InitializeComponent();

            lbProducto.MaximumSize = new Size(250, 0); // Esto se hace para habilitar el multiline en las labels
            lbProducto.AutoSize = true;

            lbComentarios.MaximumSize = new Size(234, 0);
            lbComentarios.AutoSize = true;

        }

        private void Actualiza()
        {
            lbProducto.Text = ordenProducto.TipoProducto.Producto.nombre_producto;
            lbProducto.Text += " " + ordenProducto.TipoProducto.nombre_tipo;

            foreach (ProductoVariante pv in ordenProducto.ProductoVariante)
            {
                lbProducto.Text += " " + pv.nombre_variante;
            }

            lbComentarios.Text = ordenProducto.comentarios;
            lbCantidad.Text = "" + ordenProducto.cantidad;
            lbStatus.Text = ordenProducto.status;
            decimal total = ordenProducto.cantidad * ordenProducto.precio;
            foreach (ProductoVariante pv in ordenProducto.ProductoVariante)
            {
                total += ordenProducto.cantidad * pv.precio_variante;
            }
            lbTotal.Text = "" + (total);

            lbMesa.Text = "Mesa: " + ordenProducto.Orden.Mesa.nombre_mesa;
        }

        private void OrdenUserControl_Load(object sender, EventArgs e)
        {
            Actualiza();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (SeleccionTipoFrm variantes = new SeleccionTipoFrm(ordenProducto.TipoProducto.Producto)) // Abre form para seleccionar el tipo y variantes del producto
            {
                variantes.ShowDialog(this);
                if (variantes.OK)  // Si se cambio el producto
                {
                    OrdenProducto nuevo = new OrdenProducto() // Crea una nueva orden de producto con la nueva informacion
                    {
                        id_orden = ordenProducto.id_orden,
                        id_tipo_producto = variantes.Tipo.id_tipo_producto,
                        ProductoVariante = variantes.Variantes,
                        status = "En cola",
                        cantidad = variantes.Cantidad,
                        comentarios = variantes.Comentarios,
                        precio = variantes.Precio,
                        TipoProducto = variantes.Tipo
                    };
                    if (ControlOrdenProductos.Instance.Eliminar(ordenProducto)) // elimina la anterior
                    {
                        nuevo.Orden = ordenProducto.Orden;
                        ordenProducto = nuevo;
                        if (ControlOrdenProductos.Instance.Agregar(ordenProducto)) // Agrega la nueva
                        {
                            ordenProducto.TipoProducto = variantes.Tipo;

                            Actualiza();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Eror al agregar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eror al eliminar");
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Realmente quiere eliminar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (boton != DialogResult.OK) return;
            if (ControlOrdenProductos.Instance.Eliminar(ordenProducto))
            {
                MessageBox.Show("Producto eliminado");
                lbStatus.Text = "Eliminado";
                lbTotal.Text = "0";
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }
    }
}
