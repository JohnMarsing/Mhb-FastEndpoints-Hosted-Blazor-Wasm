namespace MyHebrewBible.Endpoints;

public class WordPart
{
	public long ScriptureID { get; set; }
	public long WordCount { get; set; }
	public long SegmentCount { get; set; }
	public long WordEnum { get; set; }
	public string? Hebrew1 { get; set; }
	public string? Hebrew2 { get; set; }
	public string? Hebrew3 { get; set; }
	public string? KjvWord { get; set; }
	public long Strongs { get; set; }
	public string? Transliteration { get; set; }
	public int? FinalEnum { get; set; }
}

// Ignore Spelling: strongs, 

//ScriptureID, WordCount, SegmentCount, WordEnum, Hebrew1, Hebrew2, Hebrew3, KjvWord, Strongs, Transliteration, FinalEnum