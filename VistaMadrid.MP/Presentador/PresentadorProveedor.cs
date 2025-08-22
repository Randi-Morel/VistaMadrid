using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorProveedor
    {
        private readonly IProveedor _view;
        private readonly ModeloProveedor _modeloProveedor;

        public PresentadorProveedor(IProveedor view)
        {
            _view = view;
            _modeloProveedor = new ModeloProveedor();
        }

        public List<Proveedor> ObtenerTodosProveedor()
        {
            var Proveedor = _modeloProveedor.ObtenerTodos();
            return Proveedor;
        }

        public bool Guardar()
        {
            var registro = new Proveedor
            {
                ID_Proveedor = _view.ID_Proveedor,
                Nombre = (_view.Nombre ?? string.Empty).Trim(),
                Telefono = _view.Telefono,
                Email = _view.Email,
                Direccion = (_view.Direccion ?? string.Empty).Trim(),
                Activo = _view.Activo
            };
            var ok = _modeloProveedor.Guardar(registro);
            _view.ID_Proveedor = registro.ID_Proveedor;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Proveedor > 0)
            {
                return _modeloProveedor.EliminarPorID(_view.ID_Proveedor);
            }
            return false;
        }
    }
}
