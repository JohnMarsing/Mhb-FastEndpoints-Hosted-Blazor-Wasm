namespace MyHebrewBible.Client.Features.Parasha;

// Copied from - MyHebrewBible.Client\Features\AlephTav\SummaryVM.cs
public record SummaryVM(long SectionId, long RowCnt, string? VerseRange, long VerseCount);
