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

namespace CapaPresentacion.Trabajadores
{
    public partial class TrabajadorFrm : MaterialForm
    {
        List<Trabajador> trabajadores;
        public TrabajadorFrm(bool maximized, List<Trabajador> trabajadores)
        {
            InitializeComponent();
            this.trabajadores = trabajadores;
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);

            var listaPuesto = ControlPuestos.Instance.GetLista();
            if (listaPuesto == null) { MessageBox.Show("Revisa tu coneccion"); return; }
            if (listaPuesto.Count > 0)
            {

                foreach (Puesto puesto in listaPuesto)
                {

                    opciones1.AgregarOpcion(puesto.nombre_puesto, Properties.Resources.F_baseline_person_outline_white_18, new MouseEventHandler(
                        (e, a) =>
                        {
                            UpdateList(ControlTrabajadores.Instance.GetLista(puesto));
                        }
                      ));
                }
            }

            UpdateList(trabajadores);

        }

        private TarjetaMesero CrearTarjeta(Trabajador trabajador)
        {

            TarjetaMesero tarjeta = new TarjetaMesero(trabajador)
            {
                FontSize = 18
                
            };
            tarjeta.MouseClick += (sender, e) =>
            {
                if (e.Button == MouseButtons.Right) return;
                using (EditarTrabajador editar = new EditarTrabajador(trabajador))
                {
                    editar.ShowDialog(this);
                    if (editar.Changed)
                    {
                        UpdateList();
                    }
                }
            };
            return tarjeta;
        }

        private void UpdateList(List<Trabajador> nuevaLista)
        {
            contenedorTarjetas.Controls.Clear();

            if (nuevaLista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (Trabajador mesero in nuevaLista)
            {
                if (mesero.nombre.Equals("root"))
                {
                    continue;
                }
                contenedorTarjetas.Controls.Add(CrearTarjeta(mesero));
            }
        }
        private async void UpdateList()
        {
            List<Trabajador> lista = await Task.Run(() => ControlTrabajadores.Instance.GetLista());
            UpdateList(lista);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (EditarTrabajador agregar = new EditarTrabajador())
            {
                agregar.ShowDialog(this);
                if (agregar.Changed)
                {
                    UpdateList();
                }
            }
        }

        private void contenedorTarjetas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
