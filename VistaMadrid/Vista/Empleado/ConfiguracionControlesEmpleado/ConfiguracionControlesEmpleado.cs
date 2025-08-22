using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
using VistaMadrid.Vista.Mantenimientos.Empleado;

namespace VistaMadrid 
{
    /// Configura frmEmpleado: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesEmpleado
    {
        private readonly frmEmpleado _frmVista;
        private readonly PresentadorEmpleado _Presentador;

        public ConfiguracionControlesEmpleado(frmEmpleado frm, PresentadorEmpleado presenter)
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
            var item = row.DataBoundItem as C_Usuario;
            if (item == null) return;

            // Cargar datos al formulario
            _frmVista.ID_Usuario = item.ID_Usuario;
            _frmVista.ID_Rol = item.ID_Rol;
            _frmVista.Usuario = item.Usuario;
            _frmVista.Contrasena = item.Contrasena;
            _frmVista.Nombre = item.Nombre;
            _frmVista.Apellidos = item.Apellidos;
            _frmVista.Activo = item.Activo;
        }
        #endregion

        public void CargarCombox()
        {
            var salas = _Presentador.ObtenerTodosCondicion().Where(s => s.Activo == true).ToList();
            _frmVista.CID_Rol.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_Rol.DisplayMember = "Descripcion";
            _frmVista.CID_Rol.ValueMember = "ID_Rol";
            _frmVista.CID_Rol.DataSource = salas;

            // (Opcional) Dejar sin selección inicial o respetar la que tenga la vista
            _frmVista.CID_Rol.SelectedIndex = -1;
        }

        public bool ComprobarParaGuardar(out string mensaje)
        {
            string nombre = _frmVista.Nombre?.Trim();
            string Usuario = _frmVista.Usuario?.Trim();
            string Contrasena = _frmVista.Contrasena?.Trim();
            string Apellidos = _frmVista.Apellidos?.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Usuario))
            {
                mensaje = "El usuario es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Contrasena))
            {
                mensaje = "La Contraseña es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Apellidos))
            {
                mensaje = "El o los apellidos es obligatorio.";
                return false;
            }

            if (_frmVista.ID_Rol <= 0)
            {
                mensaje = "Debe seleccionar un rol.";
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

            // ID_Empleado (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Usuario",
                HeaderText = "ID_Empleado",
                DataPropertyName = "ID_Usuario",
                Visible = false
            });

            // ID_Rol (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Rol",
                HeaderText = "ID_Rol",
                DataPropertyName = "ID_Rol",
                Visible = false
            });

            // Usuario (de Empleado)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsuario",
                HeaderText = "Usuario",
                DataPropertyName = "Usuario",
                FillWeight = 140
            });

            // Contrasena (de Empleado)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colContrasena",
                HeaderText = "Contrasena",
                DataPropertyName = "Contrasena",
                FillWeight = 140
            });

            // Nombre (de Empleado)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 140
            });

            // Apellidos (de Empleado)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colApellidos",
                HeaderText = "Apellidos",
                DataPropertyName = "Apellidos",
                FillWeight = 140
            });

            // Rol (de Empleado)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRol",
                HeaderText = "Rol",
                DataPropertyName = "Rol",
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

            var nom = _frmVista.ConsultaNombre;
            var usu = _frmVista.ConsultaUsuario;

            // Carga de datos desde el presentador (List<C_Usuario>>)
            var data = _Presentador.CargarDatosGRD(nom, usu);
            _frmVista.GRD_DataSourceUsuario = data;

            g.ResumeLayout();
        }

        public void CargarDatosGRD()
        {
            var g = _frmVista.GRD;
            var nom = _frmVista.ConsultaNombre;
            var usu = _frmVista.ConsultaUsuario;

            // Carga de datos desde el presentador (List<C_Usuario>>)
            var data = _Presentador.CargarDatosGRD(nom, usu);
            _frmVista.GRD_DataSourceUsuario = data;

            g.ResumeLayout();
        }
    }
}
