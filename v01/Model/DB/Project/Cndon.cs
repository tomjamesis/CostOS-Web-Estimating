﻿using System;
using System.Collections.Generic;

namespace Model.DB.Project
{
    public partial class Cndon
    {
        public Cndon()
        {
            BoqitemCondition = new HashSet<BoqitemCondition>();
        }

        public long Conditionid { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public byte? Operand { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? Qty2 { get; set; }
        public decimal? Qty3 { get; set; }
        public decimal? Qtyf { get; set; }
        public string Unit1 { get; set; }
        public string Unit2 { get; set; }
        public string Unit3 { get; set; }
        public string Unitf { get; set; }
        public string Dbname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int? Bidno { get; set; }
        public int? Cndno { get; set; }
        public string Cndtype { get; set; }
        public int? Cndid { get; set; }
        public string Globalid { get; set; }
        public int? Picktype { get; set; }
        public string Pickdata { get; set; }
        public string Takeofftype { get; set; }
        public string Building { get; set; }
        public string Storey { get; set; }
        public string Location { get; set; }
        public string Layer { get; set; }
        public string Qty1name { get; set; }
        public string Qty2name { get; set; }
        public string Qty3name { get; set; }
        public string Qtyfname { get; set; }
        public string Formula1 { get; set; }
        public string Formula2 { get; set; }
        public string Formula3 { get; set; }
        public string Formulaf { get; set; }
        public string Bimtype { get; set; }
        public string Bimmaterial { get; set; }
        public string Fctstate { get; set; }
        public bool? Virt { get; set; }
        public long? Prjid { get; set; }
        public long? RefId { get; set; }

        public virtual ICollection<BoqitemCondition> BoqitemCondition { get; set; }
    }
}
