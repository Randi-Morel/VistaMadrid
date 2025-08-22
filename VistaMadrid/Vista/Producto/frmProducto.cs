using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VistaMadrid.Vista.Mantenimientos.Producto
{
    public partial class frmProducto : Form, IProducto, IAccionesMantenimiento
    {
        public PresentadorProducto Presentador { get; set; }
        private ConfiguracionControlesProducto _ConfiguracionControlesProducto;

        public frmProducto()
        {
            InitializeComponent();
            Presentador = new PresentadorProducto(this);
            _ConfiguracionControlesProducto = new ConfiguracionControlesProducto(this, Presentador);
            _ConfiguracionControlesProducto.Configuracion();
        }

        public int ID_Producto
        {
            get
            {
                var s = TID_Producto?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                TID_Producto.Text = value.ToString();
            }
        }

        public int ID_ProductoCategoria { get => CID_ProductoCategoria.SelectedValue == null ? 0 : Convert.ToInt32(CID_ProductoCategoria.SelectedValue); set => CID_ProductoCategoria.SelectedValue = value; }

        public int ID_UnidadMedida { get => CID_UnidadMedida.SelectedValue == null ? 0 : Convert.ToInt32(CID_UnidadMedida.SelectedValue); set => CID_UnidadMedida.SelectedValue = value; }

        public string Nombre { get => TNombre.Text; set => TNombre.Text = value; }

        public string Descripcion { get => TDescripcion.TextButton; set => TDescripcion.TextButton = value; }

        public decimal StockMinimo { get => NUMStockMinimo.Value; set => NUMStockMinimo.Value = value; }

        public decimal PrecioCosto
        {
            get => ParseDecimalOrZero(TPrecioCosto.Text);
            set => TPrecioCosto.Text = value.ToString("0.##", CultureInfo.CurrentCulture);
        }

        public decimal PrecioVenta
        {
            get => ParseDecimalOrZero(TPrecioVenta.Text);
            set => TPrecioVenta.Text = value.ToString("0.##", CultureInfo.CurrentCulture);
        }

        public bool Activo { get => CHKActivo.Checked; set => CHKActivo.Checked = value; }

        public object GRD_DataSourceProducto
        {
            set => GRD.DataSource = value;
        }

        public byte[] ArchivoContenido { get; set; }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesProducto.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool ok = Presentador.Guardar();

                if (ok)
                {
                    Limpiar();
                    _ConfiguracionControlesProducto.CargarDatosGRD();
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
                    _ConfiguracionControlesProducto.CargarDatosGRD();
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
            ID_Producto = 0;
            ID_ProductoCategoria = -1;
            ID_UnidadMedida = -1;
            Nombre = null;
            Descripcion = null;
            StockMinimo = 1;
            PrecioCosto = 0m;
            PrecioVenta = 0m;
            Activo = true;

            ArchivoContenido = null;
            Archivo.Image = null;
        }
        #endregion

        private static decimal ParseDecimalOrZero(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0m;

            if (decimal.TryParse(text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                                 CultureInfo.CurrentCulture, out var d))
                return d;

            if (decimal.TryParse(text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                                 CultureInfo.InvariantCulture, out d))
                return d;

            return 0m;
        }

        private void frmProducto_Resize(object sender, EventArgs e)
        {
            lblInfo.Location = new Point(tblInfoEmpleado.Location.X, lblInfo.Location.Y);
            lblAccesibilidad.Location = new Point(tblAccesibilidad.Location.X, lblAccesibilidad.Location.Y);
        }
    }
}
