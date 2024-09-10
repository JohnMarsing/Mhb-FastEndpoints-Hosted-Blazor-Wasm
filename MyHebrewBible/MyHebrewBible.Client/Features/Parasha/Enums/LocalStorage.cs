using Ardalis.SmartEnum;
using MyHebrewBible.Client.Features.Parasha.TopSection;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

public abstract class LocalStorage : SmartEnum<LocalStorage>
{

	#region Id's
	private static class Id
	{
		internal const int Torah = 1;
		internal const int Haftorah = 2;
		internal const int Brit = 3;
		internal const int Grid = 4;

	}
	#endregion

	#region  Declared Public Instances
	public static readonly LocalStorage Torah = new TorahSE();
	public static readonly LocalStorage Haftorah = new HaftorahSE();
	public static readonly LocalStorage Brit = new BritSE();
	public static readonly LocalStorage Grid = new GridSE();

	#endregion

	private LocalStorage(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Key { get; }
	#endregion

	#region Private Instantiation

	private sealed class TorahSE : LocalStorage
	{
		public TorahSE() : base($"{nameof(Id.Torah)}", Id.Torah) { }
		public override string Key => $"parasha-{nameof(Id.Torah).ToLower()}";
	}

	private sealed class HaftorahSE : LocalStorage
	{
		public HaftorahSE() : base($"{nameof(Id.Haftorah)}", Id.Haftorah) { }
		public override string Key => $"parasha-{nameof(Id.Haftorah).ToLower()}";
	}

	private sealed class BritSE : LocalStorage
	{
		public BritSE() : base($"{nameof(Id.Brit)}", Id.Brit) { }
		public override string Key => $"parasha-{nameof(Id.Brit).ToLower()}";
	}

	private sealed class GridSE : LocalStorage
	{
		public GridSE() : base($"{nameof(Id.Grid)}", Id.Grid) { }
		public override string Key => $"parasha-{nameof(Id.Grid).ToLower()}";
	}

	#endregion
}