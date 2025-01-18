using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class ParashaIdRequest
{
	//public long TriennialId { get; set; }
	public long Id { get; set; }
}

public class GetParasha : Endpoint<ParashaIdRequest, IEnumerable<Parasha>>
{
	public override void Configure()
	{
		Get(Api.Parasha.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetParasha> _logger;
	public GetParasha(Query query, ILogger<GetParasha> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(ParashaIdRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get TriennialId: {TriennialId}"
		, nameof(HandleAsync), request.Id);
		try
		{
			IEnumerable<Parasha?> verses = await _db.GetParasha(request.Id!);
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

public class Parasha
{
	public long ID { get; set; } // Scripture.ID
	public long SectionId { get; set; }
	public long RowCnt { get; set; }
	public string? VerseRange { get; set; }
	//Scripture columns below
	public string? BCV { get; set; }
	public long BookID { get; set; }
	public long Chapter { get; set; }
	public long Verse { get; set; }
	public string? VerseOffset { get; set; }
	public string? KJV { get; set; }
	public string? DescH { get; set; }
	public string? DescD { get; set; }
}
