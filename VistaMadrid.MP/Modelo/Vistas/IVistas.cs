using System;
using System.Collections.Generic;
using VistaMadrid.MP.EF;

namespace VistaMadrid.MP.MVistas
{
    public interface IVistasRepository : IDisposable
    {
        BDVistaMadridEntidades DbContext { get; }
    }
}
