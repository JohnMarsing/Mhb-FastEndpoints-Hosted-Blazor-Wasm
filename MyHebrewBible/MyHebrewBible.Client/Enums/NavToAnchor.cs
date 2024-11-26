using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Enums;

public abstract class NavToAnchor : SmartEnum<NavToAnchor>
{
	#region Id's
	private static class Id
	{
		internal const int HebrewKeyboard = 1;
	}
	#endregion

	private NavToAnchor(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Url { get; }
	public abstract string Title { get; }
	public abstract string Description { get; }
	public abstract string Icon { get; }

	#endregion

	#region  Declared Public Instances
	public static readonly NavToAnchor HebrewKeyboard = new HebrewKeyboardSE();
	#endregion

	#region Private Instantiation
	private sealed class HebrewKeyboardSE : NavToAnchor
	{
		public HebrewKeyboardSE() : base($"{nameof(Id.HebrewKeyboard)}", Id.HebrewKeyboard) { }
		public override string Url => "https://www.lexilogos.com/keyboard/hebrew.htm";
		public override string Title => "Hebrew Keyboard";
		public override string Description => "Online Hebrew Keyboard";
		public override string Icon => "far fa-keyboard"; 
	}
	#endregion
}
