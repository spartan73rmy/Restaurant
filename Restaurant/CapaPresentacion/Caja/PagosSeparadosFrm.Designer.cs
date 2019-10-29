namespace CapaPresentacion.Caja
{
    partial class PagosSeparadosFrm
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath4 = new System.Drawing.Drawing2D.GraphicsPath();
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.contenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.listPersonas = new MaterialSkin.Controls.MaterialListView();
            this.PersonaC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarPersona = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbSubtotal = new MaterialSkin.Controls.MaterialLabel();
            this.materiallabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtPagar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // opciones1
            // 
            this.opciones1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones1.Location = new System.Drawing.Point(0, 64);
            this.opciones1.Name = "opciones1";
            this.opciones1.Size = new System.Drawing.Size(199, 383);
            this.opciones1.TabIndex = 0;
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.Location = new System.Drawing.Point(431, 64);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(357, 339);
            this.contenedor.TabIndex = 1;
            // 
            // listPersonas
            // 
            this.listPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPersonas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonaC});
            this.listPersonas.Depth = 0;
            this.listPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listPersonas.FullRowSelect = true;
            this.listPersonas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listPersonas.Location = new System.Drawing.Point(205, 64);
            this.listPersonas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listPersonas.MouseState = MaterialSkin.MouseState.OUT;
            this.listPersonas.MultiSelect = false;
            this.listPersonas.Name = "listPersonas";
            this.listPersonas.OwnerDraw = true;
            this.listPersonas.Shadow = null;
            this.listPersonas.ShadowShape = null;
            this.listPersonas.Size = new System.Drawing.Size(220, 339);
            this.listPersonas.TabIndex = 2;
            this.listPersonas.UseCompatibleStateImageBehavior = false;
            this.listPersonas.View = System.Windows.Forms.View.Details;
            // 
            // PersonaC
            // 
            this.PersonaC.Text = "Persona";
            this.PersonaC.Width = 150;
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarPersona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPersona.Depth = 0;
            this.btnAgregarPersona.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAgregarPersona.FontSize = 9;
            this.btnAgregarPersona.Icon = null;
            this.btnAgregarPersona.Location = new System.Drawing.Point(205, 418);
            this.btnAgregarPersona.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Primary = true;
            this.btnAgregarPersona.RoundedCornerRadius = 2;
            this.btnAgregarPersona.Shadow = null;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAgregarPersona.ShadowShape = graphicsPath3;
            this.btnAgregarPersona.Size = new System.Drawing.Size(220, 29);
            this.btnAgregarPersona.TabIndex = 3;
            this.btnAgregarPersona.Text = "Agregar Persona";
            this.btnAgregarPersona.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Depth = 0;
            this.lbSubtotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSubtotal.FontSize = 11;
            this.lbSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSubtotal.Location = new System.Drawing.Point(506, 428);
            this.lbSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Primary = false;
            this.lbSubtotal.Shadow = null;
            this.lbSubtotal.ShadowShape = null;
            this.lbSubtotal.Size = new System.Drawing.Size(17, 19);
            this.lbSubtotal.TabIndex = 7;
            this.lbSubtotal.Text = "0";
            // 
            // materiallabel
            // 
            this.materiallabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materiallabel.AutoSize = true;
            this.materiallabel.Depth = 0;
            this.materiallabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.materiallabel.FontSize = 11;
            this.materiallabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materiallabel.Location = new System.Drawing.Point(431, 428);
            this.materiallabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materiallabel.Name = "materiallabel";
            this.materiallabel.Primary = false;
            this.materiallabel.Shadow = null;
            this.materiallabel.ShadowShape = null;
            this.materiallabel.Size = new System.Drawing.Size(69, 19);
            this.materiallabel.TabIndex = 6;
            this.materiallabel.Text = "Subtotal:";
            // 
            // txtPagar
            // 
            this.txtPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPagar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtPagar.Depth = 0;
            this.txtPagar.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtPagar.FontSize = 9;
            this.txtPagar.Icon = null;
            this.txtPagar.Location = new System.Drawing.Point(696, 418);
            this.txtPagar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Primary = true;
            this.txtPagar.RoundedCornerRadius = 2;
            this.txtPagar.Shadow = null;
            graphicsPath4.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.txtPagar.ShadowShape = graphicsPath4;
            this.txtPagar.Size = new System.Drawing.Size(92, 36);
            this.txtPagar.TabIndex = 5;
            this.txtPagar.Text = "Pagar";
            this.txtPagar.Click += new System.EventHandler(this.txtPagar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Depth = 0;
            this.lbTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbTotal.FontSize = 11;
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTotal.Location = new System.Drawing.Point(626, 428);
            this.lbTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Primary = false;
            this.lbTotal.Shadow = null;
            this.lbTotal.ShadowShape = null;
            this.lbTotal.Size = new System.Drawing.Size(17, 19);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "0";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.FontSize = 11;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(572, 428);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Primary = false;
            this.materialLabel3.Shadow = null;
            this.materialLabel3.ShadowShape = null;
            this.materialLabel3.Size = new System.Drawing.Size(48, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Total:";
            // 
            // PagosSeparadosFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.materiallabel);
            this.Controls.Add(this.txtPagar);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.listPersonas);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.opciones1);
            this.Name = "PagosSeparadosFrm";
            this.Text = "PagosSeparados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private System.Windows.Forms.FlowLayoutPanel contenedor;
        private MaterialSkin.Controls.MaterialListView listPersonas;
        private System.Windows.Forms.ColumnHeader PersonaC;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarPersona;
        private MaterialSkin.Controls.MaterialLabel lbSubtotal;
        private MaterialSkin.Controls.MaterialLabel materiallabel;
        private MaterialSkin.Controls.MaterialRaisedButton txtPagar;
        private MaterialSkin.Controls.MaterialLabel lbTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}