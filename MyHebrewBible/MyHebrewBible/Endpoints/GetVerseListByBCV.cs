using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class GetVerseListByBCVRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
	public long BegVerse { get; set; }
	public long EndVerse { get; set; }
}

public class GetVerseListByBCV : Endpoint<GetVerseListByBCVRequest, IEnumerable<BibleVerse>>
{
	public override void Configure()
	{
		Get(Api.VerseList.EndPoint);
		AllowAnonymous();
	}

	private readonly Query _db;
	private readonly ILogger<GetVerseListByBCV> _logger;
	public GetVerseListByBCV(Query query, ILogger<GetVerseListByBCV> logger)
	{
		_db = query;
		_logger = logger;
	}

	public override async Task HandleAsync(GetVerseListByBCVRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get B/C: {BookID}/{Chapter} Verse {BegVerse}:{EndVerse}"
			, nameof(GetVerseListByBCVRequest), request.BookID, request.Chapter, request.BegVerse, request.EndVerse);
		try
		{
			IEnumerable<BibleVerse?> verses = await _db.GetVerseListByBCV(request.BookID, request.Chapter, request.BegVerse, request.EndVerse);
			_logger.LogDebug($"Retrieved {verses.Count()} verses from the database.");
			await SendAsync(verses.ToList()!);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(GetVerseListByBCVRequest));
			throw;
		}
	}
}
