namespace MyHebrewBible.Client.Features.AlephTav;

public class WordHtmlMinimal
{
	public int ScriptureID { get; set; }
	public byte WordCount { get; set; }
	public int? Strongs { get; set; }
	public string? Hebrew { get; set; }
	public string? KjvWord { get; set; }
	public string? Transliteration { get; set; }
}
