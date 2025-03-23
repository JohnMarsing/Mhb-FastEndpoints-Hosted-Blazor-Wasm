using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad.Enums;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class StepState
{

/*  ToDo: how to add a logger   */

	public StepState(BibleBook? bibleBook)
	{
		BibleBook = bibleBook;
		LoadPlaceValueRecForChapter();
		Chapter = 0;
		Phase = Enums.Phase.Chapter;
		HundredPlaceIsVisible = bibleBook!.ChapterHundreds > 0;
	}

	private BibleBook? BibleBook { get; set; }

	public int Chapter { get; set; }
	public Step? Step { get; set; }
	public Phase? Phase { get; set; }
	public PlaceValueRec? PlaceValueRec; //{ get; set; } 
	public bool HundredPlaceIsVisible { get; set; } //
	public int LastChapter = 0;

	private void LoadPlaceValueRecForChapter()
	{
		if (BibleBook!.ChapterHundreds > 0)
		{
			PlaceValueRec = new PlaceValueRec(BibleBook!.ChapterHundreds, BibleBook!.ChapterTens, BibleBook!.ChapterOnes, BibleBook.ChapterIsWhole, "XXX");
			Step = Step.ChapterHundred; ;
		}
		else
		{
			if (BibleBook!.ChapterTens > 0)
			{
				PlaceValueRec = new PlaceValueRec(null, BibleBook!.ChapterTens, BibleBook!.ChapterOnes, BibleBook.ChapterIsWhole, "XX");
				Step = Step.ChapterTen;
			}
			else
			{
				PlaceValueRec = new PlaceValueRec(null, null, BibleBook!.ChapterOnes, BibleBook.ChapterIsWhole, "X");
				Step = Step.ChapterOne;
			}
		}
		LastChapter = BibleBook.LastChapter;
	}

	private static string GetPlaceMask(int count)
	{
		return new string('X', count); //  PlaceValueRec!.Count
	}

	private void LoadPlaceValueRecForVerse()
	{
		if (LastVerse >= 100)  
		{
			PlaceValueRec = new PlaceValueRec(
				Helper.GetPlace(Place.Hundreds, LastVerse),
				Helper.GetPlace(Place.Tens, LastVerse),
				Helper.GetPlace(Place.Ones, LastVerse),
				Helper.GetLastVerseIsWhole(LastVerse), "XXX");
		}
		else
		{
			if (LastVerse >= 10)  
			{
				PlaceValueRec = new PlaceValueRec(
					null,
					Helper.GetPlace(Place.Tens, LastVerse),
					Helper.GetPlace(Place.Ones, LastVerse),
					Helper.GetLastVerseIsWhole(LastVerse), "XX");
			}
			else
			{
				PlaceValueRec = new PlaceValueRec(
					null,
					null,
					Helper.GetPlace(Place.Ones, LastVerse),
					Helper.GetLastVerseIsWhole(LastVerse), "X");
			}
		}

	}

	public int LastVerse = 0;
	public void ChangeCurrentStep(Direction? newDirection, int number = 0)
	{
		switch (newDirection)
		{
			case Direction.GoToNextStep:
				if (Step == Enums.Step.ChapterHundred || Step == Enums.Step.VerseHundred)
				{
					PlaceValueRec = PlaceValueRec! with { Hundreds = number, Mask=$"{number}XX" };
				}
				else
				{
					PlaceValueRec = PlaceValueRec! with { Tens = number, Mask = $"{PlaceValueRec.Hundreds}{number}X" };
				}
				Step = Step.FromValue(Step!.Value + 1);
				break;

			case Direction.GoToPreviousStep:
				//ToDo: Finish this
				Step = Step.FromValue(Step!.Value - 1);
				break;

			case Direction.GoToSecondPhase:
				PlaceValueRec = PlaceValueRec! with { Ones = number, Mask = "X" }; // Finish chapter processing
				Chapter = PlaceValueRecHelper.Combine(PlaceValueRec);
				LastVerse = Helper.GetLastVerse(BibleBook, Chapter);
				LoadPlaceValueRecForVerse();
				//Verse = PlaceValueRecHelper.Combine(PlaceValueRec);

				if (LastVerse >= 100) // 100 or more
				{
					Step = Step.VerseHundred;
				}
				else if (LastVerse >= 10) // 10 or more
				{
					Step = Step.VerseTen;
				}
				else // less than 10
				{
					Step = Step.VerseOne;
				}

				break;


			// ToDo: this never actually gets called 
			case Direction.FinishAndReturnBCV:
				//public int Verse { get; set; } // ToDo: this is actually never used
				//Verse = number;
				break;

			default:
				break;
		}
	}


}