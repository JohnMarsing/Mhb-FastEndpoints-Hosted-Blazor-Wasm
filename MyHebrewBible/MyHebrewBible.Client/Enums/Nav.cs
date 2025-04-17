using Ardalis.SmartEnum;
using BookChapterConstants = MyHebrewBible.Client.Features.BookChapter.Constants;
using ParashaEnums = MyHebrewBible.Client.Features.Parasha.Enums;  // Index => ParashaEnums.Constants.GetUrl()! ?? this.Name;

namespace MyHebrewBible.Client.Enums;

[Flags]
public enum PageListType
{
	None = 0,
	SitemapPage = 1,
	Footer = 2,
	Layout = 4,
	HealthCheck = 8,
	Reply = 16,
	LayoutXs = 32,
	LayoutSm = 64,
	LayoutMd = 128,
	LayoutLg = 256,
	LayoutXl = 512,
}

public abstract class Nav : SmartEnum<Nav>
{

	#region Id's
	private static class Id
	{
		internal const int Home = 1;
		internal const int BookChapter = 2;
		internal const int Parasha = 3;
		internal const int Donate = 4;
		internal const int Article = 5;
		internal const int FavoriteVerses = 6;
		internal const int Hebrew = 7;
		internal const int AlephTavs = 8;
		internal const int BibleList = 9;
		internal const int Haggadah = 10;
		internal const int Teaching = 11;
		internal const int Sitemap = 12;
		internal const int About = 13;
		internal const int HomeMhbVer6 = 14;
		internal const int VerseList = 15;
		internal const int Contact = 16;
		internal const int DonateReplyConfirm = 17;
		internal const int Profile = 18;
		internal const int BibleSearch = 19;
		internal const int HealthCheckBibleBook = 20;
		internal const int HealthCheckThrowError = 21;
		internal const int HealthCheckVerseList = 22;
		internal const int ParashaList = 23;
		internal const int HealthCheckBitwise = 24;
		internal const int HebrewRevelation = 25;
		internal const int HealthCheckParasha = 26;
		internal const int HealthCheckTableRowCount = 27;
		internal const int HealthCheckQuickGrid = 28;

		/*
		Un documented Health Checks
		internal const int HealthCheckBitwiseSample = 25;
		internal const int HealthCheckQuickGrid = 25;
		internal const int HealthCheckToggle = 25;
		*/

	}
	#endregion

	#region  Declared Public Instances
	public static readonly Nav Home = new HomeSE();
	public static readonly Nav BookChapter = new BookChapterSE();
	public static readonly Nav Parasha = new ParashaSE();
	public static readonly Nav Donate = new DonateSE();
	public static readonly Nav Article = new ArticleSE();
	public static readonly Nav FavoriteVerses = new FavoriteVersesSE();
	public static readonly Nav Hebrew = new HebrewSE();
	public static readonly Nav AlephTavs = new AlephTavsSE();
	public static readonly Nav BibleList = new BibleListSE();
	public static readonly Nav Haggadah = new HaggadahSE();
	public static readonly Nav Teaching = new TeachingSE();
	public static readonly Nav Sitemap = new SitemapSE();
	public static readonly Nav About = new AboutSE();
	public static readonly Nav HomeMhbVer6 = new HomeMhbVer6SE();
	public static readonly Nav VerseList = new VerseListSE();
	public static readonly Nav Contact = new ContactSE();
	public static readonly Nav DonateReplyConfirm = new DonateReplyConfirmSE();
	public static readonly Nav Profile = new ProfileSE();
	public static readonly Nav BibleSearch = new BibleSearchSE();
	public static readonly Nav HealthCheckBibleBook = new HealthCheckBibleBookSE();
	public static readonly Nav HealthCheckThrowError = new HealthCheckThrowErrorSE();
	public static readonly Nav HealthCheckVerseList = new HealthCheckVerseListSE();
	public static readonly Nav ParashaList = new ParashaListSE();
	public static readonly Nav HealthCheckBitwise = new HealthCheckBitwiseSE();
	public static readonly Nav HebrewRevelation = new HebrewRevelationSE();
	public static readonly Nav HealthCheckParasha = new HealthCheckParashaSE();
	public static readonly Nav HealthCheckTableRowCount = new HealthCheckTableRowCountSE();
	public static readonly Nav HealthCheckQuickGrid = new HealthCheckQuickGridSE();
	#endregion

	private Nav(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Index { get; }
	public abstract string Title { get; }
	public abstract string Icon { get; }
	public abstract int Sort { get; }
	public abstract string HomeTitleSuffix { get; }
	public abstract string HomeFloatRightHebrew { get; }
	public abstract bool IsPartOfList(PageListType pageListType);
	public abstract PageListType PageListType { get; }
	public abstract bool Disabled { get; }

	public string DisabledHtml
	{
		get
		{
			return $"{(Disabled ? " disabled" : "")}";
		}
	}

	public string TextColor
	{
		get
		{
			return $"{(Disabled ? " text-black-50" : "text-primary")}";
		}
	}

	#endregion

	#region Private Instantiation

	private sealed class HomeSE : Nav
	{
		public HomeSE() : base($"{nameof(Id.Home)}", Id.Home) { }
		public override string Index => "/";
		public override string Title => "Home";
		public override string Icon => "fas fa-home";
		public override int Sort => Id.Home;
		public override string HomeTitleSuffix => " bayit H1004";
		public override string HomeFloatRightHebrew => "בַּיִת";
		public override PageListType PageListType => PageListType.Footer;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class BookChapterSE : Nav
	{
		public BookChapterSE() : base($"{nameof(Id.BookChapter)}", Id.BookChapter) { }
		public override string Index => $"/{BookChapterConstants.BaseUrl}/{BookChapterConstants.DefaultRouteParameter}";  
		public override string Title => "Book Chapter";
		public override string Icon => "fa fa-book";
		public override int Sort => Id.BookChapter;
		public override string HomeTitleSuffix => " mispar h4557";
		public override string HomeFloatRightHebrew => "מִסְפָּר";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Footer | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class ParashaSE : Nav
	{
		public ParashaSE() : base($"{nameof(Id.Parasha)}", Id.Parasha) { }
		public override string Index => ParashaEnums.Constants.GetUrl()! ?? this.Name;
		//public override string Index => ParashaEnums.Constants.GetUrl() ?? $"/{ParashaEnums.Constants.BaseUrl}";
		public override string Title => "Parasha";
		public override string Icon => "far fa-bookmark";
		public override int Sort => Id.Parasha;
		public override string HomeTitleSuffix => " Parashat H6567";
		public override string HomeFloatRightHebrew => "פָּרָשַׁת";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class DonateSE : Nav
	{
		public DonateSE() : base($"{nameof(Id.Donate)}", Id.Donate) { }
		public override string Index => "/Donate";
		public override string Title => "Donate";
		public override string Icon => "fas fa-donate";
		public override int Sort => Id.Donate;
		public override string HomeTitleSuffix => " Tsadik H6662";
		public override string HomeFloatRightHebrew => "צַדִּיק";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Footer | PageListType.Layout | PageListType.LayoutMd;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class ArticleSE : Nav
	{
		public ArticleSE() : base($"{nameof(Id.Article)}", Id.Article) { }
		public override string Index => "/Articles";
		public override string Title => "Articles";
		public override string Icon => "fas fa-pencil-alt";
		public override int Sort => Id.Article;
		public override string HomeTitleSuffix => " Mispar H4557 ";
		public override string HomeFloatRightHebrew => "מִסְפָּר";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class FavoriteVersesSE : Nav
	{
		public FavoriteVersesSE() : base($"{nameof(Id.FavoriteVerses)}", Id.FavoriteVerses) { }
		public override string Index => "/FavoriteVerses";
		public override string Title => "Favorite Verses";
		public override string Icon => "text-danger fas fa-star";
		public override int Sort => Id.FavoriteVerses;
		public override string HomeTitleSuffix => " Avah H183";
		public override string HomeFloatRightHebrew => "אָוָה";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class HebrewSE : Nav
	{
		public HebrewSE() : base($"{nameof(Id.Hebrew)}", Id.Hebrew) { }
		public override string Index => "/Hebrew";
		public override string Title => "Hebrew";
		public override string Icon => "fa fa-letter-aleph";  //   fa-letter-aleph-bet
		public override int Sort => Id.Hebrew;
		public override string HomeTitleSuffix => " Ivri H5680";
		public override string HomeFloatRightHebrew => "עִבְרִי";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class AlephTavsSE : Nav
	{
		public AlephTavsSE() : base($"{nameof(Id.AlephTavs)}", Id.AlephTavs) { }
		public override string Index => "/alephTav";
		public override string Title => "Aleph Tavs";
		public override string Icon => "fa fa-letter-aleph-tav text-danger";
		public override int Sort => Id.AlephTavs;
		public override string HomeTitleSuffix => " Aleph Tav H853";
		public override string HomeFloatRightHebrew => "אֵת";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class BibleListSE : Nav
	{
		public BibleListSE() : base($"{nameof(Id.BibleList)}", Id.BibleList) { }
		public override string Index => "/BibleList";
		public override string Title => "Bible List";
		public override string Icon => "fas fa-torah";
		public override int Sort => Id.BibleList;
		public override string HomeTitleSuffix => " Mispar H4557 ";
		public override string HomeFloatRightHebrew => "מִסְפָּר";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout | PageListType.LayoutSm;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class TeachingSE : Nav
	{
		public TeachingSE() : base($"{nameof(Id.Teaching)}", Id.Teaching) { }
		public override string Index => "/Teaching";
		public override string Title => "Teaching";
		public override string Icon => "fas fa-graduation-cap";
		public override int Sort => Id.Teaching;
		public override string HomeTitleSuffix => " Tamid H8548"; // Yara H3384; h2094 Zahar
		public override string HomeFloatRightHebrew => "לְלַמֵד";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout | PageListType.LayoutSm | PageListType.LayoutMd;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class SitemapSE : Nav
	{
		public SitemapSE() : base($"{nameof(Id.Sitemap)}", Id.Sitemap) { }
		public override string Index => "/Sitemap";
		public override string Title => "Sitemap";
		public override string Icon => "fas fa-sitemap";
		public override int Sort => Id.Sitemap;
		public override string HomeTitleSuffix => " nahal H5095";
		public override string HomeFloatRightHebrew => "נָהַל";
		public override PageListType PageListType => PageListType.Footer | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class AboutSE : Nav
	{
		public AboutSE() : base($"{nameof(Id.About)}", Id.About) { }
		public override string Index => "/About";
		public override string Title => "About";
		public override string Icon => "fas fa-info";
		public override int Sort => Id.About;
		public override string HomeTitleSuffix => " Odot H182";
		public override string HomeFloatRightHebrew => "אוֹדוֹת";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => true;
	}

	private sealed class HomeMhbVer6SE : Nav
	{
		public HomeMhbVer6SE() : base($"{nameof(Id.HomeMhbVer6)}", Id.HomeMhbVer6) { }
		public override string Index => "/HomeMhbVer6";
		public override string Title => "Old Home Page";
		public override string Icon => "fas fa-history";
		public override int Sort => Id.HomeMhbVer6;
		public override string HomeTitleSuffix => " zaken H2204";  // bawlah H1086
		public override string HomeFloatRightHebrew => "זָקֵן";  // בָּלָה
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class VerseListSE : Nav
	{
		public VerseListSE() : base($"{nameof(Id.VerseList)}", Id.VerseList) { }
		public override string Index => "/VerseList/0/0/0/0";  
		public override string Title => "Verse List";
		public override string Icon => "fas fa-list";
		public override int Sort => Id.VerseList;
		public override string HomeTitleSuffix => " mispar H4557";
		public override string HomeFloatRightHebrew => "מִסְפָּר";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class ContactSE : Nav
	{
		public ContactSE() : base($"{nameof(Id.Contact)}", Id.Contact) { }
		public override string Index => "/Contact";
		public override string Title => "Contact";
		public override string Icon => "far fa-comment-dots";  // "fas fa-user-friends
		public override int Sort => Id.Contact;
		public override string HomeTitleSuffix => "Shalom  H7695";
		public override string HomeFloatRightHebrew => "שָׁלוֹם";

		//LMM Leadership
		//public override string HomeTitleSuffix => "Zaken  H2205";
		//public override string HomeFloatRightHebrew => "זָקֵן";

		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout | PageListType.Footer;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => true;
	}

	private sealed class DonateReplyConfirmSE : Nav
	{
		public DonateReplyConfirmSE() : base($"{nameof(Id.DonateReplyConfirm)}", Id.DonateReplyConfirm) { }
		public override string Index => "/confirm_donation.html";
		public override string Title => "Donation Confirmed";
		public override string Icon => "fab fa-cc-stripe";
		public override int Sort => Id.DonateReplyConfirm;
		public override string HomeTitleSuffix => "";
		public override string HomeFloatRightHebrew => "";

		public override PageListType PageListType => PageListType.Reply;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false; // N/A
	}

	private sealed class ProfileSE : Nav
	{
		public ProfileSE() : base($"{nameof(Id.Profile)}", Id.Profile) { }
		public override string Index => "/profile";
		public override string Title => "Profile";
		public override string Icon => "fas fa-user";  //fab fa-superpowers  fas fa-address-card
		public override int Sort => Id.Profile;
		public override string HomeTitleSuffix => "Netser H5342";
		public override string HomeFloatRightHebrew => "נֵצֶר";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => true;
	}

	private sealed class BibleSearchSE : Nav
	{
		public BibleSearchSE() : base($"{nameof(Id.BibleSearch)}", Id.BibleSearch) { }
		public override string Index => "BibleSearch";
		public override string Title => "Bible Search";
		public override string Icon => "fas fa-search";
		public override int Sort => Id.Profile;
		public override string HomeTitleSuffix => " Bawkar H1239";
		public override string HomeFloatRightHebrew => "בָּקַר";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class HealthCheckBibleBookSE : Nav
	{
		public HealthCheckBibleBookSE() : base($"{nameof(Id.HealthCheckBibleBook)}", Id.HealthCheckBibleBook) { }
		public override string Index => "HealthChecks/BibleBooks";
		public override string Title => "BibleBook (HC)";
		public override string Icon => "fas fa-brain";
		public override int Sort => Id.HealthCheckBibleBook;
		public override string HomeTitleSuffix => " Yakah H3198";
		public override string HomeFloatRightHebrew => "יָכַח";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.HealthCheck;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	//ToDo This should only be for Admin users
	private sealed class HealthCheckThrowErrorSE : Nav
	{
		public HealthCheckThrowErrorSE() : base($"{nameof(Id.HealthCheckThrowError)}", Id.HealthCheckThrowError) { }
		public override string Index => "HealthChecks/ThrowError";
		public override string Title => "ThrowError (HC)";
		public override string Icon => "fas fa-bomb";  //fas fa-wrench
		public override int Sort => Id.HealthCheckThrowError;
		public override string HomeTitleSuffix => " ";
		public override string HomeFloatRightHebrew => "";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.HealthCheck;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class HealthCheckVerseListSE : Nav
	{
		public HealthCheckVerseListSE() : base($"{nameof(Id.HealthCheckVerseList)}", Id.HealthCheckVerseList) { }
		public override string Index => "HealthChecks/VerseList";
		public override string Title => "Verse List (HC)";
		public override string Icon => "fas fa-wrench";
		public override int Sort => Id.HealthCheckVerseList;
		public override string HomeTitleSuffix => " ";
		public override string HomeFloatRightHebrew => "";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.HealthCheck;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class ParashaListSE : Nav
	{
		public ParashaListSE() : base($"{nameof(Id.ParashaList)}", Id.ParashaList) { }
		public override string Index => "/ParashaList";
		public override string Title => "Parasha List";
		public override string Icon => "fas fa-table";
		public override int Sort => Id.ParashaList;
		public override string HomeTitleSuffix => "";
		public override string HomeFloatRightHebrew => "";

		public override PageListType PageListType => PageListType.None;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false; // N/A
	}

	private sealed class HealthCheckBitwiseSE : Nav
	{
		public HealthCheckBitwiseSE() : base($"{nameof(Id.HealthCheckBitwise)}", Id.HealthCheckBitwise) { }
		public override string Index => "HealthChecks/Bitwise";
		public override string Title => "Bitwise (HC)";
		public override string Icon => "fas fa-teeth";  // fab fa-perbyte
		public override int Sort => Id.HealthCheckBitwise;
		public override string HomeTitleSuffix => " ";
		public override string HomeFloatRightHebrew => "";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.HealthCheck;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class HebrewRevelationSE : Nav
	{
		public HebrewRevelationSE() : base($"{nameof(Id.HebrewRevelation)}", Id.HebrewRevelation) { }
		public override string Index => "HebrewRevelation";
		public override string Title => "Hebrew Revelation";
		public override string Icon => "fas fa-eye";  
		public override int Sort => Id.HebrewRevelation;
		public override string HomeTitleSuffix => "Hazon H2377";
		public override string HomeFloatRightHebrew => "חֲזוֹן";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class HealthCheckParashaSE : Nav
	{
		public HealthCheckParashaSE() : base($"{nameof(Id.HealthCheckParasha)}", Id.HealthCheckParasha) { }
		public override string Index => "HealthChecks/Parasha";
		public override string Title => "Parasha (HC)";
		public override string Icon => "fas fa-crow";
		public override int Sort => Id.HealthCheckParasha;
		public override string HomeTitleSuffix => " Parashat H6567";
		public override string HomeFloatRightHebrew => "פָּרָשַׁת";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.HealthCheck;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class HealthCheckTableRowCountSE : Nav
	{
		public HealthCheckTableRowCountSE() : base($"{nameof(Id.HealthCheckTableRowCount)}", Id.HealthCheckTableRowCount) { }
		public override string Index => "HealthChecks/TableRowCount";
		public override string Title => "Table Row Count (HC)";
		public override string Icon => "fas fa-wave-square";  // fa-stopwatch-20
		public override int Sort => Id.HealthCheckTableRowCount;
		public override string HomeTitleSuffix => " ";
		public override string HomeFloatRightHebrew => "";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.HealthCheck;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class HealthCheckQuickGridSE : Nav
	{
		public HealthCheckQuickGridSE() : base($"{nameof(Id.HealthCheckQuickGrid)}", Id.HealthCheckQuickGrid) { }
		public override string Index => "HealthChecks/QuickGrid";
		public override string Title => "QuickGrid Test";
		public override string Icon => "fas fa-fighter-jet";  
		public override int Sort => Id.HealthCheckQuickGrid;
		public override string HomeTitleSuffix => " ";
		public override string HomeFloatRightHebrew => "";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.HealthCheck;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	private sealed class HaggadahSE : Nav
	{
		public HaggadahSE() : base($"{nameof(Id.Haggadah)}", Id.Haggadah) { }
		public override string Index => "Haggadah";
		public override string Title => "Haggadah (telling)";
		public override string Icon => "fas fa-book-open";  
		public override int Sort => Id.Haggadah;
		public override string HomeTitleSuffix => " Nagad H5046";
		public override string HomeFloatRightHebrew => "הַגָּדָה";
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
		public override bool Disabled => false;
	}

	// 

	#endregion


	#region IsLayout
	// Never used, but looks useful 
	public bool IsLayoutShownXs
	{
		get { return this.PageListType == PageListType.LayoutXs ? true : false; }
	}

	public bool IsLayoutShownSm
	{
		get { return this.PageListType == PageListType.LayoutSm ? true : false; }
	}

	public bool IsLayoutShownMd
	{
		get { return this.PageListType == PageListType.LayoutMd ? true : false; }
	}

	public bool IsLayoutShownLg
	{
		get { return this.PageListType == PageListType.LayoutLg ? true : false; }
	}

	public bool IsLayoutShownXl
	{
		get { return this.PageListType == PageListType.LayoutXl ? true : false; }
	}
	#endregion

}

//  Title2 = "Welcome 😄";  https://github.com/anton-bot/Full-Emoji-List/blob/master/Emoji.cs
// Ignore Spelling: Nav Parasha QRC Descr loggedout Tavs Mhb Ver, Haggadah
