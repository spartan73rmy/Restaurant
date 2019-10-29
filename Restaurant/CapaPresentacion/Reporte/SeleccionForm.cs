using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reporte
{
    public partial class SeleccionForm : MaterialForm
    {
        public List<Producto> selected = new List<Producto>();
        private List<CategoriaProducto> categorias = new List<CategoriaProducto>();
        private CategoriaProducto categoriaTemp;
        public SeleccionForm(bool maximized)
        {
            InitializeComponent();
            if (maximized)
                MaximizeWindow(maximized);

            Inicia();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeleccionForm_Load(object sender, EventArgs e)
        {

        }

        private async void Inicia()
        {
            opciones1.Clear();
            // CargarListaProductos(null); // Carga todos los productos

            var lista = ControlCategorias.Instance.GetLista();
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (CategoriaProducto categoria in lista)
            {
                categorias.Add(categoria);
                if (categoria.CategoriaProductoImagen == null)
                {
                    await Task.Run(() => categoria.LoadImage()); // Carga la imagen de la categoria (nesesario? se ve feo)
                }

                opciones1.AgregarOpcion(categoria.nombre_categoria, categoria.CategoriaProductoImagen.Image,
                    new MouseEventHandler(
                        (o, sender) => CargarListaProductos(categoria)
                    )
                 );
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (unselectedListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Advertencia", "Seleccione un producto"); return;
            }
            else
            {
                foreach (ListViewItem item in unselectedListView.SelectedItems)
                {
                    selected.Add((Producto)item.Tag);
                }
                CargarListaProductos(categoriaTemp);
                CargarListaSeleccionados();
            }
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (selectedListView.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Advertencia", "Seleccione un producto"); return;
            }
            else
            {
                foreach (ListViewItem  item in selectedListView.SelectedItems)
                {
                    //Console.WriteLine(((Producto)item.Tag).id_producto);
                    selected.Remove(((Producto)item.Tag));
                }
                CargarListaProductos(categoriaTemp);
                CargarListaSeleccionados();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public List<Producto> GetListSelected()
        {
            return selected;
        }

        private void unselectedListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarListaProductos(CategoriaProducto categoria)
        {
            categoriaTemp = categoria;
            unselectedListView.Items.Clear();

            var listaProductos = ControlProductos.Instance.GetLista(categoria);
            if (listaProductos == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (Producto producto in listaProductos)
            {
                ListViewItem item = new ListViewItem(producto.nombre_producto);
                item.Tag = producto;
                if (selected.Contains(producto)) { continue; }
                unselectedListView.Items.Add(item);
            }
        }

        private List<Producto> CargarListaProductosTodos(CategoriaProducto categoria)
        {
            List<Producto> todos = new List<Producto>();
            categoriaTemp = categoria;

            var lista = ControlProductos.Instance.GetLista(categoria);
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return null; }

            foreach (Producto producto in lista)
            {
                if (selected.Contains(producto)) { continue; }
                todos.Add(producto);
            }
            return todos;
        }

        private void CargarListaSeleccionados()
        {
            selectedListView.Items.Clear();
            foreach (Producto producto in selected)
            {
                ListViewItem item = new ListViewItem(producto.nombre_producto);
                item.Tag = producto;
                selectedListView.Items.Add(item);
            }
        }

        private void btn_SeleccionarTodo_Click(object sender, EventArgs e)
        {
            foreach (CategoriaProducto item in categorias)
            {
                selected.AddRange(CargarListaProductosTodos(item));
            }
            CargarListaSeleccionados();
        }
    }
}
