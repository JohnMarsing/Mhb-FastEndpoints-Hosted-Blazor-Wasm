using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Hebrew.Enums;

public abstract class Zepc3v8Word : SmartEnum<Zepc3v8Word>
{
	#region  Declared Public Instances
	public static readonly Zepc3v8Word Word001 = new Word001SE();
	public static readonly Zepc3v8Word Word002 = new Word002SE();
	public static readonly Zepc3v8Word Word003 = new Word003SE();
	public static readonly Zepc3v8Word Word004 = new Word004SE();
	public static readonly Zepc3v8Word Word005 = new Word005SE();
	public static readonly Zepc3v8Word Word006 = new Word006SE();
	public static readonly Zepc3v8Word Word007 = new Word007SE();
	public static readonly Zepc3v8Word Word008 = new Word008SE();
	public static readonly Zepc3v8Word Word009 = new Word009SE();
	public static readonly Zepc3v8Word Word010 = new Word010SE();
	public static readonly Zepc3v8Word Word011 = new Word011SE();
	public static readonly Zepc3v8Word Word012 = new Word012SE();
	public static readonly Zepc3v8Word Word013 = new Word013SE();
	public static readonly Zepc3v8Word Word014 = new Word014SE();
	public static readonly Zepc3v8Word Word015 = new Word015SE();
	public static readonly Zepc3v8Word Word016 = new Word016SE();
	public static readonly Zepc3v8Word Word017 = new Word017SE();
	public static readonly Zepc3v8Word Word018 = new Word018SE();
	public static readonly Zepc3v8Word Word019 = new Word019SE();
	public static readonly Zepc3v8Word Word020 = new Word020SE();
	public static readonly Zepc3v8Word Word021 = new Word021SE();
	public static readonly Zepc3v8Word Word022 = new Word022SE();
	public static readonly Zepc3v8Word Word023 = new Word023SE();
	public static readonly Zepc3v8Word Word024 = new Word024SE();
	public static readonly Zepc3v8Word Word025 = new Word025SE();
	public static readonly Zepc3v8Word Word026 = new Word026SE();
	// SE=SmartEnum
	#endregion

	private Zepc3v8Word(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract string? Translation { get; }
	public abstract string? PRS { get; }
	#endregion

	#region Private Instantiation
	private sealed class Word001SE : Zepc3v8Word
	{
		public Word001SE() : base("Word001", 1) { }
		public override string PRS => "<span class='nrl'>לָ</span>כֵן";
		public override string Translation => "Therefore";
	}
	private sealed class Word002SE : Zepc3v8Word
	{
		public Word002SE() : base("Word002", 2) { }
		public override string PRS => "חַכּוּ־";
		public override string Translation => "Therefore wait";
	}
	private sealed class Word003SE : Zepc3v8Word
	{
		public Word003SE() : base("Word003", 3) { }
		public override string PRS => "לִ<span class='nrl'>י</span>";
		public override string Translation => "_";
	}
	private sealed class Word004SE : Zepc3v8Word
	{
		public Word004SE() : base("Word004", 4) { }
		public override string PRS => "נְאֻם־";
		public override string Translation => "ye upon me saith";
	}
	private sealed class Word005SE : Zepc3v8Word
	{
		public Word005SE() : base("Word005", 5) { }
		public override string PRS => "יְהוָה";
		public override string Translation => "YHVH";
	}
	private sealed class Word006SE : Zepc3v8Word
	{
		public Word006SE() : base("Word006", 6) { }
		public override string PRS => "<span class='nrl'>לְ</span>יוֹם";
		public override string Translation => "until the day";
	}
	private sealed class Word007SE : Zepc3v8Word
	{
		public Word007SE() : base("Word007", 7) { }
		public override string PRS => "קוּמִ<span class='nrl'>י</span>";
		public override string Translation => "that I rise up";
	}
	private sealed class Word008SE : Zepc3v8Word
	{
		public Word008SE() : base("Word008", 8) { }
		public override string PRS => "<span class='nrl'>לְ</span>עַד";
		public override string Translation => "to the prey";
	}
	private sealed class Word009SE : Zepc3v8Word
	{
		public Word009SE() : base("Word009", 9) { }
		public override string PRS => "כִּי";
		public override string Translation => "Indeed";
	}
	private sealed class Word010SE : Zepc3v8Word
	{
		public Word010SE() : base("Word010", 10) { }
		public override string PRS => "מִשְׁפָּטִ<span class='nrl'>י</span>";
		public override string Translation => "for my determination";
	}
	private sealed class Word011SE : Zepc3v8Word
	{
		public Word011SE() : base("Word011", 11) { }
		public override string PRS => "<span class='nrl'>לֶ</span>אֱסֹף";
		public override string Translation => "[is] to gather";
	}
	private sealed class Word012SE : Zepc3v8Word
	{
		public Word012SE() : base("Word012", 12) { }
		public override string PRS => "גּוֹיִם";
		public override string Translation => "the nations";
	}
	private sealed class Word013SE : Zepc3v8Word
	{
		public Word013SE() : base("Word013", 13) { }
		public override string PRS => "<span class='nrl'>לְ</span>קָבְצִ<span class='nrl'>י</span>";
		public override string Translation => "that I may assemble";
	}
	private sealed class Word014SE : Zepc3v8Word
	{
		public Word014SE() : base("Word014", 14) { }
		public override string PRS => "מַמְלָכוֹת";
		public override string Translation => "the kingdoms";
	}
	private sealed class Word015SE : Zepc3v8Word
	{
		public Word015SE() : base("Word015", 15) { }
		public override string PRS => "<span class='nrl'>לִ</span>שְׁפֹּךְ";
		public override string Translation => "to pour";
	}
	private sealed class Word016SE : Zepc3v8Word
	{
		public Word016SE() : base("Word016", 16) { }
		public override string PRS => "עֲלֵי<span class='nrl'>הֶם</span>";
		public override string Translation => "on";
	}
	private sealed class Word017SE : Zepc3v8Word
	{
		public Word017SE() : base("Word017", 17) { }
		public override string PRS => "זַעְמִ<span class='nrl'>י</span>";
		public override string Translation => "upon them mine indignation";
	}
	private sealed class Word018SE : Zepc3v8Word
	{
		public Word018SE() : base("Word018", 18) { }
		public override string PRS => "כֹּל";
		public override string Translation => "all";
	}
	private sealed class Word019SE : Zepc3v8Word
	{
		public Word019SE() : base("Word019", 19) { }
		public override string PRS => "חֲרוֹן";
		public override string Translation => "[even] all my fierce";
	}
	private sealed class Word020SE : Zepc3v8Word
	{
		public Word020SE() : base("Word020", 20) { }
		public override string PRS => "אַפִּ<span class='nrl'>י</span>";
		public override string Translation => "anger";
	}
	private sealed class Word021SE : Zepc3v8Word
	{
		public Word021SE() : base("Word021", 21) { }
		public override string PRS => "כִּי";
		public override string Translation => "Indeed";
	}
	private sealed class Word022SE : Zepc3v8Word
	{
		public Word022SE() : base("Word022", 22) { }
		public override string PRS => "<span class='nrl'>בְּ</span>אֵשׁ";
		public override string Translation => "with the fire";
	}
	private sealed class Word023SE : Zepc3v8Word
	{
		public Word023SE() : base("Word023", 23) { }
		public override string PRS => "קִנְאָתִ<span class='nrl'>י</span>";
		public override string Translation => "of my jealousy";
	}
	private sealed class Word024SE : Zepc3v8Word
	{
		public Word024SE() : base("Word024", 24) { }
		public override string PRS => "תֵּאָכֵל";
		public override string Translation => "shall be devoured";
	}
	private sealed class Word025SE : Zepc3v8Word
	{
		public Word025SE() : base("Word025", 25) { }
		public override string PRS => "כָּל־";
		public override string Translation => "for all";
	}
	private sealed class Word026SE : Zepc3v8Word
	{
		public Word026SE() : base("Word026", 26) { }
		public override string PRS => "<span class='nrl'>הָ</span>אָרֶץ";
		public override string Translation => "the earth";
	}
	#endregion

}

// Ignore Spelling: PRS