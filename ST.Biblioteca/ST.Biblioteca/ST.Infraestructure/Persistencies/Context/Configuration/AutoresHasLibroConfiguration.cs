using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ST.Domain.Entities;

namespace ST.Infraestructure.Persistencies.Context.Configuration
{
    public class AutoresHasLibroConfiguration : IEntityTypeConfiguration<AutoresHasLibro>
    {
        public void Configure(EntityTypeBuilder<AutoresHasLibro> builder)
        {
            builder.HasNoKey();

            builder.ToTable("autores_has_libros");

            builder.Property(e => e.AutoresId).HasColumnName("Autores_id");

            builder.Property(e => e.LibrosIsbn).HasColumnName("Libros_ISBN");

            builder.HasOne(d => d.Autores)
                .WithMany()
                .HasForeignKey(d => d.AutoresId)
                .HasConstraintName("FK_autores_has_libros_autores");

            builder.HasOne(d => d.LibrosIsbnNavigation)
                .WithMany()
                .HasForeignKey(d => d.LibrosIsbn)
                .HasConstraintName("FK_autores_has_libros_libros");
        }
    }
}
