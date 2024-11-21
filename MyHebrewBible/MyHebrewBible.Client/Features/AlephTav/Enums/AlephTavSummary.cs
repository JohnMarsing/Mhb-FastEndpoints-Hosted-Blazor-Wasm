using Ardalis.SmartEnum;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.AlephTav.Enums;


public abstract class AlephTavSummary : SmartEnum<AlephTavSummary>
{

	#region Id's
	private static class Id
	{
		internal const int Genesis = 1;
		internal const int Exodus = 2;
		internal const int Leviticus = 3;
		internal const int Numbers = 4;
		internal const int Deuteronomy = 5;
		internal const int Joshua = 6;
		internal const int Judges = 7;
		internal const int Ruth = 8;
		internal const int FirstSamuel = 9;
		internal const int SecondSamuel = 10;
		internal const int FirstKings = 11;
		internal const int SecondKings = 12;
		internal const int FirstChronicles = 13;
		internal const int SecondChronicles = 14;
		internal const int Nehemiah = 16;
		internal const int Esther = 17;
		internal const int Job = 18;
		internal const int Psalms = 19;
		internal const int Proverbs = 20;
		internal const int Ecclesiastes = 21;
		internal const int SongofSolomon = 22;
		internal const int Isaiah = 23;
		internal const int Jeremiah = 24;
		internal const int Lamentations = 25;
		internal const int Ezekiel = 26;
		internal const int Daniel = 27;
		internal const int Amos = 30;
		internal const int Obadiah = 31;
		internal const int Micah = 33;
		internal const int Zephaniah = 36;
		internal const int Haggai = 37;
		internal const int Zechariah = 38;
		internal const int Malachi = 39;
	}
	#endregion

	#region  Declared Public Instances

	public static readonly AlephTavSummary Genesis = new GenesisSE();
	public static readonly AlephTavSummary Exodus = new ExodusSE();
	public static readonly AlephTavSummary Leviticus = new LeviticusSE();
	public static readonly AlephTavSummary Numbers = new NumbersSE();
	public static readonly AlephTavSummary Deuteronomy = new DeuteronomySE();
	public static readonly AlephTavSummary Joshua = new JoshuaSE();
	public static readonly AlephTavSummary Judges = new JudgesSE();
	public static readonly AlephTavSummary Ruth = new RuthSE();
	public static readonly AlephTavSummary FirstSamuel = new FirstSamuelSE();
	public static readonly AlephTavSummary SecondSamuel = new SecondSamuelSE();
	public static readonly AlephTavSummary FirstKings = new FirstKingsSE();
	public static readonly AlephTavSummary SecondKings = new SecondKingsSE();
	public static readonly AlephTavSummary FirstChronicles = new FirstChroniclesSE();
	public static readonly AlephTavSummary SecondChronicles = new SecondChroniclesSE();
	public static readonly AlephTavSummary Nehemiah = new NehemiahSE();
	public static readonly AlephTavSummary Esther = new EstherSE();
	public static readonly AlephTavSummary Job = new JobSE();
	public static readonly AlephTavSummary Psalms = new PsalmsSE();
	public static readonly AlephTavSummary Proverbs = new ProverbsSE();
	public static readonly AlephTavSummary Ecclesiastes = new EcclesiastesSE();
	public static readonly AlephTavSummary SongofSolomon = new SongofSolomonSE();
	public static readonly AlephTavSummary Isaiah = new IsaiahSE();
	public static readonly AlephTavSummary Jeremiah = new JeremiahSE();
	public static readonly AlephTavSummary Lamentations = new LamentationsSE();
	public static readonly AlephTavSummary Ezekiel = new EzekielSE();
	public static readonly AlephTavSummary Daniel = new DanielSE();
	public static readonly AlephTavSummary Amos = new AmosSE();
	public static readonly AlephTavSummary Obadiah = new ObadiahSE();
	public static readonly AlephTavSummary Micah = new MicahSE();
	public static readonly AlephTavSummary Zephaniah = new ZephaniahSE();
	public static readonly AlephTavSummary Haggai = new HaggaiSE();
	public static readonly AlephTavSummary Zechariah = new ZechariahSE();
	public static readonly AlephTavSummary Malachi = new MalachiSE();

	#endregion

	private AlephTavSummary(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract BibleBook BibleBook { get; }
	public abstract List<int> Chapters { get; }

	//ToDo: Consider deleting these
	public abstract int VerseCnt { get; }
	public abstract int SatCount { get; }
	#endregion

	#region Private Instantiation

	private sealed class GenesisSE : AlephTavSummary
	{
		public GenesisSE() : base($"{nameof(Id.Genesis)}", Id.Genesis) { }
		public override BibleBook BibleBook => BibleBook.Genesis;
		public override List<int> Chapters => [1, 2, 9, 12, 13, 14, 17, 18, 20, 21, 22, 24, 26, 27, 28, 29, 30, 31, 32, 34, 35, 39, 41, 42, 44, 45, 49, 50];
		public override int VerseCnt => 44;
		public override int SatCount => 47;
	}

	private sealed class ExodusSE : AlephTavSummary
	{
		public ExodusSE() : base($"{nameof(Id.Exodus)}", Id.Exodus) { }
		public override BibleBook BibleBook => BibleBook.Exodus;
		public override List<int> Chapters => [1, 4, 6, 7, 9, 10, 13, 14, 16, 18, 19, 20, 23, 24, 25, 26, 27, 29, 31, 33, 34, 35, 36, 38, 39, 40];
		public override int VerseCnt => 61;
		public override int SatCount => 63;
	}

	private sealed class LeviticusSE : AlephTavSummary
	{
		public LeviticusSE() : base($"{nameof(Id.Leviticus)}", Id.Leviticus) { }
		public override BibleBook BibleBook => BibleBook.Leviticus;
		public override List<int> Chapters => [1, 2, 4, 7, 8, 9, 10, 11, 13, 14, 19, 21, 22, 25, 26, 27];
		public override int VerseCnt => 30;
		public override int SatCount => 31;
	}

	private sealed class NumbersSE : AlephTavSummary
	{
		public NumbersSE() : base($"{nameof(Id.Numbers)}", Id.Numbers) { }
		public override BibleBook BibleBook => BibleBook.Numbers;
		public override List<int> Chapters => [1, 3, 4, 5, 7, 11, 15, 16, 18, 19, 20, 21, 22, 23, 25, 26, 31, 32, 33, 35];
		public override int VerseCnt => 42;
		public override int SatCount => 43;
	}

	private sealed class DeuteronomySE : AlephTavSummary
	{
		public DeuteronomySE() : base($"{nameof(Id.Deuteronomy)}", Id.Deuteronomy) { }
		public override BibleBook BibleBook => BibleBook.Deuteronomy;
		public override List<int> Chapters => [1, 3, 4, 5, 6, 7, 9, 10, 11, 12, 14, 17, 18, 21, 24, 25, 28, 29, 30, 31];
		public override int VerseCnt => 38;
		public override int SatCount => 39;
	}

	private sealed class JoshuaSE : AlephTavSummary
	{
		public JoshuaSE() : base($"{nameof(Id.Joshua)}", Id.Joshua) { }
		public override BibleBook BibleBook => BibleBook.Joshua;
		public override List<int> Chapters => [2, 3, 5, 7, 8, 9, 10, 15, 21, 22, 23, 24];
		public override int VerseCnt => 21;
		public override int SatCount => 21;
	}

	private sealed class JudgesSE : AlephTavSummary
	{
		public JudgesSE() : base($"{nameof(Id.Judges)}", Id.Judges) { }
		public override BibleBook BibleBook => BibleBook.Judges;
		public override List<int> Chapters => [1, 2, 3, 4, 7, 8, 9, 11, 14, 16, 18];
		public override int VerseCnt => 19;
		public override int SatCount => 20;
	}

	private sealed class RuthSE : AlephTavSummary
	{
		public RuthSE() : base($"{nameof(Id.Ruth)}", Id.Ruth) { }
		public override BibleBook BibleBook => BibleBook.Ruth;
		public override List<int> Chapters => [2, 3];
		public override int VerseCnt => 7;
		public override int SatCount => 9;
	}

	private sealed class FirstSamuelSE : AlephTavSummary
	{
		public FirstSamuelSE() : base($"{nameof(Id.FirstSamuel)}", Id.FirstSamuel) { }
		public override BibleBook BibleBook => BibleBook.FirstSamuel;
		public override List<int> Chapters => [2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 15, 16, 19, 22, 23, 24, 25, 26, 28, 30, 31];
		public override int VerseCnt => 39;
		public override int SatCount => 41;
	}

	private sealed class SecondSamuelSE : AlephTavSummary
	{
		public SecondSamuelSE() : base($"{nameof(Id.SecondSamuel)}", Id.SecondSamuel) { }
		public override BibleBook BibleBook => BibleBook.SecondSamuel;
		public override List<int> Chapters => [3, 4, 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 19, 20, 21, 23, 24];
		public override int VerseCnt => 29;
		public override int SatCount => 30;
	}

	private sealed class FirstKingsSE : AlephTavSummary
	{
		public FirstKingsSE() : base($"{nameof(Id.FirstKings)}", Id.FirstKings) { }
		public override BibleBook BibleBook => BibleBook.FirstKings;
		public override List<int> Chapters => [2, 4, 5, 7, 8, 9, 10, 11, 14, 16, 18, 19, 20];
		public override int VerseCnt => 35;
		public override int SatCount => 37;
	}

	private sealed class SecondKingsSE : AlephTavSummary
	{
		public SecondKingsSE() : base($"{nameof(Id.SecondKings)}", Id.SecondKings) { }
		public override BibleBook BibleBook => BibleBook.SecondKings;
		public override List<int> Chapters => [5, 7, 8, 9, 10, 11, 12, 15, 18, 19, 20, 21, 22, 23, 25];
		public override int VerseCnt => 30;
		public override int SatCount => 30;
	}

	private sealed class FirstChroniclesSE : AlephTavSummary
	{
		public FirstChroniclesSE() : base($"{nameof(Id.FirstChronicles)}", Id.FirstChronicles) { }
		public override BibleBook BibleBook => BibleBook.FirstChronicles;
		public override List<int> Chapters => [4, 6, 10, 11, 13, 15, 17, 18, 22];
		public override int VerseCnt => 12;
		public override int SatCount => 12;
	}

	private sealed class SecondChroniclesSE : AlephTavSummary
	{
		public SecondChroniclesSE() : base($"{nameof(Id.SecondChronicles)}", Id.SecondChronicles) { }
		public override BibleBook BibleBook => BibleBook.SecondChronicles;
		public override List<int> Chapters => [4, 6, 7, 9, 10, 14, 21, 25, 29, 33, 34, 36];
		public override int VerseCnt => 24;
		public override int SatCount => 24;
	}

	private sealed class NehemiahSE : AlephTavSummary
	{
		public NehemiahSE() : base($"{nameof(Id.Nehemiah)}", Id.Nehemiah) { }
		public override BibleBook BibleBook => BibleBook.Nehemiah;
		public override List<int> Chapters => [2, 3, 9, 13];
		public override int VerseCnt => 7;
		public override int SatCount => 7;
	}

	private sealed class EstherSE : AlephTavSummary
	{
		public EstherSE() : base($"{nameof(Id.Esther)}", Id.Esther) { }
		public override BibleBook BibleBook => BibleBook.Esther;
		public override List<int> Chapters => [2, 3, 4, 6, 8, 9];
		public override int VerseCnt => 13;
		public override int SatCount => 13;
	}

	private sealed class JobSE : AlephTavSummary
	{
		public JobSE() : base($"{nameof(Id.Job)}", Id.Job) { }
		public override BibleBook BibleBook => BibleBook.Job;
		public override List<int> Chapters => [1, 2];
		public override int VerseCnt => 2;
		public override int SatCount => 2;
	}

	private sealed class PsalmsSE : AlephTavSummary
	{
		public PsalmsSE() : base($"{nameof(Id.Psalms)}", Id.Psalms) { }
		public override BibleBook BibleBook => BibleBook.Psalms;
		public override List<int> Chapters => [47, 60, 83, 98, 132, 137];
		public override int VerseCnt => 6;
		public override int SatCount => 6;
	}

	private sealed class ProverbsSE : AlephTavSummary
	{
		public ProverbsSE() : base($"{nameof(Id.Proverbs)}", Id.Proverbs) { }
		public override BibleBook BibleBook => BibleBook.Proverbs;
		public override List<int> Chapters => [3, 7];
		public override int VerseCnt => 2;
		public override int SatCount => 2;
	}

	private sealed class EcclesiastesSE : AlephTavSummary
	{
		public EcclesiastesSE() : base($"{nameof(Id.Ecclesiastes)}", Id.Ecclesiastes) { }
		public override BibleBook BibleBook => BibleBook.Ecclesiastes;
		public override List<int> Chapters => [2, 4, 5, 7];
		public override int VerseCnt => 4;
		public override int SatCount => 4;
	}

	private sealed class SongofSolomonSE : AlephTavSummary
	{
		public SongofSolomonSE() : base($"{nameof(Id.SongofSolomon)}", Id.SongofSolomon) { }
		public override BibleBook BibleBook => BibleBook.SongofSolomon;
		public override List<int> Chapters => [3, 6];
		public override int VerseCnt => 5;
		public override int SatCount => 5;
	}

	private sealed class IsaiahSE : AlephTavSummary
	{
		public IsaiahSE() : base($"{nameof(Id.Isaiah)}", Id.Isaiah) { }
		public override BibleBook BibleBook => BibleBook.Isaiah;
		public override List<int> Chapters => [2, 3, 4, 5, 7, 8, 11, 21, 22, 36, 37, 38, 39, 41, 52, 53, 63];
		public override int VerseCnt => 22;
		public override int SatCount => 22;
	}

	private sealed class JeremiahSE : AlephTavSummary
	{
		public JeremiahSE() : base($"{nameof(Id.Jeremiah)}", Id.Jeremiah) { }
		public override BibleBook BibleBook => BibleBook.Jeremiah;
		public override List<int> Chapters => [1, 2, 7, 8, 9, 15, 16, 19, 20, 23, 25, 26, 30, 31, 32, 34, 35, 36, 38, 41, 43, 44, 51, 52];
		public override int VerseCnt => 58;
		public override int SatCount => 62;
	}

	private sealed class LamentationsSE : AlephTavSummary
	{
		public LamentationsSE() : base($"{nameof(Id.Lamentations)}", Id.Lamentations) { }
		public override BibleBook BibleBook => BibleBook.Lamentations;
		public override List<int> Chapters => [2];
		public override int VerseCnt => 1;
		public override int SatCount => 1;
	}

	private sealed class EzekielSE : AlephTavSummary
	{
		public EzekielSE() : base($"{nameof(Id.Ezekiel)}", Id.Ezekiel) { }
		public override BibleBook BibleBook => BibleBook.Ezekiel;
		public override List<int> Chapters => [1, 2, 3, 5, 7, 9, 11, 12, 14, 15, 16, 17, 18, 21, 22, 23, 27, 33, 34, 36, 42, 43, 44, 46];
		public override int VerseCnt => 39;
		public override int SatCount => 41;
	}

	private sealed class DanielSE : AlephTavSummary
	{
		public DanielSE() : base($"{nameof(Id.Daniel)}", Id.Daniel) { }
		public override BibleBook BibleBook => BibleBook.Daniel;
		public override List<int> Chapters => [1, 8, 9, 10, 11];
		public override int VerseCnt => 6;
		public override int SatCount => 6;
	}

	private sealed class AmosSE : AlephTavSummary
	{
		public AmosSE() : base($"{nameof(Id.Amos)}", Id.Amos) { }
		public override BibleBook BibleBook => BibleBook.Amos;
		public override List<int> Chapters => [3, 5, 8];
		public override int VerseCnt => 3;
		public override int SatCount => 3;
	}

	private sealed class ObadiahSE : AlephTavSummary
	{
		public ObadiahSE() : base($"{nameof(Id.Obadiah)}", Id.Obadiah) { }
		public override BibleBook BibleBook => BibleBook.Obadiah;
		public override List<int> Chapters => [1];
		public override int VerseCnt => 2;
		public override int SatCount => 2;
	}

	private sealed class MicahSE : AlephTavSummary
	{
		public MicahSE() : base($"{nameof(Id.Micah)}", Id.Micah) { }
		public override BibleBook BibleBook => BibleBook.Micah;
		public override List<int> Chapters => [5, 6];
		public override int VerseCnt => 2;
		public override int SatCount => 2;
	}

	private sealed class ZephaniahSE : AlephTavSummary
	{
		public ZephaniahSE() : base($"{nameof(Id.Zephaniah)}", Id.Zephaniah) { }
		public override BibleBook BibleBook => BibleBook.Zephaniah;
		public override List<int> Chapters => [1, 2];
		public override int VerseCnt => 2;
		public override int SatCount => 2;
	}

	private sealed class HaggaiSE : AlephTavSummary
	{
		public HaggaiSE() : base($"{nameof(Id.Haggai)}", Id.Haggai) { }
		public override BibleBook BibleBook => BibleBook.Haggai;
		public override List<int> Chapters => [2];
		public override int VerseCnt => 1;
		public override int SatCount => 1;
	}

	private sealed class ZechariahSE : AlephTavSummary
	{
		public ZechariahSE() : base($"{nameof(Id.Zechariah)}", Id.Zechariah) { }
		public override BibleBook BibleBook => BibleBook.Zechariah;
		public override List<int> Chapters => [8, 11, 12];
		public override int VerseCnt => 3;
		public override int SatCount => 3;
	}

	private sealed class MalachiSE : AlephTavSummary
	{
		public MalachiSE() : base($"{nameof(Id.Malachi)}", Id.Malachi) { }
		public override BibleBook BibleBook => BibleBook.Malachi;
		public override List<int> Chapters => [2, 3, 4];
		public override int VerseCnt => 3;
		public override int SatCount => 3;
	}

	#endregion
}

// Ignore Spelling: Cnt SongOf

/*
private sealed class TorahSE : AlephTavSummary
{
	public TorahSE() : base($"{nameof(Id.Torah)}", Id.Torah) { }
	public override string Title => "Torah Verses";
}

	private sealed class GenesisSE : AlephTavSummary
{
	public GenesisSE() : base($"{nameof(Id.Genesis)}", Id.Genesis) { }
	public override BibleBook BibleBook => "Genesis";
	public override int VerseCnt => "44";
	public override int SatCount => SatCount;

	p 

 */