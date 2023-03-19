using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ST.Domain.Entities;

namespace ST.Infraestructure.Persistencies.Context.Configuration
{
    public class LibroConfiguracion : IEntityTypeConfiguration<Libro>
    {
        public void Configure(EntityTypeBuilder<Libro> builder)
        {
            builder.HasKey(e => e.Isbn);

            builder.ToTable("libros");

            builder.Property(e => e.Isbn)
                .ValueGeneratedNever()
                .HasColumnName("ISBN");

            builder.Property(e => e.EditorialesId).HasColumnName("Editoriales_id");

            builder.Property(e => e.NPaginas)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("N_paginas");

            builder.Property(e => e.Sinopsis).HasColumnType("text");

            builder.Property(e => e.Titulo)
                .HasMaxLength(45)
                .IsUnicode(false);

            builder.HasOne(d => d.Editoriales)
                .WithMany(p => p.Libros)
                .HasForeignKey(d => d.EditorialesId)
                .HasConstraintName("FK_libros_editoriales");
        }
    }
}
