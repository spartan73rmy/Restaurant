namespace CapaPresentacion.Clientes
{
    partial class EditarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be 
        /// d; otherwise, false.</param>
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
            this.txtRFC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBorrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRFC
            // 
            this.txtRFC.Depth = 0;
            this.txtRFC.EnterToTab = false;
            this.txtRFC.Hint = " R F C";
            this.txtRFC.Location = new System.Drawing.Point(12, 189);
            this.txtRFC.MaxLength = 32767;
            this.txtRFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.PasswordChar = '\0';
            this.txtRFC.SelectedText = "";
            this.txtRFC.SelectionLength = 0;
            this.txtRFC.SelectionStart = 0;
            this.txtRFC.Shadow = null;
            this.txtRFC.ShadowShape = null;
            this.txtRFC.Size = new System.Drawing.Size(200, 23);
            this.txtRFC.TabIndex = 18;
            this.txtRFC.UseSystemPasswordChar = false;
            this.txtRFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRFC_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.EnterToTab = false;
            this.txtDireccion.Hint = "Direccion";
            this.txtDireccion.Location = new System.Drawing.Point(12, 160);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Shadow = null;
            this.txtDireccion.ShadowShape = null;
            this.txtDireccion.Size = new System.Drawing.Size(200, 23);
            this.txtDireccion.TabIndex = 17;
            this.txtDireccion.UseSystemPasswordChar = false;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBorrar.Depth = 0;
            this.btnBorrar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnBorrar.FontSize = 9;
            this.btnBorrar.Icon = null;
            this.btnBorrar.Location = new System.Drawing.Point(188, 275);
            this.btnBorrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Primary = true;
            this.btnBorrar.RoundedCornerRadius = 2;
            this.btnBorrar.Shadow = null;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnBorrar.ShadowShape = graphicsPath1;
            this.btnBorrar.Size = new System.Drawing.Size(147, 55);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAceptar.FontSize = 9;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(341, 275);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.RoundedCornerRadius = 2;
            this.btnAceptar.Shadow = null;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAceptar.ShadowShape = graphicsPath2;
            this.btnAceptar.Size = new System.Drawing.Size(147, 55);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.EnterToTab = false;
            this.txtTelefono.Hint = "Telefono";
            this.txtTelefono.Location = new System.Drawing.Point(12, 131);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Shadow = null;
            this.txtTelefono.ShadowShape = null;
            this.txtTelefono.Size = new System.Drawing.Size(200, 23);
            this.txtTelefono.TabIndex = 16;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Depth = 0;
            this.txtApellidos.EnterToTab = false;
            this.txtApellidos.Hint = "Apellidos";
            this.txtApellidos.Location = new System.Drawing.Point(12, 102);
            this.txtApellidos.MaxLength = 32767;
            this.txtApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.Shadow = null;
            this.txtApellidos.ShadowShape = null;
            this.txtApellidos.Size = new System.Drawing.Size(200, 23);
            this.txtApellidos.TabIndex = 15;
            this.txtApellidos.UseSystemPasswordChar = false;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ic_face_black_24dp_2x;
            this.pictureBox1.Location = new System.Drawing.Point(345, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.EnterToTab = false;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(12, 73);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Shadow = null;
            this.txtNombre.ShadowShape = null;
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnCancelar.FontSize = 9;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(35, 275);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.RoundedCornerRadius = 2;
            this.btnCancelar.Shadow = null;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnCancelar.ShadowShape = graphicsPath3;
            this.btnCancelar.Size = new System.Drawing.Size(147, 55);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EditarCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 342);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtRFC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialRaisedButton btnBorrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
    }
}