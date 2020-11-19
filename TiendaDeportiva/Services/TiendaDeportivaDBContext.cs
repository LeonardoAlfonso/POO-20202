using Microsoft.EntityFrameworkCore;
using TiendaDeportiva.Models;

namespace TiendaDeportiva.Services
{
    public class TiendaDeportivaDBContext : DbContext
    {
        public TiendaDeportivaDBContext(DbContextOptions<TiendaDeportivaDBContext> options)
                    : base(options) { }

        public DbSet<UsuarioModel> usuariosla { get; set; }
    }
}