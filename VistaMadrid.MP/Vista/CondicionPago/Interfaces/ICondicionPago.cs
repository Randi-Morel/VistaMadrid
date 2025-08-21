
namespace VistaMadrid.MP
{
    public interface ICondicionPago
    {
        object GRD_DataSourceCondicionPago { set; }

        int ID_Condicion { get; set; }
        string Descripcion { get; set; }
        bool AutoPago { get; set; }
        int DiasCredito { get; set; }
        bool Activo { get; set; }

        PresentadorCondicionPago Presentador { get; set; }
    }
}
