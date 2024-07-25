namespace MyHebrewBible.Endpoints;

public class WordPartKjv
{
	public long ScriptureID { get; set; }
	public long WordCount { get; set; }
	public long? Strongs { get; set; }
	public string? Word { get; set; }
}
