using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VistaMadrid.MP;

namespace VistaMadrid.Vista.Mantenimientos.Mesa
{
    public partial class frmMesa : Form, IMesa
    {
        public PresentadorMesa Presentador { get; set; }
        private ConfiguracionControlesMesa _ConfiguracionControlesMesa;

        public frmMesa()
        {
            InitializeComponent();
            Presentador = new PresentadorMesa(this);
            _ConfiguracionControlesMesa = new ConfiguracionControlesMesa(this, Presentador);
            _ConfiguracionControlesMesa.Configuracion();
        }

        public int ID_Mesa { get; set; }

        public int ID_Sala { get => cbSala.SelectedValue == null ? 0 : Convert.ToInt32(cbSala.SelectedValue); set => cbSala.SelectedValue = value; }

        public string Descripcion { get => txtDescripcion.Text; set => txtDescripcion.Text = value; }

        public int Asientos { get => Decimal.ToInt32(nudDiasCredito.Value); set => nudDiasCredito.Value = value; }

        public bool Activo { get; set; }

        #region "Eventos del Formulario"
        private void frmMesa_Resize(object sender, EventArgs e)
        {
            if (this.Width <= 900)
            {
                rbInactivo.Location = new System.Drawing.Point(rbActivo.Location.X, rbActivo.Location.Y + 30);
            }
            else {
                rbInactivo.Location = new System.Drawing.Point(123, 61);
            }
        }
        #endregion

    }
}

