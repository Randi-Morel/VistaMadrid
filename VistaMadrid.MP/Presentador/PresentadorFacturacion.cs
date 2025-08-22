using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorFacturacion
    {
        private readonly IFacturacion _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloOrden _modeloOrden;
        private readonly ModeloProducto _modeloProducto;
        private readonly ModeloSala _modeloSala;
        private readonly ModeloMesa _modeloMesa;
        private readonly ModeloCliente _modeloCliente;

        public PresentadorFacturacion(IFacturacion view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloOrden = new ModeloOrden();
            _modeloProducto = new ModeloProducto();
            _modeloSala = new ModeloSala();
            _modeloMesa = new ModeloMesa();
            _modeloCliente = new ModeloCliente();
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

        public List<Sala> ObtenerTodosSala()
        {
            var Sala = _modeloSala.ObtenerTodos();
            return Sala;
        }

        public List<Mesa> ObtenerTodosMesa()
        {
            var Mesa = _modeloMesa.ObtenerTodos();
            return Mesa;
        }

        public List<Cliente> ObtenerTodosCliente()
        {
            var Cliente = _modeloCliente.ObtenerTodos();
            return Cliente;
        }

        public bool Guardar(IEnumerable<ItemFactura> items)
        {
            var registro = new Orden
            {
                ID_Orden = _view.ID_Orden,
                ID_Cliente = _view.ID_Cliente,
                ID_Mesa = _view.ID_Mesa,
                ID_Usuario = 2,
                ID_Condicion = 2,
                FechaAlta = DateTime.Now,
                FechaVencimiento = null,
                Total = _view.Total,
                SaldoPendiente = _view.SaldoPendiente,
                Finalizada = false,
                Activo = true
            };
            var ok = _modeloOrden.Guardar(registro);
            if (!ok) return false;

            var detalles = (items ?? Enumerable.Empty<ItemFactura>())
            .GroupBy(i => i.ID_Producto)
            .Select(g =>
            {
                var prod = ObtenerProducto(g.Key);
                return new OrdenDetalle
                {
                    ID_Orden = registro.ID_Orden,
                    ID_Producto = g.Key,
                    Cantidad = g.Sum(x => x.Cantidad),
                    PrecioUnitario = prod?.PrecioVenta ?? g.Last().PrecioVenta,
                    Activo = true
                };
            })
            .ToList();

            if (detalles.Count == 0)
            {
                _view.ID_Orden = registro.ID_Orden;
                return true;
            }

            var modeloDetalle = new ModeloOrdenDetalle();
            ok = modeloDetalle.GuardarRango(detalles);

            _view.ID_Orden = registro.ID_Orden;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Orden > 0)
            {
                return _modeloOrden.EliminarPorID(_view.ID_Orden);
            }
            return false;
        }
    }
}
