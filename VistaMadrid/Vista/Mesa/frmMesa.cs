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
    public partial class frmMesa : Form, IMesa, IAccionesMantenimiento
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

        public int ID_Mesa
        {
            get
            {
                var s = TID_Mesa?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_Mesa.Text = value.ToString();
            }
        }

        public int ID_Sala { get => cbSala.SelectedValue == null ? 0 : Convert.ToInt32(cbSala.SelectedValue); set => cbSala.SelectedValue = value; }

        public string Descripcion { get => txtDescripcion.TextButton; set => txtDescripcion.TextButton = value; }

        public int Asientos { get => Decimal.ToInt32(nudDiasCredito.Value); set => nudDiasCredito.Value = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceMesa
        {
            set => GRD.DataSource = value;
        }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            if (!_ConfiguracionControlesMesa.ComprobarParaGuardar(out var msg))
            {
                MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return Presentador.Guardar();
        }

        public bool Eliminar()
        {
            return Presentador.Eliminar();
        }

        public void Limpiar()
        {
            // Reinicia controles…
            ID_Mesa = 0;
            Descripcion = null; 
            ID_Sala = -1;
            Asientos= 2;
            Activo = true;
        }

        private void frmMesa_Resize(object sender, EventArgs e)
        {
            CHKActivo.Location = new System.Drawing.Point(123, 61);
        }
        #endregion

    }
}

