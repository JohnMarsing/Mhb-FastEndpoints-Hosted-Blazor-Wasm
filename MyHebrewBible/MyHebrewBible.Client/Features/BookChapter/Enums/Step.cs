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
}
#endregion

#region  Declared Public Instances
	public static readonly Step ChapterHundred = new ChapterHundredSE();
	public static readonly Step ChapterTen = new ChapterTenSE();
	public static readonly Step ChapterOne = new ChapterOneSE();
	public static readonly Step VerseHundred = new VerseHundredSE();
	public static readonly Step VerseTen = new VerseTenSE();
	public static readonly Step VerseOne = new VerseOneSE();
	// SE=SmartEnum
	#endregion

	private Step(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields

	// true for `Chapter*` false for `Verse*`
	//public abstract bool IsChapter { get; }
	public abstract Phase Phase { get; }
	
	public abstract Direction? DirectionForward { get; }
	public abstract Direction? DirectionBackward { get; }

	// true for `ChapterHundred` or `VerseHundred` 
	public abstract bool MayNotBeVisible { get; } 

	// maybe this is a property that works with HasParent and HasChild???
	public abstract bool CanGoBack { get; }
	public abstract bool CanGoForward { get; }

	// see Features.BookChapter.Enums SmartEnum<Place> ;
	//public abstract bool HasParent { get; }
	//public abstract bool HasChild { get; }

	// 3x4 except for for `ChapterHundred` or `VerseHundred`
	public abstract int Columns { get; } // 3
	public abstract int Rows { get; }    // 4

	//Properties


	#endregion


	#region Private Instantiation

	private sealed class ChapterHundredSE : Step
	{
		public ChapterHundredSE() : base($"{nameof(Id.ChapterHundred)}", Id.ChapterHundred) { }
		//public override bool HasParent => false;
		//public override bool HasChild => true;
		//public override bool IsChapter => true;
		
		public override Phase Phase => Phase.Chapter;
		public override Direction? DirectionForward => Direction.GoToNextStep;  
		public override Direction? DirectionBackward => null;

		public override bool MayNotBeVisible => true;
		public override bool CanGoBack => false;
		public override bool CanGoForward => true;
		public override int Columns => 1;
		public override int Rows => 2;
	}

	private sealed class ChapterTenSE : Step
	{
		public ChapterTenSE() : base($"{nameof(Id.ChapterTen)}", Id.ChapterTen) { }
		//public override bool HasParent => true;
		//public override bool HasChild => true;
		//public override bool IsChapter => true;

		public override Phase Phase => Phase.Chapter;
		public override Direction? DirectionForward => Direction.GoToNextStep; 
		public override Direction? DirectionBackward => Direction.GoToPreviousStep; 

		public override bool MayNotBeVisible => false;
		public override bool CanGoBack => true;
		public override bool CanGoForward => true;
		public override int Columns => 3;
		public override int Rows => 4;
	}

	private sealed class ChapterOneSE : Step
	{
		public ChapterOneSE() : base($"{nameof(Id.ChapterOne)}", Id.ChapterOne) { }
		//public override bool HasParent => false;
		//public override bool HasChild => true;
		//public override bool IsChapter => true;

		public override Phase Phase => Phase.Chapter;
		public override Direction? DirectionForward => Direction.GoToSecondPhase;   
		public override Direction? DirectionBackward => Direction.GoToPreviousStep; 

		public override bool MayNotBeVisible => false;
		public override bool CanGoBack => true;
		public override bool CanGoForward => false; // Action Change to IsVerse
		public override int Columns => 3;
		public override int Rows => 4;
	}

	private sealed class VerseHundredSE : Step
	{
		public VerseHundredSE() : base($"{nameof(Id.VerseHundred)}", Id.VerseHundred) { }
		//public override bool HasParent => false;
		//public override bool HasChild => true;
		//public override bool IsChapter => false;

		public override Phase Phase => Phase.Verse;
		public override Direction? DirectionForward => Direction.GoToNextStep; 
		public override Direction? DirectionBackward => Direction.GoToPreviousStep; //.GoToPreviousPlace;

		public override bool MayNotBeVisible => true;
		public override bool CanGoBack => false;
		public override bool CanGoForward => true;
		public override int Columns => 1;
		public override int Rows => 2;
	}

	private sealed class VerseTenSE : Step
	{
		public VerseTenSE() : base($"{nameof(Id.VerseTen)}", Id.VerseTen) { }
		//public override bool HasParent => false;
		//public override bool HasChild => true;
		//public override bool IsChapter => false;

		public override Phase Phase => Phase.Verse;
		public override Direction? DirectionForward => Direction.GoToNextStep;
		public override Direction? DirectionBackward => Direction.GoToPreviousStep; 

		public override bool MayNotBeVisible => false;
		public override bool CanGoBack => true;
		public override bool CanGoForward => true;
		public override int Columns => 3;
		public override int Rows => 4;
	}

	private sealed class VerseOneSE : Step
	{
		public VerseOneSE() : base($"{nameof(Id.VerseOne)}", Id.VerseOne) { }
		//public override bool HasParent => false;
		//public override bool HasChild => true;
		//public override bool IsChapter => false;

		public override Phase Phase => Phase.Verse;
		public override Direction? DirectionForward => Direction.FinishAndReturnBCV;
		public override Direction? DirectionBackward => Direction.GoToPreviousStep;

		public override bool MayNotBeVisible => false;
		public override bool CanGoBack => true;
		public override bool CanGoForward => false; // Action ReturnBCV
		public override int Columns => 3;
		public override int Rows => 4;
	}

	#endregion
}