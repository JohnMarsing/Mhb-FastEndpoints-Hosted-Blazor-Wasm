namespace MyHebrewBible.Client.Features.Haggadah.Enums;

using Ardalis.SmartEnum;

public abstract class MenuItemLanguage : SmartEnum<MenuItemLanguage>
{
	#region Id's
	private static class Id
	{
		internal const int English = 1;
		internal const int Spanish = 2;
		internal const int Both = 3;

		internal const int ShowToC = 4;

	}
	#endregion

	#region Declared Public Instances
	public static readonly MenuItemLanguage English = new EnglishSE();
	public static readonly MenuItemLanguage Spanish = new SpanishSE();
	public static readonly MenuItemLanguage Both = new BothSE();
	public static readonly MenuItemLanguage ShowToC = new ShowToCSE();

	#endregion

	private MenuItemLanguage(string name, int value) : base(name, value) { }

	#region Extra Fields
	public abstract int HeaderId { get; }
	public abstract string Description { get; }
	public abstract string Title { get; }
	#endregion

	#region Private Instantiation
	private sealed class EnglishSE : MenuItemLanguage
	{
		public EnglishSE() : base(nameof(English), Id.English) { }
		public override int HeaderId => MenuHeaders.LanguageChoice.Value;
		public override string Title => "English";
		public override string Description => "Display content in English only.";
	}

	private sealed class SpanishSE : MenuItemLanguage
	{
		public SpanishSE() : base(nameof(Spanish), Id.Spanish) { }
		public override int HeaderId => MenuHeaders.LanguageChoice.Value;
		public override string Title => "Español";
		public override string Description => "Display content in Español only.";
	}

	private sealed class BothSE : MenuItemLanguage
	{
		public BothSE() : base(nameof(Both), Id.Both) { }
		public override int HeaderId => MenuHeaders.LanguageChoice.Value;
		public override string Title => "Eng + Esp";
		public override string Description => "Display content in both English and Español.";
	}

	private sealed class ShowToCSE : MenuItemLanguage
	{
		public ShowToCSE() : base(nameof(ShowToC), Id.ShowToC) { }
		public override int HeaderId => MenuHeaders.ShowHaggadahOutlineModal;
		public override string Title => "Table of Content";
		public override string Description => "Show T o C";
	}

	#endregion
}

/* public enum MenuItems {  English = 1, Spanish = 2,	Both = 3 } */
