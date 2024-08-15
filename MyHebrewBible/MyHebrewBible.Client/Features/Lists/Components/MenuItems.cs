using Ardalis.SmartEnum;
using PageLink = MyHebrewBible.Client.Enums.Nav;

namespace MyHebrewBible.Client.Features.Lists.Components;

public abstract class MenuItems : SmartEnum<MenuItems>
{
	#region Id's
	private static class Id
	{
		internal const int Home = 0;
		internal const int Emendations = 1;
		internal const int Feasts = 2;
		internal const int JotAndTittle = 3;
		internal const int MapCanaanOT = 4;
		internal const int Mitzvot = 5;
		internal const int ParablesOfYeshua = 6;
		internal const int PeopleKilled = 7;
		internal const int TimeLine = 8;
		internal const int YosephAndYeshuaComparison = 9;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly MenuItems Home = new HomeSE();
	public static readonly MenuItems Emendations = new EmendationsSE();
	public static readonly MenuItems Feasts = new FeastsSE();
	public static readonly MenuItems JotAndTittle = new JotAndTittleSE();
	public static readonly MenuItems MapCanaanOT = new MapCanaanOTSE();
	public static readonly MenuItems Mitzvot = new MitzvotSE();
	public static readonly MenuItems ParablesOfYeshua = new ParablesOfYeshuaSE();
	public static readonly MenuItems PeopleKilled = new PeopleKilledSE();
	public static readonly MenuItems TimeLine = new TimeLineSE();
	public static readonly MenuItems YosephAndYeshuaComparison = new YosephAndYeshuaComparisonSE();
	// SE=SmartEnum
	#endregion

	private MenuItems(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract string Icon { get; }
	public abstract string Title { get; }
	public abstract string Page { get; }
	#endregion

	#region Private Instantiation

	private sealed class HomeSE : MenuItems
	{
		public HomeSE() : base($"{nameof(Id.Home)}", Id.Home) { }
		public override string Icon => "fa fa-table";
		public override string Title => nameof(Id.Home);
		public override string Page => PageLink.BibleList.Index;
	}

	private sealed class EmendationsSE : MenuItems
	{
		public EmendationsSE() : base($"{nameof(Id.Emendations)}", Id.Emendations) { }
		public override string Icon => "fa fa-table";
		public override string Title => nameof(Id.Emendations);
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.Emendations);
	}

	private sealed class FeastsSE : MenuItems
	{
		public FeastsSE() : base($"{nameof(Id.Feasts)}", Id.Feasts) { }
		public override string Icon => "fa fa-Feasts";
		public override string Title => nameof(Id.Feasts);
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.Feasts); 
	}

	private sealed class JotAndTittleSE : MenuItems
	{
		public JotAndTittleSE() : base($"{nameof(Id.JotAndTittle)}", Id.JotAndTittle) { }
		public override string Icon => "fa fa-plane";
		public override string Title => "Jots and Tittles";
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.JotAndTittle); 
	}

	private sealed class MapCanaanOTSE : MenuItems
	{
		public MapCanaanOTSE() : base($"{nameof(Id.MapCanaanOT)}", Id.MapCanaanOT) { }
		public override string Icon => "fas fa-map";
		public override string Title => "Map of Canaan";
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.MapCanaanOT); 
	}

	private sealed class MitzvotSE : MenuItems
	{
		public MitzvotSE() : base($"{nameof(Id.Mitzvot)}", Id.Mitzvot) { }
		public override string Icon => "fas fa-map";
		public override string Title => "Mitzvot";
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.Mitzvot);
	}

	private sealed class ParablesOfYeshuaSE : MenuItems
	{
		public ParablesOfYeshuaSE() : base($"{nameof(Id.ParablesOfYeshua)}", Id.ParablesOfYeshua) { }
		public override string Icon => "fa fa-blind";
		public override string Title => "Parables of Yeshua";
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.ParablesOfYeshua);
	}

	private sealed class PeopleKilledSE : MenuItems
	{
		public PeopleKilledSE() : base($"{nameof(Id.PeopleKilled)}", Id.PeopleKilled) { }
		public override string Icon => "fas fa-battery-empty"; 
		public override string Title => "People Killed";
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.PeopleKilled);
	}

	private sealed class TimeLineSE : MenuItems
	{
		public TimeLineSE() : base($"{nameof(Id.TimeLine)}", Id.TimeLine) { }
		public override string Icon => "fas fa-clock";
		public override string Title => "Timeline";
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.TimeLine);
	}

	private sealed class YosephAndYeshuaComparisonSE : MenuItems
	{
		public YosephAndYeshuaComparisonSE() : base($"{nameof(Id.YosephAndYeshuaComparison)}", Id.YosephAndYeshuaComparison) { }
		public override string Icon => "fa fa-bars";
		public override string Title => "Yoseph and Yeshua Comparison";
		public override string Page => PageLink.BibleList.Index + "/" + nameof(Id.YosephAndYeshuaComparison);
	}

	#endregion
}

