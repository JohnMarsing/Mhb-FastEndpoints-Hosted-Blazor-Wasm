using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class WordPartByBookAndChapterRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
}

public class GetAlephTavHebrewVerses(Query query, ILogger<GetAlephTavHebrewVerses> logger) : Endpoint<WordPartByBookAndChapterRequest, IEnumerable<AlephTavHebrewVerse>>
{
	public override void Configure()
	{
		Get(Api.AlephTavHebrewVerses.EndPoint);
		AllowAnonymous();
	}

	#region DI Using Primary Constructors
	private readonly Query _db = query;
	private readonly ILogger<GetAlephTavHebrewVerses> _logger = logger;
	#endregion

	public override async Task HandleAsync(WordPartByBookAndChapterRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get B/C: {BookID}/{Chapter}"
		, nameof(HandleAsync), request.BookID, request.Chapter);
		try
		{
			IEnumerable<AlephTavHebrewVerse?> verses = await _db.GetAlephTavHebrewVerses(request.BookID, request.Chapter);
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

public class AlephTavHebrewVerse
{
	public long ScriptureID { get; set; }
	public string? BCV { get; set; }
	public long Chapter { get; set; }
	public long Verse { get; set; }
	public long WordCount { get; set; }
	public long WordEnum { get; set; }
	public string? Hebrew1 { get; set; }
	public string? Hebrew2 { get; set; }
	public string? Hebrew3 { get; set; }
	public string? KjvWord { get; set; }
	public long Strongs { get; set; }
	public string? Transliteration { get; set; }
	public int? FinalEnum { get; set; }
	public long HasTwo { get; set; }
}

// Ignore Spelling: BCV, strongs, Paseq, css,  alephtavhebrewverse: bookid, 
