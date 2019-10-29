namespace CapaPresentacion.Comanda
{
    partial class PedidosActivosFrm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.SuspendLayout();
            // 
            // contenedorTarjetas
            // 
            this.contenedorTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedorTarjetas.AutoScroll = true;
            this.contenedorTarjetas.Location = new System.Drawing.Point(205, 64);
            this.contenedorTarjetas.Name = "contenedorTarjetas";
            this.contenedorTarjetas.Size = new System.Drawing.Size(583, 374);
            this.contenedorTarjetas.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // opciones1
            // 
            this.opciones1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones1.Location = new System.Drawing.Point(0, 64);
            this.opciones1.Name = "opciones1";
            this.opciones1.Size = new System.Drawing.Size(199, 374);
            this.opciones1.TabIndex = 0;
            // 
            // PedidosActivosFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedorTarjetas);
            this.Controls.Add(this.opciones1);
            this.Name = "PedidosActivosFrm";
            this.Text = "PedidosActivosFrm";
            this.Load += new System.EventHandler(this.PedidosActivosFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private System.Windows.Forms.FlowLayoutPanel contenedorTarjetas;
        private System.Windows.Forms.Timer timer1;
    }
}