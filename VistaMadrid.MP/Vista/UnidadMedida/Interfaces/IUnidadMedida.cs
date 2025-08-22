
namespace VistaMadrid.MP
{
    public interface IUnidadMedida
    {
        object GRD_DataSourceUnidadMedida { set; }

        int ID_UnidadMedida { get; set; }
        string Descripcion { get; set; }
        bool Activo { get; set; }

        string ConsultaDescripcion { get; set; }

        PresentadorUnidadMedida Presentador { get; set; }
    }
}
