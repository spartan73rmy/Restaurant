using CapaAccesoDatos;
using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public class ControlEstadoMesa : IControlEntidad<EstadoMesa>
    {
        Mesa mesa;

        static ControlEstadoMesa instance;
        
        public ControlEstadoMesa() { }

        public static ControlEstadoMesa Instance
        {
            get
            {
                if (instance == null) instance = new ControlEstadoMesa();
                return instance;
            }
        }

        public bool Agregar(EstadoMesa entidad)
        {
            throw new NotImplementedException();
        }

        public bool Editar(EstadoMesa entidad)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(EstadoMesa entidad)
        {
            throw new NotImplementedException();
        }

        public List<EstadoMesa> GetLista()
        {
            try
            {
                using (RestaurantEntities db = new RestaurantEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    // return db.Mesa.OrderBy(m => m.nombre).ToList();
                    return db.EstadoMesa.OrderBy(m => m.nombre_estado).ToList();
                }
            }
            catch (Exception e)
            {
                Log.Write("Error " + e.Message);
                return null;
            }

        }



        public override string ToString()
        {
            return mesa.EstadoMesa.ToString();
        }
    }
}
