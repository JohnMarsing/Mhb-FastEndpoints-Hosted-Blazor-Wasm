using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Components.BookChapterToolbar;

public class BookChapterPrevNext
{
	public string Icon { get; set; }
	public BibleBook? BibleBook { get; set; }
	public string? ButtonText { get; set; }
	public int Chapter { get; set; }
	public bool ThereIsNone { get { return BibleBook == null ? true : false; } }

	public BookChapterPrevNext(string icon)
	{
		Icon = icon;
	}
}