using System;
using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorCondicionPago
    {
        private readonly ICondicionPago _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloCondicion _modeloCondicionPago;

        public PresentadorCondicionPago(ICondicionPago view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloCondicionPago = new ModeloCondicion();
        }

        public List<Condicion> CargarDatosGRD(string descripcion)
        {
            var lista = _modeloCondicionPago.ObtenerTodos();

            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                var q = descripcion.Trim();
                lista = lista.Where(s => (s.Descripcion ?? "")
                    .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            return lista;
        }

        public List<Condicion> ObtenerTodosCondicion()
        {
            var Condicion = _modeloCondicionPago.ObtenerTodos();
            return Condicion;
        }

        //public List<C_CondicionPago> ObtenerTodosC_CondicionPago()
        //{
        //    return _vistasRepository.DbContext.C_CondicionPago.ToList();
        //}

        public bool Guardar()
        {
            var registro = new Condicion
            {
                ID_Condicion = _view.ID_Condicion,                       
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                AutoPago = _view.AutoPago,
                DiasCredito = _view.DiasCredito,
                Activo = _view.Activo
            };
            var ok = _modeloCondicionPago.Guardar(registro);
            _view.ID_Condicion = registro.ID_Condicion;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Condicion > 0)
            {
                return _modeloCondicionPago.EliminarPorID(_view.ID_Condicion);
            }
            return false;
        }
    }
}
