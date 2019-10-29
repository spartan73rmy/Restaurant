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
    public class ControlClientes : IControlEntidad<Cliente>
    {
        private static ControlClientes instance;
        private ControlClientes() { }

        public static ControlClientes Instance
        {
            get
            {
                if (instance == null) instance = new ControlClientes();
                return instance;
            }
        }

        public bool Agregar(Cliente entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Cliente.Add(entidad);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception e)
            {
                Logger.Log.Write("Ha ocurrido un error " + e.Message);
            }
            return false;
        }

        public bool Editar(Cliente entidad)
        {
            if (entidad.id_cliente <= 0) return false;
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
                
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return false;
        }

        public bool Eliminar(Cliente entidad)
        {
            if (entidad.id_cliente <= 0) return false;

            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Entry(entidad).State = EntityState.Deleted;
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

        public List<Cliente> GetLista()
        {
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Cliente.OrderBy(c => c.nombre).ToList();
                }
            }
            catch (Exception e)
            {
                Log.Write("Error: " + e.Message);
                return null;
            }
        }
    }
}
