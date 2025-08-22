using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorStockActual
    {
        private readonly IStockActual _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloProducto _modeloProducto;

        public PresentadorStockActual(IStockActual view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloProducto = new ModeloProducto();
        }

        public List<C_Producto> ObtenerTodosC_Producto()
        {
            return _vistasRepository.DbContext.C_Producto.ToList();
        }
    }
}
