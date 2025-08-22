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
using VistaMadrid.Vista.CuentasVencidas;

namespace VistaMadrid 
{
    /// Configura frmCuentasVencidas: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesCuentasVencidas
    {
        private readonly frmCuentasVencidas _frmVista;
        private readonly PresentadorCuentasVencidas _Presentador;

        public ConfiguracionControlesCuentasVencidas(frmCuentasVencidas frm, PresentadorCuentasVencidas presenter)
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

            // ID_Orden (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Orden",
                HeaderText = "ID_Orden",
                DataPropertyName = "ID_Orden",
                Visible = false
            });

            // FechaAlta (de CuentasVencidas)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFechaAlta",
                HeaderText = "FechaAlta",
                DataPropertyName = "FechaAlta",
                FillWeight = 140
            });

            // FechaVencimiento (de CuentasVencidas)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFechaVencimiento",
                HeaderText = "FechaVencimiento",
                DataPropertyName = "FechaVencimiento",
                FillWeight = 140
            });

            // Nombre (de CuentasVencidas)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 140
            });

            // Mesa (de CuentasVencidas)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMesa",
                HeaderText = "Mesa",
                DataPropertyName = "Mesa",
                FillWeight = 140
            });

            // Total (de CuentasVencidas)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTotal",
                HeaderText = "Total",
                DataPropertyName = "Total",
                FillWeight = 140
            });

            // SaldoPendiente (de CuentasVencidas)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSaldoPendiente",
                HeaderText = "Saldo Pendiente",
                DataPropertyName = "SaldoPendiente",
                FillWeight = 140
            });

            // Carga de datos desde el presentador (List<C_Orden>)
            var data = _Presentador.ObtenerTodosC_Orden();
            _frmVista.GRD_DataSourceCuentasVencidas = data;

            g.ResumeLayout();
        }
    }
}
