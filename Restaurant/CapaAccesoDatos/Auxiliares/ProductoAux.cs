using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public partial class Producto
    {
        public override bool Equals(object obj)
        {
            if (!(obj is Producto)) return false;
            Producto other = obj as Producto;

            return other.id_producto == this.id_producto;
        }
    }
}
