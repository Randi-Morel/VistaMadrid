
namespace VistaMadrid.MP
{
    public interface IProveedor
    {
        object GRD_DataSourceProveedor { set; }

        int ID_Proveedor { get; set; }
        string Nombre { get; set; }
        string Telefono { get; set; }
        string Email { get; set; }
        string Direccion { get; set; }
        bool Activo { get; set; }

        PresentadorProveedor Presentador { get; set; }
    }
}
