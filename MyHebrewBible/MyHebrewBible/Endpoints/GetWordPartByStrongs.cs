using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class WordPartByStrongsRequest
{
	public int ScriptureId { get; set; }
	public int Strongs { get; set; }
}

public class GetWordPartByStrongs : Endpoint<WordPartByStrongsRequest, IEnumerable<WordPartByStrongs>>
{
	public override void Configure()
	{
		Get(Api.WordPartByStrongs.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetWordPartByStrongs> _logger;
	public GetWordPartByStrongs(Query query, ILogger<GetWordPartByStrongs> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(WordPartByStrongsRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} ScriptureId: {ScriptureId}; Strongs: {Strongs}"
			, nameof(HandleAsync), request.ScriptureId, request.Strongs);
		try
		{
			IEnumerable<WordPartByStrongs?> verses = await _db.GetWordPartsByStrongs(request.ScriptureId, request.Strongs);
			await SendAsync(verses.ToList()!);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(HandleAsync));
		}
	}

}

public class WordPartByStrongs
{
	public int ScriptureID { get; set; }
	public int WordCount { get; set; }
	public int SegmentCount { get; set; }
	public int WordEnum { get; set; }
	public string? Hebrew1 { get; set; }
	public string? Hebrew2 { get; set; }
	public string? Hebrew3 { get; set; }
	public string? KjvWord { get; set; }
	public int Strongs { get; set; }
	public string? Transliteration { get; set; }
	public int? FinalEnum { get; set; }
}

// Ignore Spelling: strongs, 