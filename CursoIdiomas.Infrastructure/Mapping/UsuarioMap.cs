using CursoIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoIdiomas.Infrastructure.Mapping
{
    class UsuarioMap : BaseMap<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);

            builder.ToTable("Usuarios");

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
