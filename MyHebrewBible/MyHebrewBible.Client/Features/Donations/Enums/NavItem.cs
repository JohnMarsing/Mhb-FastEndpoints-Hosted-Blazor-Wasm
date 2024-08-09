using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Donations.Enums;

public abstract class NavItem : SmartEnum<NavItem>
{
	#region Id's
	private static class Id
	{
		internal const int Stripe = 1;  
		internal const int Zelle = 2;
		internal const int Check = 3;
		internal const int QRC = 4;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly NavItem Stripe = new StripeSE();
	public static readonly NavItem Zelle = new ZelleSE();
	public static readonly NavItem Check = new CheckSE();
	public static readonly NavItem QRC = new QRCSE();
	// SE=SmartEnum
	#endregion

	private NavItem(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract string ButtonId { get; }
	public abstract string Target { get; }
	public abstract string AriaControls { get; }
	//public abstract string Icon { get; }
	#endregion

	#region Private Instantiation
	private sealed class StripeSE : NavItem
	{
		public StripeSE() : base($"{nameof(Id.Stripe)}", Id.Stripe) { }
		public override string ButtonId => $"{nameof(Id.Stripe).ToLower()}-tab"; 
		public override string Target => $"#{nameof(Id.Stripe).ToLower()}";
		public override string AriaControls => $"{nameof(Id.Stripe).ToLower()}";

	}

	private sealed class ZelleSE : NavItem
	{
		public ZelleSE() : base($"{nameof(Id.Zelle)}", Id.Zelle) { }
		public override string ButtonId => $"{nameof(Id.Zelle).ToLower()}-tab";
		public override string Target => $"#{nameof(Id.Zelle).ToLower()}";
		public override string AriaControls => $"{nameof(Id.Zelle).ToLower()}";
	}

	private sealed class CheckSE : NavItem
	{
		public CheckSE() : base($"{nameof(Id.Check)}", Id.Check) { }
		public override string ButtonId => $"{nameof(Id.Check).ToLower()}-tab";
		public override string Target => $"#{nameof(Id.Check).ToLower()}";
		public override string AriaControls => $"{nameof(Id.Check).ToLower()}";
	}

	private sealed class QRCSE : NavItem
	{
		public QRCSE() : base($"{nameof(Id.QRC)}", Id.QRC) { }
		public override string ButtonId => $"{nameof(Id.QRC).ToLower()}-tab";
		public override string Target => $"#{nameof(Id.QRC).ToLower()}";
		public override string AriaControls => $"{nameof(Id.QRC).ToLower()}";
	}


	#endregion

	// Ignore Spelling: Zelle, Nav QRC QRCSE
}
