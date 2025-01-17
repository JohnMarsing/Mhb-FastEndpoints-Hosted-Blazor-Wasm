using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class AlephTavTriennialWordPartContextRequest
{
	public long TriennialId { get; set; }
}

public class GetAlephTavTriennialWordPartContext(Query query, ILogger<GetAlephTavTriennialWordPartContext> logger) : Endpoint<AlephTavTriennialWordPartContextRequest, IEnumerable<AlephTavWordPartContext>>
{
	public override void Configure()
	{
		//Get(Api.AlephTavWordPartContext.EndPoint);
		Get(Api.AlephTavTriennialWordPartContext.EndPoint);
		AllowAnonymous();
	}

	#region DI Using Primary Constructors
	private readonly Query _db = query;
	private readonly ILogger<GetAlephTavTriennialWordPartContext> _logger = logger;
	#endregion

	public override async Task HandleAsync(AlephTavTriennialWordPartContextRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get TriennialId: {TriennialId}"
		, nameof(HandleAsync), request.TriennialId);
		try
		{
			IEnumerable<AlephTavWordPartContext?> verses = await _db.GetAlephTavTriennialWordPartContext(request.TriennialId);
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
// Ignore Spelling: alephtavhebrewverse: bookid,  
