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
    public partial class EditarProductoFrm : MaterialForm
    {
        private Producto producto;
        private List<CategoriaProducto> categorias;

        public EditarProductoFrm(Producto producto)
        {
            InitializeComponent();

            // TODO quitar combox y cambiar por algo amigable al tacto
            // por ejemplo ListView
            categorias = ControlCategorias.Instance.GetLista();

            if (categorias == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (CategoriaProducto cp in categorias)
            {
                ListView1.Items.Add(""+cp.nombre_categoria);
                if (cp.nombre_categoria.Equals(producto.CategoriaProducto.nombre_categoria))
                {
            //Agregar Focused o Select para no cambiar la categoria 
                    ListView1.Select();
                }
            }
            

            this.producto = producto;

            txtPrecio.Enabled = false;
            txtPrecio.Visible = false;

            txtNombre.Text = producto.nombre_producto;
            if (producto.ProductoImagen != null)
                pictureBox1.Image = producto.ProductoImagen.Image;
           // cbCategorias.Text = producto.CategoriaProducto.ToString();
            
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || ListView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Llene Todos Los Campos", "ERROR");
            }
            else
            {
                CategoriaProducto seleccionada=null;
                if (categorias == null) { MessageBox.Show("Revisa tu coneccion"); return; }

                foreach (CategoriaProducto cp in categorias)
                {

                    if (ListView1.SelectedItems[0].ToString().Equals("ListViewItem: {"+cp.nombre_categoria+"}"))
                    {
                        seleccionada = cp;
                    }
                }
                //CategoriaProducto seleccionada = (CategoriaProducto)cbCategorias.SelectedItem;

                producto.CategoriaProducto = seleccionada;
                producto.id_categoria = seleccionada.id_categoria;
                producto.nombre_producto = txtNombre.Text;
                producto.ProductoImagen.Image = pictureBox1.Image;
                producto.TipoProducto.Clear();

                if (ControlProductos.Instance.Editar(producto))
                {
                    MessageBox.Show("Producto Editado Correctamente", "COMPLETADO");
                    Changed = true;
                }
                else
                {
                    MessageBox.Show("Error", "Error");
                }
                Close();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ControlProductos.Instance.Eliminar(producto))
            {
                MessageBox.Show("Producto Eliminado Correctamente", "COMPLETADO");
                Changed = true;
                Close();
            }
            else
            {
                MessageBox.Show("Error", "Error");
                Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image image = ImageDialog.OpenImage();
            if (image != null)
                pictureBox1.Image = image;
        }


        public bool Changed { get; internal set; }


        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            using (EditarTipo nuevoTipo = new EditarTipo(producto))
            {
                nuevoTipo.ShowDialog(this);
                if (nuevoTipo.Changed)
                {
                    TipoProducto nuevo = nuevoTipo.Tipo;
                    nuevo.id_producto = producto.id_producto;
                    ListViewItem item = new ListViewItem(new string[] { nuevo.nombre_tipo, "" + nuevo.precio_tipo });
                    item.Tag = nuevo;
                    producto.TipoProducto.Add(nuevo);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.AlfanumericoSpace(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloNumeros(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);

        }


    }
}
