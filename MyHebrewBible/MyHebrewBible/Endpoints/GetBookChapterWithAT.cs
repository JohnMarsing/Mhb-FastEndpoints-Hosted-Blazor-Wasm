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

public class BibleVerseWithAT
{
	public long ID { get; set; }
	public string? BCV { get; set; }
	public long Verse { get; set; }
	public string? VerseOffset { get; set; }
	public string? KJV { get; set; }
	public string? DescH { get; set; }
	public string? DescD { get; set; }
	public List<WordPart>? WordPartList { get; set; }
}

public record WordPart
{
	public int Id { get; init; }                   // AlephTavVerseWordPart!Id int
	public string? BCV { get; init; }
	public long BookID { get; init; }              // Scripture!BookID is bigint
	public long Chapter { get; init; }             // Scripture!Chapter is bigint
	public long Verse { get; init; }               // Scripture!Verse is bigint
	public int ScriptureID { get; init; }          // WordPart!ScriptureID int
	public int WordCount { get; init; }
	public int SegmentCount { get; init; }
	public int WordEnum { get; init; }             // WordPart!WordEnum int
	public string? Hebrew1 { get; init; }
	public string? Hebrew2 { get; init; }
	public string? Hebrew3 { get; init; }
	public string? KjvWord { get; init; }
	public int Strongs { get; init; }              // WordPart!Strongs int
	public string? Transliteration { get; init; }
	public int? FinalEnum { get; init; }           // WordPart!FinalEnum int
}

// Ignore Spelling: BCV, Strongs