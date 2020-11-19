using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class TiendaDBContext : DbContext
    {
        public TiendaDBContext(DbContextOptions<TiendaDBContext> options)
                    : base(options) { }

        public DbSet<Movie> peliculas { get; set; }
    }
}