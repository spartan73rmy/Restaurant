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

namespace CapaPresentacion.Configuracion
{
    public partial class Configuracion : MaterialForm
    {
        private string[] valores = new string[]
 {
                "Barra"
                ,"Cocina"
 };

        public Configuracion(bool Maximized)
        {
            InitializeComponent();
            if (Maximized)
                MaximizeWindow(Maximized);

            MaterialSkinManager.AddFormToManage(this);

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            #region botones
            opciones1.AgregarOpcion("Configurar Categorias", Properties.Resources.F_baseline_playlist_add_white_18,
            new MouseEventHandler((o, args) =>
            {
                CargarCategorias();
            }));

            //opciones1.AgregarOpcion("Imprimir", Properties.Resources.F_baseline_edit_white_18,
            //new MouseEventHandler((o, args) =>
            //{
            //    string temp = "";
            //    MessageBox.Show("Selecciona la ubicacion donde se encuentra el equipo", "Informacion");
            //    using (configMaquinaImpresion configMaquina = new configMaquinaImpresion())
            //    {
            //        configMaquina.ShowDialog(this);
            //        temp = configMaquina.Opcion();
            //    }
            //}));

            #endregion botones

        }

        private async void CargarCategorias()
        {
            contenedorTarjetas.Controls.Clear();

            var listaCategoriaProducto = ControlCategorias.Instance.GetLista();
            if (listaCategoriaProducto.Count <= 0 || listaCategoriaProducto == null)
            {
                return;
            }

            foreach (CategoriaProducto categoria in listaCategoriaProducto)
            {

                if (categoria.CategoriaProductoImagen == null)
                {
                    await Task.Run(() => categoria.LoadImage()); // Carga la imagen de la categoria (nesesario? se ve feo)
                }

                TarjetaCategoria tarjeta = new TarjetaCategoria(categoria, this);
                tarjeta.MouseClick += (sen, eve) =>
                {
                    string temp = "";
                    using (ConfigCategoria configCategoria = new ConfigCategoria(false, categoria))
                    {
                        configCategoria.ShowDialog(this);
                        temp = configCategoria.Opcion();
                    }

                };
                contenedorTarjetas.Controls.Add(tarjeta);

            }

        }


    }
}
