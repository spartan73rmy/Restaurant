using CapaAccesoDatos;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Configuracion
{
    public partial class ConfigCategoria : MaterialForm
    {
        private string configSelected = "";
        private CategoriaProducto categoria;

        public ConfigCategoria(bool Maximized, CategoriaProducto categoria)
        {
            this.categoria = categoria;
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);

            if (Maximized)
                MaximizeWindow(Maximized);

            loadContent();
        }

        private void loadContent()
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Restaurant";
            string file = path + "\\Impresiones.config";
            try
            {
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                if (!File.Exists(file)) File.WriteAllText(file, "[]");

                List<CategoriaProducto> list = JsonConvert.DeserializeObject<List<CategoriaProducto>>(File.ReadAllText(file));
                
                if(list.Contains(categoria))
                {
                    materialCheckBox1.Checked = true;
                }
            }
            catch (Exception ex)
            {
                try
                {
                    File.WriteAllText(file, "[]");
                }
                catch { }
                MessageBox.Show("No se ha podido cargar la configuracion");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Restaurant";
            string file = path + "\\Impresiones.config";
            try
            {
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                if (!File.Exists(file)) File.WriteAllText(file, "[]");

                List<CategoriaProducto> list = JsonConvert.DeserializeObject<List<CategoriaProducto>>(File.ReadAllText(file));
                if (materialCheckBox1.Checked && !list.Contains(categoria))
                {
                    list.Add(categoria);
                }
                else if (!materialCheckBox1.Checked && list.Contains(categoria))
                {
                    list.Remove(categoria);
                }
                categoria.CategoriaProductoImagen = null;
                File.WriteAllText(file, JsonConvert.SerializeObject(list));
            }
            catch (Exception ex)
            {
                try
                {
                    File.WriteAllText(file, "[]");
                }
                catch { }
                MessageBox.Show("No se ha podido guardar la configuracion");
            }
            Close();
        }

        public string Opcion()
        {
            return configSelected;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
