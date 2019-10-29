using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Utilerias.Eventos;
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

namespace CapaPresentacion.Comanda
{
    public partial class SeleccionTipoFrm : MaterialForm
    {
        public bool OK { get; internal set; }
        public TipoProducto Tipo { get; internal set; }
        public IList<ProductoVariante> Variantes { get; internal set; }
        public int Cantidad { get; internal set; }
        public string Comentarios { get; internal set; }
        public decimal Precio { get; internal set; }

        private int cant=0;

        private Producto producto;
        public SeleccionTipoFrm(Producto producto)
        {
            this.producto = producto;
            InitializeComponent();
            btnCancelar.Visible = true;

            MaterialSkinManager.AddFormToManage(this);
            
        }

        private void SeleccionVariantesFrm_Load(object sender, EventArgs e)
        {
            var lista = ControlTipoProducto.Instance.GetLista(producto);
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (TipoProducto tipo in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { tipo.nombre_tipo });
                item.Tag = tipo;
                materialListView1.Items.Add(item);
            }
        }

        private void materialListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;
            contenedorVariantes.Controls.Clear();
            TipoProducto tipo = (TipoProducto)e.Item.Tag;
            var lista = ControlProductoVariante.Instance.GetLista(tipo);
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (ProductoVariante variante in lista)
            {
                MaterialCheckBox material = new MaterialCheckBox()
                {
                    Text = variante.nombre_variante,
                    Tag = variante
                };
                contenedorVariantes.Controls.Add(material);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecciona un tamaño");
                return;
            }
            
            Tipo = (TipoProducto)materialListView1.SelectedItems[0].Tag;
            Variantes = new List<ProductoVariante>();
            foreach (MaterialCheckBox check in contenedorVariantes.Controls)
            {
                if (check.Checked)
                {
                    Variantes.Add((ProductoVariante)check.Tag);
                }
            }
            if (Utilerias.Controles.Helper.Vacio(txtCantidad))
            {
                MessageBox.Show("Faltan datos", "ADVERTENCIA");
                return;
            }
            else
            {
                Cantidad = int.Parse(txtCantidad.Text);
                Comentarios = txtComentarios.Text;
                Precio = Tipo.precio_tipo;
                Close();
                OK = true;
            }


        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "" + ++cant;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

            if (--cant >= 1)
            {
                txtCantidad.Text = "" + cant;
            }
            else
            {
                cant = 1; txtCantidad.Text = "" + cant;
            }
        }

        private void txtComentarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.AlfanumericoSpace(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloNumeros(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
