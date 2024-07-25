namespace MyHebrewBible.Endpoints;

public class WordPartKjvRequest
{
	public long ScriptureId { get; set; }
}

public class GetWordPartKjv : Endpoint<WordPartKjvRequest, IEnumerable<WordPartKjv>>
{
	public override void Configure()
	{
		Get("/wordpartkjv/{scriptureid:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetWordPartKjv(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(WordPartKjvRequest request, CancellationToken ct)
	{
		IEnumerable<WordPartKjv?> wordparts = await _db.GetWordPartKjvs(request.ScriptureId);
		await SendAsync(wordparts.ToList()!);
	}
}