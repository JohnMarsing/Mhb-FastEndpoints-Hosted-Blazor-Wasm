using Microsoft.AspNetCore.Components.QuickGrid;

namespace MyHebrewBible.Client.Features.Parasha;

public partial class Index
{
	IQueryable<Enums.Ahavta>? items; // = Enums.Ahavta.List.ToList().OrderBy(o => o.Value);

	PaginationState pagination = new PaginationState { ItemsPerPage = 10 };

	protected override void OnInitialized()
	{
		items = Enums.Ahavta.List.AsQueryable();
	}
}
