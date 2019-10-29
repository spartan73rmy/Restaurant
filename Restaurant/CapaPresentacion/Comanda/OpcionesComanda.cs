using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
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

namespace CapaPresentacion.Comanda
{
    public partial class OpcionesComanda : MaterialForm
    {
        private Mesa mesa;
        private Orden orden;
        public OpcionesComanda(bool maximized, Mesa mesa)
        {
            this.mesa = mesa;
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);
            
        }

        private void btnMostrarOrdenes_Click(object sender, EventArgs e)
        {
            using (MostrarOrdenes ordenar = new MostrarOrdenes(Maximized, orden))
            {
                ordenar.ShowDialog(this);
            }
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            using (AgregarOrdenFrm agregar = new AgregarOrdenFrm(Maximized, orden))
            {
                agregar.ShowDialog(this);
            }
        }

        private void OpcionesComanda_Load(object sender, EventArgs e)
        {
            var lista = ControlOrdenes.Instance.GetLista(mesa);
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }
            if (lista.Count > 1) throw new Exception("Solo puede haber una orden activa");
            if (lista.Count == 0)
            {
                DialogResult boton = MessageBox.Show("No existe ninguna orden, ¿Crear?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (boton != DialogResult.OK)
                {
                    Close();
                    return;
                }
                else
                {
                    orden = new Orden()
                    {
                        id_mesa = mesa.id_mesa,
                        fecha = DateTime.Now,
                        activa = true
                    };
                    
                    ControlOrdenes.Instance.Agregar(orden);
                }
            } else
            {
                orden = lista[0];
            }
        }
    }
}
