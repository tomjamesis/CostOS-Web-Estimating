﻿namespace Desktop.common.nomitech.common.data.descriptor
{
	using UILanguage = nomitech.common.ui.UILanguage;

	public class ProjectEPSWithUsersViewDescriptor : BaseViewDescriptor
	{
	  private static ProjectEPSWithUsersViewDescriptor s_instance = null;

	  private readonly DataObjectDescriptor[] ALL_FIELDS = new DataObjectDescriptor[]
	  {
		  new DataObjectDescriptor("epsLevel1Code", "eps.CODE1", "EPS LEVEL 1 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel2Code", "eps.CODE2", "EPS LEVEL 2 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel3Code", "eps.CODE3", "EPS LEVEL 3 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel4Code", "eps.CODE4", "EPS LEVEL 4 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel5Code", "eps.CODE5", "EPS LEVEL 5 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel6Code", "eps.CODE6", "EPS LEVEL 6 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel7Code", "eps.CODE7", "EPS LEVEL 7 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel8Code", "eps.CODE8", "EPS LEVEL 8 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel9Code", "eps.CODE9", "EPS LEVEL 9 CODE", "Text"),
		  new DataObjectDescriptor("epsLevel1Title", "eps.TITLE1", "EPS LEVEL 1 TITLE", "Text"),
		  new DataObjectDescriptor("epsLevel2Title", "eps.TITLE2", "EPS LEVEL 2 TITLE", "Text"),
		  new DataObjectDescriptor("epsLevel3Title", "eps.TITLE3", "EPS LEVEL 3 TITLE", "Text"),
		  new DataObjectDescriptor("epsLevel4Title", "eps.TITLE4", "EPS LEVEL 4 TITLE", "Text"),
		  new DataObjectDescriptor("epsLevel5Title", "eps.TITLE5", "EPS LEVEL 5 TITLE", "Text"),
		  new DataObjectDescriptor("epsLevel6Title", "eps.TITLE6", "EPS LEVEL 6 TITLE", "Text"),
		  new DataObjectDescriptor("epsLevel7Title", "eps.TITLE7", "EPS LEVEL 7 TITLE", "Text"),
		  new DataObjectDescriptor("epsLevel8Title", "eps.TITLE8", "EPS LEVEL 8 TITLE", "Text"),
		  new DataObjectDescriptor("epsLevel9Title", "eps.TITLE9", "EPS LEVEL 9 TITLE", "Text"),
		  new DataObjectDescriptor("defaultProjectId", "defaultProject.PROJECTINFOID", UILanguage.get("tab.pselect.column.id"), "Long"),
		  new DataObjectDescriptor("defaultProjectCode", "defaultProject.CODE", UILanguage.get("tab.pselect.column.code"), "Text"),
		  new DataObjectDescriptor("defaultProjectTitle", "defaultProject.TITLE", UILanguage.get("tab.pselect.column.title"), "Text"),
		  new DataObjectDescriptor("defaultProjectDescription", "defaultProject.DESCRIPTION", UILanguage.get("tab.pselect.column.description"), "Text"),
		  new DataObjectDescriptor("defaultProjectCreatorId", "defaultProject.CREATORID", "Creator ID", "Text"),
		  new DataObjectDescriptor("defaultProjectCreateDate", "defaultProject.CREATEDATE", UILanguage.get("tab.pselect.column.submissionDate"), "Date"),
		  new DataObjectDescriptor("defaultProjectEditorId", "defaultProject.EDITORID", UILanguage.get("tab.pselect.column.editorId"), "Text"),
		  new DataObjectDescriptor("defaultProjectLastUpdate", "defaultProject.LASTUPDATE", UILanguage.get("tab.pselect.column.lastUpdate"), "Date"),
		  new DataObjectDescriptor("defaultProjectStatus", "defaultProject.STATUS", UILanguage.get("tab.pselect.column.status"), "Text"),
		  new DataObjectDescriptor("defaultProjectCurrency", "defaultProject.CURRENCY", UILanguage.get("tab.pselect.column.currency"), "Text"),
		  new DataObjectDescriptor("defaultProjectTotalCost", "defaultProject.TOTALCOST", UILanguage.get("tab.pselect.column.totalCost"), "Decimal"),
		  new DataObjectDescriptor("defaultProjectOfferedPrice", "defaultProject.OFFEREDPRICE", UILanguage.get("tab.pselect.column.offeredPrice"), "Decimal"),
		  new DataObjectDescriptor("defaultProjectLocation", "defaultProject.LOCATION", UILanguage.get("tab.pselect.column.location"), "Text"),
		  new DataObjectDescriptor("defaultProjectCountry", "defaultProject.COUNTRY", UILanguage.get("tab.pselect.column.country"), "Text"),
		  new DataObjectDescriptor("defaultProjectState", "defaultProject.STATE", UILanguage.get("tab.pselect.column.stateProvince"), "Text"),
		  new DataObjectDescriptor("defaultProjectClient", "defaultProject.CLIENT", UILanguage.get("tab.pselect.column.client"), "Text"),
		  new DataObjectDescriptor("userId", "projectUser.USERID", "Project User Id", "Text"),
		  new DataObjectDescriptor("userName", "projectUser.UNAME", "Project User Name", "Text"),
		  new DataObjectDescriptor("userEmail", "projectUser.EMAIL", "Project User Email", "Text"),
		  new DataObjectDescriptor("userXchange", "projectUser.XCHANGE", "Project User Xchange ", "Boolean"),
		  new DataObjectDescriptor("userEsclte", "projectUser.ESCLTE", "Project User Esclte", "Boolean"),
		  new DataObjectDescriptor("userProps", "projectUser.PROPS", "Project User Properties", "Boolean"),
		  new DataObjectDescriptor("userTakeoff", "projectUser.TAKEOFF", "Project User Takeoff ", "Boolean"),
		  new DataObjectDescriptor("userRSRC", "projectUser.RSRC", "Project User RSRC", "Boolean"),
		  new DataObjectDescriptor("userEstimator", "projectUser.ESTIM", "Project User Estimator", "Boolean"),
		  new DataObjectDescriptor("userAdmin", "projectUser.ADMN", "Project User Admin", "Boolean"),
		  new DataObjectDescriptor("userSQuote", "projectUser.SQUOTE", "Project User Squote ", "Boolean"),
		  new DataObjectDescriptor("userRQuote", "projectUser.RQUOTE", "Project User RQUOTE", "Boolean"),
		  new DataObjectDescriptor("userAQuote", "projectUser.AQUOTE", "Project User AQUOTE", "Boolean"),
		  new DataObjectDescriptor("userWbs", "projectUser.WBS", "Project User wbs", "Boolean"),
		  new DataObjectDescriptor("userAditms", "projectUser.ADITMS", "Project User Aditms", "Boolean"),
		  new DataObjectDescriptor("userRditms", "projectUser.RMITMS", "Project User Ritms", "Boolean"),
		  new DataObjectDescriptor("userEditms", "projectUser.EDITMS", "Project User Editms", "Boolean"),
		  new DataObjectDescriptor("userVaitms", "projectUser.VAITMS", "Project User Vditms", "Boolean"),
		  new DataObjectDescriptor("userVarSusr", "projectUser.VARSUSR", "Project User VarUSR", "Boolean"),
		  new DataObjectDescriptor("userVarsAdmin", "projectUser.VARSADMIN", "Project User VARSADMIN", "Boolean")
	  };

	  public static ProjectEPSWithUsersViewDescriptor Instance
	  {
		  get
		  {
			if (s_instance == null)
			{
			  s_instance = new ProjectEPSWithUsersViewDescriptor();
			}
			return s_instance;
		  }
	  }

	  public override DataObjectDescriptor[] All
	  {
		  get
		  {
			  return this.ALL_FIELDS;
		  }
	  }

	  public override string ViewName
	  {
		  get
		  {
			  return null;
		  }
	  }
	}


	/* Location:              C:\Users\TomJames_zyl8law\Lightos\Lightos Hub - Documents\01-Clients\CostOS\Solution from Java Source Code\common\!\nomitech\common\data\descriptor\ProjectEPSWithUsersViewDescriptor.class
	 * Java compiler version: 8 (52.0)
	 * JD-Core Version:       1.0.7
	 */
}