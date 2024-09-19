using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Enums;

public abstract class MediaQuery : SmartEnum<MediaQuery>
{
	#region Id's
	private static class Id
	{
		internal const int Xs = 1;
		internal const int Sm = 2;
		internal const int Md = 3;
		internal const int Lg = 5;
		internal const int Xl = 6;
		internal const int XsOrSm = 7;
		internal const int SmOrMdOrLgOrXl = 8;
		internal const int MdOrLgOrXl = 9;
		internal const int LgOrXl = 10;
		internal const int XsOrSmOrMd = 11;
		//internal const int XsOrXl = 11;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly MediaQuery Xs = new XsSE();
	public static readonly MediaQuery Sm = new SmSE();
	public static readonly MediaQuery Md = new MdSE();
	public static readonly MediaQuery Lg = new LgSE();
	public static readonly MediaQuery Xl = new XlSE();

	// Combination
	public static readonly MediaQuery XsOrSm = new XsOrSmSE();
	public static readonly MediaQuery XsOrSmOrMd = new XsOrSmOrMdSE();
	public static readonly MediaQuery SmOrMdOrLgOrXl = new SmOrMdOrLgOrXlSE();
	public static readonly MediaQuery MdOrLgOrXl = new MdOrLgOrXlSE();
	public static readonly MediaQuery LgOrXl = new LgOrXlSE();
	//public static readonly MediaQuery XsOrXl = new XsOrXlSE(); 

	// SE=SmartEnum
	#endregion

	private MediaQuery(string name, int value) : base(name, value) { }  // Constructor

	#region Extra Fields
	public abstract string DivClass { get; }
	public abstract int ChapterButtonsPerRow { get; }
	#endregion


	#region Private Instantiation

	private sealed class XsSE : MediaQuery
	{
		public XsSE() : base($"{nameof(Id.Xs)}", Id.Xs) { }
		public override string DivClass => "d-sm-none";
		public override int ChapterButtonsPerRow => 5;
	}

	private sealed class SmSE : MediaQuery
	{
		public SmSE() : base($"{nameof(Id.Sm)}", Id.Sm) { }
		public override string DivClass => "d-none d-sm-block d-md-none d-lg-none d-xl-none";
		public override int ChapterButtonsPerRow => 10;
	}

	private sealed class MdSE : MediaQuery
	{
		public MdSE() : base($"{nameof(Id.Md)}", Id.Md) { }
		public override string DivClass => "d-none d-md-block d-lg-none d-xl-none";
		public override int ChapterButtonsPerRow => 15;
	}

	private sealed class LgSE : MediaQuery
	{
		public LgSE() : base($"{nameof(Id.Lg)}", Id.Lg) { }
		public override string DivClass => "d-none d-lg-block d-xl-none";
		public override int ChapterButtonsPerRow => 20;
	}

	private sealed class XlSE : MediaQuery
	{
		public XlSE() : base($"{nameof(Id.Xl)}", Id.Xl) { }
		public override string DivClass => "d-none d-xl-block";
		public override int ChapterButtonsPerRow => 25;
	}

	// Combination
	private sealed class XsOrSmSE : MediaQuery
	{
		public XsOrSmSE() : base($"{nameof(Id.XsOrSm)}", Id.XsOrSm) { }
		public override string DivClass => "d-md-none";
		public override int ChapterButtonsPerRow => Xs.ChapterButtonsPerRow;
	}

	private sealed class XsOrSmOrMdSE : MediaQuery
	{
		public XsOrSmOrMdSE() : base($"{nameof(Id.XsOrSmOrMd)}", Id.XsOrSmOrMd) { }
		public override string DivClass => "d-lg-none";
		public override int ChapterButtonsPerRow => Xs.ChapterButtonsPerRow;
	}

	private sealed class SmOrMdOrLgOrXlSE : MediaQuery
	{
		public SmOrMdOrLgOrXlSE() : base($"{nameof(Id.SmOrMdOrLgOrXl)}", Id.SmOrMdOrLgOrXl) { }
		public override string DivClass => "d-none d-sm-block";
		public override int ChapterButtonsPerRow => Sm.ChapterButtonsPerRow;
	}

	private sealed class MdOrLgOrXlSE : MediaQuery
	{
		public MdOrLgOrXlSE() : base($"{nameof(Id.MdOrLgOrXl)}", Id.MdOrLgOrXl) { }
		public override string DivClass => "d-none d-md-block";
		public override int ChapterButtonsPerRow => Md.ChapterButtonsPerRow;
	}

	private sealed class LgOrXlSE : MediaQuery
	{
		public LgOrXlSE() : base($"{nameof(Id.LgOrXl)}", Id.LgOrXl) { }
		public override string DivClass => "d-none d-lg-block";
		public override int ChapterButtonsPerRow => Lg.ChapterButtonsPerRow;
	}

	/*	NOT WOWRKING
		private sealed class XsOrXlSE : MediaQuery
	{
		public XsOrXlSE() : base($"{nameof(Id.XsOrXl)}", Id.XsOrXl) { } // ToDo: what combo goes here?
		public override string DivClass => "d-sm-block d-md-block d-lg-block";
	}
	*/

	#endregion

}

/*

```csharp
	private void SetButtonsPerRow()
	{
		MediaQuery!
		.When(MediaQuery.Xs).Then(() => ButtonsPerRow = 5)
		.When(MediaQuery.Sm).Then(() => ButtonsPerRow = 10)
		.When(MediaQuery.Md).Then(() => ButtonsPerRow = 15)
		.When(MediaQuery.Lg).Then(() => ButtonsPerRow = 20)
		.When(MediaQuery.Xl).Then(() => ButtonsPerRow = 25);
	}
```

<div class="d-sm-none"></div>
<div class="d-none d-sm-block d-md-none d-lg-none d-xl-none"></div>
<div class="d-none d-md-block d-lg-none d-xl-none"></div>
<div class="d-none d-lg-block d-xl-none"></div>
<div class="d-none d-xl-block"></div> 

https://getbootstrap.com/docs/5.0/utilities/display/
https://getbootstrap.com/docs/5.0/layout/breakpoints/

public abstract string Breakpoint { get; }
public abstract string ClassInfix { get; }
public abstract int Dimensions { get; }

Breakpoint	Class Infix†	Dimensions
	X-Small			None					<576px
	Small				sm						≥576px
	Medium			md						≥768px
	Large				lg						≥992px
	Extra	large	xl						≥1200px
	2xExtra lg	xxl						≥1400px  v5

† Infix: An operator that comes in between its operands, such as multiplication in 24 * 7 .
*/
