using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.IO
{
    public class Archivos
    {
        public static bool Eliminar(string filename)
        {
            try
            {
                File.Delete(filename);
                return true;
            } catch(Exception e)
            {
                Log.Write("Error " + e.Message);
                return false;
            }
        }
    }
}
