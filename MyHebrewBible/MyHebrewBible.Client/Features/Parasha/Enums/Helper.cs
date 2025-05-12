using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

public class Helper
{
	//public static class Transform	{ }

	// ZBA = Zero Based Arrays
	// OBA = One Based Arrays	
	// TransformTriennialToBCV
	// TransformTriennialToMenuHierachy
	public static (int, int) CalculateChapterAndVerse(BibleBook bibleBook, int begId)
	{
		int runningTotal = SumPriorLastVerses(bibleBook);  // Where(w => w.Value < bibleBook.Value))

		int lvIndexZBA = 0;
		foreach (var lastVerse in bibleBook.LastVerses)
		{
			runningTotal += lastVerse;
			if (runningTotal < begId)
			{
				lvIndexZBA += 1;
			}
			else
			{
				break;
			}
		}
		int chapter = lvIndexZBA + 1;
		int lastVerseValue = bibleBook.LastVerses[lvIndexZBA];
		int verse = begId - runningTotal + lastVerseValue;

		return (chapter, verse);
	}

	private static int SumPriorLastVerses(BibleBook bibleBook)
	{
		int i = 0;
		foreach (var book in BibleBook.List.Where(w => w.Value < bibleBook.Value))
		{
			i += book.LastVerses.Sum();
		}
		return i;
	}



}
