namespace MyHebrewBible.Endpoints.CommonDtos;

public record WordPart
{
	public int Id { get; init; }                   // AlephTavVerseWordPart!Id int
	public string? BCV { get; init; }
	public int BookID { get; init; }              // Scripture!BookID is bigint
	public int Chapter { get; init; }             // Scripture!Chapter is bigint
	public int Verse { get; init; }               // Scripture!Verse is bigint
	public int ScriptureID { get; init; }          // WordPart!ScriptureID int
	public int WordCount { get; init; }
	public int SegmentCount { get; init; }
	public int WordEnum { get; init; }             // WordPart!WordEnum int
	public string? Hebrew1 { get; init; }
	public string? Hebrew2 { get; init; }
	public string? Hebrew3 { get; init; }
	public string? KjvWord { get; init; }
	public int Strongs { get; init; }              // WordPart!Strongs int
	public string? Transliteration { get; init; }
	public int? FinalEnum { get; init; }           // WordPart!FinalEnum int
}
// Ignore Spelling: BCV, Strongs, bigint