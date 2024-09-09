using Ardalis.SmartEnum;
using MyHebrewBible.Client.Helpers;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

public abstract class VerseGroup : SmartEnum<VerseGroup>
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
	public static readonly VerseGroup Torah = new TorahSE();
	public static readonly VerseGroup Haftorah = new HaftorahSE();
	public static readonly VerseGroup Brit = new BritSE();
	// SE=SmartEnum

	#endregion

	private VerseGroup(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Title { get; }
	public abstract string ButtonColor { get; }
	public abstract string HeaderColor { get; }
	#endregion

	#region Private Instantiation

	private sealed class TorahSE : VerseGroup
	{
		public TorahSE() : base($"{nameof(Id.Torah)}", Id.Torah) { }
		public override string Title => "Torah Verses";
		public override string ButtonColor => Anchors.BtnColors.Primary;
		public override string HeaderColor => TextColors.Primary;
	}
	private sealed class HaftorahSE : VerseGroup
	{
		public HaftorahSE() : base($"{nameof(Id.Haftorah)}", Id.Haftorah) { }
		public override string Title => "Haftorah Verses";
		public override string ButtonColor => Anchors.BtnColors.Warning;
		public override string HeaderColor => TextColors.Warning;
	}
	private sealed class BritSE : VerseGroup
	{
		public BritSE() : base($"{nameof(Id.Brit)}", Id.Brit) { }
		public override string Title => "Brit Verses";
		public override string ButtonColor => Anchors.BtnColors.Danger;
		public override string HeaderColor => TextColors.Danger;
	}

	#endregion
}