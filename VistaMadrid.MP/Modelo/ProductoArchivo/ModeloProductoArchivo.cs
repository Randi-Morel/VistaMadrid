using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;

public class ModeloProductoArchivo : RepositorioBase<ProductoArchivo>, IProductoArchivoRepository
{
    public ProductoArchivo ObtenerPorID_Producto(int ID_Producto)
    {
        return Query.Where(pa => pa.ID_Producto == ID_Producto).FirstOrDefault();
    }
}
