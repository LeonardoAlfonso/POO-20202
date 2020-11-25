using System.Collections.Generic;
using Libreria.Models;

namespace Libreria.ViewModels
{
    public class LibrosIndexViewModel
    {
        public List<LibroModel> Libros { get; set; }
        public bool HayLibros { get; set; }

        public LibrosIndexViewModel()
        {
            Libros = new List<LibroModel>();
            HayLibros = true;
        }
    }
}