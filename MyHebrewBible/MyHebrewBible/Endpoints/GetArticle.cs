namespace MyHebrewBible.Endpoints;

public class ArticleRequest
{
	public long Id { get; set; }
}

//                                               , IEnumerable<Article>
public class GetArticle : Endpoint<ArticleRequest, Article>  //Endpoint<ArticleRequest, Article>
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

	public override async Task HandleAsync(ArticleRequest request, CancellationToken ct)
	{
		Article? article = await _db.GetArticle(request.Id);
		if (article == null)
		{
			//https://fast-endpoints.com/docs/misc-conveniences#send-methods
			//await SendNoContentAsync(ct); 
			await SendNotFoundAsync(ct);
		}
		else
		{
			await SendAsync(article!);  // , cancellation: ct);
		}
	}
}
