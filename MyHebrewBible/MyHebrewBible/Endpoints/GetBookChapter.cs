namespace MyHebrewBible.Endpoints;

public class BookChapterRequest
{
	//[BindFrom("amount")]
	public long BookID { get; set; }
	public long Chapter { get; set; }
}

public class GetBookChapter : Endpoint<BookChapterRequest, IEnumerable<BibleVerse>>
{
	public override void Configure()
	{
		Get("/bookchapter/{bookid:long}/{chapter:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetBookChapter(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(BookChapterRequest request, CancellationToken ct)
	{
		IEnumerable<BibleVerse?> verses = await _db.GetBookChapter(request.BookID, request.Chapter);
		await SendAsync(verses.ToList()!);
	}
}
