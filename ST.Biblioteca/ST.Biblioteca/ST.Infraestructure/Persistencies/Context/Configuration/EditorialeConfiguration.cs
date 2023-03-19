using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ST.Domain.Entities;

namespace ST.Infraestructure.Persistencies.Context.Configuration
{
    public class EditorialeConfiguration : IEntityTypeConfiguration<Editoriale>
    {
        public void Configure(EntityTypeBuilder<Editoriale> builder)
        {
            builder.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false);

            builder.Property(e => e.Sede)
                .HasMaxLength(45)
                .IsUnicode(false);
        }
    }
}
