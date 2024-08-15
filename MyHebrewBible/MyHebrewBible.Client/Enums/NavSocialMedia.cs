using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Enums;

public abstract class NavSocialMedia : SmartEnum<NavSocialMedia>
{

	#region Id's
	private static class Id
	{
		internal const int YouTube = 1;
		internal const int GitHub = 2;
		internal const int Twitter = 3;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly NavSocialMedia YouTube = new YouTubeSE();
	public static readonly NavSocialMedia GitHub = new GitHubSE();
	public static readonly NavSocialMedia Twitter = new TwitterSE();
	#endregion

	private NavSocialMedia(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Href { get; }
	public abstract string Title { get; }
	public abstract string Icon { get; }
	#endregion

	#region Private Instantiation

	private const string _channelId = "@JohnMarsing";  
	private sealed class YouTubeSE : NavSocialMedia
	{
		public YouTubeSE() : base($"{nameof(Id.YouTube)}", Id.YouTube) { }
		public override string Href => $"https://www.youtube.com/channel/{_channelId}";
		public override string Title => "YouTube";
		public override string Icon => "fab fa-youtube";
	}

	private sealed class GitHubSE : NavSocialMedia
	{
		public GitHubSE() : base($"{nameof(Id.GitHub)}", Id.GitHub) { }
		public override string Href => "https://github.com/JohnMarsing";
		public override string Title => "GitHub";
		public override string Icon => "fab fa-github";
	}

	private sealed class TwitterSE : NavSocialMedia
	{
		public TwitterSE() : base($"{nameof(Id.Twitter)}", Id.Twitter) { }
		public override string Href => "https://twitter.com/Torahlawform";
		public override string Title => "Twitter";
		public override string Icon => "fab fa-twitter";
	}
	#endregion

}
// Ignore Spelling: Nav  Href