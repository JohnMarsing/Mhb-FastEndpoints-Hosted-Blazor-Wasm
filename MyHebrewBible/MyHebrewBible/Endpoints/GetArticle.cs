using MyHebrewBible.Client.Enums;
namespace MyHebrewBible.Endpoints;

public class ArticleRequest
{
	public int Id { get; set; }
}

public class GetArticle : Endpoint<ArticleRequest, Article>
{
	public override void Configure()
	{
		Get(Api.Article.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetArticle> _logger;
	public GetArticle(Query query, ILogger<GetArticle> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion

	public override async Task HandleAsync(ArticleRequest request, CancellationToken c)
	{
		_logger.LogDebug("{Method} Id: {Id}", nameof(HandleAsync), request.Id);
		try
		{
			Article? article = await _db.GetArticle(request.Id);
			await SendAsync(article!);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(HandleAsync));
			throw;
		}
	}
}

public class Article
{
	public int Id { get; set; }
	public string? FileNameNoExt { get; set; }
	public string? Title { get; set; }
	//public string? Uri { get; set; }
	public string? Details { get; set; }
	public string? DetailsMD { get; set; }
	public int PrimaryScriptureId { get; set; }
	public DateTime CreateDate { get; set; }
	public int? DocBlobID { get; set; }
	public int? PdfBlobID { get; set; }
	public bool IsPlaceHolder { get; set; }
	public bool IsFavorite { get; set; }
	public int ExtraVerses { get; set; }
	public bool IsWordStudy { get; set; }
	public bool IsParasha { get; set; }
	public string? BCV { get; set; }
	public int BookID { get; set; }
	public int Chapter { get; set; }
	public int Verse { get; set; }
	
	//public string? BookAbrv { get; set; }

	public string IsFavoriteHtml
	{
		get
		{
			return $"{(IsFavorite ? "<span class='text-danger'><span class='fas fa-star'></span></span>" : "")}";
		}
	}

	public string RelatedVersesHtml
	{
		get
		{
			if (PrimaryScriptureId != 31102 && !String.IsNullOrEmpty(BCV))
			{
				if (ExtraVerses != 0)
				{
					return $"{BCV}-{Verse + ExtraVerses}";
				}
				else
				{
					return $"{BCV}";
				}

			}
			else
			{
				return "";
			}
		}
	}

}
