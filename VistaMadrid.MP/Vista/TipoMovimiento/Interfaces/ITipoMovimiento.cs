
namespace VistaMadrid.MP
{
    public interface ITipoMovimiento
    {
        object GRD_DataSourceTipoMovimiento { set; }

        int ID_MovimientoTipo { get; set; }
        string Descripcion { get; set; }
        bool AfectaStock { get; set; }
        bool Activo { get; set; }

        string ConsultaDescripcion { get; set; }

        PresentadorTipoMovimiento Presentador { get; set; }
    }
}
