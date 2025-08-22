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

namespace VistaMadrid.Vista.Mantenimientos.TipoMovimiento
{
    public partial class frmTipoMovimiento : Form, ITipoMovimiento, IAccionesMantenimiento
    {
        public PresentadorTipoMovimiento Presentador { get; set; }
        private ConfiguracionControlesTipoMovimiento _ConfiguracionControlesTipoMovimiento;

        public frmTipoMovimiento()
        {
            InitializeComponent();
            Presentador = new PresentadorTipoMovimiento(this);
            _ConfiguracionControlesTipoMovimiento = new ConfiguracionControlesTipoMovimiento(this, Presentador);
            _ConfiguracionControlesTipoMovimiento.Configuracion();
        }

        public int ID_MovimientoTipo
        {
            get
            {
                var s = TID_MovimientoTipo?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_MovimientoTipo.Text = value.ToString();
            }
        }

        public string Descripcion { get => TDescripcion.TextButton; set => TDescripcion.TextButton = value; }

        public bool AfectaStock { get => CHKAfectaStock.Checked; set => CHKAfectaStock.Checked = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceTipoMovimiento
        {
            set => GRD.DataSource = value;
        }

        public string ConsultaDescripcion { get => TConsultaDescripcion.Text; set => TConsultaDescripcion.Text = value; }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesTipoMovimiento.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesTipoMovimiento.CargarDatosGRD();
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
                    _ConfiguracionControlesTipoMovimiento.CargarDatosGRD();
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
            ID_MovimientoTipo = 0;
            Descripcion = null;
            AfectaStock = false;
            Activo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ConfiguracionControlesTipoMovimiento.CargarDatosGRD();
        }
        #endregion
    }
}
