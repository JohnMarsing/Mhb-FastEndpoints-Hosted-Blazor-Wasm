using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class AlephTavBookChapterWordPartContextRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
}

public class GetAlephTavBookChapterWordPartContext(Query query, ILogger<GetAlephTavBookChapterWordPartContext> logger) : 
Endpoint<AlephTavBookChapterWordPartContextRequest, IEnumerable<AlephTavBookChapterWordPartContext>>
{
	public override void Configure()
	{
		Get(Api.AlephTavBookChapterWordPartContext.EndPoint);
		AllowAnonymous();
	}

	#region DI Using Primary Constructors
	private readonly Query _db = query;
	private readonly ILogger<GetAlephTavBookChapterWordPartContext> _logger = logger;
	#endregion

	public override async Task HandleAsync(AlephTavBookChapterWordPartContextRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get B/C: {BookID}/{Chapter}"
		, nameof(HandleAsync), request.BookID, request.Chapter);
		try
		{
			IEnumerable<AlephTavBookChapterWordPartContext?> verses = await _db.GetAlephTavWordPartContext(request.BookID, request.Chapter);
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

public class AlephTavBookChapterWordPartContext 
{
	public int Id { get; set; }                   // AlephTavVerseWordPart!Id int
	public int ScriptureID { get; set; }          // WordPart!ScriptureID int
	public string? BCV { get; set; }
	public long BookID { get; set; }              // Scripture!BookID is bigint
	public long Chapter { get; set; }             // Scripture!Chapter is bigint
	public long Verse { get; set; }               // Scripture!Verse is bigint
	public int WordCount { get; set; }
	public int SegmentCount { get; set; }
	public int WordEnum { get; set; }             // WordPart!WordEnum int
	public string? Hebrew1 { get; set; }
	public string? Hebrew2 { get; set; }
	public string? Hebrew3 { get; set; }
	public string? KjvWord { get; set; }
	public int Strongs { get; set; }              // WordPart!Strongs int
	public string? Transliteration { get; set; }
	public int? FinalEnum { get; set; }           // WordPart!FinalEnum int
	public long HasTwo { get; set; }              // AlephTavVerse!HasTwo bigint

}

// Ignore Spelling: alephtavhebrewverse: bookid, BCV, bigint, Strongs