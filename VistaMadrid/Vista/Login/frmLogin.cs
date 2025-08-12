using System;
using System.Drawing;
using System.Windows.Forms;
using VistaMadrid.MP;

namespace VistaMadrid
{
    public partial class frmLogin : Form, ILogin
    {
        public PresentadorLogin Presentador { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            Presentador = new PresentadorLogin(this);

            this.txtUsuario.AutoSize = false;
            this.txtUsuario.Size = new Size(309, 32);

            this.txtPassword.AutoSize = false;
            this.txtPassword.Size = new Size(309, 32);
            this.txtPassword.UseSystemPasswordChar = true;
        }

        public string Usuario { get => txtUsuario.Text; set => txtUsuario.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public void Entrada()
        {
            Presentador.Autenticar();
        }

        #region "Eventos del Formulario"
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var usuario = Presentador.Autenticar();

            if (usuario != null)
            {
                var frmPrincipal = new frmPrincipal();
                frmPrincipal.FormClosed += (s, args) => this.Close();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
        #endregion
    }
}
