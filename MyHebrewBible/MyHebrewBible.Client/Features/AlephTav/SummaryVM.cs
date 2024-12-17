namespace MyHebrewBible.Client.Features.AlephTav;

/*
### Used by

#### `Sections.razor`
- Populates `private List<SummaryVM>? SummaryVerseList` inside `OnParametersSetAsync`
- This is done in by doing a summary LINQ of `DetailWordList` right after it is populated
- `DetailWordList` is `ICollection<AlephTavHebrewVerse>` which is populated by `Api.GetAlephTavHebrewVersesAsync`

#### `Header.razor`
- `[Parameter, EditorRequired] public SummaryVM? SummaryVM { get; set; }`

*/
public record SummaryVM(long ScriptureId, string BCV, long Chapter, long Verse, long HasTwo, int RowCnt);

