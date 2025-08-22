using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.Vista.Mantenimientos.Sala;

namespace VistaMadrid 
{
    /// Configura frmSala: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesSala
    {
        private readonly frmSala _frmVista;
        private readonly PresentadorSala _Presentador;

        public ConfiguracionControlesSala(frmSala frm, PresentadorSala presenter)
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
            var item = row.DataBoundItem as Sala;
            if (item == null) return;

            // Cargar datos al formulario
            _frmVista.ID_Sala = item.ID_Sala;
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

            // ID_Sala (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Sala",
                HeaderText = "ID",
                DataPropertyName = "ID_Sala",
                Visible = false
            });

            // Descripcion (de Sala)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Descripcion",
                DataPropertyName = "Descripcion",
                FillWeight = 140
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
            // Carga de datos desde el presentador (List<Sala>)
            var data = _Presentador.CargarDatosGRD(desc);
            _frmVista.GRD_DataSourceSala = data;

            g.ResumeLayout();
        }

        public void CargarDatosGRD()
        {
            var g = _frmVista.GRD;
            var desc = _frmVista.ConsultaDescripcion;

            // Carga de datos desde el presentador (List<Sala>)
            var data = _Presentador.CargarDatosGRD(desc);
            _frmVista.GRD_DataSourceSala = data;

            g.ResumeLayout();
        }
    }
}
