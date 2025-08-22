
namespace VistaMadrid.MP
{
    public interface IRegistroPagos
    {
        object GRD_DataSourceRegistroPagos { set; }

        int ID_Pago { get; set; }
        int ID_Orden { get; set; }
        int ID_MetodoPago { get; set; }
        decimal MontoTotal { get; set; }

        PresentadorRegistroPagos Presentador { get; set; }
    }
}
