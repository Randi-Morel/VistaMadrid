using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;

public class ModeloProducto : RepositorioBase<Producto>, IProductoRepository
{
    // Ejemplo de método adicional que podría ser necesario a futuro
    //public List<Producto> ObtenerTodosPorID_Producto(int ID_Producto)
    //{
    //    using (var _db = new BDVistaMadridEntidades())
    //    {
    //        return _db.Set<Producto>()
    //                  .Where(x => x.ID_Producto == ID_Producto)
    //                  .ToList();
    //    }
    //}
}
