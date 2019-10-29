using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public partial class Puesto
    {
        public override string ToString()
        {
            return nombre_puesto;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Puesto)) return false;
            Puesto puesto = obj as Puesto;
            return puesto.id_puesto == this.id_puesto;
        }
    }
}
