
namespace VistaMadrid.MP
{
    public interface IAccionesMantenimiento
    {
        bool Guardar();   // true si guardó OK (tras validar)
        bool Eliminar();  // true si eliminó OK
        void Limpiar();   // limpia los controles
    }
}
