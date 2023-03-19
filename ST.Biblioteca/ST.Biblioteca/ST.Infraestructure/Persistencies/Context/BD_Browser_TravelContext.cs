using Microsoft.EntityFrameworkCore;
using ST.Domain.Entities;
using System.Reflection;

namespace ST.Infraestructure.Persistencies.Context
{
    public partial class BD_Browser_TravelContext : DbContext
    {
        public BD_Browser_TravelContext()
        {
        }

        public BD_Browser_TravelContext(DbContextOptions<BD_Browser_TravelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autore> Autores { get; set; } = null!;
        public virtual DbSet<AutoresHasLibro> AutoresHasLibros { get; set; } = null!;
        public virtual DbSet<Editoriale> Editoriales { get; set; } = null!;
        public virtual DbSet<Libro> Libros { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configuracion de las entidades de forma global
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
