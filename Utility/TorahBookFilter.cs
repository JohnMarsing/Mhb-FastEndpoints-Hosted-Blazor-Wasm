using Ardalis.SmartEnum;

namespace Utility;

public abstract class TorahBookFilter : SmartEnum<TorahBookFilter>
{
	#region  Declared Public Instances
	//public static readonly TorahBookFilter All = new AllSE();
	public static readonly TorahBookFilter Genesis = new GenesisSE();
	public static readonly TorahBookFilter Exodus = new ExodusSE();
	public static readonly TorahBookFilter Leviticus = new LeviticusSE();
	public static readonly TorahBookFilter Numbers = new NumbersSE();
	public static readonly TorahBookFilter Deuteronomy = new DeuteronomySE();
	#endregion

	private TorahBookFilter(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract BibleBook BibleBook { get; }
	public abstract string Abrv { get; }
	#endregion

	#region Private Instantiation
	//private sealed class AllSE : TorahBookFilter
	//{
	//	public AllSE() : base("All", 0) { }
	//	public override BibleBook BibleBook => null;
	//}

	private sealed class GenesisSE : TorahBookFilter
	{
		public GenesisSE() : base(BibleBook.Genesis.Name, BibleBook.Genesis.Value) { }
		public override BibleBook BibleBook => BibleBook.Genesis;
		public override string Abrv =>  this.BibleBook.Abrv;
	}

	private sealed class ExodusSE : TorahBookFilter
	{
		public ExodusSE() : base(BibleBook.Exodus.Name, BibleBook.Exodus.Value) { }
		public override BibleBook BibleBook => BibleBook.Exodus;
		public override string Abrv =>  this.BibleBook.Abrv;
	}

	private sealed class LeviticusSE : TorahBookFilter
	{
		public LeviticusSE() : base(BibleBook.Leviticus.Name, BibleBook.Leviticus.Value) { }
		public override BibleBook BibleBook => BibleBook.Leviticus;
		public override string Abrv => this.BibleBook.Abrv;
	}

	private sealed class NumbersSE : TorahBookFilter
	{
		public NumbersSE() : base(BibleBook.Numbers.Name, BibleBook.Numbers.Value) { }
		public override BibleBook BibleBook => BibleBook.Numbers;
		public override string Abrv => this.BibleBook.Abrv;
	}

	private sealed class DeuteronomySE : TorahBookFilter
	{
		public DeuteronomySE() : base(BibleBook.Deuteronomy.Name, BibleBook.Deuteronomy.Value) { }
		public override BibleBook BibleBook => BibleBook.Deuteronomy;
		public override string Abrv => this.BibleBook.Abrv;
	}
	#endregion

}

// Ignore Spelling: Abrv
