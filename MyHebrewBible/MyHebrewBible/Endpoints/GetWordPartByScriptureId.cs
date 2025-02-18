using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class WordPartByScriptureIdRequest
{
	public int ScriptureId { get; set; }
}

public class GetWordPartByScriptureId : Endpoint<WordPartByScriptureIdRequest, IEnumerable<WordPartByScriptureId>>  //
{
	public override void Configure()
	{
		Get(Api.WordPartByScriptureId.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetWordPartByScriptureId> _logger;
	public GetWordPartByScriptureId(Query query, ILogger<GetWordPartByScriptureId> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(WordPartByScriptureIdRequest request, CancellationToken ct)
	{
		//_logger.LogDebug("{Method} ScriptureId: {ScriptureId}", nameof(HandleAsync), request.ScriptureId);
		try
		{
			IEnumerable<WordPartByScriptureId?> verses = await _db.GetWordPartByScriptureId(request.ScriptureId);
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

public class WordPartByScriptureId
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
// Ignore Spelling: strongs, Paseq