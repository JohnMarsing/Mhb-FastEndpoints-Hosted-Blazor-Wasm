namespace MyHebrewBible.Client.Features.Articles;

public static class Blobs
{
	public const string BaseUrl = "https://myhebrewbible5.blob.core.windows.net/mhb-container/";
	public const string ArticleUrl = BaseUrl + "Article/";
	public const string ImagesUrl = BaseUrl + "images/";
}


//href="@Model.DetailsVM.BaseLink@Model.DetailsVM.Article.WordFileName">
//public string BaseLink {	get { return Env.ArticleUrl; } }