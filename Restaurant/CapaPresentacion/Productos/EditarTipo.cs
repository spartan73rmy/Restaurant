using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Utilerias.Eventos;
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

namespace CapaPresentacion.Productos
{
    public partial class EditarTipo : MaterialForm
    {
        private Producto producto;
        public bool Changed { get; internal set; }
        public bool Eliminar { get; internal set; }
        public TipoProducto Tipo { get; internal set; }

        public EditarTipo(Producto producto, TipoProducto tipo)
        {
            InitializeComponent();
            this.producto = producto;
            MaterialSkinManager.AddFormToManage(this);
            Tipo = tipo;
            btnCancelar.Visible = true;
            if (tipo != null)
            {
                txtNombre.Text = tipo.nombre_tipo;
                txtPrecio.Text = "" + tipo.precio_tipo;
                btnEliminar.Visible = true;
                
            }
        }

        public EditarTipo(Producto producto) : this(producto, null) { }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (Tipo == null)
            {
                if (txtNombre.Text.Equals("")||txtPrecio.Text.Equals(""))
                {
                    MessageBox.Show("Introduce datos validos", "ERROR");
                    return;
                }
                Tipo = new TipoProducto
                {
                    nombre_tipo = txtNombre.Text,
                    precio_tipo = decimal.Parse(txtPrecio.Text),
                    id_producto = producto.id_producto
                };

                if(ControlTipoProducto.Instance.Agregar(Tipo))
                {
                    MessageBox.Show("Bien");
                    Changed = true;
                } else
                {
                    MessageBox.Show("Mal");
                }
            } else
            {
                Tipo.nombre_tipo = txtNombre.Text;
                Tipo.precio_tipo = decimal.Parse(txtPrecio.Text);
                if (ControlTipoProducto.Instance.Editar(Tipo))
                {
                    MessageBox.Show("Bien");
                    Changed = true;
                }
                else
                {
                    MessageBox.Show("Mal");
                }
            }
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ControlTipoProducto.Instance.Eliminar(Tipo))
            {
                MessageBox.Show("Bien");
                Changed = true;
            }
            else
            {
                MessageBox.Show("Mal");
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
