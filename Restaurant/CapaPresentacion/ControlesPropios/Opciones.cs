using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CapaPresentacion.ControlesPropios
{
    public partial class Opciones : UserControl
    {
        public Opciones()
        {
            InitializeComponent();
            panel1.BackColor = MaterialSkinManager.ColorScheme.PrimaryColor;
            AddBack();
        }

        public MaterialSmallCard AgregarOpcion(string name, Image icon, MouseEventHandler handler)
        {
            MaterialSmallCard card = AgregarOpcion(name, icon);
            card.MouseClick += handler;
            return card;
        }

        private void AddBack()
        {
            AgregarOpcion("Atras", Properties.Resources.F_baseline_arrow_back_white_18, new MouseEventHandler(
                (e, a) =>
                {
                    FindForm().Close();
                }
            ));
        }

        public void Clear()
        {
            panel1.Controls.Clear();
            AddBack();
        }

        public void quitButtons()
        {
            panel1.Controls.Clear();
        }


        public MaterialSmallCard AgregarOpcion(string name, Image icon)
        {
            MaterialSmallCard card = DefaultCard();
            card.Text = name;
            card.Image = icon;
            panel1.Controls.Add(card);
            return card;
        }

        private MaterialSmallCard DefaultCard()
        {
            return new MaterialSmallCard()
            {
                BackColor = Color.Transparent,
                AutoExpand = false,
                Size = new Size(169, 52)
            };
        }
    }
}
