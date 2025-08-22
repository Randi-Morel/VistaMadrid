using System.Collections.Generic;
using VistaMadrid.MP.EF;

public interface IProductoArchivoRepository : IRepositorioBase<ProductoArchivo>
{
    ProductoArchivo ObtenerPorID_Producto(int ID_Producto);
}
