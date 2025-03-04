using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public record BookChapterVerse(BibleBook? BibleBook, int Chapter, int Verse);

