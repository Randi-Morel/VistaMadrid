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

namespace VistaMadrid.Vista.Mantenimientos.Proveedor
{
    public partial class frmProveedor : Form, IProveedor, IAccionesMantenimiento
    {
        public PresentadorProveedor Presentador { get; set; }
        private ConfiguracionControlesProveedor _ConfiguracionControlesProveedor;

        public frmProveedor()
        {
            InitializeComponent();
            Presentador = new PresentadorProveedor(this);
            _ConfiguracionControlesProveedor = new ConfiguracionControlesProveedor(this, Presentador);
            _ConfiguracionControlesProveedor.Configuracion();
        }

        public int ID_Proveedor
        {
            get
            {
                var s = TID_Proveedor?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_Proveedor.Text = value.ToString();
            }
        }

        public string Nombre { get => TNombre.Text; set => TNombre.Text = value; }

        public string Telefono { get => TTelefono.Text; set => TTelefono.Text = value; }

        public string Email { get => TEmail.Text; set => TEmail.Text = value; }

        public string Direccion { get => TDireccion.TextButton; set => TDireccion.TextButton = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceProveedor
        {
            set => GRD.DataSource = value;
        }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesProveedor.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesProveedor.CargarDatosGRD();
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
                    _ConfiguracionControlesProveedor.CargarDatosGRD();
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
            ID_Proveedor = 0;
            Nombre = null;
            Telefono = null;
            Email = null;
            Direccion = null;
            Activo = true;
        }
        #endregion

        private void frmProveedor_Resize(object sender, EventArgs e)
        {
            lblInfo.Location = new Point(tblInfoEmpleado.Location.X, lblInfo.Location.Y);
            lblAccesibilidad.Location = new Point(tblAccesibilidad.Location.X, lblAccesibilidad.Location.Y);
        }
    }
}
