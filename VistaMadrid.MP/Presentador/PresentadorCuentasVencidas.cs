using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorCuentasVencidas
    {
        private readonly ICuentasVencidas _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloOrden _modeloOrden;

        public PresentadorCuentasVencidas(ICuentasVencidas view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloOrden = new ModeloOrden();
        }

        public List<C_Orden> ObtenerTodosC_Orden()
        {
            return _vistasRepository.DbContext.C_Orden.Where(o => (o.SaldoPendiente ?? 0m) > 0m && o.FechaVencimiento < DateTime.Now).ToList();
        }
    }
}
