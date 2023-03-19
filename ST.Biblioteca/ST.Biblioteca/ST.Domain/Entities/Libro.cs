using System;
using System.Collections.Generic;

namespace ST.Domain.Entities
{
    public partial class Libro
    {
        public Int64 Isbn { get; set; }
        public int? EditorialesId { get; set; }
        public string? Titulo { get; set; }
        public string? Sinopsis { get; set; }
        public string? NPaginas { get; set; }

        public virtual Editoriale? Editoriales { get; set; }
    }
}
