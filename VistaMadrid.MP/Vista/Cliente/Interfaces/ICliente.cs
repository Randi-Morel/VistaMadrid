
namespace VistaMadrid.MP
{
    public interface ICliente
    {
        object GRD_DataSourceCliente { set; }

        int ID_Cliente { get; set; }
        string Nombre { get; set; }
        string Telefono { get; set; }
        string Email { get; set; }
        string Direccion { get; set; }
        int ID_Condicion { get; set; }
        bool Activo { get; set; }

        PresentadorCliente Presentador { get; set; }
    }
}
