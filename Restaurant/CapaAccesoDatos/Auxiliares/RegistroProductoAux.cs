using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public partial class RegistroProducto : IComparable<RegistroProducto>
    {
        public int CompareTo(RegistroProducto other)
        {
            if (this.nombre_producto != other.nombre_producto) return string.Compare(this.nombre_producto, other.nombre_producto);
            return string.Compare(this.nombre_tipo, other.nombre_tipo);
        }

        public override bool Equals(object obj)
        {
            var producto = obj as RegistroProducto;
            return producto != null &&
                   id_tipo_producto == producto.id_tipo_producto;
        }

        public override int GetHashCode()
        {
            return 1981354152 + id_tipo_producto.GetHashCode();
        }
    }
}
