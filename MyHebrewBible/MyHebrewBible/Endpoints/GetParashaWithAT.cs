using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class ParashaWithATRequest
{
	public long Id { get; set; }
}

public class GetParashaWithAT : Endpoint<ParashaWithATRequest, IEnumerable<ParashaWithAT>>
{
	public override void Configure()
	{
		Get(Api.ParashaWithAT.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetParashaWithAT> _logger;
	public GetParashaWithAT(Query query, ILogger<GetParashaWithAT> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(ParashaWithATRequest request, CancellationToken ct)
	{
		_logger.LogDebug("{Method} Get TriennialId: {TriennialId}"
		, nameof(HandleAsync), request.Id);
		try
		{
			IEnumerable<ParashaWithAT?> verses = await _db.GetParashaWithAT(request.Id!);
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

public record ParashaWithAT
{
	public long ID { get; init; }            // s.ID, 
	public long SectionId { get; init; }     // t.SectionId, 
	public long RowCnt { get; init; }        // t.RowCnt, 
	public string? VerseRange { get; init; } // t.VerseRange,
	public string? BCV { get; init; }        // s.BCV, 
	public long BookID { get; init; }        // s.BookID, 
	public long Chapter { get; init; }       // s.Chapter, 
	public long Verse { get; init; }         // s.Verse, 
	public string? VerseOffset { get; init; } //s.VerseOffset
	public string? KJV { get; init; }        // s.KJV, 
	public string? DescH { get; init; }      // s.DescH, 
	public string? DescD { get; init; }      // s.DescD
	public List<CommonDtos.WordPart>? WordPartList { get; init; }
}
// Ignore Spelling: Cnt, BCV