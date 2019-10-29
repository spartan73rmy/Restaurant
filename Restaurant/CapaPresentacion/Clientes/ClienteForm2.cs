using CapaAccesoDatos;
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

namespace CapaPresentacion.Clientes
{
    public partial class ClienteForm2 : MaterialForm
    {
        private List<Cliente> clientes;
        public ClienteForm2(bool maximized, List<Cliente> clientes)
        {
            InitializeComponent();
            btnAceptar.Enabled = false;
            btnAceptar.Visible = false;
            btnBorrar.Enabled = false;
            btnBorrar.Visible = false;

            this.clientes = clientes;
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);
            Actualiza();
        }

        private void Actualiza()
        {
            if (clientes.Count <= 0 || clientes == null)
            {
                return;
            }

            foreach (Cliente c in clientes)
            {
                
                // TarjetaCliente tarjeta = new TarjetaCliente(c, this);
                ListViewItem item = new ListViewItem(new string[] { c.nombre, c.telefono });
                item.Tag = c;
                materialListView1.Items.Add(item);
            }
        }


        private void materialListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Cliente cliente = (Cliente)e.Item.Tag;
            txtNombre.Text = cliente.nombre;
            txtApellidos.Text = cliente.apellidos;
            txtDireccion.Text = cliente.direccion;
            txtRFC.Text = cliente.rfc;
            txtTelefono.Text = cliente.telefono;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloNumeros(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Filtros.Direccion(e);
        }

        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
