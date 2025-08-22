using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.Vista.Mantenimientos.CondicionPago;

namespace VistaMadrid 
{
    /// Configura frmCondicionPago: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesCondicionPago
    {
        private readonly frmCondicionPago _frmVista;
        private readonly PresentadorCondicionPago _Presentador;

        public ConfiguracionControlesCondicionPago(frmCondicionPago frm, PresentadorCondicionPago presenter)
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
            var item = row.DataBoundItem as Condicion;
            if (item == null) return;

            // Cargar datos al formulario
            _frmVista.ID_Condicion = item.ID_Condicion;
            _frmVista.Descripcion = item.Descripcion;
            _frmVista.AutoPago = item.AutoPago;
            _frmVista.DiasCredito = item.DiasCredito;
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

            if (_frmVista.DiasCredito <= 0)
            {
                mensaje = "La cantidad de Dias de Credito debe ser mayor que 0.";
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

            // ID_CondicionPago (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Condicion",
                HeaderText = "ID_Condicion",
                DataPropertyName = "ID_Condicion",
                Visible = false
            });

            // Descripcion (de CondicionPago)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Descripcion",
                DataPropertyName = "Descripcion",
                FillWeight = 140
            });

            // AutoPago
            g.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colAutoPago",
                HeaderText = "AutoPago",
                DataPropertyName = "AutoPago",
                Width = 70
            });

            // DiasCredito
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDiasCredito",
                HeaderText = "DiasCredito",
                DataPropertyName = "DiasCredito",
                Width = 70,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight }
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

            // Carga de datos desde el presentador (List<CondicionPago>)
            var data = _Presentador.CargarDatosGRD(desc);
            _frmVista.GRD_DataSourceCondicionPago = data;

            g.ResumeLayout();
        }

        public void CargarDatosGRD()
        {
            var g = _frmVista.GRD;
            var desc = _frmVista.ConsultaDescripcion;

            // Carga de datos desde el presentador (List<CondicionPago>)
            var data = _Presentador.CargarDatosGRD(desc);
            _frmVista.GRD_DataSourceCondicionPago = data;

            g.ResumeLayout();
        }
    }
}
