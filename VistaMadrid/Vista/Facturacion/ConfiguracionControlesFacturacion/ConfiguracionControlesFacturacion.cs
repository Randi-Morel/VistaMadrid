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
using VistaMadrid.Vista.Facturacion;

namespace VistaMadrid 
{
    /// Configura frmFacturacion: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesFacturacion
    {
        private readonly frmFacturacion _frmVista;
        private readonly PresentadorFacturacion _Presentador;

        public ConfiguracionControlesFacturacion(frmFacturacion frm, PresentadorFacturacion presenter)
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

            // (Opcional) Dejar sin selección inicial o respetar la que tenga la vista
            _frmVista.CID_Producto.SelectedIndex = -1;

            var Sala = _Presentador.ObtenerTodosSala().Where(s => s.Activo == true).ToList();
            _frmVista.CID_Sala.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_Sala.DisplayMember = "Descripcion";
            _frmVista.CID_Sala.ValueMember = "ID_Sala";
            _frmVista.CID_Sala.DataSource = Sala;

            var Mesa = _Presentador.ObtenerTodosMesa().Where(s => s.Activo == true).ToList();
            _frmVista.CID_Mesa.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_Mesa.DisplayMember = "Descripcion";
            _frmVista.CID_Mesa.ValueMember = "ID_Mesa";
            _frmVista.CID_Mesa.DataSource = Mesa;

            var Cliente = _Presentador.ObtenerTodosCliente().Where(s => s.Activo == true).ToList();
            _frmVista.CID_Cliente.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_Cliente.DisplayMember = "Nombre";
            _frmVista.CID_Cliente.ValueMember = "ID_Cliente";
            _frmVista.CID_Cliente.DataSource = Cliente;

        }

        public bool ComprobarParaGuardar(out string mensaje)
        {

            if (_frmVista.ID_Cliente <= 0)
            {
                mensaje = "Debe seleccionar un Cliente.";
                return false;
            }

            if (_frmVista.ID_Mesa <= 0)
            {
                mensaje = "Debe seleccionar una Mesa.";
                return false;
            }

            if (_frmVista.ID_Sala <= 0)
            {
                mensaje = "Debe seleccionar una Sala.";
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

        public void CargarDatosGRD()
        {
          
        }
    }
}
