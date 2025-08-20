using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid.Vista.Mantenimientos.Condicion_de_Pago
{
    public partial class frmCondicionPago : Form
    {
        public frmCondicionPago()
        {
            InitializeComponent();
        }

        private void frmCondicionPago_Resize(object sender, EventArgs e)
        {
            if (this.Width <= 900)
            {
                rbInactivo.Location = new System.Drawing.Point(rbActivo.Location.X, rbActivo.Location.Y + 30);
            }
            else
            {
                rbInactivo.Location = new System.Drawing.Point(123, 61);
            }
        }
    }
}
