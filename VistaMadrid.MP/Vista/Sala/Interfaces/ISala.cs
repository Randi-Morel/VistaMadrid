
namespace VistaMadrid.MP
{
    public interface ISala
    {
        object GRD_DataSourceSala { set; }

        int ID_Sala { get; set; }
        string Descripcion { get; set; }
        bool Activo { get; set; }

        PresentadorSala Presentador { get; set; }
    }
}
