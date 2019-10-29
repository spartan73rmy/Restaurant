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

namespace CapaPresentacion.Caja
{
    public partial class ProductoOrdenUC : UserControl
    {
        OrdenProducto producto;

        public decimal Precio
        {
            get
            {
                decimal total = 0;
                decimal.TryParse(txtPrecio.Text, out total);
                return total;
            }
        }

        int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                _cantidad = value;
                ActualizaCanttidad();
            }
        }

        public bool BtnVisible
        {
            get { return btnAgregar.Visible; }
            set
            {
                btnAgregar.Visible = value;
            }
        }

        public event EventHandler TextChangedA;
        public event EventHandler AgregarClicked;

        public ProductoOrdenUC(OrdenProducto producto)
        {
            this.producto = producto;
            //CategoriaProducto categoria = producto.CategoriaProducto;
            InitializeComponent();
            this.Cantidad = producto.cantidad;

            lbDescripcion.Text = producto.comentarios;
            lbProducto.Text = producto.TipoProducto.Producto.nombre_producto + " " + producto.TipoProducto.nombre_tipo + " $" + producto.precio;
            lbVariantes.Text = string.Empty;
            txtPrecio.Enabled = false;

            foreach (var variante in producto.ProductoVariante)
            {
                lbVariantes.Text += variante.nombre_variante + " $" + variante.precio_variante + " ";
            }



            txtPrecio.Text = ObtieneTotal().ToString();
            ActualizaCanttidad();
        }

        private void ActualizaCanttidad()
        {
            lbCantidad.Text = Cantidad.ToString();
            txtPrecio.Text = ObtieneTotal().ToString();

        }

        private decimal ObtieneTotal()
        {
            decimal total = Cantidad * producto.precio;
            foreach (ProductoVariante pv in producto.ProductoVariante)
            {
                total += Cantidad * pv.precio_variante;
            }
            return total;
        }

        private void ckPrecio_CheckedChanged(object sender, EventArgs e)
        {
            txtPrecio.Enabled = ckPrecio.Checked;
            if (!ckPrecio.Checked)
            {
                txtPrecio.Text = producto.precio.ToString();
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (TextChangedA != null)
                TextChangedA(sender, e);
        }

        public override string ToString()
        {
            return   producto.TipoProducto.Producto.CategoriaProducto.nombre_categoria + " " + lbProducto.Text + " " + lbVariantes.Text + " $" + Precio;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (AgregarClicked != null)
                AgregarClicked(this, e);
        }
    }
}
