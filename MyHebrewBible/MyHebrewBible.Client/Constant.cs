namespace MyHebrewBible.Client;

public static class Global
{
	public const string ToastShowError = "An invalid operation occurred, contact your administrator";
}

public static class Emails
{
	public static class Donations
	{
		public static string Email() { return "donations@myhebrewbible.com"; }
	}

	public static class Info
	{
		public static string Email() { return "info@myhebrewbible.com"; }
		public static string Subject = "?Subject=Questions";
	}

}


public static class SocialMedia
{
	public static class YouTube
	{
		private const string _channelId = "JohnMarsing"; // Sample
		private const string _baseFeedUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=";
		private const string _baseNormalUrl = "https://www.youtube.com/channel/";
		private const string _baseSearchUrl = "https://www.youtube.com/results?search_query=john+marsing";
		public static string YouTubeFeed()
		{
			return _baseFeedUrl + _channelId;
		}

		public static string YouTubeNormal()
		{
			return _baseNormalUrl + _channelId;
		}

		public static string YouTubeFeatured()
		{
			return _baseNormalUrl + _channelId + "/featured";
		}

		public static string YouTubeSearch()
		{
			return _baseSearchUrl;
		}

	}
}


//public static class Utc
//{
//	public const int ArizonaUtcMinus7 = -7;
//}

//public static class Blobs
//{
//	 MyHebrewBible.Client\Application.cs ! BlobContent
//}

public static class DateFormat
{
	public const string ddd_mm_dd = "ddd, MM/dd";  //ddd, MM/dd/yyyy
	public const string mm_dd = "MM/dd";
	public const string MM_dd_HH_mm = "MM/dd HH:mm";
	public const string MM_dd_hh_mm = "MM/dd hh:mm";
	public const string dd = "dd";
	public const string dddd_dd_MMMM = "dddd, dd MMMM";
	public const string dddd_MMMM_dd = "dddd, MMMM dd ";
	public const string ddd_MMMM_dd_YYYY = "ddd, MMMM dd, yyyy";
	public const string ddd_MMM_dd_YYYY = "ddd, MMM dd, yyyy";
	public const string YYYY_MM_DD = "yyyy-MM-dd";
	public const string FeastDayPlanner = "ddd, MMM dd";
	public const string YYYY_MM_DD_hh_mm = "yyyy-MM-dd hh:mm";
}

//public static class CurrencyFormat
//{
//	public const string NoCents = "{0:C0}"; // doesn't work use a property like below
//	/*
//		public string AmountNoCents { get { return String.Format("{0:C0}", Amount); }	}
//	*/
//}
