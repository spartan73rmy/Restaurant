using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.ControlEntidades
{
    public interface IControlEntidad <T>
    {
        bool Agregar(T entidad);
        bool Editar(T entidad);
        bool Eliminar(T entidad);
        List<T> GetLista();
        
    }
}
