using CursoIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoIdiomas.Infrastructure.Mapping
{
    class TurmaMap : BaseMap<Turma>
    {
        public override void Configure(EntityTypeBuilder<Turma> builder)
        {
            base.Configure(builder);

            builder.ToTable("Turmas");

            builder.HasMany(prop => prop.Alunos).WithOne(prop => prop.Turma);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(100)");

            builder.Property(prop => prop.Turno)
                .IsRequired()
                .HasColumnName("Turno")
                .HasColumnType("VARCHAR(20)");
        }
    }
}
