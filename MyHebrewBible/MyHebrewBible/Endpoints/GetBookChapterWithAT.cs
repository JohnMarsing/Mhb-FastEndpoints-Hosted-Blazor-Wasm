using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class BookChapterWithATRequest
{
	//[BindFrom("amount")]
	public long BookID { get; set; }
	public long Chapter { get; set; }
}

public class GetBookChapterWithAT : Endpoint<BookChapterWithATRequest, IEnumerable<BibleVerseWithAT>>
{
	public override void Configure()
	{
		Get(Api.BookChapterWithAT.EndPoint);
		AllowAnonymous();
	}

	#region DI 
	private readonly Query _db;
	private readonly ILogger<GetBookChapterWithAT> _logger;
	public GetBookChapterWithAT(Query query, ILogger<GetBookChapterWithAT> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(BookChapterWithATRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get B/C: {BookID}/{Chapter}"
			, nameof(HandleAsync), request.BookID, request.Chapter);
		try
		{
			IEnumerable<BibleVerseWithAT?> verses = await _db.GetBookChapterWithAT(request.BookID, request.Chapter);
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

public record BibleVerseWithAT
{
	public long ID { get; init; }
	public string? BCV { get; init; }
	public long Verse { get; init; }
	public string? VerseOffset { get; init; }
	public string? KJV { get; init; }
	public string? DescH { get; init; }
	public string? DescD { get; init; }
	public List<CommonDtos.WordPart>? WordPartList { get; init; }
}

// Ignore Spelling: BCV