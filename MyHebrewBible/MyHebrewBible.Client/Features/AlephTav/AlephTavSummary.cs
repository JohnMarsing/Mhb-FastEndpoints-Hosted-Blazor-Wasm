namespace MyHebrewBible.Client.Features.AlephTav;

public class AlephTavSummary
{
	public int Id { get; set; }
	public string? Abrv { get; set; }
	public int RowCntVerses { get; set; }
	public int RowCntAlephTavs { get; set; }
	public int BookGroupId { get; set; }
	public string? BookGroupDescription { get; set; }
}

public class AlephTavSummaryFactory
{

	public static IQueryable<AlephTavSummary> GetAlephTavSummaryBooks()
	{
		return new List<AlephTavSummary>
			{
new AlephTavSummary {Id = 1, Abrv = "Gen", RowCntVerses = 44, RowCntAlephTavs = 47, BookGroupId = 1, BookGroupDescription = "Torah"},
new AlephTavSummary {Id = 2, Abrv = "Exo", RowCntVerses = 61, RowCntAlephTavs = 63, BookGroupId = 1, BookGroupDescription = "Torah"},
new AlephTavSummary {Id = 3, Abrv = "Lev", RowCntVerses = 30, RowCntAlephTavs = 31, BookGroupId = 1, BookGroupDescription = "Torah"},
new AlephTavSummary {Id = 4, Abrv = "Num", RowCntVerses = 42, RowCntAlephTavs = 43, BookGroupId = 1, BookGroupDescription = "Torah"},
new AlephTavSummary {Id = 5, Abrv = "Deu", RowCntVerses = 38, RowCntAlephTavs = 39, BookGroupId = 1, BookGroupDescription = "Torah"},
new AlephTavSummary {Id = 6, Abrv = "Jos", RowCntVerses = 21, RowCntAlephTavs = 21, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 7, Abrv = "Jdg", RowCntVerses = 19, RowCntAlephTavs = 20, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 8, Abrv = "Rut", RowCntVerses = 7, RowCntAlephTavs = 9, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 9, Abrv = "1Sa", RowCntVerses = 39, RowCntAlephTavs = 41, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 10, Abrv = "2Sa", RowCntVerses = 29, RowCntAlephTavs = 30, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 11, Abrv = "1Ki", RowCntVerses = 35, RowCntAlephTavs = 37, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 12, Abrv = "2Ki", RowCntVerses = 30, RowCntAlephTavs = 30, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 13, Abrv = "1Ch", RowCntVerses = 12, RowCntAlephTavs = 12, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 14, Abrv = "2Ch", RowCntVerses = 24, RowCntAlephTavs = 24, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 16, Abrv = "Neh", RowCntVerses = 7, RowCntAlephTavs = 7, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 17, Abrv = "Est", RowCntVerses = 13, RowCntAlephTavs = 13, BookGroupId = 2, BookGroupDescription = "History"},
new AlephTavSummary {Id = 18, Abrv = "Job", RowCntVerses = 2, RowCntAlephTavs = 2, BookGroupId = 3, BookGroupDescription = "Poetry (Wisdom)"},
new AlephTavSummary {Id = 19, Abrv = "Psa", RowCntVerses = 6, RowCntAlephTavs = 6, BookGroupId = 3, BookGroupDescription = "Poetry (Wisdom)"},
new AlephTavSummary {Id = 20, Abrv = "Pro", RowCntVerses = 2, RowCntAlephTavs = 2, BookGroupId = 3, BookGroupDescription = "Poetry (Wisdom)"},
new AlephTavSummary {Id = 21, Abrv = "Ecc", RowCntVerses = 4, RowCntAlephTavs = 4, BookGroupId = 3, BookGroupDescription = "Poetry (Wisdom)"},
new AlephTavSummary {Id = 22, Abrv = "Son", RowCntVerses = 5, RowCntAlephTavs = 5, BookGroupId = 3, BookGroupDescription = "Poetry (Wisdom)"},
new AlephTavSummary {Id = 23, Abrv = "Isa", RowCntVerses = 22, RowCntAlephTavs = 22, BookGroupId = 4, BookGroupDescription = "Major Prophets"},
new AlephTavSummary {Id = 24, Abrv = "Jer", RowCntVerses = 58, RowCntAlephTavs = 62, BookGroupId = 4, BookGroupDescription = "Major Prophets"},
new AlephTavSummary {Id = 25, Abrv = "Lam", RowCntVerses = 1, RowCntAlephTavs = 1, BookGroupId = 4, BookGroupDescription = "Major Prophets"},
new AlephTavSummary {Id = 26, Abrv = "Eze", RowCntVerses = 39, RowCntAlephTavs = 41, BookGroupId = 4, BookGroupDescription = "Major Prophets"},
new AlephTavSummary {Id = 27, Abrv = "Dan", RowCntVerses = 6, RowCntAlephTavs = 6, BookGroupId = 4, BookGroupDescription = "Major Prophets"},
new AlephTavSummary {Id = 30, Abrv = "Amo", RowCntVerses = 3, RowCntAlephTavs = 3, BookGroupId = 5, BookGroupDescription = "Minor Prophets"},
new AlephTavSummary {Id = 31, Abrv = "Oba", RowCntVerses = 2, RowCntAlephTavs = 2, BookGroupId = 5, BookGroupDescription = "Minor Prophets"},
new AlephTavSummary {Id = 33, Abrv = "Mic", RowCntVerses = 2, RowCntAlephTavs = 2, BookGroupId = 5, BookGroupDescription = "Minor Prophets"},
new AlephTavSummary {Id = 36, Abrv = "Zep", RowCntVerses = 2, RowCntAlephTavs = 2, BookGroupId = 5, BookGroupDescription = "Minor Prophets"},
new AlephTavSummary {Id = 37, Abrv = "Hag", RowCntVerses = 1, RowCntAlephTavs = 1, BookGroupId = 5, BookGroupDescription = "Minor Prophets"},
new AlephTavSummary {Id = 38, Abrv = "Zec", RowCntVerses = 3, RowCntAlephTavs = 3, BookGroupId = 5, BookGroupDescription = "Minor Prophets"},
new AlephTavSummary {Id = 39, Abrv = "Mal", RowCntVerses = 3, RowCntAlephTavs = 3, BookGroupId = 5, BookGroupDescription = "Minor Prophets"},
		}.AsQueryable();
	}
	/*

SELECT CodeGen FROM vwAlephTavSummaryCodeGen ORDER BY Id

SELECT 
'new AlephTavSummary {' +
'Id = ' + CAST(ID AS varchar(4)) + 
', Abrv = "' + Abrv  + 
'", RowCntVerses = ' + CAST(RowCntVerses AS varchar(4)) + 
', RowCntAlephTavs = ' + CAST(RowCntAlephTavs AS varchar(4)) + 
', BookGroupId = ' + CAST(BookGroupId AS varchar(4)) + 
', BookGroupDescription = "' + BookGroup + '"},'  
AS CodeGen
, Id
FROM AlephTavSummary

	*/

}

