namespace MyHebrewBible.Endpoints;

public class GetAlephTavRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
}

public class GetAlephTav : Endpoint<GetAlephTavRequest, IEnumerable<AlephTav>>
{
	public override void Configure()
	{
		Get("/aleptav/{bookid:long}/{chapter:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetAlephTav(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(GetAlephTavRequest request, CancellationToken ct)
	{
		IEnumerable<AlephTav?> verses = await _db.GetAlephTav(request.BookID, request.Chapter);
		await SendAsync(verses.ToList()!);
	}
}
