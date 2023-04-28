using Microsoft.EntityFrameworkCore;

namespace Gazeta.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }

    }
}
