using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaMadrid.MP
{
    public interface ILogin
    {
        string Usuario { get; set; }
        string Password { get; set; }

        PresentadorLogin Presentador { get; set; }
    }
}
