namespace MyHebrewBible.Client.Features.AlephTav;

public class Constants { }

public static class PartialViews
{
	public const string WordsMinimal = "_WordsMinimal";
	public const string AlephTavPopover = "_AlephTavPopover";
	public const string Details = "_Details";
}

public static class VDD // Constants for ViewDataDictionary
{
	public const string ScriptureID = "ScriptureId";
	public const string IsXs = "IsXs";
}

//	Hack, see Task 75:
public static class UrlAction
{
	public const string Controller = "AlephTav";
	public const string Index = "Index";
}