namespace MyHebrewBible.Client.State.VerseList;

public record DetailRecord(int BibleBookId, int Chapter, int BegVerse, int EndVerse, string? NotesMD);