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

namespace VistaMadrid.Vista.RegistroMovimiento
{
    public partial class frmRegistroMovimiento : Form, IRegistroMovimiento, IAccionesMantenimiento
    {
        public PresentadorRegistroMovimiento Presentador { get; set; }
        private ConfiguracionControlesRegistroMovimiento _ConfiguracionControlesRegistroMovimiento;
        private BindingList<ItemFactura> _items = new BindingList<ItemFactura>();

        public frmRegistroMovimiento()
        {
            InitializeComponent();
            Presentador = new PresentadorRegistroMovimiento(this);
            _ConfiguracionControlesRegistroMovimiento = new ConfiguracionControlesRegistroMovimiento(this, Presentador);
            _ConfiguracionControlesRegistroMovimiento.Configuracion();

            GRD_DataSourceRegistroMovimiento = _items;
        }

        public int ID_MovimientoInventario { get; set; }


        public int ID_MovimientoTipo { get => CID_MovimientoTipo.SelectedValue == null ? 0 : Convert.ToInt32(CID_MovimientoTipo.SelectedValue); set => CID_MovimientoTipo.SelectedValue = value; }

        public int ID_Producto { get => CID_Producto.SelectedValue == null ? 0 : Convert.ToInt32(CID_Producto.SelectedValue); set => CID_Producto.SelectedValue = value; }

        public int Cantidad { get => Decimal.ToInt32(NUMCantidad.Value); set => NUMCantidad.Value = value; }

        public string Observaciones { get => TObservaciones.TextButton; set => TObservaciones.TextButton = value; }

        public object GRD_DataSourceRegistroMovimiento
        {
            set => GRD.DataSource = value;
        }

        #region "Eventos del Formulario"
        public bool Guardar()
        {
            try
            {
                if (!_ConfiguracionControlesRegistroMovimiento.ComprobarParaGuardar(out var msg))
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
                //    _ConfiguracionControlesRegistroMovimiento.CargarDatosGRD();
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
            //ID_RegistroMovimiento = 0;
            //ID_RegistroMovimientoCategoria = -1;
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
        }

        private void btnProcesarMovimiento_Click(object sender, EventArgs e)
        {
            
        }
    }
}
