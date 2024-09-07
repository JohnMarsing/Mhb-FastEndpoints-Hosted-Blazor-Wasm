namespace MyHebrewBible.Endpoints;

public class GetVerseListByBCVRequest
{
	public long BookID { get; set; }
	public long Chapter { get; set; }
	public long BegVerse { get; set; }
	public long EndVerse { get; set; }
}

public class GetVerseListByBCV : Endpoint<GetVerseListByBCVRequest, IEnumerable<BibleVerse>>
{
	public override void Configure()
	{
		Get("/verselist/{bookid:long}/{chapter:long}/{begverse:long}/{endverse:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetVerseListByBCV(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(GetVerseListByBCVRequest request, CancellationToken ct)
	{
		IEnumerable<BibleVerse?> verses = await _db.GetVerseListByBCV(request.BookID, request.Chapter, request.BegVerse, request.EndVerse);
		await SendAsync(verses.ToList()!);
	}
}
