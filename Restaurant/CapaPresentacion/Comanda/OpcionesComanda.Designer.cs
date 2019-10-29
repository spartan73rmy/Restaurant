namespace CapaPresentacion.Comanda
{
    partial class OpcionesComanda
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
            this.btnMostrarOrdenes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregarOrden = new MaterialSkin.Controls.MaterialRaisedButton();
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
            // btnMostrarOrdenes
            // 
            this.btnMostrarOrdenes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrarOrdenes.Depth = 0;
            this.btnMostrarOrdenes.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnMostrarOrdenes.FontSize = 9;
            this.btnMostrarOrdenes.Icon = null;
            this.btnMostrarOrdenes.Location = new System.Drawing.Point(188, 85);
            this.btnMostrarOrdenes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrarOrdenes.Name = "btnMostrarOrdenes";
            this.btnMostrarOrdenes.Primary = true;
            this.btnMostrarOrdenes.RoundedCornerRadius = 2;
            this.btnMostrarOrdenes.Shadow = null;
            this.btnMostrarOrdenes.ShadowShape = null;
            this.btnMostrarOrdenes.Size = new System.Drawing.Size(200, 100);
            this.btnMostrarOrdenes.TabIndex = 1;
            this.btnMostrarOrdenes.Text = "Ordenes";
            this.btnMostrarOrdenes.Click += new System.EventHandler(this.btnMostrarOrdenes_Click);
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarOrden.Depth = 0;
            this.btnAgregarOrden.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAgregarOrden.FontSize = 9;
            this.btnAgregarOrden.Icon = null;
            this.btnAgregarOrden.Location = new System.Drawing.Point(394, 85);
            this.btnAgregarOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Primary = true;
            this.btnAgregarOrden.RoundedCornerRadius = 2;
            this.btnAgregarOrden.Shadow = null;
            this.btnAgregarOrden.ShadowShape = null;
            this.btnAgregarOrden.Size = new System.Drawing.Size(200, 100);
            this.btnAgregarOrden.TabIndex = 2;
            this.btnAgregarOrden.Text = "Agregar Orden";
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // OpcionesComanda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarOrden);
            this.Controls.Add(this.btnMostrarOrdenes);
            this.Controls.Add(this.opciones1);
            this.Name = "OpcionesComanda";
            this.Text = "OpcionesComanda";
            this.Load += new System.EventHandler(this.OpcionesComanda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private MaterialSkin.Controls.MaterialRaisedButton btnMostrarOrdenes;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarOrden;
    }
}