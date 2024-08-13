using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.State;
using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.BookChapter
{
	public partial class Index
	{
		[Inject] public ILogger<Index>? Logger { get; set; }
		[Inject] public IBookChapterState? bookChapterState { get; set; }

		protected string _err = string.Empty;
		protected string _msg = string.Empty;

		public BookAndChapter? CurrentBookAndChapter { get; set; }

		protected override void OnInitialized()
		{
			Logger!.LogInformation("{Class}!{Method}", nameof(Index), nameof(OnInitialized));
			try
			{
				BibleBookIdAndChapter bibleBookIdAndChapter = bookChapterState!.Get();
				CurrentBookAndChapter = new BookAndChapter(BibleBook.FromValue(bibleBookIdAndChapter.BibleBookId), bibleBookIdAndChapter.Chapter);

				//int i = 1; int j = 0; int k = i/j;
			}
			catch (Exception ex)
			{
				Logger!.LogError(ex, "{Class}!{Method}", nameof(Index), nameof(OnInitialized));
				//Logger!.LogError("{Class}!{Method}: {Type} Message: {Message}", nameof(Index), nameof(OnInitialized), ex.GetType(), ex.Message);
			}
		}

		protected string? ReturnedBookAndChapterString;

		private void ReturnedBookAndChapter(BookAndChapter bookAndChapter)  //async Task
		{
			ReturnedBookAndChapterString = bookAndChapter.ToString();
			CurrentBookAndChapter = bookAndChapter!;
			bookChapterState!.Update(new BibleBookIdAndChapter(CurrentBookAndChapter.BibleBook!.Value, CurrentBookAndChapter.Chapter));
		}

	}
}