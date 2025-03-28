using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public record BookChapterVerse(BibleBook? BibleBook, int Chapter, int Verse);

public static class BookChapterVerseHelper
{
	public static string Dump(BookChapterVerse? BCV)
	{
		return $"{BCV!.BibleBook!.Abrv} {BCV.Chapter}:{BCV.Verse}";
	}
}
// Ignore Spelling: BCV	
