using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.BookChapter.Enums;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class StepState
{

/*  ToDo: how to add a logger   */

	public StepState(BibleBook? bibleBook)
	{
		BibleBook = bibleBook;
		LoadPlaceValueRecForChapter();
		Chapter = 0; // not defined
		CurrentPhase = Enums.Phase.Chapter;
		ChapterHundredIsVisible = bibleBook!.ChapterHundreds > 0;
	}

	private BibleBook? BibleBook { get; set; }

	public int Chapter { get; set; }
	public int Verse { get; set; }
	public Step? CurrentStep { get; set; }
	public Phase? CurrentPhase { get; set; }
	public PlaceValueRec? PlaceValueRec; //{ get; set; } 
	public bool ChapterHundredIsVisible { get; set; } //

	private void LoadPlaceValueRecForChapter()
	{
		if (BibleBook!.ChapterHundreds > 0)
		{
			PlaceValueRec = new PlaceValueRec(BibleBook!.ChapterHundreds, BibleBook!.ChapterTens, BibleBook!.ChapterOnes, BibleBook.ChapterIsWhole);
			CurrentStep = Step.ChapterHundred; ;
		}
		else
		{
			if (BibleBook!.ChapterTens > 0)
			{
				PlaceValueRec = new PlaceValueRec(null, BibleBook!.ChapterTens, BibleBook!.ChapterOnes, BibleBook.ChapterIsWhole);
				CurrentStep = Step.ChapterTen;
			}
			else
			{
				PlaceValueRec = new PlaceValueRec(null, null, BibleBook!.ChapterOnes, BibleBook.ChapterIsWhole);
				CurrentStep = Step.ChapterOne;
			}
		}
	}

	private void LoadPlaceValueRecForVerse()
	{
		if (LastVerse >= 100)  
		{
			PlaceValueRec = new PlaceValueRec(
				LastVerseHelper.GetPlace(Place.Hundreds, LastVerse),
				LastVerseHelper.GetPlace(Place.Tens, LastVerse),
				LastVerseHelper.GetPlace(Place.Ones, LastVerse),
				LastVerseHelper.GetLastVerseIsWhole(LastVerse));
		}
		else
		{
			if (LastVerse >= 10)  
			{
				PlaceValueRec = new PlaceValueRec(
					null,
					LastVerseHelper.GetPlace(Place.Tens, LastVerse),
					LastVerseHelper.GetPlace(Place.Ones, LastVerse),
					LastVerseHelper.GetLastVerseIsWhole(LastVerse));
			}
			else
			{
				PlaceValueRec = new PlaceValueRec(
					null,
					null,
					LastVerseHelper.GetPlace(Place.Ones, LastVerse),
					LastVerseHelper.GetLastVerseIsWhole(LastVerse));
			}
		}
	}

	public int LastVerse = 0;
	public void ChangeCurrentStep(Direction? newDirection, int number = 0)
	{
		switch (newDirection)
		{
			case Direction.GoToNextStep:
				if (CurrentStep == Enums.Step.ChapterHundred || CurrentStep == Enums.Step.VerseHundred)
				{
					PlaceValueRec = PlaceValueRec! with { Hundreds = number };
				}
				else
				{
					PlaceValueRec = PlaceValueRec! with { Tens = number };
				}
				CurrentStep = Step.FromValue(CurrentStep!.Value + 1);
				break;

			case Direction.GoToPreviousStep:
				//ToDo: Finish this
				CurrentStep = Step.FromValue(CurrentStep!.Value - 1);
				break;

			case Direction.GoToSecondPhase:
				PlaceValueRec = PlaceValueRec! with { Ones = number }; // Finish chapter processing
				Chapter = PlaceValueRecHelper.Combine(PlaceValueRec);
				LastVerse = LastVerseHelper.GetLastVerse(BibleBook, Chapter);
				LoadPlaceValueRecForVerse(); //PlaceValueRec = PlaceValueRec.Default;

				if (LastVerse >= 100) // 100 or more
				{
					CurrentStep = Step.VerseHundred;
				}
				else if (LastVerse >= 10) // 10 or more
				{
					CurrentStep = Step.VerseTen;
				}
				else // less than 10
				{
					CurrentStep = Step.VerseOne;
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