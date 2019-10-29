using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public partial class CategoriaProducto
    {
        public override string ToString()
        {
            return nombre_categoria;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CategoriaProducto)) return false;

            CategoriaProducto otra = (CategoriaProducto)obj;

            if (otra.id_categoria != this.id_categoria) return false;
            if (otra.nombre_categoria != this.nombre_categoria) return false;
            return true;
        }

        // TODO cambiar esto
        public void LoadImage()
        {
            if (CategoriaProductoImagen == null)
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    CategoriaProductoImagen img = db.CategoriaProductoImagen.Find(id_categoria);
                    CategoriaProductoImagen = img;
                }
            }
        }

        public override int GetHashCode()
        {
            var hashCode = -940782600;
            hashCode = hashCode * -1521134295 + id_categoria.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre_categoria);
            return hashCode;
        }
    }
}
