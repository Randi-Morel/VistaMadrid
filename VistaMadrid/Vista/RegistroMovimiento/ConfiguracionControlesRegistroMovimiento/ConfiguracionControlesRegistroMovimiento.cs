using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
using VistaMadrid.Vista.RegistroMovimiento;

namespace VistaMadrid 
{
    /// Configura frmRegistroMovimiento: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesRegistroMovimiento
    {
        private readonly frmRegistroMovimiento _frmVista;
        private readonly PresentadorRegistroMovimiento _Presentador;

        public ConfiguracionControlesRegistroMovimiento(frmRegistroMovimiento frm, PresentadorRegistroMovimiento presenter)
        {
            _frmVista = frm ?? throw new ArgumentNullException(nameof(frm));
            _Presentador = presenter ?? throw new ArgumentNullException(nameof(presenter));
        }

        public void Configuracion()
        {
            AgregarEventos();
            CargarCombox();
            ConfiguracionGRD();
        }

        #region Eventos
        private void AgregarEventos()
        {
          
        }

        private void GRD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        public void CargarCombox()
        {
            var Producto = _Presentador.ObtenerTodosProducto().Where(s => s.Activo == true).ToList();
            _frmVista.CID_Producto.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_Producto.DisplayMember = "Nombre";
            _frmVista.CID_Producto.ValueMember = "ID_Producto";
            _frmVista.CID_Producto.DataSource = Producto;

            _frmVista.CID_Producto.SelectedIndex = -1;

            var MovimientoTipo = _Presentador.ObtenerTodosMovimientoTipo().Where(s => s.Activo == true).ToList();
            _frmVista.CID_MovimientoTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_MovimientoTipo.DisplayMember = "Descripcion";
            _frmVista.CID_MovimientoTipo.ValueMember = "ID_MovimientoTipo";
            _frmVista.CID_MovimientoTipo.DataSource = MovimientoTipo;

        }

        public bool ComprobarParaGuardar(out string mensaje)
        {

            if (_frmVista.ID_MovimientoTipo <= 0)
            {
                mensaje = "Debe seleccionar un Cliente.";
                return false;
            }

            mensaje = null;
            return true;
        }

        private void ConfiguracionGRD()
        {
            var g = _frmVista.GRD;

            g.SuspendLayout();
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.EditMode = DataGridViewEditMode.EditProgrammatically;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.RowHeadersVisible = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            g.Columns.Clear();

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Producto",
                HeaderText = "ID_Producto",
                DataPropertyName = "ID_Producto",
                Visible = false
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 140
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Descripcion",
                DataPropertyName = "Descripcion",
                FillWeight = 140
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioVenta",
                HeaderText = "PrecioVenta",
                DataPropertyName = "PrecioVenta",
                FillWeight = 120
            });

            // NUEVA: Cantidad
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                FillWeight = 80
            });

            g.ResumeLayout();
        }
    }
}
