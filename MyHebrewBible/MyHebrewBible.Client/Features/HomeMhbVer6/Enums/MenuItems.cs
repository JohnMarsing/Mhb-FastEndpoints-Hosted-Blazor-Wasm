using Ardalis.SmartEnum;
using PageLink = MyHebrewBible.Client.Enums.Nav;
using MyHebrewBible.Client.Helpers;

namespace MyHebrewBible.Client.Features.HomeMhbVer6.Enums;

public abstract class MenuItems : SmartEnum<MenuItems>
{
	#region Id's
	private static class Id
	{
		internal const int Home = 0;
		internal const int CriticalThinking = 1;
		internal const int Purpose = 2;
		internal const int AboutMyReligion = 3;
		internal const int MarsingsMaxim = 4;
		//internal const int AboutMe = 5;
	}
	#endregion
	
	#region  Declared Public Instances
	public static readonly MenuItems Home = new HomeSE();
	public static readonly MenuItems CriticalThinking = new CriticalThinkingSE();
	public static readonly MenuItems Purpose = new PurposeSE();
	public static readonly MenuItems AboutMyReligion = new AboutMyReligionSE();
	public static readonly MenuItems MarsingsMaxim = new MarsingsMaximSE();
	//public static readonly MenuItems AboutMe = new AboutMeSE();
	// SE=SmartEnum
	#endregion

	private MenuItems(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract string Icon { get; }
	public abstract string Title { get; }
	public abstract string Page { get; }
	public abstract string ButtonColor { get; }
	public abstract string TextColor { get; }
	#endregion

	#region Private Instantiation

	private sealed class HomeSE : MenuItems
	{
		public HomeSE() : base($"{nameof(Id.Home)}", Id.Home) { }
		public override string Icon => "fas fa-caret-right"; 
		public override string Title => nameof(Id.Home);
		public override string Page => PageLink.HomeMhbVer6.Index;
		public override string ButtonColor => BtnColors.Success;
		public override string TextColor => TextColors.Success;
	}

	private sealed class CriticalThinkingSE : MenuItems
	{
		public CriticalThinkingSE() : base($"{nameof(Id.CriticalThinking)}", Id.CriticalThinking) { }
		public override string Icon => "fas fa-cloud"; 
		public override string Title => "Critical Thinking";
		public override string Page => PageLink.HomeMhbVer6.Index + "/" + nameof(Id.CriticalThinking);
		public override string ButtonColor => BtnColors.Info;
		public override string TextColor => TextColors.Info;
	}

	private sealed class PurposeSE : MenuItems
	{
		public PurposeSE() : base($"{nameof(Id.Purpose)}", Id.Purpose) { }
		public override string Icon => "fas fa-calendar"; // fa fa-Feasts fas fa-pizza-slice
		public override string Title => nameof(Id.Purpose);
		public override string Page => PageLink.HomeMhbVer6.Index + "/" + nameof(Id.Purpose);
		public override string ButtonColor => BtnColors.Primary;
		public override string TextColor => TextColors.Primary;
	}

	private sealed class AboutMyReligionSE : MenuItems
	{
		public AboutMyReligionSE() : base($"{nameof(Id.AboutMyReligion)}", Id.AboutMyReligion) { }
		public override string Icon => "fas fa-torah"; 
		public override string Title => "My Religion";
		public override string Page => PageLink.HomeMhbVer6.Index + "/" + nameof(Id.AboutMyReligion);
		public override string ButtonColor => BtnColors.Warning;
		public override string TextColor => TextColors.Warning;
	}

	private sealed class MarsingsMaximSE : MenuItems
	{
		public MarsingsMaximSE() : base($"{nameof(Id.MarsingsMaxim)}", Id.MarsingsMaxim) { }
		public override string Icon => "fas fa-ruler-horizontal"; 
		public override string Title => "Marsing\'s Maxims";
		public override string Page => PageLink.HomeMhbVer6.Index + "/" + nameof(Id.MarsingsMaxim);
		public override string ButtonColor => BtnColors.Danger;
		public override string TextColor => TextColors.Danger;
	}

	/*
	private sealed class AboutMeSE : MenuItems
	{
		public AboutMeSE() : base($"{nameof(Id.AboutMe)}", Id.AboutMe) { }
		public override string Icon => "fas fa-balance-scale";  // fas fa-map
		public override string Title => "About Me";
		public override string Page => PageLink.HomeMhbVer6.Index + "/" + nameof(Id.AboutMe);
	}
	*/
	#endregion
}
// Ignore Spelling: Marsings torah
