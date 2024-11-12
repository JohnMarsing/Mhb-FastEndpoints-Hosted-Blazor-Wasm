namespace MyHebrewBible.Client.Features.AlephTav.Enums;

using Ardalis.SmartEnum;

public abstract class Filter : SmartEnum<Filter>
{

	#region Id's
	private static class Id
	{
		// Class ArticleList
		//internal const int All = 0;
		internal const int Summary = 1;       
		internal const int All613 = 2;    
	}
	#endregion

	#region  Declared Public Instances
	//public static readonly Filter All = new AllSE();
	public static readonly Filter Summary = new SummarySE();
	public static readonly Filter All613 = new All613SE();
	#endregion

	private Filter(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Title { get; }
	//public abstract string Where { get; }
	#endregion

	#region Private Instantiation

	//private sealed class AllSE : Filter
	//{
	//	public AllSE() : base($"{nameof(Id.All)}", Id.All) { }
	//	public override string Title => "All";
	//	public override string Where => ""; 
	//}

	private sealed class SummarySE : Filter
	{
		public SummarySE() : base($"{nameof(Id.Summary)}", Id.Summary) { }
		public override string Title => "Summary";
		//public override string Where => " WHERE zzz ";
	}

	private sealed class All613SE : Filter
	{
		public All613SE() : base($"{nameof(Id.All613)}", Id.All613) { }
		public override string Title => "See all 634";
		//public override string Where => " WHERE zzz ";
	}

	#endregion
}
