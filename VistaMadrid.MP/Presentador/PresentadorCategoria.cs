using System;
using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
namespace VistaMadrid.MP

{
    public class PresentadorCategoria
    {
        private readonly ICategoria _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloProductoCategoria _modeloCategoria;

        public PresentadorCategoria(ICategoria view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloCategoria = new ModeloProductoCategoria();
        }

        public List<ProductoCategoria> CargarDatosGRD(string descripcion)
        {
            var lista = _modeloCategoria.ObtenerTodos();

            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                var q = descripcion.Trim();
                lista = lista.Where(s => (s.Descripcion ?? "")
                    .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            return lista;
        }

        public List<ProductoCategoria> ObtenerTodosProductoCategoria()
        {
            var categoria = _modeloCategoria.ObtenerTodos();
            return categoria;
        }

        //public List<C_Categoria> ObtenerTodosC_Categoria()
        //{
        //    return _vistasRepository.DbContext.C_Categoria.ToList();
        //}

        public bool Guardar()
        {
            var registro = new ProductoCategoria
            {
                ID_ProductoCategoria = _view.ID_ProductoCategoria,                       
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                Activo = _view.Activo
            };
            var ok = _modeloCategoria.Guardar(registro);
            _view.ID_ProductoCategoria = registro.ID_ProductoCategoria;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_ProductoCategoria > 0)
            {
                return _modeloCategoria.EliminarPorID(_view.ID_ProductoCategoria);
            }
            return false;
        }
    }
}
