using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Enums;

public abstract class TorahBookFilter : SmartEnum<TorahBookFilter>
{
	#region  Declared Public Instances
	public static readonly TorahBookFilter All = new AllSE();
	public static readonly TorahBookFilter Genesis = new GenesisSE();
	public static readonly TorahBookFilter Exodus = new ExodusSE();
	public static readonly TorahBookFilter Leviticus = new LeviticusSE();
	public static readonly TorahBookFilter Numbers = new NumbersSE();
	public static readonly TorahBookFilter Deuteronomy = new DeuteronomySE();
	#endregion

	private TorahBookFilter(string name, int value) : base(name, value) { } // Constructor

	#region Private Instantiation
	private sealed class AllSE : TorahBookFilter
	{
		public AllSE() : base("All", 0) { }
	}

	private sealed class GenesisSE : TorahBookFilter
	{
		public GenesisSE() : base(BibleBook.Genesis.Name, BibleBook.Genesis.Value) { }
	}

	private sealed class ExodusSE : TorahBookFilter
	{
		public ExodusSE() : base(BibleBook.Exodus.Name, BibleBook.Exodus.Value) { }
	}

	private sealed class LeviticusSE : TorahBookFilter
	{
		public LeviticusSE() : base(BibleBook.Leviticus.Name, BibleBook.Leviticus.Value) { }
	}

	private sealed class NumbersSE : TorahBookFilter
	{
		public NumbersSE() : base(BibleBook.Numbers.Name, BibleBook.Numbers.Value) { }
	}

	private sealed class DeuteronomySE : TorahBookFilter
	{
		public DeuteronomySE() : base(BibleBook.Deuteronomy.Name, BibleBook.Deuteronomy.Value) { }
	}
	#endregion

}


