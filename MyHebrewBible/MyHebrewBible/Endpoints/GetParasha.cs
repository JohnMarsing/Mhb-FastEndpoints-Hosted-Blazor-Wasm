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

	private readonly Query _db;
	private readonly ILogger<GetParasha> _logger;
	public GetParasha(Query query, ILogger<GetParasha> logger)
	{
		_db = query;
		_logger = logger;
	}

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
