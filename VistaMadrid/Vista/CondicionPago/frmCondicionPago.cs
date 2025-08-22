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

namespace VistaMadrid.Vista.Mantenimientos.CondicionPago
{
    public partial class frmCondicionPago : Form, ICondicionPago, IAccionesMantenimiento
    {
        public PresentadorCondicionPago Presentador { get; set; }
        private ConfiguracionControlesCondicionPago _ConfiguracionControlesCondicionPago;

        public frmCondicionPago()
        {
            InitializeComponent();
            Presentador = new PresentadorCondicionPago(this);
            _ConfiguracionControlesCondicionPago = new ConfiguracionControlesCondicionPago(this, Presentador);
            _ConfiguracionControlesCondicionPago.Configuracion();
        }

        public int ID_Condicion
        {
            get
            {
                var s = TID_Condicion?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_Condicion.Text = value.ToString();
            }
        }

        public string Descripcion { get => TDescripcion.TextButton; set => TDescripcion.TextButton = value; }

        public bool AutoPago { get => CHKAutoPago.Checked; set => CHKAutoPago.Checked = value; }

        public int DiasCredito { get => Decimal.ToInt32(NUMDiasCredito.Value); set => NUMDiasCredito.Value = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceCondicionPago
        {
            set => GRD.DataSource = value;
        }

        public string ConsultaDescripcion { get => TConsultaDescripcion.Text; set => TConsultaDescripcion.Text = value; }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesCondicionPago.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesCondicionPago.CargarDatosGRD();
                }

                return ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Eliminar()
        {
            try
            {
                bool ok = Presentador.Eliminar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesCondicionPago.CargarDatosGRD();
                }

                return ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void Limpiar()
        {
            // Reinicia controles…
            ID_Condicion = 0;
            Descripcion = null;
            AutoPago = false;
            DiasCredito = 1;
            Activo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ConfiguracionControlesCondicionPago.CargarDatosGRD();
        }
        #endregion
    }
}
