
namespace Models.local.Interfaces
{
	public interface IAlcGroups
	{
		System.Guid Id { get; set; }
		string Code { get; set; }
		string Description { get; set; }
		
		AlcGroups Clone();
	}
}
