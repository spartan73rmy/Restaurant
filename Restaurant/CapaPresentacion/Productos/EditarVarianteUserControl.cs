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
using CapaLogica.ControlEntidades;
using CapaPresentacion.ControlesPropios;
using MaterialSkin.Controls;

namespace CapaPresentacion.Productos
{
    public partial class EditarVarianteUserControl : UserControl
    {
        private TipoProducto tipo;

        public MaterialListView materialListView
        {
            get
            {
                return materialListView2;
            }
                
        }

        public EditarVarianteUserControl(TipoProducto tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            Actualiza();
        }

        public void Actualiza()
        {
            materialListView2.Items.Clear();
            foreach (ProductoVariante x in ControlProductoVariante.Instance.GetLista(tipo))
            {
                ListViewItem item = new ListViewItem(new string[] { x.nombre_variante, "" + "" + x.precio_variante, "" + x.disponible });
                item.Tag = x;
                materialListView2.Items.Add(item);
            }
        }

        private void btnAgregarVariante_Click(object sender, EventArgs e)
        {
            using (EditarVarianteFrm agregar = new EditarVarianteFrm(tipo))
            {
                agregar.ShowDialog(this);
                if (agregar.Changed)
                {
                    Actualiza();
                }
            }
        }

        private void btnEditarVariante_Click(object sender, EventArgs e)
        {
            if (materialListView2.SelectedItems.Count < 1) return;
            ProductoVariante variante = materialListView2.SelectedItems[0].Tag as ProductoVariante;
            using (EditarVarianteFrm agregar = new EditarVarianteFrm(tipo, variante))
            {
                agregar.ShowDialog(this);
                if (agregar.Changed)
                {
                    Actualiza();
                }
            }
        }
    }
}
