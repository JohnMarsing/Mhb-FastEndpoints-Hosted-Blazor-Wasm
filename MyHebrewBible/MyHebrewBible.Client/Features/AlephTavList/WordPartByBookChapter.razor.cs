using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using MyHebrewBible.Client.Components;

namespace MyHebrewBible.Client.Features.AlephTavList;

public partial class WordPartByBookChapter
{
	[Inject] public ILogger<WordPartByBookChapter>? Logger { get; set; }
	[Inject] public ApiClient? Api { get; set; }
	[Inject] public IToastService? Toast { get; set; }

	[Parameter, EditorRequired] public BookAndChapter? BookAndChapter { get; set; }

	private ICollection<AlephTavHebrewVerse>? DetailWordList = null;
	private List<SummaryVM>? SummaryVerseList;

	protected override async Task OnParametersSetAsync()
	{
		try
		{
			DetailWordList = await Api!.GetAlephTavHebrewVersesAsync(BookAndChapter!.BibleBook!.Value, BookAndChapter!.Chapter);

			SummaryVerseList = DetailWordList
				.GroupBy(d => new { d.BCV, d.ScriptureID, d.Chapter, d.Verse, d.HasTwo })
				.Select(g => new SummaryVM(
						g.Key.ScriptureID,
						g.Key.BCV,
						g.Key.Chapter,
						g.Key.Verse,
						g.Key.HasTwo,
						g.Count() // This gives us the RowCnt, which is the count of rows grouped by BCV and Id
				))
				.ToList();
		}
		catch (Exception ex)
		{
			Logger!.LogError(ex, "{Class}!{Method}", nameof(WordPartByBookChapter), nameof(OnParametersSetAsync));
			Toast!.ShowError($"{Global.ToastShowError} {nameof(WordPartByBookChapter)}!{nameof(OnParametersSetAsync)}");
		}
	}
}