using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.Haggadah.Enums;

public abstract class Content : SmartEnum<Content>
{
	#region Id's
	private static class Id
	{
		internal const int Introduction = 1;
		internal const int FirstPassover = 2;
		internal const int PassoverDeliverance = 3;
		internal const int StoryOfRedemption = 4;
		internal const int Matzah = 5;
		internal const int FirstCup = 6;
		internal const int SecondCup = 7;
		internal const int ThirdCup = 8;
		internal const int FourthCup = 9;
		internal const int Charoset = 10;
		internal const int Dinner = 11;
		internal const int FifthCup = 12;
		internal const int SixthCup = 13;
		internal const int SeventhCup = 14;
		internal const int NextYear = 15;
	}
	#endregion


	#region  Declared Public Instances
	public static readonly Content Introduction = new IntroductionSE();
	public static readonly Content FirstPassover = new FirstPassoverSE();
	public static readonly Content PassoverDeliverance = new PassoverDeliveranceSE();
	public static readonly Content StoryOfRedemption = new StoryOfRedemptionSE();
	public static readonly Content Matzah = new MatzahSE();
	public static readonly Content FirstCup = new FirstCupSE();
	public static readonly Content SecondCup = new SecondCupSE();
	public static readonly Content ThirdCup = new ThirdCupSE();
	public static readonly Content FourthCup = new FourthCupSE();
	public static readonly Content Charoset = new CharosetSE();
	public static readonly Content Dinner = new DinnerSE();
	public static readonly Content FifthCup = new FifthCupSE();
	public static readonly Content SixthCup = new SixthCupSE();
	public static readonly Content SeventhCup = new SeventhCupSE();
	public static readonly Content NextYear = new NextYearSE();

	#endregion

	private Content(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	//public abstract int Section { get; }
	public abstract MarkupString EngTitle { get; }
	public abstract MarkupString EspTitle { get; }
	#endregion

	#region Private Instantiation

	private sealed class IntroductionSE : Content
	{
		public IntroductionSE() : base($"{nameof(Id.Introduction)}", Id.Introduction) { }
		//public override int Section => 1;
		public override MarkupString EngTitle => (MarkupString)(@"
			<h2 class='text-center text-danger fw-bold mb-3'>
				<span class='text-dark'>Messiah, Savior, Redeemer</span>
			</h2>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h2 class='text-center text-danger fw-bold mb-3'>
				<span class='text-dark'>Mesías, Salvador, Redentor</span>
			</h2>
			");
	}

	private sealed class FirstPassoverSE : Content
	{
		public FirstPassoverSE() : base($"{nameof(Id.FirstPassover)}", Id.FirstPassover) { }
		//public override int Section => 2;	
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				<span class='text-dark'>The First Passover</span>
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				<span class='text-dark'>La Primera Pascua</span>
			</h3>
			");
	}

	private sealed class PassoverDeliveranceSE : Content
	{
		//public override int Section => 3;
		public PassoverDeliveranceSE() : base($"{nameof(Id.PassoverDeliverance)}", Id.PassoverDeliverance) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				<span class='text-dark'>THIS  IS THE PASSOVER DELIVERANCE  OF Yehovah!</span>
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				<span class='text-dark'>¡ESTA ES LA LIBERACIÓN DE LA PASCUA DE YAHVÉ!</span>
			</h3>
			");
	}

	private sealed class StoryOfRedemptionSE : Content
	{
		public StoryOfRedemptionSE() : base($"{nameof(Id.StoryOfRedemption)}", Id.StoryOfRedemption) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				<span class='text-dark'>The Story and Redemption of Ephraim</span>
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				<span class='text-dark'>La Historia y Redención de Efraím</span>
			</h3>
			");
	}

	private sealed class MatzahSE : Content
	{
		public MatzahSE() : base($"{nameof(Id.Matzah)}", Id.Matzah) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				<span class='text-dark'>MATZAH</span>
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				<span class='text-dark'>MATZÁ</span>
			</h3>
			");
	}

	private sealed class FirstCupSE : Content
	{
		public FirstCupSE() : base($"{nameof(Id.FirstCup)}", Id.FirstCup) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				First Cup of Ephraim’s Redemption
				<br /><br />
				The CUP of Messiah(the Renewed Covenant)
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Primera Copa de la Redención de Efraím
				<br /><br />
				La COPA del Mesías (el Nuevo Pacto)
			</h3>
			");
	}

	private sealed class SecondCupSE : Content
	{
		public SecondCupSE() : base($"{nameof(Id.SecondCup)}", Id.SecondCup) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Second Cup of Ephraim’s Redemption 
				<br /><br />
				The CUP OF MERCY 
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Segunda Copa de la Redención de Efraím  
				<br /><br />
				La COPA DE LA MISERICORDIA
			</h3>
			");
	}

	private sealed class ThirdCupSE : Content
	{
		public ThirdCupSE() : base($"{nameof(Id.ThirdCup)}", Id.ThirdCup) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Third Cup of Ephraim’s Redemption 
				<br /><br />
				The CUP OF IDENTITY 
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Tercera COPA DE LA REDENCIÓN DE Efraím  
				<br /><br />
				LA COPA DE LA IDENTIDAD
			</h3>
			");
	}

	private sealed class FourthCupSE : Content
	{
		public FourthCupSE() : base($"{nameof(Id.FourthCup)}", Id.FourthCup) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Fourth Cup of Ephraim’s Redemption
				<br /><br />
				The CUP of God's Instructions 
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Cuarta Copa de la Redención de Efraím
				<br /><br />
				La COPA de las Instrucciones de Dios
			</h3>
			");
	}


	private sealed class CharosetSE : Content
	{
		public CharosetSE() : base($"{nameof(Id.Charoset)}", Id.Charoset) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>CHAROSET</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>CHAROSET</h3>
			");
	}

	private sealed class DinnerSE : Content
	{
		public DinnerSE() : base($"{nameof(Id.Dinner)}", Id.Dinner) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>DINNER IS SERVED</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>SE SIRVE LA CENA</h3>
			");
	}


	private sealed class FifthCupSE : Content
	{
		public FifthCupSE() : base($"{nameof(Id.FifthCup)}", Id.FifthCup) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Fifth Cup of Ephraim’s Redemption
				<br /><br />
				The CUP of Holiness/Fidelity
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Quinta Copa de la Redención de Efraím
				<br /><br />
				La COPA de Santidad/Fidelidad
			</h3>
			");
	}

	private sealed class SixthCupSE : Content
	{
		public SixthCupSE() : base($"{nameof(Id.SixthCup)}", Id.SixthCup) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Sixth Cup of Ephraim’s Redemption 
				<br /><br />
				The CUP of Reconciliation 
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Sexta Copa de la Redención de Efraím  
				<br /><br />
				La COPA de la Reconciliación
			</h3>
			");
	}

	private sealed class SeventhCupSE : Content
	{
		public SeventhCupSE() : base($"{nameof(Id.SeventhCup)}", Id.SeventhCup) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Seventh Cup of Ephraim’s Redemption 
				<br /><br />
				The CUP of RETURN
			</h3>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>
				Séptima COPA DE LA REDENCIÓN DE Efraím  
				<br /><br />
				La COPA del RETORNO
			</h3>
			");
	}

	private sealed class NextYearSE : Content
	{
		public NextYearSE() : base($"{nameof(Id.NextYear)}", Id.NextYear) { }
		public override MarkupString EngTitle => (MarkupString)(@"
			<h3 class='text-center'>Next Year</h3>
			<h2 class='mt-5 text-center'>
				May He come quickly, soon, and in our day
				<br />
				Next Year in Jerusalem
			</p>
			");
		public override MarkupString EspTitle => (MarkupString)(@"
			<h3 class='text-center'>Próximo Año</h3>
			<h2 class='mt-5 text-center'>
				Que venga rápidamente, pronto, y en nuestro día El
				<br />
				próximo año en Jerusalén
			</p>
			
			");
	}

	#endregion
}
//<sup> <span class='text-dark'><span class='badge rounded-pill bg-danger'>2</span> <i class='text-danger fas fa-wine-glass-alt'></i> </sup>	
// <span class='text-dark'><span class='badge rounded-pill bg-info'>1</span> 
// Ignore Spelling: Matzah, Charoset