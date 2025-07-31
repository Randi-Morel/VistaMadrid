using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using VistaMadrid.MP.EF;

public abstract class RepositorioBase<T> : BaseModelo, IRepositorioBase<T> where T : class, new()
{
    public DbSet<T> Query
    {
        get
        {
            this.Instanciar();
            return _db.Set<T>();
        }
    }

    public virtual T ObtenerPorID(int id)
    {
        using (var context = new BDVistaMadridEntidades())
        {
            return context.Set<T>().Find(id);
        }
    }

    public virtual List<T> ObtenerTodos()
    {
        using (var context = new BDVistaMadridEntidades())
        {
            return context.Set<T>().ToList();
        }
    }

    public virtual bool Guardar(T entity)
    {
        using (var context = new BDVistaMadridEntidades())
        {
            var idPrimaryKey = GetKeyValue(entity);
            if (Convert.ToInt32(idPrimaryKey) > 0)
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                context.Set<T>().Add(entity);
            }
            return context.SaveChanges() > 0;
        }
    }

    public virtual bool GuardarRango(List<T> entities)
    {
        using (var context = new BDVistaMadridEntidades())
        {
            foreach (var item in entities)
            {
                var idPrimaryKey = GetKeyValue(item);
                if (Convert.ToInt32(idPrimaryKey) > 0)
                {
                    context.Entry(item).State = EntityState.Modified;
                }
                else
                {
                    context.Set<T>().Add(item);
                }
            }
            return context.SaveChanges() > 0;
        }
    }

    public virtual bool EliminarPorID(int id)
    {
        using (var context = new BDVistaMadridEntidades())
        {
            var entity = ObtenerPorID(id);
            if (entity != null)
            {
                context.Entry(entity).State = EntityState.Deleted;
                return context.SaveChanges() > 0;
            }
            return false;
        }
    }

    public virtual bool EliminarRango(List<T> entities)
    {
        using (var context = new BDVistaMadridEntidades())
        {
            foreach (var item in entities)
            {
                context.Entry(item).State = EntityState.Deleted;
            }
            return context.SaveChanges() > 0;
        }
    }

    private object GetKeyValue(T entity)
    {
        var keyProperty = typeof(T).GetProperties()
            .FirstOrDefault(p => p.GetCustomAttribute<KeyAttribute>() != null);

        if (keyProperty == null)
            throw new InvalidOperationException("La entidad no tiene una clave primaria válida.");

        return keyProperty.GetValue(entity);
    }
}
