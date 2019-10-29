using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaLogica.Login;
using CapaPresentacion.Utilerias;
using CapaPresentacion.Utilerias.Eventos;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Trabajadores
{
    public partial class EditarTrabajador : MaterialForm
    {
        private Trabajador mesero;
        public EditarTrabajador(Trabajador mesero)
        {
            this.mesero = mesero;
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);

            var listaPuesto = ControlPuestos.Instance.GetLista();
            if (listaPuesto == null) { MessageBox.Show("Revisa tu coneccion"); return; }
            if (listaPuesto.Count>0)
            {
                foreach (Puesto puesto in listaPuesto)
                {
                    cbPuestos.Items.Add(puesto);
                }
            }


            if (mesero != null)
            {
                btnBorrar.Visible = true;
                txtNombre.Text = mesero.nombre;
                txtApellidos.Text = mesero.apellidos;
                txtDireccion.Text = mesero.direccion;
                txtTelefono.Text = mesero.telefono;
                dateTimePicker.Value = mesero.fecha_nacimiento;
                pictureBox1.Image = mesero.TrabajadorImagen.Image;
                cbPuestos.SelectedItem = mesero.Puesto;
                ckAcceso.Visible = true;
                txtUser.Visible = false;
                txtPass.Visible = false;
            }


        }

        public EditarTrabajador() : this(null)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ControlTrabajadores.Instance.Eliminar(mesero))
            {
                MessageBox.Show("Trabajador Eliminado Correctamente", "COMPLETADO");
                Changed = true;
                Close();
            }
            else
            {
                MessageBox.Show("Error", "error");
                Close();
            }
        }

        // Crea el ususario y contrasena para el mesero
        private bool CrearAcceso()
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            bool ok = LoginManager.AgregarOEditar(user, pass, mesero);
            if(!ok)
            {
                MessageBox.Show("Asegurate que el usuario sea unico");
            }
            return ok;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Utilerias.Controles.Helper.Llenos(txtNombre, txtApellidos, txtTelefono, txtDireccion))
            {
                MessageBox.Show("Llene Todos Los Campos", "ERROR");
            }
            else
            {
                bool bien;
                // Necesita editarse
                if (mesero != null)
                {
                    mesero.Puesto = null;
                    mesero.nombre = txtNombre.Text;
                    mesero.apellidos = txtApellidos.Text;
                    mesero.direccion = txtDireccion.Text;
                    mesero.fecha_nacimiento = dateTimePicker.Value;
                    mesero.telefono = txtTelefono.Text;
                    mesero.TrabajadorImagen.Image = pictureBox1.Image;
                    mesero.id_puesto = (cbPuestos.SelectedItem as Puesto).id_puesto;
                    bien = ControlTrabajadores.Instance.Editar(mesero);

                    if (bien && ckAcceso.Checked)
                        bien = CrearAcceso();

                }
                else
                {
                    mesero = new Trabajador()
                    {
                        nombre = txtNombre.Text,
                        apellidos = txtApellidos.Text,
                        direccion = txtDireccion.Text,
                        fecha_nacimiento = dateTimePicker.Value,
                        telefono = txtTelefono.Text,
                        id_puesto = (cbPuestos.SelectedItem as Puesto).id_puesto,
                        TrabajadorImagen = new TrabajadorImagen() { Image = pictureBox1.Image }
                    };
                    bien = ControlTrabajadores.Instance.Agregar(mesero);
                    if (bien)
                        bien = CrearAcceso();
                }

                if (bien)
                {
                    MessageBox.Show("Trabajador Agregado Correctamente", "COMPLETADO");
                    Changed = true;
                    Close();
                    /* DialogResult boton = MessageBox.Show("Ahora necesita crear un usuario y contraseña para el mesero", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (boton != DialogResult.OK)
                    {
                        Close();
                        return;
                    }*/
                }
                else
                {
                    MessageBox.Show("Error", "Error");
                    Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image nueva = ImageDialog.OpenImage();
            if (nueva != null)
                pictureBox1.Image = nueva;
        }

        public bool Changed { get; internal set; }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.Telefono(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Filtros.Direccion(e);
        }

        private void ckAcceso_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Visible = txtPass.Visible = ckAcceso.Checked;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
