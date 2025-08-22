using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Entidades;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorRegistroPagos
    {
        private readonly IRegistroPagos _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloPago _modeloPago;
        private readonly ModeloMetodoPago _modeloMetodoPago;
        private readonly ModeloOrden _modeloOrden;

        public PresentadorRegistroPagos(IRegistroPagos view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloPago = new ModeloPago();
            _modeloMetodoPago = new ModeloMetodoPago();
            _modeloOrden = new ModeloOrden();
        }

        public C_Orden ObtenerC_Orden(int idOrden)
        {
            return _vistasRepository.DbContext.C_Orden.Where(o => o.ID_Orden == idOrden).FirstOrDefault();
        }

        public Orden ObtenerOrden(int idOrden)
        {
            return _vistasRepository.DbContext.Orden.Where(o => o.ID_Orden == idOrden).FirstOrDefault();
        }

        public List<C_Orden> ObtenerTodosC_Orden()
        {
            return _vistasRepository.DbContext.C_Orden.Where(o => (o.SaldoPendiente ?? 0m) > 0m).ToList();
        }

        public List<MetodoPago> ObtenerTodosMetodoPago()
        {
            return _modeloMetodoPago.ObtenerTodos();
        }

        public bool Guardar(IEnumerable<ItemOrdenPago> items)
        {
            var registro = new Pago
            {
                ID_Pago = _view.ID_Pago,
                ID_MetodoPago = _view.ID_MetodoPago,
                FechaPago = DateTime.Now,
                MontoTotal = _view.MontoTotal,
                Nota = null,
                Activo = true
            };
            var ok = _modeloPago.Guardar(registro);
            if (!ok) return false;

            var detalles = (items ?? Enumerable.Empty<ItemOrdenPago>())
            .GroupBy(i => i.ID_Orden)
            .Select(g =>
            {
                return new OrdenPago
                {
                    ID_Pago = registro.ID_Pago,
                    ID_Orden = g.Key,
                };
            })
            .ToList();

            if (detalles.Count == 0)
            {
                _view.ID_Pago = registro.ID_Pago;
                return true;
            }

            var modeloDetalle = new ModeloOrdenPago();
            ok = modeloDetalle.GuardarRango(detalles);
            if (!ok) return false;

            var idsOrdenes = detalles.Select(d => d.ID_Orden).Distinct().ToList();

            var ordenes = new List<Orden>();
            foreach (var id in idsOrdenes)
            {
                var o = ObtenerOrden(id);     
                if (o == null) continue;
                o.SaldoPendiente = 0m;        
                ordenes.Add(o);
            }

            if (ordenes.Count > 0)
            {
                ok = _modeloOrden.GuardarRango(ordenes);
                if (!ok) return false;
            }

            _view.ID_Pago = registro.ID_Pago;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Pago > 0)
            {
                return _modeloPago.EliminarPorID(_view.ID_Pago);
            }
            return false;
        }
    }
}
