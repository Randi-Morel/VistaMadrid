using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorLogin
    {
        private readonly ILogin _view;
        private readonly ModeloUsuario _modelo;

        public PresentadorLogin(ILogin view)
        {
            _view = view;
            _modelo = new ModeloUsuario();
        }

        public Usuario Autenticar()
        {
            var usuario = (_view.Usuario ?? "").Trim();
            var password = (_view.Password ?? "").Trim();

            var usr = _modelo.ObtenerPorCredenciales(usuario, password);
            return usr;
        }
    }
}
