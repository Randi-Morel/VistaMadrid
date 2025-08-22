
namespace VistaMadrid.MP
{
    public interface IRol
    {
        object GRD_DataSourceRol { set; }

        int ID_Rol { get; set; }
        string Descripcion { get; set; }
        bool Activo { get; set; }

        PresentadorRol Presentador { get; set; }
    }
}
