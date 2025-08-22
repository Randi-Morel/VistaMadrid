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

namespace VistaMadrid.Vista.Mantenimientos.Categoria
{
    public partial class frmCategoria : Form, ICategoria, IAccionesMantenimiento
    {
        public PresentadorCategoria Presentador { get; set; }
        private ConfiguracionControlesCategoria _ConfiguracionControlesCategoria;

        public frmCategoria()
        {
            InitializeComponent();
            Presentador = new PresentadorCategoria(this);
            _ConfiguracionControlesCategoria = new ConfiguracionControlesCategoria(this, Presentador);
            _ConfiguracionControlesCategoria.Configuracion();
        }

        public int ID_ProductoCategoria
        {
            get
            {
                var s = TID_ProductoCategoria?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;  
            }
            set
            {
                TID_ProductoCategoria.Text = value.ToString();
            }
        }

        public string Descripcion { get => TDescripcion.TextButton; set => TDescripcion.TextButton = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceCategoria
        {
            set => GRD.DataSource = value;
        }

        public string ConsultaDescripcion { get => TConsultaDescripcion.Text; set => TConsultaDescripcion.Text = value; }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesCategoria.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesCategoria.CargarDatosGRD();
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
                    _ConfiguracionControlesCategoria.CargarDatosGRD();
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
            ID_ProductoCategoria = 0;
            Descripcion = null;
            Activo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ConfiguracionControlesCategoria.CargarDatosGRD();
        }
        #endregion

        #region Cambios del size del form
        private void frmCategoria_Resize(object sender, EventArgs e)
        {
            pnDescripcion.Location = new System.Drawing.Point((int)(tblCentral.Width * 0.17), 31);
            pnDescripcion.Size = new System.Drawing.Size((int)(tblCentral.Width * 0.34), pnDescripcion.Height);
            pnEstado.Location = new System.Drawing.Point((int)(pnDescripcion.Location.X * 3.19), 31);

        }

        #endregion
    }
}
