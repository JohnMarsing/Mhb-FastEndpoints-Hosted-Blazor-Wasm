using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class ParashaWithATRequest
{
	public int Id { get; set; }
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
	public int ID { get; init; }            // s.ID, 
	public int SectionId { get; init; }     // t.SectionId, 
	public int GroupCount { get; init; }    // t.GroupCount, 
	public int ScriptureID_Beg { get; init; } // t.ScriptureID_Beg, 
	public string? VerseRange { get; init; } // t.VerseRange,
	public string? BCV { get; init; }        // s.BCV, 
	public int BookID { get; init; }        // s.BookID, 
	public int Chapter { get; init; }       // s.Chapter, 
	public int Verse { get; init; }         // s.Verse, 
	public string? VerseOffset { get; init; } //s.VerseOffset
	public string? KJV { get; init; }        // s.KJV, 
	public string? DescH { get; init; }      // s.DescH, 
	public string? DescD { get; init; }      // s.DescD
	public List<CommonDtos.WordPart>? WordPartList { get; init; }
}
// Ignore Spelling: Cnt, BCV