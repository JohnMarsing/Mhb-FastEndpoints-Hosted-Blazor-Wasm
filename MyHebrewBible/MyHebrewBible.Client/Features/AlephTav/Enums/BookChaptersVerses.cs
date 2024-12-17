using Ardalis.SmartEnum;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.AlephTav.Enums;


public abstract class BookChaptersVerses : SmartEnum<BookChaptersVerses>
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

	public static readonly BookChaptersVerses Genesis = new GenesisSE();
	public static readonly BookChaptersVerses Exodus = new ExodusSE();
	public static readonly BookChaptersVerses Leviticus = new LeviticusSE();
	public static readonly BookChaptersVerses Numbers = new NumbersSE();
	public static readonly BookChaptersVerses Deuteronomy = new DeuteronomySE();
	public static readonly BookChaptersVerses Joshua = new JoshuaSE();
	public static readonly BookChaptersVerses Judges = new JudgesSE();
	public static readonly BookChaptersVerses Ruth = new RuthSE();
	public static readonly BookChaptersVerses FirstSamuel = new FirstSamuelSE();
	public static readonly BookChaptersVerses SecondSamuel = new SecondSamuelSE();
	public static readonly BookChaptersVerses FirstKings = new FirstKingsSE();
	public static readonly BookChaptersVerses SecondKings = new SecondKingsSE();
	public static readonly BookChaptersVerses FirstChronicles = new FirstChroniclesSE();
	public static readonly BookChaptersVerses SecondChronicles = new SecondChroniclesSE();
	public static readonly BookChaptersVerses Nehemiah = new NehemiahSE();
	public static readonly BookChaptersVerses Esther = new EstherSE();
	public static readonly BookChaptersVerses Job = new JobSE();
	public static readonly BookChaptersVerses Psalms = new PsalmsSE();
	public static readonly BookChaptersVerses Proverbs = new ProverbsSE();
	public static readonly BookChaptersVerses Ecclesiastes = new EcclesiastesSE();
	public static readonly BookChaptersVerses SongofSolomon = new SongofSolomonSE();
	public static readonly BookChaptersVerses Isaiah = new IsaiahSE();
	public static readonly BookChaptersVerses Jeremiah = new JeremiahSE();
	public static readonly BookChaptersVerses Lamentations = new LamentationsSE();
	public static readonly BookChaptersVerses Ezekiel = new EzekielSE();
	public static readonly BookChaptersVerses Daniel = new DanielSE();
	public static readonly BookChaptersVerses Amos = new AmosSE();
	public static readonly BookChaptersVerses Obadiah = new ObadiahSE();
	public static readonly BookChaptersVerses Micah = new MicahSE();
	public static readonly BookChaptersVerses Zephaniah = new ZephaniahSE();
	public static readonly BookChaptersVerses Haggai = new HaggaiSE();
	public static readonly BookChaptersVerses Zechariah = new ZechariahSE();
	public static readonly BookChaptersVerses Malachi = new MalachiSE();

	#endregion

	private BookChaptersVerses(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract BibleBook BibleBook { get; }
	public abstract List<int> Chapters { get; }
	public abstract List<ChapterVerse>? Verses { get; }
	#endregion

	#region Private Instantiation


	private sealed class GenesisSE : BookChaptersVerses
	{
		public GenesisSE() : base($"{nameof(Id.Genesis)}", Id.Genesis) { }
		public override BibleBook BibleBook => BibleBook.Genesis;
		public override List<int> Chapters => [1, 2, 9, 12, 13, 14, 17, 18, 20, 21, 22, 24, 26, 27, 28, 29, 30, 31, 32, 34, 35, 39, 41, 42, 44, 45, 49, 50];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 1)
, new ChapterVerse(2, 11)
, new ChapterVerse(2, 13)
, new ChapterVerse(9, 22)
, new ChapterVerse(9, 23)
, new ChapterVerse(9, 24)
, new ChapterVerse(12, 13)
, new ChapterVerse(13, 11)
, new ChapterVerse(14, 9)
, new ChapterVerse(14, 16)
, new ChapterVerse(17, 8)
, new ChapterVerse(17, 11)
, new ChapterVerse(17, 25)
, new ChapterVerse(18, 19)
, new ChapterVerse(20, 14)
, new ChapterVerse(21, 5)
, new ChapterVerse(22, 17)
, new ChapterVerse(24, 23)
, new ChapterVerse(24, 47)
, new ChapterVerse(24, 60)
, new ChapterVerse(24, 66)
, new ChapterVerse(26, 4)
, new ChapterVerse(26, 8)
, new ChapterVerse(27, 45)
, new ChapterVerse(28, 15)
, new ChapterVerse(29, 13)
, new ChapterVerse(30, 29)
, new ChapterVerse(31, 1)
, new ChapterVerse(31, 12)
, new ChapterVerse(32, 22)
, new ChapterVerse(34, 13)
, new ChapterVerse(35, 4)
, new ChapterVerse(39, 22)
, new ChapterVerse(41, 4)
, new ChapterVerse(41, 7)
, new ChapterVerse(41, 20)
, new ChapterVerse(41, 24)
, new ChapterVerse(41, 25)
, new ChapterVerse(42, 9)
, new ChapterVerse(42, 29)
, new ChapterVerse(44, 24)
, new ChapterVerse(45, 27)
, new ChapterVerse(49, 1)
, new ChapterVerse(50, 15)
 ];
	}

	private sealed class ExodusSE : BookChaptersVerses
	{
		public ExodusSE() : base($"{nameof(Id.Exodus)}", Id.Exodus) { }
		public override BibleBook BibleBook => BibleBook.Exodus;
		public override List<int> Chapters => [1, 4, 6, 7, 9, 10, 13, 14, 16, 18, 19, 20, 23, 24, 25, 26, 27, 29, 31, 33, 34, 35, 36, 38, 39, 40];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 1)
, new ChapterVerse(1, 14)
, new ChapterVerse(4, 15)
, new ChapterVerse(4, 28)
, new ChapterVerse(4, 30)
, new ChapterVerse(6, 4)
, new ChapterVerse(6, 29)
, new ChapterVerse(7, 2)
, new ChapterVerse(9, 25)
, new ChapterVerse(10, 2)
, new ChapterVerse(10, 12)
, new ChapterVerse(13, 7)
, new ChapterVerse(14, 24)
, new ChapterVerse(14, 25)
, new ChapterVerse(16, 5)
, new ChapterVerse(16, 9)
, new ChapterVerse(16, 23)
, new ChapterVerse(18, 1)
, new ChapterVerse(18, 8)
, new ChapterVerse(18, 14)
, new ChapterVerse(19, 7)
, new ChapterVerse(20, 1)
, new ChapterVerse(20, 7)
, new ChapterVerse(23, 25)
, new ChapterVerse(23, 31)
, new ChapterVerse(24, 3)
, new ChapterVerse(24, 4)
, new ChapterVerse(24, 10)
, new ChapterVerse(25, 9)
, new ChapterVerse(25, 16)
, new ChapterVerse(25, 22)
, new ChapterVerse(25, 39)
, new ChapterVerse(26, 33)
, new ChapterVerse(27, 9)
, new ChapterVerse(29, 19)
, new ChapterVerse(29, 27)
, new ChapterVerse(31, 6)
, new ChapterVerse(31, 7)
, new ChapterVerse(33, 12)
, new ChapterVerse(34, 11)
, new ChapterVerse(34, 28)
, new ChapterVerse(34, 32)
, new ChapterVerse(34, 34)
, new ChapterVerse(35, 5)
, new ChapterVerse(35, 10)
, new ChapterVerse(35, 16)
, new ChapterVerse(35, 17)
, new ChapterVerse(35, 24)
, new ChapterVerse(35, 27)
, new ChapterVerse(36, 3)
, new ChapterVerse(36, 4)
, new ChapterVerse(38, 8)
, new ChapterVerse(38, 22)
, new ChapterVerse(38, 27)
, new ChapterVerse(39, 39)
, new ChapterVerse(39, 40)
, new ChapterVerse(39, 42)
, new ChapterVerse(40, 3)
, new ChapterVerse(40, 6)
, new ChapterVerse(40, 13)
, new ChapterVerse(40, 21)
 ];
	}

	private sealed class LeviticusSE : BookChaptersVerses
	{
		public LeviticusSE() : base($"{nameof(Id.Leviticus)}", Id.Leviticus) { }
		public override BibleBook BibleBook => BibleBook.Leviticus;
		public override List<int> Chapters => [1, 2, 4, 7, 8, 9, 10, 11, 13, 14, 19, 21, 22, 25, 26, 27];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 8)
, new ChapterVerse(2, 14)
, new ChapterVerse(4, 17)
, new ChapterVerse(4, 21)
, new ChapterVerse(7, 3)
, new ChapterVerse(7, 30)
, new ChapterVerse(8, 9)
, new ChapterVerse(8, 14)
, new ChapterVerse(8, 18)
, new ChapterVerse(8, 36)
, new ChapterVerse(9, 5)
, new ChapterVerse(9, 15)
, new ChapterVerse(10, 11)
, new ChapterVerse(11, 15)
, new ChapterVerse(13, 12)
, new ChapterVerse(13, 54)
, new ChapterVerse(13, 57)
, new ChapterVerse(14, 11)
, new ChapterVerse(14, 31)
, new ChapterVerse(19, 27)
, new ChapterVerse(21, 12)
, new ChapterVerse(21, 21)
, new ChapterVerse(22, 15)
, new ChapterVerse(25, 5)
, new ChapterVerse(25, 10)
, new ChapterVerse(25, 22)
, new ChapterVerse(25, 25)
, new ChapterVerse(26, 14)
, new ChapterVerse(26, 35)
, new ChapterVerse(27, 23)
 ];
	}

	private sealed class NumbersSE : BookChaptersVerses
	{
		public NumbersSE() : base($"{nameof(Id.Numbers)}", Id.Numbers) { }
		public override BibleBook BibleBook => BibleBook.Numbers;
		public override List<int> Chapters => [1, 3, 4, 5, 7, 11, 15, 16, 18, 19, 20, 21, 22, 23, 25, 26, 31, 32, 33, 35];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 17)
, new ChapterVerse(3, 40)
, new ChapterVerse(3, 49)
, new ChapterVerse(4, 5)
, new ChapterVerse(4, 27)
, new ChapterVerse(5, 18)
, new ChapterVerse(5, 25)
, new ChapterVerse(5, 30)
, new ChapterVerse(7, 7)
, new ChapterVerse(7, 10)
, new ChapterVerse(11, 5)
, new ChapterVerse(11, 12)
, new ChapterVerse(11, 24)
, new ChapterVerse(15, 22)
, new ChapterVerse(15, 23)
, new ChapterVerse(16, 28)
, new ChapterVerse(16, 31)
, new ChapterVerse(16, 35)
, new ChapterVerse(16, 38)
, new ChapterVerse(16, 39)
, new ChapterVerse(18, 5)
, new ChapterVerse(18, 15)
, new ChapterVerse(18, 29)
, new ChapterVerse(19, 9)
, new ChapterVerse(20, 14)
, new ChapterVerse(21, 6)
, new ChapterVerse(21, 25)
, new ChapterVerse(22, 2)
, new ChapterVerse(22, 4)
, new ChapterVerse(22, 6)
, new ChapterVerse(22, 17)
, new ChapterVerse(23, 12)
, new ChapterVerse(25, 8)
, new ChapterVerse(26, 10)
, new ChapterVerse(31, 26)
, new ChapterVerse(32, 11)
, new ChapterVerse(32, 28)
, new ChapterVerse(32, 31)
, new ChapterVerse(33, 4)
, new ChapterVerse(33, 52)
, new ChapterVerse(35, 6)
, new ChapterVerse(35, 14)
 ];
	}

	private sealed class DeuteronomySE : BookChaptersVerses
	{
		public DeuteronomySE() : base($"{nameof(Id.Deuteronomy)}", Id.Deuteronomy) { }
		public override BibleBook BibleBook => BibleBook.Deuteronomy;
		public override List<int> Chapters => [1, 3, 4, 5, 6, 7, 9, 10, 11, 12, 14, 17, 18, 21, 24, 25, 28, 29, 30, 31];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 4)
, new ChapterVerse(1, 18)
, new ChapterVerse(1, 19)
, new ChapterVerse(1, 35)
, new ChapterVerse(3, 21)
, new ChapterVerse(4, 3)
, new ChapterVerse(4, 6)
, new ChapterVerse(5, 11)
, new ChapterVerse(5, 27)
, new ChapterVerse(5, 31)
, new ChapterVerse(6, 5)
, new ChapterVerse(7, 12)
, new ChapterVerse(7, 18)
, new ChapterVerse(9, 7)
, new ChapterVerse(9, 25)
, new ChapterVerse(10, 4)
, new ChapterVerse(10, 16)
, new ChapterVerse(11, 1)
, new ChapterVerse(11, 32)
, new ChapterVerse(12, 11)
, new ChapterVerse(12, 28)
, new ChapterVerse(12, 32)
, new ChapterVerse(14, 22)
, new ChapterVerse(17, 9)
, new ChapterVerse(18, 18)
, new ChapterVerse(18, 20)
, new ChapterVerse(21, 16)
, new ChapterVerse(24, 9)
, new ChapterVerse(25, 17)
, new ChapterVerse(28, 12)
, new ChapterVerse(28, 58)
, new ChapterVerse(28, 60)
, new ChapterVerse(29, 2)
, new ChapterVerse(29, 9)
, new ChapterVerse(29, 16)
, new ChapterVerse(30, 7)
, new ChapterVerse(31, 26)
, new ChapterVerse(31, 28)
 ];
	}

	private sealed class JoshuaSE : BookChaptersVerses
	{
		public JoshuaSE() : base($"{nameof(Id.Joshua)}", Id.Joshua) { }
		public override BibleBook BibleBook => BibleBook.Joshua;
		public override List<int> Chapters => [2, 3, 5, 7, 8, 9, 10, 15, 21, 22, 23, 24];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 10)
, new ChapterVerse(2, 23)
, new ChapterVerse(3, 3)
, new ChapterVerse(5, 1)
, new ChapterVerse(7, 17)
, new ChapterVerse(8, 1)
, new ChapterVerse(8, 26)
, new ChapterVerse(8, 32)
, new ChapterVerse(9, 3)
, new ChapterVerse(9, 24)
, new ChapterVerse(10, 23)
, new ChapterVerse(15, 19)
, new ChapterVerse(21, 9)
, new ChapterVerse(21, 44)
, new ChapterVerse(22, 2)
, new ChapterVerse(23, 3)
, new ChapterVerse(23, 6)
, new ChapterVerse(23, 15)
, new ChapterVerse(24, 7)
, new ChapterVerse(24, 27)
, new ChapterVerse(24, 31)
 ];
	}

	private sealed class JudgesSE : BookChaptersVerses
	{
		public JudgesSE() : base($"{nameof(Id.Judges)}", Id.Judges) { }
		public override BibleBook BibleBook => BibleBook.Judges;
		public override List<int> Chapters => [1, 2, 3, 4, 7, 8, 9, 11, 14, 16, 18];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 15)
, new ChapterVerse(2, 7)
, new ChapterVerse(3, 1)
, new ChapterVerse(3, 9)
, new ChapterVerse(4, 23)
, new ChapterVerse(4, 24)
, new ChapterVerse(7, 22)
, new ChapterVerse(8, 16)
, new ChapterVerse(9, 3)
, new ChapterVerse(9, 25)
, new ChapterVerse(9, 36)
, new ChapterVerse(9, 56)
, new ChapterVerse(11, 21)
, new ChapterVerse(11, 22)
, new ChapterVerse(11, 24)
, new ChapterVerse(14, 6)
, new ChapterVerse(14, 8)
, new ChapterVerse(16, 23)
, new ChapterVerse(18, 27)
 ];
	}

	private sealed class RuthSE : BookChaptersVerses
	{
		public RuthSE() : base($"{nameof(Id.Ruth)}", Id.Ruth) { }
		public override BibleBook BibleBook => BibleBook.Ruth;
		public override List<int> Chapters => [2, 3];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 17)
, new ChapterVerse(2, 18)
, new ChapterVerse(2, 19)
, new ChapterVerse(2, 21)
, new ChapterVerse(3, 4)
, new ChapterVerse(3, 10)
, new ChapterVerse(3, 16)
 ];
	}

	private sealed class FirstSamuelSE : BookChaptersVerses
	{
		public FirstSamuelSE() : base($"{nameof(Id.FirstSamuel)}", Id.FirstSamuel) { }
		public override BibleBook BibleBook => BibleBook.FirstSamuel;
		public override List<int> Chapters => [2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 15, 16, 19, 22, 23, 24, 25, 26, 28, 30, 31];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 17)
, new ChapterVerse(2, 22)
, new ChapterVerse(3, 12)
, new ChapterVerse(4, 4)
, new ChapterVerse(5, 1)
, new ChapterVerse(6, 18)
, new ChapterVerse(7, 16)
, new ChapterVerse(8, 10)
, new ChapterVerse(8, 21)
, new ChapterVerse(10, 8)
, new ChapterVerse(10, 20)
, new ChapterVerse(10, 25)
, new ChapterVerse(12, 7)
, new ChapterVerse(12, 20)
, new ChapterVerse(12, 24)
, new ChapterVerse(13, 3)
, new ChapterVerse(13, 14)
, new ChapterVerse(15, 2)
, new ChapterVerse(15, 16)
, new ChapterVerse(16, 3)
, new ChapterVerse(16, 4)
, new ChapterVerse(19, 7)
, new ChapterVerse(19, 18)
, new ChapterVerse(22, 21)
, new ChapterVerse(23, 5)
, new ChapterVerse(24, 10)
, new ChapterVerse(24, 18)
, new ChapterVerse(25, 8)
, new ChapterVerse(25, 24)
, new ChapterVerse(25, 29)
, new ChapterVerse(25, 33)
, new ChapterVerse(25, 35)
, new ChapterVerse(26, 19)
, new ChapterVerse(28, 2)
, new ChapterVerse(28, 8)
, new ChapterVerse(28, 9)
, new ChapterVerse(30, 18)
, new ChapterVerse(30, 23)
, new ChapterVerse(31, 11)
 ];
	}

	private sealed class SecondSamuelSE : BookChaptersVerses
	{
		public SecondSamuelSE() : base($"{nameof(Id.SecondSamuel)}", Id.SecondSamuel) { }
		public override BibleBook BibleBook => BibleBook.SecondSamuel;
		public override List<int> Chapters => [3, 4, 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 19, 20, 21, 23, 24];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(3, 13)
, new ChapterVerse(3, 19)
, new ChapterVerse(3, 25)
, new ChapterVerse(4, 5)
, new ChapterVerse(5, 7)
, new ChapterVerse(6, 2)
, new ChapterVerse(7, 21)
, new ChapterVerse(8, 7)
, new ChapterVerse(8, 9)
, new ChapterVerse(11, 9)
, new ChapterVerse(11, 19)
, new ChapterVerse(11, 20)
, new ChapterVerse(11, 22)
, new ChapterVerse(12, 9)
, new ChapterVerse(12, 24)
, new ChapterVerse(13, 21)
, new ChapterVerse(13, 22)
, new ChapterVerse(13, 32)
, new ChapterVerse(14, 19)
, new ChapterVerse(15, 16)
, new ChapterVerse(15, 34)
, new ChapterVerse(16, 3)
, new ChapterVerse(19, 19)
, new ChapterVerse(19, 37)
, new ChapterVerse(20, 3)
, new ChapterVerse(21, 11)
, new ChapterVerse(21, 19)
, new ChapterVerse(23, 20)
, new ChapterVerse(24, 2)
 ];
	}

	private sealed class FirstKingsSE : BookChaptersVerses
	{
		public FirstKingsSE() : base($"{nameof(Id.FirstKings)}", Id.FirstKings) { }
		public override BibleBook BibleBook => BibleBook.FirstKings;
		public override List<int> Chapters => [2, 4, 5, 7, 8, 9, 10, 11, 14, 16, 18, 19, 20];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 3)
, new ChapterVerse(2, 5)
, new ChapterVerse(2, 9)
, new ChapterVerse(2, 15)
, new ChapterVerse(2, 22)
, new ChapterVerse(2, 43)
, new ChapterVerse(2, 44)
, new ChapterVerse(4, 34)
, new ChapterVerse(5, 8)
, new ChapterVerse(7, 37)
, new ChapterVerse(7, 48)
, new ChapterVerse(8, 14)
, new ChapterVerse(8, 15)
, new ChapterVerse(8, 24)
, new ChapterVerse(8, 25)
, new ChapterVerse(8, 31)
, new ChapterVerse(8, 54)
, new ChapterVerse(8, 55)
, new ChapterVerse(8, 63)
, new ChapterVerse(9, 9)
, new ChapterVerse(10, 2)
, new ChapterVerse(10, 4)
, new ChapterVerse(11, 10)
, new ChapterVerse(11, 14)
, new ChapterVerse(11, 20)
, new ChapterVerse(11, 31)
, new ChapterVerse(11, 35)
, new ChapterVerse(14, 6)
, new ChapterVerse(16, 12)
, new ChapterVerse(18, 4)
, new ChapterVerse(18, 13)
, new ChapterVerse(18, 36)
, new ChapterVerse(19, 1)
, new ChapterVerse(20, 13)
, new ChapterVerse(20, 22)
 ];
	}

	private sealed class SecondKingsSE : BookChaptersVerses
	{
		public SecondKingsSE() : base($"{nameof(Id.SecondKings)}", Id.SecondKings) { }
		public override BibleBook BibleBook => BibleBook.SecondKings;
		public override List<int> Chapters => [5, 7, 8, 9, 10, 11, 12, 15, 18, 19, 20, 21, 22, 23, 25];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(5, 20)
, new ChapterVerse(7, 12)
, new ChapterVerse(7, 16)
, new ChapterVerse(8, 4)
, new ChapterVerse(8, 5)
, new ChapterVerse(8, 12)
, new ChapterVerse(9, 25)
, new ChapterVerse(10, 10)
, new ChapterVerse(10, 11)
, new ChapterVerse(10, 27)
, new ChapterVerse(10, 33)
, new ChapterVerse(11, 1)
, new ChapterVerse(12, 18)
, new ChapterVerse(15, 16)
, new ChapterVerse(18, 12)
, new ChapterVerse(18, 14)
, new ChapterVerse(18, 24)
, new ChapterVerse(18, 27)
, new ChapterVerse(19, 4)
, new ChapterVerse(19, 11)
, new ChapterVerse(19, 16)
, new ChapterVerse(20, 3)
, new ChapterVerse(20, 15)
, new ChapterVerse(21, 13)
, new ChapterVerse(21, 14)
, new ChapterVerse(21, 24)
, new ChapterVerse(22, 16)
, new ChapterVerse(23, 4)
, new ChapterVerse(23, 18)
, new ChapterVerse(25, 29)
 ];
	}

	private sealed class FirstChroniclesSE : BookChaptersVerses
	{
		public FirstChroniclesSE() : base($"{nameof(Id.FirstChronicles)}", Id.FirstChronicles) { }
		public override BibleBook BibleBook => BibleBook.FirstChronicles;
		public override List<int> Chapters => [4, 6, 10, 11, 13, 15, 17, 18, 22];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(4, 10)
, new ChapterVerse(6, 65)
, new ChapterVerse(10, 11)
, new ChapterVerse(11, 22)
, new ChapterVerse(13, 6)
, new ChapterVerse(13, 12)
, new ChapterVerse(15, 12)
, new ChapterVerse(15, 15)
, new ChapterVerse(15, 17)
, new ChapterVerse(17, 19)
, new ChapterVerse(18, 7)
, new ChapterVerse(22, 18)
 ];
	}

	private sealed class SecondChroniclesSE : BookChaptersVerses
	{
		public SecondChroniclesSE() : base($"{nameof(Id.SecondChronicles)}", Id.SecondChronicles) { }
		public override BibleBook BibleBook => BibleBook.SecondChronicles;
		public override List<int> Chapters => [4, 6, 7, 9, 10, 14, 21, 25, 29, 33, 34, 36];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(4, 19)
, new ChapterVerse(6, 3)
, new ChapterVerse(6, 4)
, new ChapterVerse(6, 15)
, new ChapterVerse(6, 16)
, new ChapterVerse(7, 18)
, new ChapterVerse(7, 22)
, new ChapterVerse(9, 1)
, new ChapterVerse(9, 3)
, new ChapterVerse(10, 13)
, new ChapterVerse(14, 14)
, new ChapterVerse(21, 16)
, new ChapterVerse(21, 17)
, new ChapterVerse(25, 20)
, new ChapterVerse(29, 16)
, new ChapterVerse(29, 20)
, new ChapterVerse(33, 8)
, new ChapterVerse(33, 25)
, new ChapterVerse(34, 4)
, new ChapterVerse(34, 19)
, new ChapterVerse(34, 24)
, new ChapterVerse(34, 32)
, new ChapterVerse(34, 33)
, new ChapterVerse(36, 19)
 ];
	}

	private sealed class NehemiahSE : BookChaptersVerses
	{
		public NehemiahSE() : base($"{nameof(Id.Nehemiah)}", Id.Nehemiah) { }
		public override BibleBook BibleBook => BibleBook.Nehemiah;
		public override List<int> Chapters => [2, 3, 9, 13];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 9)
, new ChapterVerse(3, 13)
, new ChapterVerse(9, 6)
, new ChapterVerse(9, 32)
, new ChapterVerse(13, 17)
, new ChapterVerse(13, 18)
, new ChapterVerse(13, 27)
 ];
	}

	private sealed class EstherSE : BookChaptersVerses
	{
		public EstherSE() : base($"{nameof(Id.Esther)}", Id.Esther) { }
		public override BibleBook BibleBook => BibleBook.Esther;
		public override List<int> Chapters => [2, 3, 4, 6, 8, 9];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 13)
, new ChapterVerse(2, 18)
, new ChapterVerse(3, 3)
, new ChapterVerse(4, 7)
, new ChapterVerse(4, 9)
, new ChapterVerse(4, 12)
, new ChapterVerse(6, 13)
, new ChapterVerse(8, 4)
, new ChapterVerse(9, 19)
, new ChapterVerse(9, 21)
, new ChapterVerse(9, 23)
, new ChapterVerse(9, 27)
, new ChapterVerse(9, 29)
 ];
	}

	private sealed class JobSE : BookChaptersVerses
	{
		public JobSE() : base($"{nameof(Id.Job)}", Id.Job) { }
		public override BibleBook BibleBook => BibleBook.Job;
		public override List<int> Chapters => [1, 2];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 10)
, new ChapterVerse(2, 11)
 ];
	}

	private sealed class PsalmsSE : BookChaptersVerses
	{
		public PsalmsSE() : base($"{nameof(Id.Psalms)}", Id.Psalms) { }
		public override BibleBook BibleBook => BibleBook.Psalms;
		public override List<int> Chapters => [47, 60, 83, 98, 132, 137];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(47, 4)
, new ChapterVerse(60, 1)
, new ChapterVerse(83, 12)
, new ChapterVerse(98, 3)
, new ChapterVerse(132, 1)
, new ChapterVerse(137, 7)
 ];
	}

	private sealed class ProverbsSE : BookChaptersVerses
	{
		public ProverbsSE() : base($"{nameof(Id.Proverbs)}", Id.Proverbs) { }
		public override BibleBook BibleBook => BibleBook.Proverbs;
		public override List<int> Chapters => [3, 7];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(3, 12)
, new ChapterVerse(7, 4)
 ];
	}

	private sealed class EcclesiastesSE : BookChaptersVerses
	{
		public EcclesiastesSE() : base($"{nameof(Id.Ecclesiastes)}", Id.Ecclesiastes) { }
		public override BibleBook BibleBook => BibleBook.Ecclesiastes;
		public override List<int> Chapters => [2, 4, 5, 7];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 12)
, new ChapterVerse(4, 3)
, new ChapterVerse(5, 4)
, new ChapterVerse(7, 13)
 ];
	}

	private sealed class SongofSolomonSE : BookChaptersVerses
	{
		public SongofSolomonSE() : base($"{nameof(Id.SongofSolomon)}", Id.SongofSolomon) { }
		public override BibleBook BibleBook => BibleBook.SongofSolomon;
		public override List<int> Chapters => [3, 6];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(3, 1)
, new ChapterVerse(3, 2)
, new ChapterVerse(3, 3)
, new ChapterVerse(3, 4)
, new ChapterVerse(6, 4)
 ];
	}

	private sealed class IsaiahSE : BookChaptersVerses
	{
		public IsaiahSE() : base($"{nameof(Id.Isaiah)}", Id.Isaiah) { }
		public override BibleBook BibleBook => BibleBook.Isaiah;
		public override List<int> Chapters => [2, 3, 4, 5, 7, 8, 11, 21, 22, 36, 37, 38, 39, 41, 52, 53, 63];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 20)
, new ChapterVerse(3, 18)
, new ChapterVerse(4, 4)
, new ChapterVerse(5, 5)
, new ChapterVerse(5, 24)
, new ChapterVerse(7, 6)
, new ChapterVerse(7, 17)
, new ChapterVerse(8, 2)
, new ChapterVerse(8, 6)
, new ChapterVerse(11, 15)
, new ChapterVerse(21, 4)
, new ChapterVerse(22, 8)
, new ChapterVerse(36, 9)
, new ChapterVerse(36, 22)
, new ChapterVerse(37, 4)
, new ChapterVerse(37, 17)
, new ChapterVerse(38, 3)
, new ChapterVerse(39, 4)
, new ChapterVerse(41, 22)
, new ChapterVerse(52, 10)
, new ChapterVerse(53, 6)
, new ChapterVerse(63, 11)
 ];
	}

	private sealed class JeremiahSE : BookChaptersVerses
	{
		public JeremiahSE() : base($"{nameof(Id.Jeremiah)}", Id.Jeremiah) { }
		public override BibleBook BibleBook => BibleBook.Jeremiah;
		public override List<int> Chapters => [1, 2, 7, 8, 9, 15, 16, 19, 20, 23, 25, 26, 30, 31, 32, 34, 35, 36, 38, 41, 43, 44, 51, 52];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 17)
, new ChapterVerse(2, 20)
, new ChapterVerse(2, 27)
, new ChapterVerse(7, 10)
, new ChapterVerse(7, 12)
, new ChapterVerse(7, 15)
, new ChapterVerse(8, 7)
, new ChapterVerse(9, 1)
, new ChapterVerse(15, 6)
, new ChapterVerse(16, 10)
, new ChapterVerse(19, 15)
, new ChapterVerse(20, 2)
, new ChapterVerse(23, 25)
, new ChapterVerse(25, 13)
, new ChapterVerse(25, 30)
, new ChapterVerse(26, 2)
, new ChapterVerse(26, 8)
, new ChapterVerse(26, 10)
, new ChapterVerse(26, 12)
, new ChapterVerse(26, 15)
, new ChapterVerse(26, 22)
, new ChapterVerse(30, 2)
, new ChapterVerse(30, 9)
, new ChapterVerse(31, 7)
, new ChapterVerse(32, 13)
, new ChapterVerse(32, 14)
, new ChapterVerse(32, 23)
, new ChapterVerse(32, 42)
, new ChapterVerse(34, 6)
, new ChapterVerse(35, 14)
, new ChapterVerse(35, 17)
, new ChapterVerse(36, 2)
, new ChapterVerse(36, 3)
, new ChapterVerse(36, 4)
, new ChapterVerse(36, 13)
, new ChapterVerse(36, 16)
, new ChapterVerse(36, 18)
, new ChapterVerse(36, 20)
, new ChapterVerse(36, 24)
, new ChapterVerse(36, 28)
, new ChapterVerse(36, 31)
, new ChapterVerse(36, 32)
, new ChapterVerse(38, 9)
, new ChapterVerse(38, 10)
, new ChapterVerse(38, 16)
, new ChapterVerse(41, 3)
, new ChapterVerse(41, 9)
, new ChapterVerse(41, 11)
, new ChapterVerse(41, 16)
, new ChapterVerse(43, 1)
, new ChapterVerse(43, 5)
, new ChapterVerse(44, 2)
, new ChapterVerse(44, 4)
, new ChapterVerse(51, 12)
, new ChapterVerse(51, 24)
, new ChapterVerse(51, 60)
, new ChapterVerse(51, 61)
, new ChapterVerse(52, 33)
 ];
	}

	private sealed class LamentationsSE : BookChaptersVerses
	{
		public LamentationsSE() : base($"{nameof(Id.Lamentations)}", Id.Lamentations) { }
		public override BibleBook BibleBook => BibleBook.Lamentations;
		public override List<int> Chapters => [2];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 2)
 ];
	}

	private sealed class EzekielSE : BookChaptersVerses
	{
		public EzekielSE() : base($"{nameof(Id.Ezekiel)}", Id.Ezekiel) { }
		public override BibleBook BibleBook => BibleBook.Ezekiel;
		public override List<int> Chapters => [1, 2, 3, 5, 7, 9, 11, 12, 14, 15, 16, 17, 18, 21, 22, 23, 27, 33, 34, 36, 42, 43, 44, 46];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 11)
, new ChapterVerse(1, 23)
, new ChapterVerse(2, 2)
, new ChapterVerse(2, 8)
, new ChapterVerse(3, 1)
, new ChapterVerse(3, 2)
, new ChapterVerse(3, 3)
, new ChapterVerse(5, 9)
, new ChapterVerse(7, 3)
, new ChapterVerse(7, 8)
, new ChapterVerse(9, 8)
, new ChapterVerse(11, 13)
, new ChapterVerse(11, 25)
, new ChapterVerse(12, 25)
, new ChapterVerse(14, 9)
, new ChapterVerse(14, 22)
, new ChapterVerse(14, 23)
, new ChapterVerse(15, 4)
, new ChapterVerse(16, 45)
, new ChapterVerse(16, 48)
, new ChapterVerse(16, 58)
, new ChapterVerse(17, 4)
, new ChapterVerse(18, 13)
, new ChapterVerse(18, 19)
, new ChapterVerse(21, 20)
, new ChapterVerse(22, 2)
, new ChapterVerse(22, 24)
, new ChapterVerse(23, 21)
, new ChapterVerse(23, 22)
, new ChapterVerse(23, 36)
, new ChapterVerse(27, 3)
, new ChapterVerse(27, 5)
, new ChapterVerse(33, 5)
, new ChapterVerse(34, 23)
, new ChapterVerse(36, 27)
, new ChapterVerse(42, 18)
, new ChapterVerse(43, 21)
, new ChapterVerse(44, 5)
, new ChapterVerse(46, 12)
 ];
	}

	private sealed class DanielSE : BookChaptersVerses
	{
		public DanielSE() : base($"{nameof(Id.Daniel)}", Id.Daniel) { }
		public override BibleBook BibleBook => BibleBook.Daniel;
		public override List<int> Chapters => [1, 8, 9, 10, 11];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 13)
, new ChapterVerse(1, 15)
, new ChapterVerse(8, 19)
, new ChapterVerse(9, 13)
, new ChapterVerse(10, 14)
, new ChapterVerse(11, 2)
 ];
	}

	private sealed class AmosSE : BookChaptersVerses
	{
		public AmosSE() : base($"{nameof(Id.Amos)}", Id.Amos) { }
		public override BibleBook BibleBook => BibleBook.Amos;
		public override List<int> Chapters => [3, 5, 8];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(3, 2)
, new ChapterVerse(5, 26)
, new ChapterVerse(8, 11)
 ];
	}

	private sealed class ObadiahSE : BookChaptersVerses
	{
		public ObadiahSE() : base($"{nameof(Id.Obadiah)}", Id.Obadiah) { }
		public override BibleBook BibleBook => BibleBook.Obadiah;
		public override List<int> Chapters => [1];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 17)
, new ChapterVerse(1, 20)
 ];
	}

	private sealed class MicahSE : BookChaptersVerses
	{
		public MicahSE() : base($"{nameof(Id.Micah)}", Id.Micah) { }
		public override BibleBook BibleBook => BibleBook.Micah;
		public override List<int> Chapters => [5, 6];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(5, 1)
, new ChapterVerse(6, 1)
 ];
	}

	private sealed class ZephaniahSE : BookChaptersVerses
	{
		public ZephaniahSE() : base($"{nameof(Id.Zephaniah)}", Id.Zephaniah) { }
		public override BibleBook BibleBook => BibleBook.Zephaniah;
		public override List<int> Chapters => [1, 2];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(1, 18)
, new ChapterVerse(2, 11)
 ];
	}

	private sealed class HaggaiSE : BookChaptersVerses
	{
		public HaggaiSE() : base($"{nameof(Id.Haggai)}", Id.Haggai) { }
		public override BibleBook BibleBook => BibleBook.Haggai;
		public override List<int> Chapters => [2];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 17)
 ];
	}

	private sealed class ZechariahSE : BookChaptersVerses
	{
		public ZechariahSE() : base($"{nameof(Id.Zechariah)}", Id.Zechariah) { }
		public override BibleBook BibleBook => BibleBook.Zechariah;
		public override List<int> Chapters => [8, 11, 12];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(8, 9)
, new ChapterVerse(11, 14)
, new ChapterVerse(12, 10)
 ];
	}

	private sealed class MalachiSE : BookChaptersVerses
	{
		public MalachiSE() : base($"{nameof(Id.Malachi)}", Id.Malachi) { }
		public override BibleBook BibleBook => BibleBook.Malachi;
		public override List<int> Chapters => [2, 3, 4];
		public override List<ChapterVerse>? Verses =>
	 [
	 new ChapterVerse(2, 4)
, new ChapterVerse(3, 10)
, new ChapterVerse(4, 5)
 ];
	}


	#endregion
}

// Ignore Spelling: Cnt SongOf
