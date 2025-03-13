using Ardalis.SmartEnum;
using MyHebrewBible.Client.Helpers;

namespace MyHebrewBible.Client.Features.BookChapter.Enums;

public abstract class ButtonsBCV : SmartEnum<ButtonsBCV>
{
	#region Id's
	private static class Id
	{
		internal const int Hundreds = 1;
		internal const int Tens = 2;
		internal const int Ones = 3;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly ButtonsBCV Hundreds = new HundredsSE();
	public static readonly ButtonsBCV Tens = new TensSE();
	public static readonly ButtonsBCV Ones = new OnesSE();
	#endregion

	private ButtonsBCV(string name, int value) : base(name, value) { } // Constructor
																																		 
	#region Extra Fields
	public abstract string ButtonColor { get; }

	//Properties
	#endregion

	#region Private Instantiation

	private sealed class HundredsSE : ButtonsBCV
	{
		public HundredsSE() : base($"{nameof(Id.Hundreds)}", Id.Hundreds) { }
		public override string ButtonColor => BtnOutlineColors.Info;  // .Dark;	
	}

	private sealed class TensSE : ButtonsBCV
	{
		public TensSE() : base($"{nameof(Id.Tens)}", Id.Tens) { }
		public override string ButtonColor => BtnOutlineColors.Info; // .Dark;	
	}

	private sealed class OnesSE : ButtonsBCV
	{
		public OnesSE() : base($"{nameof(Id.Ones)}", Id.Ones) { }
		public override string ButtonColor => BtnOutlineColors.Info; // .Dark;	
	}
	#endregion

}

// Ignore Spelling: fs

public class Helper
{
	//<button class="btn font-monospace @fontSize">&nbsp;</button>

	public static string GetButtonClassEmpty()
	{
		return $"btn {fontType} {fontSize}"; // btn 
	}

	public static string GetDefaultButtonClass()
	{
		return $"{fontType} {fontSize}";
	}

	public static string GetDisabledColor()
	{
		return BtnOutlineColors.Secondary;
	}


	const string fontType = "font-monospace"; 
	const string fontSize = "fs-4";
}