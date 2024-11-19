namespace MyHebrewBible.Endpoints;


public class WordPartByBookAndChapterRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
}

public class GetAlephTavHebrewVerses : Endpoint<WordPartByBookAndChapterRequest, IEnumerable<AlephTavHebrewVerse>>
{
	public override void Configure()
	{
		Get("/alephtavhebrewverse/{bookid:long}/{chapter:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetAlephTavHebrewVerses(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(WordPartByBookAndChapterRequest request, CancellationToken ct)
	{
		IEnumerable<AlephTavHebrewVerse?> verses = await _db.GetAlephTavHebrewVerses(request.BookID, request.Chapter);
		await SendAsync(verses.ToList()!); 
	}
}

// Ignore Spelling: alephtavhebrewverse: bookid, 