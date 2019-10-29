using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.ControlesPropios;
using CapaAccesoDatos;
using MaterialSkin.Controls;

namespace CapaPresentacion.Configuracion
{
    public partial class TarjetaCategoria : Tarjeta
    {
        private CategoriaProducto categoria;
        private MaterialForm owner;

        public TarjetaCategoria(CategoriaProducto categoria, MaterialForm owner)
        {
            InitializeComponent();
            this.owner = owner;
            this.categoria = categoria;
            Texto = categoria.nombre_categoria;
            Image = categoria.CategoriaProductoImagen.Image;
            //LoadImage();
        }

        public CategoriaProducto Categoria { get { return categoria; } }

        private async void LoadImage()
        {
            if (categoria.CategoriaProductoImagen == null)
            {
                await Task.Run(() => categoria.LoadImage()); // Carga la imagen de la categoria (nesesario? se ve feo)
                Image = categoria.CategoriaProductoImagen.Image;
            }
        }

    }
}
