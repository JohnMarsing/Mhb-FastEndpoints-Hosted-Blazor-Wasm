using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Haggadah.Enums;

public abstract class MenuItemModal : SmartEnum<MenuItemModal>
{
	#region Id's
	private static class Id
	{
		internal const int Instructions = 1;
		internal const int TenPlagues = 2;
		internal const int Easter = 3;
		internal const int BibleVerses = 4;
		internal const int Language = 5;
	}
	#endregion

	#region Declared Public Instances
	public static readonly MenuItemModal Instructions = new InstructionsSE();
	public static readonly MenuItemModal TenPlagues = new TenPlaguesPlaguesSE();
	public static readonly MenuItemModal Easter = new EasterSE();
	public static readonly MenuItemModal BibleVerses = new BibleVersesSE();
	public static readonly MenuItemModal Language = new LanguageSE();
	#endregion

	private MenuItemModal(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields 
	public abstract string Title { get; }
	public abstract string Category { get; }
	public abstract int CategorySort { get; }

	#endregion

	private sealed class InstructionsSE : MenuItemModal
	{
		public InstructionsSE() : base(nameof(Instructions), Id.Instructions) { }
		public override string Title => "Instructions";
		public override string Category => "Instructions";
		public override int CategorySort => 1;
	}


	private sealed class TenPlaguesPlaguesSE : MenuItemModal
	{
		public TenPlaguesPlaguesSE() : base(nameof(TenPlagues), Id.TenPlagues) { }
		public override string Title => "10 Plagues";
		public override string Category => "Appendix";
		public override int CategorySort => 2;
	}

	private sealed class EasterSE : MenuItemModal
	{
		public EasterSE() : base(nameof(Easter), Id.Easter) { }
		public override string Title => "Easter";
		public override string Category => "Appendix";
		public override int CategorySort => 2;
	}

	private sealed class BibleVersesSE : MenuItemModal
	{
		public BibleVersesSE() : base(nameof(BibleVerses), Id.BibleVerses) { }
		public override string Title => "Bible Verses";
		public override string Category => "Appendix";
		public override int CategorySort => 2;
	}

	private sealed class LanguageSE : MenuItemModal
	{
		public LanguageSE() : base(nameof(Language), Id.Language) { }
		public override string Title => "Language Setting";
		public override string Category => "User Settings";
		public override int CategorySort => 3;
	}
	
}
