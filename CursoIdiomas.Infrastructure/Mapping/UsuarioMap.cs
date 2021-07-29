using CursoIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoIdiomas.Infrastructure.Mapping
{
    class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("VARCHAR(100)");

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnName("Senha")
                .HasColumnType("VARCHAR(20)");
        }
    }
}
