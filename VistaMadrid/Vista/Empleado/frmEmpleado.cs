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
using VistaMadrid.MP.EF;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VistaMadrid.Vista.Mantenimientos.Empleado
{
    public partial class frmEmpleado : Form, IEmpleado, IAccionesMantenimiento
    {
        public PresentadorEmpleado Presentador { get; set; }
        private ConfiguracionControlesEmpleado _ConfiguracionControlesEmpleado;

        public frmEmpleado()
        {
            InitializeComponent();
            Presentador = new PresentadorEmpleado(this);
            _ConfiguracionControlesEmpleado = new ConfiguracionControlesEmpleado(this, Presentador);
            _ConfiguracionControlesEmpleado.Configuracion();
        }

        public int ID_Usuario
        {
            get
            {
                var s = TID_Usuario?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_Usuario.Text = value.ToString();
            }
        }

        public int ID_Rol { get => CID_Rol.SelectedValue == null ? 0 : Convert.ToInt32(CID_Rol.SelectedValue); set => CID_Rol.SelectedValue = value; }
        
        public string Usuario { get => TUsuario.Text; set => TUsuario.Text = value; }

        public string Contrasena { get => TContrasena.Text; set => TContrasena.Text = value; }
        
        public string Nombre { get => TNombre.Text; set => TNombre.Text = value; }

        public string Apellidos { get => TApellidos.Text; set => TApellidos.Text = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceUsuario
        {
            set => GRD.DataSource = value;
        }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesEmpleado.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesEmpleado.CargarDatosGRD();
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
                    _ConfiguracionControlesEmpleado.CargarDatosGRD();
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
            ID_Usuario = 0;
            ID_Rol = -1;
            Usuario = null;
            Contrasena = null;
            Nombre = null;
            Apellidos = null;
            Activo = true;
        }
        #endregion

        private void frmEmpleado_Resize(object sender, EventArgs e)
        {
            lblInfo.Location = new Point(tblInfoEmpleado.Location.X, lblInfo.Location.Y);
            lblAccesibilidad.Location = new Point(tblAccesibilidad.Location.X, lblAccesibilidad.Location.Y);
        }
    }
}
