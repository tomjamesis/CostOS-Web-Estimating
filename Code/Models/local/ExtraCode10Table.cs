﻿using System;

namespace Model.local
{
    [Serializable]
    public class ExtraCode10Table
    {

        public static readonly string[] FIELDS = new string[] { "extraCode10Id", "groupCode", "title", "unit", "unitFactor", "editorId", "notes", "description", "lastUpdate" };

        public long? extraCode10Id { get; set; }
        public string extraCode10 { get; set; }
        public string title { get; set; }
        public string editorId { get; set; }
        public string description { get; set; }
        public string notes { get; set; }
        public DateTime lastUpdate { get; set; }
        public string unit { get; set; }
        public decimal unitFactor { get; set; }

        public ExtraCode10Table()
        { }
    }
}