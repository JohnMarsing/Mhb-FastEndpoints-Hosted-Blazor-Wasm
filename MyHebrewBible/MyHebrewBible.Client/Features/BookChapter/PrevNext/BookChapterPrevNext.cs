namespace MyHebrewBible.Client.Features.BookChapter.PrevNext;

public class BookChapterPrevNext
{

	public BookAndChapter? BookAndChapter { get; set; }
	public string Icon { get; set; }
	public string? ButtonText { get; set; }

	public BookChapterPrevNext(BookAndChapter? bookAndChapter, string icon, string? buttonText)  
	{
		BookAndChapter = bookAndChapter;
		Icon = icon;
		ButtonText = buttonText;
	}

	public bool ThereIsNone
	{
		get
		{
			if (BookAndChapter is null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	public override string ToString()
	{
		return $"BookAndChapter: {BookAndChapter}; Icon: {Icon}; ButtonText: {ButtonText ?? "NULL"}; ThereIsNone: {ThereIsNone} ";
	}

}