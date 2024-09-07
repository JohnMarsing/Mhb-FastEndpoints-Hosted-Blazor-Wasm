using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Components;

public record BookChapterVerseVM(BibleBook? BibleBook, int Chapter, int Verse);