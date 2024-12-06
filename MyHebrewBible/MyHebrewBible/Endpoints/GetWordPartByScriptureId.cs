using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class WordPartByScriptureIdRequest
{
	public long ScriptureId { get; set; }
}

public class GetWordPartByScriptureId : Endpoint<WordPartByScriptureIdRequest, IEnumerable<WordPart>>
{
	public override void Configure()
	{
		Get(Api.HebrewWords.EndPoint);
		AllowAnonymous();
	}

	private readonly Query _db;
	private readonly ILogger<GetWordPartByScriptureId> _logger;
	public GetWordPartByScriptureId(Query query, ILogger<GetWordPartByScriptureId> logger)
	{
		_db = query;
		_logger = logger;
	}

	public override async Task HandleAsync(WordPartByScriptureIdRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} ScriptureId: {ScriptureId}", nameof(HandleAsync), request.ScriptureId);
		try
		{
			IEnumerable<WordPart?> verses = await _db.GetWordPartByScriptureId(request.ScriptureId);
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