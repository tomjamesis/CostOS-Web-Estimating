﻿using System;
using System.Collections.Generic;

namespace Model.DB.Project
{
    public partial class Prjuserprop
    {
        public long Id { get; set; }
        public string Pkey { get; set; }
        public string Pval { get; set; }
        public string Propuser { get; set; }
        public long? Prjid { get; set; }
        public long? RefId { get; set; }
    }
}
