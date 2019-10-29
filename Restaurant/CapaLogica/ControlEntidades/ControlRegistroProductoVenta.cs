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
   public class ControlRegistroProductoVenta : IControlEntidad<RegistroProductoVenta>
    {
        private static ControlRegistroProductoVenta instance;

        public static ControlRegistroProductoVenta Instance
        {
            get
            {
                if (instance == null) instance = new ControlRegistroProductoVenta();
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

        public bool Agregar(RegistroProductoVenta entidad)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Producto entidad)
        {
            return false;
        }

        public bool Editar(RegistroProductoVenta entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Producto producto)
        {
            return false;
        }

        public bool Eliminar(RegistroProductoVenta entidad)
        {
            throw new NotImplementedException();
        }

        public List<RegistroProductoVenta> GetLista(List<Producto> selected)
        {
            List<RegistroProductoVenta> lista = null;
            try
            {

                using (RestaurantEntities context = new RestaurantEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    if (selected != null && selected.Count>0)
                    {
                        //Genera la cadena para consulta del tipo param,param2,...paramN
                        string consulta = "";
                        foreach (Producto item in selected)
                        {
                            consulta += item.id_producto + ",";
                        }

                        consulta = consulta.Substring(0, consulta.Length - 1);
                        //Falta agregar los productos

                        lista = context.getRegistroProducto1(consulta).ToList();

                        
                        //lista = context.RegistroProductoVenta.Include(prop => prop.Producto).ToList();

                        //lista = context.Database.
                        //    SqlQuery<RegistroProductoVenta>("dbo.getRegistroProducto @chain", new SqlParameter ("@chain",consulta)).ToList();


                        foreach (var item in lista)
                        {
                            Console.WriteLine(item.id_producto);
                        }
                        Console.WriteLine(lista.Count);

                        return lista;

                    }
                    else
                    {
                        return lista = null;
                    }
                }

            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return lista = null;
            }
        }

        public List<RegistroProductoVenta> GetLista()
        {
            return GetLista(null);
        }

        List<RegistroProductoVenta> IControlEntidad<RegistroProductoVenta>.GetLista()
        {
            throw new NotImplementedException();
        }
    }
}
