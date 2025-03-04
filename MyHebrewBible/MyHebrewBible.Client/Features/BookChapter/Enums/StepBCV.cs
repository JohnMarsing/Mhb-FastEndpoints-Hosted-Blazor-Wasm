using Ardalis.SmartEnum;
namespace MyHebrewBible.Client.Features.BookChapter.Enums;

public abstract class StepBCV : SmartEnum<StepBCV>
{
	#region Id's
	private static class Id
	{
		internal const int NeedBook = 1;
		internal const int NeedChapter = 2;
		internal const int NeedVerse = 3;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly StepBCV NeedBook = new NeedBookSE();
	public static readonly StepBCV NeedChapter = new NeedChapterSE();
	public static readonly StepBCV NeedVerse = new NeedVerseSE();
	// SE=SmartEnum
	#endregion

	private StepBCV(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields

	public abstract int StepNumber { get; }
	public abstract string Heading { get; }
	public abstract string Text { get; }

	#endregion


	#region Private Instantiation

	private sealed class NeedBookSE : StepBCV
	{
		public NeedBookSE() : base($"{nameof(Id.NeedBook)}", Id.NeedBook) { }
		public override int StepNumber => 1;
		public override string Heading => "Book";
		public override string Text => "Select Book";
	}

	private sealed class NeedChapterSE : StepBCV
	{
		public NeedChapterSE() : base($"{nameof(Id.NeedChapter)}", Id.NeedChapter) { }
		public override int StepNumber => 2;
		public override string Heading => "Chapter";
		public override string Text => "Get chapter";
	}

	private sealed class NeedVerseSE : StepBCV
	{
		public NeedVerseSE() : base($"{nameof(Id.NeedVerse)}", Id.NeedVerse) { }
		public override int StepNumber => 3;
		public override string Heading => "Verse";
		public override string Text => "Get verse";
	}
	#endregion
}
/*
	public abstract bool UsedByUI { get; }
	public abstract bool DisplayAsCompleted(StepBCV status);
	public abstract bool DisplayRegistrationToggleButton { get; }
	public abstract string Icon { get; }

			public override bool UsedByUI => true;
		public override string Icon => "fas fa-check";

		public override bool DisplayRegistrationToggleButton => false;

		public override bool DisplayAsCompleted(StepBCV status)
		{
			return status == StepBCV.NeedBook ||
						 //status == StatusBCV.EmailNotConfirmed ||
						 //status == StatusBCV.AgreementNotSigned ||
						 //status == StatusBCV.StartRegistration ||
						 //status == StatusBCV.Payment ||
						 status == StepBCV.NeedChapter;
		}
 
 */
