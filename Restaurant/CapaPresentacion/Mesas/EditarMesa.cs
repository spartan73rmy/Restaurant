using CapaAccesoDatos;
using CapaLogica.ControlEntidades;
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

namespace CapaPresentacion.Mesas
{
    public partial class EditarMesa : MaterialForm
    {
        private Mesa mesa;
        private EstadoMesa estado;
        private bool bien;


        public EditarMesa(Mesa mesa)
        {
            bien = false;
            this.mesa = mesa;
            estado = new EstadoMesa();
            InitializeComponent();
            materialListView1.MultiSelect = false;
            btnCancelar.Visible = true;

            MaterialSkinManager.AddFormToManage(this);
            cargarLista();

            if (mesa != null)
            {
                btnEliminar.Visible = true;
                txtNombre.Text = mesa.nombre_mesa;
            }
        }

        public EditarMesa() : this(null)
        {
            estado = new EstadoMesa();
        }

        private void cargarLista()
        {
            List<string> auxTipos = new List<string>();
            var lista = ControlEstadoMesa.Instance.GetLista();
            if (lista == null) { MessageBox.Show("Revisa tu coneccion"); return; }

            foreach (EstadoMesa estado in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { estado.nombre_estado });
                if (estado.id_estado_mesa == 4) continue;

                item.Tag = estado;

                materialListView1.Items.Add(item);
                
            }
        }

        public bool NecesitaActualizar()
        {
            return bien;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Llene Todos Los Campos","ERROR");
            }
            else
            {
                // Necesita editarse
                if (materialListView1.SelectedItems.Count > 0)
                {

                    if (mesa != null)
                    {
                        mesa.nombre_mesa = txtNombre.Text;
                        mesa.id_estado = ((EstadoMesa)materialListView1.SelectedItems[0].Tag).id_estado_mesa;
                        mesa.EstadoMesa = (EstadoMesa)materialListView1.SelectedItems[0].Tag;
                        bien = ControlMesas.Instance.Editar(mesa);
                        MessageBox.Show("Mesa Editada Correctamente ", "COMPLETADO");

                    }
                    else
                    {

                        estado = (EstadoMesa)materialListView1.SelectedItems[0].Tag;
                        mesa = new Mesa()
                        {
                            nombre_mesa = txtNombre.Text,
                            id_estado = estado.id_estado_mesa,
                        };
                        bien = ControlMesas.Instance.Agregar(mesa);
                        MessageBox.Show("Mesa Agregada Correctamente en " + estado.nombre_estado, "COMPLETADO");
                        
                    }
                }
                // TODO hacer algo
                if (bien)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("", "ERROR");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // TODO algo
            if (ControlMesas.Instance.Eliminar(mesa))
            {
                MessageBox.Show("Mesa Eliminada Correctamente", "COMPLETADO");
                Close();
            }
            else
            {
                MessageBox.Show("", "ERROR");

            }
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros.AlfanumericoSpace(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
