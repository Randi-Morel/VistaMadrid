using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorProducto
    {
        private readonly IProducto _view;

        public PresentadorProducto(IProducto view)
        {
            _view = view;
        }

    }
}
