
namespace VistaMadrid.MP
{
    public interface IMetodoPago
    {
        object GRD_DataSourceMetodoPago { set; }

        int ID_MetodoPago { get; set; }
        string Descripcion { get; set; }
        bool Activo { get; set; }

        PresentadorMetodoPago Presentador { get; set; }
    }
}
