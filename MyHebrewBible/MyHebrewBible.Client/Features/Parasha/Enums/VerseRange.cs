using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

// See 057-Strongs-Frequency-Analysis\Notes.md re.  `VerseRange.cs` ! `GetSatVerseList()`
public record VerseRange(BibleBook BibleBook, string ChapterVerse, long	BegId, long EndId);

