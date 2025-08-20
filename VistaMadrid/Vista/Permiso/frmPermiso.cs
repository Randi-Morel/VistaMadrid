using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid.Vista.Mantenimientos.Permiso
{
    public partial class frmPermiso : Form
    {
        public frmPermiso()
        {
            InitializeComponent();
        }

        private void frmPermiso_Resize(object sender, EventArgs e)
        {
            pnDescripcion.Location = new System.Drawing.Point((int)(tblCentral.Width * 0.17), 31);
            pnDescripcion.Size = new System.Drawing.Size((int)(tblCentral.Width * 0.34), pnDescripcion.Height);
            pnEstado.Location = new System.Drawing.Point((int)(pnDescripcion.Location.X * 3.19), 31);
        }
    }
}
