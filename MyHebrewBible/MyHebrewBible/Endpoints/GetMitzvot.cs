namespace MyHebrewBible.Endpoints;

public class MitzvahRequest
{
	public long Filter { get; set; }
}

 public class GetMitzvot  : Endpoint<MitzvahRequest, IEnumerable<Mitzvah>>
{
	public override void Configure()
	{
		//string Uri = $"api/mitzvot/book/{torahBookFilter.Value}";
		Get("/mitzvot/book/{torahBookfilter:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetMitzvot(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(MitzvahRequest request, CancellationToken ct)
	{
		IEnumerable<Mitzvah?> mitzvot = await _db.GetMitzvot(request.Filter);
		await SendAsync(mitzvot.ToList()!);
	}
}
