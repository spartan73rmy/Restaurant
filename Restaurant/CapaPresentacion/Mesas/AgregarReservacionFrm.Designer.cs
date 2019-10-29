namespace CapaPresentacion.Mesas
{
    partial class AgregarReservacionFrm
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath9 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath5 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath6 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath7 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath8 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath4 = new System.Drawing.Drawing2D.GraphicsPath();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listClientes = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMesas = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialPanel1 = new MaterialSkin.Controls.MaterialPanel();
            this.lblHora = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMenos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnMas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMinutos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtHora = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDuracion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAceptar.FontSize = 9;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(876, 426);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.RoundedCornerRadius = 2;
            this.btnAceptar.Shadow = null;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAceptar.ShadowShape = graphicsPath1;
            this.btnAceptar.Size = new System.Drawing.Size(123, 36);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.Depth = 0;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnNuevoCliente.FontSize = 9;
            this.btnNuevoCliente.Icon = null;
            this.btnNuevoCliente.Location = new System.Drawing.Point(732, 426);
            this.btnNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Primary = true;
            this.btnNuevoCliente.RoundedCornerRadius = 2;
            this.btnNuevoCliente.Shadow = null;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnNuevoCliente.ShadowShape = graphicsPath2;
            this.btnNuevoCliente.Size = new System.Drawing.Size(123, 36);
            this.btnNuevoCliente.TabIndex = 10;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // listClientes
            // 
            this.listClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listClientes.Depth = 0;
            this.listClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listClientes.FullRowSelect = true;
            this.listClientes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listClientes.Location = new System.Drawing.Point(467, 64);
            this.listClientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.listClientes.MultiSelect = false;
            this.listClientes.Name = "listClientes";
            this.listClientes.OwnerDraw = true;
            this.listClientes.Shadow = null;
            this.listClientes.ShadowShape = null;
            this.listClientes.Size = new System.Drawing.Size(259, 398);
            this.listClientes.TabIndex = 12;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Clientes";
            this.columnHeader2.Width = 500;
            // 
            // listMesas
            // 
            this.listMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMesas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listMesas.Depth = 0;
            this.listMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listMesas.FullRowSelect = true;
            this.listMesas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listMesas.Location = new System.Drawing.Point(205, 64);
            this.listMesas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listMesas.MouseState = MaterialSkin.MouseState.OUT;
            this.listMesas.MultiSelect = false;
            this.listMesas.Name = "listMesas";
            this.listMesas.OwnerDraw = true;
            this.listMesas.Shadow = null;
            this.listMesas.ShadowShape = null;
            this.listMesas.Size = new System.Drawing.Size(240, 398);
            this.listMesas.TabIndex = 11;
            this.listMesas.UseCompatibleStateImageBehavior = false;
            this.listMesas.View = System.Windows.Forms.View.Details;
            this.listMesas.SelectedIndexChanged += new System.EventHandler(this.listMesas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mesas";
            this.columnHeader1.Width = 350;
            // 
            // materialPanel1
            // 
            this.materialPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPanel1.ChangeBackColor = false;
            this.materialPanel1.Controls.Add(this.materialLabel4);
            this.materialPanel1.Controls.Add(this.materialRaisedButton3);
            this.materialPanel1.Controls.Add(this.materialRaisedButton4);
            this.materialPanel1.Controls.Add(this.materialLabel5);
            this.materialPanel1.Controls.Add(this.txtDuracion);
            this.materialPanel1.Controls.Add(this.lblHora);
            this.materialPanel1.Controls.Add(this.materialLabel3);
            this.materialPanel1.Controls.Add(this.dateTimePicker1);
            this.materialPanel1.Controls.Add(this.materialRaisedButton1);
            this.materialPanel1.Controls.Add(this.materialRaisedButton2);
            this.materialPanel1.Controls.Add(this.btnMenos);
            this.materialPanel1.Controls.Add(this.materialLabel2);
            this.materialPanel1.Controls.Add(this.btnMas);
            this.materialPanel1.Controls.Add(this.txtMinutos);
            this.materialPanel1.Controls.Add(this.materialLabel1);
            this.materialPanel1.Controls.Add(this.txtHora);
            this.materialPanel1.Depth = 0;
            this.materialPanel1.Location = new System.Drawing.Point(732, 64);
            this.materialPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Primary = false;
            this.materialPanel1.RoundedCornerRadius = 2;
            this.materialPanel1.Shadow = null;
            graphicsPath9.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialPanel1.ShadowShape = graphicsPath9;
            this.materialPanel1.Size = new System.Drawing.Size(267, 356);
            this.materialPanel1.TabIndex = 17;
            this.materialPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialPanel1_Paint);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Depth = 0;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHora.FontSize = 11;
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHora.Location = new System.Drawing.Point(155, 124);
            this.lblHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHora.Name = "lblHora";
            this.lblHora.Primary = false;
            this.lblHora.Shadow = null;
            this.lblHora.ShadowShape = null;
            this.lblHora.Size = new System.Drawing.Size(0, 19);
            this.lblHora.TabIndex = 32;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.FontSize = 11;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 10);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Primary = false;
            this.materialLabel3.Shadow = null;
            this.materialLabel3.ShadowShape = null;
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 31;
            this.materialLabel3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialRaisedButton1.FontSize = 9;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(68, 214);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.RoundedCornerRadius = 2;
            this.materialRaisedButton1.Shadow = null;
            graphicsPath5.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialRaisedButton1.ShadowShape = graphicsPath5;
            this.materialRaisedButton1.Size = new System.Drawing.Size(44, 44);
            this.materialRaisedButton1.TabIndex = 28;
            this.materialRaisedButton1.Text = "-";
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialRaisedButton2.FontSize = 9;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(196, 214);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.RoundedCornerRadius = 2;
            this.materialRaisedButton2.Shadow = null;
            graphicsPath6.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialRaisedButton2.ShadowShape = graphicsPath6;
            this.materialRaisedButton2.Size = new System.Drawing.Size(44, 44);
            this.materialRaisedButton2.TabIndex = 29;
            this.materialRaisedButton2.Text = "+";
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click_1);
            // 
            // btnMenos
            // 
            this.btnMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenos.Depth = 0;
            this.btnMenos.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnMenos.FontSize = 9;
            this.btnMenos.Icon = null;
            this.btnMenos.Location = new System.Drawing.Point(68, 111);
            this.btnMenos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Primary = true;
            this.btnMenos.RoundedCornerRadius = 2;
            this.btnMenos.Shadow = null;
            graphicsPath7.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnMenos.ShadowShape = graphicsPath7;
            this.btnMenos.Size = new System.Drawing.Size(44, 44);
            this.btnMenos.TabIndex = 24;
            this.btnMenos.Text = "-";
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click_1);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.FontSize = 11;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 192);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Primary = false;
            this.materialLabel2.Shadow = null;
            this.materialLabel2.ShadowShape = null;
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Minutos:";
            // 
            // btnMas
            // 
            this.btnMas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMas.Depth = 0;
            this.btnMas.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnMas.FontSize = 9;
            this.btnMas.Icon = null;
            this.btnMas.Location = new System.Drawing.Point(196, 111);
            this.btnMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMas.Name = "btnMas";
            this.btnMas.Primary = true;
            this.btnMas.RoundedCornerRadius = 2;
            this.btnMas.Shadow = null;
            graphicsPath8.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnMas.ShadowShape = graphicsPath8;
            this.btnMas.Size = new System.Drawing.Size(44, 44);
            this.btnMas.TabIndex = 25;
            this.btnMas.Text = "+";
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click_1);
            // 
            // txtMinutos
            // 
            this.txtMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMinutos.Depth = 0;
            this.txtMinutos.EnterToTab = false;
            this.txtMinutos.Hint = "";
            this.txtMinutos.IsNumerical = true;
            this.txtMinutos.Location = new System.Drawing.Point(118, 223);
            this.txtMinutos.MaxLength = 32767;
            this.txtMinutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.PasswordChar = '\0';
            this.txtMinutos.SelectedText = "";
            this.txtMinutos.SelectionLength = 0;
            this.txtMinutos.SelectionStart = 0;
            this.txtMinutos.Shadow = null;
            this.txtMinutos.ShadowShape = null;
            this.txtMinutos.Size = new System.Drawing.Size(54, 23);
            this.txtMinutos.TabIndex = 26;
            this.txtMinutos.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.FontSize = 11;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Primary = false;
            this.materialLabel1.Shadow = null;
            this.materialLabel1.ShadowShape = null;
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Hora:";
            // 
            // txtHora
            // 
            this.txtHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHora.Depth = 0;
            this.txtHora.EnterToTab = false;
            this.txtHora.Hint = "";
            this.txtHora.IsNumerical = true;
            this.txtHora.Location = new System.Drawing.Point(118, 120);
            this.txtHora.MaxLength = 32767;
            this.txtHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHora.Name = "txtHora";
            this.txtHora.PasswordChar = '\0';
            this.txtHora.SelectedText = "";
            this.txtHora.SelectionLength = 0;
            this.txtHora.SelectionStart = 0;
            this.txtHora.Shadow = null;
            this.txtHora.ShadowShape = null;
            this.txtHora.Size = new System.Drawing.Size(31, 23);
            this.txtHora.TabIndex = 22;
            this.txtHora.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(451, 64);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Shadow = null;
            this.materialDivider1.ShadowShape = null;
            this.materialDivider1.Size = new System.Drawing.Size(10, 398);
            this.materialDivider1.TabIndex = 18;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // opciones1
            // 
            this.opciones1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones1.Location = new System.Drawing.Point(0, 64);
            this.opciones1.Name = "opciones1";
            this.opciones1.Size = new System.Drawing.Size(199, 398);
            this.opciones1.TabIndex = 2;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialRaisedButton3.FontSize = 9;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(68, 306);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.RoundedCornerRadius = 2;
            this.materialRaisedButton3.Shadow = null;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialRaisedButton3.ShadowShape = graphicsPath3;
            this.materialRaisedButton3.Size = new System.Drawing.Size(44, 44);
            this.materialRaisedButton3.TabIndex = 35;
            this.materialRaisedButton3.Text = "-";
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Font = new System.Drawing.Font("Roboto", 9F);
            this.materialRaisedButton4.FontSize = 9;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(211, 306);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.RoundedCornerRadius = 2;
            this.materialRaisedButton4.Shadow = null;
            graphicsPath4.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialRaisedButton4.ShadowShape = graphicsPath4;
            this.materialRaisedButton4.Size = new System.Drawing.Size(44, 44);
            this.materialRaisedButton4.TabIndex = 36;
            this.materialRaisedButton4.Text = "+";
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.FontSize = 11;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 283);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Primary = false;
            this.materialLabel5.Shadow = null;
            this.materialLabel5.ShadowShape = null;
            this.materialLabel5.Size = new System.Drawing.Size(73, 19);
            this.materialLabel5.TabIndex = 34;
            this.materialLabel5.Text = "Duracion:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDuracion.Depth = 0;
            this.txtDuracion.EnterToTab = false;
            this.txtDuracion.Hint = "";
            this.txtDuracion.IsNumerical = true;
            this.txtDuracion.Location = new System.Drawing.Point(118, 315);
            this.txtDuracion.MaxLength = 32767;
            this.txtDuracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PasswordChar = '\0';
            this.txtDuracion.SelectedText = "";
            this.txtDuracion.SelectionLength = 0;
            this.txtDuracion.SelectionStart = 0;
            this.txtDuracion.Shadow = null;
            this.txtDuracion.ShadowShape = null;
            this.txtDuracion.Size = new System.Drawing.Size(31, 23);
            this.txtDuracion.TabIndex = 33;
            this.txtDuracion.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.FontSize = 11;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(155, 319);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Primary = false;
            this.materialLabel4.Shadow = null;
            this.materialLabel4.ShadowShape = null;
            this.materialLabel4.Size = new System.Drawing.Size(50, 19);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "Horas";
            // 
            // AgregarReservacionFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1011, 474);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialPanel1);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.listMesas);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.opciones1);
            this.Name = "AgregarReservacionFrm";
            this.Text = "AgregarReservacionFrm";
            this.materialPanel1.ResumeLayout(false);
            this.materialPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ControlesPropios.Opciones opciones1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoCliente;
        private MaterialSkin.Controls.MaterialListView listMesas;
        private MaterialSkin.Controls.MaterialListView listClientes;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialPanel materialPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnMenos;
        private MaterialSkin.Controls.MaterialRaisedButton btnMas;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHora;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMinutos;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel lblHora;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDuracion;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}