using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class BookChapterRequest
{
	//[BindFrom("amount")]
	public long BookID { get; set; }
	public long Chapter { get; set; }
}

public class GetBookChapter : Endpoint<BookChapterRequest, IEnumerable<BibleVerse>>
{
	public override void Configure()
	{
		Get(Api.BookChapter.EndPoint);
		AllowAnonymous();
	}

	private readonly Query _db;
	private readonly ILogger<GetBookChapter> _logger;
	public GetBookChapter(Query query, ILogger<GetBookChapter> logger)
	{
		_db = query;
		_logger = logger;
	}

	public override async Task HandleAsync(BookChapterRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get B/C: {BookID}/{Chapter}"
			, nameof(HandleAsync), request.BookID, request.Chapter);
		try
		{
			IEnumerable<BibleVerse?> verses = await _db.GetBookChapter(request.BookID, request.Chapter);
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
