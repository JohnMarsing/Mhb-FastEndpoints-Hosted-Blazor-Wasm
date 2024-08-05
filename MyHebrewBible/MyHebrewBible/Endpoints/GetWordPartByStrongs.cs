namespace MyHebrewBible.Endpoints;


public class WordPartByStrongsRequest
{
	public long ScriptureId { get; set; }
	public long Strongs { get; set; }
}


public class GetWordPartByStrongs : Endpoint<WordPartByStrongsRequest, IEnumerable<WordPart>>
{
	public override void Configure()
	{
		Get("/wordpart/{scriptureid:long}/{strongs:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetWordPartByStrongs(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(WordPartByStrongsRequest request, CancellationToken ct)
	{
		IEnumerable<WordPart?> verses = await _db.GetWordPartsByStrongs(request.ScriptureId, request.Strongs);
		await SendAsync(verses.ToList()!);
	}

}


// Ignore Spelling: strongs, 