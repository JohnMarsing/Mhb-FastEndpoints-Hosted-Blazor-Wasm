namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public record PlaceValueRec(int? Hundreds, int? Tens, int Ones, bool IsWhole)
{
	// ToDo: give a better example of where this is being used
	//	return (AbrvChapterVerse.Default, new BookAndChapter(GlobalEnums.BibleBook.Genesis, chapter));
	public static PlaceValueRec Default => new(null, null, -1, false);
}

/*
### Nullabillity 
- **Hundreds** is null if it's not possible to hold a value (e.g. only not null if Chapter == Psalms)
- **Tens** is null if `BibleBook.LastChapter < 10` (e.g. Ruth has only 4) or `LastVerseCount` is < 10)
- **Ones** can never be null

### Values

#### Negative 1
`-1` indicates value [0..9] has not yet been made, not applicable if it's null

#### 0
`0` (for the most part) `0` has not special meaning because it's a value like 1-9 are.
The interesting question about the value `0` occurs when taking about the One's place.
From a UI perspective there are conditions when you don't want the user the option to select 0
See helper method `OnesPlaceZeroButtonIsDisabled` for the details

### Initialization


Ignore Spelling: Nullabillity 
 */