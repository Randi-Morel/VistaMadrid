using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorUnidadMedida
    {
        private readonly IUnidadMedida _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloUnidadMedida _modeloUnidadMedida;

        public PresentadorUnidadMedida(IUnidadMedida view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloUnidadMedida = new ModeloUnidadMedida();
        }

        public List<UnidadMedida> ObtenerTodosUnidadMedida()
        {
            var UnidadMedida = _modeloUnidadMedida.ObtenerTodos();
            return UnidadMedida;
        }

        //public List<C_UnidadMedida> ObtenerTodosC_UnidadMedida()
        //{
        //    return _vistasRepository.DbContext.C_UnidadMedida.ToList();
        //}

        public bool Guardar()
        {
            var registro = new UnidadMedida
            {
                ID_UnidadMedida = _view.ID_UnidadMedida,                       
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                Activo = _view.Activo
            };
            var ok = _modeloUnidadMedida.Guardar(registro);
            _view.ID_UnidadMedida = registro.ID_UnidadMedida;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_UnidadMedida > 0)
            {
                return _modeloUnidadMedida.EliminarPorID(_view.ID_UnidadMedida);
            }
            return false;
        }
    }
}
