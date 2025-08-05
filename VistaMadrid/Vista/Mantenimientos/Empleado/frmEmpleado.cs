using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid.Vista.Mantenimientos.Empleados
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void frmEmpleado_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void frmEmpleado_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout();
            lblInfoEmpleado.Location = new Point(tblInfoEmpleado.Location.X, lblInfoEmpleado.Location.Y);
            lblAccesibilidad.Location = new Point(tblAccesibilidad.Location.X, lblAccesibilidad.Location.Y);
        }
    }
}
