using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.Vista.Mantenimientos.Rol;

namespace VistaMadrid 
{
    /// Configura frmRol: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesRol
    {
        private readonly frmRol _frmVista;
        private readonly PresentadorRol _Presentador;

        public ConfiguracionControlesRol(frmRol frm, PresentadorRol presenter)
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
            var item = row.DataBoundItem as Rol;
            if (item == null) return;

            // Cargar datos al formulario
            _frmVista.ID_Rol = item.ID_Rol;
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

            // ID_Rol (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Rol",
                HeaderText = "ID",
                DataPropertyName = "ID_Rol",
                Visible = false
            });

            // Descripcion (de Rol)
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
            // Carga de datos desde el presentador (List<Rol>)
            var data = _Presentador.CargarDatosGRD(desc);
            _frmVista.GRD_DataSourceRol = data;

            g.ResumeLayout();
        }

        public void CargarDatosGRD()
        {
            var g = _frmVista.GRD;

            var desc = _frmVista.ConsultaDescripcion;
            // Carga de datos desde el presentador (List<Rol>)
            var data = _Presentador.CargarDatosGRD(desc);
            _frmVista.GRD_DataSourceRol = data;

            g.ResumeLayout();
        }
    }
}
