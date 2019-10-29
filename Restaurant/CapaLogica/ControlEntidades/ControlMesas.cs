using CapaAccesoDatos;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlMesas : IControlEntidad<Mesa>
    {
        private static ControlMesas instance;
        private ControlMesas() { }        
        public static ControlMesas Instance
        {
            
            get
            {
                if (instance == null) instance = new ControlMesas();
                return instance;
            }
        }


        public bool Agregar(Mesa entidad)
        {
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Mesa.Add(entidad);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return false;
            }
        }

        public bool Editar(Mesa entidad)
        {
            if (entidad.id_mesa <= 0) return false;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Entry(entidad).State = EntityState.Modified;
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

        public bool Eliminar(Mesa entidad)
        {
            if (entidad.id_mesa <= 0) return false;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    entidad = db.Mesa.Find(entidad.id_mesa);
                    db.Mesa.Remove(entidad);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Log.Write(e.Message,"Error");
                return false;
            }
        }

        public List<Mesa> GetLista(bool disponibles)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    return db.Mesa.Where(m => m.EstadoMesa.nombre_estado == "Disponible").Include(m => m.EstadoMesa).
                        OrderBy(m => m.nombre_mesa).ToList();
                    //return db.Mesa.Include(m => m.EstadoMesa).
                    //    OrderBy(m => m.nombre_mesa).ToList();

                }
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return null;
            }
        }

        public List<Mesa> GetLista()
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    return db.Mesa.Include(m=>m.EstadoMesa).
                        OrderBy(m => m.nombre_mesa).ToList();
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
