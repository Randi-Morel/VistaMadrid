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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VistaMadrid.Vista.Mantenimientos.Sala
{
    public partial class frmSala : Form, ISala, IAccionesMantenimiento
    {
        public PresentadorSala Presentador { get; set; }
        private ConfiguracionControlesSala _ConfiguracionControlesSala;

        public frmSala()
        {
            InitializeComponent();
            Presentador = new PresentadorSala(this);
            _ConfiguracionControlesSala = new ConfiguracionControlesSala(this, Presentador);
            _ConfiguracionControlesSala.Configuracion();
        }

        public int ID_Sala
        {
            get
            {
                var s = TID_Sala?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_Sala.Text = value.ToString();
            }
        }

        public string Descripcion { get => TDescripcion.TextButton; set => TDescripcion.TextButton = value; }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceSala
        {
            set => GRD.DataSource = value;
        }

        public string ConsultaDescripcion { get => TConsultaDescripcion.Text; set => TConsultaDescripcion.Text = value; }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesSala.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesSala.CargarDatosGRD();
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
                    _ConfiguracionControlesSala.CargarDatosGRD();
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
            ID_Sala = 0;
            Descripcion = null;
            Activo = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _ConfiguracionControlesSala.CargarDatosGRD();
        }
        #endregion
    }
}
