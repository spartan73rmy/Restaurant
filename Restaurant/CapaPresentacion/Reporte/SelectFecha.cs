using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reporte
{
    public partial class SelectFecha : MaterialForm
    {
        DateTime fechaInicio = new DateTime();
        DateTime fechaFin = new DateTime();

        public SelectFecha(bool Maximized)
        {
            
            InitializeComponent();
            if (Maximized)
                MaximizeWindow(Maximized);
            

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            fechaInicio=dateTimePicker1.Value;
            fechaFin = dateTimePicker2.Value;
            if (fechaInicio>fechaFin)
            {
                MessageBox.Show("La fecha de inicio debe anterior a la de fin");
                return;
            }
            Close();
        }

        public DateTime FechaInicio() { return fechaInicio; }
        public DateTime FechaFin() { return fechaFin; }
    }
}
