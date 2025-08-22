using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorRol
    {
        private readonly IRol _view;
        private readonly ModeloRol _modeloRol;

        public PresentadorRol(IRol view)
        {
            _view = view;
            _modeloRol = new ModeloRol();
        }

        public List<Rol> ObtenerTodosRol()
        {
            var Rol = _modeloRol.ObtenerTodos();
            return Rol;
        }

        public bool Guardar()
        {
            var registro = new Rol
            {
                ID_Rol = _view.ID_Rol,                       
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                Activo = _view.Activo
            };
            var ok = _modeloRol.Guardar(registro);
            _view.ID_Rol = registro.ID_Rol;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Rol > 0)
            {
                return _modeloRol.EliminarPorID(_view.ID_Rol);
            }
            return false;
        }
    }
}
