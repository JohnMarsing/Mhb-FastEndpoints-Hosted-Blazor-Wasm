namespace MyHebrewBible.Endpoints;

public class AlephTavHebrewVerse
{
	public long ScriptureID { get; set; }
	public string? BCV { get; set; }
	public long Chapter { get; set; }
	public long Verse { get; set; }
	public long WordCount { get; set; }
	public long WordEnum { get; set; }
	public string? Hebrew1 { get; set; }
	public string? Hebrew2 { get; set; }
	public string? Hebrew3 { get; set; }
	public string? KjvWord { get; set; }
	public long Strongs { get; set; }
	public string? Transliteration { get; set; }
	public int? FinalEnum { get; set; }
	public long HasTwo { get; set; }

	// ToDo: should this be only on the client?
	public string StrongsH
	{
		get
		{
			return $"<a href='https://www.blueletterbible.org/lexicon/h{Strongs}/kjv/wlc/0-1/' target='_blank'>H{Strongs}</a> <i class='fas fa-external-link-alt'></i>";
		}
	}

}

// Ignore Spelling: BCV, strongs, Paseq, css

