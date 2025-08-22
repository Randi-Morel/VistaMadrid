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

namespace VistaMadrid.Vista.Facturacion
{
    public partial class frmFacturacion : Form, IFacturacion, IAccionesMantenimiento
    {
        public PresentadorFacturacion Presentador { get; set; }
        private ConfiguracionControlesFacturacion _ConfiguracionControlesFacturacion;
        private BindingList<ItemFactura> _items = new BindingList<ItemFactura>();

        public frmFacturacion()
        {
            InitializeComponent();
            Presentador = new PresentadorFacturacion(this);
            _ConfiguracionControlesFacturacion = new ConfiguracionControlesFacturacion(this, Presentador);
            _ConfiguracionControlesFacturacion.Configuracion();

            GRD_DataSourceFacturacion = _items;
        }

        public int ID_Orden
        {
            get
            {
                var s = LID_Orden?.Text?.Trim();
                return int.TryParse(s, out var n) ? n : 0;
            }
            set
            {
                LID_Orden.Text = value.ToString();
            }
        }

        public int ID_Condicion { get ; set; }

        public int ID_Sala { get => CID_Sala.SelectedValue == null ? 0 : Convert.ToInt32(CID_Sala.SelectedValue); set => CID_Sala.SelectedValue = value; }

        public int ID_Mesa { get => CID_Mesa.SelectedValue == null ? 0 : Convert.ToInt32(CID_Mesa.SelectedValue); set => CID_Mesa.SelectedValue = value; }

        public int ID_Cliente { get => CID_Cliente.SelectedValue == null ? 0 : Convert.ToInt32(CID_Cliente.SelectedValue); set => CID_Cliente.SelectedValue = value; }

        public int ID_Producto { get => CID_Producto.SelectedValue == null ? 0 : Convert.ToInt32(CID_Producto.SelectedValue); set => CID_Producto.SelectedValue = value; }

        public int Cantidad { get => Decimal.ToInt32(NUMCantidad.Value); set => NUMCantidad.Value = value; }

        public decimal Total
        {
            get => ParseDecimalOrZero(LTotal.Text);
            set => LTotal.Text = value.ToString("0.##", CultureInfo.CurrentCulture);
        }

        public decimal SaldoPendiente
        {
            get => ParseDecimalOrZero(LTotal.Text);
            set => LTotal.Text = value.ToString("0.##", CultureInfo.CurrentCulture);
        }

        public object GRD_DataSourceFacturacion
        {
            set => GRD.DataSource = value;
        }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesFacturacion.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var items = (GRD.DataSource as IEnumerable<ItemFactura>) ?? Enumerable.Empty<ItemFactura>();
                bool ok = Presentador.Guardar(items);

                if (ok)
                {
                    Limpiar();
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
                //bool ok = Presentador.Eliminar();

                //if (ok)
                //{
                //    Limpiar();
                //    _ConfiguracionControlesFacturacion.CargarDatosGRD();
                //}

                //return ok;
                return false;
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
            //ID_Facturacion = 0;
            //ID_FacturacionCategoria = -1;
            //ID_UnidadMedida = -1;
            //Nombre = null;
            //Descripcion = null;
            //StockMinimo = 1;
            //PrecioCosto = 0m;
            //PrecioVenta = 0m;
            //Activo = true;
        }
        #endregion

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (ID_Producto <= 0 || Cantidad <= 0)
            {
                MessageBox.Show("Seleccione un producto y una cantidad mayor a 0.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var p = Presentador.ObtenerProducto(ID_Producto);
            if (p == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existente = _items.FirstOrDefault(i => i.ID_Producto == p.ID_Producto);
            if (existente != null)
            {
                existente.Cantidad += Cantidad;
                var idx = _items.IndexOf(existente);
                _items.ResetItem(idx);
            }
            else
            {
                _items.Add(new ItemFactura
                {
                    ID_Producto = p.ID_Producto,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    PrecioVenta = p.PrecioVenta,
                    Cantidad = Cantidad
                });
            }

            RecalcularTotal();
        }

        private void RecalcularTotal()
        {
            var total = _items.Sum(i => i.PrecioVenta * i.Cantidad);
            Total = total;
            LSubtotal.Text = total.ToString("0.##", CultureInfo.CurrentCulture);
            SaldoPendiente = total;
        }

        private void btnProcesarOrden_Click(object sender, EventArgs e)
        {
            //_ConfiguracionControlesMesa.CargarDatosGRD();
        }

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
    }
}
