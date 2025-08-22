
namespace VistaMadrid.MP
{
    public interface IFacturacion
    {
        object GRD_DataSourceFacturacion { set; }

        int ID_Orden { get; set; }
        int ID_Cliente { get; set; }
        int ID_Mesa { get; set; }
        int ID_Sala { get; set; }
        int ID_Condicion { get; set; }
        int ID_Producto { get; set; }
        int Cantidad { get; set; }
        decimal Total { get; set; }
        decimal SaldoPendiente { get; set; }

        PresentadorFacturacion Presentador { get; set; }
    }
}
