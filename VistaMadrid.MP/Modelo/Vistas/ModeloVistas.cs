using System.Collections.Generic;
using System.Linq;
using VistaMadrid.MP.EF;

namespace VistaMadrid.MP.MVistas
{
    public sealed class ModeloVistas : IVistasRepository
    {
        public BDVistaMadridEntidades DbContext { get; }

        public ModeloVistas(int connectionTimeout = 60)
        {
            DbContext = new BDVistaMadridEntidades();
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Database.CommandTimeout = connectionTimeout;
        }

        public void Dispose() => DbContext?.Dispose();
    }
}
