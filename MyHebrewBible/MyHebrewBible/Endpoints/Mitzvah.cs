namespace MyHebrewBible.Endpoints;

public class Mitzvah
{
	public long Id { get; set; }
	public long Detail { get; set; }
	public long BegId { get; set; }
	public long EndId { get; set; }
	public string? Verse { get; set; }
  public string? Descr { get; set; }
  public long BookId { get; set; }
	public string? BookAbrv { get; set; }
}

// Ignore Spelling: Mitzvah, Descr, Abrv