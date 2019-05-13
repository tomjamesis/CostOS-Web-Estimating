﻿using System;
using System.Collections.Generic;

namespace Models
{
    public partial class AssemblyLabor
    {
        public long Assemblylaborid { get; set; }
        public DateTime? Lastupdate { get; set; }
        public decimal? Factor1 { get; set; }
        public decimal? Factor2 { get; set; }
        public decimal? Factor3 { get; set; }
        public decimal? Exchangerate { get; set; }
        public long? Laborid { get; set; }
        public long? Assemblyid { get; set; }
        public decimal? Localfactor { get; set; }
        public string Localcountry { get; set; }
        public string Localstate { get; set; }
        public decimal? Frate { get; set; }
        public decimal? Fikarate { get; set; }
        public decimal? Qtypunit { get; set; }

        public virtual Assembly Assembly { get; set; }
        public virtual Labor Labor { get; set; }
    }
}
