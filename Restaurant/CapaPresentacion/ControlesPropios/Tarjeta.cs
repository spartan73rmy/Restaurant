using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ControlesPropios
{
    public partial class Tarjeta : UserControl
    {
        public Tarjeta()
        {
            InitializeComponent();
        }


        [Description("Test text displayed in the label"), Category("Data")]
        public string Texto
        {
            get { return materialLabel1.Text; }
            set { materialLabel1.Text = value; }
        }

        [Description("FontSize displayed in the label"), Category("Data")]
        public int FontSize
        {
            get { return materialLabel1.FontSize; }
            set { materialLabel1.FontSize = value; }
        }

        [Description("Picture text displayed in the textbox"), Category("Data")]
        public Image Image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        [Description("Picture text displayed in the textbox"), Category("Data")]
        public Color ColorFondo
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        private void Tarjeta_Load(object sender, EventArgs e)
        {
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.FontSize = 14;
            this.Update();
        }


        // Agregar este evento a todos los controles
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        // Agregar este evento a todos los controles
        public new event MouseEventHandler MouseClick
        {
            add
            {
                base.MouseClick += value;
                foreach (Control control in Controls)
                {
                    control.MouseClick += value;
                }
            }
            remove
            {
                base.MouseClick -= value;
                foreach (Control control in Controls)
                {
                    control.MouseClick -= value;
                }
            }
        }

        // Agregar este evento a todos los controles
        public new event EventHandler MouseEnter
        {
            add
            {
                base.MouseEnter += value;
                foreach (Control control in Controls)
                {
                    control.MouseEnter += value;
                }
            }
            remove
            {
                base.MouseEnter -= value;
                foreach (Control control in Controls)
                {
                    control.MouseEnter -= value;
                }
            }
        }

        // Agregar este evento a todos los controles
        public new event EventHandler MouseLeave
        {
            add
            {
                base.MouseLeave += value;
                foreach (Control control in Controls)
                {
                    control.MouseLeave += value;
                }
            }
            remove
            {
                base.MouseLeave -= value;
                foreach (Control control in Controls)
                {
                    control.MouseLeave -= value;
                }
            }
        }

        private void this_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Tarjeta_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void materialLabel1_Paint(object sender, PaintEventArgs e)
        {
            if(materialLabel1.BackColor != Color.Transparent)
            {
                materialLabel1.BackColor = Color.Transparent;
            }
        }
    }
}
