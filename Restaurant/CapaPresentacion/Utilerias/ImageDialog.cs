using CapaLogica.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Utilerias
{
    public class ImageDialog
    {
        public static Image OpenImage()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";

            // Todo hacer que se abra con una resolucion maxima de n*m
            // Para no usar mucha ram
            if (op.ShowDialog() == DialogResult.OK)
            {
                Bitmap ret = new Bitmap(Imagen.DesdeArchivo(op.FileName), 256, 256);
                return ret;
            }

            return null;
        }
    }
}
