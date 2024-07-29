using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Helpers;

namespace MyHebrewBible.Client.Features.BookChapter.PrevNext;

public class PrevNextButtonVM
{
	public BookChapterPrevNext? PrevBibleBook { get; set; }
	public BookChapterPrevNext? NextBibleBook { get; set; }

	public PrevNextButtonVM(BookAndChapter bookAndChapter)
	{
		PrevBibleBook = SetPrevBookChapter(bookAndChapter);
		NextBibleBook = SetNextBookChapter(bookAndChapter);
	}

	private BookChapterPrevNext SetPrevBookChapter(BookAndChapter bookAndChapter)
	{
		BookChapterPrevNext bc_pn;

		if (bookAndChapter.BibleBook!.Value == BibleBook.Genesis.Value & bookAndChapter.Chapter == 1)
		{
			bc_pn = new(null, "", null); 
			return bc_pn;
		}

		if (bookAndChapter.Chapter != 1)
		{
			var bookAndChapterPrev = bookAndChapter with
			{
				Chapter = bookAndChapter.Chapter - 1
			};

			bc_pn = new(bookAndChapterPrev, "fas fa-arrow-left", bookAndChapterPrev.Chapter.ToString());

		}
		else
		{
			var bookAndChapterPrev = bookAndChapter with
			{
				BibleBook = BibleBook.FromValue(bookAndChapter.BibleBook.Value - 1),
				Chapter = bookAndChapter.Chapter - 1
			};
			bc_pn = new(bookAndChapterPrev, "fas fa-arrow-left", bookAndChapterPrev.Chapter.ToString());
		}
		return bc_pn;
	}

	private BookChapterPrevNext SetNextBookChapter(BookAndChapter bookAndChapter)
	{
		BookChapterPrevNext bc_pn;

		if (bookAndChapter.BibleBook!.Value == VerseFacts.LastBookInNT &
				bookAndChapter.Chapter == VerseFacts.LastChapterInNt)
		{
			bc_pn = new(null, "", null);
		}

		if (bookAndChapter.Chapter != bookAndChapter.BibleBook!.LastChapter)
		{
			var bookAndChapterPrev = bookAndChapter with
			{
				Chapter = bookAndChapter.Chapter + 1
			};

			bc_pn = new(bookAndChapterPrev, "fas fa-arrow-right", bookAndChapterPrev.Chapter.ToString());

		}
		else
		{
			var bookAndChapterPrev = bookAndChapter with
			{
				BibleBook = BibleBook.FromValue(bookAndChapter.BibleBook.Value + 1),
				Chapter = 1
			};
			bc_pn = new(bookAndChapterPrev, "fas fa-arrow-right", bookAndChapterPrev.Chapter.ToString());
		}

		return bc_pn;

	}

}
