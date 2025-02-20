using MyHebrewBible.Client.Enums;
using AlephTavEnums = MyHebrewBible.Client.Features.AlephTav.Enums;

namespace MyHebrewBible.Client.Components;

public record BookAndChapter(BibleBook? BibleBook, int Chapter);

public static class Helper
{
	public static int LastVerseCount(BibleBook? BibleBook, int chapter)
	{
		return BibleBook!.LastVerses[chapter - 1];
	}

	public static string GetNavigateToUrlVerseList(BibleBook? bibleBook, int chapter, int begVerse, int endVerse)
	{
		return $"VerseList/{bibleBook!.Value}/{chapter}/{begVerse}/{endVerse}";
	}

	public static List<AlephTavEnums.ChapterVerse>? GetSatVerseList(BibleBook? bibleBook, int chapter) // Sat=Standalone Aleph Tav 
	{
		if (bibleBook is null) { return null;		}

		if (bibleBook.IsHebrewBible)
		{
			AlephTavEnums.BookChaptersVerses? bibleBookWithSATs;
			if (AlephTavEnums.BookChaptersVerses.TryFromValue(bibleBook!.Value, out bibleBookWithSATs))
			{
				return bibleBookWithSATs.Verses!.Where(w => w.Chapter == chapter).ToList();
			}
			else
			{
			return null;
			}
		}
		else
		{
			return null;
		}

	}

}

