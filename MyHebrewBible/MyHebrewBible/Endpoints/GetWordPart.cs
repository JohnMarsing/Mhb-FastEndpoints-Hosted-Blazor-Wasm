namespace MyHebrewBible.Endpoints;

public class WordPartRequest
{
	public long ScriptureId { get; set; }
}

public class GetWordPart : Endpoint<WordPartRequest, IEnumerable<WordPart>>
{
	public override void Configure()
	{
		Get("/wordpart/{scriptureid:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetWordPart(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(WordPartRequest request, CancellationToken ct)
	{
		IEnumerable<WordPart?> verses = await _db.GetWordParts(request.ScriptureId);
		await SendAsync(verses.ToList()!);
	}
}
