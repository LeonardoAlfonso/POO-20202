using System.Collections.Generic;
using TiendaDeportiva.Models;

namespace TiendaDeportiva.ViewModels
{
    public class ListUsersViewModel
    {
        public List<UsuarioModel> Users { get; set; }

        public ListUsersViewModel()
        {
            Users = new List<UsuarioModel>();
        }

    }
}