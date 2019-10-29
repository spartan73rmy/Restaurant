namespace CapaPresentacion.Trabajadores
{
    partial class EditarTrabajador
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
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBorrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbPuestos = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ckAcceso = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.EnterToTab = false;
            this.txtDireccion.Hint = "Direccion";
            this.txtDireccion.Location = new System.Drawing.Point(222, 99);
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
            this.txtDireccion.TabIndex = 8;
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
            this.btnBorrar.Location = new System.Drawing.Point(383, 349);
            this.btnBorrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Primary = true;
            this.btnBorrar.RoundedCornerRadius = 2;
            this.btnBorrar.Shadow = null;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnBorrar.ShadowShape = graphicsPath1;
            this.btnBorrar.Size = new System.Drawing.Size(147, 55);
            this.btnBorrar.TabIndex = 14;
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
            this.btnAceptar.Location = new System.Drawing.Point(536, 349);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.RoundedCornerRadius = 2;
            this.btnAceptar.Shadow = null;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAceptar.ShadowShape = graphicsPath2;
            this.btnAceptar.Size = new System.Drawing.Size(147, 55);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(222, 134);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.EnterToTab = false;
            this.txtTelefono.Hint = "Telefono";
            this.txtTelefono.Location = new System.Drawing.Point(16, 99);
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
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Depth = 0;
            this.txtApellidos.EnterToTab = false;
            this.txtApellidos.Hint = "Apellidos";
            this.txtApellidos.Location = new System.Drawing.Point(222, 70);
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
            this.txtApellidos.TabIndex = 6;
            this.txtApellidos.UseSystemPasswordChar = false;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ic_face_black_24dp_2x;
            this.pictureBox1.Location = new System.Drawing.Point(540, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 152);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.EnterToTab = false;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(16, 70);
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
            this.txtNombre.TabIndex = 5;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.FontSize = 11;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(61, 135);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Primary = false;
            this.materialLabel1.Shadow = null;
            this.materialLabel1.ShadowShape = null;
            this.materialLabel1.Size = new System.Drawing.Size(155, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Fecha de Nacimiento:";
            // 
            // cbPuestos
            // 
            this.cbPuestos.FormattingEnabled = true;
            this.cbPuestos.Location = new System.Drawing.Point(222, 163);
            this.cbPuestos.Name = "cbPuestos";
            this.cbPuestos.Size = new System.Drawing.Size(121, 21);
            this.cbPuestos.TabIndex = 10;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.FontSize = 11;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(156, 165);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Primary = false;
            this.materialLabel2.Shadow = null;
            this.materialLabel2.ShadowShape = null;
            this.materialLabel2.Size = new System.Drawing.Size(60, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Puesto:";
            // 
            // ckAcceso
            // 
            this.ckAcceso.Checked = false;
            this.ckAcceso.Depth = 0;
            this.ckAcceso.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckAcceso.Location = new System.Drawing.Point(16, 198);
            this.ckAcceso.Margin = new System.Windows.Forms.Padding(0);
            this.ckAcceso.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckAcceso.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckAcceso.Name = "ckAcceso";
            this.ckAcceso.Ripple = true;
            this.ckAcceso.Shadow = null;
            this.ckAcceso.ShadowShape = null;
            this.ckAcceso.Size = new System.Drawing.Size(160, 36);
            this.ckAcceso.TabIndex = 16;
            this.ckAcceso.Text = "Editar Acceso";
            this.ckAcceso.Visible = false;
            this.ckAcceso.CheckedChanged += new MaterialSkin.Controls.MaterialCheckBox.CheckedChangedEventHandler(this.ckAcceso_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Depth = 0;
            this.txtPass.EnterToTab = false;
            this.txtPass.Hint = "Contraseña";
            this.txtPass.Location = new System.Drawing.Point(16, 266);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Shadow = null;
            this.txtPass.ShadowShape = null;
            this.txtPass.Size = new System.Drawing.Size(200, 23);
            this.txtPass.TabIndex = 12;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.EnterToTab = false;
            this.txtUser.Hint = "Usuario";
            this.txtUser.Location = new System.Drawing.Point(16, 237);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Shadow = null;
            this.txtUser.ShadowShape = null;
            this.txtUser.Size = new System.Drawing.Size(200, 23);
            this.txtUser.TabIndex = 11;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnCancelar.FontSize = 9;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(16, 349);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.RoundedCornerRadius = 2;
            this.btnCancelar.Shadow = null;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnCancelar.ShadowShape = graphicsPath3;
            this.btnCancelar.Size = new System.Drawing.Size(147, 55);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EditarTrabajador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(695, 416);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.ckAcceso);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cbPuestos);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.Name = "EditarTrabajador";
            this.Text = "EditarMesero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialRaisedButton btnBorrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cbPuestos;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox ckAcceso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
    }
}