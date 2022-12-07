using Microsoft.EntityFrameworkCore;

namespace HouseCrimes.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Filme> Filme { get; set; }
    }
}
