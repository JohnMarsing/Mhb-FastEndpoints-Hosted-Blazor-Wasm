namespace MyHebrewBible.Client.Features.BookChapter.Enums;


public class StepHelper
{
	public static string CssDisabled(Step step, int maxButtons)
	{
		if (step.MayNotBeVisible) return "disabled";
		return "";
	}

	// The 0 button is disabled when 
	public static bool IsZeroButtonDisabled(Step? step)
	{
		//if (step.) return true;
		//return false;


		if (step!.Phase == Phase.Chapter)
		{
			if (step! == Step.ChapterHundred)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		else  // (step!.Phase == Phase.Verse
		{
			if (step! == Step.VerseHundred)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

	}


	// the only place that may not be visible is the Hundred (Chapter of Verse)
	public static bool IsPlaceVisible(Step step) // , Place place
	{
		//if (step.MayNotBeVisible) return "disabled";
		return false;
		//return CurrentStep!.Phase == Phase.Chapter
		//	? StartupStep != Step.ChapterHundred
		//	: StartupStep != Step.VerseHundred;
	}


}
