using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
using CapaPresentacion.Utilerias;
using CapaPresentacion.Utilerias.Controles;
using CapaPresentacion.Utilerias.Eventos;
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

namespace CapaPresentacion.Clientes
{
    public partial class EditarCliente : MaterialForm
    {
        private Cliente cliente;
        public EditarCliente(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            btnCancelar.Visible = true;

            if (cliente != null)
            {
                txtNombre.Text = cliente.nombre;
                txtApellidos.Text = cliente.apellidos;
                txtTelefono.Text = cliente.telefono;
                txtDireccion.Text = cliente.direccion;
                txtRFC.Text = cliente.rfc;
                btnBorrar.Visible = true;
            }
        }

        public EditarCliente() : this(null) { }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Helper.Llenos(txtApellidos, txtDireccion, txtNombre,txtTelefono))
            {
                MessageBox.Show("Llene Todos Los Campos", "ERROR");
                return;
            }
            else
            {
                //    Si existe mesero quiere decir que solo hay que editarlo
                if (cliente != null)
                {
                    cliente.nombre = txtNombre.Text;
                    cliente.apellidos = txtApellidos.Text;
                    cliente.telefono = txtTelefono.Text;
                    cliente.direccion = txtDireccion.Text;
                    cliente.rfc = txtRFC.Text;

                    if (ControlClientes.Instance.Editar(cliente))
                    {                       
                        MessageBox.Show("Cliente Editado Correctamente", "COMPLETADO");
                        Close();
                    }
                    else
                    {
                        //TODO manejar error
                        MessageBox.Show("Error", "Error");
                        Close();
                    }
                    
                }
                //  sino se crea y se agrega
                else
                {
                    cliente = new Cliente()
                    {
                        nombre = txtNombre.Text,
                        apellidos = txtApellidos.Text,
                        telefono = txtTelefono.Text,
                        direccion = txtDireccion.Text,
                        rfc = txtRFC.Text
                    };

                    if (ControlClientes.Instance.Agregar(cliente))
                    {
                        MessageBox.Show("Cliente Agregado Correctamente", "COMPLETADO");
                        Close();
                    }
                    else
                    {
                        // TODO manejar error
                        MessageBox.Show("Error", "Error");
                        Close();
                    }
                    
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ControlClientes.Instance.Eliminar(cliente))
            {
                MessageBox.Show("Cliente eliminado Correctamente", "COMPLETADO");
                Close();
            }
            else
            {
                //TODO manejar error
                MessageBox.Show("Error", "Error");
                Close();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image nueva = ImageDialog.OpenImage();
            if (nueva != null)
                pictureBox1.Image = nueva;
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloLetras(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.SoloLetras(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.Telefono(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Filtros.AlfanumericoSpace(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);

        }

        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.Alfanumerico(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
