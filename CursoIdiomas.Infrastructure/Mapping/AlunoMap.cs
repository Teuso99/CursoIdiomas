using CursoIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoIdiomas.Infrastructure.Mapping
{
    public class AlunoMap : BaseMap<Aluno>
    {
        public override void Configure(EntityTypeBuilder<Aluno> builder)
        {
            base.Configure(builder);

            builder.ToTable("Alunos");

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
