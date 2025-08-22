using System;
using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorSala
    {
        private readonly ISala _view;
        private readonly ModeloSala _modeloSala;

        public PresentadorSala(ISala view)
        {
            _view = view;
            _modeloSala = new ModeloSala();
        }

        public List<Sala> CargarDatosGRD(string descripcion)
        {
            var lista = _modeloSala.ObtenerTodos();

            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                var q = descripcion.Trim();
                lista = lista.Where(s => (s.Descripcion ?? "")
                    .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            return lista;
        }

        public List<Sala> ObtenerTodosSala()
        {
            var Sala = _modeloSala.ObtenerTodos();
            return Sala;
        }

        public bool Guardar()
        {
            var registro = new Sala
            {
                ID_Sala = _view.ID_Sala,                       
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                Activo = _view.Activo
            };
            var ok = _modeloSala.Guardar(registro);
            _view.ID_Sala = registro.ID_Sala;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Sala > 0)
            {
                return _modeloSala.EliminarPorID(_view.ID_Sala);
            }
            return false;
        }
    }
}
