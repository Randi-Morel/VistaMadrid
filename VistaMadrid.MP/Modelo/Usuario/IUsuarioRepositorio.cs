using System.Collections.Generic;
using VistaMadrid.MP.EF;

public interface IUsuarioRepository : IRepositorioBase<Usuario>
{
    Usuario ObtenerPorCredenciales(string usuario, string password);
}
