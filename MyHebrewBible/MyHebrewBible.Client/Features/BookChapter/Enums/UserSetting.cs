using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.BookChapter.Enums;

[Flags]
public enum Permutation : int
{
	HebrewShownOnTheSide = 1,
	StandaloneAlephTavDetailOn = 2,
	ParashaDividerDetailOn = 4,
	HebrewWordNumbersOn = 8,

	/*
	ReplaceEnglishWithHebrewLevelBasic = 16,	
	ReplaceEnglishWithHebrewLevelIntermediate = 32,
	ReplaceEnglishWithHebrewLevelAdvanced = 64,

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
		internal const int StandaloneAlephTav = 2;
		internal const int ParashaDivider = 3;
		internal const int HebrewWordNumbers = 4;	
		//internal const int WordReplaceLevel = 5;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly UserSetting HebrewLocation = new HebrewLocationSE();
	public static readonly UserSetting StandaloneAlephTav = new StandaloneAlephTavSE();
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
	public abstract string DetailWhenOn { get; }
	public abstract string DetailWhenOff { get; }

	//Properties

	public static Permutation Default =>
		Permutation.HebrewShownOnTheSide
	| Permutation.StandaloneAlephTavDetailOn
	| Permutation.ParashaDividerDetailOn
	| Permutation.HebrewWordNumbersOn;
	//| Permutation.ReplaceEnglishWithHebrewLevelBasic


	#endregion

	#region Private Instantiation
	private sealed class HebrewLocationSE : UserSetting
	{
		public HebrewLocationSE() : base($"{nameof(Id.HebrewLocation)}", Id.HebrewLocation) { }
		public override Permutation OnState => Permutation.HebrewShownOnTheSide;
		public override string Title => "Hebrew Location";
		public override string DetailWhenOn => "on the right as a paragraph";
		public override string DetailWhenOff => "at the bottom as a table";
	}

	private sealed class StandaloneAlephTavSE : UserSetting
	{
		public StandaloneAlephTavSE() : base($"{nameof(Id.StandaloneAlephTav)}", Id.StandaloneAlephTav) { }
		public override Permutation OnState => Permutation.StandaloneAlephTavDetailOn;
		public override string Title => "Standalone Aleph Tav";
		public override string DetailWhenOn => "expanded to show surrounding words";
		public override string DetailWhenOff => "shrunk to only show an icon";
	}

	private sealed class ParashaDividerSE : UserSetting
	{
		public ParashaDividerSE() : base($"{nameof(Id.ParashaDivider)}", Id.ParashaDivider) { }
		public override Permutation OnState => Permutation.ParashaDividerDetailOn;
		public override string Title => "Parasha Divider Detail";
		public override string DetailWhenOn => "Parasha divider detail is shown";
		public override string DetailWhenOff => "Only parasha divider line is shown";
	}

	private sealed class HebrewWordNumbersSE : UserSetting
	{
		public HebrewWordNumbersSE() : base($"{nameof(Id.HebrewWordNumbers)}", Id.HebrewWordNumbers) { }
		public override Permutation OnState => Permutation.HebrewWordNumbersOn;
		public override string Title => "Hebrew Word Numbers";
		public override string DetailWhenOn => "sequential cardinal numbers shown";
		public override string DetailWhenOff => "sequential cardinal numbers NOT shown";
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
