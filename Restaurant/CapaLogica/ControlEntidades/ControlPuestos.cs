using CapaAccesoDatos;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlPuestos : IControlEntidad<Puesto>
    {
        private static ControlPuestos instance = null;
        public ControlPuestos() { }
        public static ControlPuestos Instance
        {
            get
            {
                if (instance == null) instance = new ControlPuestos();
                return instance;
            }
        }

        public bool Agregar(Puesto entidad)
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                context.Puesto.Add(entidad);
                context.SaveChanges();
                return true;
            }



        }

        public bool Editar(Puesto entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Puesto entidad)
        {
            throw new NotImplementedException();
        }

        public List<Puesto> GetLista()
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    return db.Puesto.OrderBy(p => p.nombre_puesto).ToList();
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
