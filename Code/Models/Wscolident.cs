﻿using System;
using System.Collections.Generic;

namespace Models.project1
{
    public partial class Wscolident
    {
        public long Id { get; set; }
        public string Splitfield { get; set; }
        public bool? Munique { get; set; }
        public bool? Sheetprefix { get; set; }
        public bool? Fileprefix { get; set; }
        public bool? Exauma { get; set; }
        public int? Coltype { get; set; }
        public int? Mapaction { get; set; }
        public string Fldname { get; set; }
        public int? Colindex { get; set; }
        public int? Fldtype { get; set; }
        public string Fieldmap { get; set; }
        public long? Mappingid { get; set; }

        public virtual Wsdatamapping Mapping { get; set; }
    }
}
