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
using VistaMadrid.MP.EF.Vistas;

namespace VistaMadrid.Vista.RegistroPagos
{
    public partial class frmRegistroPagos : Form, IRegistroPagos
    {
        public PresentadorRegistroPagos Presentador { get; set; }
        private ConfiguracionControlesRegistroPagos _ConfiguracionControlesRegistroPagos;
        private BindingList<ItemOrdenPago> _items = new BindingList<ItemOrdenPago>();

        public frmRegistroPagos()
        {
            InitializeComponent();

            Presentador = new PresentadorRegistroPagos(this);
            _ConfiguracionControlesRegistroPagos = new ConfiguracionControlesRegistroPagos(this, Presentador);
            _ConfiguracionControlesRegistroPagos.Configuracion();

            GRD_DataSourceRegistroPagos = _items;
        }


        public int ID_Pago { get; set; }

        public int ID_MetodoPago { get => CID_MetodoPago.SelectedValue == null ? 0 : Convert.ToInt32(CID_MetodoPago.SelectedValue); set => CID_MetodoPago.SelectedValue = value; }

        public int ID_Orden { get => CID_Orden.SelectedValue == null ? 0 : Convert.ToInt32(CID_Orden.SelectedValue); set => CID_Orden.SelectedValue = value; }

        public decimal MontoTotal
        {
            get => decimal.TryParse(TMontoTotal.Text, out var v) ? v : 0m;
            set => TMontoTotal.Text = value.ToString("0.##");
        }

        public object GRD_DataSourceRegistroPagos
        {
            set => GRD.DataSource = value;
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            if (ID_Orden <= 0)
            {
                MessageBox.Show("Seleccione una orden.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var o = Presentador.ObtenerC_Orden(ID_Orden);
            if (o == null)
            {
                MessageBox.Show("Orden no encontrada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existente = _items.FirstOrDefault(i => i.ID_Orden == o.ID_Orden);
            if (existente != null)
            {
                MessageBox.Show("La orden ya fue agregada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _items.Add(new ItemOrdenPago
            {
                ID_Orden = o.ID_Orden,
                Cliente = o.Nombre,             
                Mesa = o.Mesa,                  
                Condicion = o.Condicion,        
                Total = o.Total,                
                SaldoPendiente = o.SaldoPendiente, 
                MontoAPagar = o.SaldoPendiente ?? 0m 
            });

            RecalcularMontoTotal();
        }

        private void RecalcularMontoTotal()
        {
            var total = _items.Sum(i => i.MontoAPagar);
            MontoTotal = total;
            LTotal.Text = total.ToString();
            LSubtotal.Text = total.ToString();
        }

        private void btnProcesarMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_ConfiguracionControlesRegistroPagos.ComprobarParaGuardar(out var msg))
                {
                    MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                var items = (GRD.DataSource as IEnumerable<ItemOrdenPago>) ?? Enumerable.Empty<ItemOrdenPago>();
                Presentador.Guardar(items);

                MessageBox.Show("Se ha procesado el paso de forma exitosa", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
