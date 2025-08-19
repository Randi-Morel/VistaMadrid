
namespace VistaMadrid.MP
{
    public interface ILogin
    {
        string Usuario { get; set; }
        string Password { get; set; }

        PresentadorLogin Presentador { get; set; }
    }
}
