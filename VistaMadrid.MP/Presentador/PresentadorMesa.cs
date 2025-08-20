using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorMesa
    {
        private readonly IMesa _view;
        private readonly ModeloUsuario _modelo;

        public PresentadorMesa(IMesa view)
        {
            _view = view;
            _modelo = new ModeloUsuario();
        }

        public Usuario Autenticar()
        {
            //var usuario = (_view.Usuario ?? "").Trim();
            //var password = (_view.Password ?? "").Trim();

            //var usr = _modelo.ObtenerPorCredenciales(usuario, password);
            return null;
        }
    }
}
