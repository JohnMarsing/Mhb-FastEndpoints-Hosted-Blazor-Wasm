using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class WordPartKjvRequest
{
	public long ScriptureId { get; set; }
}

public class GetWordPartKjv : Endpoint<WordPartKjvRequest, IEnumerable<WordPartKjv>>
{
	public override void Configure()
	{
		Get(Api.WordPartKjv.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetWordPartKjv> _logger;
	public GetWordPartKjv(Query query, ILogger<GetWordPartKjv> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(WordPartKjvRequest request, CancellationToken ct)
	{
		//_logger.LogDebug("{Method} Id: {Id}", nameof(HandleAsync), request.Id);
		try
		{
		IEnumerable<WordPartKjv?> wordparts = await _db.GetWordPartKjv(request.ScriptureId);
		await SendAsync(wordparts.ToList()!);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(HandleAsync));
			throw;
		}
	}
}

public class WordPartKjv
{
	public long ScriptureID { get; set; }
	public long WordCount { get; set; }
	public long? Strongs { get; set; }
	public string? Word { get; set; }
}

// Ignore Spelling: Strongs