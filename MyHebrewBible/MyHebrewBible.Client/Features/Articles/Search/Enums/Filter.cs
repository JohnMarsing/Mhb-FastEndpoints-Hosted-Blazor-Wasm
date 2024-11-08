namespace MyHebrewBible.Client.Features.Articles.Search.Enums;
using Ardalis.SmartEnum;

public abstract class Filter : SmartEnum<Filter>
{

	#region Id's
	private static class Id
	{
																				// Class ArticleList
		internal const int All = 0;
		internal const int Parasha = 1;				// IsParasha
		internal const int WordStudy = 2;			// IsWordStudy
		internal const int Favorite = 3;			// IsFavorite
		internal const int PlaceHolder = 4;		// IsPlaceHolder
		internal const int Basic = 5;					// 
	}
	#endregion

	#region  Declared Public Instances
	public static readonly Filter All = new AllSE();
	public static readonly Filter Parasha = new ParashaSE();
	public static readonly Filter WordStudy = new WordStudySE();
	public static readonly Filter Favorite = new FavoriteSE();
	public static readonly Filter PlaceHolder = new PlaceHolderSE();
	public static readonly Filter Basic = new BasicSE();
	#endregion

	private Filter(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Title { get; }
	public abstract string Where { get; }
	#endregion

	#region Private Instantiation

	private sealed class AllSE : Filter
	{
		public AllSE() : base($"{nameof(Id.All)}", Id.All) { }
		public override string Title => "All";
		public override string Where => "";  // IsFavorite, IsPlaceHolder, IsParasha, IsWordStudy
	}

	private sealed class ParashaSE : Filter
	{
		public ParashaSE() : base($"{nameof(Id.Parasha)}", Id.Parasha) { }
		public override string Title => "Parasha";
		public override string Where => " WHERE IsParasha=1 ";
	}

	private sealed class WordStudySE : Filter
	{
		public WordStudySE() : base($"{nameof(Id.WordStudy)}", Id.WordStudy) { }
		public override string Title => "Word Study";
		public override string Where => " WHERE IsWordStudy=1 ";
	}

	private sealed class FavoriteSE : Filter
	{
		public FavoriteSE() : base($"{nameof(Id.Favorite)}", Id.Favorite) { }
		public override string Title => "Favorite";
		public override string Where => " WHERE IsFavorite=1 ";

	}

	private sealed class PlaceHolderSE : Filter
	{
		public PlaceHolderSE() : base($"{nameof(Id.PlaceHolder)}", Id.PlaceHolder) { }
		public override string Title => "Place Holder"; 
		public override string Where => " WHERE IsPlaceHolder=1 ";
	}

	private sealed class BasicSE : Filter
	{
		public BasicSE() : base($"{nameof(Id.Basic)}", Id.Basic) { }
		public override string Title => "Basic"; 
		public override string Where => " WHERE IsPlaceHolder=0 AND IsFavorite=0 AND IsWordStudy=0 AND IsParasha=0 ";
	}

	#endregion
}