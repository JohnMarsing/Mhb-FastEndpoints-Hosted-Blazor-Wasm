using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.BookChapter.Enums;

[Flags]
public enum Permutation : int
{
	HebrewShownOnTheSide = 1,
	HebrewShownAsTable = 2,
	SatDetailOn = 4,
	SatDetailOff = 8,
	ParashaDividerOn = 16,
	ParashaDividerOff = 32,
	HebrewWordNumbersOn = 64,
	HebrewWordNumbersOff = 128,

	/*
	ReplaceEnglishWithHebrewLevelBasic = 256,	
	ReplaceEnglishWithHebrewLevelIntermediate = 512,
	ReplaceEnglishWithHebrewLevelAdvanced = 1024,

	Enums\BLB.cs

	*/
}

/*
# Business rule

*/

public abstract class UserSetting : SmartEnum<UserSetting>
{
	#region Id's
	private static class Id
	{
		internal const int HebrewLocation = 1;
		internal const int SAT = 2;
		internal const int ParashaDivider = 3;
		internal const int HebrewWordNumbers = 4;	
		//internal const int WordReplaceLevel = 5;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly UserSetting HebrewLocation = new HebrewLocationSE();
	public static readonly UserSetting SAT = new SATSE();
	public static readonly UserSetting ParashaDivider = new ParashaDividerSE();
	public static readonly UserSetting HebrewWordNumbers = new HebrewWordNumbersSE();	
	//public static readonly UserSetting WordReplaceLevel = new WordReplaceLevelSE();
	#endregion

	private UserSetting(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields 
	public abstract string Title { get; }
	public abstract Permutation OnState { get; }

	//Properties

	public static Permutation Default =>
		Permutation.HebrewShownOnTheSide
	| Permutation.SatDetailOn
	| Permutation.ParashaDividerOn
	| Permutation.HebrewWordNumbersOn;
	//| Permutation.ReplaceEnglishWithHebrewLevelBasic


	public static Permutation AntiDefault => 
		Permutation.HebrewShownAsTable
	| Permutation.SatDetailOff
	| Permutation.ParashaDividerOff
	| Permutation.HebrewWordNumbersOff;


	#endregion

	#region Private Instantiation
	private sealed class HebrewLocationSE : UserSetting
	{
		public HebrewLocationSE() : base($"{nameof(Id.HebrewLocation)}", Id.HebrewLocation) { }
		public override Permutation OnState => Permutation.HebrewShownOnTheSide;
		public override string Title => "Hebrew Location";
	}

	private sealed class SATSE : UserSetting
	{
		public SATSE() : base($"{nameof(Id.SAT)}", Id.SAT) { }
		public override Permutation OnState => Permutation.SatDetailOn;
		public override string Title => "Standalone Aleph Tav";
	}

	private sealed class ParashaDividerSE : UserSetting
	{
		public ParashaDividerSE() : base($"{nameof(Id.ParashaDivider)}", Id.ParashaDivider) { }
		public override Permutation OnState => Permutation.ParashaDividerOn;
		public override string Title => "Show Parasha Divider";
	}

	private sealed class HebrewWordNumbersSE : UserSetting
	{
		public HebrewWordNumbersSE() : base($"{nameof(Id.HebrewWordNumbers)}", Id.HebrewWordNumbers) { }
		public override Permutation OnState => Permutation.HebrewWordNumbersOn;
		public override string Title => "Show Hebrew Word Numbers";
	}

	/*
	private sealed class WordReplaceLevelSE : UserSetting
	{
		public WordReplaceLevelSE() : base($"{nameof(Id.WordReplaceLevel)}", Id.WordReplaceLevel) { }
		public override Permutation DefaultState => Permutation.ReplaceEnglishWithHebrewLevelBasic;
		public override string Title => "Word Replace Level";
	}
	*/
	#endregion
}
// Ignore Spelling: SATSE
