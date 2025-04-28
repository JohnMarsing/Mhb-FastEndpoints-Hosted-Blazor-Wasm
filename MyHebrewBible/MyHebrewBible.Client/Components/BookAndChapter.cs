using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Components;

public record BookAndChapter(BibleBook? BibleBook, int Chapter);

public static class Helper
{
	// Used by only by: MyHebrewBible.Client\Components\BibleLookup\Toolbar\Verses\VerseModal.razor
	public static int LastVerseCount(BibleBook? BibleBook, int chapter)
	{
		return BibleBook!.LastVerses[chapter - 1];
	}

	public static bool HasPrevious(BibleBook bibleBook)
	{
		return bibleBook.Value != BookChapterFacts.FirstBook;
	}

	public static bool HasNext(BibleBook bibleBook)
	{
		return bibleBook.Value != BookChapterFacts.LastBook;
	}


	public static string PreviousText(BibleBook bibleBook)
	{
		if (bibleBook != BookChapterFacts.FirstBook)
		{
			return bibleBook.Title;

		}
		else
		{
			return string.Empty;
		}
	}


	// Used by only by: Features!VerseList!Index!ReNavigateBackToThisPage()
	// - MyHebrewBible.Client\Features\VerseList\Index.razor	153  
	// 
	public static string GetNavigateToUrlVerseList(BibleBook? bibleBook, int chapter, int begVerse, int endVerse)
	{
		return $"VerseList/{bibleBook!.Value}/{chapter}/{begVerse}/{endVerse}";
	}

}




 
