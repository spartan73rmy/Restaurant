using CapaAccesoDatos;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlReservaciones : IControlEntidad<Reservacion>
    {
        private static ControlReservaciones instance;
        public ControlReservaciones() { }

        public static ControlReservaciones Instance
        {
            get
            {
                if (instance == null) instance = new ControlReservaciones();
                return instance;
            }
        }

        public bool Agregar(Reservacion entidad)
        {
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Reservacion.Add(entidad);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Log.Write("Error: " + e.Message);
                return false;
            }
        }

        public bool Editar(Reservacion entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Reservacion entidad)
        {
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    
                    Mesa m = entidad.Mesa;
                    m.id_estado = 1;
                    bool ok = ControlMesas.Instance.Editar(m);

                    entidad = context.Reservacion.Find(entidad.id_reservacion);
                    context.Reservacion.Remove(entidad);
                    context.SaveChanges();
                    return ok;
                }
            }
            catch (Exception e)
            {
                Log.Write("Error: " + e.Message);
                return false;
            }
        }

        public List<Reservacion> GetLista()
        {
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    return context.Reservacion.OrderBy(r=>r.fecha).Include(m => m.Cliente).Include(m => m.Mesa).Where(c => c.activa).ToList();
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
