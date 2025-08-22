
namespace VistaMadrid.MP
{
    public interface IProducto
    {
        object GRD_DataSourceProducto { set; }
        byte[] ArchivoContenido { get; set; }

        int ID_Producto { get; set; }
        int ID_ProductoCategoria { get; set; }
        int ID_UnidadMedida { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        //decimal StockActual { get; set; }
        decimal StockMinimo { get; set; }
        decimal PrecioCosto { get; set; }
        decimal PrecioVenta { get; set; }
        bool Activo { get; set; }

        PresentadorProducto Presentador { get; set; }
    }
}
