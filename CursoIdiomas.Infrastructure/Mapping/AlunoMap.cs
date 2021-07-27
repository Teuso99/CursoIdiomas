using CursoIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIdiomas.Infrastructure.Mapping
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.Id);

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
