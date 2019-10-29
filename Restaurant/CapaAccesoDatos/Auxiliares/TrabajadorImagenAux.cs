using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public partial class TrabajadorImagen
    {
        private Bitmap image;
        public Image Image
        {
            get
            {
                if (image == null) image = ImagenUtils.ByteArrayToImage(imagen);
                return image;
            }
            set
            {
                imagen = ImagenUtils.ImageToByteArray(value);
            }
        }
    }
}
