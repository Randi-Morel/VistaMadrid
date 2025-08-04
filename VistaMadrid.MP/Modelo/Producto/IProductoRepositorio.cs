using System.Collections.Generic;
using VistaMadrid.MP.EF;

public interface IProductoRepository : IRepositorioBase<Producto>
{
    // Ejemplo de método adicional que podría ser necesario a futuro
    //List<Producto> ObtenerTodosPorID_Producto(int ID_Producto);
}
