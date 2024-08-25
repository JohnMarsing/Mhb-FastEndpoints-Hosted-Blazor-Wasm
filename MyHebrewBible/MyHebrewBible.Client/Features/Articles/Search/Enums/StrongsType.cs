using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Articles.Search.Enums;

public abstract class StrongsType : SmartEnum<StrongsType>
{
	#region Id's
	private static class Id
	{
		internal const int Hebrew = 1;
		internal const int Greek = 2;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly StrongsType Hebrew = new HebrewSE();
	public static readonly StrongsType Greek = new GreekSE();
	#endregion

	private StrongsType(string name, int value) : base(name, value) { } // Constructor

	#region Private Instantiation

	#region Extra Fields
	public abstract string Title { get; }
	public abstract string InputNumberId { get; }
	public abstract string PlaceHolder { get; }
	#endregion

	private sealed class HebrewSE : StrongsType
	{
		public HebrewSE() : base($"{nameof(Id.Hebrew)}", Id.Hebrew) { }
		public override string InputNumberId => $"{nameof(Id.Hebrew).ToLower()}-id";
		public override string PlaceHolder => "H1234";
		public override string Title => "Strong's: H[1234]";		//<h5 class="card-title">Strong's: H[1234]</h5>
	}

	private sealed class GreekSE : StrongsType
	{
		public GreekSE() : base($"{nameof(Id.Greek)}", Id.Greek) { }
		public override string InputNumberId => $"{nameof(Id.Greek).ToLower()}-id";
		public override string PlaceHolder => "G1234";
		public override string Title => "Strong's: G[1234]";  
	}

	#endregion

}



