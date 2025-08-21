using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid.Vista.Mantenimientos.Producto
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }


        private void frmProducto_Resize(object sender, EventArgs e)
        {
            lblInfo.Location = new Point(tblInfoEmpleado.Location.X, lblInfo.Location.Y);
            lblAccesibilidad.Location = new Point(tblAccesibilidad.Location.X, lblAccesibilidad.Location.Y);
        }
    }
}
