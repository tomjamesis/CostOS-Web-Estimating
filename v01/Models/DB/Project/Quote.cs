﻿using System;
using System.Collections.Generic;

namespace Models.DB.Project
{
    public partial class Quote
    {
        public Quote()
        {
            Quoteitem = new HashSet<QuoteItem>();
        }

        public long Expenseid { get; set; }
        public int? Performance { get; set; }
        public string Subject { get; set; }
        public string Fax { get; set; }
        public string Currency { get; set; }
        public bool? Delivery { get; set; }
        public bool? Hasmatrate { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Geopos { get; set; }
        public long? Quotetempid { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Statepro { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
        public string Tomail { get; set; }
        public string Ccmail { get; set; }
        public string Bccmail { get; set; }
        public string Quotetype { get; set; }
        public string Editorid { get; set; }
        public string Status { get; set; }
        public string Guid { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Sentdate { get; set; }
        public DateTime? Receiveddate { get; set; }
        public long? Prjid { get; set; }
        public long? RefId { get; set; }

        public virtual ICollection<QuoteItem> Quoteitem { get; set; }
    }
}
