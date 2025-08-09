using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            //Sirve para añadirle altura customizada
            this.txtUsuario.AutoSize = false;
            this.txtUsuario.Size = new System.Drawing.Size(309, 32);

            this.txtPassword.AutoSize = false;
            this.txtPassword.Size = new System.Drawing.Size(309, 32);
        }
    }
}
