namespace MyHebrewBible.Endpoints;

public class AlephTav
{
	public long ScriptureID { get; set; }
	public long Detail { get; set; }
	public string? BCV { get; set; }
	public long BookID { get; set; }
	public long Chapter { get; set; }
	public long WordCount { get; set; }
	//public long SegmentCount { get; set; }
	public long WordEnum { get; set; }
	public string? Hebrew1 { get; set; }
	public string? Hebrew2 { get; set; }
	public string? Hebrew3 { get; set; }

	public string Hebrew
	{
		get
		{
			if (WordEnum == 1) // SimpleSingle
			{
				return $"<span class='hebrew30'>{Hebrew1}</span>";
			}
			else if (WordEnum == 2) // NRL_Prefix
			{
				return $"<span class='hebrew30 nrl'>{Hebrew1}</span><span class='hebrew30'>{Hebrew2}</span>";
			}
			else if (WordEnum == 3) // NRL_Suffix
			{
				return $"<span class='hebrew30'>{Hebrew1}</span><span class='hebrew30 nrl'>{Hebrew2}</span>";
			}
			else if (WordEnum == 4) // NRL_Prefix and NRL_Suffix
			{
				return $"<span class='hebrew30 nrl'>{Hebrew1}</span><span class='hebrew30'>{Hebrew2}</span><span class='hebrew30 nrl'>{Hebrew3}</span>";
			}
			else if (WordEnum == 5) // SAT
			{
				return $"<span class='hebrew30 at-red'>{Hebrew1}</span>";
			}
			else  // SAT and Paseq
			{
				return $"<span class='hebrew30 at-red'>{Hebrew1}</span> <span class='last-seg-type-paseq'>׀</span>";
			}
		}
	}
}
