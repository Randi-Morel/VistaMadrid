using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;

public class ModeloUsuario : RepositorioBase<Usuario>, IUsuarioRepository
{
    public Usuario ObtenerPorCredenciales(string usuario, string password)
    {
        using (var context = new BDVistaMadridEntidades())
        {
            return context.Set<Usuario>()
                .AsNoTracking()
                .Where(u => u.Usuario1.Trim() == usuario && u.Contrasena.Trim() == password)
                .FirstOrDefault();
        }
    }
}
