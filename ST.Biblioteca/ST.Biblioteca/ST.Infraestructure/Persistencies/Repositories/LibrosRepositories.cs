using Microsoft.EntityFrameworkCore;
using ST.Infraestructure.Commons.Base.Request;
using ST.Infraestructure.Commons.Base.Response;
using ST.Infraestructure.Persistencies.Context;
using ST.Infraestructure.Persistencies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.Infraestructure.Persistencies.Repositories
{
    public class LibrosRepositories : ILibrosRepositories
    {
        private readonly BD_Browser_TravelContext _context;

        public LibrosRepositories(BD_Browser_TravelContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LibroResponse>> ListaLibros()
        {
            var libros = await (from autoresLibros in _context.AutoresHasLibros
                                  join autor in _context.Autores on autoresLibros.AutoresId equals autor.Id
                                  join libro in _context.Libros on autoresLibros.LibrosIsbn equals libro.Isbn
                                  join editorial in _context.Editoriales on libro.EditorialesId equals editorial.Id
                                  select new LibroResponse
                                  {
                                      NombreAutor = autor.Nombre,
                                      ApellidosAutor = autor.Apellidos,
                                      Isbn = libro.Isbn,
                                      Titulo = libro.Titulo,
                                      Sinopsis = libro.Sinopsis,
                                      NPaginas = libro.NPaginas,
                                      NombreEditorial = editorial.Nombre,
                                      SedeEditorial = editorial.Sede
                                  }).AsNoTracking().ToListAsync();
            return libros;
        }

        public async Task<LibroResponse> LibroId(Int64 libroId)
        {
            var resultQuery = await(from libro in _context.Libros!
                                    join autoresLibros in _context.AutoresHasLibros 
                                                       on libro.Isbn equals autoresLibros.LibrosIsbn
                                    join autor in _context.Autores on autoresLibros.AutoresId equals autor.Id
                                    join editorial in _context.Editoriales on libro.EditorialesId equals editorial.Id
                                    where libro.Isbn.Equals(libroId)
                                 select new LibroResponse
                                 {
                                     NombreAutor = autor.Nombre,
                                     ApellidosAutor = autor.Apellidos,
                                     Isbn = libro.Isbn,
                                     Titulo = libro.Titulo,
                                     Sinopsis = libro.Sinopsis,
                                     NPaginas = libro.NPaginas,
                                     NombreEditorial = editorial.Nombre,
                                     SedeEditorial = editorial.Sede
                                 }).AsNoTracking().FirstOrDefaultAsync();
            return resultQuery!;
        }

    }
}
