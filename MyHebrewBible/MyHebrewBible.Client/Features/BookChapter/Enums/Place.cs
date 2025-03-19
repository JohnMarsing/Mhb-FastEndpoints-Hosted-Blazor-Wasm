using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.BookChapter.Enums;

public abstract class Place : SmartEnum<Place>
{
	#region Id's
	
	private static class Id
	{
		internal const int Hundreds = 1;
		internal const int Tens = 2;
		internal const int Ones = 3;
	}
	
	#endregion

	#region  Declared Public Instances
	public static readonly Place Hundreds = new HundredsSE();
	public static readonly Place Tens = new TensSE();
	public static readonly Place Ones = new OnesSE();
	// SE=SmartEnum
	#endregion

	private Place(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract string ColumnName { get; }
	
	//Properties
	#endregion


	#region Private Instantiation

	private sealed class HundredsSE : Place
	{
		public HundredsSE() : base($"{nameof(Id.Hundreds)}", Id.Hundreds) { }
		public override string ColumnName => "100s";
	}

	private sealed class TensSE : Place
	{
		public TensSE() : base($"{nameof(Id.Tens)}", Id.Tens) { }
		public override string ColumnName => nameof(Id.Tens);
	}

	private sealed class OnesSE : Place
	{
		public OnesSE() : base($"{nameof(Id.Ones)}", Id.Ones) { }
		public override string ColumnName => nameof(Id.Ones);
	}
	#endregion
}

