﻿using System;
using System.Collections.Generic;

namespace Models
{
    public partial class PrjProp
    {
        public long Id { get; set; }
        public string Pkey { get; set; }
        public string Pval { get; set; }
        public long? Projecturlid { get; set; }

        public virtual ProjectUrl Projecturl { get; set; }
    }
}