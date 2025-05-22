using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.BookChapter.Enums;

public abstract class MenuItem : SmartEnum<MenuItem>
{
	#region Id's
	private static class Id
	{
		internal const int Instructions = 1;
		internal const int UserSettings = 2;
	}
	#endregion

	#region Declared Public Instances
	public static readonly MenuItem Instructions = new InstructionsSE();
	public static readonly MenuItem UserSettings = new UserSettingsSE();
	#endregion

	private MenuItem(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields 
	public abstract string Title { get; }
	public abstract bool IsModal { get; }

	/*
	### IsModal: 
		- ToDo do I need this?
		- Do I need to make a distinction between modal and e.g. Navigate?
		protected List<Dictionary<int, string?>> MenuItems = Enums.MenuItem.List
				.Where(item => item.IsModal) 
				.Select(item => new Dictionary<int, string?> { { item.Value, item.Title } })
				.ToList();
	
	//Properties 
	public string CardHeader => $"<h3 class='{HeaderColor}'<b>{Title}</b></h3>";
	*/

	#endregion

	private sealed class InstructionsSE : MenuItem
	{
		public InstructionsSE() : base(nameof(Instructions), Id.Instructions) { }
		public override string Title => "Instructions";
		public override bool IsModal => true;
	}

	private sealed class UserSettingsSE : MenuItem
	{
		public UserSettingsSE() : base(nameof(UserSettings), Id.UserSettings) { }
		public override string Title => "User Settings";
		public override bool IsModal => true;
	}
}
