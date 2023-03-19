using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.Application.DTOs.Libro.Response
{
    public class LibroResponseDTo
    {
        public string? NombreAutor { get; set; }
        public string? ApellidosAutor { get; set; }
        public Int64? Isbn { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopsis { get; set; }
        public string? NPaginas { get; set; }
        public string? NombreEditorial { get; set; }
        public string? SedeEditorial { get; set; }
    }
}
