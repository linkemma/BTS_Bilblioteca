﻿using System;
using System.Collections.Generic;

namespace ST.Domain.Entities
{
    public partial class Autore
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
    }
}
