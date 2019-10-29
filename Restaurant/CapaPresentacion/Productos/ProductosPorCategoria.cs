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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Productos
{
    public partial class ProductosPorCategoria : MaterialForm
    {
        private CategoriaProducto categoria;

        public ProductosPorCategoria(bool maximized, CategoriaProducto categoria, List<Producto> productos)
        {
            
            this.categoria = categoria ?? throw new ArgumentNullException("Categoria no pude ser nulo");
            if (productos == null) throw new ArgumentNullException("Productos no puede ser nulo");

            InitializeComponent();
            ScrollIni();

            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);

            UpdateList(productos);
        }

        private void ScrollIni()
        {

            contenedorTarjetas.AutoScroll = false;
            contenedorTarjetas.HorizontalScroll.Visible = false;
            contenedorTarjetas.HorizontalScroll.Enabled = false;
            contenedorTarjetas.HorizontalScroll.Maximum = 0;
            contenedorTarjetas.AutoScroll = true;
        }

        private void UpdateList(List<Producto> productos)
        {
            contenedorTarjetas.Controls.Clear();

            // Agregra el evento MouseClick a todas las tarjetas
            if (productos == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (Producto producto in productos)
            {
                TarjetaProducto tarjetaProducto = new TarjetaProducto(producto, this);

                tarjetaProducto.MouseClick += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Right) return;

                    using (ProductoTipos variante = new ProductoTipos(Maximized, producto))
                    {
                        variante.ShowDialog(this);
                    }
                    
                };
                tarjetaProducto.ContextMenuStrip = materialContextMenuStrip1;
                contenedorTarjetas.Controls.Add(tarjetaProducto);
            }
        }



        private async void UpdateList()
        {
            List<Producto> lista = await Task.Run(() => ControlProductos.Instance.GetLista(categoria));
            UpdateList(lista);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (NuevoProductoFrm nuevoProd = new NuevoProductoFrm(categoria))
            {
                nuevoProd.ShowDialog(this);
                if (nuevoProd.Changed)
                {
                    UpdateList();
                }
            }
        }
        

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    TarjetaProducto sourceControl = (TarjetaProducto)owner.SourceControl;
                    Producto producto = sourceControl.Producto;

                    using (EditarProductoFrm editar = new EditarProductoFrm(producto))
                    {
                        editar.ShowDialog(this);
                        if(editar.Changed)
                        {
                            UpdateList();
                        }
                    }
                }
            }
        }

        private void contenedorTarjetas_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
