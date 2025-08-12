using System;
using System.Drawing;
using System.Windows.Forms;
using VistaMadrid.MP;

namespace VistaMadrid
{
    public partial class frmLogin : Form, ILogin
    {
        public PresentadorLogin Presentador { get; set; }

        private Point lastLocation;
        private bool mouseDown;

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

        #region "Para mover el login de sitio"
        private void pnSuperiorIzquierda_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void pnSuperiorIzquierda_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void pnSuperiorIzquierda_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnSuperiorDerecha_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnSuperiorDerecha_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnSuperiorDerecha_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

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

        private void btnSalir_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
