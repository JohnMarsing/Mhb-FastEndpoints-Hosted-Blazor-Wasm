// Ignore Spelling: Toolbar

namespace MyHebrewBible.Client.Features.BookChapter;

/*
Used by
	private sealed class BookChapterSE : Nav	{
		public override string Index => $"/{BookChapterConstants.BaseUrl}/{BookChapterConstants.DefaultRouteParameter}";  
		                                 "/BookChapter/0/0/0/default" used to be this
 */
public static class Constants
{
	public const string BaseUrl = "BookChapter";
	public const string DefaultAbrv = "default";
	//                                              gen /c/v/SID
	public const string DefaultRouteParameter = "default/0/0/0";  // default/0/0 The abrv is case sensitive Gen/1/1

	public const string ToolbarNumericPad = "numeric-pad";
	public const string ToolbarDynamicButtons = "dynamic-buttons";
}
