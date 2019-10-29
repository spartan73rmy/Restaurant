using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Utilerias;
using CapaPresentacion.Utilerias.Eventos;

namespace CapaPresentacion.Productos
{
    public partial class EditarCategoriaFrm : MaterialForm
    {
        private CategoriaProducto categoria;
        public bool Changed { get; internal set; }

        public EditarCategoriaFrm(CategoriaProducto categoria)
        {
            this.categoria = categoria;
            Changed = false;
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);

            if (categoria != null)
            {
                txtCategoria.Text = categoria.nombre_categoria;
                btnEliminar.Visible = true;
                pictureBox1.Image = categoria.CategoriaProductoImagen.Image;
            }
            
        }
        

        public EditarCategoriaFrm() : this(null) { }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Llene Todos Los Campos", "ERROR");
                return;
            }
            else
            {
                bool bien = false;
                // si la categoria no es null significa que tenemos que editar solamente
                if (categoria != null)
                {
                    categoria.nombre_categoria = txtCategoria.Text;
                    categoria.CategoriaProductoImagen.Image = pictureBox1.Image;
                    bien = ControlCategorias.Instance.Editar(categoria);
                }
                else
                {
                    categoria = new CategoriaProducto()
                    {
                        nombre_categoria = txtCategoria.Text,
                        CategoriaProductoImagen = new CategoriaProductoImagen()
                    };

                    categoria.CategoriaProductoImagen.Image = pictureBox1.Image;

                    bien = ControlCategorias.Instance.Agregar(categoria);

                }

                if (bien)
                {
                    MessageBox.Show("Categoria Agregada Correctamente", "COMPLETADO");
                    Changed = true;
                }
                else
                {
                    Changed = false;
                }
                Close();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ControlCategorias.Instance.Eliminar(categoria))
            {
                MessageBox.Show("Categoria Eliminada Correctamente", "COMPLETADO");
                Changed = true;
                Close();
            }
            else
            {
                MessageBox.Show("No se elimino la categoria", "ERROR");
               
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image image = ImageDialog.OpenImage();
            if (image != null)
                pictureBox1.Image = image;
        }


        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.AlfanumericoSpace(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
