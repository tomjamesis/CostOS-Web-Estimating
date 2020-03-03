﻿using System;
using System.Collections.Generic;

namespace Models.DB.Project
{
    public partial class Conceptuals
    {
        public long Conceptualid { get; set; }
        public int? Exectype { get; set; }
        public string Title { get; set; }
        public string Currency { get; set; }
        public string Crewfacs { get; set; }
        public string Unit { get; set; }
        public string Titleconcat { get; set; }
        public string Notesconcat { get; set; }
        public string Descconcat { get; set; }
        public string Matrate { get; set; }
        public string Matfab { get; set; }
        public string Matship { get; set; }
        public string Crews { get; set; }
        public string Subrate { get; set; }
        public string Subika { get; set; }
        public string Weightunit { get; set; }
        public string Volflow { get; set; }
        public string Vfunit { get; set; }
        public string Massflow { get; set; }
        public string Mfunit { get; set; }
        public string Duty { get; set; }
        public string Dtunit { get; set; }
        public string Operpress { get; set; }
        public string Opunit { get; set; }
        public string Opertemp { get; set; }
        public string Otunit { get; set; }
        public string Groupcode { get; set; }
        public string Gekcode { get; set; }
        public string Labrate { get; set; }
        public string Labika { get; set; }
        public string Conrate { get; set; }
        public string Equresrate { get; set; }
        public string Equlubrate { get; set; }
        public string Equtrsrate { get; set; }
        public string Equsprrate { get; set; }
        public string Equdeprate { get; set; }
        public string Equfulrate { get; set; }
        public string Equfucrate { get; set; }
        public string Equfutrate { get; set; }
        public string Extracode1 { get; set; }
        public string Extracode2 { get; set; }
        public string Extracode3 { get; set; }
        public string Extracode4 { get; set; }
        public string Extracode5 { get; set; }
        public string Extracode6 { get; set; }
        public string Extracode7 { get; set; }
        public string Rawmat1 { get; set; }
        public string Rawmat2 { get; set; }
        public string Rawmat3 { get; set; }
        public string Rawmat4 { get; set; }
        public string Rawmat5 { get; set; }
        public string Weightrate { get; set; }
        public decimal? Rel1 { get; set; }
        public decimal? Rel2 { get; set; }
        public decimal? Rel3 { get; set; }
        public decimal? Rel4 { get; set; }
        public decimal? Rel5 { get; set; }
        public DateTime? Refdate { get; set; }
        public string Ct01eq { get; set; }
        public string Ct02eq { get; set; }
        public string Ct03eq { get; set; }
        public string Ct04eq { get; set; }
        public string Ct05eq { get; set; }
        public string Ct06eq { get; set; }
        public string Ct07eq { get; set; }
        public string Ct08eq { get; set; }
        public string Ct09eq { get; set; }
        public string Ct10eq { get; set; }
        public string Ct11eq { get; set; }
        public string Ct12eq { get; set; }
        public string Ct13eq { get; set; }
        public string Ct14eq { get; set; }
        public string Ct15eq { get; set; }
        public string Ct16eq { get; set; }
        public string Ct17eq { get; set; }
        public string Ct18eq { get; set; }
        public string Ct19eq { get; set; }
        public string Ct20eq { get; set; }
        public string Ct21eq { get; set; }
        public string Ct22eq { get; set; }
        public string Ct23eq { get; set; }
        public string Ct24eq { get; set; }
        public string Ct25eq { get; set; }
        public string Cr01eq { get; set; }
        public string Cr02eq { get; set; }
        public string Cr03eq { get; set; }
        public string Cr04eq { get; set; }
        public string Cr05eq { get; set; }
        public string Cr06eq { get; set; }
        public string Cr07eq { get; set; }
        public string Cr08eq { get; set; }
        public string Cr09eq { get; set; }
        public string Cr10eq { get; set; }
        public string Cr11eq { get; set; }
        public string Cr12eq { get; set; }
        public string Cr13eq { get; set; }
        public string Cr14eq { get; set; }
        public string Cr15eq { get; set; }
        public string Cr16eq { get; set; }
        public string Cr17eq { get; set; }
        public string Cr18eq { get; set; }
        public string Cr19eq { get; set; }
        public string Cr20eq { get; set; }
        public string Cc01eq { get; set; }
        public string Cc02eq { get; set; }
        public string Cc03eq { get; set; }
        public string Cc04eq { get; set; }
        public string Cc05eq { get; set; }
        public string Cc06eq { get; set; }
        public string Cc07eq { get; set; }
        public string Cc08eq { get; set; }
        public string Cc09eq { get; set; }
        public string Cc10eq { get; set; }
        public string Cc11eq { get; set; }
        public string Cc12eq { get; set; }
        public string Cc13eq { get; set; }
        public string Cc14eq { get; set; }
        public string Cc15eq { get; set; }
        public string Cc16eq { get; set; }
        public string Cc17eq { get; set; }
        public string Cc18eq { get; set; }
        public string Cc19eq { get; set; }
        public string Cc20eq { get; set; }
        public long? Paramoutputid { get; set; }
        public long? Prjid { get; set; }
        public long? RefId { get; set; }

        public virtual Paramoutput Paramoutput { get; set; }
    }
}
