namespace MyHebrewBible.Client.Features.AlephTav;

public class DetailsVM
{
	public AlephTavScripture? AlephTavScripture { get; set; }
	public List<WordHtmlMinimal>? Words { get; set; }
	public IEnumerable<AlephTavSummaryOLD>? AlephTavSummaryBooks { get; set; }
}
