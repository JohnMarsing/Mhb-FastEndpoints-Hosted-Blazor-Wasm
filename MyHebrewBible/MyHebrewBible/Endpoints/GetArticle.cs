namespace MyHebrewBible.Endpoints;

public class ArticleRequest
{
	public long Id { get; set; }
}

public class GetArticle : Endpoint<ArticleRequest, Article>
{
	public override void Configure()
	{
		Get("/article/{id:long}");
		AllowAnonymous();
	}

	private readonly Repository _db;
	public GetArticle(Repository repository)
	{
		_db = repository;
	}

	public override async Task HandleAsync(ArticleRequest request, CancellationToken c)
	{
		Article? article = await _db.GetArticle(request.Id);
		await SendAsync(article!);
	}
}
