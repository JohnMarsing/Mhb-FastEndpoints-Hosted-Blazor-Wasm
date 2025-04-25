using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.HealthChecks.FavoriteVerses.Enums;

public record VerseRecord(BibleBook BibleBook, int Chapter, int BegVerse, int EndVerse);

