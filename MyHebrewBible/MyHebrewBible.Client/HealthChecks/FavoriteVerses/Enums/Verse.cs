using Ardalis.SmartEnum;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.HealthChecks.FavoriteVerses.Enums;

public abstract class Verse : SmartEnum<Verse>
{
	#region Id's
	private static class Id
	{
		//ToDo: instead of having a dumb key for the value what if it was the calculated BegId
		internal const int Genesis_01_01 = 1;
		internal const int Genesis_02_02 = 33;
		internal const int Genesis_50_26 = 1533;
		internal const int Exodus_01_01 = 1534;
		internal const int Exodus_02_02 = 1557;
		internal const int Exodus_40_38 = 2746;
		internal const int Leviticus_01_01 = 2747;
		internal const int Leviticus_02_02 = 2765;
		internal const int FirstSamuel_08_07 = 7377;
		internal const int Psalms_122_001 = 16091;
		/* */
	}
	#endregion

	#region  Declared Public Instances
	public static readonly Verse Gen_01_01 = new Gen_01_01SE();
	public static readonly Verse Gen_02_02 = new Gen_02_02SE();
	public static readonly Verse Gen_50_26 = new Gen_50_26SE();
	public static readonly Verse Exo_01_01 = new Exo_01_01SE();
	public static readonly Verse Exo_02_02 = new Exo_02_02SE();
	public static readonly Verse Exo_40_38 = new Exo_40_38SE(); 
	public static readonly Verse Lev_01_01 = new Lev_01_01SE();
	public static readonly Verse Lev_02_02 = new Lev_02_02SE();
	public static readonly Verse FirstSamuel_08_07 = new FirstSamuel_08_07SE();
	public static readonly Verse Psalms_122_001 = new Psalms_122_001SE();
	#endregion


	private Verse(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract VerseRecord VerseRecord { get; }
	#endregion

	#region Private Instantiation
	private sealed class Gen_01_01SE : Verse
	{
		public Gen_01_01SE() : base($"{nameof(Id.Genesis_01_01)}", Id.Genesis_01_01) { }
		public override VerseRecord VerseRecord => new(BibleBook.Genesis, 1, 1, 1);
	}
	private sealed class Gen_02_02SE : Verse
	{
		public Gen_02_02SE() : base($"{nameof(Id.Genesis_02_02)}", Id.Genesis_02_02) { }
		public override VerseRecord VerseRecord => new (BibleBook.Genesis, 2, 2, 3);
	}
	private sealed class Gen_50_26SE : Verse
	{
		public Gen_50_26SE() : base($"{nameof(Id.Genesis_50_26)}", Id.Genesis_50_26) { }
		public override VerseRecord VerseRecord => new (BibleBook.Genesis, 50, 26, 36);
	}

	private sealed class Exo_01_01SE : Verse
	{
		public Exo_01_01SE() : base($"{nameof(Id.Exodus_01_01)}", Id.Exodus_01_01) { }
		public override VerseRecord VerseRecord => new (BibleBook.Exodus, 1, 1, 1);
	}
	private sealed class Exo_02_02SE : Verse
	{
		public Exo_02_02SE() : base($"{nameof(Id.Exodus_02_02)}", Id.Exodus_02_02) { }
		public override VerseRecord VerseRecord => new (BibleBook.Exodus, 2, 2, 3);
	}
	private sealed class Exo_40_38SE : Verse
	{
		public Exo_40_38SE() : base($"{nameof(Id.Exodus_40_38)}", Id.Exodus_40_38) { }
		public override VerseRecord VerseRecord => new (BibleBook.Exodus, 40, 38, 38);
	}

	private sealed class Lev_01_01SE : Verse
	{
		public Lev_01_01SE() : base($"{nameof(Id.Leviticus_01_01)}", Id.Leviticus_01_01) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Leviticus, 1, 1, 1);
	}
	private sealed class Lev_02_02SE : Verse
	{
		public Lev_02_02SE() : base($"{nameof(Id.Leviticus_02_02)}", Id.Leviticus_02_02) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Leviticus, 2, 2, 3);
	}
	private sealed class FirstSamuel_08_07SE : Verse
	{
		public FirstSamuel_08_07SE() : base($"{nameof(Id.FirstSamuel_08_07)}", Id.FirstSamuel_08_07) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstSamuel, 8, 7, 7);
	}
	private sealed class Psalms_122_001SE : Verse
	{
		public Psalms_122_001SE() : base($"{nameof(Id.Psalms_122_001)}", Id.Psalms_122_001) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Psalms, 122, 1, 9);
	}

	//
	#endregion
}