using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;

namespace VistaMadrid 
{
    /// Configura frmLogin: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesLogin
    {
        private readonly frmLogin _frmVista;

        public ConfiguracionControlesLogin(frmLogin frm, PresentadorLogin presenter)
        {
            _frmVista = frm ?? throw new ArgumentNullException(nameof(frm));
        }

        public void Configurar()
        {
            AgregarEventos();
        }

        #region Eventos
        private void AgregarEventos()
        {
            // Desuscribir por seguridad (evita duplicados)
            _frmVista.txtUsuario.KeyDown -= CambiarFoco_Enter;
            _frmVista.txtPassword.KeyDown -= CambiarFoco_Enter;

            // Suscribe
            _frmVista.txtUsuario.KeyDown += CambiarFoco_Enter;
            _frmVista.txtPassword.KeyDown += CambiarFoco_Enter;
        }

        private void CambiarFoco_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            if (ReferenceEquals(sender, _frmVista.txtPassword))
            {
                // Ejecuta la misma acción que el botón Entrar
                // (equivale a hacer click)
                _frmVista.btnEntrar.PerformClick();
                return;
            }

            // En cualquier otro control, navega el foco (Shift+Enter hacia atrás)
            bool adelante = !e.Shift;
            _frmVista.SelectNextControl((Control)sender, adelante, true, true, true);
        }

        #endregion
    }
}
