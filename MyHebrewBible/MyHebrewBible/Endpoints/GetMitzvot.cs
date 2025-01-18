using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

// GetMitzvotAsync(long torahBookfilter, long filter)
public class MitzvahRequest
{
	public long filter { get; set; }
}

public class GetMitzvot : Endpoint<MitzvahRequest, IEnumerable<Mitzvah>>
{
	public override void Configure()
	{
		Get(Api.Mitzvah.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetMitzvot> _logger;
	public GetMitzvot(Query query, ILogger<GetMitzvot> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(MitzvahRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Filter: {Filter}", nameof(HandleAsync), request.filter);
		try
		{
			IEnumerable<Mitzvah?> mitzvot = await _db.GetMitzvot(request.filter);
			await SendAsync(mitzvot.ToList()!);
			_logger.LogDebug($"Retrieved {mitzvot.Count()} mitzvot from the database.");
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(HandleAsync));
			throw;
		}
	}

}

public class Mitzvah
{
	public long Id { get; set; }
	public long Detail { get; set; }
	public long BegId { get; set; }
	public long EndId { get; set; }
	public string? Verse { get; set; }
	public string? Descr { get; set; }
	public long BookId { get; set; }
	public string? BookAbrv { get; set; }
}

// Ignore Spelling: Mitzvah, Mitzvot, Descr, Abrv