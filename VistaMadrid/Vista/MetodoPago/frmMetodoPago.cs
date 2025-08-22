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

namespace VistaMadrid.Vista.Mantenimientos.MetodoPago
{
    public partial class frmMetodoPago : Form, IMetodoPago, IAccionesMantenimiento
    {
        public PresentadorMetodoPago Presentador { get; set; }
        private ConfiguracionControlesMetodoPago _ConfiguracionControlesMetodoPago;

        public frmMetodoPago()
        {
            InitializeComponent();
            Presentador = new PresentadorMetodoPago(this);
            _ConfiguracionControlesMetodoPago = new ConfiguracionControlesMetodoPago(this, Presentador);
            _ConfiguracionControlesMetodoPago.Configuracion();
        }

        public int ID_MetodoPago
        {
            get
            {
                var s = TID_MetodoPago?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_MetodoPago.Text = value.ToString();
            }
        }

        public string Descripcion { get => TDescripcion.TextButton; set => TDescripcion.TextButton = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceMetodoPago
        {
            set => GRD.DataSource = value;
        }

        public string ConsultaDescripcion { get => TConsultaDescripcion.Text; set => TConsultaDescripcion.Text = value; }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesMetodoPago.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesMetodoPago.CargarDatosGRD();
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
                    _ConfiguracionControlesMetodoPago.CargarDatosGRD();
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
            ID_MetodoPago = 0;
            Descripcion = null;
            Activo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ConfiguracionControlesMetodoPago.CargarDatosGRD();
        }
        #endregion

        private void frmMetodoPago_Resize(object sender, EventArgs e)
        {
            pnDescripcion.Location = new System.Drawing.Point((int)(tblCentral.Width * 0.17), 31);
            pnDescripcion.Size = new System.Drawing.Size((int)(tblCentral.Width * 0.34), pnDescripcion.Height);
            pnEstado.Location = new System.Drawing.Point((int)(pnDescripcion.Location.X * 3.19), 31);
        }
    }
}
