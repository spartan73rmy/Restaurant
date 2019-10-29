using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Clientes;
using CapaPresentacion.Ejemplo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Thread(() =>
            {
                ControlProductos.Instance.GetLista();
            }).Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginFrm login = new LoginFrm();
            if (false)
            {
                Application.Run(new VentanaPricipal(login.Trabajador));
                return;
            }

            
            Application.Run(login);

            if(login.Logged)
            {
                Application.Run(new VentanaPricipal(login.Trabajador));

            }
            // Application.Run(new ControlProductosFrm());

            // Application.Run(new FlowLayoutPane());

        }
    }
}
