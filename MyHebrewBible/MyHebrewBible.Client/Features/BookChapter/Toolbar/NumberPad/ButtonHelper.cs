using MyHebrewBible.Client.Helpers;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class ButtonHelper
{

	public static string GetButtonClassEmpty()
	{
		return $"btn {BtnOutlineColors.Secondary} disabled {fontType} {fontSize}";
	}

	public static string GetButtonClassEmptyNoColor()
	{
		return $"btn {fontType} {fontSize}";
	}

	public static string GetDefaultButtonClass(bool small = false)
	{
		return $"{fontType} {(small ? fontSizeSmall : fontSize)}";
	}


	public static string GetDisabledColor()
	{
		return BtnOutlineColors.Secondary;
	}

	public static string GetButtonColor()
	{
		return BtnOutlineColors.Info;
	}

	const string fontType = "font-monospace";
	const string fontSize = "fs-4";
	const string fontSizeSmall = "fs-5";
}