﻿using System;
using System.Collections.Generic;

namespace Model.DB.Local
{
    public partial class Roles
    {
        public string Roleid { get; set; }
        public string Principalid { get; set; }
        public string Role { get; set; }
        public string Rolegroup { get; set; }
    }
}
