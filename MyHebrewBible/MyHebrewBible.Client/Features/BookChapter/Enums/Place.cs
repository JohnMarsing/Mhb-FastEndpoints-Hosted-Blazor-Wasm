using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.BookChapter.Enums;

/* ToDo: Determine if this should be replaced with StepState */
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
	public abstract string ShortName { get; }
	public abstract int DigitValue { get; }
	public abstract bool HasParent { get; }
	public abstract bool HasChild { get; }
	#endregion


	#region Private Instantiation

	private sealed class HundredsSE : Place
	{
		public HundredsSE() : base($"{nameof(Id.Hundreds)}", Id.Hundreds) { }
		public override string ShortName => "h";
		public override int DigitValue => 100;	
		public override bool HasParent => false ;
		public override bool HasChild => true;
	}

	private sealed class TensSE : Place
	{
		public TensSE() : base($"{nameof(Id.Tens)}", Id.Tens) { }
		public override string ShortName => "t";
		public override int DigitValue => 10;	
		public override bool HasParent => true;
		public override bool HasChild => true;
	}

	private sealed class OnesSE : Place
	{
		public OnesSE() : base($"{nameof(Id.Ones)}", Id.Ones) { }
		public override string ShortName => "o";
		public override int DigitValue => 1;
		public override bool HasParent => true;
		public override bool HasChild => false;
	}
	#endregion
}

public static class PlaceHelper
{
	public const int NotSetValue = -1;	
	//public static int NotSet() { return -1; // const int NotSet = -1; 	}
}

/*
	public abstract bool UsedByUI { get; }
	public abstract bool DisplayAsCompleted(Place2 status);
	public abstract bool DisplayRegistrationToggleButton { get; }
	public abstract string Icon { get; }

			public override bool UsedByUI => true;
		public override string Icon => "fas fa-check";

		public override bool DisplayRegistrationToggleButton => false;

		public override bool DisplayAsCompleted(Place2 status)
		{
			return status == Place2.NeedBook ||
						 //status == StatusBCV.EmailNotConfirmed ||
						 //status == StatusBCV.AgreementNotSigned ||
						 //status == StatusBCV.StartRegistration ||
						 //status == StatusBCV.Payment ||
						 status == Place2.NeedChapter;
		}
 
 */
