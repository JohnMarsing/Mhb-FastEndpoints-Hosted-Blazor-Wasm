using Ardalis.SmartEnum;
using MyHebrewBible.Client.Enums;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;

namespace MyHebrewBible.Client.Features.Parasha.Enums;


public abstract class Ahavta : SmartEnum<Ahavta>
{

	#region Id's
	private static class Id
	{
		internal const int Gen_01a = 1;
		internal const int Gen_01b = 2;
		internal const int Gen_02 = 3;
		internal const int Gen_03a = 4;
		internal const int Gen_03b = 5;
		internal const int Gen_05 = 6;
		internal const int Gen_06 = 7;
		internal const int Gen_08a = 8;
		internal const int Gen_08b = 9;
		internal const int Gen_09 = 10;
		internal const int Gen_11 = 11;
		internal const int Gen_12 = 12;
		internal const int Gen_14 = 13;
		internal const int Gen_15 = 14;
		internal const int Gen_16 = 15;
		internal const int Gen_17 = 16;
		internal const int Gen_18 = 17;
		internal const int Gen_19 = 18;
		internal const int Gen_20 = 19;
		internal const int Gen_21 = 20;
		internal const int Gen_22 = 21;
		internal const int Gen_23 = 22;
		internal const int Gen_24a = 23;
		internal const int Gen_24b = 24;
		internal const int Gen_25a = 25;
		internal const int Gen_25b = 26;
		internal const int Gen_26 = 27;
		internal const int Gen_27a = 28;
		internal const int Gen_27b = 29;
		internal const int Gen_28 = 30;
		internal const int Gen_29 = 31;
		internal const int Gen_30 = 32;
		internal const int Gen_31 = 33;
		internal const int Gen_32 = 34;
		internal const int Gen_33 = 35;
		internal const int Gen_35 = 36;
		internal const int Gen_37 = 37;
		internal const int Gen_38 = 38;
		internal const int Gen_39 = 39;
		internal const int Gen_40 = 40;
		internal const int Gen_41a = 41;
		internal const int Gen_41b = 42;
		internal const int Gen_42 = 43;
		internal const int Gen_43 = 44;
		internal const int Gen_44 = 45;
		internal const int Gen_46 = 46;
		internal const int Gen_48 = 47;
		internal const int Gen_49 = 48;
		internal const int Exo_01 = 49;
		internal const int Exo_03 = 50;
		internal const int Exo_04 = 51;
		internal const int Exo_06 = 52;
		internal const int Exo_07 = 53;
		internal const int Exo_08 = 54;
		internal const int Exo_10 = 55;
		internal const int Exo_11 = 56;
		internal const int Exo_12 = 57;
		internal const int Exo_13a = 58;
		internal const int Exo_13b = 59;
		internal const int Exo_15 = 60;
		internal const int Exo_16 = 61;
		internal const int Exo_18 = 62;
		internal const int Exo_19 = 63;
		internal const int Exo_21 = 64;
		internal const int Exo_22 = 65;
		internal const int Exo_24 = 66;
		internal const int Exo_25 = 67;
		internal const int Exo_27a = 68;
		internal const int Exo_27b = 69;
		internal const int Exo_29 = 70;
		internal const int Exo_30a = 71;
		internal const int Exo_30b = 72;
		internal const int Exo_31 = 73;
		internal const int Exo_32 = 74;
		internal const int Exo_34 = 75;
		internal const int Exo_37 = 76;
		internal const int Exo_38 = 77;
		internal const int Exo_39 = 78;
		internal const int Lev_01 = 79;
		internal const int Lev_03 = 80;
		internal const int Lev_04 = 81;
		internal const int Lev_05 = 82;
		internal const int Lev_06 = 83;
		internal const int Lev_07 = 84;
		internal const int Lev_08 = 85;
		internal const int Lev_09 = 86;
		internal const int Lev_12 = 87;
		internal const int Lev_13 = 88;
		internal const int Lev_14 = 89;
		internal const int Lev_15 = 90;
		internal const int Lev_16 = 91;
		internal const int Lev_17 = 92;
		internal const int Lev_18 = 93;
		internal const int Lev_19 = 94;
		internal const int Lev_21 = 95;
		internal const int Lev_22 = 96;
		internal const int Lev_24 = 97;
		internal const int Lev_25a = 98;
		internal const int Lev_25b = 99;
		internal const int Lev_26 = 100;
		internal const int Num_01 = 101;
		internal const int Num_02 = 102;
		internal const int Num_03 = 103;
		internal const int Num_04 = 104;
		internal const int Num_05 = 105;
		internal const int Num_06a = 106;
		internal const int Num_06b = 107;
		internal const int Num_08 = 108;
		internal const int Num_10 = 109;
		internal const int Num_11 = 110;
		internal const int Num_12 = 111;
		internal const int Num_13 = 112;
		internal const int Num_14 = 113;
		internal const int Num_15 = 114;
		internal const int Num_16 = 115;
		internal const int Num_17 = 116;
		internal const int Num_19 = 117;
		internal const int Num_20 = 118;
		internal const int Num_22 = 119;
		internal const int Num_23 = 120;
		internal const int Num_25 = 121;
		internal const int Num_26 = 122;
		internal const int Num_28 = 123;
		internal const int Num_30 = 124;
		internal const int Num_32 = 125;
		internal const int Num_33 = 126;
		internal const int Num_34 = 127;
		internal const int Num_35 = 128;
		internal const int Deu_01 = 129;
		internal const int Deu_02 = 130;
		internal const int Deu_03 = 131;
		internal const int Deu_04 = 132;
		internal const int Deu_05 = 133;
		internal const int Deu_06 = 134;
		internal const int Deu_08 = 135;
		internal const int Deu_09 = 136;
		internal const int Deu_10 = 137;
		internal const int Deu_11 = 138;
		internal const int Deu_12 = 139;
		internal const int Deu_15 = 140;
		internal const int Deu_16 = 141;
		internal const int Deu_17 = 142;
		internal const int Deu_18 = 143;
		internal const int Deu_20 = 144;
		internal const int Deu_21 = 145;
		internal const int Deu_22 = 146;
		internal const int Deu_23a = 147;
		internal const int Deu_23b = 148;
		internal const int Deu_24 = 149;
		internal const int Deu_26 = 150;
		internal const int Deu_28 = 151;
		internal const int Deu_29 = 152;
		internal const int Deu_30 = 153;
		internal const int Deu_31 = 154;
		internal const int Deu_32 = 155;
		internal const int Deu_33 = 156;
		internal const int Deu_34 = 157;
	}
	#endregion

	#region  Declared Public Instances

	public static readonly Ahavta Gen_01a = new Gen_01aSE();
	public static readonly Ahavta Gen_01b = new Gen_01bSE();
	public static readonly Ahavta Gen_02 = new Gen_02SE();
	public static readonly Ahavta Gen_03a = new Gen_03aSE();
	public static readonly Ahavta Gen_03b = new Gen_03bSE();
	public static readonly Ahavta Gen_05 = new Gen_05SE();
	public static readonly Ahavta Gen_06 = new Gen_06SE();
	public static readonly Ahavta Gen_08a = new Gen_08aSE();
	public static readonly Ahavta Gen_08b = new Gen_08bSE();
	public static readonly Ahavta Gen_09 = new Gen_09SE();
	public static readonly Ahavta Gen_11 = new Gen_11SE();
	public static readonly Ahavta Gen_12 = new Gen_12SE();
	public static readonly Ahavta Gen_14 = new Gen_14SE();
	public static readonly Ahavta Gen_15 = new Gen_15SE();
	public static readonly Ahavta Gen_16 = new Gen_16SE();
	public static readonly Ahavta Gen_17 = new Gen_17SE();
	public static readonly Ahavta Gen_18 = new Gen_18SE();
	public static readonly Ahavta Gen_19 = new Gen_19SE();
	public static readonly Ahavta Gen_20 = new Gen_20SE();
	public static readonly Ahavta Gen_21 = new Gen_21SE();
	public static readonly Ahavta Gen_22 = new Gen_22SE();
	public static readonly Ahavta Gen_23 = new Gen_23SE();
	public static readonly Ahavta Gen_24a = new Gen_24aSE();
	public static readonly Ahavta Gen_24b = new Gen_24bSE();
	public static readonly Ahavta Gen_25a = new Gen_25aSE();
	public static readonly Ahavta Gen_25b = new Gen_25bSE();
	public static readonly Ahavta Gen_26 = new Gen_26SE();
	public static readonly Ahavta Gen_27a = new Gen_27aSE();
	public static readonly Ahavta Gen_27b = new Gen_27bSE();
	public static readonly Ahavta Gen_28 = new Gen_28SE();
	public static readonly Ahavta Gen_29 = new Gen_29SE();
	public static readonly Ahavta Gen_30 = new Gen_30SE();
	public static readonly Ahavta Gen_31 = new Gen_31SE();
	public static readonly Ahavta Gen_32 = new Gen_32SE();
	public static readonly Ahavta Gen_33 = new Gen_33SE();
	public static readonly Ahavta Gen_35 = new Gen_35SE();
	public static readonly Ahavta Gen_37 = new Gen_37SE();
	public static readonly Ahavta Gen_38 = new Gen_38SE();
	public static readonly Ahavta Gen_39 = new Gen_39SE();
	public static readonly Ahavta Gen_40 = new Gen_40SE();
	public static readonly Ahavta Gen_41a = new Gen_41aSE();
	public static readonly Ahavta Gen_41b = new Gen_41bSE();
	public static readonly Ahavta Gen_42 = new Gen_42SE();
	public static readonly Ahavta Gen_43 = new Gen_43SE();
	public static readonly Ahavta Gen_44 = new Gen_44SE();
	public static readonly Ahavta Gen_46 = new Gen_46SE();
	public static readonly Ahavta Gen_48 = new Gen_48SE();
	public static readonly Ahavta Gen_49 = new Gen_49SE();
	public static readonly Ahavta Exo_01 = new Exo_01SE();
	public static readonly Ahavta Exo_03 = new Exo_03SE();
	public static readonly Ahavta Exo_04 = new Exo_04SE();
	public static readonly Ahavta Exo_06 = new Exo_06SE();
	public static readonly Ahavta Exo_07 = new Exo_07SE();
	public static readonly Ahavta Exo_08 = new Exo_08SE();
	public static readonly Ahavta Exo_10 = new Exo_10SE();
	public static readonly Ahavta Exo_11 = new Exo_11SE();
	public static readonly Ahavta Exo_12 = new Exo_12SE();
	public static readonly Ahavta Exo_13a = new Exo_13aSE();
	public static readonly Ahavta Exo_13b = new Exo_13bSE();
	public static readonly Ahavta Exo_15 = new Exo_15SE();
	public static readonly Ahavta Exo_16 = new Exo_16SE();
	public static readonly Ahavta Exo_18 = new Exo_18SE();
	public static readonly Ahavta Exo_19 = new Exo_19SE();
	public static readonly Ahavta Exo_21 = new Exo_21SE();
	public static readonly Ahavta Exo_22 = new Exo_22SE();
	public static readonly Ahavta Exo_24 = new Exo_24SE();
	public static readonly Ahavta Exo_25 = new Exo_25SE();
	public static readonly Ahavta Exo_27a = new Exo_27aSE();
	public static readonly Ahavta Exo_27b = new Exo_27bSE();
	public static readonly Ahavta Exo_29 = new Exo_29SE();
	public static readonly Ahavta Exo_30a = new Exo_30aSE();
	public static readonly Ahavta Exo_30b = new Exo_30bSE();
	public static readonly Ahavta Exo_31 = new Exo_31SE();
	public static readonly Ahavta Exo_32 = new Exo_32SE();
	public static readonly Ahavta Exo_34 = new Exo_34SE();
	public static readonly Ahavta Exo_37 = new Exo_37SE();
	public static readonly Ahavta Exo_38 = new Exo_38SE();
	public static readonly Ahavta Exo_39 = new Exo_39SE();
	public static readonly Ahavta Lev_01 = new Lev_01SE();
	public static readonly Ahavta Lev_03 = new Lev_03SE();
	public static readonly Ahavta Lev_04 = new Lev_04SE();
	public static readonly Ahavta Lev_05 = new Lev_05SE();
	public static readonly Ahavta Lev_06 = new Lev_06SE();
	public static readonly Ahavta Lev_07 = new Lev_07SE();
	public static readonly Ahavta Lev_08 = new Lev_08SE();
	public static readonly Ahavta Lev_09 = new Lev_09SE();
	public static readonly Ahavta Lev_12 = new Lev_12SE();
	public static readonly Ahavta Lev_13 = new Lev_13SE();
	public static readonly Ahavta Lev_14 = new Lev_14SE();
	public static readonly Ahavta Lev_15 = new Lev_15SE();
	public static readonly Ahavta Lev_16 = new Lev_16SE();
	public static readonly Ahavta Lev_17 = new Lev_17SE();
	public static readonly Ahavta Lev_18 = new Lev_18SE();
	public static readonly Ahavta Lev_19 = new Lev_19SE();
	public static readonly Ahavta Lev_21 = new Lev_21SE();
	public static readonly Ahavta Lev_22 = new Lev_22SE();
	public static readonly Ahavta Lev_24 = new Lev_24SE();
	public static readonly Ahavta Lev_25a = new Lev_25aSE();
	public static readonly Ahavta Lev_25b = new Lev_25bSE();
	public static readonly Ahavta Lev_26 = new Lev_26SE();
	public static readonly Ahavta Num_01 = new Num_01SE();
	public static readonly Ahavta Num_02 = new Num_02SE();
	public static readonly Ahavta Num_03 = new Num_03SE();
	public static readonly Ahavta Num_04 = new Num_04SE();
	public static readonly Ahavta Num_05 = new Num_05SE();
	public static readonly Ahavta Num_06a = new Num_06aSE();
	public static readonly Ahavta Num_06b = new Num_06bSE();
	public static readonly Ahavta Num_08 = new Num_08SE();
	public static readonly Ahavta Num_10 = new Num_10SE();
	public static readonly Ahavta Num_11 = new Num_11SE();
	public static readonly Ahavta Num_12 = new Num_12SE();
	public static readonly Ahavta Num_13 = new Num_13SE();
	public static readonly Ahavta Num_14 = new Num_14SE();
	public static readonly Ahavta Num_15 = new Num_15SE();
	public static readonly Ahavta Num_16 = new Num_16SE();
	public static readonly Ahavta Num_17 = new Num_17SE();
	public static readonly Ahavta Num_19 = new Num_19SE();
	public static readonly Ahavta Num_20 = new Num_20SE();
	public static readonly Ahavta Num_22 = new Num_22SE();
	public static readonly Ahavta Num_23 = new Num_23SE();
	public static readonly Ahavta Num_25 = new Num_25SE();
	public static readonly Ahavta Num_26 = new Num_26SE();
	public static readonly Ahavta Num_28 = new Num_28SE();
	public static readonly Ahavta Num_30 = new Num_30SE();
	public static readonly Ahavta Num_32 = new Num_32SE();
	public static readonly Ahavta Num_33 = new Num_33SE();
	public static readonly Ahavta Num_34 = new Num_34SE();
	public static readonly Ahavta Num_35 = new Num_35SE();
	public static readonly Ahavta Deu_01 = new Deu_01SE();
	public static readonly Ahavta Deu_02 = new Deu_02SE();
	public static readonly Ahavta Deu_03 = new Deu_03SE();
	public static readonly Ahavta Deu_04 = new Deu_04SE();
	public static readonly Ahavta Deu_05 = new Deu_05SE();
	public static readonly Ahavta Deu_06 = new Deu_06SE();
	public static readonly Ahavta Deu_08 = new Deu_08SE();
	public static readonly Ahavta Deu_09 = new Deu_09SE();
	public static readonly Ahavta Deu_10 = new Deu_10SE();
	public static readonly Ahavta Deu_11 = new Deu_11SE();
	public static readonly Ahavta Deu_12 = new Deu_12SE();
	public static readonly Ahavta Deu_15 = new Deu_15SE();
	public static readonly Ahavta Deu_16 = new Deu_16SE();
	public static readonly Ahavta Deu_17 = new Deu_17SE();
	public static readonly Ahavta Deu_18 = new Deu_18SE();
	public static readonly Ahavta Deu_20 = new Deu_20SE();
	public static readonly Ahavta Deu_21 = new Deu_21SE();
	public static readonly Ahavta Deu_22 = new Deu_22SE();
	public static readonly Ahavta Deu_23a = new Deu_23aSE();
	public static readonly Ahavta Deu_23b = new Deu_23bSE();
	public static readonly Ahavta Deu_24 = new Deu_24SE();
	public static readonly Ahavta Deu_26 = new Deu_26SE();
	public static readonly Ahavta Deu_28 = new Deu_28SE();
	public static readonly Ahavta Deu_29 = new Deu_29SE();
	public static readonly Ahavta Deu_30 = new Deu_30SE();
	public static readonly Ahavta Deu_31 = new Deu_31SE();
	public static readonly Ahavta Deu_32 = new Deu_32SE();
	public static readonly Ahavta Deu_33 = new Deu_33SE();
	public static readonly Ahavta Deu_34 = new Deu_34SE();

	#endregion

	private Ahavta(string name, int value) : base(name, value) { } // Constructor


	#region Extra Fields
	public abstract string TriNum { get; } // 1.1	
	public abstract string ParashaName { get; } // B'reisheet (1)	
	public abstract string NameUrl { get; } // b-reisheet-genesis-1-1-to-19-number-1-1	
	public abstract string AhavtaURL { get; } // http://www.ahavta.org/Commentary Y-1/Y1-01.htm	
	public abstract string Meaning { get; } // In the beginning (Days 1 - 4)	

	//Verses
	public abstract VerseRange TorahVerse { get; }
	public abstract List<VerseRange>? HaftorahVerses { get; }
	public abstract List<VerseRange>? BritVerses { get; }

	//Methods
	public DateTime Date
	{
		get
		{
			return Constants.ShabbatDateSeed.AddDays(7 * this.Value);
		}
	}
	public string Title // 1.1, Gen 1:1-19, Sep 29 2018; 
	{
		get
		{
			return $" {this.TriNum}, {BibleBook.FromValue(this.TorahVerse.BibleBook).Abrv} {this.TorahVerse.ChapterVerse}, {this.Date.ToString(DateFormat.YYYY_MM_DD)}";
		}
	}
	public string Torah  // Genesis 1:1-19
	{
		get
		{
			return $" {BibleBook.FromValue(this.TorahVerse.BibleBook).Name} {this.TorahVerse.ChapterVerse}";
		}
	}
	public string TorahAbrv // Gen 1:1-19
	{
		get
		{
			return $" {BibleBook.FromValue(this.TorahVerse.BibleBook).Abrv} {this.TorahVerse.ChapterVerse}";
		}
	}

	#endregion

	#region Private Instantiation
	private sealed class Gen_01aSE : Ahavta
	{
		public Gen_01aSE() : base($"{nameof(Id.Gen_01a)}", Id.Gen_01a) { }
		public override string TriNum => "1.1";
		public override string ParashaName => "B'reisheet (1)";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "In the beginning (Days 1 - 4)";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "1:1-19", 1, 19);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "45:17", 18579, 18579),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "4:5", 23215, 23215),     new VerseRange(BibleBook.John, "1:1-5", 26046, 26050),    new VerseRange(BibleBook.Colossians, "1:1-23", 29467, 29489),     new VerseRange(BibleBook.Revelation, "22:6-21", 31087, 31102),
		];
	}
	private sealed class Gen_01bSE : Ahavta
	{
		public Gen_01bSE() : base($"{nameof(Id.Gen_01b)}", Id.Gen_01b) { }
		public override string TriNum => "1.2";
		public override string ParashaName => "B'reisheet (2)";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "In the beginning (Days 5 - 7)";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "1:20-2:3", 20, 34);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange>? BritVerses => null;
	}
	private sealed class Gen_02SE : Ahavta
	{
		public Gen_02SE() : base($"{nameof(Id.Gen_02)}", Id.Gen_02) { }
		public override string TriNum => "1.3";
		public override string ParashaName => "HaShamayim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "The heavens - Part 1";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "2:4-25", 35, 56);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "42:5", 18486, 18486),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "1:6-28", 26051, 26073),     new VerseRange(BibleBook.Romans, "5:12-21", 28060, 28069),    new VerseRange(BibleBook.Hebrews, "11:1-7", 30174, 30180),
		];
	}
	private sealed class Gen_03aSE : Ahavta
	{
		public Gen_03aSE() : base($"{nameof(Id.Gen_03a)}", Id.Gen_03a) { }
		public override string TriNum => "1.4";
		public override string ParashaName => "HaShamayim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "The heavens - Part 2";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "3:1-23", 57, 79);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange>? BritVerses => null;
	}
	private sealed class Gen_03bSE : Ahavta
	{
		public Gen_03bSE() : base($"{nameof(Id.Gen_03b)}", Id.Gen_03b) { }
		public override string TriNum => "1.5";
		public override string ParashaName => "Vahyehgaresh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He drove out";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "3:24-4:26", 80, 106);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "42:7-8", 18488, 18489),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "1:24", 24918, 24918),     new VerseRange(BibleBook.Luke, "2:39-41", 25013, 25015),    new VerseRange(BibleBook.John, "2:23", 26119, 26119),
		];
	}
	private sealed class Gen_05SE : Ahavta
	{
		public Gen_05SE() : base($"{nameof(Id.Gen_05)}", Id.Gen_05) { }
		public override string TriNum => "1.6";
		public override string ParashaName => "Tol'dot Adahm";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Generations of Adam";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "5:1-6:8", 107, 146);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "30:8-15", 18226, 18233),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "1:11-23", 26056, 26068),
		];
	}
	private sealed class Gen_06SE : Ahavta
	{
		public Gen_06SE() : base($"{nameof(Id.Gen_06)}", Id.Gen_06) { }
		public override string TriNum => "2.1";
		public override string ParashaName => "Noach";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Rest";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "6:9-7:24", 147, 184);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "54:5-8", 18729, 18732),     new VerseRange(BibleBook.Ezekiel, "14:14", 20746, 20746),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "24:4-14", 23962, 23972),     new VerseRange(BibleBook.John, "1:24-34", 26069, 26079),
		];
	}
	private sealed class Gen_08aSE : Ahavta
	{
		public Gen_08aSE() : base($"{nameof(Id.Gen_08a)}", Id.Gen_08a) { }
		public override string TriNum => "2.2";
		public override string ParashaName => "Vayizkor";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He remebered";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "8:1-14", 185, 198);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Habakkuk, "3:1-5", 22770, 22774),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "1:1-14", 26925, 26938),     new VerseRange(BibleBook.FirstPeter, "3:20", 30445, 30445),     new VerseRange(BibleBook.Revelation, "1:9-20", 30707, 30718),
		];
	}
	private sealed class Gen_08bSE : Ahavta
	{
		public Gen_08bSE() : base($"{nameof(Id.Gen_08b)}", Id.Gen_08b) { }
		public override string TriNum => "2.3";
		public override string ParashaName => "Tzay meen hatayvah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Come out from the ark";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "8:15-9:17", 199, 223);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "42:9-21", 18490, 18502),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "24:4-14", 23962, 23972),     new VerseRange(BibleBook.SecondTimothy, "2:8-19", 29836, 29847),
		];
	}
	private sealed class Gen_09SE : Ahavta
	{
		public Gen_09SE() : base($"{nameof(Id.Gen_09)}", Id.Gen_09) { }
		public override string TriNum => "2.4";
		public override string ParashaName => "Venay Noach";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Sons of Noah";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "9:18-10:32", 224, 267);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "49:9-13", 18646, 18650),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "17:26-28", 27550, 27552),     new VerseRange(BibleBook.Revelation, "5", 30781, 30794),
		];
	}
	private sealed class Gen_11SE : Ahavta
	{
		public Gen_11SE() : base($"{nameof(Id.Gen_11)}", Id.Gen_11) { }
		public override string TriNum => "2.5";
		public override string ParashaName => "Vayehee kol haaretz";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And he had all the land";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "11", 268, 299);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "28:10-16", 18175, 18181),     new VerseRange(BibleBook.Zephaniah, "3:9", 22830, 22830),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstCorinthians, "14:20-33", 28699, 28712),
		];
	}
	private sealed class Gen_12SE : Ahavta
	{
		public Gen_12SE() : base($"{nameof(Id.Gen_12)}", Id.Gen_12) { }
		public override string TriNum => "3.1";
		public override string ParashaName => "Lech L'cha";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Get yourself out";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "12 & 13", 300, 337);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Joshua, "24:3-18", 6480, 6495),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Galatians, "2:20", 29102, 29102),    new VerseRange(BibleBook.SecondTimothy, "2:11", 29839, 29839),    new VerseRange(BibleBook.Hebrews, "11:1-10", 30174, 30183),
		];
	}
	private sealed class Gen_14SE : Ahavta
	{
		public Gen_14SE() : base($"{nameof(Id.Gen_14)}", Id.Gen_14) { }
		public override string TriNum => "3.2";
		public override string ParashaName => "B'may Amraphel";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Days of Amraphel";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "14", 338, 361);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "10:9", 9089, 9089),     new VerseRange(BibleBook.Isaiah, "41:2-14", 18454, 18466),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "7:1-19", 30066, 30084),
		];
	}
	private sealed class Gen_15SE : Ahavta
	{
		public Gen_15SE() : base($"{nameof(Id.Gen_15)}", Id.Gen_15) { }
		public override string TriNum => "3.3";
		public override string ParashaName => "Bahmahchazeh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "In a vision";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "15", 362, 382);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "1:1-27", 17656, 17682),     new VerseRange(BibleBook.Zephaniah, "3:9-19", 22830, 22840),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "4:1-9", 28024, 28032),
		];
	}
	private sealed class Gen_16SE : Ahavta
	{
		public Gen_16SE() : base($"{nameof(Id.Gen_16)}", Id.Gen_16) { }
		public override string TriNum => "3.4";
		public override string ParashaName => "Sarai ayshet Avram";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Sarai wife of Avram";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "16", 383, 398);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "54:1", 18725, 18725),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Galatians, "4:21-31", 29153, 29163),
		];
	}
	private sealed class Gen_17SE : Ahavta
	{
		public Gen_17SE() : base($"{nameof(Id.Gen_17)}", Id.Gen_17) { }
		public override string TriNum => "3.5";
		public override string ParashaName => "Vayhee Avram";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When Avram";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "17", 399, 425);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "63:10-19", 18877, 18886),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "4:10-25", 28033, 28048),
		];
	}
	private sealed class Gen_18SE : Ahavta
	{
		public Gen_18SE() : base($"{nameof(Id.Gen_18)}", Id.Gen_18) { }
		public override string TriNum => "4.1";
		public override string ParashaName => "Vayera";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He appeared";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "18", 426, 458);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.SecondKings, "4:1", 9605, 9605),     new VerseRange(BibleBook.Isaiah, "33:17-24", 18297, 18304),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "8:40-56", 25286, 25302),    new VerseRange(BibleBook.Hebrews, "11:8-18", 30181, 30191),
		];
	}
	private sealed class Gen_19SE : Ahavta
	{
		public Gen_19SE() : base($"{nameof(Id.Gen_19)}", Id.Gen_19) { }
		public override string TriNum => "4.2";
		public override string ParashaName => "Vayavo'u sh'ne";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And came the two";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "19", 459, 496);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "17:14-18:7", 17998, 18005),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "17:20-37", 25672, 25689),
		];
	}
	private sealed class Gen_20SE : Ahavta
	{
		public Gen_20SE() : base($"{nameof(Id.Gen_20)}", Id.Gen_20) { }
		public override string TriNum => "4.3";
		public override string ParashaName => "VaYisa'a Misham";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And journeyed from ..";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "20", 497, 514);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "61:9-10", 18853, 18854),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "8:1-13", 23347, 23359),    new VerseRange(BibleBook.FirstCorinthians, "7:1-2", 28489, 28490),    new VerseRange(BibleBook.Galatians, "3:15-29", 29118, 29132),
		];
	}
	private sealed class Gen_21SE : Ahavta
	{
		public Gen_21SE() : base($"{nameof(Id.Gen_21)}", Id.Gen_21) { }
		public override string TriNum => "4.4";
		public override string ParashaName => "VaHa-Shem Paqad";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And YHVH visited";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "21", 515, 548);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "2:21-28", 7262, 7269),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "1:18-25", 23163, 23170),     new VerseRange(BibleBook.Hebrews, "11:11", 30184, 30184),
		];
	}
	private sealed class Gen_22SE : Ahavta
	{
		public Gen_22SE() : base($"{nameof(Id.Gen_22)}", Id.Gen_22) { }
		public override string TriNum => "4.5";
		public override string ParashaName => "V'HaElohim Nisah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And Elohim tested";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "22", 549, 572);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "33:7-22", 18287, 18302),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "27:27-66", 24157, 24196),    new VerseRange(BibleBook.John, "19:16-17", 26842, 26843),
		];
	}
	private sealed class Gen_23SE : Ahavta
	{
		public Gen_23SE() : base($"{nameof(Id.Gen_23)}", Id.Gen_23) { }
		public override string TriNum => "5.1";
		public override string ParashaName => "Chaye Sarah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Life of Sarah";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "23", 573, 592);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "1:1-31", 8719, 8749),     new VerseRange(BibleBook.Isaiah, "1:1-27", 17656, 17682),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "19:41", 26867, 26867),    new VerseRange(BibleBook.Acts, "7:1-18", 27118, 27135),     new VerseRange(BibleBook.FirstCorinthians, "15:50-57", 28769, 28776),
		];
	}
	private sealed class Gen_24aSE : Ahavta
	{
		public Gen_24aSE() : base($"{nameof(Id.Gen_24a)}", Id.Gen_24a) { }
		public override string TriNum => "5.2";
		public override string ParashaName => "V'Avraham Zaken";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And Abraham was old";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "24:1-41", 593, 633);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Judges, "19:20-21", 7045, 7046),     new VerseRange(BibleBook.Isaiah, "40:1-2", 18422, 18423),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "4:7-15", 26164, 26172),     new VerseRange(BibleBook.Ephesians, "5:15-33", 29320, 29338),
		];
	}
	private sealed class Gen_24bSE : Ahavta
	{
		public Gen_24bSE() : base($"{nameof(Id.Gen_24b)}", Id.Gen_24b) { }
		public override string TriNum => "5.3";
		public override string ParashaName => "Va'Avo HaYom";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "I came today";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "24:42-67", 634, 659);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "49:14-51:3", 18651, 18677),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.James, "4:13-17", 30351, 30355),
		];
	}
	private sealed class Gen_25aSE : Ahavta
	{
		public Gen_25aSE() : base($"{nameof(Id.Gen_25a)}", Id.Gen_25a) { }
		public override string TriNum => "5.4";
		public override string ParashaName => "VaYosef Avraham";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And added Avraham";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "25:1-18", 660, 677);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.SecondSamuel, "5:17-6:1", 8150, 8159),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "7", 28093, 28117),
		];
	}
	private sealed class Gen_25bSE : Ahavta
	{
		public Gen_25bSE() : base($"{nameof(Id.Gen_25b)}", Id.Gen_25b) { }
		public override string TriNum => "6.1";
		public override string ParashaName => "Tole'dot";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Generations";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "25:19-26:11", 678, 704);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "20:18", 7749, 7749),     new VerseRange(BibleBook.FirstSamuel, "20:42", 7773, 7773),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "9:9-14", 28165, 28170),     new VerseRange(BibleBook.Hebrews, "12:14-29", 30227, 30242),
		];
	}
	private sealed class Gen_26SE : Ahavta
	{
		public Gen_26SE() : base($"{nameof(Id.Gen_26)}", Id.Gen_26) { }
		public override string TriNum => "6.2";
		public override string ParashaName => "Vauiz'ra Yitschaq";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And Isaac sowed";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "26:12-35", 705, 728);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "51:12-52:12", 18686, 18709),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "16:1-15", 25622, 25636),    new VerseRange(BibleBook.Romans, "9:1-8", 28157, 28164),
		];
	}
	private sealed class Gen_27aSE : Ahavta
	{
		public Gen_27aSE() : base($"{nameof(Id.Gen_27a)}", Id.Gen_27a) { }
		public override string TriNum => "6.3";
		public override string ParashaName => "Vay'hi Ki-Zeqen";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And it was when old";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "27:1-29", 729, 757);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "46:3-6", 18590, 18593),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "2:14-18", 29992, 29996),     new VerseRange(BibleBook.Hebrews, "11:20", 30193, 30193),
		];
	}
	private sealed class Gen_27bSE : Ahavta
	{
		public Gen_27bSE() : base($"{nameof(Id.Gen_27b)}", Id.Gen_27b) { }
		public override string TriNum => "6.4";
		public override string ParashaName => "V'yitem L'kha";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And may give you";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "27:30-28:9", 758, 783);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Micah, "1:11", 22591, 22591),    new VerseRange(BibleBook.Micah, "5", 22635, 22649),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "10:20-11:36", 28209, 28246),
		];
	}
	private sealed class Gen_28SE : Ahavta
	{
		public Gen_28SE() : base($"{nameof(Id.Gen_28)}", Id.Gen_28) { }
		public override string TriNum => "7.1";
		public override string ParashaName => "Vayetse";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He went out";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "28:10-29:30", 784, 826);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "60", 18823, 18844),     new VerseRange(BibleBook.Hosea, "12:13", 22266, 22266),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "9:18-19", 23398, 23399),     new VerseRange(BibleBook.Luke, "2:1-31", 24975, 25005),     new VerseRange(BibleBook.Ephesians, "6:5-9", 29343, 29347),
		];
	}
	private sealed class Gen_29SE : Ahavta
	{
		public Gen_29SE() : base($"{nameof(Id.Gen_29)}", Id.Gen_29) { }
		public override string TriNum => "7.2";
		public override string ParashaName => "Vayara YHVH";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "YHVH Saw";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "29:31-30:21", 827, 852);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "60:15", 18837, 18837),    new VerseRange(BibleBook.Isaiah, "61:10-63:9", 18854, 18876),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "11:25-36", 28235, 28246),     new VerseRange(BibleBook.Revelation, "19", 31019, 31039),
		];
	}
	private sealed class Gen_30SE : Ahavta
	{
		public Gen_30SE() : base($"{nameof(Id.Gen_30)}", Id.Gen_30) { }
		public override string TriNum => "7.3";
		public override string ParashaName => "Vayizchar Elohim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Elohim Remebered";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "30:22-31:2", 853, 876);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "1:11", 7224, 7224),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "2:13", 23183, 23183),    new VerseRange(BibleBook.Acts, "13:16-41", 27379, 27404),     new VerseRange(BibleBook.Revelation, "20:4-15", 31043, 31054),
		];
	}
	private sealed class Gen_31SE : Ahavta
	{
		public Gen_31SE() : base($"{nameof(Id.Gen_31)}", Id.Gen_31) { }
		public override string TriNum => "7.4";
		public override string ParashaName => "Shuv El Eretz";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Return to the Land";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "31:3-32:3", 877, 932);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "30:10-16", 19678, 19684),     new VerseRange(BibleBook.Micah, "6:3-7:20", 22652, 22685),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "1:24-28", 26069, 26073),    new VerseRange(BibleBook.James, "4:1-12", 30339, 30350),
		];
	}
	private sealed class Gen_32SE : Ahavta
	{
		public Gen_32SE() : base($"{nameof(Id.Gen_32)}", Id.Gen_32) { }
		public override string TriNum => "8.1";
		public override string ParashaName => "Vayishlach";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He sent";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "32:4-33:17", 933, 978);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Obadiah, "1:1", 22512, 22512),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.James, "1:1-12", 30268, 30279),
		];
	}
	private sealed class Gen_33SE : Ahavta
	{
		public Gen_33SE() : base($"{nameof(Id.Gen_33)}", Id.Gen_33) { }
		public override string TriNum => "8.2";
		public override string ParashaName => "Vayavo";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Then He Arrived";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "33:18-35:8", 979, 1020);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Nahum, "1:12-2:5", 22697, 22705),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Revelation, "22:8-21", 31089, 31102),
		];
	}
	private sealed class Gen_35SE : Ahavta
	{
		public Gen_35SE() : base($"{nameof(Id.Gen_35)}", Id.Gen_35) { }
		public override string TriNum => "8.3";
		public override string ParashaName => "Vayrah Elohim el";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Then Elohim appeared";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "35:9-36:43", 1021, 1084);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "43:1-7", 18507, 18513),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "5:1-12", 23236, 23247),
		];
	}
	private sealed class Gen_37SE : Ahavta
	{
		public Gen_37SE() : base($"{nameof(Id.Gen_37)}", Id.Gen_37) { }
		public override string TriNum => "9.1";
		public override string ParashaName => "Vayeshev";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He dwelt";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "37", 1085, 1120);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "38:8", 19904, 19904),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "19:1-20:10", 26827, 26878),
		];
	}
	private sealed class Gen_38SE : Ahavta
	{
		public Gen_38SE() : base($"{nameof(Id.Gen_38)}", Id.Gen_38) { }
		public override string TriNum => "9.2";
		public override string ParashaName => "VaYered Yehudah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Judah Departed";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "38", 1121, 1150);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "37:31-37", 18384, 18390),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "9:22-29", 28178, 28185),
		];
	}
	private sealed class Gen_39SE : Ahavta
	{
		public Gen_39SE() : base($"{nameof(Id.Gen_39)}", Id.Gen_39) { }
		public override string TriNum => "9.3";
		public override string ParashaName => "VaYosheph";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Now Joseph";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "39", 1151, 1173);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "52:3-9", 18700, 18706),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "7:9-37", 27126, 27154),
		];
	}
	private sealed class Gen_40SE : Ahavta
	{
		public Gen_40SE() : base($"{nameof(Id.Gen_40)}", Id.Gen_40) { }
		public override string TriNum => "9.4";
		public override string ParashaName => "Chateu";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "They offended";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "40", 1174, 1196);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Amos, "1:3-15", 22368, 22380),     new VerseRange(BibleBook.Amos, "2:6", 22386, 22386),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.SecondCorinthians, "9:6-15", 28963, 28972),
		];
	}
	private sealed class Gen_41aSE : Ahavta
	{
		public Gen_41aSE() : base($"{nameof(Id.Gen_41a)}", Id.Gen_41a) { }
		public override string TriNum => "10.1";
		public override string ParashaName => "Miketz";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "At the end of";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "41:1-37", 1197, 1233);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "3:15-4:1", 8832, 8846),     new VerseRange(BibleBook.Isaiah, "29:8", 18202, 18202),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "2", 23171, 23193),
		];
	}
	private sealed class Gen_41bSE : Ahavta
	{
		public Gen_41bSE() : base($"{nameof(Id.Gen_41b)}", Id.Gen_41b) { }
		public override string TriNum => "10.2";
		public override string ParashaName => "Hanimtza";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Can We Find?";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "41:38-42:17", 1234, 1270);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "11:2-9", 17887, 17894),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "7:1-19", 27118, 27136),
		];
	}
	private sealed class Gen_42SE : Ahavta
	{
		public Gen_42SE() : base($"{nameof(Id.Gen_42)}", Id.Gen_42) { }
		public override string TriNum => "10.3";
		public override string ParashaName => "Vayomer Eleichem";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "He Said to Them";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "42:18-43:23", 1271, 1314);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "50:10-52:11", 18673, 18708),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "1:68-79", 24962, 24973),
		];
	}
	private sealed class Gen_43SE : Ahavta
	{
		public Gen_43SE() : base($"{nameof(Id.Gen_43)}", Id.Gen_43) { }
		public override string TriNum => "10.4";
		public override string ParashaName => "Vayavei Ha-ish";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Then the Man Brought";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "43:24-44:17", 1315, 1342);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "42:12-17", 19988, 19993),     new VerseRange(BibleBook.Jeremiah, "43:12-13", 20010, 20011),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "19:37-48", 25769, 25780),
		];
	}
	private sealed class Gen_44SE : Ahavta
	{
		public Gen_44SE() : base($"{nameof(Id.Gen_44)}", Id.Gen_44) { }
		public override string TriNum => "11.1";
		public override string ParashaName => "Vayigash";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He drew near";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "44:18-46:27", 1343, 1414);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Joshua, "14:6", 6194, 6194),     new VerseRange(BibleBook.Ezekiel, "37:10", 21408, 21408),     new VerseRange(BibleBook.Ezekiel, "37:15-18", 21413, 21416),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "2:23", 26973, 26973),     new VerseRange(BibleBook.Acts, "2:36", 26986, 26986),     new VerseRange(BibleBook.Revelation, "12:1-6", 30893, 30898),
		];
	}
	private sealed class Gen_46SE : Ahavta
	{
		public Gen_46SE() : base($"{nameof(Id.Gen_46)}", Id.Gen_46) { }
		public override string TriNum => "11.2";
		public override string ParashaName => "Yehudah Shalach";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "He Sent Judah";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "46:28-47:31", 1415, 1452);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "2:1-4", 8772, 8775),    new VerseRange(BibleBook.SecondKings, "13:14", 9886, 9886),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Revelation, "21:1-10", 31055, 31064),    new VerseRange(BibleBook.Revelation, "22:1-10", 31082, 31091),
		];
	}
	private sealed class Gen_48SE : Ahavta
	{
		public Gen_48SE() : base($"{nameof(Id.Gen_48)}", Id.Gen_48) { }
		public override string TriNum => "12.1";
		public override string ParashaName => "Vay'chi";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He lived";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "48:1-49:27", 1453, 1501);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "43:2", 18508, 18508),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "19:39-20:9", 26865, 26877),
		];
	}
	private sealed class Gen_49SE : Ahavta
	{
		public Gen_49SE() : base($"{nameof(Id.Gen_49)}", Id.Gen_49) { }
		public override string TriNum => "12.2";
		public override string ParashaName => "Shivtey Yisrael";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "The Tribes of Israel";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Genesis, "49:28-50:26", 1502, 1533);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Micah, "2:12", 22608, 22608),    new VerseRange(BibleBook.Zechariah, "14:1", 23070, 23070),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "21:12-19", 26911, 26918),
		];
	}
	private sealed class Exo_01SE : Ahavta
	{
		public Exo_01SE() : base($"{nameof(Id.Exo_01)}", Id.Exo_01) { }
		public override string TriNum => "13.1";
		public override string ParashaName => "Shemot";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Names";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "1 & 2", 1534, 1580);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "27:6", 18158, 18158),     new VerseRange(BibleBook.Isaiah, "52:1-6", 18698, 18703),     new VerseRange(BibleBook.Isaiah, "65:19-23", 18917, 18921),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "7:17-29", 27134, 27146),    new VerseRange(BibleBook.SecondCorinthians, "6:1-10", 28900, 28909),
		];
	}
	private sealed class Exo_03SE : Ahavta
	{
		public Exo_03SE() : base($"{nameof(Id.Exo_03)}", Id.Exo_03) { }
		public override string TriNum => "13.2";
		public override string ParashaName => "Umoshe";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Now Moses";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "3:1-4:13", 1581, 1615);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.SecondKings, "20:8", 10107, 10107),    new VerseRange(BibleBook.Isaiah, "40:11", 18432, 18432),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "12:26", 23516, 23516),     new VerseRange(BibleBook.Luke, "20:37", 25817, 25817),    new VerseRange(BibleBook.Acts, "7:30", 27147, 27147),
		];
	}
	private sealed class Exo_04SE : Ahavta
	{
		public Exo_04SE() : base($"{nameof(Id.Exo_04)}", Id.Exo_04) { }
		public override string TriNum => "13.3";
		public override string ParashaName => "VaYeled Moshe";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Then Moses Departed";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "4:14-6:1", 1616, 1657);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "55:12", 18753, 18753),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "8:26-59", 26408, 26441),
		];
	}
	private sealed class Exo_06SE : Ahavta
	{
		public Exo_06SE() : base($"{nameof(Id.Exo_06)}", Id.Exo_06) { }
		public override string TriNum => "14.1";
		public override string ParashaName => "Va'crya";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And I appeared";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "6:2-7:7", 1658, 1693);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "42:8", 18489, 18489),     new VerseRange(BibleBook.Ezekiel, "28:25-29:21", 21183, 21205),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.ThirdJohn, "1:1-7", 30660, 30666),
		];
	}
	private sealed class Exo_07SE : Ahavta
	{
		public Exo_07SE() : base($"{nameof(Id.Exo_07)}", Id.Exo_07) { }
		public override string TriNum => "14.2";
		public override string ParashaName => "Ki Y'daber";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When He Speaks";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "7:8-8:15", 1694, 1726);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "22:1-38", 9482, 9519),    new VerseRange(BibleBook.Joel, "3:1-7", 22345, 22351),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Revelation, "16:1-17", 30956, 30972),
		];
	}
	private sealed class Exo_08SE : Ahavta
	{
		public Exo_08SE() : base($"{nameof(Id.Exo_08)}", Id.Exo_08) { }
		public override string TriNum => "14.3";
		public override string ParashaName => "Hash'kem Baboker";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Rise Up Early in the Morning";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "8:16-9:35", 1727, 1778);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "34:1-11", 18305, 18315),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "11:20", 25426, 25426),    new VerseRange(BibleBook.John, "11:47-53", 26571, 26577),     new VerseRange(BibleBook.Revelation, "8:1-9:6", 30829, 30847),
		];
	}
	private sealed class Exo_10SE : Ahavta
	{
		public Exo_10SE() : base($"{nameof(Id.Exo_10)}", Id.Exo_10) { }
		public override string TriNum => "15.1";
		public override string ParashaName => "Bo";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Enter/Go";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "10", 1779, 1807);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "6:6", 7338, 7338),     new VerseRange(BibleBook.Isaiah, "19:1", 18006, 18006),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "24:29-44", 23987, 24002),    new VerseRange(BibleBook.Matthew, "25:31", 24040, 24040),     new VerseRange(BibleBook.Matthew, "26:30", 24085, 24085),
		];
	}
	private sealed class Exo_11SE : Ahavta
	{
		public Exo_11SE() : base($"{nameof(Id.Exo_11)}", Id.Exo_11) { }
		public override string TriNum => "15.2";
		public override string ParashaName => "Od Nega Echad";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "One More Plague";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "11:1-12:28", 1808, 1845);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "46:13-28", 20059, 20074),     new VerseRange(BibleBook.Micah, "7:15", 22680, 22680),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "3:13-25", 26134, 26146),
		];
	}
	private sealed class Exo_12SE : Ahavta
	{
		public Exo_12SE() : base($"{nameof(Id.Exo_12)}", Id.Exo_12) { }
		public override string TriNum => "15.3";
		public override string ParashaName => "Vayhi-Bachatzi";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "It was at midnight";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "12:29-51", 1846, 1868);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "21:9-12", 18045, 18048),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "6:4-15", 26262, 26273),     new VerseRange(BibleBook.John, "21:1", 26900, 26900),     new VerseRange(BibleBook.Revelation, "18", 30995, 31018),
		];
	}
	private sealed class Exo_13aSE : Ahavta
	{
		public Exo_13aSE() : base($"{nameof(Id.Exo_13a)}", Id.Exo_13a) { }
		public override string TriNum => "15.4";
		public override string ParashaName => "Kadesh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Sanctify";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "13:1-20", 1869, 1888);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "46:3-7", 18590, 18594),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "8:6-9:1", 30099, 30107),     new VerseRange(BibleBook.Hebrews, "9:13-15", 30119, 30121),
		];
	}
	private sealed class Exo_13bSE : Ahavta
	{
		public Exo_13bSE() : base($"{nameof(Id.Exo_13b)}", Id.Exo_13b) { }
		public override string TriNum => "16.1";
		public override string ParashaName => "B'Shalach";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When He let go";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "13:21-15:21", 1889, 1942);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Joshua, "24:1-4", 6478, 6481),     new VerseRange(BibleBook.Judges, "4:4-5:31", 6604, 6655),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "16:25", 26752, 26752),    new VerseRange(BibleBook.Philippians, "4:4-23", 29447, 29466),
		];
	}
	private sealed class Exo_15SE : Ahavta
	{
		public Exo_15SE() : base($"{nameof(Id.Exo_15)}", Id.Exo_15) { }
		public override string TriNum => "16.2";
		public override string ParashaName => "Yasa Moshe";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Moses Caused Them to Journey";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "15:22-16:24", 1943, 1972);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Psalms, "106:7-8", 15659, 15660),    new VerseRange(BibleBook.Isaiah, "49:8-14", 18645, 18651),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Philippians, "4:4-23", 29447, 29466),
		];
	}
	private sealed class Exo_16SE : Ahavta
	{
		public Exo_16SE() : base($"{nameof(Id.Exo_16)}", Id.Exo_16) { }
		public override string TriNum => "16.3";
		public override string ParashaName => "Hayom ki-Shabbat";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Today is Sabbath";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "16:25-17:16", 1973, 2000);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "58:13", 18800, 18800),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "6:35-59", 26293, 26317),
		];
	}
	private sealed class Exo_18SE : Ahavta
	{
		public Exo_18SE() : base($"{nameof(Id.Exo_18)}", Id.Exo_18) { }
		public override string TriNum => "17.1";
		public override string ParashaName => "Yithro";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Priest/Jethro";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "18:1-19:6", 2001, 2033);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "6", 17771, 17783),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "6:1-35", 26259, 26293),     new VerseRange(BibleBook.John, "6:60-71", 26318, 26329),
		];
	}
	private sealed class Exo_19SE : Ahavta
	{
		public Exo_19SE() : base($"{nameof(Id.Exo_19)}", Id.Exo_19) { }
		public override string TriNum => "17.2";
		public override string ParashaName => "T'daber";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "You Shall Speak";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "19:7-20:26", 2034, 2078);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "61:6-10", 18850, 18854),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "12:18", 30231, 30231),     new VerseRange(BibleBook.Hebrews, "12:29", 30242, 30242),
		];
	}
	private sealed class Exo_21SE : Ahavta
	{
		public Exo_21SE() : base($"{nameof(Id.Exo_21)}", Id.Exo_21) { }
		public override string TriNum => "18.1";
		public override string ParashaName => "Mishpatim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Judgements";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "21:1-22:24", 2079, 2138);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "56:1", 18755, 18755),     new VerseRange(BibleBook.Jeremiah, "34", 19803, 19824),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "7:1-5", 23318, 23322),
		];
	}
	private sealed class Exo_22SE : Ahavta
	{
		public Exo_22SE() : base($"{nameof(Id.Exo_22)}", Id.Exo_22) { }
		public override string TriNum => "18.2";
		public override string ParashaName => "Im-kesef Talveh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When You Lend";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "22:25-23:33", 2139, 2178);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "48:10", 18625, 18625),    new VerseRange(BibleBook.Isaiah, "49", 18638, 18663),     new VerseRange(BibleBook.Isaiah, "49:3", 18640, 18640),     new VerseRange(BibleBook.Isaiah, "60:17-61:11", 18839, 18855),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "5", 23236, 23283),
		];
	}
	private sealed class Exo_24SE : Ahavta
	{
		public Exo_24SE() : base($"{nameof(Id.Exo_24)}", Id.Exo_24) { }
		public override string TriNum => "18.3";
		public override string ParashaName => "?";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "?";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "24", 2179, 2196);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "6:11-13", 8908, 8910),    new VerseRange(BibleBook.Isaiah, "60:17-61:9", 18839, 18853),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "26:26-30", 24081, 24085),
		];
	}
	private sealed class Exo_25SE : Ahavta
	{
		public Exo_25SE() : base($"{nameof(Id.Exo_25)}", Id.Exo_25) { }
		public override string TriNum => "19.1";
		public override string ParashaName => "T'rumah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Offering";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "25:1-26:30", 2197, 2273);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "66", 18924, 18947),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "7:25-32", 26354, 26361),    new VerseRange(BibleBook.Hebrews, "9", 30107, 30134),
		];
	}
	private sealed class Exo_27aSE : Ahavta
	{
		public Exo_27aSE() : base($"{nameof(Id.Exo_27a)}", Id.Exo_27a) { }
		public override string TriNum => "19.2";
		public override string ParashaName => "V'ashita Parochet";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "You Shall Make a Partition";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "26:31-27:19", 2274, 2292);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "16:10-19", 20773, 20782),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "23:1-28", 23920, 23947),
		];
	}
	private sealed class Exo_27bSE : Ahavta
	{
		public Exo_27bSE() : base($"{nameof(Id.Exo_27b)}", Id.Exo_27b) { }
		public override string TriNum => "20.1";
		public override string ParashaName => "T'tzaveh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "You shall command";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "27:20-28:43", 2293, 2337);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "3:10-27", 20513, 20530),     new VerseRange(BibleBook.Ezekiel, "43:10-12", 21583, 21585),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "3", 29997, 30015),
		];
	}
	private sealed class Exo_29SE : Ahavta
	{
		public Exo_29SE() : base($"{nameof(Id.Exo_29)}", Id.Exo_29) { }
		public override string TriNum => "20.2";
		public override string ParashaName => "V'tzeh haDabar";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "This is the Word";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "29", 2338, 2383);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "61:6", 18850, 18850),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstPeter, "2", 30401, 30425),
		];
	}
	private sealed class Exo_30aSE : Ahavta
	{
		public Exo_30aSE() : base($"{nameof(Id.Exo_30a)}", Id.Exo_30a) { }
		public override string TriNum => "20.3";
		public override string ParashaName => "V'ashit Mizbe'ach";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "You Shall Make an Altar";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "30:1-10", 2384, 2393);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Malachi, "1:11-2:7", 23101, 23111),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "1:1-25", 24895, 24919),
		];
	}
	private sealed class Exo_30bSE : Ahavta
	{
		public Exo_30bSE() : base($"{nameof(Id.Exo_30b)}", Id.Exo_30b) { }
		public override string TriNum => "21.1";
		public override string ParashaName => "Ki Tisa";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When you elevate";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "30:11-38", 2394, 2421);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "18:1-39", 9343, 9381),    new VerseRange(BibleBook.SecondKings, "12:5", 9856, 9856),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "5:10-11", 28058, 28059),
		];
	}
	private sealed class Exo_31SE : Ahavta
	{
		public Exo_31SE() : base($"{nameof(Id.Exo_31)}", Id.Exo_31) { }
		public override string TriNum => "21.2";
		public override string ParashaName => "R'eh Qaratiy";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "See, I Have Called";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "31:1-32:13", 2422, 2452);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "43:7-21", 18513, 18527),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.SecondTimothy, "1", 29811, 29828),
		];
	}
	private sealed class Exo_32SE : Ahavta
	{
		public Exo_32SE() : base($"{nameof(Id.Exo_32)}", Id.Exo_32) { }
		public override string TriNum => "21.3";
		public override string ParashaName => "Vayifen Vayered Moshe";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Moses Turned and Went Down";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "32:14-34:26", 2453, 2523);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.SecondSamuel, "22:10-51", 8613, 8654),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "9", 28157, 28189),
		];
	}
	private sealed class Exo_34SE : Ahavta
	{
		public Exo_34SE() : base($"{nameof(Id.Exo_34)}", Id.Exo_34) { }
		public override string TriNum => "22.1";
		public override string ParashaName => "Vayakhel";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He assembled";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "34:27-36:38", 2524, 2605);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "18:27-39", 9369, 9381),     new VerseRange(BibleBook.Jeremiah, "31:31-40", 19723, 19732),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.SecondCorinthians, "3", 28843, 28860),
		];
	}
	private sealed class Exo_37SE : Ahavta
	{
		public Exo_37SE() : base($"{nameof(Id.Exo_37)}", Id.Exo_37) { }
		public override string TriNum => "22.2";
		public override string ParashaName => "Vaya'as B'tzal-el";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Betzalel Made";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "37:1-38:20", 2606, 2654);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "7:13-27", 8948, 8962),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "9", 30107, 30134),     new VerseRange(BibleBook.FirstJohn, "1", 30542, 30551),
		];
	}
	private sealed class Exo_38SE : Ahavta
	{
		public Exo_38SE() : base($"{nameof(Id.Exo_38)}", Id.Exo_38) { }
		public override string TriNum => "23.1";
		public override string ParashaName => "Pekude";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Accounts of";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "38:21-31", 2655, 2665);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "8:8-22", 8994, 9008),     new VerseRange(BibleBook.Jeremiah, "30:18-24", 19686, 19692),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.SecondCorinthians, "4:1-5:19", 28861, 28897),
		];
	}
	private sealed class Exo_39SE : Ahavta
	{
		public Exo_39SE() : base($"{nameof(Id.Exo_39)}", Id.Exo_39) { }
		public override string TriNum => "23.2";
		public override string ParashaName => "Vumin HaTechelet";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "From the Blue";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Exodus, "39:1-40:38", 2666, 2746);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "7:13", 8948, 8948),     new VerseRange(BibleBook.Isaiah, "33:20-34:8", 18300, 18312),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "8:1-5", 30094, 30098),     new VerseRange(BibleBook.Revelation, "15", 30948, 30955),
		];
	}
	private sealed class Lev_01SE : Ahavta
	{
		public Lev_01SE() : base($"{nameof(Id.Lev_01)}", Id.Lev_01) { }
		public override string TriNum => "24.1";
		public override string ParashaName => "Vayikra";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And He called";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "1 & 2", 2747, 2779);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "43:21-44:23", 18527, 18557),    new VerseRange(BibleBook.Jeremiah, "31:15-20", 19707, 19712),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstCorinthians, "3", 28412, 28434),
		];
	}
	private sealed class Lev_03SE : Ahavta
	{
		public Lev_03SE() : base($"{nameof(Id.Lev_03)}", Id.Lev_03) { }
		public override string TriNum => "24.2";
		public override string ParashaName => "Vayim tzevach shalamim karbani";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "If a Feast Peace-Offering";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "3", 2780, 2796);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "20:33-44", 20929, 20940),    new VerseRange(BibleBook.Ezekiel, "44:10-14", 21610, 21614),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Revelation, "8", 30829, 30841),
		];
	}
	private sealed class Lev_04SE : Ahavta
	{
		public Lev_04SE() : base($"{nameof(Id.Lev_04)}", Id.Lev_04) { }
		public override string TriNum => "24.3";
		public override string ParashaName => "Nephesh Ki-techeta Mi-shegagah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When a Soul Sins Unintentionally";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "4", 2797, 2831);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "18:4-17", 20854, 20867),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "8:1-13", 28118, 28130),     new VerseRange(BibleBook.Hebrews, "10:1-18", 30135, 30152),
		];
	}
	private sealed class Lev_05SE : Ahavta
	{
		public Lev_05SE() : base($"{nameof(Id.Lev_05)}", Id.Lev_05) { }
		public override string TriNum => "24.4";
		public override string ParashaName => "V'nephesh Ki-techeta";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Then If a Soul Sins";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "5:1-6:7", 2832, 2857);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "15:1-34", 7562, 7595),     new VerseRange(BibleBook.Zechariah, "5 - 7", 22938, 22977),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Revelation, "5 &amp; 6", 30781, 30811),
		];
	}
	private sealed class Lev_06SE : Ahavta
	{
		public Lev_06SE() : base($"{nameof(Id.Lev_06)}", Id.Lev_06) { }
		public override string TriNum => "25.1";
		public override string ParashaName => "Tzav";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Command";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "6:8-30", 2858, 2880);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "7:12-34", 19132, 19154),    new VerseRange(BibleBook.Ezekiel, "36:16-36", 21376, 21396),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Mark, "12:28-34", 24702, 24708),
		];
	}
	private sealed class Lev_07SE : Ahavta
	{
		public Lev_07SE() : base($"{nameof(Id.Lev_07)}", Id.Lev_07) { }
		public override string TriNum => "25.2";
		public override string ParashaName => "Zeh Karban Aharon";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "This is the Offering of Aaron";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "7", 2881, 2918);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Malachi, "3:6-9", 23127, 23130),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "23", 23920, 23958),    new VerseRange(BibleBook.John, "6:63-66", 26321, 26324),
		];
	}
	private sealed class Lev_08SE : Ahavta
	{
		public Lev_08SE() : base($"{nameof(Id.Lev_08)}", Id.Lev_08) { }
		public override string TriNum => "25.3";
		public override string ParashaName => "Qach et-Aharon";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Take Aaron";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "8", 2919, 2954);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "43:27", 21600, 21600),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "24:29-44", 23987, 24002),    new VerseRange(BibleBook.Matthew, "25:31", 24040, 24040),     new VerseRange(BibleBook.Matthew, "26:30", 24085, 24085),
		];
	}
	private sealed class Lev_09SE : Ahavta
	{
		public Lev_09SE() : base($"{nameof(Id.Lev_09)}", Id.Lev_09) { }
		public override string TriNum => "26.1";
		public override string ParashaName => "Shemeni";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Eighth";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "9 - 11", 2955, 3045);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.SecondSamuel, "6:1-7", 8159, 8165),    new VerseRange(BibleBook.FirstKings, "8:54-61", 9040, 9047),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Mark, "7:1-23", 24465, 24487),
		];
	}
	private sealed class Lev_12SE : Ahavta
	{
		public Lev_12SE() : base($"{nameof(Id.Lev_12)}", Id.Lev_12) { }
		public override string TriNum => "27.1";
		public override string ParashaName => "Tazria";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "She bears seed";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "12:1-13:28", 3046, 3081);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.SecondKings, "4:42-5:19", 9646, 9667),     new VerseRange(BibleBook.Isaiah, "66:7", 18930, 18930),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "1:18-24", 23163, 23169),     new VerseRange(BibleBook.John, "7:37-44", 26366, 26373),
		];
	}
	private sealed class Lev_13SE : Ahavta
	{
		public Lev_13SE() : base($"{nameof(Id.Lev_13)}", Id.Lev_13) { }
		public override string TriNum => "27.2";
		public override string ParashaName => "B'rosh u B'tzaqan";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "In the Scalp or In the Beard";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "13:29-59", 3082, 3112);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "2:11-18", 29979, 29996),
		];
	}
	private sealed class Lev_14SE : Ahavta
	{
		public Lev_14SE() : base($"{nameof(Id.Lev_14)}", Id.Lev_14) { }
		public override string TriNum => "28.1";
		public override string ParashaName => "Metzorah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Infected One";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "14", 3113, 3169);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.SecondKings, "7:1-16", 9709, 9724),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "8:1-4", 23347, 23350),     new VerseRange(BibleBook.Luke, "5:12-14", 25120, 25122),    new VerseRange(BibleBook.Ephesians, "4", 29274, 29305),
		];
	}
	private sealed class Lev_15SE : Ahavta
	{
		public Lev_15SE() : base($"{nameof(Id.Lev_15)}", Id.Lev_15) { }
		public override string TriNum => "28.2";
		public override string ParashaName => "Ish Ish Chai";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When Any Man";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "15", 3170, 3202);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "43:18-27", 21591, 21600),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Philippians, "3", 29423, 29443),
		];
	}
	private sealed class Lev_16SE : Ahavta
	{
		public Lev_16SE() : base($"{nameof(Id.Lev_16)}", Id.Lev_16) { }
		public override string TriNum => "30.1";
		public override string ParashaName => "Achare Mot";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "After the death";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "16", 3203, 3236);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "44:1-15", 21601, 21615),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Jude, "1:6-21", 30679, 30694),
		];
	}
	private sealed class Lev_17SE : Ahavta
	{
		public Lev_17SE() : base($"{nameof(Id.Lev_17)}", Id.Lev_17) { }
		public override string TriNum => "30.2";
		public override string ParashaName => "Asher Yishchat";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Who Slaughters";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "17", 3237, 3252);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "22:1-19", 20978, 20996),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstJohn, "5", 30626, 30646),
		];
	}
	private sealed class Lev_18SE : Ahavta
	{
		public Lev_18SE() : base($"{nameof(Id.Lev_18)}", Id.Lev_18) { }
		public override string TriNum => "30.3";
		public override string ParashaName => "K'maaseh Eretz";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "The Practice in the Land";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "18", 3253, 3282);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "22:20-31", 20997, 21008),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstCorinthians, "5:1-6:10", 28456, 28488),
		];
	}
	private sealed class Lev_19SE : Ahavta
	{
		public Lev_19SE() : base($"{nameof(Id.Lev_19)}", Id.Lev_19) { }
		public override string TriNum => "31.1";
		public override string ParashaName => "Kedoshim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Set apart Ones";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "19 & 20", 3283, 3346);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "4", 17735, 17740),    new VerseRange(BibleBook.Amos, "9", 22497, 22511),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "18", 23729, 23763),
		];
	}
	private sealed class Lev_21SE : Ahavta
	{
		public Lev_21SE() : base($"{nameof(Id.Lev_21)}", Id.Lev_21) { }
		public override string TriNum => "32.1";
		public override string ParashaName => "Emor";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Say";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "21", 3347, 3370);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "44", 21601, 21631),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstCorinthians, "7:17", 28505, 28505),
		];
	}
	private sealed class Lev_22SE : Ahavta
	{
		public Lev_22SE() : base($"{nameof(Id.Lev_22)}", Id.Lev_22) { }
		public override string TriNum => "32.2";
		public override string ParashaName => "Daber elAharon";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Tell Aaron";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "22 & 23", 3371, 3447);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "56", 18755, 18766),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstCorinthians, "15:20-23", 28739, 28742),
		];
	}
	private sealed class Lev_24SE : Ahavta
	{
		public Lev_24SE() : base($"{nameof(Id.Lev_24)}", Id.Lev_24) { }
		public override string TriNum => "32.3";
		public override string ParashaName => "Shemen Zayot";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Oil of Pressed Olives";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "24", 3448, 3470);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Hosea, "14", 22284, 22292),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "7", 26330, 26382),
		];
	}
	private sealed class Lev_25aSE : Ahavta
	{
		public Lev_25aSE() : base($"{nameof(Id.Lev_25a)}", Id.Lev_25a) { }
		public override string TriNum => "33.1";
		public override string ParashaName => "Behar";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "On the mount";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "25:1-38", 3471, 3508);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "32:6-27", 19738, 19759),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "10:1-33", 26483, 26515),
		];
	}
	private sealed class Lev_25bSE : Ahavta
	{
		public Lev_25bSE() : base($"{nameof(Id.Lev_25b)}", Id.Lev_25b) { }
		public override string TriNum => "33.2";
		public override string ParashaName => "V'ki Amuk";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "If Impoverished";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "25:39-26:2", 3509, 3527);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "12:17-28", 20698, 20709),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Galatians, "4:1-5:1", 29133, 29164),
		];
	}
	private sealed class Lev_26SE : Ahavta
	{
		public Lev_26SE() : base($"{nameof(Id.Lev_26)}", Id.Lev_26) { }
		public override string TriNum => "34.1";
		public override string ParashaName => "B'chukkotal";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "In My statutes";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Leviticus, "26:3-27:34", 3528, 3605);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "16:16-17:4", 19353, 19362),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "15", 26701, 26727),
		];
	}
	private sealed class Num_01SE : Ahavta
	{
		public Num_01SE() : base($"{nameof(Id.Num_01)}", Id.Num_01) { }
		public override string TriNum => "35.1";
		public override string ParashaName => "Bemidar";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "In the wilderness";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "1:1-2:13", 3606, 3672);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "47:13-23", 21693, 21703),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Revelation, "7", 30812, 30828),
		];
	}
	private sealed class Num_02SE : Ahavta
	{
		public Num_02SE() : base($"{nameof(Id.Num_02)}", Id.Num_02) { }
		public override string TriNum => "35.2";
		public override string ParashaName => "Ish Al Diglo";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Each Man by His Own Banner";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "2:14-3:13", 3673, 3706);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "8:18-22", 17826, 17830),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "15:1-7", 25590, 25596),
		];
	}
	private sealed class Num_03SE : Ahavta
	{
		public Num_03SE() : base($"{nameof(Id.Num_03)}", Id.Num_03) { }
		public override string TriNum => "35.3";
		public override string ParashaName => "V'eleh Toldot";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "These are the Generations";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "3:14-4:20", 3707, 3764);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "43:8-13", 18514, 18519),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "5:1-16", 27061, 27076),     new VerseRange(BibleBook.Hebrews, "12", 30214, 30242),
		];
	}
	private sealed class Num_04SE : Ahavta
	{
		public Num_04SE() : base($"{nameof(Id.Num_04)}", Id.Num_04) { }
		public override string TriNum => "37.1";
		public override string ParashaName => "Naso";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Elevate";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "4:21-5:10", 3765, 3803);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Judges, "13:2-25", 6887, 6910),    new VerseRange(BibleBook.FirstSamuel, "6:10-16", 7342, 7348),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstCorinthians, "12:12-18", 28647, 28653),
		];
	}
	private sealed class Num_05SE : Ahavta
	{
		public Num_05SE() : base($"{nameof(Id.Num_05)}", Id.Num_05) { }
		public override string TriNum => "37.2";
		public override string ParashaName => "Ki Tisteh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "If She Goes Astray";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "5:11-31", 3804, 3824);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Hosea, "4:14-15", 22148, 22149),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.SecondPeter, "2", 30502, 30523),
		];
	}
	private sealed class Num_06aSE : Ahavta
	{
		public Num_06aSE() : base($"{nameof(Id.Num_06a)}", Id.Num_06a) { }
		public override string TriNum => "37.3";
		public override string ParashaName => "Ki Yafli Lindor";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "If . . . Make a Special Vow";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "6:1-21", 3825, 3845);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "1:7-11", 7220, 7224),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "1:8-17", 24902, 24911),
		];
	}
	private sealed class Num_06bSE : Ahavta
	{
		public Num_06bSE() : base($"{nameof(Id.Num_06b)}", Id.Num_06b) { }
		public override string TriNum => "37.4";
		public override string ParashaName => "Ko haBarchu";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Thus Shall You Bless";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "6:22-7:89", 3846, 3940);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "31:21-34", 19713, 19726),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "13:1-30", 26632, 26661),
		];
	}
	private sealed class Num_08SE : Ahavta
	{
		public Num_08SE() : base($"{nameof(Id.Num_08)}", Id.Num_08) { }
		public override string TriNum => "38.1";
		public override string ParashaName => "B'ha'alot'cha";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "In your going up";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "8-9", 3941, 3989);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Zechariah, "4", 22924, 22937),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Revelation, "11", 30874, 30892),
		];
	}
	private sealed class Num_10SE : Ahavta
	{
		public Num_10SE() : base($"{nameof(Id.Num_10)}", Id.Num_10) { }
		public override string TriNum => "38.2";
		public override string ParashaName => "Avo-yamaim vo-chodesh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Whether days or a month";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "10", 3990, 4025);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "27:7-12", 7938, 7943),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstCorinthians, "14:1-9", 28680, 28688),
		];
	}
	private sealed class Num_11SE : Ahavta
	{
		public Num_11SE() : base($"{nameof(Id.Num_11)}", Id.Num_11) { }
		public override string TriNum => "38.3";
		public override string ParashaName => "Ha'am Bemitun'nim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "The People Sought Complaints";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "11", 4026, 4060);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "12:3-12", 27341, 27350),    new VerseRange(BibleBook.FirstCorinthians, "10", 28569, 28601),
		];
	}
	private sealed class Num_12SE : Ahavta
	{
		public Num_12SE() : base($"{nameof(Id.Num_12)}", Id.Num_12) { }
		public override string TriNum => "38.4";
		public override string ParashaName => "Vatdaber Miryam vAharon";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Miriam and Aaron spoke";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "12", 4061, 4076);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "11:22-13:4", 28232, 28271),     new VerseRange(BibleBook.Isaiah, "59:1-21", 18802, 18822),
		];
	}
	private sealed class Num_13SE : Ahavta
	{
		public Num_13SE() : base($"{nameof(Id.Num_13)}", Id.Num_13) { }
		public override string TriNum => "39.1";
		public override string ParashaName => "Shelah L'cha";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Send for yourself";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "13", 4077, 4109);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Joshua, "2:1-11", 5871, 5881),     new VerseRange(BibleBook.Joshua, "18:1-2", 6295, 6296),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "11:24-31", 30197, 30204),
		];
	}
	private sealed class Num_14SE : Ahavta
	{
		public Num_14SE() : base($"{nameof(Id.Num_14)}", Id.Num_14) { }
		public override string TriNum => "39.2";
		public override string ParashaName => "Vayibchu haAm";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "The People Wept";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "14", 4110, 4154);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.SecondChronicles, "36:5-23", 11999, 12017),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Philippians, "3", 29423, 29443),
		];
	}
	private sealed class Num_15SE : Ahavta
	{
		public Num_15SE() : base($"{nameof(Id.Num_15)}", Id.Num_15) { }
		public override string TriNum => "39.3";
		public override string ParashaName => "Ki Tavo'u el Eretz";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When You Come into the Land";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "15", 4155, 4195);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "17:19-27", 19377, 19385),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstJohn, "2 and 3", 30552, 30604),
		];
	}
	private sealed class Num_16SE : Ahavta
	{
		public Num_16SE() : base($"{nameof(Id.Num_16)}", Id.Num_16) { }
		public override string TriNum => "40.1";
		public override string ParashaName => "Korach";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Korah";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "16", 4196, 4245);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "11:14-12:22", 7460, 7483),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.SecondTimothy, "2:8-21", 29836, 29849),    new VerseRange(BibleBook.Jude, "1", 30674, 30698),
		];
	}
	private sealed class Num_17SE : Ahavta
	{
		public Num_17SE() : base($"{nameof(Id.Num_17)}", Id.Num_17) { }
		public override string TriNum => "40.2";
		public override string ParashaName => "V'qach Meitam Mattah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Take from Them a Staff";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "17 & 18", 4246, 4290);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "44:15-28", 21615, 21628),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "5:1-6", 30032, 30037),
		];
	}
	private sealed class Num_19SE : Ahavta
	{
		public Num_19SE() : base($"{nameof(Id.Num_19)}", Id.Num_19) { }
		public override string TriNum => "41.1";
		public override string ParashaName => "Chukkat";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Ordinance of";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "19:1-20:13", 4291, 4325);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Judges, "11:1-33", 6831, 6863),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "20:1-31", 26869, 26899),
		];
	}
	private sealed class Num_20SE : Ahavta
	{
		public Num_20SE() : base($"{nameof(Id.Num_20)}", Id.Num_20) { }
		public override string TriNum => "41.2";
		public override string ParashaName => "Malachim MiKadesh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Messengers from Kadesh";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "20:14-22:1", 4326, 4377);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "44:29-31", 21629, 21631),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "20:1-31", 26122, 26152),
		];
	}
	private sealed class Num_22SE : Ahavta
	{
		public Num_22SE() : base($"{nameof(Id.Num_22)}", Id.Num_22) { }
		public override string TriNum => "42.1";
		public override string ParashaName => "Balak";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Destoyer";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "22:2-23:1", 4378, 4418);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Micah, "5:6-6:8", 22640, 22657),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstPeter, "5:5-7", 30471, 30473),
		];
	}
	private sealed class Num_23SE : Ahavta
	{
		public Num_23SE() : base($"{nameof(Id.Num_23)}", Id.Num_23) { }
		public override string TriNum => "42.2";
		public override string ParashaName => "V'yaas Balaq";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Balak Did";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "23:2-25:9", 4419, 4481);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Joshua, "17:1-18", 6277, 6294),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.James, "3:1-4:17", 30321, 30355),
		];
	}
	private sealed class Num_25SE : Ahavta
	{
		public Num_25SE() : base($"{nameof(Id.Num_25)}", Id.Num_25) { }
		public override string TriNum => "43.1";
		public override string ParashaName => "Pin'has";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Dark Skin";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "25:10-26:51", 4482, 4541);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstKings, "18:46-19:21", 9388, 9409),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "23:1-12", 23920, 23931),     new VerseRange(BibleBook.Ephesians, "4:1-16", 29274, 29289),
		];
	}
	private sealed class Num_26SE : Ahavta
	{
		public Num_26SE() : base($"{nameof(Id.Num_26)}", Id.Num_26) { }
		public override string TriNum => "43.2";
		public override string ParashaName => "L'eleh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "To These";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "26:52-27:23", 4542, 4578);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Malachi, "2:1-9", 23105, 23113),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Ephesians, "1:3-23", 29210, 29230),
		];
	}
	private sealed class Num_28SE : Ahavta
	{
		public Num_28SE() : base($"{nameof(Id.Num_28)}", Id.Num_28) { }
		public override string TriNum => "43.3";
		public override string ParashaName => "Qarbani";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "My Offerings";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "28 & 29", 4579, 4649);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "45:13-25", 21644, 21656),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Hebrews, "10:1-39", 30135, 30173),
		];
	}
	private sealed class Num_30SE : Ahavta
	{
		public Num_30SE() : base($"{nameof(Id.Num_30)}", Id.Num_30) { }
		public override string TriNum => "44.1";
		public override string ParashaName => "Matot";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Tribes";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "30 & 31", 4650, 4719);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "1:1-2:3", 18948, 18969),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "5:33-37", 23268, 23272),
		];
	}
	private sealed class Num_32SE : Ahavta
	{
		public Num_32SE() : base($"{nameof(Id.Num_32)}", Id.Num_32) { }
		public override string TriNum => "44.2";
		public override string ParashaName => "Umiqneh Rav";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Much Cattle";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "32", 4720, 4761);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "2", 18967, 19003),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.James, "2:1-26", 30295, 30320),
		];
	}
	private sealed class Num_33SE : Ahavta
	{
		public Num_33SE() : base($"{nameof(Id.Num_33)}", Id.Num_33) { }
		public override string TriNum => "45.1";
		public override string ParashaName => "Masa'ei";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Stages";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "33", 4762, 4817);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "3", 19004, 19028),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Acts, "6", 27103, 27117),    new VerseRange(BibleBook.James, "4:1-12", 30339, 30350),
		];
	}
	private sealed class Num_34SE : Ahavta
	{
		public Num_34SE() : base($"{nameof(Id.Num_34)}", Id.Num_34) { }
		public override string TriNum => "45.2";
		public override string ParashaName => "Zot haAretz";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "This is the Land";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "34:1-35:8", 4818, 4854);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "4", 19029, 19059),    new VerseRange(BibleBook.Ezekiel, "45:1-8", 21632, 21639),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Ephesians, "2:1-22", 29231, 29252),
		];
	}
	private sealed class Num_35SE : Ahavta
	{
		public Num_35SE() : base($"{nameof(Id.Num_35)}", Id.Num_35) { }
		public override string TriNum => "45.3";
		public override string ParashaName => "Ki Atem Ovrim et haYarden";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When You Cross the Jordan";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Numbers, "35:9-36:13", 4855, 4893);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "5", 19060, 19090),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "4:1-45", 26158, 26202),
		];
	}
	private sealed class Deu_01SE : Ahavta
	{
		public Deu_01SE() : base($"{nameof(Id.Deu_01)}", Id.Deu_01) { }
		public override string TriNum => "46.1";
		public override string ParashaName => "Devarim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Words";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "1", 4894, 4939);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "1:1-27", 17656, 17682),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.FirstTimothy, "3:1-7", 29733, 29739),    new VerseRange(BibleBook.Hebrews, "3", 29997, 30015),
		];
	}
	private sealed class Deu_02SE : Ahavta
	{
		public Deu_02SE() : base($"{nameof(Id.Deu_02)}", Id.Deu_02) { }
		public override string TriNum => "46.2";
		public override string ParashaName => "Vanephen";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "We Turned";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "2:1-3:22", 4940, 4998);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "9", 28157, 28189),
		];
	}
	private sealed class Deu_03SE : Ahavta
	{
		public Deu_03SE() : base($"{nameof(Id.Deu_03)}", Id.Deu_03) { }
		public override string TriNum => "47.1";
		public override string ParashaName => "Va’etchanan";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And I pleaded";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "3:23-29", 4999, 5005);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "40:1-11", 18422, 18432),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Mark, "12:28-34", 24702, 24708),     new VerseRange(BibleBook.Romans, "2:1-3:31", 27964, 28023),
		];
	}
	private sealed class Deu_04SE : Ahavta
	{
		public Deu_04SE() : base($"{nameof(Id.Deu_04)}", Id.Deu_04) { }
		public override string TriNum => "47.2";
		public override string ParashaName => "Yisrael, Sh'ma";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Israel, Listen";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "4", 5006, 5054);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "40:12-14", 18433, 18435),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "3:1", 25027, 25027),
		];
	}
	private sealed class Deu_05SE : Ahavta
	{
		public Deu_05SE() : base($"{nameof(Id.Deu_05)}", Id.Deu_05) { }
		public override string TriNum => "47.3";
		public override string ParashaName => "Vayiqra Moshe";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Moses Summoned";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "5:1-6:3", 5055, 5090);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "40:15-26", 18436, 18447),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "10:1", 28190, 28190),
		];
	}
	private sealed class Deu_06SE : Ahavta
	{
		public Deu_06SE() : base($"{nameof(Id.Deu_06)}", Id.Deu_06) { }
		public override string TriNum => "47.4";
		public override string ParashaName => "Vazot haMitzvot";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "This is the Commandment";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "6:4-7:26", 5091, 5138);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "4:1", 23211, 23211),
		];
	}
	private sealed class Deu_08SE : Ahavta
	{
		public Deu_08SE() : base($"{nameof(Id.Deu_08)}", Id.Deu_08) { }
		public override string TriNum => "48.1";
		public override string ParashaName => "Ekev";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "On the heel of (because)";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "8", 5139, 5158);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "49:14-51:3", 18651, 18677),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "4:11", 25075, 25075),     new VerseRange(BibleBook.Romans, "8:31-39", 28148, 28156),
		];
	}
	private sealed class Deu_09SE : Ahavta
	{
		public Deu_09SE() : base($"{nameof(Id.Deu_09)}", Id.Deu_09) { }
		public override string TriNum => "48.2";
		public override string ParashaName => "Atah Over Hayom";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "You are Crossing Over Today";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "9", 5159, 5187);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Ephesians, "2:11", 29241, 29241),
		];
	}
	private sealed class Deu_10SE : Ahavta
	{
		public Deu_10SE() : base($"{nameof(Id.Deu_10)}", Id.Deu_10) { }
		public override string TriNum => "48.3";
		public override string ParashaName => "Pesal Lecha";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Carve for Yourself";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "10:1-11:25", 5188, 5234);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Colossians, "3:1", 29519, 29519),
		];
	}
	private sealed class Deu_11SE : Ahavta
	{
		public Deu_11SE() : base($"{nameof(Id.Deu_11)}", Id.Deu_11) { }
		public override string TriNum => "49.1";
		public override string ParashaName => "Re'eh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "See!";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "11:26-12:19", 5235, 5260);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "54:11-55:5", 18735, 18746),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "6:20", 25167, 25167),     new VerseRange(BibleBook.FirstJohn, "4:1-6", 30605, 30610),
		];
	}
	private sealed class Deu_12SE : Ahavta
	{
		public Deu_12SE() : base($"{nameof(Id.Deu_12)}", Id.Deu_12) { }
		public override string TriNum => "49.2";
		public override string ParashaName => "Ki-Yarchiv";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When He Enlarges";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "12:20-15:6", 5261, 5326);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "7:15", 23332, 23332),
		];
	}
	private sealed class Deu_15SE : Ahavta
	{
		public Deu_15SE() : base($"{nameof(Id.Deu_15)}", Id.Deu_15) { }
		public override string TriNum => "49.3";
		public override string ParashaName => "Ev-yon";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "A Poor Man";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "15:7-16:17", 5327, 5360);

		public override List<VerseRange>? HaftorahVerses => null;

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "4:14", 25078, 25078),
		];
	}
	private sealed class Deu_16SE : Ahavta
	{
		public Deu_16SE() : base($"{nameof(Id.Deu_16)}", Id.Deu_16) { }
		public override string TriNum => "50.1";
		public override string ParashaName => "Shoftim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Judges";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "16:18-17:13", 5361, 5378);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "51:12-52:12", 18686, 18709),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "5:1", 26212, 26212),    new VerseRange(BibleBook.FirstCorinthians, "5:9-13", 28464, 28468),
		];
	}
	private sealed class Deu_17SE : Ahavta
	{
		public Deu_17SE() : base($"{nameof(Id.Deu_17)}", Id.Deu_17) { }
		public override string TriNum => "50.2";
		public override string ParashaName => "Ki haBo";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When You Enter";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "17:14-18:13", 5379, 5398);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.FirstSamuel, "8:1-7", 7371, 7377),     new VerseRange(BibleBook.Jeremiah, "31:31-34", 19723, 19726),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "19:11-22", 19723, 19726),     new VerseRange(BibleBook.Acts, "13:13-44", 27376, 27407),
		];
	}
	private sealed class Deu_18SE : Ahavta
	{
		public Deu_18SE() : base($"{nameof(Id.Deu_18)}", Id.Deu_18) { }
		public override string TriNum => "50.3";
		public override string ParashaName => "Navi Miqirb'cha";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "A Prophet from Your Midst";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "18:14-20:9", 5399, 5437);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "29:8-30:9", 19644, 19677),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Galatians, "5:1-6:10", 29164, 29199),
		];
	}
	private sealed class Deu_20SE : Ahavta
	{
		public Deu_20SE() : base($"{nameof(Id.Deu_20)}", Id.Deu_20) { }
		public override string TriNum => "50.4";
		public override string ParashaName => "Ki Tiqrav el Iyr";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When You Approach a City";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "20:10-21:9", 5438, 5457);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Joshua, "24:1-15", 6478, 6492),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "10:11-31", 26493, 26513),
		];
	}
	private sealed class Deu_21SE : Ahavta
	{
		public Deu_21SE() : base($"{nameof(Id.Deu_21)}", Id.Deu_21) { }
		public override string TriNum => "51.1";
		public override string ParashaName => "Ki Tetse";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When you go out";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "21:10-22:5", 5458, 5476);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "54:1-10", 18725, 18734),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "20:27-38", 25807, 25818),     new VerseRange(BibleBook.Galatians, "3:1-5:26", 29104, 29189),
		];
	}
	private sealed class Deu_22SE : Ahavta
	{
		public Deu_22SE() : base($"{nameof(Id.Deu_22)}", Id.Deu_22) { }
		public override string TriNum => "51.2";
		public override string ParashaName => "Kein Tzipor";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "A Bird|s Nest";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "22:6-23:8", 5477, 5509);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Micah, "5:1-6", 22635, 22640),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "22:1-14", 23874, 23887),
		];
	}
	private sealed class Deu_23aSE : Ahavta
	{
		public Deu_23aSE() : base($"{nameof(Id.Deu_23a)}", Id.Deu_23a) { }
		public override string TriNum => "51.3";
		public override string ParashaName => "Ki-tetzei Machaneh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When a Camp";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "23:9-20", 5510, 5521);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "1:16-26", 17671, 17681),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "8:1-14", 23347, 23360),
		];
	}
	private sealed class Deu_23bSE : Ahavta
	{
		public Deu_23bSE() : base($"{nameof(Id.Deu_23b)}", Id.Deu_23b) { }
		public override string TriNum => "51.4";
		public override string ParashaName => "Ki-chidor neder";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When You Make a Vow";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "23:21-24:18", 5522, 5544);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "19:1-25", 18006, 18030),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "5:30-37", 23265, 23272),
		];
	}
	private sealed class Deu_24SE : Ahavta
	{
		public Deu_24SE() : base($"{nameof(Id.Deu_24)}", Id.Deu_24) { }
		public override string TriNum => "51.5";
		public override string ParashaName => "Ki-tik'tzor";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When You Reap";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "24:19-25:19", 5545, 5567);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Hosea, "10:12-15", 22238, 22241),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Luke, "12:13-48", 25473, 25508),
		];
	}
	private sealed class Deu_26SE : Ahavta
	{
		public Deu_26SE() : base($"{nameof(Id.Deu_26)}", Id.Deu_26) { }
		public override string TriNum => "52.1";
		public override string ParashaName => "Ki Tavo";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "When you enter in";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "26 & 27", 5568, 5612);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "60", 18823, 18844),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "11:1-15", 28211, 28225),    new VerseRange(BibleBook.Revelation, "21:9-22:7", 31063, 31088),
		];
	}
	private sealed class Deu_28SE : Ahavta
	{
		public Deu_28SE() : base($"{nameof(Id.Deu_28)}", Id.Deu_28) { }
		public override string TriNum => "52.2";
		public override string ParashaName => "Im-Shamoa";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "If You Hearken";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "28:1-29:9", 5613, 5689);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "55:1-5", 18742, 18746),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "14:1-31", 26670, 26700),
		];
	}
	private sealed class Deu_29SE : Ahavta
	{
		public Deu_29SE() : base($"{nameof(Id.Deu_29)}", Id.Deu_29) { }
		public override string TriNum => "53.1";
		public override string ParashaName => "Nitsavim";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "You are standing";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "29:10-30:10", 5690, 5719);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Isaiah, "55:6-58:8", 18747, 18795),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Romans, "10:1-13", 28190, 28202),
		];
	}
	private sealed class Deu_30SE : Ahavta
	{
		public Deu_30SE() : base($"{nameof(Id.Deu_30)}", Id.Deu_30) { }
		public override string TriNum => "53.2";
		public override string ParashaName => "haMitzvah";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "This Commandment";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "30:11-31:13", 5720, 5742);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Jeremiah, "12:15-17", 19267, 18746),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "11:7-30", 23467, 23490),
		];
	}
	private sealed class Deu_31SE : Ahavta
	{
		public Deu_31SE() : base($"{nameof(Id.Deu_31)}", Id.Deu_31) { }
		public override string TriNum => "64.1";
		public override string ParashaName => "Vayelekh";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "And he went";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "31:14-30", 5743, 5759);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Hosea, "14:2-9", 22285, 22292),    new VerseRange(BibleBook.Joel, "2:15-27", 22327, 22339),    new VerseRange(BibleBook.Micah, "7:18-20", 22683, 22685),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "12:35-14:26", 26616, 26695),    new VerseRange(BibleBook.Hebrews, "13:5-8", 30247, 30250),
		];
	}
	private sealed class Deu_32SE : Ahavta
	{
		public Deu_32SE() : base($"{nameof(Id.Deu_32)}", Id.Deu_32) { }
		public override string TriNum => "66.1";
		public override string ParashaName => "Haazinu";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Give ear";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "32", 5760, 5811);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "17:22-24", 20848, 20850),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.John, "17:1-26", 26761, 26786),
		];
	}
	private sealed class Deu_33SE : Ahavta
	{
		public Deu_33SE() : base($"{nameof(Id.Deu_33)}", Id.Deu_33) { }
		public override string TriNum => "67.1";
		public override string ParashaName => "VeZot HaBracha";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "This is the blessing";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "33", 5812, 5840);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Ezekiel, "37:15-20", 21413, 21418),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "19:25-20:16", 23788, 23809),     new VerseRange(BibleBook.Jude, "1:8-9", 30681, 30682),
		];
	}
	private sealed class Deu_34SE : Ahavta
	{
		public Deu_34SE() : base($"{nameof(Id.Deu_34)}", Id.Deu_34) { }
		public override string TriNum => "68.1";
		public override string ParashaName => "Vayaal Moshe";
		public override string NameUrl => NameUrl;
		public override string AhavtaURL => "";
		public override string Meaning => "Moses Ascended";

		public override VerseRange TorahVerse => new VerseRange(BibleBook.Deuteronomy, "34", 5841, 5852);

		public override List<VerseRange> HaftorahVerses =>
		[
			new VerseRange(BibleBook.Joshua, "1", 5853, 5870),
		];

		public override List<VerseRange> BritVerses =>
		[
			new VerseRange(BibleBook.Matthew, "4:5-11", 23215, 23221),
		];
	}
	#endregion

}
//	protected List<Data.CalendarQuery>? DataMonth { get; set; } = new List<Data.CalendarQuery>();



