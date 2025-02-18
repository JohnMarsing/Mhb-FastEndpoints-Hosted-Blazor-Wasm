using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class WordPartKjvRequest
{
	public int ScriptureId { get; set; }
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
	public int ScriptureID { get; set; }
	public int WordCount { get; set; }
	public int Strongs { get; set; } // fn 1
	public string? Word { get; set; }
}

// fn 1: was int?, forced to 0 like this... `ifnull(Strongs,0) AS Strongs`; see MyHebrewBible.Client\Enums\Api.cs!WordPartKjvSE
// Ignore Spelling: Strongs