namespace MyHebrewBible.Endpoints;

public class GetVerseListRequest
{
	public long BegId { get; set; }
	public long EndId { get; set; }
}

public class GetVerseList : Endpoint<GetVerseListRequest, IEnumerable<VerseList>>
{
	public override void Configure()
	{
		//https://myhebrewbible.azurewebsites.net/Verse/gen-1-2/Englishonly
		//string Uri = $"api/versebyrange/{begId}/{endId}";
		//@page "/VerseList/{BegId:int}/{EndId:int}"
		Get("/VerseList/{begId:long}/{endId:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetVerseList(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(GetVerseListRequest request, CancellationToken ct)
	{
		IEnumerable<VerseList?> verses = await _db.GetVerseList(request.BegId, request.EndId);
		await SendAsync(verses.ToList()!);
	}
}

//https://myhebrewbible.azurewebsites.net/MultiVerseLookupCsv
//Gen 1:1, Exo 2:2-3
// IScriptureService? svc
// await svc!.GetByVerses(begId, endId);

/*
	public async Task GetByVerses(int begId, int endId) 
	{
		string Uri = $"api/versebyrange/{begId}/{endId}";
		_logger.LogDebug(string.Format("Inside {0}; Uri: {1}"
			, nameof(ScriptureService) + "!" + nameof(GetByVerses), Uri));
		var result = await _http.GetFromJsonAsync<List<VerseListVM>>(requestUri: Uri);

		if (result is not null)
		{
			VerseList = result;
		}
	}
*/