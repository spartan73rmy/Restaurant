using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Clientes;
using CapaPresentacion.Utilerias.Controles;
using MaterialSkin;
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

namespace CapaPresentacion.Mesas
{
    public partial class AgregarReservacionFrm : MaterialForm
    {
    
        int Hora=12, Min=1,Dur=1;
        string[] Hora_Format = new string[2];

        DateTime fecha;

        public AgregarReservacionFrm(bool maximized)
        {
            InitializeComponent();
            if (maximized)
                MaximizeWindow(maximized);
            MaterialSkinManager.AddFormToManage(this);
            ActualizaClientes(); ActualizaMesas();

            materialDivider1.BackColor = Color.DarkRed;
            string[] temp = HoraMas();
            txtHora.Text = temp[0];
            lblHora.Text = temp[1];
            txtDuracion.Text = ""+Dur;
            txtMinutos.Text = MinutosMenos();
        }

        private void ActualizaClientes()
        {
            listClientes.Items.Clear();
            var lista = ControlClientes.Instance.GetLista();
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (Cliente c in lista)
            {
                ListViewItem item = new ListViewItem(c.nombre + " " + c.apellidos);
                item.Tag = c;
                listClientes.Items.Add(item);
            }
        }

        private void ActualizaMesas()
        {
            listMesas.Items.Clear();
            var lista = ControlMesas.Instance.GetLista(true);
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (Mesa c in lista)
            {
                ListViewItem item = new ListViewItem(c.nombre_mesa);
                item.Tag = c;
                listMesas.Items.Add(item);
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            using(EditarCliente nuevo = new EditarCliente())
            {
                nuevo.ShowDialog(this);
                ActualizaClientes();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField []textBoxes = { txtDuracion, txtHora, txtMinutos };

            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Selecciona una fecha valida");
                return;
            }

            if (listMesas.SelectedItems.Count != 1 || listClientes.SelectedItems.Count != 1 || !Helper.Llenos(textBoxes))
            {
                MessageBox.Show("Error selecciona una mesa y despues un cliente, fecha y hora para la reservacion");
                return;
            }

            Cliente cliente = listClientes.SelectedItems[0].Tag as Cliente;
            Mesa mesa = listMesas.SelectedItems[0].Tag as Mesa;
            fecha = dateTimePicker1.Value.Date;
            DateTime hora = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 17, Hora, Min, 0);
            DateTime horaFinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 17, Hora, Min, 0);
            

            Reservacion nueva = new Reservacion()
            {
                id_cliente = cliente.id_cliente,
                id_mesa = mesa.id_mesa,
                activa = true,
                fecha = fecha,
                hora_inicio = hora,
                hora_fin = horaFinal.AddHours(Dur)
            };
            mesa.EstadoMesa = null;

            if (fecha.Date == DateTime.Now.Date)
            {
                mesa.id_estado = 4;
            }
            else
            {
                mesa.id_estado = 1;
            }

            if (ControlReservaciones.Instance.Agregar(nueva) && ControlMesas.Instance.Editar(mesa))
            {
                MessageBox.Show("Bien");
                Close();
            } else
            {
                MessageBox.Show("Error");
                Close();
            }

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }


        private void btnMenos_Click(object sender, EventArgs e)
        {
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
        }

        private void listMesas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMenos_Click_1(object sender, EventArgs e)
        {
            string[] temp = HoraMenos();
            txtHora.Text = temp[0];
            lblHora.Text = temp[1];
        }

        private void btnMas_Click_1(object sender, EventArgs e)
        {
            string[] temp = HoraMas();
            txtHora.Text = temp[0];
            lblHora.Text = temp[1];
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            txtMinutos.Text = MinutosMenos();
        }

        private void materialRaisedButton2_Click_1(object sender, EventArgs e)
        {
            txtMinutos.Text = MinutosMas();
        }


        #region Tiempo

        #region Hora
        private string[] HoraMas()
        {
            Hora += 1;

            if (Hora > 24)
            {
                Hora = 1;
            }

            if (Hora > 12)
            {
                Hora_Format[0] = "" + (Hora - 12);
                Hora_Format[1] = "PM";
            }
            else
            {
                Hora_Format[0] = "" + (Hora);
                Hora_Format[1] = "AM";
            }
            return Hora_Format;
        }

        private string[] HoraMenos()
        {
            Hora -= 1;

            if (Hora <= 0)
            {
                Hora = 24;
            }

            if (Hora > 24)
            {
                Hora = 1;
            }

            if (Hora > 12)
            {
                Hora_Format[0] = "" + (Hora - 12);
                Hora_Format[1] = "PM";
            }
            else
            {
                Hora_Format[0] = ""+Hora;
                Hora_Format[1] = "AM";
            }
            return Hora_Format;
        }
        #endregion Hora

        #region Minutos
        private string MinutosMas()
        {
            string cad;
            Min += 1;

            if (Min < 0)
            {
                Min = 59;
            }

            if (Min >= 60)
            {
                Min = 0;
            }

            cad = "" + Min;
            return cad;

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Dur += 1;
            if (Dur > 10)
            {
                Dur = 1;
            }
            txtDuracion.Text = "" + Dur;
        }

        private void materialPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Dur -= 1;
            if (Dur < 1)
            {
                Dur = 1;
            }
            txtDuracion.Text = "" + Dur;
        }

        private string MinutosMenos()
        {
            string cad;
            Min -= 1;

            if (Min < 0)
            {
                Min = 59;
            }

            if (Min > 60)
            {
                Min = 0;
            }

            cad = "" + Min;
            return cad;
        }
        #endregion Minutos

        #endregion Tiempo
    }
}
