using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.ControlesPropios;
using CapaAccesoDatos;
using MaterialSkin.Controls;
using System.IO;
using CapaLogica.ControlEntidades;

namespace CapaPresentacion.Trabajadores
{
    public partial class TarjetaMesero : Tarjeta
    {
        private Trabajador mesero;

        public TarjetaMesero(Trabajador mesero)
        {
            this.mesero = mesero;
            InitializeComponent();
            Texto = mesero.nombre + " " + mesero.apellidos;
            LoadImage();
            
        }

        private async void LoadImage()
        {
            if (mesero.TrabajadorImagen == null)
            {
                await Task.Run(() => ControlTrabajadores.Imagenes.Instance.LoadImage(mesero));
                Image = mesero.TrabajadorImagen.Image;
            }
        }
        
    }
}
