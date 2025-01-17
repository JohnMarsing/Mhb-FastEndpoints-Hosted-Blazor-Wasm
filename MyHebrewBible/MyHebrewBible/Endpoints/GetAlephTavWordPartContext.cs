using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class AlephTavWordPartContextRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
}

public class GetAlephTavWordPartContext(Query query, ILogger<GetAlephTavWordPartContext> logger) : Endpoint<AlephTavWordPartContextRequest, IEnumerable<AlephTavWordPartContext>>
{
	public override void Configure()
	{
		Get(Api.AlephTavWordPartContext.EndPoint);
		AllowAnonymous();
	}

	#region DI Using Primary Constructors
	private readonly Query _db = query;
	private readonly ILogger<GetAlephTavWordPartContext> _logger = logger;
	#endregion

	public override async Task HandleAsync(AlephTavWordPartContextRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get B/C: {BookID}/{Chapter}"
		, nameof(HandleAsync), request.BookID, request.Chapter);
		try
		{
			IEnumerable<AlephTavWordPartContext?> verses = await _db.GetAlephTavWordPartContext(request.BookID, request.Chapter);
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