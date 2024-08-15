namespace MyHebrewBible.Client;

public class Application
{
	public const string Name = "My Hebrew Bible";
	public const string LongDescription = "My Hebrew Bible Blazor 8 Wasm";
	public const string ConnectionStringName = "Database"; //OsisXmlToSql
	public const string ErrorView = "Error";
	public const string DefaultTheme = "Cerulean";
	public const string BaseUrlMHB = "www.MyHebrewBible.com/";
	public const string BaseUrlMHB2 = "https://MyHebrewBible.com/";
}

public static class BlobContent
{
	private const string images = "https://myhebrewbible5.blob.core.windows.net/mhb-container/images/";
	private const string articles = "https://myhebrewbible5.blob.core.windows.net/mhb-container/article/";
	private const string fonts = "https://myhebrewbible5.blob.core.windows.net/mhb-container/fonts/";

	public static string ImagesUrl(string blob)
	{
		return images + blob;
	}

	public static string ArticlesUrl(string blob)
	{
		return articles + blob;
	}

	public static string FontsUrl(string blob)
	{
		return fonts + blob;
	}
}

