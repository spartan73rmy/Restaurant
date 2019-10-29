using CapaAccesoDatos;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlTipoProducto : IControlEntidad<TipoProducto>
    {
        private static ControlTipoProducto instance;
        public static ControlTipoProducto Instance
        {
            get
            {
                if (instance == null) instance = new ControlTipoProducto();
                return instance;
            }
        }
        private ControlTipoProducto() { }

        public bool Agregar(TipoProducto entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.TipoProducto.Add(entidad);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
            }
            return false;
        }

        public bool Editar(TipoProducto entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Set<TipoProducto>().AddOrUpdate(entidad);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
            }
            return false;
        }

        public bool Eliminar(TipoProducto entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    entidad = db.TipoProducto.Find(entidad.id_tipo_producto);
                    db.TipoProducto.Remove(entidad);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
            }
            return false;
        }

        public List<TipoProducto> GetLista(Producto producto)
        {
            List<TipoProducto> lista = null;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    lista = db.TipoProducto.Include(a => a.Producto).Where(p => p.id_producto == producto.id_producto).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
            }
            return lista;
        }
        

        public List<TipoProducto> GetLista()
        {
            return GetLista(null);
        }
    }
}
