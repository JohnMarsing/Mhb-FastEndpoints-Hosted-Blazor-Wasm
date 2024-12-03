using MyHebrewBible.Client.Enums;
namespace MyHebrewBible.Endpoints;

public class GetVerseListBetweenIdsRequest
{
	public long BegId { get; set; }
	public long EndId { get; set; }
}

public class GetVerseListBetweenIds : Endpoint<GetVerseListBetweenIdsRequest, IEnumerable<BibleVerse>>
{
	public override void Configure()
	{
		Get(Api.VerseListBetweenIds.EndPoint);
		AllowAnonymous();
	}

	private readonly Query _db;
	private readonly ILogger<GetVerseListBetweenIds> _logger;
	public GetVerseListBetweenIds(Query query, ILogger<GetVerseListBetweenIds> logger)
	{
		_db = query;
		_logger = logger;
	}

	public override async Task HandleAsync(GetVerseListBetweenIdsRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get BegId/EndId: {BegId}/{EndId}"
		, nameof(GetVerseListBetweenIdsRequest), request.BegId, request.EndId);
		try
		{
			IEnumerable<BibleVerse?> verses = await _db.GetVerseListBetweenIds(request.BegId, request.EndId);
			_logger.LogDebug($"Retrieved {verses.Count()} verses from the database.");
			await SendAsync(verses.ToList()!);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(GetVerseListBetweenIdsRequest));
			throw;
		}
	}
}

