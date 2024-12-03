using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Components;

public record BookAndChapter(BibleBook? BibleBook, int Chapter);

public static class Helper
{
	public static int LastVerseCount(BibleBook? BibleBook, int chapter)
	{
		return BibleBook!.LastVerses[chapter - 1];
	}

	public static string GetNavigateToUrl(BibleBook? bibleBook, int chapter) 
	{
		return $"BookChapter/{bibleBook!.Value}/{chapter}/{bibleBook!.Abrv}-{chapter}";
	}

	public static string GetNavigateToUrlVerseList(BibleBook? bibleBook, int chapter, int begVerse, int endVerse)
	{
		return $"VerseList/{bibleBook!.Value}/{chapter}/{begVerse}/{endVerse}";
	}

}

