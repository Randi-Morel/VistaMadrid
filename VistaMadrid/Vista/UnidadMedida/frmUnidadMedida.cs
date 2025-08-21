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

namespace VistaMadrid.Vista.Mantenimientos.UnidadMedida
{
    public partial class frmUnidadMedida : Form, IUnidadMedida, IAccionesMantenimiento
    {
        public PresentadorUnidadMedida Presentador { get; set; }
        private ConfiguracionControlesUnidadMedida _ConfiguracionControlesUnidadMedida;

        public frmUnidadMedida()
        {
            InitializeComponent();
            Presentador = new PresentadorUnidadMedida(this);
            _ConfiguracionControlesUnidadMedida = new ConfiguracionControlesUnidadMedida(this, Presentador);
            _ConfiguracionControlesUnidadMedida.Configuracion();
        }

        public int ID_UnidadMedida
        {
            get
            {
                var s = TID_UnidadMedida?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_UnidadMedida.Text = value.ToString();
            }
        }

        public string Descripcion { get => TDescripcion.TextButton; set => TDescripcion.TextButton = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceUnidadMedida
        {
            set => GRD.DataSource = value;
        }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesUnidadMedida.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesUnidadMedida.CargarDatosGRD();
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
                    _ConfiguracionControlesUnidadMedida.CargarDatosGRD();
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
            ID_UnidadMedida = 0;
            Descripcion = null;
            Activo = true;
        }
        #endregion

        private void frmUnidadMedida_Resize(object sender, EventArgs e)
        {
            pnDescripcion.Location = new System.Drawing.Point((int)(tblCentral.Width * 0.17), 31);
            pnDescripcion.Size = new System.Drawing.Size((int)(tblCentral.Width * 0.34), pnDescripcion.Height);
            pnEstado.Location = new System.Drawing.Point((int)(pnDescripcion.Location.X * 3.19), 31);
        }
    }
}
