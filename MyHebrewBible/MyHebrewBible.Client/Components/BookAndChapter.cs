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

	// Used by only by: Features!VerseList!Index!ReNavigateBackToThisPage()
	// - MyHebrewBible.Client\Features\VerseList\Index.razor	153  
	// 
	public static string GetNavigateToUrlVerseList(BibleBook? bibleBook, int chapter, int begVerse, int endVerse)
	{
		return $"VerseList/{bibleBook!.Value}/{chapter}/{begVerse}/{endVerse}";
	}

}




 
