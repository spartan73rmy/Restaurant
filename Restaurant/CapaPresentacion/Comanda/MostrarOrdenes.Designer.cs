namespace CapaPresentacion.Comanda
{
    partial class MostrarOrdenes
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
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.contenedorTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // opciones1
            // 
            this.opciones1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones1.Location = new System.Drawing.Point(0, 64);
            this.opciones1.Name = "opciones1";
            this.opciones1.Size = new System.Drawing.Size(182, 374);
            this.opciones1.TabIndex = 0;
            // 
            // contenedorTarjetas
            // 
            this.contenedorTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedorTarjetas.AutoScroll = true;
            this.contenedorTarjetas.Location = new System.Drawing.Point(188, 64);
            this.contenedorTarjetas.Name = "contenedorTarjetas";
            this.contenedorTarjetas.Size = new System.Drawing.Size(600, 374);
            this.contenedorTarjetas.TabIndex = 1;
            // 
            // MostrarOrdenes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedorTarjetas);
            this.Controls.Add(this.opciones1);
            this.Name = "MostrarOrdenes";
            this.Text = "OrdenesPorMesa";
            this.Load += new System.EventHandler(this.OrdenesPorMesa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private System.Windows.Forms.FlowLayoutPanel contenedorTarjetas;
    }
}