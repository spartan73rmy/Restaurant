using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
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

namespace CapaPresentacion.Reporte
{
    public partial class CorteCaja : MaterialForm
    {
        public CorteCaja(bool maximized)
        {
            InitializeComponent();
            if (maximized)
                MaximizeWindow(maximized);
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            materialListView1.Items.Clear();
            DateTime fecha = dateTimePicker1.Value.Date;
            DateTime fecha2 = dateTimePicker2.Value.Date;
            List<RegistroProducto> lista = ControlRegistroProducto.Instance.GetLista(fecha2, fecha);

            //lista.Sort();

            Dictionary<RegistroProducto, int> registros = new Dictionary<RegistroProducto, int>();


            decimal total = 0;

            foreach (RegistroProducto c in lista)
            {
                if (!registros.ContainsKey(c))
                {
                    registros.Add(c, c.cantidad);
                }
                else
                {
                    int cantidad = registros[c];
                    registros[c] = cantidad + c.cantidad;
                }
            }

            foreach (var c in registros)
            {
                RegistroProducto registro = c.Key;
                int cantidad = c.Value;
                // TarjetaCliente tarjeta = new TarjetaCliente(c, this);
                ListViewItem item = new ListViewItem(
                    new string[] {
                        registro.nombre_producto,
                        registro.nombre_tipo,
                        cantidad.ToString(),
                        registro.precio_tipo.ToString(),
                        (registro.precio_tipo * cantidad).ToString()
                    });
                item.Tag = c;
                total += registro.precio_tipo * cantidad;
                materialListView1.Items.Add(item);
            }

            materialLabel3.Text = "Total: " + total.ToString(".00");
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
