using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.ControlesPropios;
using CapaAccesoDatos;
using MaterialSkin.Controls;

namespace CapaPresentacion.Mesas
{
    public partial class TarjetaMesa : Tarjeta
    {
        public Mesa mesa;
        private Form owner;
        public TarjetaMesa(Mesa mesa, Form owner)
        {
            Image = Properties.Resources.F_B_baseline_weekend_black_48;
            this.mesa = mesa;
            this.owner = owner;
            InitializeComponent();
            Texto = mesa.nombre_mesa+ "\n" + mesa.EstadoMesa.nombre_estado;
            FontSize = 12;
        }

        private void TarjetaMesa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;
        }

        private void stripMenuItemEditar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
