using Microsoft.EntityFrameworkCore;
using Libreria.Models;

namespace Libreria.Services
{
    public class LibreriaDBContext : DbContext
    {
        public LibreriaDBContext(DbContextOptions<LibreriaDBContext> options)
                    : base(options) { }

        public DbSet<LibroModel> Libros { get; set; }
        public DbSet<AutorModel> Autores { get; set; }
    }
}