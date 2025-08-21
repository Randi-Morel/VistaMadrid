
namespace VistaMadrid.MP
{
    public interface IMesa
    {
        object GRD_DataSourceMesa { set; }

        int ID_Mesa { get; set; }
        int ID_Sala { get; set; }
        string Descripcion { get; set; }
        int Asientos { get; set; }
        bool Activo { get; set; }

        PresentadorMesa Presentador { get; set; }
    }
}
