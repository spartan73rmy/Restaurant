using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Utilerias;
using CapaPresentacion.Utilerias.Eventos;
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

namespace CapaPresentacion.Productos
{
    public partial class NuevoProductoFrm : MaterialForm
    {
        private CategoriaProducto categoria;
        private ProductoTipos productoTipos;
        private Producto productoAux;
        public NuevoProductoFrm(CategoriaProducto categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            txtPrecio.Enabled = false;
            txtPrecio.Visible = false;

            // TODO permitir que el usuario seleccione alguna caracteristica o subcategoria
            // ejemplo, Pizza(chica, mediana, grande o combinada, salami, queso)
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Llene Todos Los Campos", "ERROR");
            }
            else
            {
                Producto producto = new Producto()
                {
                    nombre_producto = txtNombre.Text,
                    id_categoria = categoria.id_categoria,
                    ProductoImagen = new ProductoImagen(),
                    TipoProducto = new List<TipoProducto>()
                };
                producto.ProductoImagen.Image = pictureBox1.Image;
                
                if (ControlProductos.Instance.Agregar(producto))
                {
                    MessageBox.Show("Producto Agregado Correctamente", "COMPLETADO");
                    Changed = true;
                    productoAux = producto;
                }
                else
                {
                    MessageBox.Show("Eror", "Error");
                }
            }
            this.Close();

            using (ProductoTipos variante = new ProductoTipos(true, productoAux))
            {
                variante.ShowDialog();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image image = ImageDialog.OpenImage();
            if (image != null)
                pictureBox1.Image = image;
        }

        public bool Changed { get; internal set; }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloLetras(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloNumeros(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
