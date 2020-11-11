using System.Collections.Generic;
using TiendaDeportiva.Models;

namespace TiendaDeportiva.ViewModels
{
    public class ListProductViewModel
    {
        public List<Product> Products { get; set; }

        public ListProductViewModel()
        {
            Products = new List<Product>();
        }

    }
}