using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Reporte
{
    public partial class ReporteFrm : MaterialForm
    {
        const int DINERO = 0, PRODUCTOS = 1;
        List<RegistroProductoVenta> Agregados = new List<RegistroProductoVenta>();
        List<Producto> Seleccionados = new List<Producto>();

        Dictionary<RegistroProductoVenta, DateTime> registroFechado = new Dictionary<RegistroProductoVenta, DateTime>();
        DateTime fechaActual = new DateTime();
        DateTime fechaSeleccionada = new DateTime();

        public ReporteFrm(bool Maximized)
        {
            fechaActual = DateTime.Now;
            fechaSeleccionada = DateTime.Now;

            InitializeComponent();
            MaximizeWindow(Maximized);
            List<RegistroProductoVenta> productoVenta = null;

            chart1.Series["Series1"].LegendText = "Informe";
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;

            lblInicia.Text = "Inicia:" + fechaSeleccionada.ToShortDateString();
            lblTermina.Text = "Finaliza:" + fechaActual.ToShortDateString();

            //chart1.Series["Series1"].ChartType = SeriesChartType.Candlestick;
            //chart1.Series["Series1"].ChartType = SeriesChartType.Bubble;


        }

        private void ReporteFrm_Load(object sender, EventArgs e)
        {
            CargarListViewFechas();

            #region Botones
            opciones1.AgregarOpcion("Seleccionar", Properties.Resources.F_baseline_playlist_add_white_18,
            new MouseEventHandler((o, args) =>
            {
                Seleccionados.Clear();
                registroFechado.Clear();

                using (SeleccionForm seleccion = new SeleccionForm(maximized: true))
                {
                    seleccion.ShowDialog(this);
                    Seleccionados = seleccion.GetListSelected();
                }
                ObtenerRegistro();

            }));

            //opciones1.AgregarOpcion("Dinero", Properties.Resources.F_baseline_local_atm_white_18,
            //new MouseEventHandler((o, args) =>
            //{
            //     MessageBox.Show("En terminos de Money");
            //    HacerReporte(DINERO);
            //}));

            opciones1.AgregarOpcion("Producto", Properties.Resources.F_baseline_fastfood_white_18,
            new MouseEventHandler((o, args) =>
            {
                HacerReporte(PRODUCTOS);
            }));

            #endregion Botones

            // HacerReporte(PRODUCTOS);
        }

        private void ObtenerRegistro()
        {
            //Checamos los elementos
            if (Seleccionados.Count <= 0 || Seleccionados == null) { return; }
            var listaRegistroProducto = ControlRegistroProductoVenta.Instance.GetLista(Seleccionados);
            if (listaRegistroProducto == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (RegistroProductoVenta item in listaRegistroProducto)
            {
                registroFechado.Add(item, item.fecha);
            }
        }

        private void HacerReporte(int Terminos)
        {
            switch (Terminos)
            {
                case DINERO:

                    break;
                case PRODUCTOS:
                    chart1.Series.Clear();

                    IniciarScrollChart();

                    Agregados.Clear();

                    registroFechado.Clear();
                    ObtenerRegistro();

                    chart1.Series["Series1"].LegendText = "Informe de productos";

                    if (registroFechado.Count <= 0)
                    {
                        MessageBox.Show("Seleccione algunos productos", "Aviso");
                        return;
                    }
                    foreach (KeyValuePair<RegistroProductoVenta, DateTime> d in registroFechado)
                    {
                        RegistroProductoVenta temp = new RegistroProductoVenta();
                        temp = (RegistroProductoVenta)d.Key;


                        if (fechaActual >= d.Value && d.Value >= fechaSeleccionada)
                        {
                            if (Agregados.Contains(temp))
                            {
                                temp = Agregados.Find(obj => obj.id_producto == temp.id_producto);
                                temp.cantidad += ((RegistroProductoVenta)d.Key).cantidad;
                                //agregados.Remove(d.Key);
                                //agregados.Add(temp);
                            }
                            else { Agregados.Add(temp); }
                        }
                        temp = null;
                    }

                    if (Agregados.Count <= 0)
                    {
                        MessageBox.Show("Seleccione un intervalo de fecha diferente por favor", "Nada que hacer aqui");
                        return;
                    }

                    foreach (RegistroProductoVenta item in Agregados)
                    {

                        if (item.cantidad < 1)
                            continue;

                        Console.WriteLine(item.nombre_producto + "->" + item.cantidad);
                        chart1.Series["Series1"].Points.AddXY(item.nombre_producto, item.cantidad);
                    }

                    break;
                default:
                    break;
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count <= 0) { return; }
            else
            {
                string op = materialListView1.SelectedItems[0].Tag as string;
                fechaSeleccionada = DateTime.Now;

                switch (op)
                {
                    case "Hoy":
                        fechaSeleccionada = DateTime.Now;
                        break;

                    case "Seleccionar de Fecha de Inicio y Fin":
                        using (SelectFecha fecha = new SelectFecha(false))
                        {
                            fecha.ShowDialog(this);
                            fechaActual = fecha.FechaFin();
                            fechaSeleccionada = fecha.FechaInicio();
                        }
                        break;
                    case "Total a la Fecha":
                        fechaSeleccionada = DateTime.MinValue;
                        break;
                    case "Ultimo Año":
                        fechaSeleccionada = DateTime.Today.AddYears(-1);
                        break;
                    case "Ultimos Seis Meses":
                        fechaSeleccionada = DateTime.Today.AddMonths(-6);

                        break;
                    case "Ultimos Tres Meses":
                        fechaSeleccionada = DateTime.Today.AddMonths(-3);
                        break;
                    case "Ultimo Mes":
                        fechaSeleccionada = DateTime.Today.AddDays(-(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)));
                        break;
                    case "Ultima Semana":
                        fechaSeleccionada = DateTime.Today.AddDays((double)(-7));
                        break;

                    default:
                        using (SelectFecha fecha = new SelectFecha(false))
                        {
                            fecha.ShowDialog(this);
                            fechaActual = fecha.FechaFin();
                            fechaSeleccionada = fecha.FechaInicio();
                        }

                        break;
                }

                lblInicia.Text = "Inicia:" + fechaSeleccionada.ToShortDateString();
                lblTermina.Text = "Finaliza:" + fechaActual.ToShortDateString();

                HacerReporte(PRODUCTOS);
            }
        }

        private void IniciarScrollChart()
        {
            var series = chart1.Series.Add("Series1");
            int blockSize = 20;
            var chartArea = chart1.ChartAreas[series.ChartArea];

            chartArea.AxisX.Title = "Productos";
            chartArea.AxisX.Interval = 1;

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 100000;

            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 100;
            chartArea.AxisY.ScaleView.Zoomable = true;
            chartArea.AxisY.ScaleView.SizeType = DateTimeIntervalType.Number;
            chartArea.CursorY.AutoScroll = true;

            chartArea.CursorX.AutoScroll = true;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;

            int pos = 0;
            int size = blockSize;
            chartArea.AxisX.ScaleView.Zoom(pos, size);
            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.ResetZoom;

            chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;
            chartArea.AxisY.ScaleView.SmallScrollSize = blockSize;

        }

        private void CargarListViewFechas()
        {
            string[] valores = new string[]
{
                "Hoy"
                ,"Ultima Semana"
                ,"Ultimo Mes"
                ,"Ultimos Tres Meses"
                ,"Ultimos Seis Meses"
                ,"Ultimo Año"
                ,"Total a la Fecha"
                ,"Seleccionar de Fecha de Inicio y Fin"
};


            for (int i = 0; i < valores.Length; i++)
            {
                ListViewItem viewItem = new ListViewItem(valores[i]);
                viewItem.Tag = valores[i];
                materialListView1.Items.Add(viewItem);
            }


        }
    }
}
