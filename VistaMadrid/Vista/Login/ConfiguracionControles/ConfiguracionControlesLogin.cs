using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaMadrid.MP
{
    public class ConfiguracionControlesLogin
    {
        private readonly ILogin _view;
        public ConfiguracionControlesLogin(ILogin view)
        {
            _view = view;
        }

        public void Configurar()
        {
            // Estilos, validaciones, combobox, etc.
        }
    }
}
