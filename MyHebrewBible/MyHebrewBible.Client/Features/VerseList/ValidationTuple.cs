using MyHebrewBible.Client.Components;

namespace MyHebrewBible.Client.Features.VerseList;

public record ValidationTuple (bool IsValid, string ErrorMessage, BookChapterVerse? BCV);

