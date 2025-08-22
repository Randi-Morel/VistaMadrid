using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
namespace VistaMadrid.MP

{
    public class PresentadorProducto
    {
        private readonly IProducto _view;
        private MVistas.IVistasRepository _vistasRepository;
        private readonly ModeloArchivo _modeloArchivo;
        private readonly ModeloProducto _modeloProducto;
        private readonly ModeloProductoArchivo _modeloProductoArchivo;
        private readonly ModeloProductoCategoria _modeloProductoCategoria;
        private readonly ModeloUnidadMedida _modeloUnidadMedida;

        public PresentadorProducto(IProducto view)
        {
            _view = view;
            _vistasRepository = new MVistas.ModeloVistas();
            _modeloArchivo = new ModeloArchivo();
            _modeloProducto = new ModeloProducto();
            _modeloProductoArchivo = new ModeloProductoArchivo();
            _modeloProductoCategoria = new ModeloProductoCategoria();
            _modeloUnidadMedida = new ModeloUnidadMedida();
        }

        public List<C_Producto> CargarDatosGRD(string descripcion, int? idCategoria)
        {
            var lista = _vistasRepository.DbContext.C_Producto.ToList();

            if (idCategoria.HasValue && idCategoria > 0)
                lista = lista.Where(s => s.ID_ProductoCategoria == idCategoria).ToList();

            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                var q = descripcion.Trim();
                lista = lista.Where(s => (s.Nombre ?? "")
                    .IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            return lista;
        }

        public ProductoArchivo ObtenerProductoArchivo(int ID_Producto)
        {
            var ProductoArchivo = _modeloProductoArchivo.ObtenerPorID_Producto(ID_Producto);
            return ProductoArchivo;
        }

        public Archivo ObtenerArchivo(int ID_Archivo)
        {
            var Archivo = _modeloArchivo.ObtenerPorID(ID_Archivo);
            return Archivo;
        }

        public List<ProductoCategoria> ObtenerTodosProductoCategoria()
        {
            var ProductoCategoria = _modeloProductoCategoria.ObtenerTodos();
            return ProductoCategoria;
        }

        public List<UnidadMedida> ObtenerTodosUnidadMedida()
        {
            var UnidadMedida = _modeloUnidadMedida.ObtenerTodos();
            return UnidadMedida;
        }

        public List<C_Producto> ObtenerTodosC_Producto()
        {
            return _vistasRepository.DbContext.C_Producto.ToList();
        }

        public bool Guardar()
        {
            var registro = new Producto
            {
                ID_Producto = _view.ID_Producto,
                Nombre = (_view.Nombre ?? string.Empty).Trim(),
                Descripcion = (_view.Descripcion ?? string.Empty).Trim(),
                ID_ProductoCategoria = _view.ID_ProductoCategoria,
                ID_UnidadMedida = _view.ID_UnidadMedida,
                StockActual = _view.StockMinimo,
                StockMinimo = _view.StockMinimo,
                PrecioCosto = _view.PrecioCosto,
                PrecioVenta = _view.PrecioVenta,
                Activo = _view.Activo
            };
            var ok = _modeloProducto.Guardar(registro);

            if (ok && _view.ArchivoContenido != null && _view.ArchivoContenido.Length > 0)
            {
                var img = new Archivo
                {
                    NombreArchivo = $"producto_{registro.Nombre}_{DateTime.Now:yyyyMMddHHmmss}",
                    TipoArchivo = "image/jpeg",
                    Datos = _view.ArchivoContenido,
                    FechaSubida = DateTime.Now
                };

                var okArchivo = _modeloArchivo.Guardar(img);
                if (okArchivo)
                {
                    var prodImg = new ProductoArchivo
                    {
                        ID_Producto = registro.ID_Producto,
                        ID_Archivo = img.ID_Archivo,
                    };
                    _modeloProductoArchivo.Guardar(prodImg);
                }
            };

            _view.ID_Producto = registro.ID_Producto;
            return ok;
        }

        public bool Eliminar()
        {
            if (_view.ID_Producto > 0)
            {
                return _modeloProducto.EliminarPorID(_view.ID_Producto);
            }
            return false;
        }
    }
}
