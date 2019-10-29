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
    public class ControlProductoVariante : IControlEntidad<ProductoVariante>
    {
        private ControlProductoVariante() { }

        private static ControlProductoVariante instance;
        public static ControlProductoVariante Instance
        {
            get
            {
                if (instance == null) instance = new ControlProductoVariante();
                return instance;
            }
        }
        public bool Agregar(ProductoVariante productoVariante)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    // db.Producto.Attach(productoVariante.Producto);
                    db.ProductoVariante.Add(productoVariante);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return false;
        }


        public bool Editar(ProductoVariante entidad)
        {
            if (entidad.id_producto_variante <= 0) return false;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Set<ProductoVariante>().AddOrUpdate(entidad); // de otro modo da problemas esto
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Ha ocurrido un error " + e.Message);
            }
            return false;
        }

        public bool Eliminar(ProductoVariante entidad)
        {
            if (entidad.id_producto_variante <= 0) return false;
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {

                    // TODO agregar un log a todo esto
                    // context.Database.Log = s => Console.WriteLine(s);
                    entidad = context.ProductoVariante.Find(entidad.id_producto_variante);
                    context.ProductoVariante.Remove(entidad);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return false;
            }
        }

        public List<ProductoVariante> GetLista(TipoProducto tipo)
        {
            List<ProductoVariante> lista = null;

            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Configuration.LazyLoadingEnabled = true;
                    // context.Database.Log = s => Log.Write(s);
                    context.Configuration.LazyLoadingEnabled = false;
                    if (tipo == null)
                    {
                        lista = context.ProductoVariante.ToList();
                    }
                    else
                    {
                        lista = context.ProductoVariante.Where(pr => pr.id_tipo_producto == tipo.id_tipo_producto).OrderBy(p => p.nombre_variante).ToList();
                        
                        return lista;
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

        public List<ProductoVariante> GetListaP(TipoProducto tipo)
        {
            List<ProductoVariante> lista = null;

            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    var tmp = context.ProductoVariante.Where(pv => pv.id_tipo_producto == tipo.id_tipo_producto);
                    lista = tmp.ToList();
                }

                return lista;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return lista;
            }
        }
        public List<ProductoVariante> GetLista()
        {
            return GetLista(null);
        }

    }
}
