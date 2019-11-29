﻿using System;
using System.Collections.Generic;

namespace Models.local.BaseClass
{
    public partial class BcElemcovering
    {
        public long Id { get; set; }
        public int? Type { get; set; }
        public long? CoverelemId { get; set; }
        public long? ModelId { get; set; }
        public long? RelatingelemId { get; set; }

        public virtual BcElement Coverelem { get; set; }
        public virtual BcModel Model { get; set; }
        public virtual BcElement Relatingelem { get; set; }
    }
}
