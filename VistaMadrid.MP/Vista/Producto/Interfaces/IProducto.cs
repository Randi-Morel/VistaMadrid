
namespace VistaMadrid.MP
{
    public interface IProducto
    {
        string Usuario { get; set; }
        string Password { get; set; }

        PresentadorProducto Presentador { get; set; }
    }
}
