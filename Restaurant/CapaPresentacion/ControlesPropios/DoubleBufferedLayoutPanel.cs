using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ControlesPropios
{
    public class DoubleBufferedLayoutPanel : FlowLayoutPanel
    {
        public DoubleBufferedLayoutPanel()
        {
            DoubleBuffered = true;
        }

        public new bool DoubleBuffered
        {
            get
            {
                return base.DoubleBuffered;
            }
            set
            {
                base.DoubleBuffered = value;
            }
        }
    }
}
