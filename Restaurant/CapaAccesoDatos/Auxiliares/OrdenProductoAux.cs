using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public partial class OrdenProducto
    {
        public override bool Equals(object obj)
        {
            if (!(obj is OrdenProducto)) return false;
            OrdenProducto other = obj as OrdenProducto;
            if (id_orden_producto != other.id_orden_producto) return false;
            if (this.precio != other.precio) return false;
            if (this.comentarios != other.comentarios) return false;
            if (this.status != other.status) return false;
            if (this.cantidad != other.cantidad) return false;
            if (this.id_tipo_producto != other.id_tipo_producto) return false;
            return true;
        }
    }
}
