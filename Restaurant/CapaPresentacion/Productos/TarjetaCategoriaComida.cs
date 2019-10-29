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
using CapaPresentacion.Productos;
using MaterialSkin.Controls;
using CapaPresentacion.ControlesPropios;
using CapaLogica.ControlEntidades;

namespace CapaPresentacion.Productos
{
    public partial class TarjetaCategoriaComida : Tarjeta
    {
        private CategoriaProducto categoria;
        private MaterialForm owner;
        public CategoriaProducto Categoria { get { return this.categoria; } }
        public TarjetaCategoriaComida(CategoriaProducto categoria, MaterialForm owner)
        {
            InitializeComponent();
            this.categoria = categoria;
            Texto = categoria.nombre_categoria;
            this.owner = owner;
            LoadImage();
        }

        private async void LoadImage()
        {
            if (categoria.CategoriaProductoImagen == null)
            {
                await Task.Run(() => ControlCategorias.Imagenes.Instance.LoadImage(categoria));
                if (categoria.CategoriaProductoImagen != null)
                    Image = categoria.CategoriaProductoImagen.Image;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is TarjetaCategoriaComida)) return false;
            TarjetaCategoriaComida otra = (TarjetaCategoriaComida)obj;
            return this.Categoria.Equals(otra.categoria);
        }

        public override int GetHashCode()
        {
            return Categoria.GetHashCode();
        }

    }
}
