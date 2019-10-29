using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using MaterialSkin.Controls;
using CapaPresentacion.ControlesPropios;



namespace CapaPresentacion.Clientes
{
    public partial class TarjetaCliente : Tarjeta
    {

        public Cliente cliente;
        private MaterialForm owner;

        public TarjetaCliente(Cliente cliente, MaterialForm owner)
        {
            this.cliente = cliente;
            this.owner = owner;
            InitializeComponent();
            Texto = cliente.nombre + " " + cliente.apellidos;
        }

        public TarjetaCliente()
        {
            InitializeComponent();
        }

        private void TarjetaCliente_Click(object sender, EventArgs e)
        {
        }
    }
}
