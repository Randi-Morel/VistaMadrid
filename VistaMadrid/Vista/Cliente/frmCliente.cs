using System;
using System.Drawing;
using System.Windows.Forms;
using VistaMadrid.MP;

namespace VistaMadrid.Vista.Mantenimientos.Cliente
{
    public partial class frmCliente : Form, ICliente, IAccionesMantenimiento
    {
        public PresentadorCliente Presentador { get; set; }
        private ConfiguracionControlesCliente _ConfiguracionControlesCliente;

        public frmCliente()
        {
            InitializeComponent();
            Presentador = new PresentadorCliente(this);
            _ConfiguracionControlesCliente = new ConfiguracionControlesCliente(this, Presentador);
            _ConfiguracionControlesCliente.Configuracion();
        }

        public int ID_Cliente
        {
            get
            {
                var s = TID_Cliente?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_Cliente.Text = value.ToString();
            }
        }

        public string Nombre { get => TNombre.Text; set => TNombre.Text = value; }

        public string Telefono { get => TTelefono.Text; set => TTelefono.Text= value; }

        public string Email { get => TEmail.Text; set => TEmail.Text = value; }

        public string Direccion { get => TDireccion.TextButton; set => TDireccion.TextButton = value; }

        public int ID_Condicion { get => CID_Condicion.SelectedValue == null ? 0 : Convert.ToInt32(CID_Condicion.SelectedValue); set => CID_Condicion.SelectedValue = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceCliente
        {
            set => GRD.DataSource = value;
        }

        public string ConsultaDescripcion { get => TConsultaNombre.Text; set => TConsultaNombre.Text = value; }

        public int ConsultaID_Condicion { get => CConsultaID_Condicion.SelectedValue == null ? 0 : Convert.ToInt32(CConsultaID_Condicion.SelectedValue); set => CID_Condicion.SelectedValue = value; }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesCliente.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesCliente.CargarDatosGRD();
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
                    _ConfiguracionControlesCliente.CargarDatosGRD();
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
            ID_Cliente = 0;
            Nombre = null;
            Telefono = null;
            Email = null;
            Direccion = null;
            ID_Condicion = -1;
            Activo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ConfiguracionControlesCliente.CargarDatosGRD();
        }
        #endregion

        private void frmCliente_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void frmCliente_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout();
            lblInfo.Location = new Point(tblInfoEmpleado.Location.X, lblInfo.Location.Y);
            lblAccesibilidad.Location = new Point(tblAccesibilidad.Location.X, lblAccesibilidad.Location.Y);
        }
    }
}
