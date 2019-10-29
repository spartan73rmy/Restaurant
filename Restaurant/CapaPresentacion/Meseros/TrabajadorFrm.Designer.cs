namespace CapaPresentacion.Trabajadores
{
    partial class TrabajadorFrm
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.contenedorTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // opciones1
            // 
            this.opciones1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones1.Location = new System.Drawing.Point(0, 64);
            this.opciones1.Name = "opciones1";
            this.opciones1.Size = new System.Drawing.Size(182, 305);
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
            this.contenedorTarjetas.Size = new System.Drawing.Size(374, 305);
            this.contenedorTarjetas.TabIndex = 1;
            this.contenedorTarjetas.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedorTarjetas_Paint);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAgregar.FontSize = 9;
            this.btnAgregar.Icon = global::CapaPresentacion.Properties.Resources.plus;
            this.btnAgregar.Location = new System.Drawing.Point(510, 318);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.RoundedCornerRadius = 28;
            this.btnAgregar.Shadow = null;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAgregar.ShadowShape = graphicsPath1;
            this.btnAgregar.Size = new System.Drawing.Size(52, 51);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TrabajadoresFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(574, 381);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.contenedorTarjetas);
            this.Controls.Add(this.opciones1);
            this.Name = "Trabajadores";
            this.Text = "Trabajadores";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private System.Windows.Forms.FlowLayoutPanel contenedorTarjetas;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
    }
}