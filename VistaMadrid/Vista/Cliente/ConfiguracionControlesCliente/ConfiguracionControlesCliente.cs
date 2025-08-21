using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
using VistaMadrid.Vista.Mantenimientos.Cliente;

namespace VistaMadrid 
{
    /// Configura frmCliente: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesCliente
    {
        private readonly frmCliente _frmVista;
        private readonly PresentadorCliente _Presentador;

        public ConfiguracionControlesCliente(frmCliente frm, PresentadorCliente presenter)
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
            // evita dobles suscripciones
            _frmVista.GRD.CellDoubleClick -= GRD_CellDoubleClick;
            _frmVista.GRD.CellDoubleClick += GRD_CellDoubleClick;
        }

        private void GRD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // cabecera

            var row = _frmVista.GRD.Rows[e.RowIndex];
            var item = row.DataBoundItem as C_Cliente;
            if (item == null) return;

            // Cargar datos al formulario
            _frmVista.ID_Cliente = item.ID_Cliente;
            _frmVista.Nombre = item.Nombre;
            _frmVista.Telefono = item.Telefono;
            _frmVista.Email = item.Email;
            _frmVista.Direccion = item.Direccion;
            _frmVista.ID_Condicion = item.ID_Condicion;
            _frmVista.Activo = item.Activo;
        }
        #endregion

        public void CargarCombox()
        {
            var salas = _Presentador.ObtenerTodosCondicion().Where(s => s.Activo == true).ToList();
            _frmVista.CID_Condicion.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_Condicion.DisplayMember = "Descripcion";
            _frmVista.CID_Condicion.ValueMember = "ID_Condicion";
            _frmVista.CID_Condicion.DataSource = salas;

            // (Opcional) Dejar sin selección inicial o respetar la que tenga la vista
            _frmVista.CID_Condicion.SelectedIndex = -1;
        }

        public bool ComprobarParaGuardar(out string mensaje)
        {
            string nombre = _frmVista.Nombre?.Trim();
            string telefono = _frmVista.Telefono?.Trim();
            string email = _frmVista.Email?.Trim();
            string direccion = _frmVista.Direccion?.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(telefono))
            {
                mensaje = "El teléfono es obligatorio.";
                return false;
            }
            if (!EsTelefonoValido(telefono))
            {
                mensaje = "El teléfono no es válido. Usa solo dígitos (8–15) y/o formato con +código de país.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                mensaje = "El email es obligatorio.";
                return false;
            }
            if (!EsEmailValido(email))
            {
                mensaje = "El email no tiene un formato válido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(direccion))
            {
                mensaje = "La dirección es obligatoria.";
                return false;
            }

            if (_frmVista.ID_Condicion <= 0)
            {
                mensaje = "Debe seleccionar una condicion.";
                return false;
            }

            mensaje = null;
            return true;
        }

        #region "Helpers"
        private static bool EsEmailValido(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email &&
                       Regex.IsMatch(addr.Host, @"^[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*\.[A-Za-z]{2,}$");
            }
            catch { return false; }
        }

        private static bool EsTelefonoValido(string phone)
        {
            var digits = Regex.Replace(phone, @"\D", "");
            if (digits.Length < 8 || digits.Length > 15) return false;

            return true; 
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

            // ID_Cliente (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Cliente",
                HeaderText = "ID_Cliente",
                DataPropertyName = "ID_Cliente",
                Visible = false
            });

            // ID_Condicion (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Condicion",
                HeaderText = "ID_Condicion",
                DataPropertyName = "ID_Condicion",
                Visible = false
            });

            // Nombre (de Cliente)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 140
            });

            // Telefono (de Cliente)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Telefono",
                DataPropertyName = "Telefono",
                FillWeight = 140
            });

            // Email (de Cliente)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEmail",
                HeaderText = "Email",
                DataPropertyName = "Email",
                FillWeight = 140
            });

            // Direccion (de Cliente)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDireccion",
                HeaderText = "Direccion",
                DataPropertyName = "Direccion",
                FillWeight = 140
            });

            // Condicion (de Cliente)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCondicion",
                HeaderText = "Condicion",
                DataPropertyName = "Condicion",
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

            // Carga de datos desde el presentador (List<Cliente>)
            var data = _Presentador.ObtenerTodosC_Cliente();
            _frmVista.GRD_DataSourceCliente = data;

            g.ResumeLayout();
        }

        public void CargarDatosGRD()
        {
            var g = _frmVista.GRD;

            // Carga de datos desde el presentador (List<Cliente>)
            var data = _Presentador.ObtenerTodosC_Cliente();
            _frmVista.GRD_DataSourceCliente = data;

            g.ResumeLayout();
        }
    }
}
