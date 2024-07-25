namespace MyHebrewBible.Endpoints;

public class BookChapter
{
	public long ID { get; set; }
	public string? BCV { get; set; }
	public long Verse { get; set; }
	public string? VerseOffset { get; set; }
	public string? KJV { get; set; }
	public string? DescH { get; set; }
	public string? DescD { get; set; }
}
