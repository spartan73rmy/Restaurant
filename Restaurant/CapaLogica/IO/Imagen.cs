using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.IO
{
    public class Imagen : Archivos
    {
        private static Bitmap defaultImage = global::CapaLogica.Properties.Resources.noimage;
        public static Bitmap DesdeArchivo(string file)
        {
            if (File.Exists(file))
            {
                Bitmap img;
                using (var bmpTemp = new Bitmap(file))
                {
                    img = new Bitmap(bmpTemp);
                }
                return img;
            }
            return defaultImage;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                using (var img = Image.FromStream(ms))
                {
                    return new Bitmap(img);
                }
            }
        }


    }
}
