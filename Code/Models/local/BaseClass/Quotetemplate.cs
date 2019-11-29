﻿using System;
using System.Collections.Generic;

namespace Models.local.BaseClass
{
    public partial class Quotetemplate
    {
        public long Id { get; set; }
        public byte[] Xcellfile { get; set; }
        public string Editorid { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Title { get; set; }
        public bool? Ismaterial { get; set; }
        public long? Layoutid { get; set; }
        public bool? Dflt { get; set; }
    }
}
