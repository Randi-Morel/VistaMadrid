
namespace VistaMadrid.MP
{
    public interface IRegistroMovimiento
    {
        object GRD_DataSourceRegistroMovimiento { set; }

        int ID_MovimientoInventario { get; set; }
        int ID_MovimientoTipo { get; set; }
        int ID_Producto { get; set; }
        int Cantidad { get; set; }
        string Observaciones { get; set; }

        PresentadorRegistroMovimiento Presentador { get; set; }
    }
}
