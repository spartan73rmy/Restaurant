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

namespace CapaPresentacion.Comanda
{
    public partial class PedidosActivosFrm : MaterialForm
    {
        private List<OrdenProducto> listaActual;
        public PedidosActivosFrm(bool maximized)
        {
            listaActual = new List<OrdenProducto>();
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);
        }

        private void Actualiza()
        {
            List<OrdenProducto> listaProductos = ControlOrdenProductos.Instance.GetLista(activa: true);
            if (listaProductos == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            if (listaProductos.All(listaActual.Contains) && listaActual.All(listaProductos.Contains)) return;
            contenedorTarjetas.Controls.Clear();
            foreach (OrdenProducto producto in listaProductos)
            {
                OrdenUserControl orden = new OrdenUserControl(producto);
                contenedorTarjetas.Controls.Add(orden);
            }
            listaActual = listaProductos;
        }

        private void PedidosActivosFrm_Load(object sender, EventArgs e)
        {
            Actualiza();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Actualiza();
        }
    }
}
