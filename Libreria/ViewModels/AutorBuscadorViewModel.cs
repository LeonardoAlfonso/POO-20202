using System.Collections.Generic;
using Libreria.Models;

namespace Libreria.ViewModels
{
    public class AutorBuscadorViewModel
    {
        public AutorModel AutorBusqueda { get; set; }
        public bool HayUsuario { get; set; }

        public AutorBuscadorViewModel()
        {
            HayUsuario = false;
        }
    }
}