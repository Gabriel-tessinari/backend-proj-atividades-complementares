using Microsoft.EntityFrameworkCore;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Context
{
    public class ProjDbContext : DbContext
    {
        public ProjDbContext(DbContextOptions<ProjDbContext> options) : base(options) { }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<HorasComplementares> HorasComplementares { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Atividades> Atividades { get; set; }
        public DbSet<Conversao> Conversao { get; set; }
        public DbSet<GrupoAtividades> GrupoAtividades { get; set; }
        public DbSet<Pontuacao> Pontuacao { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<HorasComplementares>().ToTable("HorasComplementares");
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
