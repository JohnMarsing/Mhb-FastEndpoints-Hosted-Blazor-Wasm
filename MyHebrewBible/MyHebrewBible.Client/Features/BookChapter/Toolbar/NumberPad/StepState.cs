using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.BookChapter.Enums;
using MyHebrewBible.Client.HealthChecks;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class StepState
{
	// this is initialized by one of the three chapter phases
	public StepState(BibleBook? bibleBook)
	{
		BibleBook = bibleBook;
		Chapter = 0; // not defined
		CurrentPhase = Enums.Phase.Chapter;
		if (bibleBook!.ChapterHundreds > 0)
		{
			StartupStep = Step.ChapterHundred;
		}
		else
		{
			if (bibleBook!.ChapterTens > 0)
			{
				StartupStep = Step.ChapterTen;
			}
			else
			{
				StartupStep = Step.ChapterOne;
			}
		}
		// during CTOR, CurrentStep = StartupStep;
		CurrentStep = StartupStep;
	}

	private BibleBook? BibleBook { get; set; } // 
	public int Chapter { get; set; } //
	public Step? StartupStep { get; set; }   // 
	public Step? CurrentStep { get; set; }
	public Phase? CurrentPhase { get; set; }

	public void ChangePhase()
	{
		CurrentPhase = CurrentPhase == Phase.Chapter ? Phase.Verse : Phase.Chapter;
	}


	public void ChangeCurrentStep(Direction newDirection)
	{
		switch (newDirection)
		{
			case Direction.GoToNextStep:
				CurrentStep = Step.FromValue(CurrentStep!.Value + 1);
				//CurrentStep = CurrentStep.DirectionForward;
				break;

			case Direction.GoToPreviousStep:
				CurrentStep = Step.FromValue(CurrentStep!.Value - 1);
				break;

			case Direction.GoToSecondPhase:
				if (Chapter == 0)
				{
					throw new ArgumentException("Chapter cannot be zero when changing to the second phase.");
				}

				//bibleBook!.LastVerses[chapter - 1];
				int lastVerse = LastVerseHelper.GetLastVerse(BibleBook, Chapter);

				if (lastVerse >= 100) // 100 or more
				{
					CurrentStep = Step.VerseHundred;
				}
				else if (lastVerse >= 10) // 10 or more
				{
					CurrentStep = Step.VerseTen;
				}
				else // less than 10
				{
					CurrentStep = Step.VerseOne;
				}	
				break;

			case Direction.FinishAndReturnBCV:
				// ToDo: what do I do here?
				break;

			default:
				break;
		}
	}


	/*
	// the only place that may not be visible is the Hundred (Chapter of Verse)
	public bool IsPlaceVisible
	{
		get
		{

			//return CurrentStep!.Phase == Phase.Chapter
			//? StartupStep != Step.ChapterHundred
			//: StartupStep != Step.VerseHundred;
		}
	}

	// This is set by 
	public bool IsPlaceDisabled { get; set; }

	public bool IsZeroButtonDisabled
	{
		get
		{
			//return CurrentStep!.Phase == Phase.Chapter
			//? StartupStep != Step.ChapterHundred
			//: StartupStep != Step.VerseHundred;
		}
	}

	*/
}