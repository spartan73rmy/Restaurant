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
    public class ControlTrabajadores : IControlEntidad<Trabajador>
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

            public Image LoadImage(Trabajador p)
            {
                Image ret = null;
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    TrabajadorImagen img = db.TrabajadorImagen.Find(p.id_trabajador);
                    p.TrabajadorImagen = img;
                    ret = img.Image;
                }
                return ret;
            }
        }



        private static ControlTrabajadores instance;
        private ControlTrabajadores() { }
        public static ControlTrabajadores Instance
        {
            get
            {
                if (instance == null) instance = new ControlTrabajadores();
                return instance;
            }
        }

        public bool Agregar(Trabajador Trabajador)
        {
            if (Trabajador.id_puesto == 0)
            {
                throw new ArgumentException();
            }
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Trabajador.Add(Trabajador);
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

        public bool Editar(Trabajador entidad)
        {
            if (entidad.id_trabajador <= 0) return false;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Entry(entidad).State = EntityState.Modified;
                    db.Entry(entidad.TrabajadorImagen).State = EntityState.Modified;
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



        public bool Eliminar(Trabajador entidad)
        {
            if (entidad.id_trabajador <= 0) return false;
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    entidad = db.Trabajador.Find(entidad.id_trabajador);
                    db.Trabajador.Remove(entidad);
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

        public List<Trabajador> GetLista(Puesto puesto)
        {
            List<Trabajador> trabajadores = null;
            try
            {
                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    if (puesto == null)
                        trabajadores = context.Trabajador.Include(t => t.Puesto).OrderBy(t => t.apellidos).ThenBy(t => t.nombre).ToList();
                    else
                    {
                        trabajadores = context.Trabajador.Where(t => t.id_puesto == puesto.id_puesto).Include(t => t.Puesto).OrderBy(t => t.apellidos).ThenBy(t => t.nombre).ToList();

                    }
                }

                return trabajadores;
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return trabajadores;
            }
        }

        public List<Trabajador> GetLista()
        {
            return GetLista(null);
        }

    }
}
