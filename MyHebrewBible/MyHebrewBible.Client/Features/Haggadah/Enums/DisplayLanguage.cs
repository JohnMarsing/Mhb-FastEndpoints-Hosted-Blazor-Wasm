namespace MyHebrewBible.Client.Features.Haggadah.Enums;

using Ardalis.SmartEnum;


public abstract class DisplayLanguage : SmartEnum<DisplayLanguage>
{
	#region Id's
	private static class Id
	{
		internal const int English = 1;
		internal const int Spanish = 2;
		internal const int Both = 3;
	}
	#endregion

	#region Declared Public Instances
	public static readonly DisplayLanguage English = new EnglishSE();
	public static readonly DisplayLanguage Spanish = new SpanishSE();
	public static readonly DisplayLanguage Both = new BothSE();
	#endregion

	private DisplayLanguage(string name, int value) : base(name, value) { }

	#region Extra Fields
	public abstract string Description { get; }
	public abstract string Title { get; }
	#endregion

	private sealed class EnglishSE : DisplayLanguage
	{
		public EnglishSE() : base(nameof(English), Id.English) { }
		public override string Title => "English";
		public override string Description => "Display content in English only.";
	}

	private sealed class SpanishSE : DisplayLanguage
	{
		public SpanishSE() : base(nameof(Spanish), Id.Spanish) { }
		public override string Title => "Español";
		public override string Description => "Display content in Español only.";
	}

	private sealed class BothSE : DisplayLanguage
	{
		public BothSE() : base(nameof(Both), Id.Both) { }
		public override string Title => "Eng + Esp";
		public override string Description => "Display content in both English and Español.";
	}
}

/* public enum DisplayLanguage {  English = 1, Spanish = 2,	Both = 3 } */
