using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
using VistaMadrid.Vista.Mantenimientos.Proveedor;

namespace VistaMadrid 
{
    /// Configura frmProveedor: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesProveedor
    {
        private readonly frmProveedor _frmVista;
        private readonly PresentadorProveedor _Presentador;

        public ConfiguracionControlesProveedor(frmProveedor frm, PresentadorProveedor presenter)
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
            var item = row.DataBoundItem as Proveedor;
            if (item == null) return;

            // Cargar datos al formulario
            _frmVista.ID_Proveedor = item.ID_Proveedor;
            _frmVista.Nombre = item.Nombre;
            _frmVista.Telefono = item.Telefono;
            _frmVista.Email = item.Email;
            _frmVista.Direccion = item.Direccion;
            _frmVista.Activo = item.Activo;
        }
        #endregion

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

            // ID_Proveedor (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Proveedor",
                HeaderText = "ID_Proveedor",
                DataPropertyName = "ID_Proveedor",
                Visible = false
            });

            // Nombre (de Proveedor)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 140
            });

            // Telefono (de Proveedor)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Telefono",
                DataPropertyName = "Telefono",
                FillWeight = 140
            });

            // Email (de Proveedor)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEmail",
                HeaderText = "Email",
                DataPropertyName = "Email",
                FillWeight = 140
            });

            // Direccion (de Proveedor)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDireccion",
                HeaderText = "Direccion",
                DataPropertyName = "Direccion",
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

            // Carga de datos desde el presentador (List<Proveedor>)
            var data = _Presentador.ObtenerTodosProveedor();
            _frmVista.GRD_DataSourceProveedor = data;

            g.ResumeLayout();
        }

        public void CargarDatosGRD()
        {
            var g = _frmVista.GRD;

            // Carga de datos desde el presentador (List<Proveedor>)
            var data = _Presentador.ObtenerTodosProveedor();
            _frmVista.GRD_DataSourceProveedor = data;

            g.ResumeLayout();
        }
    }
}
