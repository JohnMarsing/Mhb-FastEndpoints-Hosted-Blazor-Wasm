using Ardalis.SmartEnum;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.Haggadah.Enums;



public abstract class Verse : SmartEnum<Verse>
{
	#region Id's
	private static class Id
	{
		//internal const int Gen_1_1 = 1;
	}
	#endregion

	#region  Declared Public Instances

	public static readonly Verse Deu_08_10 = new Deu_08_10SE();
	public static readonly Verse Eze_36_24_to_25 = new Eze_36_24_to_25SE();
	public static readonly Verse Eze_37_15_to_23 = new Eze_37_15_to_23SE();
	public static readonly Verse Gal_05_22_to_23 = new Gal_05_22_to_23SE();
	public static readonly Verse Hos_01_09_to_10 = new Hos_01_09_to_10SE();
	public static readonly Verse Hos_02_11_to_12 = new Hos_02_11_to_12SE();
	public static readonly Verse Hos_14_04_to_5 = new Hos_14_04_to_5SE();
	public static readonly Verse Isa_11_12_to_13 = new Isa_11_12_to_13SE();
	public static readonly Verse Isa_11_16 = new Isa_11_16SE();
	public static readonly Verse Jam_01_25 = new Jam_01_25SE();
	public static readonly Verse Jer_03_18 = new Jer_03_18SE();
	public static readonly Verse Jer_12_15 = new Jer_12_15SE();
	public static readonly Verse Jer_16_14_to_15 = new Jer_16_14_to_15SE();
	public static readonly Verse Jer_31_07_to_08 = new Jer_31_07_to_08SE();
	public static readonly Verse Jer_31_19 = new Jer_31_19SE();
	public static readonly Verse Jer_31_20 = new Jer_31_20SE();
	public static readonly Verse Jer_31_31_to_33 = new Jer_31_31_to_33SE();
	public static readonly Verse Jer_50_04_to_05 = new Jer_50_04_to_05SE();
	public static readonly Verse Jer_50_19 = new Jer_50_19SE();
	public static readonly Verse Joh_06_35 = new Joh_06_35SE();
	public static readonly Verse Joh_06_38 = new Joh_06_38SE();
	public static readonly Verse Joh_06_51 = new Joh_06_51SE();
	public static readonly Verse Lev_20_7_to_8 = new Lev_20_7_to_8SE();
	public static readonly Verse Luk_22_19_to_20 = new Luk_22_19_to_20SE();
	public static readonly Verse FirstKings_12_16 = new FirstKings_12_16SE();
	public static readonly Verse FirstKings_12_19 = new FirstKings_12_19SE();
	public static readonly Verse FirstKings_12_24 = new FirstKings_12_24SE();
	public static readonly Verse FirstPeter_01_14_to_15 = new FirstPeter_01_14_to_15SE();
	public static readonly Verse FirstPeter_02_10 = new FirstPeter_02_10SE();
	public static readonly Verse Psa_119_12_to_16 = new Psa_119_12_to_16SE();
	public static readonly Verse Psa_78_09_to_11 = new Psa_78_09_to_11SE();
	public static readonly Verse Rev_05_09_to_10 = new Rev_05_09_to_10SE();
	public static readonly Verse Rev_22_17 = new Rev_22_17SE();
	public static readonly Verse Rev_22_20 = new Rev_22_20SE();
	public static readonly Verse SecondKings_14_26 = new SecondKings_14_26SE();
	public static readonly Verse Zec_10_06 = new Zec_10_06SE();


	#endregion

	private Verse(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract VerseRecord VerseRecord { get; }
	#endregion

	#region Private Instantiation

	private sealed class Deu_08_10SE : Verse
	{
		public Deu_08_10SE() : base("Deu_08_10", 1) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Deuteronomy, 8, 10, 10);
	}

	private sealed class Eze_36_24_to_25SE : Verse
	{
		public Eze_36_24_to_25SE() : base("Eze_36_24_to_25", 2) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Ezekiel, 36, 24, 25);	
	}

	private sealed class Eze_37_15_to_23SE : Verse
	{
		public Eze_37_15_to_23SE() : base("Eze_37_15_to_23", 9999) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Ezekiel, 37, 15, 23);
	}

	private sealed class Gal_05_22_to_23SE : Verse
	{
		public Gal_05_22_to_23SE() : base("Gal_05_22_to_23", 3) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Galatians, 5, 22, 23);
	}

	private sealed class Hos_01_09_to_10SE : Verse
	{
		public Hos_01_09_to_10SE() : base("Hos_01_09_to_10", 4) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Hosea, 1, 9, 10);	
	}

	private sealed class Hos_02_11_to_12SE : Verse
	{
		public Hos_02_11_to_12SE() : base("Hos_02_11_to_12", 5) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Hosea, 2, 11, 12);
	}

	private sealed class Hos_14_04_to_5SE : Verse
	{
		public Hos_14_04_to_5SE() : base("Hos_14_04_to_5", 6) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Hosea, 14, 4, 5);
	}

	private sealed class Isa_11_12_to_13SE : Verse
	{
		public Isa_11_12_to_13SE() : base("Isa_11_12_to_13", 7) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Isaiah, 11, 12, 13);	
	}

	private sealed class Isa_11_16SE : Verse
	{
		public Isa_11_16SE() : base("Isa_11_16", 8) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Isaiah, 11, 16, 16);
	}

	private sealed class Jam_01_25SE : Verse
	{
		public Jam_01_25SE() : base("Jam_01_25", 9) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.James, 1, 25, 25);	
	}

	private sealed class Jer_03_18SE : Verse
	{
		public Jer_03_18SE() : base("Jer_03_18", 10) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Jeremiah, 3, 18, 18);
	}

	private sealed class Jer_12_15SE : Verse
	{
		public Jer_12_15SE() : base("Jer_12_15", 11) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Jeremiah, 12, 15, 15);
	}

	private sealed class Jer_16_14_to_15SE : Verse
	{
		public Jer_16_14_to_15SE() : base("Jer_16_14_to_15", 12) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 16, 14, 15);
	}

	private sealed class Jer_31_07_to_08SE : Verse
	{
		public Jer_31_07_to_08SE() : base("Jer_31_07_to_08", 13) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Jeremiah, 31, 7, 8);
	}

	private sealed class Jer_31_19SE : Verse
	{
		public Jer_31_19SE() : base("Jer_31_19", 999) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 31, 19, 19);
	}

	private sealed class Jer_31_20SE : Verse
	{
		public Jer_31_20SE() : base("Jer_31_20", 14) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 31, 20, 20);
	}

	private sealed class Jer_31_31_to_33SE : Verse
	{
		public Jer_31_31_to_33SE() : base("Jer_31_31_to_33", 15) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 31, 31, 33);
	}

	private sealed class Jer_50_04_to_05SE : Verse
	{
		public Jer_50_04_to_05SE() : base("Jer_50_04_to_05", 16) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Jeremiah, 50, 4, 5);
	}

	private sealed class Jer_50_19SE : Verse
	{
		public Jer_50_19SE() : base("Jer_50_19", 17) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 50, 19, 19);
	}

	private sealed class Joh_06_35SE: Verse
	{
		public Joh_06_35SE() : base("Joh_06_35", 18) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.John, 6, 35, 35);
	}

	private sealed class Joh_06_38SE : Verse
	{
		public Joh_06_38SE() : base("Joh_06_38", 19) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.John, 6, 38, 38);
	}

	private sealed class Joh_06_51SE : Verse
	{
		public Joh_06_51SE() : base("Joh_06_51", 20) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.John, 6, 51, 51);	
	}

	private sealed class Lev_20_7_to_8SE : Verse
	{
		public Lev_20_7_to_8SE() : base("Lev_20_7_to_8", 21) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Leviticus, 20, 7, 8);
	}

	private sealed class Luk_22_19_to_20SE : Verse
	{
		public Luk_22_19_to_20SE() : base("Luk_22_19_to_20", 22) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Luke, 22, 19, 20);
	}

	private sealed class FirstKings_12_16SE : Verse
	{
		public FirstKings_12_16SE() : base("FirstKings_12_16", 23) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstKings, 12, 16, 16);	
	}

	private sealed class FirstKings_12_19SE : Verse
	{
		public FirstKings_12_19SE() : base("FirstKings_12_19", 24) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstKings, 12, 19, 19);
	}

	private sealed class FirstKings_12_24SE : Verse
	{
		public FirstKings_12_24SE() : base("FirstKings_12_24", 25) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstKings, 12, 24, 24);
	}

	private sealed class FirstPeter_01_14_to_15SE : Verse
	{
		public FirstPeter_01_14_to_15SE() : base("FirstPeter_01_14_to_15", 26) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstPeter, 1, 14, 15);
	}

	private sealed class FirstPeter_02_10SE : Verse
	{
		public FirstPeter_02_10SE() : base("FirstPeter_02_10", 27) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstPeter, 2, 10, 10);
	}

	private sealed class Psa_119_12_to_16SE : Verse
	{
		public Psa_119_12_to_16SE() : base("Psa_119_12_to_16", 28) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Psalms, 119, 12, 16);
	}

	private sealed class Psa_78_09_to_11SE : Verse
	{
		public Psa_78_09_to_11SE() : base("Psa_78_09_to_11", 29) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Psalms, 78, 9, 11);
	}

	private sealed class Rev_05_09_to_10SE : Verse
	{
		public Rev_05_09_to_10SE() : base("Rev_05_09_to_10", 30) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Revelation, 5, 9, 10);
	}

	private sealed class Rev_22_17SE : Verse
	{
		public Rev_22_17SE() : base("Rev_22_17", 31) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Revelation, 22, 17, 17);
	}

	private sealed class Rev_22_20SE : Verse
	{
		public Rev_22_20SE() : base("Rev_22_20", 32) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Revelation, 22, 20, 20);
	}

	private sealed class SecondKings_14_26SE : Verse
	{
		public SecondKings_14_26SE() : base("SecondKings_14_26", 33) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.SecondKings, 14, 26, 26);
	}

	private sealed class Zec_10_06SE : Verse
	{
		public Zec_10_06SE() : base("Zec_10_06", 34) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Zechariah, 10, 6, 6);
	}

	#endregion
}

//Ignore Spelling: Deu, Eze, Gal, Hos, Isa, Jam, Jer, Joh, Lev, Luk, FirstKings, FirstPeter, Psa, Rev, SecondKings, Zec