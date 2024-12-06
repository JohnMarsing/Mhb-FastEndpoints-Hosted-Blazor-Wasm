namespace MyHebrewBible.Client.Features.Articles;

public static class Blobs
{
	public const string BaseUrl = "https://myhebrewbible5.blob.core.windows.net/mhb-container/";
	public const string ArticleUrl = BaseUrl + "Article/";
	public const string ImagesUrl = BaseUrl + "images/";
}

public static class Helper
{
	public static string GetAnchor(int id, string description)
	{
		return $"<a href='/Article/{id}'>{description}</a> <i class='fas fa-pencil-alt'></i>";
	}

}

