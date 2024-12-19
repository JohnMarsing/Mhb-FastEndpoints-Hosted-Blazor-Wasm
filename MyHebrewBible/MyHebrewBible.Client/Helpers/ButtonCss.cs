namespace MyHebrewBible.Client.Helpers;

public enum ButtonSize
{
	Xs,
	Sm,
	Lg
}


//ToDo: not being used
public class ButtonCss
{
	public static string Size(ButtonSize buttonSize)
	{
		Dictionary<ButtonSize, string> buttonSizeClassMap = new Dictionary<ButtonSize, string>
				{
						{ ButtonSize.Xs, " btn-xs" },
						{ ButtonSize.Sm, " btn-sm" },
						{ ButtonSize.Lg, " btn-lg" }
				};

		if (buttonSizeClassMap.TryGetValue(buttonSize, out string? s))
		{
			return s;  //$"<button class=\"btn {sizeClass}\">Button</button>";
		}
		else
		{
			return string.Empty;
		}
	}

	public static string IconSize(ButtonSize buttonSize)
	{
		Dictionary<ButtonSize, string> iconSizeClassMap = new Dictionary<ButtonSize, string>
				{
						{ ButtonSize.Xs, "" },
						{ ButtonSize.Sm, " fa-fw fa-2x" },
						{ ButtonSize.Lg, " fa-fw fa-3x" }
				};

		if (iconSizeClassMap.TryGetValue(buttonSize, out string? s))
		{
			return s; 
		}
		else
		{
			return string.Empty;
		}
	}

}


// Ignore Spelling: Entra Css