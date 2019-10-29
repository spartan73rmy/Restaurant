namespace CapaPresentacion.Caja
{
    partial class PagosFrm
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
            this.contenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.txtPagar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.AutoScroll = true;
            this.contenedor.Location = new System.Drawing.Point(205, 64);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(583, 332);
            this.contenedor.TabIndex = 1;
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
            // txtPagar
            // 
            this.txtPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPagar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtPagar.Depth = 0;
            this.txtPagar.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtPagar.FontSize = 9;
            this.txtPagar.Icon = null;
            this.txtPagar.Location = new System.Drawing.Point(696, 405);
            this.txtPagar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Primary = true;
            this.txtPagar.RoundedCornerRadius = 2;
            this.txtPagar.Shadow = null;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.txtPagar.ShadowShape = graphicsPath1;
            this.txtPagar.Size = new System.Drawing.Size(92, 36);
            this.txtPagar.TabIndex = 2;
            this.txtPagar.Text = "Pagar";
            this.txtPagar.Click += new System.EventHandler(this.txtPagar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.FontSize = 11;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(528, 422);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Primary = false;
            this.materialLabel1.Shadow = null;
            this.materialLabel1.ShadowShape = null;
            this.materialLabel1.Size = new System.Drawing.Size(58, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.AutoSize = true;
            this.txtTotal.Depth = 0;
            this.txtTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtTotal.FontSize = 11;
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotal.Location = new System.Drawing.Point(582, 422);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Primary = false;
            this.txtTotal.Shadow = null;
            this.txtTotal.ShadowShape = null;
            this.txtTotal.Size = new System.Drawing.Size(21, 24);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "0";
            // 
            // PagosFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPagar);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.opciones1);
            this.Name = "PagosFrm";
            this.Text = "PagosFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private System.Windows.Forms.FlowLayoutPanel contenedor;
        private MaterialSkin.Controls.MaterialRaisedButton txtPagar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel txtTotal;
    }
}