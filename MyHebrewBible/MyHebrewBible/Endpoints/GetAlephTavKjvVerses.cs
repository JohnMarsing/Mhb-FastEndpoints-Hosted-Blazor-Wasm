namespace MyHebrewBible.Endpoints;

		using MyHebrewBible.Client.Enums;

public class AlephTavKjvVersesRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
}


public class GetAlephTavKjvVerses(Query query, ILogger<GetAlephTavKjvVerses> logger) : Endpoint<AlephTavKjvVersesRequest, IEnumerable<BibleVerse>>
{
	public override void Configure()
	{
		Get(Api.AlephTavKjvVerses.EndPoint);
		AllowAnonymous();
	}

	#region DI Using Primary Constructors
	private readonly Query _db = query;
	private readonly ILogger<GetAlephTavKjvVerses> _logger = logger;
	#endregion

	public override async Task HandleAsync(AlephTavKjvVersesRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get B/C: {BookID}/{Chapter}"
		, nameof(HandleAsync), request.BookID, request.Chapter);
		try
		{
			IEnumerable<BibleVerse?> verses = await _db.GetAlephTavKjvVerses(request.BookID, request.Chapter);
			_logger.LogDebug($"Retrieved {verses.Count()} verses from the database.");
			await SendAsync(verses.ToList()!, cancellation: ct);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(HandleAsync));
			throw;
		}
	}
}

// Ignore Spelling: alephtavhebrewverse: bookid, 