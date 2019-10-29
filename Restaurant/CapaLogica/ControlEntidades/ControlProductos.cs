using CapaAccesoDatos;
using CapaLogica.IO;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlProductos : IControlEntidad<Producto>
    {
        public class Imagenes
        {
            private static Imagenes instance;
            private Imagenes() { }
            public static Imagenes Instance
            {
                get
                {
                    if (instance == null) instance = new Imagenes();
                    return instance;
                }
            }

            public Image LoadImage(Producto p)
            {
                Image ret = null;
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    ProductoImagen img = db.ProductoImagen.Find(p.id_producto);
                    p.ProductoImagen = img;
                    ret = img.Image;
                }
                return ret;
            }
        }
        private static ControlProductos instance;
        private ControlProductos()
        {

        }

        public static ControlProductos Instance
        {
            get
            {
                if (instance == null) instance = new ControlProductos();
                return instance;
            }
        }

        public bool Agregar(Producto producto)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Producto.Add(producto);
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


        public bool Editar(Producto entidad)
        {
            if (entidad.id_producto <= 0 || entidad.id_categoria <= 0) return false;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Entry(entidad.ProductoImagen).State = EntityState.Modified;
                    db.Set<Producto>().AddOrUpdate(entidad);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e) { Log.Write("Ha ocurrido un error " + e.Message); }
            return false;
        }

        public bool Eliminar(Producto producto)
        {
            if (producto.id_producto <= 0) return false;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {

                    // TODO agregar un log a todo esto
                    // context.Database.Log = s => Log.Write(s);
                    // context.Entry(producto).State = EntityState.Deleted;
                    // TODO antes de eliminar verificar que no se encuentre en nimguna orden
                    producto = db.Producto.Find(producto.id_producto);
                    db.Producto.Remove(producto);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return false;
            }
        }

        public List<Producto> GetLista(CategoriaProducto categoria)
        {
            List<Producto> lista = null;
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    if (categoria == null)
                    { 
                        lista = context.Producto.Include(p => p.TipoProducto).Include(p=>p.CategoriaProducto).OrderBy(p => p.CategoriaProducto.nombre_categoria).ThenBy(p => p.nombre_producto).ToList();
                    }
                    else
                    {
                        lista = context.Producto.Include(p => p.TipoProducto).
                            Where(pr => pr.id_categoria == categoria.id_categoria).OrderBy(p => p.nombre_producto).ToList();
                    }
                }

                foreach (Producto m in lista)
                {
                    if (categoria != null)
                        m.CategoriaProducto = categoria;
                }

                return lista;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return lista;
            }
        }
        public List<Producto> GetLista()
        {
            return GetLista(null);
        }

    }
}
