namespace MyHebrewBible.Client.State.BookChapter;

public record BibleBookIdAndChapter(int BibleBookId, int Chapter, int Verse = 1, string? Slug = "slugo");
