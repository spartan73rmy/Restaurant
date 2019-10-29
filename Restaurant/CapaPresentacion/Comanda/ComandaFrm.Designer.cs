namespace CapaPresentacion.Comanda
{
    partial class ComandaFrm
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
            this.opciones = new CapaPresentacion.ControlesPropios.Opciones();
            this.contenedorTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // opciones
            // 
            this.opciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones.Location = new System.Drawing.Point(0, 64);
            this.opciones.Margin = new System.Windows.Forms.Padding(4);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(182, 425);
            this.opciones.TabIndex = 1;
            // 
            // contenedorTarjetas
            // 
            this.contenedorTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedorTarjetas.Location = new System.Drawing.Point(189, 64);
            this.contenedorTarjetas.Name = "contenedorTarjetas";
            this.contenedorTarjetas.Size = new System.Drawing.Size(490, 425);
            this.contenedorTarjetas.TabIndex = 2;
            // 
            // ComandaFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(691, 501);
            this.Controls.Add(this.contenedorTarjetas);
            this.Controls.Add(this.opciones);
            this.Name = "ComandaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comanda";
            this.Load += new System.EventHandler(this.Comanda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.Opciones opciones;
        private System.Windows.Forms.FlowLayoutPanel contenedorTarjetas;
    }
}