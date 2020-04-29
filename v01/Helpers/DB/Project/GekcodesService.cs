using Diagnostics.Logger;
using Microsoft.EntityFrameworkCore;
using Models.DB.Project;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helper.DB.Project
{
	public class GekcodesService
	{
		private ProjectContext projectContext;

		public GekcodesService(ProjectContext dbContext)
		{
			projectContext = dbContext;
		}

		public async Task<long> GekcodeCount()
		{
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				return await projectContext.Gekcode.CountAsync();
			}
			catch (Exception ae)
			{
				Log.WriteLine(ae.Message);
				if (ae.InnerException != null) Log.WriteLine(ae.InnerException.ToString());
			}
			return -1;
		}

		public async Task<IList<Models.DB.Project.Gekcode>> GetAllGekcodes()
		{
			IList<Models.DB.Project.Gekcode> Gekcodes = new List<Models.DB.Project.Gekcode>();
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				IList<Models.DB.Project.Gekcode> gekcodes = await projectContext.Gekcode.ToListAsync();
				return gekcodes;
			}
			catch (Exception ae)
			{
				Log.WriteLine(ae.Message);
				if (ae.InnerException != null) Log.WriteLine(ae.InnerException.ToString());
			}
			return null;
		}
		public async Task<long> CreateGekcode(List<Models.DB.Project.Gekcode> Gekcodes)
		{
			long returnid = -1;
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				foreach (Models.DB.Project.Gekcode gekcode in Gekcodes)
				{
					projectContext.Gekcode.Add(gekcode);
					await projectContext.SaveChangesAsync();
					returnid = gekcode.Gekcodeid;
				}
			}
			catch (Exception ae)
			{
				Log.WriteLine(ae.Message);
				if (ae.InnerException != null) Log.WriteLine(ae.InnerException.ToString());
			}
			return returnid;
		}

		public async Task<bool> UpdateGekcode(long id, Models.DB.Project.Gekcode gekcode)
		{
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				projectContext.Gekcode.Update(gekcode);
				await projectContext.SaveChangesAsync();
				return true;
			}
			catch (Exception ae)
			{
				Log.WriteLine(ae.Message);
				if (ae.InnerException != null) Log.WriteLine(ae.InnerException.ToString());
			}
			return false;
		}
		public async Task<bool> DeleteGekcode(long gekcodeId)
		{
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				Models.DB.Project.Gekcode gekcode = projectContext.Gekcode.First(p => p.Gekcodeid == gekcodeId);
				projectContext.Gekcode.Remove(gekcode);
				await projectContext.SaveChangesAsync();
				return true;
			}
			catch (Exception ae)
			{
				Log.WriteLine(ae.Message);
				if (ae.InnerException != null) Log.WriteLine(ae.InnerException.ToString());
			}
			return false;
		}
	}
}
