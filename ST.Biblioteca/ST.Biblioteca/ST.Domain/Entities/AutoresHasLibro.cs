using System;
using System.Collections.Generic;

namespace ST.Domain.Entities
{
    public partial class AutoresHasLibro
    {
        public int? AutoresId { get; set; }
        public Int64? LibrosIsbn { get; set; }

        public virtual Autore? Autores { get; set; }
        public virtual Libro? LibrosIsbnNavigation { get; set; }
    }
}
