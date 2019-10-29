using CapaAccesoDatos;
using CapaLogica.Login;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class LoginFrm : MaterialForm
    {
        public bool Logged { get; internal set; }
        public Trabajador Trabajador { get; internal set; }

        public LoginFrm()
        {
            var asForm = System.Windows.Automation.AutomationElement.FromHandle(this.Handle);
            InitializeComponent();
            MaterialSkinManager.AddFormToManage(this);
            MaterialSkinManager.ColorScheme = new ColorScheme(Primary.RojoCuadra, Primary.RojoC4, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

            MaterialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.SoftShadow = true;


            btnLogin.Focus();
            ActiveControl = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Trabajador trabajador = LoginManager.Login(txtUsuario.Text, txtContrasena.Text);
            if (trabajador == null)
            {
                MessageBox.Show("No existe el usuario o contraseña");
                return;
            }
            this.Trabajador = trabajador;
            Logged = true;
            Close();
        }

        private void LoginFrm_Shown(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Detecta si la tecla es un ENTER
            if(e.KeyChar == (char)Keys.Enter) btnLogin_Click(sender, e);
            
            
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Detecta si la tecla es un ENTER
            if (e.KeyChar == (char)Keys.Enter) btnLogin_Click(sender, e);


        }
    }
}
