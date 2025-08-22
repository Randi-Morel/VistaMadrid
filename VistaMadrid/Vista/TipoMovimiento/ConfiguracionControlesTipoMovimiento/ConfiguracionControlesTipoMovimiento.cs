using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.Vista.Mantenimientos.TipoMovimiento;

namespace VistaMadrid 
{
    /// Configura frmTipoMovimiento: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesTipoMovimiento
    {
        private readonly frmTipoMovimiento _frmVista;
        private readonly PresentadorTipoMovimiento _Presentador;

        public ConfiguracionControlesTipoMovimiento(frmTipoMovimiento frm, PresentadorTipoMovimiento presenter)
        {
            _frmVista = frm ?? throw new ArgumentNullException(nameof(frm));
            _Presentador = presenter ?? throw new ArgumentNullException(nameof(presenter));
        }

        public void Configuracion()
        {
            AgregarEventos();
            ConfiguracionGRD();
        }

        #region Eventos
        private void AgregarEventos()
        {
            // evita dobles suscripciones
            _frmVista.GRD.CellDoubleClick -= GRD_CellDoubleClick;
            _frmVista.GRD.CellDoubleClick += GRD_CellDoubleClick;
        }

        private void GRD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // cabecera

            var row = _frmVista.GRD.Rows[e.RowIndex];
            var item = row.DataBoundItem as MovimientoTipo;
            if (item == null) return;

            // Cargar datos al formulario
            _frmVista.ID_MovimientoTipo = item.ID_MovimientoTipo;
            _frmVista.Descripcion = item.Descripcion;
            _frmVista.Activo = item.Activo;
        }
        #endregion

        public bool ComprobarParaGuardar(out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(_frmVista.Descripcion))
            {
                mensaje = "La descripción es obligatoria.";
                return false;
            }

            mensaje = null;
            return true;
        }

        private void ConfiguracionGRD()
        {
            var g = _frmVista.GRD; 

            // Config base
            g.SuspendLayout();
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.EditMode = DataGridViewEditMode.EditProgrammatically;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.RowHeadersVisible = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Columnas
            g.Columns.Clear();

            // ID_TipoMovimiento (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_MovimientoTipo",
                HeaderText = "ID",
                DataPropertyName = "ID_MovimientoTipo",
                Visible = false
            });

            // Descripcion (de TipoMovimiento)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Descripcion",
                DataPropertyName = "Descripcion",
                FillWeight = 140
            });

            // AfectaStock
            g.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colActivo",
                HeaderText = "AfectaStock",
                DataPropertyName = "AfectaStock",
                Width = 70
            });

            // Activo
            g.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colActivo",
                HeaderText = "Activo",
                DataPropertyName = "Activo",
                Width = 70
            });

            var desc = _frmVista.ConsultaDescripcion;
            // Carga de datos desde el presentador (List<TipoMovimiento>)
            var data = _Presentador.CargarDatosGRD(desc);
            _frmVista.GRD_DataSourceTipoMovimiento = data;

            g.ResumeLayout();
        }

        public void CargarDatosGRD()
        {
            var g = _frmVista.GRD;

            var desc = _frmVista.ConsultaDescripcion;
            // Carga de datos desde el presentador (List<TipoMovimiento>)
            var data = _Presentador.CargarDatosGRD(desc);
            _frmVista.GRD_DataSourceTipoMovimiento = data;

            g.ResumeLayout();
        }
    }
}
