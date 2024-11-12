namespace MyHebrewBible.Endpoints;

public class GetAlephTavByBookRequest
{
	public long BookID { get; set; }
}

public class GetAlephTavByBook : Endpoint<GetAlephTavByBookRequest, IEnumerable<AlephTavList>>
{
	public override void Configure()
	{
		Get("/aleptavlist/{bookid:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetAlephTavByBook(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(GetAlephTavByBookRequest request, CancellationToken ct)
	{
		IEnumerable<AlephTavList?> verses = await _db.GetAlephTavByBook(request.BookID);
		await SendAsync(verses.ToList()!);
	}
}
