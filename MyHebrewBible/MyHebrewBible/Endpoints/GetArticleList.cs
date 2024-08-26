namespace MyHebrewBible.Endpoints;

public class ArticleListRequest
{
	public string? DummyString { get; set; }
}

public class GetArticleList : Endpoint<ArticleListRequest, IEnumerable<ArticleList>>
{
	public override void Configure()
	{
		Get("/articlelist");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetArticleList(Repository repository)
	{
		_db = repository;
	}

	
	public override async Task HandleAsync(ArticleListRequest request, CancellationToken ct)
	{
		IEnumerable<ArticleList?> articleList = await _db.GetArticleList(); 
		await SendAsync(articleList.ToList()!);
	}
}
