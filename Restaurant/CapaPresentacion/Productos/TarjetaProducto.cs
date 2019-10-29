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
using MaterialSkin.Controls;
using CapaPresentacion.ControlesPropios;
using CapaLogica.ControlEntidades;

namespace CapaPresentacion.Productos
{
    public partial class TarjetaProducto : Tarjeta
    {
        private Producto producto;
        private MaterialForm owner;
        public TarjetaProducto(Producto producto, MaterialForm owner)
        {
            InitializeComponent();
            this.producto = producto;
            this.owner = owner;
            //string price = producto.precio.ToString("#.##");
            Texto = producto.nombre_producto;
            
            LoadImage();
        }

        public Producto Producto { get { return producto; } }

        private async void LoadImage()
        {
            if (producto.ProductoImagen == null)
            {
                await Task.Run(() => ControlProductos.Imagenes.Instance.LoadImage(producto));
                Image = producto.ProductoImagen.Image;
            }
        }

        private void TarjetaProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
