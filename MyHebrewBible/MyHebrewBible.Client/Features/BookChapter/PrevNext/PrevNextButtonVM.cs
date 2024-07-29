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
		if (bookAndChapter.BibleBook!.Value == BibleBook.Genesis.Value & 
				bookAndChapter.Chapter == 1)
		{
			return new BookChapterPrevNext(null, "", null); // bookAndChapter is Gen 1, no where to go Prev
		}

		if (bookAndChapter.Chapter != 1)
		{
			var bookAndChapterPrevNotFirstChapter = bookAndChapter with
			{
				Chapter = bookAndChapter.Chapter - 1
			};

			return new BookChapterPrevNext(bookAndChapterPrevNotFirstChapter, "fas fa-arrow-left", bookAndChapterPrevNotFirstChapter.Chapter.ToString());
		}

		BibleBook bibleBookPrev = BibleBook.FromValue((bookAndChapter.BibleBook.Value - 1));  
		BookAndChapter bookAndChapterPrev = new BookAndChapter(bibleBookPrev, bibleBookPrev.LastChapter);
		string buttonText = $"{bookAndChapterPrev.Chapter.ToString()} {bookAndChapterPrev.BibleBook!.Abrv}";
		return new BookChapterPrevNext(bookAndChapterPrev, "fas fa-arrow-left", buttonText);
	}

	private BookChapterPrevNext SetNextBookChapter(BookAndChapter bookAndChapter)
	{
		if (bookAndChapter.BibleBook!.Value == VerseFacts.LastBookInNT &
				bookAndChapter.Chapter == VerseFacts.LastChapterInNt)
		{
			return new BookChapterPrevNext(null, "", null); // bookAndChapter is Rev 22 no where to go Next
		}

		if (bookAndChapter.Chapter != bookAndChapter.BibleBook!.LastChapter)
		{
			var bookAndChapterNextNotLastChapter = bookAndChapter with
			{
				Chapter = bookAndChapter.Chapter + 1
			};
			return new BookChapterPrevNext(bookAndChapterNextNotLastChapter, "fas fa-arrow-right", bookAndChapterNextNotLastChapter.Chapter.ToString());
		}

		var bookAndChapterNextIsLastChapter = bookAndChapter with
		{
			BibleBook = BibleBook.FromValue(bookAndChapter.BibleBook.Value + 1),
			Chapter = bookAndChapter.BibleBook.LastChapter
		};
		string buttonText = $"{bookAndChapterNextIsLastChapter.Chapter.ToString()} {bookAndChapterNextIsLastChapter.BibleBook.Abrv}";
		return new BookChapterPrevNext(bookAndChapterNextIsLastChapter, "fas fa-arrow-right", buttonText);
	}

}
