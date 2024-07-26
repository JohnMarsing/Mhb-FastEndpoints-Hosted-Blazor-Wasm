using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Hebrew.Enums;

public abstract class HebrewChartExtra : SmartEnum<HebrewChartExtra>
{

	#region Id's
	private static class Id
	{
		internal const int NotAuthenticated = 1;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly HebrewChartExtra holam_haser_for_vav = new holam_haser_for_vavSE();
	public static readonly HebrewChartExtra shin_dot = new shin_dotSE();
	public static readonly HebrewChartExtra sin_dot = new sin_dotSE();
	public static readonly HebrewChartExtra upper_dot = new upper_dotSE();
	public static readonly HebrewChartExtra Chaf_Sofit = new Chaf_SofitSE();
	public static readonly HebrewChartExtra Mem_Sofit = new Mem_SofitSE();
	public static readonly HebrewChartExtra Nun_Sofit = new Nun_SofitSE();
	public static readonly HebrewChartExtra Pey_Sofit = new Pey_SofitSE();
	public static readonly HebrewChartExtra Tsadi_Sofit = new Tsadi_SofitSE();
	// SE=SmartEnum
	#endregion

	private HebrewChartExtra(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract int UniInt { get; }
	public abstract string? UnicodeName { get; }
	public abstract string? UnicodeNameOriginal { get; }
	public abstract string? Hebrew { get; }
	public abstract string? EngLetter { get; }
	public abstract int Gematria { get; }
	public abstract bool IsSofit { get; }
	#endregion

	#region Private Instantiation
	private sealed class holam_haser_for_vavSE : HebrewChartExtra
	{
		public holam_haser_for_vavSE() : base("holam_haser_for_vav", 1) { }
		public override int UniInt => 1466;
		public override string UnicodeName => "holam_haser_for_vav";
		public override string UnicodeNameOriginal => "holam haser for vav";
		public override string Hebrew => "ֺ";
		public override string EngLetter => "  ";
		public override int Gematria => 0;
		public override bool IsSofit => false;
	}
	private sealed class shin_dotSE : HebrewChartExtra
	{
		public shin_dotSE() : base("shin_dot", 2) { }
		public override int UniInt => 1473;
		public override string UnicodeName => "shin_dot";
		public override string UnicodeNameOriginal => "shin dot";
		public override string Hebrew => "\u05C1"; // "ׁ";
		public override string EngLetter => "  ";
		public override int Gematria => 0;
		public override bool IsSofit => false;
	}
	private sealed class sin_dotSE : HebrewChartExtra
	{
		public sin_dotSE() : base("sin_dot", 3) { }
		public override int UniInt => 1474;
		public override string UnicodeName => "sin_dot";
		public override string UnicodeNameOriginal => "sin dot";
		public override string Hebrew => "ׂ";
		public override string EngLetter => "  ";
		public override int Gematria => 0;
		public override bool IsSofit => false;
	}
	private sealed class upper_dotSE : HebrewChartExtra
	{
		public upper_dotSE() : base("upper_dot", 4) { }
		public override int UniInt => 1476;
		public override string UnicodeName => "upper_dot";
		public override string UnicodeNameOriginal => "upper dot";
		public override string Hebrew => "ׄ";
		public override string EngLetter => "  ";
		public override int Gematria => 0;
		public override bool IsSofit => false;
	}
	private sealed class Chaf_SofitSE : HebrewChartExtra
	{
		public Chaf_SofitSE() : base("Chaf_Sofit", 5) { }
		public override int UniInt => 1498;
		public override string UnicodeName => "Chaf_Sofit";
		public override string UnicodeNameOriginal => "Chaf Sofit";
		public override string Hebrew => "ך";
		public override string EngLetter => "C ";
		public override int Gematria => 500;
		public override bool IsSofit => true;
	}
	private sealed class Mem_SofitSE : HebrewChartExtra
	{
		public Mem_SofitSE() : base("Mem_Sofit", 6) { }
		public override int UniInt => 1501;
		public override string UnicodeName => "Mem_Sofit";
		public override string UnicodeNameOriginal => "Mem Sofit";
		public override string Hebrew => "ם";
		public override string EngLetter => "M ";
		public override int Gematria => 600;
		public override bool IsSofit => true;
	}
	private sealed class Nun_SofitSE : HebrewChartExtra
	{
		public Nun_SofitSE() : base("Nun_Sofit", 7) { }
		public override int UniInt => 1503;
		public override string UnicodeName => "Nun_Sofit";
		public override string UnicodeNameOriginal => "Nun Sofit";
		public override string Hebrew => "ן";
		public override string EngLetter => "N ";
		public override int Gematria => 700;
		public override bool IsSofit => true;
	}
	private sealed class Pey_SofitSE : HebrewChartExtra
	{
		public Pey_SofitSE() : base("Pey_Sofit", 8) { }
		public override int UniInt => 1507;
		public override string UnicodeName => "Pey_Sofit";
		public override string UnicodeNameOriginal => "Pey Sofit";
		public override string Hebrew => "ף";
		public override string EngLetter => "P ";
		public override int Gematria => 800;
		public override bool IsSofit => true;
	}
	private sealed class Tsadi_SofitSE : HebrewChartExtra
	{
		public Tsadi_SofitSE() : base("Tsadi_Sofit", 9) { }
		public override int UniInt => 1509;
		public override string UnicodeName => "Tsadi_Sofit";
		public override string UnicodeNameOriginal => "Tsadi Sofit";
		public override string Hebrew => "ץ";
		public override string EngLetter => "TS";
		public override int Gematria => 900;
		public override bool IsSofit => true;
	}

	#endregion

}
