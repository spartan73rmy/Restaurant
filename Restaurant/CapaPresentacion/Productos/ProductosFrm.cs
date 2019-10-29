using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.ControlesPropios;
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

namespace CapaPresentacion.Productos
{
    public partial class ProductosFrm : MaterialForm
    {
        
        public ProductosFrm(bool maximized, List<CategoriaProducto> categorias)
        {
            InitializeComponent();
            ScrollIni();
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);

            UpdateList(categorias);


        }

        private void ScrollIni()
        {
            opciones1.AutoScroll = false;
            opciones1.HorizontalScroll.Visible = false;
            opciones1.HorizontalScroll.Enabled = false;
            opciones1.AutoScroll = true;

            contenedorTarjetas.AutoScroll = false;
            contenedorTarjetas.HorizontalScroll.Visible = false;
            contenedorTarjetas.HorizontalScroll.Enabled = false;
            contenedorTarjetas.HorizontalScroll.Maximum = 0;
            contenedorTarjetas.AutoScroll = true;
        }

        private void UpdateList(List<CategoriaProducto> nuevaLista)
        {
            contenedorTarjetas.Controls.Clear();

            if (nuevaLista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (CategoriaProducto categoria in nuevaLista)
            {
                TarjetaCategoriaComida tarjeta = new TarjetaCategoriaComida(categoria, this)
                {
                    FontSize = 18
                };
                tarjeta.MouseClick += (sender, e) => {
                    if (e.Button == MouseButtons.Right) return;
                    List<Producto> productos = ControlProductos.Instance.GetLista(categoria);

                    if (productos == null) { MessageBox.Show("Revisa tu coneccion"); return; }

                    ProductosPorCategoria productosPorCategoria = new ProductosPorCategoria(Maximized, categoria, productos);
                    productosPorCategoria.Text = categoria.nombre_categoria;
                    productosPorCategoria.Show(this);
                };
                contenedorTarjetas.Controls.Add(tarjeta);
                tarjeta.ContextMenuStrip = materialContextMenuStrip1;
            }
        }
        private async void UpdateList()
        {
           List<CategoriaProducto> lista = await Task.Run(() => ControlCategorias.Instance.GetLista());
            UpdateList(lista);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (EditarCategoriaFrm agregar = new EditarCategoriaFrm())
            {
                agregar.ShowDialog(this);
                if(agregar.Changed)
                {
                    UpdateList();
                }
                

            }
        }

        

        private TarjetaCategoriaComida GetSender(object sender)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                ContextMenuStrip calendarMenu = menuItem.Owner as ContextMenuStrip;

                if (calendarMenu != null)
                {
                    Control controlSelected = calendarMenu.SourceControl;
                    TarjetaCategoriaComida tarjeta = controlSelected as TarjetaCategoriaComida;
                    return tarjeta;
                }
            }
            return null;
            
        }

        private void toolStripMenuItemEditar_Click(object sender, EventArgs e)
        {
            using (EditarCategoriaFrm agregarCategoria = new EditarCategoriaFrm(GetSender(sender).Categoria))
            {
                agregarCategoria.ShowDialog();
                if (agregarCategoria.Changed)
                {
                    UpdateList();
                }
            }

        }

        private void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            // TODO Mostrar advertencia
            TarjetaCategoriaComida tarjeta = GetSender(sender);
            if (ControlCategorias.Instance.Eliminar(tarjeta.Categoria))
            {
                MessageBox.Show("Categoria Eliminada Correctamente", "COMPLETADO");
                UpdateList();
            }
            else
            {
                MessageBox.Show("Categoria Sin Eliminar ", "ERROR");
            }


        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ProductosFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
