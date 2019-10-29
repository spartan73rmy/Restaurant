namespace CapaPresentacion.Productos
{
    partial class EditarVarianteUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath4 = new System.Drawing.Drawing2D.GraphicsPath();
            this.btnEditarVariante = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregarVariante = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnEditarVariante
            // 
            this.btnEditarVariante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarVariante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarVariante.Depth = 0;
            this.btnEditarVariante.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnEditarVariante.FontSize = 9;
            this.btnEditarVariante.Icon = null;
            this.btnEditarVariante.Location = new System.Drawing.Point(330, 228);
            this.btnEditarVariante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarVariante.Name = "btnEditarVariante";
            this.btnEditarVariante.Primary = true;
            this.btnEditarVariante.RoundedCornerRadius = 2;
            this.btnEditarVariante.Shadow = null;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnEditarVariante.ShadowShape = graphicsPath3;
            this.btnEditarVariante.Size = new System.Drawing.Size(104, 36);
            this.btnEditarVariante.TabIndex = 11;
            this.btnEditarVariante.Text = "Editar";
            this.btnEditarVariante.Click += new System.EventHandler(this.btnEditarVariante_Click);
            // 
            // btnAgregarVariante
            // 
            this.btnAgregarVariante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarVariante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarVariante.Depth = 0;
            this.btnAgregarVariante.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAgregarVariante.FontSize = 9;
            this.btnAgregarVariante.Icon = null;
            this.btnAgregarVariante.Location = new System.Drawing.Point(220, 228);
            this.btnAgregarVariante.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarVariante.Name = "btnAgregarVariante";
            this.btnAgregarVariante.Primary = true;
            this.btnAgregarVariante.RoundedCornerRadius = 2;
            this.btnAgregarVariante.Shadow = null;
            graphicsPath4.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAgregarVariante.ShadowShape = graphicsPath4;
            this.btnAgregarVariante.Size = new System.Drawing.Size(104, 36);
            this.btnAgregarVariante.TabIndex = 10;
            this.btnAgregarVariante.Text = "Agregar";
            this.btnAgregarVariante.Click += new System.EventHandler(this.btnAgregarVariante_Click);
            // 
            // materialListView2
            // 
            this.materialListView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.CheckBoxes = true;
            this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.materialListView2.Depth = 0;
            this.materialListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView2.Location = new System.Drawing.Point(3, 32);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.MultiSelect = false;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Shadow = null;
            this.materialListView2.ShadowShape = null;
            this.materialListView2.Size = new System.Drawing.Size(431, 190);
            this.materialListView2.TabIndex = 9;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Disponible";
            this.columnHeader5.Width = 250;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 20F);
            this.materialLabel1.FontSize = 20;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Primary = false;
            this.materialLabel1.Shadow = null;
            this.materialLabel1.ShadowShape = null;
            this.materialLabel1.Size = new System.Drawing.Size(130, 33);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Variantes";
            // 
            // EditarVarianteUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnEditarVariante);
            this.Controls.Add(this.btnAgregarVariante);
            this.Controls.Add(this.materialListView2);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "EditarVarianteUserControl";
            this.Size = new System.Drawing.Size(437, 266);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnEditarVariante;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarVariante;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
