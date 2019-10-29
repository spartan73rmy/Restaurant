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

namespace CapaPresentacion
{
    public partial class Mesero : MaterialForm
    {

        public Mesero()
        {
            InitializeComponent();

            MaterialSkinManager.AddFormToManage(this);
            MaterialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.SoftShadow = true;

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
