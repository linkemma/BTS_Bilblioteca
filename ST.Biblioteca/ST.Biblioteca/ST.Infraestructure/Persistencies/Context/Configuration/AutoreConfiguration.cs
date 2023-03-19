using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ST.Domain.Entities;

namespace ST.Infraestructure.Persistencies.Context.Configuration
{
    public class AutoreConfiguration : IEntityTypeConfiguration<Autore>
    {
        public void Configure(EntityTypeBuilder<Autore> builder)
        {
            builder.ToTable("autores");

            builder.Property(e => e.Apellidos)
                .HasMaxLength(45)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .HasMaxLength(45)
                .IsUnicode(false);
        }
    }
}
