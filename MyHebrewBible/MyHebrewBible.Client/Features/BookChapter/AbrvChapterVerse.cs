namespace MyHebrewBible.Client.Features.BookChapter;

public record AbrvChapterVerse(string Abrv, int Chapter, int Verse, int ScriptureId)
{
	public static AbrvChapterVerse Default => new AbrvChapterVerse(Enums.BibleBook.Genesis.Name, 1, 1, 1);
}

// Ignore Spelling: Abrv 