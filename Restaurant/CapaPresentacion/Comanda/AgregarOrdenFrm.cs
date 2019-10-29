using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Productos;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Comanda
{
    public partial class AgregarOrdenFrm : MaterialForm
    {
        public bool Changed { get; internal set; }
        private Orden orden;
        public AgregarOrdenFrm(bool maximized, Orden orden)
        {
            this.orden = orden;
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);

            Inicia();
            ScrollIni();

        }

        private void ScrollIni()
        {
            opciones1.AutoScroll = false;
            opciones1.HorizontalScroll.Visible = true;
            opciones1.HorizontalScroll.Enabled = false;
            opciones1.AutoScroll = true;

            contenedorTarjetas.AutoScroll = false;
            contenedorTarjetas.HorizontalScroll.Enabled = false;
            contenedorTarjetas.HorizontalScroll.Visible = false;
            contenedorTarjetas.HorizontalScroll.Maximum = 0;
            contenedorTarjetas.AutoScroll = true;

        }


        private async void Inicia()
        {
            opciones1.Clear();            


            CargarTarjetasDeProductos(null); // Carga todos los productos

            var listaCategoriaProducto = ControlCategorias.Instance.GetLista();
            if (listaCategoriaProducto.Count <= 0 || listaCategoriaProducto == null)
            {
                return;
            }

            foreach (CategoriaProducto categoria in listaCategoriaProducto)
            {

                if (categoria.CategoriaProductoImagen == null)
                {
                    await Task.Run(() => categoria.LoadImage()); // Carga la imagen de la categoria (nesesario? se ve feo)
                }

                opciones1.AgregarOpcion(categoria.nombre_categoria, categoria.CategoriaProductoImagen.Image,
                    new MouseEventHandler(
                        (o, sender) => CargarTarjetasDeProductos(categoria)
                    )
                 );
            }

        }

        private void CargarTarjetasDeProductos(CategoriaProducto categoria)
        {
            contenedorTarjetas.Controls.Clear();

            var listaProductos = ControlProductos.Instance.GetLista(categoria);
            if (listaProductos.Count <= 0 || listaProductos == null)
            {
                return;
            }

            foreach (Producto producto in listaProductos)
            {
                TarjetaProducto tarjeta = new TarjetaProducto(producto, this);
                tarjeta.MouseClick += (sen, eve) =>
                {
                    OrdenarProducto(producto);
                };
                contenedorTarjetas.Controls.Add(tarjeta);
            }
        }

        private void OrdenarProducto(Producto producto)
        {
            using (SeleccionTipoFrm seleccionarTipo = new SeleccionTipoFrm(producto))
            {
                seleccionarTipo.ShowDialog(this);
                if (seleccionarTipo.OK)
                {
                    OrdenProducto ordenGenerada = new OrdenProducto()
                    {
                        id_orden = orden.id_orden,
                        id_tipo_producto = seleccionarTipo.Tipo.id_tipo_producto,
                        ProductoVariante = seleccionarTipo.Variantes,
                        status = "En cola",
                        cantidad = seleccionarTipo.Cantidad,
                        comentarios = seleccionarTipo.Comentarios,
                        precio = seleccionarTipo.Precio
                    };
                    if (ControlOrdenProductos.Instance.Agregar(ordenGenerada))
                    {
                        MessageBox.Show("Bien");
                        Changed = true;
                    }
                    else
                    {
                        MessageBox.Show("Mal");
                    }
                }
            }
        }
        

    }
}
