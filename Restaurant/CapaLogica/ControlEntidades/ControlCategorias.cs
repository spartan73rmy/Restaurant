using CapaAccesoDatos;
using CapaLogica.IO;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlCategorias : IControlEntidad<CategoriaProducto>
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

            public Image LoadImage(CategoriaProducto p)
            {
                Image ret = null;
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    CategoriaProductoImagen img = db.CategoriaProductoImagen.Find(p.id_categoria);
                    p.CategoriaProductoImagen = img;
                    if (img != null)
                        ret = img.Image;
                }
                return ret;
            }
        }
        private static ControlCategorias instance = null;
        private ControlCategorias() { }
        public static ControlCategorias Instance
        {
            get
            {
                if (instance == null) instance = new ControlCategorias();
                return instance;
            }
        }



        public bool Agregar(string nombreC)
        {
            return Agregar(new CategoriaProducto()
            {
                nombre_categoria = nombreC
            });
        }

        public bool Agregar(CategoriaProducto categoria)
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.CategoriaProducto.Add(categoria);
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


        public bool Editar(CategoriaProducto entidad)
        {
            if (entidad.id_categoria <= 0) return false;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Entry(entidad.CategoriaProductoImagen).State = EntityState.Modified;
                    db.Entry(entidad).State = EntityState.Modified;
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



        public bool Eliminar(CategoriaProducto categoria)
        {
            if (categoria.id_categoria <= 0) return false;

            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    categoria = db.CategoriaProducto.Find(categoria.id_categoria);
                    //db.Entry(categoria).State = EntityState.Deleted;
                    db.CategoriaProducto.Remove(categoria);
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

        public List<CategoriaProducto> GetLista()
        {
            List<CategoriaProducto> lista = null;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    lista = db.CategoriaProducto.OrderBy(cp => cp.nombre_categoria).ToList();
                }

                return lista;
            }
            catch (Exception e)
            {
                string s = e.Message;
                Log.Write("Ha ocurrido un error " + s);
            }
            return lista;
        }

    }
}
