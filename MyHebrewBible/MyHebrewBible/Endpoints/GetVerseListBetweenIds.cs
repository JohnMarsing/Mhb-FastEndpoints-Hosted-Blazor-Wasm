using MyHebrewBible.Client.Enums;
namespace MyHebrewBible.Endpoints;

public class VerseListBetweenIdsRequest
{
	public long BegId { get; set; }
	public long EndId { get; set; }
}

public class GetVerseListBetweenIds : Endpoint<VerseListBetweenIdsRequest, IEnumerable<BibleVerseId>>
{
	public override void Configure()
	{
		Get(Api.VerseListBetweenIds.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetVerseListBetweenIds> _logger;
	public GetVerseListBetweenIds(Query query, ILogger<GetVerseListBetweenIds> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(VerseListBetweenIdsRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get BegId/EndId: {BegId}/{EndId}"
		, nameof(HandleAsync), request.BegId, request.EndId);
		try
		{
			IEnumerable<BibleVerseId?> verses = await _db.GetVerseListBetweenIds(request.BegId, request.EndId);
			_logger.LogDebug($"Retrieved {verses.Count()} verses from the database.");
			await SendAsync(verses.ToList()!);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(HandleAsync));
			throw;
		}
	}
}

public class BibleVerseId
{
	public long ID { get; set; }
	public string? BCV { get; set; }
	public long Verse { get; set; }
	public string? VerseOffset { get; set; }
	public string? KJV { get; set; }
	public string? DescH { get; set; }
	public string? DescD { get; set; }
}
// Ignore Spelling: BCV