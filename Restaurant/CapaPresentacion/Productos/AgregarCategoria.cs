using CapaLogica.Productos;
using CapaPresentacion.Utilities;
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

namespace CapaPresentacion.Productos
{
    public partial class AgregarCategoria : MaterialForm
    {
        Filtro filtro = new Filtro();

        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ControlProductos cp = new ControlProductos();
            cp.AgregarCategoria(txtNombre.Text);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtro.SinNumeros(e);
        }
    }
}
