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
using VistaMadrid.Vista.StockActual;

namespace VistaMadrid 
{
    /// Configura frmStockActual: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesStockActual
    {
        private readonly frmStockActual _frmVista;
        private readonly PresentadorStockActual _Presentador;

        public ConfiguracionControlesStockActual(frmStockActual frm, PresentadorStockActual presenter)
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
        }
        #endregion

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

            // ID_StockActual (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Producto",
                HeaderText = "ID_Producto",
                DataPropertyName = "ID_Producto",
                Visible = false
            });

            // Nombre (de StockActual)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 140
            });

            // Descripcion (de StockActual)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Descripcion",
                DataPropertyName = "Descripcion",
                FillWeight = 140
            });

            // StockActual (de StockActual)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStockActual",
                HeaderText = "StockActual",
                DataPropertyName = "StockActual",
                FillWeight = 140
            });

            // Categoria (de StockActual)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoria",
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                FillWeight = 140
            });

            // UnidadMedida (de StockActual)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnidadMedida",
                HeaderText = "Unidad de Medida",
                DataPropertyName = "UnidadMedida",
                FillWeight = 140
            });

            // Carga de datos desde el presentador (List<StockActual>)
            var data = _Presentador.ObtenerTodosC_Producto();
            _frmVista.GRD_DataSourceStockActual = data;

            g.ResumeLayout();
        }
    }
}
