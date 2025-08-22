using System;
using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorMesa
    {
        private readonly IMesa _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloMesa _modeloMesa;
        private readonly ModeloSala _modeloSala;

        public PresentadorMesa(IMesa view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloMesa = new ModeloMesa();
            _modeloSala = new ModeloSala();
        }

        public List<C_Mesa> CargarDatosGRD(string descripcion, int? idSala)
        {
            var lista = _vistasRepository.DbContext.C_Mesa.ToList();

            if (idSala.HasValue && idSala.Value > 0)
                lista = lista.Where(s => s.ID_Sala == idSala.Value).ToList();

            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                var q = descripcion.Trim();
                lista = lista.Where(s => (s.Mesa ?? "")
                    .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            return lista;
        }

        public List<Sala> ObtenerTodosSala()
        {
            var sala = _modeloSala.ObtenerTodos();
            return sala;
        }

        public List<C_Mesa> ObtenerTodosC_Mesa()
        {
            return _vistasRepository.DbContext.C_Mesa.ToList();
        }

        public bool Guardar()
        {
            var registro = new Mesa
            {
                ID_Mesa = _view.ID_Mesa,                       
                ID_Sala = (_view.ID_Sala),                          
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                Asientos = _view.Asientos,
                Activo = _view.Activo
            };
            var ok = _modeloMesa.Guardar(registro);
            _view.ID_Mesa = registro.ID_Mesa;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Mesa > 0)
            {
                return _modeloMesa.EliminarPorID(_view.ID_Mesa);
            }
            return false;
        }
    }
}
