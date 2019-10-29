using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Utilerias.Controles
{
    //TODO buscarle un mejor nombre a la clase
    public class Helper
    {
        public static bool Vacio(Control f)
        {
            if (f.Text == null) return true;
            if (f.Text.Trim().Length == 0) return true;
            return false;
        }

        public static void VaciarTexto(params Control[] control)
        {
            foreach (Control c in control)
            {
                c.Text = string.Empty;
            }
        }

        public static bool Llenos(params Control[] control)
        {
            // return control.Where(c => Vacio(c)).ToList().Count == 0;
            foreach (Control c in control)
            {
                if(Vacio(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static void AlgoONada()
        {

        }

    }
}
