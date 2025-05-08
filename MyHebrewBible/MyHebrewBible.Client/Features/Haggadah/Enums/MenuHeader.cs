namespace MyHebrewBible.Client.Features.Haggadah.Enums;
using Ardalis.SmartEnum;


public abstract class MenuHeaders : SmartEnum<MenuHeaders>
{
	#region Id's
	private static class Id
	{
		internal const int LanguageChoice = 1; // It's a feature to see this not only in Eng, but also in Esp, or both.  
		internal const int ShowIntroductionSection = 2; // Who is the presenter, what the agenda, what Haggadah mean, 
		internal const int ShowHaggadahOutlineModal = 3; // if shown, then show the progress bar
		internal const int ShowPlaguesAppendix = 4;
		internal const int ShowSummaryAppendix = 5; // What did you learn, key take aways, what about Easter?, what about the Threshold Covenant
		internal const int ShowOriginalInstructionsAppendix = 6;
		internal const int ShowBibleVerseAppendix = 7; // if shown, then list all verses used in the Haggadah
	}
	#endregion

	#region Declared Public Instances
	public static readonly MenuHeaders LanguageChoice = new LanguageChoiceSE();
	public static readonly MenuHeaders ShowIntroductionSection = new ShowIntroductionSectionSE();
	public static readonly MenuHeaders ShowHaggadahOutlineModal = new ShowHaggadahOutlineModalSE();
	public static readonly MenuHeaders ShowBibleVerseAppendix = new ShowBibleVerseAppendixSE();
	#endregion

	private MenuHeaders(string name, int value) : base(name, value) { }

	#region Extra Fields
	public abstract string Header { get; }
	#endregion

	#region Private Instantiation

	private sealed class LanguageChoiceSE : MenuHeaders
	{
		public LanguageChoiceSE() : base(nameof(LanguageChoice), Id.LanguageChoice) { }
		public override string Header => "Language"; 
	}

	private sealed class ShowIntroductionSectionSE : MenuHeaders
	{
		public ShowIntroductionSectionSE() : base(nameof(ShowIntroductionSection), Id.ShowIntroductionSection) { }
		public override string Header => "Introduction";
	}

	private sealed class ShowHaggadahOutlineModalSE : MenuHeaders
	{
		public ShowHaggadahOutlineModalSE() : base(nameof(ShowHaggadahOutlineModal), Id.ShowHaggadahOutlineModal) { }
		public override string Header => "Haggadah Table of Contents";
	}

	private sealed class ShowBibleVerseAppendixSE : MenuHeaders
	{
		public ShowBibleVerseAppendixSE() : base(nameof(ShowBibleVerseAppendix), Id.ShowBibleVerseAppendix) { }
		public override string Header => "Bible Verse Appendix";
	}
	#endregion
}
