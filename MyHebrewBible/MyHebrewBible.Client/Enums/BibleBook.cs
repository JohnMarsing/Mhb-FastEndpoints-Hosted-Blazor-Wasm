// Ignore Spelling: Abrv Songof Colossians Thessalonians Philemon

using Ardalis.SmartEnum;
using MyHebrewBible.Client.Features;

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

	public abstract BibleBookPrevNext NavigationPrevious(int Chapter);
	public abstract BibleBookPrevNext NavigationNext(int Chapter);

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
		public override string Title => "SongofSolomon";
		public override string Abrv => "Song";
		public override BookGroupEnum BookGroupEnum => BookGroupEnum.Poetry;
		public override BookEnum BookEnum => BookEnum.SongofSolomon;
		public override int LastChapter => 8;
		public override string TransliterationInHebrew => "Shir HaShirim";
		public override string NameInHebrew => "שִׁיר הַשִּׁירִים";

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
