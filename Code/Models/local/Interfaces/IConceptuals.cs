using System;


namespace Models.local.Interfaces
{
	public interface IConceptuals
	{
		long Conceptualid { get; set; }
		int? Exectype { get; set; }
		string Title { get; set; }
		string Currency { get; set; }
		string Crewfacs { get; set; }
		string Unit { get; set; }
		string Titleconcat { get; set; }
		string Notesconcat { get; set; }
		string Descconcat { get; set; }
		string Matrate { get; set; }
		string Matfab { get; set; }
		string Matship { get; set; }
		string Crews { get; set; }
		string Subrate { get; set; }
		string Subika { get; set; }
		string Weightunit { get; set; }
		string Volflow { get; set; }
		string Vfunit { get; set; }
		string Massflow { get; set; }
		string Mfunit { get; set; }
		string Duty { get; set; }
		string Dtunit { get; set; }
		string Operpress { get; set; }
		string Opunit { get; set; }
		string Opertemp { get; set; }
		string Otunit { get; set; }
		string Groupcode { get; set; }
		string Gekcode { get; set; }
		string Labrate { get; set; }
		string Labika { get; set; }
		string Conrate { get; set; }
		string Equresrate { get; set; }
		string Equlubrate { get; set; }
		string Equtrsrate { get; set; }
		string Equsprrate { get; set; }
		string Equdeprate { get; set; }
		string Equfulrate { get; set; }
		string Equfucrate { get; set; }
		string Equfutrate { get; set; }
		string Extracode1 { get; set; }
		string Extracode2 { get; set; }
		string Extracode3 { get; set; }
		string Extracode4 { get; set; }
		string Extracode5 { get; set; }
		string Extracode6 { get; set; }
		string Extracode7 { get; set; }
		string Rawmat1 { get; set; }
		string Rawmat2 { get; set; }
		string Rawmat3 { get; set; }
		string Rawmat4 { get; set; }
		string Rawmat5 { get; set; }
		string Weightrate { get; set; }
		decimal? Rel1 { get; set; }
		decimal? Rel2 { get; set; }
		decimal? Rel3 { get; set; }
		decimal? Rel4 { get; set; }
		decimal? Rel5 { get; set; }
		DateTime? Refdate { get; set; }
		string Ct01eq { get; set; }
		string Ct02eq { get; set; }
		string Ct03eq { get; set; }
		string Ct04eq { get; set; }
		string Ct05eq { get; set; }
		string Ct06eq { get; set; }
		string Ct07eq { get; set; }
		string Ct08eq { get; set; }
		string Ct09eq { get; set; }
		string Ct10eq { get; set; }
		string Ct11eq { get; set; }
		string Ct12eq { get; set; }
		string Ct13eq { get; set; }
		string Ct14eq { get; set; }
		string Ct15eq { get; set; }
		string Ct16eq { get; set; }
		string Ct17eq { get; set; }
		string Ct18eq { get; set; }
		string Ct19eq { get; set; }
		string Ct20eq { get; set; }
		string Ct21eq { get; set; }
		string Ct22eq { get; set; }
		string Ct23eq { get; set; }
		string Ct24eq { get; set; }
		string Ct25eq { get; set; }
		string Cr01eq { get; set; }
		string Cr02eq { get; set; }
		string Cr03eq { get; set; }
		string Cr04eq { get; set; }
		string Cr05eq { get; set; }
		string Cr06eq { get; set; }
		string Cr07eq { get; set; }
		string Cr08eq { get; set; }
		string Cr09eq { get; set; }
		string Cr10eq { get; set; }
		string Cr11eq { get; set; }
		string Cr12eq { get; set; }
		string Cr13eq { get; set; }
		string Cr14eq { get; set; }
		string Cr15eq { get; set; }
		string Cr16eq { get; set; }
		string Cr17eq { get; set; }
		string Cr18eq { get; set; }
		string Cr19eq { get; set; }
		string Cr20eq { get; set; }
		string Cc01eq { get; set; }
		string Cc02eq { get; set; }
		string Cc03eq { get; set; }
		string Cc04eq { get; set; }
		string Cc05eq { get; set; }
		string Cc06eq { get; set; }
		string Cc07eq { get; set; }
		string Cc08eq { get; set; }
		string Cc09eq { get; set; }
		string Cc10eq { get; set; }
		string Cc11eq { get; set; }
		string Cc12eq { get; set; }
		string Cc13eq { get; set; }
		string Cc14eq { get; set; }
		string Cc15eq { get; set; }
		string Cc16eq { get; set; }
		string Cc17eq { get; set; }
		string Cc18eq { get; set; }
		string Cc19eq { get; set; }
		string Cc20eq { get; set; }
		long? Paramoutputid { get; set; }
		BaseClass.Paramoutput Paramoutput { get; set; }
		
		Conceptuals Clone();
	}
}
