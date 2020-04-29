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
	public class WsDataMappingsService
	{
		private ProjectContext projectContext;

		public WsDataMappingsService(ProjectContext dbContext)
		{
			projectContext = dbContext;
		}

		public async Task<long> WsDataMappingCount()
		{
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				return await projectContext.WsDataMapping.CountAsync();
			}
			catch (Exception ae)
			{
				Log.WriteLine(ae.Message);
				if (ae.InnerException != null) Log.WriteLine(ae.InnerException.ToString());
			}
			return -1;
		}

		public async Task<IList<Models.DB.Project.WsDataMapping>> GetAllWsDataMappings()
		{
			IList<Models.DB.Project.WsDataMapping> WsDataMappings = new List<Models.DB.Project.WsDataMapping>();
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				IList<Models.DB.Project.WsDataMapping> wsDataMappings = await projectContext.WsDataMapping.ToListAsync();
				return wsDataMappings;
			}
			catch (Exception ae)
			{
				Log.WriteLine(ae.Message);
				if (ae.InnerException != null) Log.WriteLine(ae.InnerException.ToString());
			}
			return null;
		}
		public async Task<long> CreateWsDataMapping(List<Models.DB.Project.WsDataMapping> WsDataMappings)
		{
			long returnid = -1;
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				foreach (Models.DB.Project.WsDataMapping wsDataMapping in WsDataMappings)
				{
					projectContext.WsDataMapping.Add(wsDataMapping);
					await projectContext.SaveChangesAsync();
					returnid = wsDataMapping.Id;
				}
			}
			catch (Exception ae)
			{
				Log.WriteLine(ae.Message);
				if (ae.InnerException != null) Log.WriteLine(ae.InnerException.ToString());
			}
			return returnid;
		}

		public async Task<bool> UpdateWsDataMapping(long id, Models.DB.Project.WsDataMapping wsDataMapping)
		{
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				projectContext.WsDataMapping.Update(wsDataMapping);
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
		public async Task<bool> DeleteWsDataMapping(long wsDataMappingId)
		{
			try
			{
				if (projectContext == null) projectContext = new ProjectContext();
				Models.DB.Project.WsDataMapping wsDataMapping = projectContext.WsDataMapping.First(p => p.Id == wsDataMappingId);
				projectContext.WsDataMapping.Remove(wsDataMapping);
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
