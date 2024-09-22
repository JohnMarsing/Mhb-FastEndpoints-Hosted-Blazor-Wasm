using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Components;

public record BookAndChapter(BibleBook? BibleBook, int Chapter);


public static class Helper
{
	public static int LastVerseCount(BibleBook? BibleBook, int chapter)
	{
		return BibleBook!.LastVerses[chapter - 1];
	}
}

