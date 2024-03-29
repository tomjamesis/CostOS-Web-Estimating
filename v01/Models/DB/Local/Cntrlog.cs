﻿using System;
using System.Collections.Generic;

namespace Models.DB.Local
{
    public partial class CntrLog
    {
        public long Id { get; set; }
        public DateTime? Logdate { get; set; }
        public string Editorid { get; set; }
        public string Description { get; set; }
        public string Src { get; set; }
        public string Fltr { get; set; }
        public long? Prjid { get; set; }
        public byte? Oprtn { get; set; }
    }
}
