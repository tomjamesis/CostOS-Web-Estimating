﻿using System;
using System.Collections.Generic;

namespace Models.DB.Project
{
    public partial class BoqItemMetadata
    {
        public long Id { get; set; }
        public string Fieldkey { get; set; }
        public string Initialdisplayname { get; set; }
        public string Fieldname { get; set; }
        public string Columnname { get; set; }
    }
}
