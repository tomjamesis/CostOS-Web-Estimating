using Models.DB.Project;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Radzen;

namespace UI.Pages.DB.Project
{
    public class QueryresourceBase : ComponentBase
    {
        protected IList<Models.DB.Project.Queryresource> queryresources = null;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                //queryresources = await GetQueryResourcesAsync();
            }
            catch (Exception ae)
            {
                ae.Message.ToString();
                if (ae.InnerException != null) _ = ae.InnerException.Message.ToString();
            }
            return;
        }
    }
}
