using MyHebrewBible.Client.Helpers;
using BibleBookEnum = MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class Helper
{

	public static string GetButtonClassEmpty()
	{
		return $"btn {BtnOutlineColors.Secondary} disabled {fontType} {fontSize} {Helper.colPadding}";
	}

	public static string GetButtonClassEmptyNoColor()
	{
		return $"btn {fontType} {fontSize} {Helper.colPadding}";
	}

	public static string GetDefaultButtonClass(bool small = false)
	{
		return $"{fontType} {(small ? fontSizeSmall : fontSize)}";
	}


	public static string GetDisabledColor()
	{
		return BtnOutlineColors.Secondary;
	}

	public static string GetButtonColor(int lastChapterIsWhole)
	{
		//return lastChapterIsWhole==0 ? BtnOutlineColors.Info : BtnOutlineColors.Primary;
		return lastChapterIsWhole == 0 ? BtnOutlineColors.Primary : BtnOutlineColors.Info;
		//return lastChapterIsWhole == 0 ? BtnColors.Primary : BtnColors.Info;
	}

	const string fontType = "font-monospace";
	const string fontSize = "fs-4";
	const string fontSizeSmall = "fs-5";


	//public const string rowPadding = "mb-1";
	//public const string colPadding = "me-1";
	public const string rowPadding = "";
	public const string colPadding = "";


	#region LastVerse
	//Imported from what was called LastVerseHelper

	// Called by StepState!ChangeCurrentStep! case Direction.GoToSecondPhase:
	public static int GetLastVerse(BibleBookEnum.BibleBook? bibleBook, int chapter)
	{
		if (bibleBook is null) return 0;
		if (chapter < 1 || chapter > bibleBook.LastChapter) return 0;
		return bibleBook!.LastVerses[chapter - 1];
	}

	#region ToDo Create Common Modulus Function
	// Called (7 times) by StepState!LoadPlaceValueRecForVerse

	public static int GetPlace(Enums.Place place, int lastVerse)
	{
		if (place == Enums.Place.Hundreds)
		{
			return lastVerse >= 100 ? lastVerse / 100 : 0;
		}
		else
		{
			if (place == Enums.Place.Tens)
			{
				return lastVerse >= 10 ? (lastVerse / 10) % 10 : 0;
			}
			else // PlaceEnums.Place.Ones
			{
				if (lastVerse >= 100)
				{
					return lastVerse % 10;
				}
				else
				{
					if (lastVerse >= 10)
					{
						return lastVerse % 10;
					}
					else
					{
						return lastVerse;
					}
				}
			}
		}
	}
	#endregion

	// Called by StepState!LoadPlaceValueRecForVerse
	public static bool GetLastVerseIsWhole(int lastVerse)
	{
		return lastVerse % 10 == 0;
	}

	#endregion
}