using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorMetodoPago
    {
        private readonly IMetodoPago _view;
        private readonly ModeloMetodoPago _modeloMetodoPago;

        public PresentadorMetodoPago(IMetodoPago view)
        {
            _view = view;
            _modeloMetodoPago = new ModeloMetodoPago();
        }

        public List<MetodoPago> ObtenerTodosMetodoPago()
        {
            var MetodoPago = _modeloMetodoPago.ObtenerTodos();
            return MetodoPago;
        }

        public bool Guardar()
        {
            var registro = new MetodoPago
            {
                ID_MetodoPago = _view.ID_MetodoPago,                       
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                Activo = _view.Activo
            };
            var ok = _modeloMetodoPago.Guardar(registro);
            _view.ID_MetodoPago = registro.ID_MetodoPago;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_MetodoPago > 0)
            {
                return _modeloMetodoPago.EliminarPorID(_view.ID_MetodoPago);
            }
            return false;
        }
    }
}
