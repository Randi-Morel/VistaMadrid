using System;
using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorEmpleado
    {
        private readonly IEmpleado _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloUsuario _modeloUsuario;
        private readonly ModeloCondicion _modeloCondicion;

        public PresentadorEmpleado(IEmpleado view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloUsuario = new ModeloUsuario();
            _modeloCondicion = new ModeloCondicion();
        }

        public List<C_Usuario> CargarDatosGRD(string nom, string usu)
        {
            var lista = _vistasRepository.DbContext.C_Usuario.ToList();

            if (!string.IsNullOrWhiteSpace(nom))
            {
                var q = nom.Trim();
                lista = lista.Where(s => (s.Nombre ?? "")
                    .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            if (!string.IsNullOrWhiteSpace(usu))
            {
                var q = usu.Trim();
                lista = lista.Where(s => (s.Usuario ?? "")
                    .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            return lista;
        }

        public List<Condicion> ObtenerTodosCondicion()
        {
            var Condicion = _modeloCondicion.ObtenerTodos();
            return Condicion;
        }

        public List<C_Usuario> ObtenerTodosC_Usuario()
        {
            return _vistasRepository.DbContext.C_Usuario.ToList();
        }

        public bool Guardar()
        {
            var registro = new Usuario
            {
                ID_Usuario = _view.ID_Usuario,
                ID_Rol = _view.ID_Rol,
                FechaCreacion = System.DateTime.Now.Date,
                Usuario1 = (_view.Usuario ?? string.Empty).Trim(),
                Contrasena = (_view.Contrasena ?? string.Empty).Trim(),
                Nombre = (_view.Nombre ?? string.Empty).Trim(),
                Apellidos = (_view.Apellidos ?? string.Empty).Trim(),
                Activo = _view.Activo
            };
            var ok = _modeloUsuario.Guardar(registro);
            _view.ID_Usuario = registro.ID_Usuario;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Usuario > 0)
            {
                return _modeloUsuario.EliminarPorID(_view.ID_Usuario);
            }
            return false;
        }
    }
}
