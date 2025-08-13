using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid.Vista.Mantenimientos.Cliente
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void frmCliente_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout();
            lblInfo.Location = new Point(tblInfoEmpleado.Location.X, lblInfo.Location.Y);
            lblAccesibilidad.Location = new Point(tblAccesibilidad.Location.X, lblAccesibilidad.Location.Y);
        }
    }
}
