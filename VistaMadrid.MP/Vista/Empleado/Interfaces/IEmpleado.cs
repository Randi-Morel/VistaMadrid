
namespace VistaMadrid.MP
{
    public interface IEmpleado
    {
        object GRD_DataSourceUsuario { set; }

        int ID_Usuario { get; set; }
        int ID_Rol { get; set; }
        string Usuario { get; set; }
        string Contrasena { get; set; }
        string Nombre { get; set; }
        string Apellidos { get; set; }
        bool Activo { get; set; }

        string ConsultaNombre { get; set; }
        string ConsultaUsuario { get; set; }

        PresentadorEmpleado Presentador { get; set; }
    }
}
