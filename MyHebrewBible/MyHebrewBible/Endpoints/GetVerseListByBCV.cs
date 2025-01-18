using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class VerseListByBCVRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
	public long BegVerse { get; set; }
	public long EndVerse { get; set; }
}

public class GetVerseListByBCV : Endpoint<VerseListByBCVRequest, IEnumerable<BibleVerseBCV>>
{
	public override void Configure()
	{
		Get(Api.VerseList.EndPoint);
		AllowAnonymous();
	}

	#region DI 
	private readonly Query _db;
	private readonly ILogger<GetVerseListByBCV> _logger;
	public GetVerseListByBCV(Query query, ILogger<GetVerseListByBCV> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(VerseListByBCVRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get B/C: {BookID}/{Chapter} Verse {BegVerse}:{EndVerse}"
			, nameof(HandleAsync), request.BookID, request.Chapter, request.BegVerse, request.EndVerse);
		try
		{
			IEnumerable<BibleVerseBCV?> verses = await _db.GetVerseListByBCV(request.BookID, request.Chapter, request.BegVerse, request.EndVerse);
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

public class BibleVerseBCV
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