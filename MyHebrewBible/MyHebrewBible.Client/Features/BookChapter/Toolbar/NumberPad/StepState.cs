using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad.Enums;
//using Microsoft.Extensions.Logging;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class StepState
{
	//private readonly ILogger<StepState> Logger; // _logger
	private readonly ILogger<ButtonWrapper> Logger; // _logger

	public StepState(BibleBook? bibleBook, ILogger<ButtonWrapper> logger)  //, ILogger<StepState> logger
	{
		BibleBook = bibleBook;
		Logger = logger;
		LoadPlaceValueRecForChapter();
		Chapter = 0;
		//Phase = Enums.Phase.Chapter;
		HundredPlaceIsVisible = bibleBook!.ChapterHundreds > 0;
	}

	private BibleBook? BibleBook { get; set; }

	public int Chapter { get; set; }
	public Step? Step { get; set; }
	//public Phase? Phase { get; set; } // Use StepState.Step.Place
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


	#region Commands

	public void UpdatePlaceValueRecForHundreds(int number)
	{
		PlaceValueRec = PlaceValueRec! with { Hundreds = number, Mask = $"{number}XX" };
	}

	public void UpdatePlaceValueRecForTens(int number)
	{
		PlaceValueRec = PlaceValueRec! with { Tens = number, Mask = $"{PlaceValueRec.Hundreds}{number}X" };
	}
	public void UpdateOnesPlaceValueRecAndSetChapter(int onesNumber)
	{
		UpdatePlaceValueRecForOnes(onesNumber);
		SetChapter();
	}

	public void UpdatePlaceValueRecForOnes(int number)
	{
		PlaceValueRec = PlaceValueRec! with { Ones = number, Mask = "X" };
	}

	private void SetChapter() => Chapter = PlaceValueRecHelper.Combine(PlaceValueRec!);

	public int LastVerse = 0;  // private int LastVerse = 0;
	public void SetLastVerse()
	{
		/*	
		LastVerse =  bibleBook!.LastVerses[chapter - 1];
		*/
		LastVerse = Helper.GetLastVerse(BibleBook, Chapter); 
		Logger!.LogInformation("{Method}, LastVerse: {LastVerse}", nameof(SetLastVerse), LastVerse);
	}

	public void SetNextStepForSecondPhase()
	{
		if (LastVerse >= 100)
		{
			Step = Step.VerseHundred;
		}
		else
		{
			if (LastVerse >= 10)
			{
				Step = Step.VerseTen;
			}
			else
			{
				Step = Step.VerseOne;
			}
		}

		Logger!.LogInformation("{Method}, LastVerse: {LastVerse}, new Step: {Step}"
			, nameof(SetNextStepForSecondPhase), LastVerse, Step.Name);
	}
	
	public void LoadPlaceValueRecForVerse()
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
		//SetNextStepForSecondPhase();
	}



	public int GetVerse()
	{
		return PlaceValueRecHelper.Combine(PlaceValueRec!);
	}

	public void SetNextStepNoPhaseChange()
	{
		Step = Step.FromValue(Step!.Value + 1);
	}


	/*
	public void SetStep(Enums.TensSpecialCase tensSpecialCase)
	{
		if (tensSpecialCase == TensSpecialCase.SkipChapterOnes)
		{
			Step = Step.FromValue(Step!.Value + 1);
		}

		if (tensSpecialCase == TensSpecialCase.SkipVerseOnes)
		{
		if (LastVerse >= 100) { Step = Step.VerseHundred; }
		else if (LastVerse >= 10) { Step = Step.VerseTen; }
		else { Step = Step.VerseOne; }
		}
		if (tensSpecialCase == TensSpecialCase.Finished) //None
		{

		}
	}
	*/

	#endregion

	public string Dump()
	{
		//return $"Step: {Step?.Name}, Phase: {Phase}, PlaceValueRec: {PlaceValueRec?.Mask}, Chapter: {Chapter}, LastVerse: {LastVerse}";
		//string s = PlaceValueRecHelper.Concatenate(PlaceValueRec!);
		//return s;
		return PlaceValueRecHelper.Concatenate(PlaceValueRec!);
	}

	public string Dump2()
	{
		string s = "";

		if (Step!.Phase == Phase.Chapter)
		{
			if (LastChapter != 0) { s += "LC: " + LastChapter; }
		}

		if (Step!.Phase == Phase.Verse)
		{
			if (LastVerse != 0) { s += "LV: " + LastVerse; }
		}
																
		s += $", IsWhole: {(PlaceValueRec!.IsWhole ? "T" : "F")} "; 


		return s;
	}

	/*
	public void ChangeCurrentStep(Direction? newDirection, int number = 0)
	{
		switch (newDirection)
		{
			case Direction.GoToNextStep:
				if (Step == Enums.Step.ChapterHundred || Step == Enums.Step.VerseHundred)  //if (Step.Place == Enums.Place.Tens)
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
	*/

	/*
	private static string GetPlaceMask(int count)
	{
		return new string('X', count); //  PlaceValueRec!.Count
	}
	*/
}