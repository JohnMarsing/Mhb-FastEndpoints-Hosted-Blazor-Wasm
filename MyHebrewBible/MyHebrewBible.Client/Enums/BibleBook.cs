// Ignore Spelling: Abrv Songof Colossians Thessalonians Philemon

using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Enums;

public enum BookGroupEnum
{
	Torah = 1,
	History = 2,
	Poetry = 3,
	MajorProphets = 4,
	MinorProphets = 5,
	Gospels = 6,
	PaulsEpistles = 7,
	GeneralEpistles = 8,
	Apocalypse = 9,
}

public enum BookEnum
{
	Genesis = 1,
	Exodus = 2,
	Leviticus = 3,
	Numbers = 4,
	Deuteronomy = 5,
	Joshua = 6,
	Judges = 7,
	Ruth = 8,
	FirstSamuel = 9,
	SecondSamuel = 10,
	FirstKings = 11,
	SecondKings = 12,
	FirstChronicles = 13,
	SecondChronicles = 14,
	Ezra = 15,
	Nehemiah = 16,
	Esther = 17,
	Job = 18,
	Psalms = 19,
	Proverbs = 20,
	Ecclesiastes = 21,
	SongofSolomon = 22,
	Isaiah = 23,
	Jeremiah = 24,
	Lamentations = 25,
	Ezekiel = 26,
	Daniel = 27,
	Hosea = 28,
	Joel = 29,
	Amos = 30,
	Obadiah = 31,
	Jonah = 32,
	Micah = 33,
	Nahum = 34,
	Habakkuk = 35,
	Zephaniah = 36,
	Haggai = 37,
	Zechariah = 38,
	Malachi = 39,
	Matthew = 40,
	Mark = 41,
	Luke = 42,
	John = 43,
	Acts = 44,
	Romans = 45,
	FirstCorinthians = 46,
	SecondCorinthians = 47,
	Galatians = 48,
	Ephesians = 49,
	Philippians = 50,
	Colossians = 51,
	FirstThessalonians = 52,
	SecondThessalonians = 53,
	FirstTimothy = 54,
	SecondTimothy = 55,
	Titus = 56,
	Philemon = 57,
	Hebrews = 58,
	James = 59,
	FirstPeter = 60,
	SecondPeter = 61,
	FirstJohn = 62,
	SecondJohn = 63,
	ThirdJohn = 64,
	Jude = 65,
	Revelation = 66,
}

public abstract class BibleBook : SmartEnum<BibleBook>
{
	#region Id's
	// Use BookEnum
	#endregion


	#region  Declared Public Instances
	public static readonly BibleBook Genesis = new GenesisSE();
	public static readonly BibleBook Exodus = new ExodusSE();
	public static readonly BibleBook Leviticus = new LeviticusSE();
	public static readonly BibleBook Numbers = new NumbersSE();
	public static readonly BibleBook Deuteronomy = new DeuteronomySE();
	public static readonly BibleBook Joshua = new JoshuaSE();
	public static readonly BibleBook Judges = new JudgesSE();
	public static readonly BibleBook Ruth = new RuthSE();
	public static readonly BibleBook FirstSamuel = new FirstSamuelSE();
	public static readonly BibleBook SecondSamuel = new SecondSamuelSE();
	public static readonly BibleBook FirstKings = new FirstKingsSE();
	public static readonly BibleBook SecondKings = new SecondKingsSE();
	public static readonly BibleBook FirstChronicles = new FirstChroniclesSE();
	public static readonly BibleBook SecondChronicles = new SecondChroniclesSE();
	public static readonly BibleBook Ezra = new EzraSE();
	public static readonly BibleBook Nehemiah = new NehemiahSE();
	public static readonly BibleBook Esther = new EstherSE();
	public static readonly BibleBook Job = new JobSE();
	public static readonly BibleBook Psalms = new PsalmsSE();
	public static readonly BibleBook Proverbs = new ProverbsSE();
	public static readonly BibleBook Ecclesiastes = new EcclesiastesSE();
	public static readonly BibleBook SongofSolomon = new SongofSolomonSE();
	public static readonly BibleBook Isaiah = new IsaiahSE();
	public static readonly BibleBook Jeremiah = new JeremiahSE();
	public static readonly BibleBook Lamentations = new LamentationsSE();
	public static readonly BibleBook Ezekiel = new EzekielSE();
	public static readonly BibleBook Daniel = new DanielSE();
	public static readonly BibleBook Hosea = new HoseaSE();
	public static readonly BibleBook Joel = new JoelSE();
	public static readonly BibleBook Amos = new AmosSE();
	public static readonly BibleBook Obadiah = new ObadiahSE();
	public static readonly BibleBook Jonah = new JonahSE();
	public static readonly BibleBook Micah = new MicahSE();
	public static readonly BibleBook Nahum = new NahumSE();
	public static readonly BibleBook Habakkuk = new HabakkukSE();
	public static readonly BibleBook Zephaniah = new ZephaniahSE();
	public static readonly BibleBook Haggai = new HaggaiSE();
	public static readonly BibleBook Zechariah = new ZechariahSE();
	public static readonly BibleBook Malachi = new MalachiSE();
	public static readonly BibleBook Matthew = new MatthewSE();
	public static readonly BibleBook Mark = new MarkSE();
	public static readonly BibleBook Luke = new LukeSE();
	public static readonly BibleBook John = new JohnSE();
	public static readonly BibleBook Acts = new ActsSE();
	public static readonly BibleBook Romans = new RomansSE();
	public static readonly BibleBook FirstCorinthians = new FirstCorinthiansSE();
	public static readonly BibleBook SecondCorinthians = new SecondCorinthiansSE();
	public static readonly BibleBook Galatians = new GalatiansSE();
	public static readonly BibleBook Ephesians = new EphesiansSE();
	public static readonly BibleBook Philippians = new PhilippiansSE();
	public static readonly BibleBook Colossians = new ColossiansSE();
	public static readonly BibleBook FirstThessalonians = new FirstThessaloniansSE();
	public static readonly BibleBook SecondThessalonians = new SecondThessaloniansSE();
	public static readonly BibleBook FirstTimothy = new FirstTimothySE();
	public static readonly BibleBook SecondTimothy = new SecondTimothySE();
	public static readonly BibleBook Titus = new TitusSE();
	public static readonly BibleBook Philemon = new PhilemonSE();
	public static readonly BibleBook Hebrews = new HebrewsSE();
	public static readonly BibleBook James = new JamesSE();
	public static readonly BibleBook FirstPeter = new FirstPeterSE();
	public static readonly BibleBook SecondPeter = new SecondPeterSE();
	public static readonly BibleBook FirstJohn = new FirstJohnSE();
	public static readonly BibleBook SecondJohn = new SecondJohnSE();
	public static readonly BibleBook ThirdJohn = new ThirdJohnSE();
	public static readonly BibleBook Jude = new JudeSE();
	public static readonly BibleBook Revelation = new RevelationSE();
	// SE=SmartEnum
	#endregion

	private BibleBook(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Title { get; }
	public abstract string Abrv { get; }
	public abstract BookGroupEnum BookGroupEnum { get; }
	public abstract BookEnum BookEnum { get; }
	public abstract int LastChapter { get; }
	public abstract string TransliterationInHebrew { get; }
	public abstract string NameInHebrew { get; }

	public abstract List<int> LastVerses { get; }

	public abstract BibleBookPrevNext NavigationPrevious(int Chapter);
	public abstract BibleBookPrevNext NavigationNext(int Chapter);

	//Properties
	public bool IsHebrewBible => this.Value <= BookChapterFacts.LastBookInOT ? true : false;

	public string Dump => $" {Value}-{Abrv}-{Name}-{BookGroupEnum}";

	#endregion


	#region Private Instantiation
	private sealed class GenesisSE : BibleBook
	{
		public GenesisSE() : base("Genesis", 1) { }
		public override string Title => "Genesis";
		public override string Abrv => "Gen";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Torah;
		public override BookEnum BookEnum => BookEnum.Genesis;
		public override int LastChapter => 50;
		public override string TransliterationInHebrew => "Beresheeth";
		public override string NameInHebrew => "בְּרֵאשִׁית";

		public override List<int> LastVerses => [31, 25, 24, 26, 32, 22, 24, 22, 29, 32, 32, 20, 18, 24, 21, 16, 27, 33, 38, 18, 34, 24, 20, 67, 34, 35, 46, 22, 35, 43, 55, 32, 20, 31, 29, 43, 36, 30, 23, 23, 57, 38, 34, 34, 28, 34, 31, 22, 33, 26,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Genesis, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(null, 0, "");

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Genesis, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Exodus, 1, Exodus.Abrv + " " + 1);
	}

	private sealed class ExodusSE : BibleBook
	{
		public ExodusSE() : base("Exodus", 2) { }
		public override string Title => "Exodus";
		public override string Abrv => "Exo";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Torah;
		public override BookEnum BookEnum => BookEnum.Exodus;
		public override int LastChapter => 40;
		public override string TransliterationInHebrew => "Shemoth";
		public override string NameInHebrew => "שְׁמֹות";

		public override List<int> LastVerses => [22, 25, 22, 31, 23, 30, 25, 32, 35, 29, 10, 51, 22, 31, 27, 36, 16, 27, 25, 26, 36, 31, 33, 18, 40, 37, 21, 43, 46, 38, 18, 35, 23, 35, 35, 38, 29, 31, 43, 38,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Exodus, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Genesis, Genesis.LastChapter, Genesis.Abrv + " " + Genesis.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Exodus, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Leviticus, 1, Leviticus.Abrv + " " + 1);

	}

	private sealed class LeviticusSE : BibleBook
	{
		public LeviticusSE() : base("Leviticus", 3) { }
		public override string Title => "Leviticus";
		public override string Abrv => "Lev";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Torah;
		public override BookEnum BookEnum => BookEnum.Leviticus;
		public override int LastChapter => 27;
		public override string TransliterationInHebrew => "Vayiqra";
		public override string NameInHebrew => "וַיִּקְרָא";

		public override List<int> LastVerses => [17, 16, 17, 35, 19, 30, 38, 36, 24, 20, 47, 8, 59, 57, 33, 34, 16, 30, 37, 27, 24, 33, 44, 23, 55, 46, 34,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Leviticus, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Exodus, Exodus.LastChapter, Exodus.Abrv + " " + Exodus.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Leviticus, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Numbers, 1, Numbers.Abrv + " " + 1);
	}

	private sealed class NumbersSE : BibleBook
	{
		public NumbersSE() : base("Numbers", 4) { }
		public override string Title => "Numbers";
		public override string Abrv => "Num";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Torah;
		public override BookEnum BookEnum => BookEnum.Numbers;
		public override int LastChapter => 36;
		public override string TransliterationInHebrew => "Bamidbar";
		public override string NameInHebrew => "בְּמִדְבַּר";

		public override List<int> LastVerses => [54, 34, 51, 49, 31, 27, 89, 26, 23, 36, 35, 16, 33, 45, 41, 50, 13, 32, 22, 29, 35, 41, 30, 25, 18, 65, 23, 31, 40, 16, 54, 42, 56, 29, 34, 13,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Numbers, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Leviticus, Leviticus.LastChapter, Leviticus.Abrv + " " + Leviticus.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Numbers, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Deuteronomy, 1, Deuteronomy.Abrv + " " + 1);
	}

	private sealed class DeuteronomySE : BibleBook
	{
		public DeuteronomySE() : base("Deuteronomy", 5) { }
		public override string Title => "Deuteronomy";
		public override string Abrv => "Deu";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Torah;
		public override BookEnum BookEnum => BookEnum.Deuteronomy;
		public override int LastChapter => 34;
		public override string TransliterationInHebrew => "Devarim";
		public override string NameInHebrew => "דְּבָרִים";

		public override List<int> LastVerses => [46, 37, 29, 49, 33, 25, 26, 20, 29, 22, 32, 32, 18, 29, 23, 22, 20, 22, 21, 20, 23, 30, 25, 22, 19, 19, 26, 68, 29, 20, 30, 52, 29, 12,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Deuteronomy, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Numbers, Numbers.LastChapter, Numbers.Abrv + " " + Numbers.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Deuteronomy, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Joshua, 1, Joshua.Abrv + " " + 1);
	}

	private sealed class JoshuaSE : BibleBook
	{
		public JoshuaSE() : base("Joshua", 6) { }
		public override string Title => "Joshua";
		public override string Abrv => "Jos";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.Joshua;
		public override int LastChapter => 24;
		public override string TransliterationInHebrew => "Yahoshua";
		public override string NameInHebrew => "יְהוֹשֻׁעַ";

		public override List<int> LastVerses => [18, 24, 17, 24, 15, 27, 26, 35, 27, 43, 23, 24, 33, 15, 63, 10, 18, 28, 51, 9, 45, 34, 16, 33,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Joshua, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Deuteronomy, Deuteronomy.LastChapter, Deuteronomy.Abrv + " " + Deuteronomy.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Joshua, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Judges, 1, Judges.Abrv + " " + 1);
	}

	private sealed class JudgesSE : BibleBook
	{
		public JudgesSE() : base("Judges", 7) { }
		public override string Title => "Judges";
		public override string Abrv => "Jdg";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.Judges;
		public override int LastChapter => 21;
		public override string TransliterationInHebrew => "Shophtim";
		public override string NameInHebrew => "שׁוֹפְטִים";
		
		public override List<int> LastVerses => [36, 23, 31, 24, 31, 40, 25, 35, 57, 18, 40, 15, 25, 20, 20, 31, 13, 31, 30, 48, 25,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Judges, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Joshua, Joshua.LastChapter, Joshua.Abrv + " " + Joshua.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Judges, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Ruth, 1, Ruth.Abrv + " " + 1);
	}

	private sealed class RuthSE : BibleBook
	{
		public RuthSE() : base("Ruth", 8) { }
		public override string Title => "Ruth";
		public override string Abrv => "Rut";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.Ruth;
		public override int LastChapter => 4;
		public override string TransliterationInHebrew => "Root";
		public override string NameInHebrew => "רוּת";

		public override List<int> LastVerses => [22, 23, 18, 22,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Ruth, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Judges, Judges.LastChapter, Judges.Abrv + " " + Judges.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Ruth, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(FirstSamuel, 1, FirstSamuel.Abrv + " " + 1);

	}

	private sealed class FirstSamuelSE : BibleBook
	{
		public FirstSamuelSE() : base("FirstSamuel", 9) { }
		public override string Title => "1 Samuel";
		public override string Abrv => "1Sa";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.FirstSamuel;
		public override int LastChapter => 31;
		public override string TransliterationInHebrew => "Schmuel Alef";
		public override string NameInHebrew => "שְׁמוּאֵל א";

		public override List<int> LastVerses => [28, 36, 21, 22, 12, 21, 17, 22, 27, 27, 15, 25, 23, 52, 35, 23, 58, 30, 24, 42, 15, 23, 29, 22, 44, 25, 12, 25, 11, 31, 13,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(FirstSamuel, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Ruth, Ruth.LastChapter, Ruth.Abrv + " " + Ruth.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(FirstSamuel, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SecondSamuel, 1, SecondSamuel.Abrv + " " + 1);
	}

	private sealed class SecondSamuelSE : BibleBook
	{
		public SecondSamuelSE() : base("SecondSamuel", 10) { }
		public override string Title => "2 Samuel";
		public override string Abrv => "2Sa";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.SecondSamuel;
		public override int LastChapter => 24;
		public override string TransliterationInHebrew => "Schmuel Bet";
		public override string NameInHebrew => "שְׁמוּאֵל ב";

		public override List<int> LastVerses => [27, 32, 39, 12, 25, 23, 29, 18, 13, 19, 27, 31, 39, 33, 37, 23, 29, 33, 43, 26, 22, 51, 39, 25,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SecondSamuel, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(FirstSamuel, FirstSamuel.LastChapter, FirstSamuel.Abrv + " " + FirstSamuel.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SecondSamuel, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(FirstKings, 1, FirstKings.Abrv + " " + 1);
	}

	private sealed class FirstKingsSE : BibleBook
	{
		public FirstKingsSE() : base("FirstKings", 11) { }
		public override string Title => "1 Kings";
		public override string Abrv => "1Ki";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.FirstKings;
		public override int LastChapter => 22;
		public override string TransliterationInHebrew => "Melechim Alef";
		public override string NameInHebrew => "מְלָכִים א";

		public override List<int> LastVerses => [53, 46, 28, 34, 18, 38, 51, 66, 28, 29, 43, 33, 34, 31, 34, 34, 24, 46, 21, 43, 29, 53,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(FirstKings, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SecondSamuel, SecondSamuel.LastChapter, SecondSamuel.Abrv + " " + SecondSamuel.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(FirstKings, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SecondKings, 1, SecondKings.Abrv + " " + 1);
	}

	private sealed class SecondKingsSE : BibleBook
	{
		public SecondKingsSE() : base("SecondKings", 12) { }
		public override string Title => "2 Kings";
		public override string Abrv => "2Ki";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.SecondKings;
		public override int LastChapter => 25;
		public override string TransliterationInHebrew => "Melechim Bet";
		public override string NameInHebrew => "מְלָכִים ב";

		public override List<int> LastVerses => [18, 25, 27, 44, 27, 33, 20, 29, 37, 36, 21, 21, 25, 29, 38, 20, 41, 37, 37, 21, 26, 20, 37, 20, 30,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SecondKings, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(FirstKings, FirstKings.LastChapter, FirstKings.Abrv + " " + FirstKings.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SecondKings, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(FirstChronicles, 1, FirstChronicles.Abrv + " " + 1);
	}

	private sealed class FirstChroniclesSE : BibleBook
	{
		public FirstChroniclesSE() : base("FirstChronicles", 13) { }
		public override string Title => "1 Chronicles";
		public override string Abrv => "1Ch";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.FirstChronicles;
		public override int LastChapter => 29;
		public override string TransliterationInHebrew => "Divre HaYamim Alef";
		public override string NameInHebrew => "דִּבְרֵי הַיָּמִים א";

		public override List<int> LastVerses => [54, 55, 24, 43, 26, 81, 40, 40, 44, 14, 47, 40, 14, 17, 29, 43, 27, 17, 19, 8, 30, 19, 32, 31, 31, 32, 34, 21, 30,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(FirstChronicles, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SecondKings, SecondKings.LastChapter, SecondKings.Abrv + " " + SecondKings.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(FirstChronicles, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SecondChronicles, 1, SecondChronicles.Abrv + " " + 1);
	}

	private sealed class SecondChroniclesSE : BibleBook
	{
		public SecondChroniclesSE() : base("SecondChronicles", 14) { }
		public override string Title => "2 Chronicles";
		public override string Abrv => "2Ch";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.SecondChronicles;
		public override int LastChapter => 36;
		public override string TransliterationInHebrew => "Divre HaYamim Bet";
		public override string NameInHebrew => "דִּבְרֵי הַיָּמִים ב";

		public override List<int> LastVerses => [17, 18, 17, 22, 14, 42, 22, 18, 31, 19, 23, 16, 22, 15, 19, 14, 19, 34, 11, 37, 20, 12, 21, 27, 28, 23, 9, 27, 36, 27, 21, 33, 25, 33, 27, 23,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SecondChronicles, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(FirstChronicles, FirstChronicles.LastChapter, FirstChronicles.Abrv + " " + FirstChronicles.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SecondChronicles, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Ezra, 1, Ezra.Abrv + " " + 1);
	}

	private sealed class EzraSE : BibleBook
	{
		public EzraSE() : base("Ezra", 15) { }
		public override string Title => "Ezra";
		public override string Abrv => "Ezr";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.Ezra;
		public override int LastChapter => 10;
		public override string TransliterationInHebrew => "Ezrah";
		public override string NameInHebrew => "עֶזְרָא";

		public override List<int> LastVerses => [11, 70, 13, 24, 17, 22, 28, 36, 15, 44,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Ezra, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SecondChronicles, SecondChronicles.LastChapter, SecondChronicles.Abrv + " " + SecondChronicles.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Ezra, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Nehemiah, 1, Nehemiah.Abrv + " " + 1);
	}

	private sealed class NehemiahSE : BibleBook
	{
		public NehemiahSE() : base("Nehemiah", 16) { }
		public override string Title => "Nehemiah";
		public override string Abrv => "Neh";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.Nehemiah;
		public override int LastChapter => 13;
		public override string TransliterationInHebrew => "Nechemyah";
		public override string NameInHebrew => "נְחֶמְיָה";

		public override List<int> LastVerses => [11, 20, 32, 23, 19, 19, 73, 18, 38, 39, 36, 47, 31,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Nehemiah, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Ezra, Ezra.LastChapter, Ezra.Abrv + " " + Ezra.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Nehemiah, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Esther, 1, Esther.Abrv + " " + 1);
	}

	private sealed class EstherSE : BibleBook
	{
		public EstherSE() : base("Esther", 17) { }
		public override string Title => "Esther";
		public override string Abrv => "Est";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.History;
		public override BookEnum BookEnum => BookEnum.Esther;
		public override int LastChapter => 10;
		public override string TransliterationInHebrew => "Hadasah";
		public override string NameInHebrew => "אֶסְתֵּר";

		public override List<int> LastVerses => [22, 23, 15, 17, 14, 14, 10, 17, 32, 3,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Esther, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Nehemiah, Nehemiah.LastChapter, Nehemiah.Abrv + " " + Nehemiah.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Esther, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Job, 1, Job.Abrv + " " + 1);
	}

	private sealed class JobSE : BibleBook
	{
		public JobSE() : base("Job", 18) { }
		public override string Title => "Job";
		public override string Abrv => "Job";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Poetry;
		public override BookEnum BookEnum => BookEnum.Job;
		public override int LastChapter => 42;
		public override string TransliterationInHebrew => "Iyov";
		public override string NameInHebrew => "אִיּוֹב";

		public override List<int> LastVerses => [22, 13, 26, 21, 27, 30, 21, 22, 35, 22, 20, 25, 28, 22, 35, 22, 16, 21, 29, 29, 34, 30, 17, 25, 6, 14, 23, 28, 25, 31, 40, 22, 33, 37, 16, 33, 24, 41, 30, 24, 34, 17,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Job, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Esther, Esther.LastChapter, Esther.Abrv + " " + Esther.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Job, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Psalms, 1, Psalms.Abrv + " " + 1);
	}

	private sealed class PsalmsSE : BibleBook
	{
		public PsalmsSE() : base("Psalms", 19) { }
		public override string Title => "Psalms";
		public override string Abrv => "Psa";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Poetry;
		public override BookEnum BookEnum => BookEnum.Psalms;
		public override int LastChapter => 150;
		public override string TransliterationInHebrew => "Tehillim";
		public override string NameInHebrew => "תְּהִלִּים";

		public override List<int> LastVerses => [6, 12, 8, 8, 12, 10, 17, 9, 20, 18, 7, 8, 6, 7, 5, 11, 15, 50, 14, 9, 13, 31, 6, 10, 22, 12, 14, 9, 11, 12, 24, 11, 22, 22, 28, 12, 40, 22, 13, 17, 13, 11, 5, 26, 17, 11, 9, 14, 20, 23, 19, 9, 6, 7, 23, 13, 11, 11, 17, 12, 8, 12, 11, 10, 13, 20, 7, 35, 36, 5, 24, 20, 28, 23, 10, 12, 20, 72, 13, 19, 16, 8, 18, 12, 13, 17, 7, 18, 52, 17, 16, 15, 5, 23, 11, 13, 12, 9, 9, 5, 8, 28, 22, 35, 45, 48, 43, 13, 31, 7, 10, 10, 9, 8, 18, 19, 2, 29, 176, 7, 8, 9, 4, 8, 5, 6, 5, 6, 8, 8, 3, 18, 3, 3, 21, 26, 9, 8, 24, 13, 10, 7, 12, 15, 21, 10, 20, 14, 9, 6,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Psalms, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Job, Job.LastChapter, Job.Abrv + " " + Job.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Psalms, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Proverbs, 1, Proverbs.Abrv + " " + 1);
	}

	private sealed class ProverbsSE : BibleBook
	{
		public ProverbsSE() : base("Proverbs", 20) { }
		public override string Title => "Proverbs";
		public override string Abrv => "Pro";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Poetry;
		public override BookEnum BookEnum => BookEnum.Proverbs;
		public override int LastChapter => 31;
		public override string TransliterationInHebrew => "Mishle";
		public override string NameInHebrew => "מִשְׁלֵי";

		public override List<int> LastVerses => [33, 22, 35, 27, 23, 35, 27, 36, 18, 32, 31, 28, 25, 35, 33, 33, 28, 24, 29, 30, 31, 29, 35, 34, 28, 28, 27, 28, 27, 33, 31,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Proverbs, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Psalms, Psalms.LastChapter, Psalms.Abrv + " " + Psalms.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Proverbs, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Ecclesiastes, 1, Ecclesiastes.Abrv + " " + 1);
	}

	private sealed class EcclesiastesSE : BibleBook
	{
		public EcclesiastesSE() : base("Ecclesiastes", 21) { }
		public override string Title => "Ecclesiastes";
		public override string Abrv => "Ecc";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Poetry;
		public override BookEnum BookEnum => BookEnum.Ecclesiastes;
		public override int LastChapter => 12;
		public override string TransliterationInHebrew => "Koheleth";
		public override string NameInHebrew => "קֹהֶלֶת";

		public override List<int> LastVerses => [18, 26, 22, 16, 20, 12, 29, 17, 18, 20, 10, 14,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Ecclesiastes, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Proverbs, Proverbs.LastChapter, Proverbs.Abrv + " " + Proverbs.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Ecclesiastes, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SongofSolomon, 1, SongofSolomon.Abrv + " " + 1);
	}

	private sealed class SongofSolomonSE : BibleBook
	{
		public SongofSolomonSE() : base("SongofSolomon", 22) { }
		public override string Title => "Song of Solomon";
		public override string Abrv => "Song";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Poetry;
		public override BookEnum BookEnum => BookEnum.SongofSolomon;
		public override int LastChapter => 8;
		public override string TransliterationInHebrew => "Shir HaShirim";
		public override string NameInHebrew => "שִׁיר הַשִּׁירִים";

		public override List<int> LastVerses => [17, 17, 11, 16, 16, 13, 13, 14,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SongofSolomon, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Ecclesiastes, Ecclesiastes.LastChapter, Ecclesiastes.Abrv + " " + Ecclesiastes.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SongofSolomon, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Isaiah, 1, Isaiah.Abrv + " " + 1);
	}

	private sealed class IsaiahSE : BibleBook
	{
		public IsaiahSE() : base("Isaiah", 23) { }
		public override string Title => "Isaiah";
		public override string Abrv => "Isa";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MajorProphets;
		public override BookEnum BookEnum => BookEnum.Isaiah;
		public override int LastChapter => 66;
		public override string TransliterationInHebrew => "Yeshayahu";
		public override string NameInHebrew => "יְשַׁעְיָהוּ";

		public override List<int> LastVerses => [31, 22, 26, 6, 30, 13, 25, 22, 21, 34, 16, 6, 22, 32, 9, 14, 14, 7, 25, 6, 17, 25, 18, 23, 12, 21, 13, 29, 24, 33, 9, 20, 24, 17, 10, 22, 38, 22, 8, 31, 29, 25, 28, 28, 25, 13, 15, 22, 26, 11, 23, 15, 12, 17, 13, 12, 21, 14, 21, 22, 11, 12, 19, 12, 25, 24,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Isaiah, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SongofSolomon, SongofSolomon.LastChapter, SongofSolomon.Abrv + " " + SongofSolomon.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Isaiah, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Jeremiah, 1, Jeremiah.Abrv + " " + 1);
	}

	private sealed class JeremiahSE : BibleBook
	{
		public JeremiahSE() : base("Jeremiah", 24) { }
		public override string Title => "Jeremiah";
		public override string Abrv => "Jer";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MajorProphets;
		public override BookEnum BookEnum => BookEnum.Jeremiah;
		public override int LastChapter => 52;
		public override string TransliterationInHebrew => "Yirmeyahu";
		public override string NameInHebrew => "יִרְמְיָהוּ";

		public override List<int> LastVerses => [19, 37, 25, 31, 31, 30, 34, 22, 26, 25, 23, 17, 27, 22, 21, 21, 27, 23, 15, 18, 14, 30, 40, 10, 38, 24, 22, 17, 32, 24, 40, 44, 26, 22, 19, 32, 21, 28, 18, 16, 18, 22, 13, 30, 5, 28, 7, 47, 39, 46, 64, 34,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Jeremiah, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Isaiah, Isaiah.LastChapter, Isaiah.Abrv + " " + Isaiah.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Jeremiah, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Lamentations, 1, Lamentations.Abrv + " " + 1);
	}

	private sealed class LamentationsSE : BibleBook
	{
		public LamentationsSE() : base("Lamentations", 25) { }
		public override string Title => "Lamentations";
		public override string Abrv => "Lam";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MajorProphets;
		public override BookEnum BookEnum => BookEnum.Lamentations;
		public override int LastChapter => 5;
		public override string TransliterationInHebrew => "Echah";
		public override string NameInHebrew => "אֵיכָה";

		public override List<int> LastVerses => [22, 22, 66, 22, 22,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Lamentations, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Jeremiah, Jeremiah.LastChapter, Jeremiah.Abrv + " " + Jeremiah.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Lamentations, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Ezekiel, 1, Ezekiel.Abrv + " " + 1);
	}

	private sealed class EzekielSE : BibleBook
	{
		public EzekielSE() : base("Ezekiel", 26) { }
		public override string Title => "Ezekiel";
		public override string Abrv => "Eze";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MajorProphets;
		public override BookEnum BookEnum => BookEnum.Ezekiel;
		public override int LastChapter => 48;
		public override string TransliterationInHebrew => "Yechezkel";
		public override string NameInHebrew => "יְחֶזְקֵאל";

		public override List<int> LastVerses => [28, 10, 27, 17, 17, 14, 27, 18, 11, 22, 25, 28, 23, 23, 8, 63, 24, 32, 14, 49, 32, 31, 49, 27, 17, 21, 36, 26, 21, 26, 18, 32, 33, 31, 15, 38, 28, 23, 29, 49, 26, 20, 27, 31, 25, 24, 23, 35,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Ezekiel, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Lamentations, Lamentations.LastChapter, Lamentations.Abrv + " " + Lamentations.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Ezekiel, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Daniel, 1, Daniel.Abrv + " " + 1);
	}

	private sealed class DanielSE : BibleBook
	{
		public DanielSE() : base("Daniel", 27) { }
		public override string Title => "Daniel";
		public override string Abrv => "Dan";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MajorProphets;
		public override BookEnum BookEnum => BookEnum.Daniel;
		public override int LastChapter => 12;
		public override string TransliterationInHebrew => "Daniyel";
		public override string NameInHebrew => "דָּנִיֵּאל";

		public override List<int> LastVerses => [21, 49, 30, 37, 31, 28, 28, 27, 27, 21, 45, 13,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Daniel, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Ezekiel, Ezekiel.LastChapter, Ezekiel.Abrv + " " + Ezekiel.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Daniel, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Hosea, 1, Hosea.Abrv + " " + 1);
	}

	private sealed class HoseaSE : BibleBook
	{
		public HoseaSE() : base("Hosea", 28) { }
		public override string Title => "Hosea";
		public override string Abrv => "Hos";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Hosea;
		public override int LastChapter => 14;
		public override string TransliterationInHebrew => "Hoshea";
		public override string NameInHebrew => "הוֹשֵׁעַ";

		public override List<int> LastVerses => [11, 23, 5, 19, 15, 11, 16, 14, 17, 15, 12, 14, 16, 9,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Hosea, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Daniel, Daniel.LastChapter, Daniel.Abrv + " " + Daniel.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Hosea, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Joel, 1, Joel.Abrv + " " + 1);
	}

	private sealed class JoelSE : BibleBook
	{
		public JoelSE() : base("Joel", 29) { }
		public override string Title => "Joel";
		public override string Abrv => "Joe";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Joel;
		public override int LastChapter => 3;
		public override string TransliterationInHebrew => "Yoel";
		public override string NameInHebrew => "יוֹאֵל";

		public override List<int> LastVerses => [20, 32, 21,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Joel, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Hosea, Hosea.LastChapter, Hosea.Abrv + " " + Hosea.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Joel, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Amos, 1, Amos.Abrv + " " + 1);
	}

	private sealed class AmosSE : BibleBook
	{
		public AmosSE() : base("Amos", 30) { }
		public override string Title => "Amos";
		public override string Abrv => "Amo";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Amos;
		public override int LastChapter => 9;
		public override string TransliterationInHebrew => "Ahmos";
		public override string NameInHebrew => "עָמוֹס";

		public override List<int> LastVerses => [15, 16, 15, 13, 27, 14, 17, 14, 15,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Amos, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Joel, Joel.LastChapter, Joel.Abrv + " " + Joel.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Amos, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Obadiah, 1, Obadiah.Abrv + " " + 1);
	}

	private sealed class ObadiahSE : BibleBook
	{
		public ObadiahSE() : base("Obadiah", 31) { }
		public override string Title => "Obadiah";
		public override string Abrv => "Oba";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Obadiah;
		public override int LastChapter => 1;
		public override string TransliterationInHebrew => "Ovadyah";
		public override string NameInHebrew => "עֹבַדְיָה";

		public override List<int> LastVerses => [21,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Obadiah, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Amos, Amos.LastChapter, Amos.Abrv + " " + Amos.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Obadiah, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Jonah, 1, Jonah.Abrv + " " + 1);
	}

	private sealed class JonahSE : BibleBook
	{
		public JonahSE() : base("Jonah", 32) { }
		public override string Title => "Jonah";
		public override string Abrv => "Jon";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Jonah;
		public override int LastChapter => 4;
		public override string TransliterationInHebrew => "Yonah";
		public override string NameInHebrew => "יוֹנָה";

		public override List<int> LastVerses => [17, 10, 10, 11,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Jonah, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Obadiah, Obadiah.LastChapter, Obadiah.Abrv + " " + Obadiah.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Jonah, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Micah, 1, Micah.Abrv + " " + 1);
	}

	private sealed class MicahSE : BibleBook
	{
		public MicahSE() : base("Micah", 33) { }
		public override string Title => "Micah";
		public override string Abrv => "Mic";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Micah;
		public override int LastChapter => 7;
		public override string TransliterationInHebrew => "Micha";
		public override string NameInHebrew => "מִיכָה";

		public override List<int> LastVerses => [16, 13, 12, 13, 15, 16, 20,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Micah, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Jonah, Jonah.LastChapter, Jonah.Abrv + " " + Jonah.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Micah, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Nahum, 1, Nahum.Abrv + " " + 1);
	}

	private sealed class NahumSE : BibleBook
	{
		public NahumSE() : base("Nahum", 34) { }
		public override string Title => "Nahum";
		public override string Abrv => "Nah";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Nahum;
		public override int LastChapter => 3;
		public override string TransliterationInHebrew => "Nachum";
		public override string NameInHebrew => "נַחוּם";

		public override List<int> LastVerses => [15, 13, 19,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Nahum, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Micah, Micah.LastChapter, Micah.Abrv + " " + Micah.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Nahum, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Habakkuk, 1, Habakkuk.Abrv + " " + 1);
	}

	private sealed class HabakkukSE : BibleBook
	{
		public HabakkukSE() : base("Habakkuk", 35) { }
		public override string Title => "Habakkuk";
		public override string Abrv => "Hab";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Habakkuk;
		public override int LastChapter => 3;
		public override string TransliterationInHebrew => "Chabakook";
		public override string NameInHebrew => "חֲבַקּוּק";

		public override List<int> LastVerses => [17, 20, 19,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Habakkuk, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Nahum, Nahum.LastChapter, Nahum.Abrv + " " + Nahum.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Habakkuk, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Zephaniah, 1, Zephaniah.Abrv + " " + 1);
	}

	private sealed class ZephaniahSE : BibleBook
	{
		public ZephaniahSE() : base("Zephaniah", 36) { }
		public override string Title => "Zephaniah";
		public override string Abrv => "Zep";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Zephaniah;
		public override int LastChapter => 3;
		public override string TransliterationInHebrew => "Tzephanyah";
		public override string NameInHebrew => "צְפַנְיָה";

		public override List<int> LastVerses => [18, 15, 20,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Zephaniah, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Habakkuk, Habakkuk.LastChapter, Habakkuk.Abrv + " " + Habakkuk.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Zephaniah, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Haggai, 1, Haggai.Abrv + " " + 1);
	}

	private sealed class HaggaiSE : BibleBook
	{
		public HaggaiSE() : base("Haggai", 37) { }
		public override string Title => "Haggai";
		public override string Abrv => "Hag";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Haggai;
		public override int LastChapter => 2;
		public override string TransliterationInHebrew => "Chaggai";
		public override string NameInHebrew => "חַגַּי";

		public override List<int> LastVerses => [15, 23,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Haggai, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Zephaniah, Zephaniah.LastChapter, Zephaniah.Abrv + " " + Zephaniah.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Haggai, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Zechariah, 1, Zechariah.Abrv + " " + 1);
	}

	private sealed class ZechariahSE : BibleBook
	{
		public ZechariahSE() : base("Zechariah", 38) { }
		public override string Title => "Zechariah";
		public override string Abrv => "Zec";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Zechariah;
		public override int LastChapter => 14;
		public override string TransliterationInHebrew => "Zecharyah";
		public override string NameInHebrew => "זְכַרְיָה";

		public override List<int> LastVerses => [21, 13, 10, 14, 11, 15, 14, 23, 17, 12, 17, 14, 9, 21,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Zechariah, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Haggai, Haggai.LastChapter, Haggai.Abrv + " " + Haggai.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Zechariah, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Malachi, 1, Malachi.Abrv + " " + 1);
	}

	private sealed class MalachiSE : BibleBook
	{
		public MalachiSE() : base("Malachi", 39) { }
		public override string Title => "Malachi";
		public override string Abrv => "Mal";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.MinorProphets;
		public override BookEnum BookEnum => BookEnum.Malachi;
		public override int LastChapter => 4;
		public override string TransliterationInHebrew => "Malachi";
		public override string NameInHebrew => "מַלְאָכִי";

		public override List<int> LastVerses => [14, 17, 18, 6,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Malachi, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Zechariah, Zechariah.LastChapter, Zechariah.Abrv + " " + Zechariah.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Malachi, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Matthew, 1, Matthew.Abrv + " " + 1);
	}

	private sealed class MatthewSE : BibleBook
	{
		public MatthewSE() : base("Matthew", 40) { }
		public override string Title => "Matthew";
		public override string Abrv => "Mat";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Gospels;
		public override BookEnum BookEnum => BookEnum.Matthew;
		public override int LastChapter => 28;
		public override string TransliterationInHebrew => "Mattityahu";
		public override string NameInHebrew => "מַתִּתְיָהוּ";

		public override List<int> LastVerses => [25, 23, 17, 25, 48, 34, 29, 34, 38, 42, 30, 50, 58, 36, 39, 28, 27, 35, 30, 34, 46, 46, 39, 51, 46, 75, 66, 20,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Matthew, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Malachi, Malachi.LastChapter, Malachi.Abrv + " " + Malachi.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Matthew, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Mark, 1, Mark.Abrv + " " + 1);
	}

	private sealed class MarkSE : BibleBook
	{
		public MarkSE() : base("Mark", 41) { }
		public override string Title => "Mark";
		public override string Abrv => "Mar";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Gospels;
		public override BookEnum BookEnum => BookEnum.Mark;
		public override int LastChapter => 16;
		public override string TransliterationInHebrew => "Yochanan-Moshe";
		public override string NameInHebrew => "מַרְקוֹס";

		public override List<int> LastVerses => [45, 28, 35, 41, 43, 56, 37, 38, 50, 52, 33, 44, 37, 72, 47, 20,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Mark, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Matthew, Matthew.LastChapter, Matthew.Abrv + " " + Matthew.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Mark, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Luke, 1, Luke.Abrv + " " + 1);
	}

	private sealed class LukeSE : BibleBook
	{
		public LukeSE() : base("Luke", 42) { }
		public override string Title => "Luke";
		public override string Abrv => "Luk";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Gospels;
		public override BookEnum BookEnum => BookEnum.Luke;
		public override int LastChapter => 24;
		public override string TransliterationInHebrew => "Luka";
		public override string NameInHebrew => "לוּקָס";

		public override List<int> LastVerses => [80, 52, 38, 44, 39, 49, 50, 56, 62, 42, 54, 59, 35, 35, 32, 31, 37, 43, 48, 47, 38, 71, 56, 53,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Luke, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Mark, Mark.LastChapter, Mark.Abrv + " " + Mark.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Luke, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(John, 1, John.Abrv + " " + 1);
	}

	private sealed class JohnSE : BibleBook
	{
		public JohnSE() : base("John", 43) { }
		public override string Title => "John";
		public override string Abrv => "Joh";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Gospels;
		public override BookEnum BookEnum => BookEnum.John;
		public override int LastChapter => 21;
		public override string TransliterationInHebrew => "Yochanan";
		public override string NameInHebrew => "יוֹחָנָן";

		public override List<int> LastVerses => [51, 25, 36, 54, 47, 71, 53, 59, 41, 42, 57, 50, 38, 31, 27, 33, 26, 40, 42, 31, 25,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(John, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Luke, Luke.LastChapter, Luke.Abrv + " " + Luke.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(John, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Acts, 1, Acts.Abrv + " " + 1);
	}

	private sealed class ActsSE : BibleBook
	{
		public ActsSE() : base("Acts", 44) { }
		public override string Title => "Acts";
		public override string Abrv => "Act";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Gospels;
		public override BookEnum BookEnum => BookEnum.Acts;
		public override int LastChapter => 28;
		public override string TransliterationInHebrew => "Maaseh Shlichim";  // Emissaries Acts
		public override string NameInHebrew => "מַעֲשֶׂה שליחים";

		public override List<int> LastVerses => [26, 47, 26, 37, 42, 15, 60, 40, 43, 48, 30, 25, 52, 28, 41, 40, 34, 28, 41, 38, 40, 30, 35, 27, 27, 32, 44, 31,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Acts, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(John, John.LastChapter, John.Abrv + " " + John.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Acts, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Romans, 1, Romans.Abrv + " " + 1);
	}

	private sealed class RomansSE : BibleBook
	{
		public RomansSE() : base("Romans", 45) { }
		public override string Title => "Romans";
		public override string Abrv => "Rom";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.Romans;
		public override int LastChapter => 16;
		public override string TransliterationInHebrew => "Romiyah";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [32, 29, 31, 25, 21, 23, 25, 39, 33, 21, 36, 21, 14, 23, 33, 27,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Romans, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Acts, Acts.LastChapter, Acts.Abrv + " " + Acts.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Romans, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(FirstCorinthians, 1, FirstCorinthians.Abrv + " " + 1);
	}

	private sealed class FirstCorinthiansSE : BibleBook
	{
		public FirstCorinthiansSE() : base("FirstCorinthians", 46) { }
		public override string Title => "1 Corinthians";
		public override string Abrv => "1Co";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.FirstCorinthians;
		public override int LastChapter => 16;
		public override string TransliterationInHebrew => "Qorintyah Alef";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [31, 16, 23, 21, 13, 20, 40, 13, 27, 33, 34, 31, 13, 40, 58, 24,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(FirstCorinthians, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Romans, Romans.LastChapter, Romans.Abrv + " " + Romans.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(FirstCorinthians, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SecondCorinthians, 1, SecondCorinthians.Abrv + " " + 1);
	}

	private sealed class SecondCorinthiansSE : BibleBook
	{
		public SecondCorinthiansSE() : base("SecondCorinthians", 47) { }
		public override string Title => "2 Corinthians";
		public override string Abrv => "2Co";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.SecondCorinthians;
		public override int LastChapter => 13;
		public override string TransliterationInHebrew => "Qorintyah Bet";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [24, 17, 18, 18, 21, 18, 16, 24, 15, 18, 33, 21, 14,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SecondCorinthians, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(FirstCorinthians, FirstCorinthians.LastChapter, FirstCorinthians.Abrv + " " + FirstCorinthians.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SecondCorinthians, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Galatians, 1, Galatians.Abrv + " " + 1);
	}

	private sealed class GalatiansSE : BibleBook
	{
		public GalatiansSE() : base("Galatians", 48) { }
		public override string Title => "Galatians";
		public override string Abrv => "Gal";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.Galatians;
		public override int LastChapter => 6;
		public override string TransliterationInHebrew => "Galutyah";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [24, 21, 29, 31, 26, 18,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Galatians, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SecondCorinthians, SecondCorinthians.LastChapter, SecondCorinthians.Abrv + " " + SecondCorinthians.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Galatians, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Ephesians, 1, Ephesians.Abrv + " " + 1);
	}

	private sealed class EphesiansSE : BibleBook
	{
		public EphesiansSE() : base("Ephesians", 49) { }
		public override string Title => "Ephesians";
		public override string Abrv => "Eph";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.Ephesians;
		public override int LastChapter => 6;
		public override string TransliterationInHebrew => "Ephsiyah";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [23, 22, 21, 32, 33, 24,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Ephesians, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Galatians, Galatians.LastChapter, Galatians.Abrv + " " + Galatians.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Ephesians, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Philippians, 1, Philippians.Abrv + " " + 1);
	}

	private sealed class PhilippiansSE : BibleBook
	{
		public PhilippiansSE() : base("Philippians", 50) { }
		public override string Title => "Philippians";
		public override string Abrv => "Php";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.Philippians;
		public override int LastChapter => 4;
		public override string TransliterationInHebrew => "Phylypsiyah";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [30, 30, 21, 23,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Philippians, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Ephesians, Ephesians.LastChapter, Ephesians.Abrv + " " + Ephesians.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Philippians, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Colossians, 1, Colossians.Abrv + " " + 1);
	}

	private sealed class ColossiansSE : BibleBook
	{
		public ColossiansSE() : base("Colossians", 51) { }
		public override string Title => "Colossians";
		public override string Abrv => "Col";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.Colossians;
		public override int LastChapter => 4;
		public override string TransliterationInHebrew => "Qolesayah";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [29, 23, 25, 18,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Colossians, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Philippians, Philippians.LastChapter, Philippians.Abrv + " " + Philippians.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Colossians, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(FirstThessalonians, 1, FirstThessalonians.Abrv + " " + 1);
	}

	private sealed class FirstThessaloniansSE : BibleBook
	{
		public FirstThessaloniansSE() : base("FirstThessalonians", 52) { }
		public override string Title => "1 Thessalonians";
		public override string Abrv => "1Th";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.FirstThessalonians;
		public override int LastChapter => 5;
		public override string TransliterationInHebrew => "Tesloniqyah Alef";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [10, 20, 13, 18, 28,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(FirstThessalonians, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Colossians, Colossians.LastChapter, Colossians.Abrv + " " + Colossians.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(FirstThessalonians, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SecondThessalonians, 1, SecondThessalonians.Abrv + " " + 1);
	}

	private sealed class SecondThessaloniansSE : BibleBook
	{
		public SecondThessaloniansSE() : base("SecondThessalonians", 53) { }
		public override string Title => "2 Thessalonians";
		public override string Abrv => "2Th";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.SecondThessalonians;
		public override int LastChapter => 3;
		public override string TransliterationInHebrew => "Tesloniqyah Bet";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [12, 17, 18,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SecondThessalonians, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(FirstThessalonians, FirstThessalonians.LastChapter, FirstThessalonians.Abrv + " " + FirstThessalonians.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SecondThessalonians, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(FirstTimothy, 1, FirstTimothy.Abrv + " " + 1);
	}

	private sealed class FirstTimothySE : BibleBook
	{
		public FirstTimothySE() : base("FirstTimothy", 54) { }
		public override string Title => "1 Timothy";
		public override string Abrv => "1Ti";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.FirstTimothy;
		public override int LastChapter => 6;
		public override string TransliterationInHebrew => "Timtheous Alef";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [20, 15, 16, 16, 25, 21,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(FirstTimothy, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SecondThessalonians, SecondThessalonians.LastChapter, SecondThessalonians.Abrv + " " + SecondThessalonians.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(FirstTimothy, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SecondTimothy, 1, SecondTimothy.Abrv + " " + 1);
	}

	private sealed class SecondTimothySE : BibleBook
	{
		public SecondTimothySE() : base("SecondTimothy", 55) { }
		public override string Title => "2 Timothy";
		public override string Abrv => "2Ti";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.SecondTimothy;
		public override int LastChapter => 4;
		public override string TransliterationInHebrew => "Timtheous Bet";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [18, 26, 17, 22,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SecondTimothy, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(FirstTimothy, FirstTimothy.LastChapter, FirstTimothy.Abrv + " " + FirstTimothy.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SecondTimothy, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Titus, 1, Titus.Abrv + " " + 1);
	}

	private sealed class TitusSE : BibleBook
	{
		public TitusSE() : base("Titus", 56) { }
		public override string Title => "Titus";
		public override string Abrv => "Tit";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.Titus;
		public override int LastChapter => 3;
		public override string TransliterationInHebrew => "Teitus";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [16, 15, 15,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Titus, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SecondTimothy, SecondTimothy.LastChapter, SecondTimothy.Abrv + " " + SecondTimothy.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Titus, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Philemon, 1, Philemon.Abrv + " " + 1);
	}

	private sealed class PhilemonSE : BibleBook
	{
		public PhilemonSE() : base("Philemon", 57) { }
		public override string Title => "Philemon";
		public override string Abrv => "Phm";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.PaulsEpistles;
		public override BookEnum BookEnum => BookEnum.Philemon;
		public override int LastChapter => 1;
		public override string TransliterationInHebrew => "Phileymon";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [25,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Philemon, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Titus, Titus.LastChapter, Titus.Abrv + " " + Titus.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Philemon, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Hebrews, 1, Hebrews.Abrv + " " + 1);
	}

	private sealed class HebrewsSE : BibleBook
	{
		public HebrewsSE() : base("Hebrews", 58) { }
		public override string Title => "Hebrews";
		public override string Abrv => "Heb";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.GeneralEpistles;
		public override BookEnum BookEnum => BookEnum.Hebrews;
		public override int LastChapter => 13;
		public override string TransliterationInHebrew => "Ivrim";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [14, 18, 19, 16, 14, 20, 28, 13, 28, 39, 40, 29, 25,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Hebrews, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Philemon, Philemon.LastChapter, Philemon.Abrv + " " + Philemon.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Hebrews, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(James, 1, James.Abrv + " " + 1);
	}

	private sealed class JamesSE : BibleBook
	{
		public JamesSE() : base("James", 59) { }
		public override string Title => "James";
		public override string Abrv => "Jam";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.GeneralEpistles;
		public override BookEnum BookEnum => BookEnum.James;
		public override int LastChapter => 5;
		public override string TransliterationInHebrew => "Yaakov";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [27, 26, 18, 17, 20,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(James, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Hebrews, Hebrews.LastChapter, Hebrews.Abrv + " " + Hebrews.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(James, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(FirstPeter, 1, FirstPeter.Abrv + " " + 1);
	}

	private sealed class FirstPeterSE : BibleBook
	{
		public FirstPeterSE() : base("FirstPeter", 60) { }
		public override string Title => "1 Peter";
		public override string Abrv => "1Pe";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.GeneralEpistles;
		public override BookEnum BookEnum => BookEnum.FirstPeter;
		public override int LastChapter => 5;
		public override string TransliterationInHebrew => "Kepha Alef";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [25, 25, 22, 19, 14,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(FirstPeter, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(James, James.LastChapter, James.Abrv + " " + James.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(FirstPeter, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SecondPeter, 1, SecondPeter.Abrv + " " + 1);
	}

	private sealed class SecondPeterSE : BibleBook
	{
		public SecondPeterSE() : base("SecondPeter", 61) { }
		public override string Title => "2 Peter";
		public override string Abrv => "2Pe";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.GeneralEpistles;
		public override BookEnum BookEnum => BookEnum.SecondPeter;
		public override int LastChapter => 3;
		public override string TransliterationInHebrew => "Kepha Bet";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [21, 22, 18,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SecondPeter, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(FirstPeter, FirstPeter.LastChapter, FirstPeter.Abrv + " " + FirstPeter.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SecondPeter, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(FirstJohn, 1, FirstJohn.Abrv + " " + 1);
	}

	private sealed class FirstJohnSE : BibleBook
	{
		public FirstJohnSE() : base("FirstJohn", 62) { }
		public override string Title => "1 John";
		public override string Abrv => "1Jo";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.GeneralEpistles;
		public override BookEnum BookEnum => BookEnum.FirstJohn;
		public override int LastChapter => 5;
		public override string TransliterationInHebrew => "Yochanan Alef";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [10, 29, 24, 21, 21,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(FirstJohn, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SecondPeter, SecondPeter.LastChapter, SecondPeter.Abrv + " " + SecondPeter.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(FirstJohn, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(SecondJohn, 1, SecondJohn.Abrv + " " + 1);
	}

	private sealed class SecondJohnSE : BibleBook
	{
		public SecondJohnSE() : base("SecondJohn", 63) { }
		public override string Title => "2 John";
		public override string Abrv => "2Jo";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.GeneralEpistles;
		public override BookEnum BookEnum => BookEnum.SecondJohn;
		public override int LastChapter => 1;
		public override string TransliterationInHebrew => "Yochanan Bet";
		public override string NameInHebrew => "";
		
		public override List<int> LastVerses => [13,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(SecondJohn, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(FirstJohn, FirstJohn.LastChapter, FirstJohn.Abrv + " " + FirstJohn.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(SecondJohn, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(ThirdJohn, 1, ThirdJohn.Abrv + " " + 1);
	}

	private sealed class ThirdJohnSE : BibleBook
	{
		public ThirdJohnSE() : base("ThirdJohn", 64) { }
		public override string Title => "3 John";
		public override string Abrv => "3Jo";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.GeneralEpistles;
		public override BookEnum BookEnum => BookEnum.ThirdJohn;
		public override int LastChapter => 1;
		public override string TransliterationInHebrew => "Yochanan Gimel";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [14,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(ThirdJohn, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(SecondJohn, SecondJohn.LastChapter, SecondJohn.Abrv + " " + SecondJohn.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(ThirdJohn, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Jude, 1, Jude.Abrv + " " + 1);
	}

	private sealed class JudeSE : BibleBook
	{
		public JudeSE() : base("Jude", 65) { }
		public override string Title => "Jude";
		public override string Abrv => "Jud";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.GeneralEpistles;
		public override BookEnum BookEnum => BookEnum.Jude;
		public override int LastChapter => 1;
		public override string TransliterationInHebrew => "Yahudah";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [25,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Jude, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(ThirdJohn, ThirdJohn.LastChapter, ThirdJohn.Abrv + " " + ThirdJohn.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Jude, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(Revelation, 1, Revelation.Abrv + " " + 1);
	}

	private sealed class RevelationSE : BibleBook
	{
		public RevelationSE() : base("Revelation", 66) { }
		public override string Title => "Revelation";
		public override string Abrv => "Rev";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Apocalypse;
		public override BookEnum BookEnum => BookEnum.Revelation;
		public override int LastChapter => 22;
		public override string TransliterationInHebrew => "Gilyahna";
		public override string NameInHebrew => "";

		public override List<int> LastVerses => [20, 29, 22, 11, 14, 17, 17, 13, 21, 11, 19, 17, 18, 20, 8, 21, 18, 24, 21, 15, 27, 21,];

		public override BibleBookPrevNext NavigationPrevious(int Chapter)
				=> Chapter != 1
				? new BibleBookPrevNext(Revelation, Chapter - 1, (Chapter - 1).ToString())
				: new BibleBookPrevNext(Jude, Jude.LastChapter, Jude.Abrv + " " + Jude.LastChapter);

		public override BibleBookPrevNext NavigationNext(int Chapter)
				=> Chapter != LastChapter
				? new BibleBookPrevNext(Revelation, Chapter + 1, (Chapter + 1).ToString())
				: new BibleBookPrevNext(null, 0, "");
	}

	#endregion

	public static class NavigationIcon
	{
		public const string Previous = "fas fa-arrow-left";
		public const string Next = "fas fa-arrow-right";
	}
}
