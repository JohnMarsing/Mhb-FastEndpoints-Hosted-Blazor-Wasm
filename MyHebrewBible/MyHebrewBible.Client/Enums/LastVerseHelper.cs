using PlaceEnums = MyHebrewBible.Client.Features.BookChapter.Enums;

namespace MyHebrewBible.Client.Enums;

public class LastVerseHelper
{
	// Called by StepState!ChangeCurrentStep! case Direction.GoToSecondPhase:
	public static int GetLastVerse(BibleBook? bibleBook, int chapter)
	{
		if (bibleBook is null) return 0;
		if (chapter < 1 || chapter > bibleBook.LastChapter) return 0;
		return bibleBook!.LastVerses[chapter - 1];
	}

	// // Called by StepState!LoadPlaceValueRecForVerse
	public static int GetPlace(PlaceEnums.Place place, int lastVerse) 
	{
		if (place == PlaceEnums.Place.Hundreds)
		{
			return lastVerse >= 100 ? lastVerse / 100 : 0;
		}
		else
		{
			if (place == PlaceEnums.Place.Tens)
			{
				return lastVerse >= 10 ? lastVerse / 10 : 0;
			}
			else // PlaceEnums.Place.Ones
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

	// // Called by StepState!LoadPlaceValueRecForVerse
	public static bool GetLastVerseIsWhole(int lastVerse)
	{
		return lastVerse % 10 == 0;
	}

}
