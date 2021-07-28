using CursoIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoIdiomas.Infrastructure.Mapping
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.Turma).WithMany(prop => prop.Alunos);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(100)");

            builder.Property(prop => prop.Matricula)
                .IsRequired()
                .HasColumnName("Matricula")
                .HasColumnType("VARCHAR(100)");

            builder.Property(prop => prop.Idade)
                .IsRequired()
                .HasColumnName("Idade")
                .HasColumnType("INT");
        }
    }
}
