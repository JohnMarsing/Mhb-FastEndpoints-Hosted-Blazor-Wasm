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
	public long ID { get; set; }            // s.ID, 
	public long SectionId { get; set; }     // t.SectionId, 
	public long RowCnt { get; set; }        // t.RowCnt, 
	public string? VerseRange { get; set; } // t.VerseRange,
	public string? BCV { get; set; }        // s.BCV, 
	public long BookID { get; set; }        // s.BookID, 
	public long Chapter { get; set; }       // s.Chapter, 
	public long Verse { get; set; }         // s.Verse, 
	public string? VerseOffset { get; set; } //s.VerseOffset
	public string? KJV { get; set; }        // s.KJV, 
	public string? DescH { get; set; }      // s.DescH, 
	public string? DescD { get; set; }      // s.DescD
	public List<CommonDtos.WordPart>? WordPartList { get; init; }
}
// Ignore Spelling: Cnt, BCV