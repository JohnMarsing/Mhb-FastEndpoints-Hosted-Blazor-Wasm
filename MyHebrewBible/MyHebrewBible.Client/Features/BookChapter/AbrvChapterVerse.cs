namespace MyHebrewBible.Client.Features.BookChapter;

using BibleBookEnum = MyHebrewBible.Client.Enums;

/*
- MyHebrewBible.Client\_Imports.razor 
	@using GlobalEnums = MyHebrewBible.Client.Enums 

Why doesn't this work???...
//public static AbrvChapterVerse Default => new AbrvChapterVerse(GlobalEnums.BibleBook.Genesis.Name, 1, 1, 1); 
 
 */


public record AbrvChapterVerse(string Abrv, int Chapter, int Verse, bool VerseIsNotDefault, int ScriptureId)
{
	public static AbrvChapterVerse Default => new AbrvChapterVerse(BibleBookEnum.BibleBook.Genesis.Name, 1, 1, false, 1);
	//                                                                     Enums.BibleBook.Genesis.Name
}

// Ignore Spelling: Abrv 