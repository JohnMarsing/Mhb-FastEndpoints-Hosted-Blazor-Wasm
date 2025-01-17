namespace MyHebrewBible.Endpoints;

public class Parasha
{
	public long ID { get; set; } // Scripture.ID
	public long SectionId { get; set; }
	public long RowCnt { get; set; }
	public string? VerseRange { get; set; }
	//Scripture columns below
	public string? BCV { get; set; }
	public long BookID { get; set; }
	public long Chapter { get; set; }
	public long Verse { get; set; }
	public string? VerseOffset { get; set; }
	public string? KJV { get; set; }
	public string? DescH { get; set; }
	public string? DescD { get; set; }
}
