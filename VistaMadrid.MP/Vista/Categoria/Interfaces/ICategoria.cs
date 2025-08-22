
namespace VistaMadrid.MP
{
    public interface ICategoria
    {
        object GRD_DataSourceCategoria { set; }

        int ID_ProductoCategoria { get; set; }
        string Descripcion { get; set; }
        bool Activo { get; set; }

        string ConsultaDescripcion { get; set; }

        PresentadorCategoria Presentador { get; set; }
    }
}
