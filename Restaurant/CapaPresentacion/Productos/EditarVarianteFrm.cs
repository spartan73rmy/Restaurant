using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Utilerias.Controles;
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
    public partial class EditarVarianteFrm : MaterialForm
    {
        private TipoProducto tipo;
        private ProductoVariante variante;

        public EditarVarianteFrm(TipoProducto tipo) : this(tipo, null) { }

        public EditarVarianteFrm(TipoProducto tipo, ProductoVariante variante)
        {
            InitializeComponent();
            this.tipo = tipo;
            if (variante != null)
            {
                btnEliminar.Visible = true;
                this.variante = variante;

                txtNombre.Text = variante.nombre_variante;
                txtDescripcion.Text = variante.descripcion;
                txtPrecio.Text = "" + variante.precio_variante;
                materialToggle1.Checked = variante.disponible;
                btnEliminar.Visible = true;
            }

        }
        public bool Changed { get; internal set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] textField = { txtNombre, txtPrecio };
            if (!Helper.Llenos(textField))
            {
                MessageBox.Show("Introduce datos validos", "ERROR");
                return;
            }
            if (variante == null)
            {
                variante = new ProductoVariante()
                {
                    nombre_variante = txtNombre.Text,
                    descripcion = txtDescripcion.Text,
                    disponible = materialToggle1.Checked,
                    id_tipo_producto = tipo.id_tipo_producto,
                    precio_variante = decimal.Parse(txtPrecio.Text)
                };
                if (ControlProductoVariante.Instance.Agregar(variante))
                {
                    Changed = true;
                    MessageBox.Show("Bien");
                }
                else
                {
                    MessageBox.Show("Mal");
                }
            }
            else
            {
                variante.nombre_variante = txtNombre.Text;
                variante.descripcion = txtDescripcion.Text;
                variante.disponible = materialToggle1.Checked;
                variante.id_tipo_producto = tipo.id_tipo_producto;
                variante.precio_variante = decimal.Parse(txtPrecio.Text);
                if (ControlProductoVariante.Instance.Editar(variante))
                {
                    Changed = true;
                    MessageBox.Show("Bien");
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
            if (ControlProductoVariante.Instance.Eliminar(variante))
            {
                Changed = true;
                MessageBox.Show("Bien");
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.AlfanumericoSpaceComa(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
