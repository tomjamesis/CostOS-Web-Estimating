﻿using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Filtro
    {
        public long Filtroid { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Filtroname { get; set; }
        public string Filtrotype { get; set; }
        public string Filtrodescription { get; set; }
    }
}
