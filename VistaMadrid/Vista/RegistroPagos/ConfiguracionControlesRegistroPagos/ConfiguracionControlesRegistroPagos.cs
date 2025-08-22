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
using VistaMadrid.Vista.RegistroPagos;

namespace VistaMadrid 
{
    /// Configura frmRegistroPagos: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesRegistroPagos
    {
        private readonly frmRegistroPagos _frmVista;
        private readonly PresentadorRegistroPagos _Presentador;

        public ConfiguracionControlesRegistroPagos(frmRegistroPagos frm, PresentadorRegistroPagos presenter)
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
            var Orden = _Presentador.ObtenerTodosC_Orden().Where(s => s.Activo == true).ToList();
            _frmVista.CID_Orden.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_Orden.DisplayMember = "ID_Orden";
            _frmVista.CID_Orden.ValueMember = "ID_Orden";
            _frmVista.CID_Orden.DataSource = Orden;

            _frmVista.CID_Orden.SelectedIndex = -1;

            var MetodoPago = _Presentador.ObtenerTodosMetodoPago().Where(s => s.Activo == true).ToList();
            _frmVista.CID_MetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_MetodoPago.DisplayMember = "Descripcion";
            _frmVista.CID_MetodoPago.ValueMember = "ID_MetodoPago";
            _frmVista.CID_MetodoPago.DataSource = MetodoPago;
        }

        public bool ComprobarParaGuardar(out string mensaje)
        {

            if (_frmVista.ID_MetodoPago <= 0)
            {
                mensaje = "Debe seleccionar un MetodoPago.";
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
                Name = "colID_Orden",
                HeaderText = "ID_Orden",
                DataPropertyName = "ID_Orden",
                Visible = false
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCliente",
                HeaderText = "Cliente",
                DataPropertyName = "Cliente",
                FillWeight = 140
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMesa",
                HeaderText = "Mesa",
                DataPropertyName = "Mesa",
                FillWeight = 100
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCondicion",
                HeaderText = "Condición",
                DataPropertyName = "Condicion",
                FillWeight = 120
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                HeaderText = "Total",
                DataPropertyName = "Total",
                FillWeight = 90
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSaldoPendiente",
                HeaderText = "Saldo Pendiente",
                DataPropertyName = "SaldoPendiente",
                FillWeight = 110
            });

            g.ResumeLayout();
        }
    }
}
