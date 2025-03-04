using Ardalis.SmartEnum;
using MyHebrewBible.Client.Helpers;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

[Flags]
public enum Permutation : int {Torah = 1,	Haftorah = 2,	Brit = 4}

/*
# Business rule
1. Torah has 1 and only 1 groups of verses 
2. Haftorah and Brit have a 0, 1 or m groups of verses
3. The presentation order of the Section groups is Torah, Haftorah, Brit
*/

public abstract class ShowSection : SmartEnum<ShowSection>
{
	#region Id's
	private static class Id
	{
		internal const int Torah = 1;
		internal const int Haftorah = 2;
		internal const int Brit = 3;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly ShowSection Torah = new TorahSE();
	public static readonly ShowSection Haftorah = new HaftorahSE();
	public static readonly ShowSection Brit = new BritSE();
	#endregion

	private ShowSection(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields 
	public abstract string Title { get; }
	public abstract string ButtonColorTOC { get; }
	public abstract string ButtonColorShowHide { get; }
	public abstract string HeaderColor { get; }
	public abstract string ButtonLabel { get; }
	public abstract Permutation VisibilityState { get; }
	public abstract string LineItemButtonColor { get; }

	//Properties
	public string CardHeader => $"<h3 class='{HeaderColor}'<b>{Title}</b></h3>";
	#endregion

	#region Private Instantiation
	private sealed class TorahSE : ShowSection
	{
		public TorahSE() : base($"{nameof(Id.Torah)}", Id.Torah) { }
		public override string ButtonLabel => "Torah";
		public override Permutation VisibilityState => Permutation.Torah;
		public override string Title => "Torah Verses";
		public override string ButtonColorTOC => BtnColors.Link;
		public override string ButtonColorShowHide => BtnColors.Success;
		public override string HeaderColor => TextColors.Success;
		public override string LineItemButtonColor => BtnOutlineColors.Success;
	}

	private sealed class HaftorahSE : ShowSection
	{
		public HaftorahSE() : base($"{nameof(Id.Haftorah)}", Id.Haftorah) { }
		public override string ButtonLabel => "Haftorah";
		public override Permutation VisibilityState => Permutation.Haftorah;
		public override string Title => "Haftorah Verses";
		public override string ButtonColorTOC => BtnColors.Link;
		public override string ButtonColorShowHide => BtnColors.Warning;
		public override string HeaderColor => TextColors.Warning;
		public override string LineItemButtonColor => BtnOutlineColors.Warning;
	}
	
	private sealed class BritSE : ShowSection
	{
		public BritSE() : base($"{nameof(Id.Brit)}", Id.Brit) { }
		public override string ButtonLabel => "Brit";
		public override Permutation VisibilityState => Permutation.Brit;
		public override string Title => "Brit Verses";
		public override string ButtonColorTOC => BtnColors.Link;
		public override string ButtonColorShowHide => BtnColors.Danger;
		public override string HeaderColor => TextColors.Danger;
		public override string LineItemButtonColor => BtnOutlineColors.Danger;
	}
	#endregion
}
// Ignore Spelling: Toc