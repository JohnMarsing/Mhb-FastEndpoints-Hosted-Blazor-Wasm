using Ardalis.SmartEnum;
using MyHebrewBible.Client.Helpers;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

[Flags]
public enum Permutation : int
{
	//None = 0,
	Torah = 1,
	Haftorah = 2,
	Brit = 4
	//, Comments = 8
}

public abstract class ShowSection : SmartEnum<ShowSection>
{

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
	public abstract string ButtonColor { get; }
	public abstract string HeaderColor { get; }

	public abstract string ButtonLabel { get; }
	public abstract Permutation Permutation { get; }
	#endregion

	#region Private Instantiation
	private sealed class TorahSE : ShowSection
	{
		public TorahSE() : base($"{nameof(Permutation.Torah)}", (int)Permutation.Torah) { }
		public override string ButtonLabel => "Torah";
		public override Permutation Permutation => Permutation.Torah;

		public override string Title => "Torah Verses";
		public override string ButtonColor => BtnColors.Primary;
		public override string HeaderColor => TextColors.Primary;
	}

	private sealed class HaftorahSE : ShowSection
	{
		public HaftorahSE() : base($"{nameof(Permutation.Haftorah)}", (int)Permutation.Haftorah) { }
		public override string ButtonLabel => "Haftorah";
		public override Permutation Permutation => Permutation.Haftorah;

		public override string Title => "Haftora Verses";
		public override string ButtonColor => BtnColors.Warning;
		public override string HeaderColor => TextColors.Warning;
	}

	private sealed class BritSE : ShowSection
	{
		public BritSE() : base($"{nameof(Permutation.Brit)}", (int)Permutation.Brit) { }
		public override string ButtonLabel => "Brit";
		public override Permutation Permutation => Permutation.Brit;

		public override string Title => "Brit Verses";
		public override string ButtonColor => BtnColors.Danger;
		public override string HeaderColor => TextColors.Danger;
	}

	#endregion
}