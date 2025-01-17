namespace MyHebrewBible.Endpoints;

public class AlephTavWordPartContext
{
	public int Id { get; set; }										// AlephTavVerseWordPart!Id int
	public int ScriptureID { get; set; }					// WordPart!ScriptureID int
	public string? BCV { get; set; }
	public long BookID { get; set; }							// Scripture!BookID is bigint
	public long Chapter { get; set; }							// Scripture!Chapter is bigint
	public long Verse { get; set; }               // Scripture!Verse is bigint
	public int WordCount { get; set; }
	public int SegmentCount { get; set; }
	public int WordEnum { get; set; }							// WordPart!WordEnum int
	public string? Hebrew1 { get; set; }
	public string? Hebrew2 { get; set; }
	public string? Hebrew3 { get; set; }
	public string? KjvWord { get; set; }
	public int Strongs { get; set; }							// WordPart!Strongs int
	public string? Transliteration { get; set; }
	public int? FinalEnum { get; set; }           // WordPart!FinalEnum int
	public long HasTwo { get; set; }							// AlephTavVerse!HasTwo bigint

	//// ToDo: should this be only on the client?
	//public string StrongsH
	//{
	//	get
	//	{
	//		return $"<a href='https://www.blueletterbible.org/lexicon/h{Strongs}/kjv/wlc/0-1/' target='_blank'>H{Strongs}</a> <i class='fas fa-external-link-alt'></i>";
	//	}
	//}

}
// Ignore Spelling: Strongs, bigint