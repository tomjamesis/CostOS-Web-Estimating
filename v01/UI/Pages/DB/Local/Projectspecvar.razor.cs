using Models.DB.Local;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Radzen;

namespace UI.Pages.DB.Local
{
    public class ProjectspecvarBase : ComponentBase
    {
        protected IList<Models.DB.Local.ProjectSpecVar> projectspecvar = null;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                //projectspecvar = await GetProjectspecvarAsync();
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
