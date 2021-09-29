using System.Data.Entity;


namespace TesteConfirp.Models
{
    public class TesteContext : DbContext
    {
        public DbSet<Estudantes> Estudantes { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
    }
}