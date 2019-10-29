using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
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

namespace CapaPresentacion.Mesas
{
    public partial class MesasFrm : MaterialForm
    {
        private List<Mesa> mesas;
        private List<Reservacion> reservaciones;
        public MesasFrm(bool maximized, List<Mesa> mesas)
        {
            this.mesas = mesas;
            InitializeComponent();
            ScrollIni();
            revisarReservacion();

            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);

            if (mesas!=null)
            {
                foreach (Mesa mesa in mesas)
                {
                    TarjetaMesa tarjeta = new TarjetaMesa(mesa, this);
                    tarjeta.ContextMenuStrip = materialContextMenuStrip1;
                    contenedorTarjetas.Controls.Add(tarjeta);
                }
            }



            opciones1.AgregarOpcion("Reservaciones", Properties.Resources.F_baseline_playlist_add_check_white_18, new MouseEventHandler(
                (s, a) =>
                {
                    ReservaMesa();
                }
                ));
        }

        private void ReservaMesa()
        {
            using(ReservacionFrm r = new ReservacionFrm(Maximized))
            {
                r.ShowDialog(this);
                Actualiza();
            }
        }

        private TarjetaMesa GetSender(object sender)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;

                if (menu != null)
                {
                    Control controlSelected = menu.SourceControl;
                    TarjetaMesa tarjeta = controlSelected as TarjetaMesa;
                    return tarjeta;
                }
            }
            return null;

        }

        public void Actualiza()
        {
            contenedorTarjetas.Controls.Clear();
            var lista = ControlMesas.Instance.GetLista();
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (Mesa mesa in lista)
            {
                TarjetaMesa tarjeta = new TarjetaMesa(mesa, this);
                //Falta cambiar la imagen de mesa en las tarjetas
                //tarjeta.BackgroundImage = Properties.Resources.F_baseline_edit_white_18;
                tarjeta.ContextMenuStrip = materialContextMenuStrip1;
                contenedorTarjetas.Controls.Add(tarjeta);
            }

        }

        private void ScrollIni()
        {

            contenedorTarjetas.AutoScroll = false;
            contenedorTarjetas.HorizontalScroll.Visible = false;
            contenedorTarjetas.HorizontalScroll.Enabled = false;
            contenedorTarjetas.HorizontalScroll.Maximum = 0;
            contenedorTarjetas.AutoScroll = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (EditarMesa editar = new EditarMesa())
                editar.ShowDialog(this);
            Actualiza();
                        
        }

        private void stripMenuItemEditar_Click(object sender, EventArgs e)
        {
            if ((GetSender(sender).mesa).id_estado == 4)
            {
                return;
            }

            using (EditarMesa editar = new EditarMesa(GetSender(sender).mesa))
            {
                editar.ShowDialog(this);
            }
            Actualiza();
        }

        private void revisarReservacion()
        {
            ControlReservaciones control = new ControlReservaciones();
            reservaciones=control.GetLista();

            if (reservaciones.Count<=0||reservaciones==null)
            {
                return;
            }

            foreach (Reservacion item in reservaciones)
            {
                if (item.fecha.Date==DateTime.Now.Date)
                {
                    item.Mesa.id_estado = 4;
                    ControlMesas.Instance.Editar(item.Mesa);
                }
            }
        }
    }
}
