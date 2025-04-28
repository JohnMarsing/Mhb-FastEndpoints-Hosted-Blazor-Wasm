//using Microsoft.AspNetCore.Components;
using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad.Enums;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class StepState
{
	//ToDo:	THIS IS CONFUSING, Why do I need to configure ILogger as <ButtonWrapper> why can't I use <StepState>?
	// 
	//private readonly ILogger<StepState> Logger; // _logger
	private readonly ILogger<ButtonWrapper> Logger; // _logger
	//[Inject] public ILogger<StepState>? Logger { get; set; }

	//public StepState(BibleBook? bibleBook)
	//public StepState(BibleBook? bibleBook, ILogger<StepState> logger)  
	public StepState(BibleBook? bibleBook, ILogger<ButtonWrapper> logger) 
	{
		BibleBook = bibleBook;
		Logger = logger;

		// ToDo: TaskHPS I need to something different for Psalms
		//   LoadPlaceValueRecForHundreds or something???
		LoadPlaceValueRecForChapter();
		
		Chapter = 0;

		if (bibleBook!.ChapterHundreds > 0)
		{
			HundredsPlaceState = new HundredsPlaceState(IsChosen: false, IsOneHundredOrMore:false); // IsVisible: true, 
			HundredToggleButtonIsVisible = true;
		}
		else
		{
			HundredsPlaceState = new HundredsPlaceState(IsChosen: false, IsOneHundredOrMore: false); // IsVisible: false, 
			HundredToggleButtonIsVisible = false;
		}
	}

	private BibleBook? BibleBook { get; set; }

	public int Chapter { get; set; }
	public Step? Step { get; set; }
	public PlaceValueRec? PlaceValueRec; //{ get; set; } 
	public HundredsPlaceState HundredsPlaceState; //{ get; set; } 

	public bool HundredToggleButtonIsVisible { get; set; }

	public int LastChapter = 0;

	private void LoadPlaceValueRecForChapter()
	{
		if (BibleBook!.ChapterHundreds > 0) // only if Psalms
		{
			// ToDo: TaskHPS this needs work, should I use something like HundredsPlaceState???
			//                                                          , BibleBook!.ChapterTens   , BibleBook.ChapterIsWhole
			PlaceValueRec = new PlaceValueRec(BibleBook!.ChapterHundreds, 9, BibleBook!.ChapterOnes, false, "XXX");
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

	public void UpdatePlaceValueRecForHundreds(bool isHundredsOrMore)
	{
		HundredsPlaceState = HundredsPlaceState! with { IsChosen = true, IsOneHundredOrMore = isHundredsOrMore };
		int number = (isHundredsOrMore ? 1 : 0);	
		PlaceValueRec = PlaceValueRec! with { Hundreds = number, Mask = $"{number}XX" };
		HundredToggleButtonIsVisible = false;
	}

	public void UpdatePlaceValueRecForTens(int number)
	{
		//Logger!.LogInformation("{Method}, number: {number}", nameof(UpdatePlaceValueRecForTens), number);
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
		LastVerse = Helper.GetLastVerse(BibleBook, Chapter); 
		Logger!.LogInformation("{Method}, LastVerse: {LastVerse}", nameof(SetLastVerse), LastVerse);
	}

	public void SetNextStepForSecondPhase()
	{
		if (LastVerse >= 100)
		{
			Step = Step.VerseHundred;
			HundredToggleButtonIsVisible = true;
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
			HundredToggleButtonIsVisible = false;
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
		
	}

	public int GetVerse()
	{
		return PlaceValueRecHelper.Combine(PlaceValueRec!);
	}

	public int GetVerseShortCircuit()
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


}