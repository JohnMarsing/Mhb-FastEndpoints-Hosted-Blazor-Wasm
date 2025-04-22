using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.Haggadah.Enums;

public record VerseRecord(BibleBook BibleBook, int Chapter, int BegId, int EndId);