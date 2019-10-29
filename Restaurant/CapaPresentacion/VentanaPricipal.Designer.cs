namespace CapaPresentacion
{
    partial class VentanaPricipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contenedorTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.timerActualizar = new System.Windows.Forms.Timer(this.components);
            this.tarjetaProductos = new CapaPresentacion.ControlesPropios.Tarjeta();
            this.tarjetaMesas = new CapaPresentacion.ControlesPropios.Tarjeta();
            this.tarjetaComanda = new CapaPresentacion.ControlesPropios.Tarjeta();
            this.tarjetaTrabajadores = new CapaPresentacion.ControlesPropios.Tarjeta();
            this.tarjetaCliente1 = new CapaPresentacion.ControlesPropios.Tarjeta();
            this.tarjetaCliente2 = new CapaPresentacion.ControlesPropios.Tarjeta();
            this.tarjetaReporte = new CapaPresentacion.ControlesPropios.Tarjeta();
            this.opciones = new CapaPresentacion.ControlesPropios.Opciones();
            this.contenedorTarjetas.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorTarjetas
            // 
            this.contenedorTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedorTarjetas.Controls.Add(this.tarjetaProductos);
            this.contenedorTarjetas.Controls.Add(this.tarjetaMesas);
            this.contenedorTarjetas.Controls.Add(this.tarjetaComanda);
            this.contenedorTarjetas.Controls.Add(this.tarjetaTrabajadores);
            this.contenedorTarjetas.Controls.Add(this.tarjetaCliente1);
            this.contenedorTarjetas.Controls.Add(this.tarjetaCliente2);
            this.contenedorTarjetas.Controls.Add(this.tarjetaReporte);
            this.contenedorTarjetas.Location = new System.Drawing.Point(188, 64);
            this.contenedorTarjetas.Name = "contenedorTarjetas";
            this.contenedorTarjetas.Size = new System.Drawing.Size(588, 715);
            this.contenedorTarjetas.TabIndex = 1;
            // 
            // timerActualizar
            // 
            this.timerActualizar.Enabled = true;
            this.timerActualizar.Interval = 5000;
            this.timerActualizar.Tick += new System.EventHandler(this.timerActualizar_Tick);
            // 
            // tarjetaProductos
            // 
            this.tarjetaProductos.BackColor = System.Drawing.Color.Transparent;
            this.tarjetaProductos.ColorFondo = System.Drawing.Color.Transparent;
            this.tarjetaProductos.FontSize = 14;
            this.tarjetaProductos.Image = global::CapaPresentacion.Properties.Resources.F_B_baseline_fastfood_black_48;
            this.tarjetaProductos.Location = new System.Drawing.Point(4, 4);
            this.tarjetaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.tarjetaProductos.Name = "tarjetaProductos";
            this.tarjetaProductos.Size = new System.Drawing.Size(188, 217);
            this.tarjetaProductos.TabIndex = 2;
            this.tarjetaProductos.Texto = "Productos";
            this.tarjetaProductos.Click += new System.EventHandler(this.tarjetaProductos_Click);
            // 
            // tarjetaMesas
            // 
            this.tarjetaMesas.BackColor = System.Drawing.Color.Transparent;
            this.tarjetaMesas.ColorFondo = System.Drawing.Color.Transparent;
            this.tarjetaMesas.FontSize = 14;
            this.tarjetaMesas.Image = global::CapaPresentacion.Properties.Resources.F_B_baseline_widgets_black_48;
            this.tarjetaMesas.Location = new System.Drawing.Point(200, 4);
            this.tarjetaMesas.Margin = new System.Windows.Forms.Padding(4);
            this.tarjetaMesas.Name = "tarjetaMesas";
            this.tarjetaMesas.Size = new System.Drawing.Size(188, 217);
            this.tarjetaMesas.TabIndex = 4;
            this.tarjetaMesas.Texto = "Mesas";
            this.tarjetaMesas.Click += new System.EventHandler(this.tarjetaMesas_Click);
            // 
            // tarjetaComanda
            // 
            this.tarjetaComanda.BackColor = System.Drawing.Color.Transparent;
            this.tarjetaComanda.ColorFondo = System.Drawing.Color.Transparent;
            this.tarjetaComanda.FontSize = 14;
            this.tarjetaComanda.Image = global::CapaPresentacion.Properties.Resources.F_B_baseline_local_dining_black_48;
            this.tarjetaComanda.Location = new System.Drawing.Point(396, 4);
            this.tarjetaComanda.Margin = new System.Windows.Forms.Padding(4);
            this.tarjetaComanda.Name = "tarjetaComanda";
            this.tarjetaComanda.Size = new System.Drawing.Size(188, 217);
            this.tarjetaComanda.TabIndex = 7;
            this.tarjetaComanda.Texto = "Comanda";
            this.tarjetaComanda.Click += new System.EventHandler(this.tarjetaComanda_Click);
            // 
            // tarjetaTrabajadores
            // 
            this.tarjetaTrabajadores.BackColor = System.Drawing.Color.Transparent;
            this.tarjetaTrabajadores.ColorFondo = System.Drawing.Color.Transparent;
            this.tarjetaTrabajadores.FontSize = 14;
            this.tarjetaTrabajadores.Image = global::CapaPresentacion.Properties.Resources.F_B_baseline_people_black_48;
            this.tarjetaTrabajadores.Location = new System.Drawing.Point(4, 229);
            this.tarjetaTrabajadores.Margin = new System.Windows.Forms.Padding(4);
            this.tarjetaTrabajadores.Name = "tarjetaTrabajadores";
            this.tarjetaTrabajadores.Size = new System.Drawing.Size(188, 217);
            this.tarjetaTrabajadores.TabIndex = 3;
            this.tarjetaTrabajadores.Texto = "Trabajadores";
            this.tarjetaTrabajadores.Click += new System.EventHandler(this.tarjetaTrabajador_Click);
            // 
            // tarjetaCliente1
            // 
            this.tarjetaCliente1.BackColor = System.Drawing.Color.Transparent;
            this.tarjetaCliente1.ColorFondo = System.Drawing.Color.Transparent;
            this.tarjetaCliente1.FontSize = 14;
            this.tarjetaCliente1.Image = global::CapaPresentacion.Properties.Resources.F_B_baseline_supervised_user_circle_black_48;
            this.tarjetaCliente1.Location = new System.Drawing.Point(200, 229);
            this.tarjetaCliente1.Margin = new System.Windows.Forms.Padding(4);
            this.tarjetaCliente1.Name = "tarjetaCliente1";
            this.tarjetaCliente1.Size = new System.Drawing.Size(188, 217);
            this.tarjetaCliente1.TabIndex = 5;
            this.tarjetaCliente1.Texto = "Cliente";
            this.tarjetaCliente1.Click += new System.EventHandler(this.tarjeta2_Click);
            // 
            // tarjetaCliente2
            // 
            this.tarjetaCliente2.BackColor = System.Drawing.Color.Transparent;
            this.tarjetaCliente2.ColorFondo = System.Drawing.Color.Transparent;
            this.tarjetaCliente2.FontSize = 14;
            this.tarjetaCliente2.Image = global::CapaPresentacion.Properties.Resources.F_B_baseline_class_black_48;
            this.tarjetaCliente2.Location = new System.Drawing.Point(396, 229);
            this.tarjetaCliente2.Margin = new System.Windows.Forms.Padding(4);
            this.tarjetaCliente2.Name = "tarjetaCliente2";
            this.tarjetaCliente2.Size = new System.Drawing.Size(188, 217);
            this.tarjetaCliente2.TabIndex = 6;
            this.tarjetaCliente2.Texto = "Cliente";
            this.tarjetaCliente2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clientes2_MouseClick);
            // 
            // tarjetaReporte
            // 
            this.tarjetaReporte.BackColor = System.Drawing.Color.Transparent;
            this.tarjetaReporte.ColorFondo = System.Drawing.Color.Transparent;
            this.tarjetaReporte.FontSize = 14;
            this.tarjetaReporte.Image = global::CapaPresentacion.Properties.Resources.F_B_baseline_insert_chart_outlined_black_48;
            this.tarjetaReporte.Location = new System.Drawing.Point(4, 454);
            this.tarjetaReporte.Margin = new System.Windows.Forms.Padding(4);
            this.tarjetaReporte.Name = "tarjetaReporte";
            this.tarjetaReporte.Size = new System.Drawing.Size(188, 217);
            this.tarjetaReporte.TabIndex = 8;
            this.tarjetaReporte.Texto = "Reporte";
            this.tarjetaReporte.Click += new System.EventHandler(this.tarjetaReporte_Click);
            this.tarjetaReporte.Load += new System.EventHandler(this.tarjetaReporte_Load);
            // 
            // opciones
            // 
            this.opciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones.Location = new System.Drawing.Point(0, 64);
            this.opciones.Margin = new System.Windows.Forms.Padding(4);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(182, 662);
            this.opciones.TabIndex = 0;
            // 
            // VentanaPricipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 739);
            this.Controls.Add(this.contenedorTarjetas);
            this.Controls.Add(this.opciones);
            this.Name = "VentanaPricipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPricipal";
            this.Load += new System.EventHandler(this.VentanaPricipal_Load);
            this.contenedorTarjetas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.Opciones opciones;
        private System.Windows.Forms.FlowLayoutPanel contenedorTarjetas;
        private ControlesPropios.Tarjeta tarjetaTrabajadores;
        private ControlesPropios.Tarjeta tarjetaProductos;
        private ControlesPropios.Tarjeta tarjetaMesas;
        private ControlesPropios.Tarjeta tarjetaCliente1;
        private ControlesPropios.Tarjeta tarjetaCliente2;
        private ControlesPropios.Tarjeta tarjetaComanda;
        private ControlesPropios.Tarjeta tarjetaReporte;
        private System.Windows.Forms.Timer timerActualizar;
    }
}