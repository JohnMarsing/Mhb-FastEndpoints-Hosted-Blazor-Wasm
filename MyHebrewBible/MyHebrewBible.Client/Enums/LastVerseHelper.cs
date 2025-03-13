using PaceEnums = MyHebrewBible.Client.Features.BookChapter.Enums;

namespace MyHebrewBible.Client.Enums;

public class LastVerseHelper
{
	public static int GetLastVerse(BibleBook? bibleBook, int chapter)
	{
		if (bibleBook is null) return 0;
		if (chapter < 1 || chapter > bibleBook.LastChapter) return 0;
		return bibleBook!.LastVerses[chapter - 1];
	}

	public static int GetPlace(PaceEnums.Place place, int lastVerse) 
	{
		if (place == PaceEnums.Place.Hundreds)
		{
			return lastVerse >= 100 ? lastVerse / 100 : 0;
		}
		else
		{
			if (place == PaceEnums.Place.Tens)
			{
				return lastVerse >= 10 ? lastVerse / 10 : 0;
			}
			else // PaceEnums.Place.Ones
			{
				if (lastVerse >= 100)
				{
					return lastVerse % 100;
				}
				else
				{
					if (lastVerse >= 10)
					{
						return (lastVerse % 10);
					}
					else
					{
						return lastVerse;
					}
				}
			}
		}

	}

	public static bool GetLastVerseIsWhole(int lastVerse)
	{
		return lastVerse % 10 == 0;
	}

}
