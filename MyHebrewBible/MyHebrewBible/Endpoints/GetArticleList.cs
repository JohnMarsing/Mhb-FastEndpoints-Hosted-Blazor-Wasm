
namespace MyHebrewBible.Endpoints;

public class ArticleListRequest
{
	public long Filter { get; set; }
}

public class GetArticleList : Endpoint<ArticleListRequest, IEnumerable<ArticleList>>
{
	public override void Configure()
	{
		Get("/articlelist/{filter:long}");   // /articlelist/{filter:long}
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetArticleList(Repository repository)
	{
		_db = repository;
	}

	
	public override async Task HandleAsync(ArticleListRequest request, CancellationToken ct)
	{
		IEnumerable<ArticleList?> articleList = await _db.GetArticleList(request.Filter); //(request.Filter!
		await SendAsync(articleList.ToList()!);
	}
}
