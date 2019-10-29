using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Mesas;
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
    public partial class ComandaFrm : MaterialForm
    {
        public ComandaFrm(bool maximized)
        {
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);
            ScrollIni();
            opciones.AgregarOpcion("Mostrar Todas", Properties.Resources.F_baseline_format_list_bulleted_white_18, new MouseEventHandler(
                (e, a) =>
                {
                    using (PedidosActivosFrm mostrarOrdenes = new PedidosActivosFrm(Maximized))
                    {
                        mostrarOrdenes.ShowDialog(this);
                    }
                }
                ));
        }

        private void ScrollIni()
        {

            contenedorTarjetas.AutoScroll = false;
            contenedorTarjetas.HorizontalScroll.Visible = false;
            contenedorTarjetas.HorizontalScroll.Enabled = false;
            contenedorTarjetas.HorizontalScroll.Maximum = 0;
            contenedorTarjetas.AutoScroll = true;
        }

        private void Comanda_Load(object sender, EventArgs e)
        {

            var listaMesas = ControlMesas.Instance.GetLista();
            if (listaMesas.Count <= 0 || listaMesas == null)
            {
                return;
            }

            foreach (Mesa mesa in listaMesas)
            {
                TarjetaMesa tarjeta = new TarjetaMesa(mesa, this);
                tarjeta.MouseClick += (osender, args) =>
                {
                    using (OpcionesComanda opciones = new OpcionesComanda(Maximized, mesa))
                    {
                        opciones.ShowDialog(this);
                    }
                };
                contenedorTarjetas.Controls.Add(tarjeta);
            }
        }

    }
}
