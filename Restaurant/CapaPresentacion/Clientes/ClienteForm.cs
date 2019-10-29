using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using CapaAccesoDatos;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using CapaLogica.ControlEntidades;

namespace CapaPresentacion.Clientes
{
    public partial class ClienteForm : MaterialForm
    {
        // TODO agregar un buscador a este form

        private List<Cliente> clientes;
        public ClienteForm(bool maximized, List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);
            Actualiza();
            ScrollIni();
        }
        private void ScrollIni()
        {

            contenedorTarjetas.AutoScroll = false;
            contenedorTarjetas.HorizontalScroll.Visible = false;
            contenedorTarjetas.HorizontalScroll.Enabled = false;
            contenedorTarjetas.HorizontalScroll.Maximum = 0;
            contenedorTarjetas.AutoScroll = true;
        }

        private void Actualiza()
        {
            foreach (Cliente c in clientes)
            {
                TarjetaCliente tarjeta = new TarjetaCliente(c, this);
                tarjeta.ContextMenuStrip = materialContextMenuStrip1;
                contenedorTarjetas.Controls.Add(tarjeta);
                if (contenedorTarjetas.Controls.Count >= 50)
                {
                    break;
                }
            }
        }

        private void Refresh()
        {
            contenedorTarjetas.Controls.Clear();
            var listaClientes = ControlClientes.Instance.GetLista();
            if (listaClientes.Count <= 0 || listaClientes == null)
            {
                return;
            }

            foreach (Cliente c in listaClientes)
            {
                TarjetaCliente tarjeta = new TarjetaCliente(c, this);
                tarjeta.ContextMenuStrip = materialContextMenuStrip1;
                contenedorTarjetas.Controls.Add(tarjeta);
                if (contenedorTarjetas.Controls.Count >= 50)
                {
                    break;
                }
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            using (EditarCliente agregarCliente = new EditarCliente())
                agregarCliente.ShowDialog(this);
            Refresh();
        }

        private TarjetaCliente GetSender(object sender)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;

                if (menu != null)
                {
                    Control controlSelected = menu.SourceControl;
                    TarjetaCliente tarjeta = controlSelected as TarjetaCliente;
                    return tarjeta;
                }
            }
            return null;

        }


        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditarCliente editar = new EditarCliente(GetSender(sender).cliente))
                editar.ShowDialog(this);
            Refresh();

        }
    }
}
