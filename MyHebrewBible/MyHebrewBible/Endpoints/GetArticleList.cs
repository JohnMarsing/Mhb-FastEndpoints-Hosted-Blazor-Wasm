using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

// Can't rename to Request because already used by GetArticle
public class ArticleListRequest
{
	public long Filter { get; set; }
}

public class GetArticleList : Endpoint<ArticleListRequest, IEnumerable<ArticleList>>
{
	public override void Configure()
	{
		Get(Api.ArticleList.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetArticleList> _logger;
	public GetArticleList(Query query, ILogger<GetArticleList> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(ArticleListRequest request, CancellationToken ct)
	{
		//_logger.LogDebug("{Method} Id: {Id}", nameof(HandleAsync), request.Id);
		try
		{
			IEnumerable<ArticleList?> articleList = await _db.GetArticleList(request.Filter); //(request.Filter!
			_logger.LogDebug($"Retrieved {articleList.Count()} articleList from the database.");
		await SendAsync(articleList.ToList()!);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(HandleAsync));
			throw;
		}
	}
}

public class ArticleList
{
	public long Id { get; set; }
	public string? Title { get; set; }
	public bool IsPlaceHolder { get; set; }
	public bool IsFavorite { get; set; }
	public bool IsWordStudy { get; set; }
	public bool IsParasha { get; set; }
}
