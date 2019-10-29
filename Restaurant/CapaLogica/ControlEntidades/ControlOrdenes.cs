using CapaAccesoDatos;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlOrdenes : IControlEntidad<Orden>
    {
        private static ControlOrdenes instance;
        private ControlOrdenes() { }

        public static ControlOrdenes Instance
        {
            get
            {
                if (instance == null) instance = new ControlOrdenes();
                return instance;
            }
        }

        public bool Agregar(Orden entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Orden.Add(entidad);
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

        public bool Editar(Orden entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Set<Orden>().AddOrUpdate(entidad);
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

        public bool Eliminar(Orden entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    entidad = db.Orden.Find(entidad.id_orden);
                    db.Orden.Remove(entidad);
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

        
        public List<Orden> GetLista(Mesa mesa = null, bool activas = true)
        {
            List<Orden> lista = null;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    if (mesa == null)
                    {
                        if (activas) lista = db.Orden.Include(o => o.OrdenProducto).Where(o => o.activa).ToList();
                        else lista = db.Orden.Include(o => o.OrdenProducto).ToList();
                    }
                    else
                    {
                        // Normalmente se usara esta query
                        if (activas)
                        {
                            /* lista = db.Orden.Include(
                              o => o.OrdenProducto.
                                  Select(op => op.TipoProducto).
                                  Select(p => p.Producto)
                              ).Where(o => o.id_mesa == mesa.id_mesa && o.activa).ToList();*/

                            lista = db.Orden.Include(o => o.OrdenProducto).Where(o => o.id_mesa == mesa.id_mesa && o.activa).ToList();
                        }
                        else lista = db.Orden.Include(o => o.OrdenProducto).Where(o => o.id_mesa == mesa.id_mesa).ToList();

                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return lista;
            }
        }

        public List<Orden> GetLista()
        {
            return GetLista(null);
        }
    }
}
