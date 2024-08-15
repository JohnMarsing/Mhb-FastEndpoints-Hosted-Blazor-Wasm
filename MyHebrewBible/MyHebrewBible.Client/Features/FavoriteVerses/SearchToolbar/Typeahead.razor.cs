using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.FavoriteVerses.EnumsFV;
using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.FavoriteVerses.SearchToolbar;

public partial class Typeahead 
{
	protected override void OnInitialized()
	{
		base.OnInitializedAsync();
	}

	private EnumsFV.Verses? SelectedVerse;

	private async Task<IEnumerable<EnumsFV.Verses>> SearchVerses(string searchText)
	{
		return await Task.FromResult(EnumsFV.Verses.List
			.Where(x => x.VerseNameAbrv.ToLower().Contains(searchText.ToLower()))
			.OrderBy(o => o.Value));
	}

	private Type? selectedType;
	private void ButtonClick(Verses verse)
	{
		selectedType = verse.Name?.ToString()?.Length > 0
			? Type.GetType($"MyHebrewBible.Client.Features.FavoriteVerses.DetailContent.{verse.Name}")
			: null;
	}

}