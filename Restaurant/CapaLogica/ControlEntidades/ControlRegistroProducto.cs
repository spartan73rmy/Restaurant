using CapaAccesoDatos;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlRegistroProducto : IControlEntidad<RegistroProducto>
    {

        private ControlRegistroProducto() { }

        private static ControlRegistroProducto instance;
        public static ControlRegistroProducto Instance
        {
            get
            {
                if (instance == null) instance = new ControlRegistroProducto();
                return instance;
            }
        }

        public bool Agregar(RegistroProducto entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.RegistroProducto.Add(entidad);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return false;
            }
        }

        public bool Editar(RegistroProducto entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(RegistroProducto entidad)
        {
            throw new NotImplementedException();
        }
        public List<RegistroProducto> GetLista(DateTime date)
        {
            List<RegistroProducto> lista = null;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    lista = db.RegistroProducto.Where(m => m.fecha >= date).ToList();
                    return lista;
                }
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return null;
            }
        }
        public List<RegistroProducto> GetLista(DateTime date, DateTime date2)
        {
            List<RegistroProducto> lista = null;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {

                    var query = (from c in db.RegistroProducto
                                 group c by c.id_producto into g
                                 select new
                                 {
                                     id_producto = g.Key,
                                     Sum = g.Sum(oi => oi.cantidad * oi.precio_tipo),
                                 }).OrderBy(m => m.Sum).ToList();

                    //return query;
                    lista = db.RegistroProducto.Where(m => m.fecha >= date && m.fecha <= date2).OrderBy(m => m.nombre_producto).ToList();
                    return lista;

                }
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return null;
            }
        }
        public List<RegistroProducto> GetLista()
        {
            List<RegistroProducto> lista = null;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    lista = db.RegistroProducto.ToList();
                    return lista;
                }
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return null;
            }
        }
    }
}
