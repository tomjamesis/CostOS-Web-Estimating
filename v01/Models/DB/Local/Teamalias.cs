﻿using System;
using System.Collections.Generic;

namespace Models.DB.Local
{
    public partial class Teamalias
    {
        public long Id { get; set; }
        public string Team { get; set; }
        public string Alias { get; set; }
    }
}
