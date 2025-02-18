namespace MyHebrewBible.Client.Components.Report;

public class ReportModel
{
	public int ID { get; init; }
	public string? BCV { get; init; }
	public int Verse { get; init; }
	public string? VerseOffset { get; init; }
	public string? KJV { get; init; }
	public string? DescH { get; init; }
	public string? DescD { get; init; }
	public int BookID { get; init; }
	public int Chapter { get; init; }
	public List<WordPart>? WordPartList { get; init; }
}

public record WordPart
{
	public int Id { get; init; }                  
	public string? BCV { get; init; }
	public int BookID { get; init; }             
	public int Chapter { get; init; }            
	public int Verse { get; init; }              
	public int ScriptureID { get; init; }         
	public int WordCount { get; init; }
	public int SegmentCount { get; init; }
	public int WordEnum { get; init; }            
	public string? Hebrew1 { get; init; }
	public string? Hebrew2 { get; init; }
	public string? Hebrew3 { get; init; }
	public string? KjvWord { get; init; }
	public int Strongs { get; init; }             
	public string? Transliteration { get; init; }
	public int? FinalEnum { get; init; }          
}

// Ignore Spelling: BCV, Strongs, bigint