using System;
using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorTipoMovimiento
    {
        private readonly ITipoMovimiento _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloMovimientoTipo _modeloTipoMovimiento;

        public PresentadorTipoMovimiento(ITipoMovimiento view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloTipoMovimiento = new ModeloMovimientoTipo();
        }

        public List<MovimientoTipo> CargarDatosGRD(string descripcion)
        {
            var lista = _modeloTipoMovimiento.ObtenerTodos();

            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                var q = descripcion.Trim();
                lista = lista.Where(s => (s.Descripcion ?? "")
                    .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            return lista;
        }

        public List<MovimientoTipo> ObtenerTodosTipoMovimiento()
        {
            var TipoMovimiento = _modeloTipoMovimiento.ObtenerTodos();
            return TipoMovimiento;
        }

        //public List<C_TipoMovimiento> ObtenerTodosC_TipoMovimiento()
        //{
        //    return _vistasRepository.DbContext.C_TipoMovimiento.ToList();
        //}

        public bool Guardar()
        {
            var registro = new MovimientoTipo
            {
                ID_MovimientoTipo = _view.ID_MovimientoTipo,                       
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                Activo = _view.Activo
            };
            var ok = _modeloTipoMovimiento.Guardar(registro);
            _view.ID_MovimientoTipo = registro.ID_MovimientoTipo;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_MovimientoTipo > 0)
            {
                return _modeloTipoMovimiento.EliminarPorID(_view.ID_MovimientoTipo);
            }
            return false;
        }
    }
}
