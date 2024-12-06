using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.CommonVerses.Enums;

public record VerseRange(BibleBook BibleBook, string ChapterVerse, int Chapter, int BegVerse, int EndVerse);
