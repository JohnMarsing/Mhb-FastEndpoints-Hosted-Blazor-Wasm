using MyHebrewBible.Client.Enums;
using AlephTavEnums = MyHebrewBible.Client.Features.AlephTav.Enums;
using MyHebrewBible.Client.Helpers;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

/* Triennial.cs

public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "2:4-3-24", 35, 80);

public override List<VerseRange> BritVerses => [
		new VerseRange(BibleBook.John, "1:6-28", 26051, 26073),
		new VerseRange(BibleBook.Romans, "5:12-21", 28060, 28069),
		new VerseRange(BibleBook.Hebrews, "11:1-7", 30174, 30180),];

*/
public record VerseRange(BibleBook BibleBook, string ChapterVerse, long	BegId, long EndId);

/*
ToDo: Not used, should this whole class / record be deleted after `Triennial.cs` is refactored?
public static class Helper
{
	public static List<AlephTavEnums.ChapterVerse>? GetSatVerseList(VerseRange verseRange) // Sat=Standalone Aleph Tav 
	{
		if (verseRange.BibleBook <= VerseFacts.LastBookInOT)
		{
			AlephTavEnums.BookChaptersVerses? bibleBookWithSATs;
			if (AlephTavEnums.BookChaptersVerses.TryFromValue(verseRange.BibleBook!.Value, out bibleBookWithSATs))
			{
				//return bibleBookWithSATs.Verses!.Where(w => w.Chapter == chapter).ToList();
				return bibleBookWithSATs.Verses!.Where(w => w.Chapter == 1).ToList();
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
*/