using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.BookChapter;


public record BookAndChapter(BibleBook? BibleBook, int Chapter);

/*
- the above code is a simplified version of the code below, 
   the parameters will use `init` and will be immutable.
- A ToString is built in;

public record BookAndChapter
{
	public BibleBook? BibleBook { get; init; }
	public int Chapter { get; init; }
}

## newing 
```
	protected BookAndChapter? bookAndChapter;
  var bookAndChapter = new BookAndChapter(CurrentBibleBook, chapter);
	...
```

 var bookAndChapter = new BookAndChapter
	 {
		 BibleBook = CurrentBibleBook,
		 Chapter = chapter
	 };

## copying to another record using `with` 
var bookAndChapter2 = bookAndChapter with
{
	 Chapter = 1200.00m
};

## ToString
```html
@if (bookAndChapter is not null) { <p>@($"bookAndChapter: {bookAndChapter.ToString()}")</p> } 


### Reference
- https://medium.com/codex/getting-started-with-c-records-7dec761a87b5

*/