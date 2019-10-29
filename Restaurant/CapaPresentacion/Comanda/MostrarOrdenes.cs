using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Caja;
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
    public partial class MostrarOrdenes : MaterialForm
    {
        private Orden orden;
        public MostrarOrdenes(bool maximized, Orden orden)
        {
            this.orden = orden;
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);
            if (maximized)
                MaximizeWindow(maximized);

            ScrollIni();

            opciones1.Clear();
            opciones1.AgregarOpcion("Agregar", Properties.Resources.F_baseline_add_circle_outline_white_18, new MouseEventHandler(
                (o, s) =>
                {
                    AgregarProducto();
                }));


            opciones1.AgregarOpcion("Pagar", Properties.Resources.F_baseline_receipt_white_18, new MouseEventHandler(
                (o, s) =>
                {
                    CompletarOrden();
                }));
        }

        private void ScrollIni()
        {

            contenedorTarjetas.AutoScroll = false;
            contenedorTarjetas.HorizontalScroll.Visible = false;
            contenedorTarjetas.HorizontalScroll.Enabled = false;
            contenedorTarjetas.HorizontalScroll.Maximum = 0;
            contenedorTarjetas.AutoScroll = true;
        }

        private void AgregarProducto()
        {
            using (AgregarOrdenFrm agregar = new AgregarOrdenFrm(Maximized, orden))
            {
                agregar.ShowDialog(this);
                if (agregar.Changed) Actualiza();
            }
        }

        private void Actualiza()
        {
            contenedorTarjetas.Controls.Clear();
            var listaProductos = ControlOrdenProductos.Instance.GetLista(orden);

            if (listaProductos.Count <= 0 || listaProductos == null)
            {
                return;
            }

            foreach (OrdenProducto producto in listaProductos)
            {
                OrdenUserControl orden = new OrdenUserControl(producto);
                contenedorTarjetas.Controls.Add(orden);
            }
        }

        private void CompletarOrden()
        {
            

            using(PagosFrm pagar = new PagosFrm(Maximized, orden))
            {
                pagar.ShowDialog(this);
                if (true) return;
            }

            orden.total = 0;
            orden.activa = false;


            var listaOrdenesProducto = ControlOrdenProductos.Instance.GetLista(orden);
            if (listaOrdenesProducto.Count <= 0 || listaOrdenesProducto == null)
            {
                return;
            }
            foreach (OrdenProducto productoOrden in listaOrdenesProducto)
            {
                orden.total += productoOrden.precio * productoOrden.cantidad;
                foreach(ProductoVariante variante in productoOrden.ProductoVariante)
                {
                    orden.total += variante.precio_variante * productoOrden.cantidad;
                }
            }
            ControlOrdenes.Instance.Editar(orden);
            MessageBox.Show("Llevar a caja total: " + orden.total);
            orden = null;
            Close();
        }

        private void OrdenesPorMesa_Load(object sender, EventArgs e)
        {
            Actualiza();
        }
    }
}
