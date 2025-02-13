namespace MyHebrewBible.Client.Features.Parasha.TableOfContents;

public record TocRecord(long SectionId, long GroupCount, long ScriptureID_Beg, string? VerseRange, long VerseCount);

// Ignore Spelling: Toc