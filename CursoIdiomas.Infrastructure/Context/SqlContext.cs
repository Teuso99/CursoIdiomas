using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CursoIdiomas.Infrastructure.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Aluno>(new AlunoMap().Configure);
            modelBuilder.Entity<Turma>(new TurmaMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
        }
    }
}
