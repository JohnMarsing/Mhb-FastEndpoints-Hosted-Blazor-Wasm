namespace MyHebrewBible.Client.Features.AlephTav;

public record SummaryVM(long ScriptureId, string BCV, long Chapter, long Verse, long HasTwo, int RowCnt);
