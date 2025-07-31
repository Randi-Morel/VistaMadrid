using System.Collections.Generic;
using System.Data.Entity;

public interface IRepositorioBase<T> where T : class, new()
{
    DbSet<T> Query { get; }

    T ObtenerPorID(int id);
    List<T> ObtenerTodos();
    bool Guardar(T entity);
    bool GuardarRango(List<T> entities);
    bool EliminarPorID(int id);
    bool EliminarRango(List<T> entities);
}
