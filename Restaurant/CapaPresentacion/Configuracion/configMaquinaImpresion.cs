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

namespace CapaPresentacion.Configuracion
{
    public partial class configMaquinaImpresion : MaterialForm
    {
        private string configSelected = "";


        public configMaquinaImpresion()
        {
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);

            CargarList();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selecciona alguna opcion");
                return;
            }
            configSelected = "";
            foreach (ListViewItem item in materialListView1.SelectedItems)
            {
                configSelected = item.Tag as string;
            }
            Close();

        }

        public string Opcion()
        {
            return configSelected;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarList()
        {
            string[] valores = new string[]
{
                "Barra"
                ,"Cocina"
};
            for (int i = 0; i < valores.Length; i++)
            {
                ListViewItem viewItem = new ListViewItem(valores[i]);
                viewItem.Tag = valores[i];
                materialListView1.Items.Add(viewItem);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selecciona alguna opcion");
                return;
            }
            configSelected = "";
            foreach (ListViewItem item in materialListView1.SelectedItems)
            {
                configSelected = item.Tag as string;
            }
            Close();

        }
    }
}
