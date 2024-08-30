using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

public record VerseRange(BibleBook BibleBook, string ChapterVerse, long	BegId, long EndId);

