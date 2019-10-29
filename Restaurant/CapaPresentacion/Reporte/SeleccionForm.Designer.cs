namespace CapaPresentacion.Reporte
{
    partial class SeleccionForm
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath4 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath5 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath6 = new System.Drawing.Drawing2D.GraphicsPath();
            this.btnQuitar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.unselectedListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialPanel1 = new MaterialSkin.Controls.MaterialPanel();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.btn_SeleccionarTodo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitar.Depth = 0;
            this.btnQuitar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnQuitar.FontSize = 9;
            this.btnQuitar.Icon = null;
            this.btnQuitar.Location = new System.Drawing.Point(188, 480);
            this.btnQuitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Primary = true;
            this.btnQuitar.RoundedCornerRadius = 2;
            this.btnQuitar.Shadow = null;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnQuitar.ShadowShape = graphicsPath1;
            this.btnQuitar.Size = new System.Drawing.Size(135, 55);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAgregar.FontSize = 9;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(329, 480);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.RoundedCornerRadius = 2;
            this.btnAgregar.Shadow = null;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAgregar.ShadowShape = graphicsPath2;
            this.btnAgregar.Size = new System.Drawing.Size(135, 55);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAceptar.FontSize = 9;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(797, 480);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.RoundedCornerRadius = 2;
            this.btnAceptar.Shadow = null;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAceptar.ShadowShape = graphicsPath3;
            this.btnAceptar.Size = new System.Drawing.Size(136, 55);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnCancelar.FontSize = 9;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(655, 480);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.RoundedCornerRadius = 2;
            this.btnCancelar.Shadow = null;
            graphicsPath4.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnCancelar.ShadowShape = graphicsPath4;
            this.btnCancelar.Size = new System.Drawing.Size(136, 55);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // unselectedListView
            // 
            this.unselectedListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unselectedListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unselectedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.unselectedListView.Depth = 0;
            this.unselectedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.unselectedListView.FullRowSelect = true;
            this.unselectedListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.unselectedListView.Location = new System.Drawing.Point(3, 3);
            this.unselectedListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.unselectedListView.MouseState = MaterialSkin.MouseState.OUT;
            this.unselectedListView.Name = "unselectedListView";
            this.unselectedListView.OwnerDraw = true;
            this.unselectedListView.Shadow = null;
            this.unselectedListView.ShadowShape = null;
            this.unselectedListView.Size = new System.Drawing.Size(311, 404);
            this.unselectedListView.TabIndex = 6;
            this.unselectedListView.UseCompatibleStateImageBehavior = false;
            this.unselectedListView.View = System.Windows.Forms.View.Details;
            this.unselectedListView.SelectedIndexChanged += new System.EventHandler(this.unselectedListView_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No selecionados";
            this.columnHeader3.Width = 300;
            // 
            // materialPanel1
            // 
            this.materialPanel1.ChangeBackColor = false;
            this.materialPanel1.Controls.Add(this.unselectedListView);
            this.materialPanel1.Depth = 0;
            this.materialPanel1.Location = new System.Drawing.Point(188, 64);
            this.materialPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Primary = false;
            this.materialPanel1.RoundedCornerRadius = 2;
            this.materialPanel1.Shadow = null;
            graphicsPath5.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialPanel1.ShadowShape = graphicsPath5;
            this.materialPanel1.Size = new System.Drawing.Size(317, 410);
            this.materialPanel1.TabIndex = 7;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Seleccionados";
            this.columnHeader2.Width = 300;
            // 
            // selectedListView
            // 
            this.selectedListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.selectedListView.Depth = 0;
            this.selectedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.selectedListView.FullRowSelect = true;
            this.selectedListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.selectedListView.Location = new System.Drawing.Point(511, 67);
            this.selectedListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.selectedListView.MouseState = MaterialSkin.MouseState.OUT;
            this.selectedListView.Name = "selectedListView";
            this.selectedListView.OwnerDraw = true;
            this.selectedListView.Shadow = null;
            this.selectedListView.ShadowShape = null;
            this.selectedListView.Size = new System.Drawing.Size(422, 407);
            this.selectedListView.TabIndex = 7;
            this.selectedListView.UseCompatibleStateImageBehavior = false;
            this.selectedListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Seleccionados";
            this.columnHeader1.Width = 300;
            // 
            // opciones1
            // 
            this.opciones1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones1.Location = new System.Drawing.Point(0, 64);
            this.opciones1.Name = "opciones1";
            this.opciones1.Size = new System.Drawing.Size(182, 471);
            this.opciones1.TabIndex = 0;
            // 
            // btn_SeleccionarTodo
            // 
            this.btn_SeleccionarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SeleccionarTodo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SeleccionarTodo.Depth = 0;
            this.btn_SeleccionarTodo.Font = new System.Drawing.Font("Roboto", 9F);
            this.btn_SeleccionarTodo.FontSize = 9;
            this.btn_SeleccionarTodo.Icon = null;
            this.btn_SeleccionarTodo.Location = new System.Drawing.Point(470, 480);
            this.btn_SeleccionarTodo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SeleccionarTodo.Name = "btn_SeleccionarTodo";
            this.btn_SeleccionarTodo.Primary = true;
            this.btn_SeleccionarTodo.RoundedCornerRadius = 2;
            this.btn_SeleccionarTodo.Shadow = null;
            graphicsPath6.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btn_SeleccionarTodo.ShadowShape = graphicsPath6;
            this.btn_SeleccionarTodo.Size = new System.Drawing.Size(135, 55);
            this.btn_SeleccionarTodo.TabIndex = 1;
            this.btn_SeleccionarTodo.Text = "Todo";
            this.btn_SeleccionarTodo.Click += new System.EventHandler(this.btn_SeleccionarTodo_Click);
            // 
            // SeleccionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(945, 547);
            this.Controls.Add(this.btn_SeleccionarTodo);
            this.Controls.Add(this.selectedListView);
            this.Controls.Add(this.materialPanel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.opciones1);
            this.Name = "SeleccionForm";
            this.Text = "SeleccionForm";
            this.Load += new System.EventHandler(this.SeleccionForm_Load);
            this.materialPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private MaterialSkin.Controls.MaterialRaisedButton btnQuitar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialListView unselectedListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialPanel materialPanel1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialListView selectedListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_SeleccionarTodo;
    }
}