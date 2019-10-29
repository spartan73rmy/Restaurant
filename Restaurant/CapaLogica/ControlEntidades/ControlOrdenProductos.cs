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
    public class ControlOrdenProductos : IControlEntidad<OrdenProducto>
    {
        private static ControlOrdenProductos instance;
        private ControlOrdenProductos() { }

        public static ControlOrdenProductos Instance
        {
            get
            {
                if (instance == null) instance = new ControlOrdenProductos();
                return instance;
            }
        }

        public bool Agregar(OrdenProducto entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    if (entidad.TipoProducto != null) entidad.TipoProducto = null;
                    foreach (ProductoVariante pv in entidad.ProductoVariante)
                    {
                        db.ProductoVariante.Attach(pv);
                    }
                    if (entidad.Orden != null)
                    {
                        entidad.Orden = db.Orden.Include(o => o.Mesa).Where(o => o.id_orden == entidad.id_orden).FirstOrDefault();
                        
                    }
                    db.OrdenProducto.Add(entidad);
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

        public bool Editar(OrdenProducto entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Set<OrdenProducto>().AddOrUpdate(entidad);
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
        public OrdenProducto Cargar(OrdenProducto entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    OrdenProducto nueva = db.OrdenProducto.
                        Include(op => op.TipoProducto.Producto).
                        Where(a => a.id_orden_producto == entidad.id_orden_producto).
                        First();
                    return nueva;
                }
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return null;
            }
        }


        public bool Eliminar(OrdenProducto entidad)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    entidad = db.OrdenProducto.Find(entidad.id_orden_producto);
                    db.Entry(entidad).State = EntityState.Deleted;
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

        public List<OrdenProducto> GetLista(bool activa = true)
        {
            List<OrdenProducto> lista = null;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    // TODO Mejorar como se sabra el status de cada orden
                    // db.Database.Log = s => Log.Write(s);
                    if (activa)
                    {
                        lista = db.OrdenProducto.
                            Include(op => op.ProductoVariante).
                            Include(op => op.TipoProducto.Producto).
                            Include(op => op.Orden.Mesa).Where(op => op.status == "En cola")
                            .ToList();
                    }
                    else
                    {
                        lista = db.OrdenProducto.
                            Include(op => op.ProductoVariante).
                            Include(op => op.TipoProducto.Producto).
                            Include(op => op.Orden.Mesa)
                            .ToList();
                    }

                    // var x = ( from pv in  );
                }
                return lista;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
            }
            return lista;
        }

        public List<OrdenProducto> GetLista(Orden orden, bool completa = false)
        {
            List<OrdenProducto> lista = null;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    if (orden != null)
                    {
                        // db.Database.Log = s => Log.Write(s);
                        lista = db.OrdenProducto.
                            Include(op => op.ProductoVariante).
                            Include(op => op.TipoProducto.Producto.CategoriaProducto).
                            Include(op => op.Orden.Mesa)
                            .Where(op => op.id_orden == orden.id_orden).ToList();
                    } else
                    {
                        lista = db.OrdenProducto.
                            Include(op => op.ProductoVariante).
                            Include(op => op.TipoProducto.Producto.CategoriaProducto).
                            Include(op => op.Orden.Mesa).ToList();
                    }

                    // var x = ( from pv in  );
                }
                return lista;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
            }
            return lista;
        }

        public List<OrdenProducto> GetLista()
        {
            return GetLista(null);
        }
    }
}
