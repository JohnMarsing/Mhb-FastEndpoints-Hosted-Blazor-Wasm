namespace MyHebrewBible.Client.Features.Parasha.TableOfContents;

public record TocRecord(int SectionId, int GroupCount, int ScriptureID_Beg, string? VerseRange, int VerseCount);

// Ignore Spelling: Toc