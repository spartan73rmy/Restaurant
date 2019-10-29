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
    public partial class ProductoTipos : MaterialForm
    {
        private Producto producto;
        private const int AGREGAR = 1, ELIMINAR = 2, EDITAR = 3;

        public ProductoTipos(bool maximized, Producto producto)
        {
            this.producto = producto;
            InitializeComponent();
            //Ocutar botones solo por si cambiamos de opinion 
            btnAgregarTipo.Visible = false;
            btnAgregarTipo.Enabled = false;
            btnEditar.Visible = false;
            btnEditar.Enabled = false;

            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);

            ActualizaTipos();

        }

        private void ActualizaTipos()
        {
            materialListView1.Items.Clear();
            var lista = ControlTipoProducto.Instance.GetLista(producto);
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (TipoProducto tipo in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { tipo.nombre_tipo, "" + tipo.precio_tipo });
                item.Tag = tipo;
                materialListView1.Items.Add(item);
            }
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            using (EditarTipo agregar = new EditarTipo(producto))
            {
                agregar.ShowDialog(this);
                if (agregar.Changed)
                {
                    ActualizaTipos();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecciona un tipo a editar");
                return;
            }
            TipoProducto tipo = materialListView1.SelectedItems[0].Tag as TipoProducto;
            using (EditarTipo editar = new EditarTipo(producto, tipo))
            {
                editar.ShowDialog(this);
                if (editar.Changed)
                {
                    ActualizaTipos();
                }
            }
        }

        private void materialListView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (materialListView1.SelectedItems.Count < 1)
            {
                return;
            }
            TipoProducto tipo = materialListView1.SelectedItems[0].Tag as TipoProducto;

            panel2.Visible = false;
            panel2.Controls.Clear();
            EditarVarianteUserControl editar = new EditarVarianteUserControl(tipo)
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(editar);
            panel2.Visible = true;
        }

        private void btnAgregarVariante_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarVariante_Click(object sender, EventArgs e)
        {

        }

        private void ProductoTipos_Load(object sender, EventArgs e)
        {

            #region Botones
            // Argumentos (Texto a mostrar, Icono a mostrar, Evento o que el control al hacer clik en él)
            opciones1.AgregarOpcion("Agregar", Properties.Resources.F_baseline_add_circle_outline_white_18,
                new MouseEventHandler((o, args) =>
                {                   
                        SeleccionarAccion(AGREGAR);
                }));


            opciones1.AgregarOpcion("Eliminar", Properties.Resources.F_baseline_remove_circle_outline_white_18,
                new MouseEventHandler((o, args) =>
                {
                    SeleccionarAccion(ELIMINAR);
                }));


            opciones1.AgregarOpcion("Editar", Properties.Resources.F_baseline_edit_white_18,
                new MouseEventHandler((o, args) =>
                {
                    SeleccionarAccion(EDITAR);
                }));

            #endregion

        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SeleccionarAccion(int opcion)
        {
                switch (opcion)
                {

                    case AGREGAR:
                    Agregar();
                        break;
                    case ELIMINAR:
                    Eliminar();
                        break;
                    case EDITAR:
                    Editar();
                        break;

                    default:
                        break;
                }     
        }

        #region Metodos_Acciones
        private void Agregar()
        {
            using (EditarTipo agregar = new EditarTipo(producto))
            {
                agregar.ShowDialog(this);
                if (agregar.Changed)
                {
                    ActualizaTipos();
                }
            }
        }

        private void Eliminar()
        {
            if (materialListView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecciona un tipo a eliminar");
                return;
            }
            TipoProducto tipoEliminar = materialListView1.SelectedItems[0].Tag as TipoProducto;
            if (ControlTipoProducto.Instance.Eliminar(tipoEliminar))
            {
                MessageBox.Show("Bien");
            }
            else
            {
                MessageBox.Show("Mal");
            }
            ActualizaTipos();
        }

        private void Editar()
        {
            if (materialListView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecciona un tipo a editar");
                return;
            }
            TipoProducto tipo = materialListView1.SelectedItems[0].Tag as TipoProducto;
            using (EditarTipo editar = new EditarTipo(producto, tipo))
            {
                editar.ShowDialog(this);
                if (editar.Changed)
                {
                    ActualizaTipos();
                }
            }
        }
        #endregion Metodos_Acciones

    }
}
