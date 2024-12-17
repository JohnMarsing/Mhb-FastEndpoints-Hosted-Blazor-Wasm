using Ardalis.SmartEnum;
using BibleBookEnum = MyHebrewBible.Client.Enums.BibleBook;

namespace MyHebrewBible.Client.CommonVerses.Enums;

public abstract class QuotedVerse : SmartEnum<QuotedVerse>
{

	#region Id's
	private static class Id
	{
		internal const int Deu_06_04 = 1;
		internal const int Deu_17_18_19 = 2;
		internal const int Gen_02_15 = 3;
		internal const int Jam_02_18 = 4;
		internal const int Joh_20_31 = 5;
		internal const int Rev_12_17 = 6;
		internal const int Exo_19_06 = 7;
		internal const int Mat_22_15_22 = 8;
		

	}
	#endregion

	#region  Declared Public Instances
	public static readonly QuotedVerse Deu_06_04 = new Deu_06_04SE();
	public static readonly QuotedVerse Deu_17_18_19 = new Deu_17_18_19SE();
	public static readonly QuotedVerse Gen_02_15 = new Gen_02_15SE();
	public static readonly QuotedVerse Jam_02_18 = new Jam_02_18SE();
	public static readonly QuotedVerse Joh_20_31 = new Joh_20_31SE();
	public static readonly QuotedVerse Rev_12_17 = new Rev_12_17SE();
	public static readonly QuotedVerse Exo_19_06 = new Exo_19_06SE();
	public static readonly QuotedVerse Mat_22_15_22 = new Mat_22_15_22SE();


	#endregion

	private QuotedVerse(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract VerseRange VerseRange { get; }

	public string Title 
	{
		get
		{
			return $"{this.VerseRange.BibleBook.Title} {this.VerseRange.ChapterVerse}";
		}
	}

	#endregion

	#region Private Instantiation

	private sealed class Deu_06_04SE : QuotedVerse
	{
		public Deu_06_04SE() : base($"{nameof(Id.Deu_06_04)}", Id.Deu_06_04) { }
		public override VerseRange VerseRange => new(BibleBookEnum.Deuteronomy, "6:4", 6, 4, 4);
	}

	private sealed class Deu_17_18_19SE : QuotedVerse
	{
		public Deu_17_18_19SE() : base($"{nameof(Id.Deu_17_18_19)}", Id.Deu_17_18_19) { }
		public override VerseRange VerseRange => new(BibleBookEnum.Deuteronomy, "17:18-19", 17, 18, 19);
	}

	private sealed class Gen_02_15SE : QuotedVerse
	{
		public Gen_02_15SE() : base($"{nameof(Id.Gen_02_15)}", Id.Gen_02_15) { }
		public override VerseRange VerseRange => new(BibleBookEnum.Genesis, "2:15", 2, 15, 15);
	}

	private sealed class Jam_02_18SE : QuotedVerse
	{
		public Jam_02_18SE() : base($"{nameof(Id.Jam_02_18)}", Id.Jam_02_18) { }
		public override VerseRange VerseRange => new(BibleBookEnum.James, "2:18", 2, 18, 18);
	}
	
	private sealed class Joh_20_31SE : QuotedVerse
	{
		public Joh_20_31SE() : base($"{nameof(Id.Joh_20_31)}", Id.Joh_20_31) { }
		public override VerseRange VerseRange => new(BibleBookEnum.John, "20:31", 20, 31, 31);
	}

	private sealed class Rev_12_17SE : QuotedVerse
	{
		public Rev_12_17SE() : base($"{nameof(Id.Rev_12_17)}", Id.Rev_12_17) { }
		public override VerseRange VerseRange => new(BibleBookEnum.Revelation, "12:17", 12, 17, 17);
	}

	private sealed class Exo_19_06SE : QuotedVerse
	{
		public Exo_19_06SE() : base($"{nameof(Id.Exo_19_06)}", Id.Exo_19_06) { }
		public override VerseRange VerseRange => new(BibleBookEnum.Exodus, "19:6", 19, 6, 6);
	}

	private sealed class Mat_22_15_22SE : QuotedVerse
	{
		public Mat_22_15_22SE() : base($"{nameof(Id.Mat_22_15_22)}", Id.Mat_22_15_22) { }
		public override VerseRange VerseRange => new(BibleBookEnum.Matthew, "22:15-22", 22, 15, 22);
	}

	//

	#endregion
}
// Ignore Spelling: Deu Joh