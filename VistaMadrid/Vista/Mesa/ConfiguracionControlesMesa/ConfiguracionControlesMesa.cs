using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.Vista.Mantenimientos.Mesa;

namespace VistaMadrid 
{
    /// Configura frmMesa: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesMesa
    {
        private readonly frmMesa _frmVista;
        private readonly PresentadorMesa _Presentador;

        public ConfiguracionControlesMesa(frmMesa frm, PresentadorMesa presenter)
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
            //// Desuscribir por seguridad (evita duplicados)
            //_frmVista.txtUsuario.KeyDown -= CambiarFoco_Enter;
            //_frmVista.txtPassword.KeyDown -= CambiarFoco_Enter;

            //// Suscribe
            //_frmVista.txtUsuario.KeyDown += CambiarFoco_Enter;
            //_frmVista.txtPassword.KeyDown += CambiarFoco_Enter;
        }

        private void CambiarFoco_Enter(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode != Keys.Enter) return;

            //e.Handled = true;
            //e.SuppressKeyPress = true;

            //if (ReferenceEquals(sender, _frmVista.txtPassword))
            //{
            //    // Ejecuta la misma acción que el botón Entrar
            //    // (equivale a hacer click)
            //    _frmVista.btnEntrar.PerformClick();
            //    return;
            //}

            //// En cualquier otro control, navega el foco (Shift+Enter hacia atrás)
            //bool adelante = !e.Shift;
            //_frmVista.SelectNextControl((Control)sender, adelante, true, true, true);
        }

        #endregion

        public void CargarCombox()
        {
            var salas = _Presentador.ObtenerTodosSala().Where(s => s.Activo == true).ToList();
            _frmVista.cbSala.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.cbSala.DisplayMember = "Descripcion";
            _frmVista.cbSala.ValueMember = "ID_Sala";
            _frmVista.cbSala.DataSource = salas;

            // (Opcional) Dejar sin selección inicial o respetar la que tenga la vista
            _frmVista.cbSala.SelectedIndex = -1;
        }

        public bool ComprobarParaGuardar(out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(_frmVista.Descripcion))
            {
                mensaje = "La descripción es obligatoria.";
                return false;
            }

            if (_frmVista.ID_Sala <= 0)
            {
                mensaje = "Debe seleccionar una sala.";
                return false;
            }

            if (_frmVista.Asientos <= 0)
            {
                mensaje = "La cantidad de asientos debe ser mayor que 0.";
                return false;
            }

            mensaje = null;
            return true;
        }

        public void ConfiguracionGRD()
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

            // ID_Mesa (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Mesa",
                HeaderText = "ID",
                DataPropertyName = "ID_Mesa",
                Visible = false
            });

            // ID_Sala (oculta; descomenta Visible=true si quieres verla)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Sala",
                HeaderText = "ID Sala",
                DataPropertyName = "ID_Sala",
                Visible = false // true si deseas mostrarla
            });

            // Sala (alias de Sala.Descripcion)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSala",
                HeaderText = "Sala",
                DataPropertyName = "Sala",
                FillWeight = 140
            });

            // Descripcion (de Mesa)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMesa",
                HeaderText = "Mesa",
                DataPropertyName = "Mesa",
                FillWeight = 140
            });

            // Asientos
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAsientos",
                HeaderText = "Asientos",
                DataPropertyName = "Asientos",
                Width = 90,
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

            // Carga de datos desde el presentador (List<C_Mesa>)
            var data = _Presentador.ObtenerTodosC_Mesa();   
            _frmVista.GRD_DataSourceMesa = data;           

            g.ResumeLayout();
        }
    }
}
