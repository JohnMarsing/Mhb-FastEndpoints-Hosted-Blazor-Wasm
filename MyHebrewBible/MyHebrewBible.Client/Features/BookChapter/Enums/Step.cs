using Ardalis.SmartEnum;
namespace MyHebrewBible.Client.Features.BookChapter.Enums;

public abstract class Step : SmartEnum<Step>
{

	#region Id's
	private static class Id
{
	internal const int ChapterHundred = 1;
	internal const int ChapterTen = 2;
	internal const int ChapterOne = 3;
	internal const int VerseHundred = 4;
	internal const int VerseTen = 5;
	internal const int VerseOne = 6;
	internal const int FinishAndReturnBCV = 7;
	}
#endregion

#region  Declared Public Instances
	public static readonly Step ChapterHundred = new ChapterHundredSE();
	public static readonly Step ChapterTen = new ChapterTenSE();
	public static readonly Step ChapterOne = new ChapterOneSE();
	public static readonly Step VerseHundred = new VerseHundredSE();
	public static readonly Step VerseTen = new VerseTenSE();
	public static readonly Step VerseOne = new VerseOneSE();
	public static readonly Step FinishAndReturnBCV = new FinishAndReturnBCVSE();
	// SE=SmartEnum
	#endregion

	private Step(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract Phase Phase { get; }
	public abstract Direction? DirectionForward { get; }
	public abstract Direction? DirectionBackward { get; }
	public abstract string PlaceShortName { get; }   

//Properties

	#endregion


	#region Private Instantiation

	private sealed class ChapterHundredSE : Step
	{
		public ChapterHundredSE() : base($"{nameof(Id.ChapterHundred)}", Id.ChapterHundred) { }
		public override Phase Phase => Phase.Chapter;
		public override Direction? DirectionForward => Direction.GoToNextStep;  
		public override Direction? DirectionBackward => null;
		public override string PlaceShortName => "h";
	}

	private sealed class ChapterTenSE : Step
	{
		public ChapterTenSE() : base($"{nameof(Id.ChapterTen)}", Id.ChapterTen) { }
		public override Phase Phase => Phase.Chapter;
		public override Direction? DirectionForward => Direction.GoToNextStep; 
		public override Direction? DirectionBackward => Direction.GoToPreviousStep;
		public override string PlaceShortName => "t";
	}

	private sealed class ChapterOneSE : Step
	{
		public ChapterOneSE() : base($"{nameof(Id.ChapterOne)}", Id.ChapterOne) { }
		public override Phase Phase => Phase.Chapter;
		public override Direction? DirectionForward => Direction.GoToSecondPhase;   
		public override Direction? DirectionBackward => Direction.GoToPreviousStep;
		public override string PlaceShortName => "o";
	}

	private sealed class VerseHundredSE : Step
	{
		public VerseHundredSE() : base($"{nameof(Id.VerseHundred)}", Id.VerseHundred) { }
		public override Phase Phase => Phase.Verse;
		public override Direction? DirectionForward => Direction.GoToNextStep; 
		public override Direction? DirectionBackward => Direction.GoToPreviousStep; //.GoToPreviousPlace;
		public override string PlaceShortName => "h";
	}

	private sealed class VerseTenSE : Step
	{
		public VerseTenSE() : base($"{nameof(Id.VerseTen)}", Id.VerseTen) { }
		public override Phase Phase => Phase.Verse;
		public override Direction? DirectionForward => Direction.GoToNextStep;
		public override Direction? DirectionBackward => Direction.GoToPreviousStep;
		public override string PlaceShortName => "t";
	}

	private sealed class VerseOneSE : Step
	{
		public VerseOneSE() : base($"{nameof(Id.VerseOne)}", Id.VerseOne) { }
		public override Phase Phase => Phase.Verse;
		public override Direction? DirectionForward => Direction.FinishAndReturnBCV;
		public override Direction? DirectionBackward => Direction.GoToPreviousStep;
		public override string PlaceShortName => "o";
	}

	private sealed class FinishAndReturnBCVSE : Step
	{
		public FinishAndReturnBCVSE() : base($"{nameof(Id.FinishAndReturnBCV)}", Id.FinishAndReturnBCV) { }
		public override Phase Phase => Phase.Verse;
		public override Direction? DirectionForward => Direction.FinishAndReturnBCV;
		public override Direction? DirectionBackward => Direction.GoToPreviousStep;
		public override string PlaceShortName => "o";
	}

	#endregion
}