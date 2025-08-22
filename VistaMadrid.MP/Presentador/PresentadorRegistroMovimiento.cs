using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Entidades;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorRegistroMovimiento
    {
        private readonly IRegistroMovimiento _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloMovimientoInventario _modeloMovimientoInventario;
        private readonly ModeloProducto _modeloProducto;
        private readonly ModeloMovimientoTipo _modeloMovimientoTipo;
        private readonly ModeloMovimientoProducto _modeloMovimientoProducto;

        public PresentadorRegistroMovimiento(IRegistroMovimiento view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloMovimientoInventario = new ModeloMovimientoInventario();
            _modeloProducto = new ModeloProducto();
            _modeloMovimientoTipo = new ModeloMovimientoTipo();
            _modeloMovimientoProducto = new ModeloMovimientoProducto();
        }

        public List<C_Orden> ObtenerTodosC_Orden()
        {
            return _vistasRepository.DbContext.C_Orden.ToList();
        }

        public Producto ObtenerProducto(int idProducto)
        {
            return _modeloProducto.ObtenerPorID(idProducto);
        }

        public List<Producto> ObtenerTodosProducto()
        {
            var Producto = _modeloProducto.ObtenerTodos();
            return Producto;
        }

        public List<MovimientoTipo> ObtenerTodosMovimientoTipo()
        {
            return _modeloMovimientoTipo.ObtenerTodos();
        }

        public bool Guardar(IEnumerable<ItemFactura> items)
        {
            var registro = new MovimientoInventario
            {
                ID_MovimientoInventario = _view.ID_MovimientoInventario,
                ID_MovimientoTipo = _view.ID_MovimientoTipo,
                ID_Proveedor = null,
                Fecha = DateTime.Now,
                Cantidad = _view.Cantidad,
                Observaciones = _view.Observaciones,
                Activo = true
            };
            var ok = _modeloMovimientoInventario.Guardar(registro);
            if (!ok) return false;

            var detalles = (items ?? Enumerable.Empty<ItemFactura>())
            .GroupBy(i => i.ID_Producto)
            .Select(g =>
            {
                var prod = ObtenerProducto(g.Key);
                return new MovimientoProducto
                {
                    ID_MovimientoInventario = registro.ID_MovimientoInventario,
                    ID_Producto = g.Key,
                };
            })
            .ToList();

            if (detalles.Count == 0)
            {
                _view.ID_MovimientoInventario = registro.ID_MovimientoInventario;
                return true;
            }

            var modeloDetalle = new ModeloMovimientoProducto();
            ok = modeloDetalle.GuardarRango(detalles);

            _view.ID_MovimientoInventario = registro.ID_MovimientoInventario;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_MovimientoInventario > 0)
            {
                return _modeloMovimientoInventario.EliminarPorID(_view.ID_MovimientoInventario);
            }
            return false;
        }
    }
}
