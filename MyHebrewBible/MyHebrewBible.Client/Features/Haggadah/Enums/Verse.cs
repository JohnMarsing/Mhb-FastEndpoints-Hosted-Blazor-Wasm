using Ardalis.SmartEnum;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.Haggadah.Enums;

//

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

	private sealed class Eze_36_24_to_25 : Verse
	{
		public Eze_36_24_to_25() : base("Eze_36_24_to_25", 2) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Ezekiel, 36, 24, 25);	
	}

	private sealed class Gal_05_22_to_23 : Verse
	{
		public Gal_05_22_to_23() : base("Gal_05_22_to_23", 3) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Galatians, 5, 22, 23);
	}

	private sealed class Hos_01_09_to_10 : Verse
	{
		public Hos_01_09_to_10() : base("Hos_01_09_to_10", 4) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Hosea, 1, 9, 10);	
	}

	private sealed class Hos_02_11_to_12 : Verse
	{
		public Hos_02_11_to_12() : base("Hos_02_11_to_12", 5) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Hosea, 2, 11, 12);
	}

	private sealed class Hos_14_04_to_5 : Verse
	{
		public Hos_14_04_to_5() : base("Hos_14_04_to_5", 6) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Hosea, 14, 4, 5);
	}

	private sealed class Isa_11_12_to_13 : Verse
	{
		public Isa_11_12_to_13() : base("Isa_11_12_to_13", 7) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Isaiah, 11, 12, 13);	
	}

	private sealed class Isa_11_16 : Verse
	{
		public Isa_11_16() : base("Isa_11_16", 8) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Isaiah, 11, 16, 16);
	}

	private sealed class Jam_01_25 : Verse
	{
		public Jam_01_25() : base("Jam_01_25", 9) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.James, 1, 25, 25);	
	}

	private sealed class Jer_03_18 : Verse
	{
		public Jer_03_18() : base("Jer_03_18", 10) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Jeremiah, 3, 18, 18);
	}

	private sealed class Jer_12_15 : Verse
	{
		public Jer_12_15() : base("Jer_12_15", 11) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Jeremiah, 12, 15, 15);
	}

	private sealed class Jer_16_14_to_15 : Verse
	{
		public Jer_16_14_to_15() : base("Jer_16_14_to_15", 12) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 16, 14, 15);
	}

	private sealed class Jer_31_07_to_08 : Verse
	{
		public Jer_31_07_to_08() : base("Jer_31_07_to_08", 13) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Jeremiah, 31, 7, 8);
	}

	private sealed class Jer_31_20 : Verse
	{
		public Jer_31_20() : base("Jer_31_20", 14) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 31, 20, 20);
	}

	private sealed class Jer_31_31_to_34 : Verse
	{
		public Jer_31_31_to_34() : base("Jer_31_31_to_34", 15) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 31, 31, 34);
	}

	private sealed class Jer_50_04_to_05 : Verse
	{
		public Jer_50_04_to_05() : base("Jer_50_04_to_05", 16) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.Jeremiah, 50, 4, 5);
	}

	private sealed class Jer_50_19 : Verse
	{
		public Jer_50_19() : base("Jer_50_19", 17) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Jeremiah, 50, 19, 19);
	}

	private sealed class Joh_06_35: Verse
	{
		public Joh_06_35() : base("Joh_06_35", 18) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.John, 6, 35, 35);
	}

	private sealed class Joh_06_38 : Verse
	{
		public Joh_06_38() : base("Joh_06_38", 19) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.John, 6, 38, 38);
	}

	private sealed class Joh_06_51 : Verse
	{
		public Joh_06_51() : base("Joh_06_51", 20) { }
		public override VerseRecord VerseRecord => new  VerseRecord(BibleBook.John, 6, 51, 51);	
	}

	private sealed class Lev_20_7_to_8 : Verse
	{
		public Lev_20_7_to_8() : base("Lev_20_7_to_8", 21) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Leviticus, 20, 7, 8);	
	}

	private sealed class Luk_22_19_to_20 : Verse
	{
		public Luk_22_19_to_20() : base("Luk_22_19_to_20", 22) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Luke, 22, 19, 20);
	}

	private sealed class FirstKi_12_16 : Verse
	{
		public FirstKi_12_16() : base("FirstKi_12_16", 23) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstKings, 12, 16, 16);	
	}

	private sealed class FirstKi_12_19 : Verse
	{
		public FirstKi_12_19() : base("FirstKi_12_19", 24) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstKings, 12, 19, 19);
	}

	private sealed class FirstKi_12_24 : Verse
	{
		public FirstKi_12_24() : base("FirstKi_12_24", 25) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstKings, 12, 24, 24);
	}

	private sealed class FirstPe_01_14_to_15 : Verse
	{
		public FirstPe_01_14_to_15() : base("FirstPe_01_14_to_15", 26) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstPeter, 1, 14, 15);
	}

	private sealed class FirstPe_02_10 : Verse
	{
		public FirstPe_02_10() : base("FirstPe_02_10", 27) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.FirstPeter, 2, 10, 10);
	}

	private sealed class Psa_119_12_to_16 : Verse
	{
		public Psa_119_12_to_16() : base("Psa_119_12_to_16", 28) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Psalms, 119, 12, 16);
	}

	private sealed class Psa_78_09_to_11 : Verse
	{
		public Psa_78_09_to_11() : base("Psa_78_09_to_11", 29) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Psalms, 78, 9, 11);
	}

	private sealed class Rev_05_09_to_10 : Verse
	{
		public Rev_05_09_to_10() : base("Rev_05_09_to_10", 30) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Revelation, 5, 9, 10);
	}

	private sealed class Rev_22_17 : Verse
	{
		public Rev_22_17() : base("Rev_22_17", 31) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Revelation, 22, 17, 17);
	}

	private sealed class Rev_22_20 : Verse
	{
		public Rev_22_20() : base("Rev_22_20", 32) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Revelation, 22, 20, 20);
	}

	private sealed class SecondKi_14_26 : Verse
	{
		public SecondKi_14_26() : base("SecondKi_14_26", 33) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.SecondKings, 14, 26, 26);
	}

	private sealed class Zec_10_06 : Verse
	{
		public Zec_10_06() : base("Zec_10_06", 34) { }
		public override VerseRecord VerseRecord => new VerseRecord(BibleBook.Zechariah, 10, 6, 6);
	}

	#endregion
}
