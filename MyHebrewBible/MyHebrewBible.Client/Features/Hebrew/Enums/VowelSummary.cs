using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Hebrew.Enums;

public abstract class VowelSummary : SmartEnum<VowelSummary>
{
	#region Id's
	private static class Id
	{
		//internal const int Foo = 1;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly VowelSummary Kamatz = new KamatzSE();
	public static readonly VowelSummary Patach = new PatachSE();
	public static readonly VowelSummary Segal = new SegalSE();
	public static readonly VowelSummary ChatafKamatz = new ChatafKamatzSE();
	public static readonly VowelSummary ChatafPatach = new ChatafPatachSE();
	public static readonly VowelSummary ChatafSegal = new ChatafSegalSE();
	public static readonly VowelSummary Tsere = new TsereSE();
	public static readonly VowelSummary Chirik = new ChirikSE();
	public static readonly VowelSummary Shva = new ShvaSE();
	public static readonly VowelSummary Kubutz = new KubutzSE();
	public static readonly VowelSummary Shuruk = new ShurukSE();
	public static readonly VowelSummary Cholem = new CholemSE();
	// SE=SmartEnum
	#endregion

	private VowelSummary(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract int UniInt { get; }
	public abstract string? UnicodeName { get; }
	public abstract string? UnicodeNameHtml { get; }
	public abstract string? Hebrew { get; }
	public abstract string? ExampleHtml { get; }
	public abstract string? Sound { get; }
	public abstract bool IsWithChataf { get; }
	#endregion


	#region Private Instantiation
	private sealed class KamatzSE : VowelSummary
	{
		public KamatzSE() : base("Kamatz", 1) { }
		public override int UniInt => 1464;
		public override string UnicodeName => "kamatz";
		public override string Hebrew => "ָ";
		public override string UnicodeNameHtml => "kam<b>ah</b>tz";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1464</span>";
		public override string Sound => "bog";
		public override bool IsWithChataf => false;
	}
	private sealed class PatachSE : VowelSummary
	{
		public PatachSE() : base("Patach", 2) { }
		public override int UniInt => 1463;
		public override string UnicodeName => "patach";
		public override string Hebrew => "ַ";
		public override string UnicodeNameHtml => "pat<b>ah</b>ch";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1463</span>";
		public override string Sound => "bog";
		public override bool IsWithChataf => false;
	}
	private sealed class SegalSE : VowelSummary
	{
		public SegalSE() : base("Segal", 3) { }
		public override int UniInt => 1462;
		public override string UnicodeName => "segal";
		public override string Hebrew => "ֶ";
		public override string UnicodeNameHtml => "seg<b>e</b>l";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1462</span>";
		public override string Sound => "beg";
		public override bool IsWithChataf => false;
	}
	private sealed class ChatafKamatzSE : VowelSummary
	{
		public ChatafKamatzSE() : base("ChatafKamatz", 4) { }
		public override int UniInt => 1459;
		public override string UnicodeName => "chataf kamatz";
		public override string Hebrew => "ֳ";
		public override string UnicodeNameHtml => "chataf<br />kam<b>ah</b>tz";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1459</span>";
		public override string Sound => "bog";
		public override bool IsWithChataf => true;
	}
	private sealed class ChatafPatachSE : VowelSummary
	{
		public ChatafPatachSE() : base("ChatafPatach", 5) { }
		public override int UniInt => 1458;
		public override string UnicodeName => "chataf patach";
		public override string Hebrew => "ֲ";
		public override string UnicodeNameHtml => "chataf<br />pat<b>ah</b>ch";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1458</span>";
		public override string Sound => "bog";
		public override bool IsWithChataf => true;
	}
	private sealed class ChatafSegalSE : VowelSummary
	{
		public ChatafSegalSE() : base("ChatafSegal", 6) { }
		public override int UniInt => 1457;
		public override string UnicodeName => "chataf segal";
		public override string Hebrew => "ֱ";
		public override string UnicodeNameHtml => "chataf<br />seg<b>e</b>l ";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1457</span>";
		public override string Sound => "beg";
		public override bool IsWithChataf => true;
	}
	private sealed class TsereSE : VowelSummary
	{
		public TsereSE() : base("Tsere", 7) { }
		public override int UniInt => 1461;
		public override string UnicodeName => "tsere";
		public override string Hebrew => "ֵ";
		public override string UnicodeNameHtml => "tser<b>&#0257</b>";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1461</span>";
		public override string Sound => "bay";
		public override bool IsWithChataf => false;
	}
	private sealed class ChirikSE : VowelSummary
	{
		public ChirikSE() : base("Chirik", 8) { }
		public override int UniInt => 1460;
		public override string UnicodeName => "chirik";
		public override string Hebrew => "ִ";
		public override string UnicodeNameHtml => "chir<b>&#0275</b>k";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1460</span>";
		public override string Sound => "bee";
		public override bool IsWithChataf => false;
	}
	private sealed class ShvaSE : VowelSummary
	{
		public ShvaSE() : base("Shva", 9) { }
		public override int UniInt => 1456;
		public override string UnicodeName => "shva";
		public override string Hebrew => "ְ";
		public override string UnicodeNameHtml => "shva<b>'</b>";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1456</span>";
		public override string Sound => "b'reshit";
		public override bool IsWithChataf => false;
	}
	private sealed class KubutzSE : VowelSummary
	{
		public KubutzSE() : base("Kubutz", 10) { }
		public override int UniInt => 1467;
		public override string UnicodeName => "kubutz";
		public override string Hebrew => "ֻ";
		public override string UnicodeNameHtml => "kub<b>u</b>tz";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489</span><span class='hebrewchart vp'>&#1467</span>";
		public override string Sound => "boot";
		public override bool IsWithChataf => false;
	}
	private sealed class ShurukSE : VowelSummary
	{
		public ShurukSE() : base("Shuruk", 11) { }
		public override int UniInt => 1468;
		public override string UnicodeName => "shuruk";
		public override string Hebrew => "ּ";
		public override string UnicodeNameHtml => "shur<b>u</b>k";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489&#1493</span><span class='hebrewchart vp'>&#1468</span>";
		public override string Sound => "boot";
		public override bool IsWithChataf => false;
	}
	private sealed class CholemSE : VowelSummary
	{
		public CholemSE() : base("Cholem", 12) { }
		public override int UniInt => 1465;
		public override string UnicodeName => "cholem";
		public override string Hebrew => "ֹ";
		public override string UnicodeNameHtml => "ch<b>&#0333</b>lem";
		public override string ExampleHtml => "<span class='hebrewchart gray'>&#1489&#1493</span><span class='hebrewchart vp'>&#1465</span>";
		public override string Sound => "boat";
		public override bool IsWithChataf => false;
	}
	#endregion

}


/*
	DECLARE @RC int
	EXEC @RC = dbo.stpVowelSummaryCodeGen 
*/