using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorCliente
    {
        private readonly ICliente _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloCliente _modeloCliente;
        private readonly ModeloCondicion _modeloCondicion;

        public PresentadorCliente(ICliente view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloCliente = new ModeloCliente();
            _modeloCondicion = new ModeloCondicion();
        }

        public List<Condicion> ObtenerTodosCondicion()
        {
            var Condicion = _modeloCondicion.ObtenerTodos();
            return Condicion;
        }

        public List<C_Cliente> ObtenerTodosC_Cliente()
        {
            return _vistasRepository.DbContext.C_Cliente.ToList();
        }

        public bool Guardar()
        {
            var registro = new Cliente
            {
                ID_Cliente = _view.ID_Cliente,
                Nombre = (_view.Nombre ?? string.Empty).Trim(),
                Telefono = _view.Telefono,
                Email = _view.Email,
                Direccion = (_view.Direccion ?? string.Empty).Trim(),
                ID_Condicion = _view.ID_Condicion,
                Activo = _view.Activo
            };
            var ok = _modeloCliente.Guardar(registro);
            _view.ID_Condicion = registro.ID_Condicion;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Cliente > 0)
            {
                return _modeloCliente.EliminarPorID(_view.ID_Cliente);
            }
            return false;
        }
    }
}
