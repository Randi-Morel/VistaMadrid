using System.Collections.Generic;
using VistaMadrid.MP.EF;

public interface IProductoRepository : IRepositorioBase<Producto>
{
    // Ejemplo de m�todo adicional que podr�a ser necesario a futuro
    //List<Producto> ObtenerTodosPorID_Producto(int ID_Producto);
}
