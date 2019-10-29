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
    public partial class ReservacionFrm : MaterialForm
    {
        DateTime today = new DateTime();
         public ReservacionFrm(bool maximized)
        {
            today = DateTime.Now;
            InitializeComponent();
            if (maximized)
                MaximizeWindow(maximized);
            MaterialSkinManager.AddFormToManage(this);

            opciones1.AgregarOpcion("Nueva", Properties.Resources.F_baseline_add_circle_outline_white_18, new MouseEventHandler(
                (s, a) =>
                {
                    NuevaReservacion();
                }
                ));

            Actualiza();
        }

        private void NuevaReservacion()
        {
            using (AgregarReservacionFrm nueva = new AgregarReservacionFrm(Maximized))
            {
                nueva.ShowDialog(this);
                Actualiza();
            }
        }

        private void Actualiza()
        {
            materialListView1.Items.Clear();
            var lista = ControlReservaciones.Instance.GetLista();
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (Reservacion r in lista)
            {
                string horaInicio = r.hora_inicio.ToString("hh:mm") + " " + r.hora_inicio.ToString("tt").ToUpper();
                string horaFin = r.hora_fin.ToString("hh:mm") + " " + r.hora_fin.ToString("tt").ToUpper();

                string[] t = { r.Mesa.nombre_mesa, r.Cliente.nombre + " " + r.Cliente.apellidos, "" +
                        r.fecha.ToShortDateString(), horaInicio, horaFin };
                ListViewItem item = new ListViewItem(t);
                item.Tag = r;
                materialListView1.Items.Add(item);
            }
        }

        private void ReservacionFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Seleccione una reservacion");
                return;
            }

            bool ok = true;
            foreach (ListViewItem item in materialListView1.SelectedItems)
            {
                ok &= ControlReservaciones.Instance.Eliminar(item.Tag as Reservacion);
            }
            if (ok)
            {
                MessageBox.Show("Bien");
                Actualiza();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
