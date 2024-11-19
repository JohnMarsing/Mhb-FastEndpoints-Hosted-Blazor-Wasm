using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using MyHebrewBible.Client.Components;

namespace MyHebrewBible.Client.Enums;

public abstract class BLB : SmartEnum<BLB>
{

	#region Id's
	private static class Id
	{
		internal const int KJV = 1;
		internal const int NKJV = 2;
		internal const int nlt = 3;
		internal const int niv = 4;
		internal const int esv = 5;
		internal const int csb = 6;
		internal const int nasb20 = 7;
		internal const int nasb95 = 8;
		internal const int lsb = 9;
		internal const int amp = 10;
		internal const int net = 11;
		internal const int rsv = 12;
		internal const int asv = 13;
		internal const int ylt = 14;
		internal const int dby = 15;
		internal const int web = 16;
		internal const int hnv = 17;
		internal const int RVR60 = 18;
		internal const int VUL = 19;
		internal const int WLC = 20;
		internal const int BES = 21;
		internal const int lxx = 22;
		internal const int mGNT = 23;
		internal const int TR = 24;
		internal const int NAV = 25; // Open New Arabic Version
		internal const int svd = 26; // Smith & Van Dyck
	}
	#endregion

	#region  Declared Public Instances

	public static readonly BLB KJV = new KJV_SE();
	public static readonly BLB NKJV = new NKJV_SE();
	public static readonly BLB WLC = new WLC_SE();
	// SE=SmartEnum

	#endregion


	private BLB(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Title { get; }
	#endregion


	#region Private Instantiation

	private sealed class KJV_SE : BLB
	{
		public KJV_SE() : base($"{nameof(Id.KJV)}", Id.KJV) { }
		public override string Title => "King James Version";
	}

	private sealed class NKJV_SE : BLB
	{
		public NKJV_SE() : base($"{nameof(Id.NKJV)}", Id.NKJV) { }
		public override string Title => "New King James Version";
	}

	private sealed class WLC_SE : BLB
	{
		// https://www.blueletterbible.org/NKJV/Gen/1/1/t_bibles_2001
		// https://www.blueletterbible.org/wlc/gen/1/1/s_1001
		public WLC_SE() : base($"{nameof(Id.WLC)}", Id.WLC) { }
		public override string Title => "Westminster Leningrad Codex"; // (WLC)
	}

	/*
			public override string Title => "King James Version";
			public override string Title => "New King James Version";
			public override string Title => "New Living Translation";
			public override string Title => "New International Version";
			public override string Title => "English Standard Version";
			public override string Title => "Christian Standard Bible";
			public override string Title => "New American Standard Bible 2020";
			public override string Title => "New American Standard Bible 1995";
			public override string Title => "Legacy Standard Bible";
			public override string Title => "Amplified Bible"; // AMP
			public override string Title => "New English Translation";
			public override string Title => "Revised Standard Version";
			public override string Title => "American Standard Version";
			public override string Title => "Young's Literal Translation";
			public override string Title => "Darby Translation"; // (DBY)
			public override string Title => "Webster's Bible"; // (WEB)
			public override string Title => "Hebrew Names Version";
			public override string Title => "Reina-Valera 1960 Version"; // (RVR60)
			public override string Title => "Latin Vulgate"; // (VUL)

			public override string Title => "Brenton's English Septuagint"; // (BES)
			public override string Title => "Septuagint"; // (LXX)
			public override string Title => "Morphological Greek New Testament"; // (mGNT)
			public override string Title => "Textus Receptus"; // (TR)
			public override string Title => "Open New Arabic Version"; // (NAV)
			public override string Title => "Smith & Van Dyck"; // (SVD)
	*/

	#endregion

	// Deprecated Used by Features\BookChapter\Verses\WordSegmentsCard.razor
	public MarkupString AnchorBCV(BookAndChapter? bookAndChapter, int verseNumber)
	{
		if (bookAndChapter is not null && bookAndChapter.BibleBook is not null)
		{
			string
			s = "<a";                                           // Start anchor attribute
			s += " href='https://www.blueletterbible.org/";     // start href with a '
			s += $"{this.Name}/";
			s += $"{BibleBookFormat.BLB_HrefSuffix(bookAndChapter, verseNumber)}";
			s += $"t_bibles_2001";
			s += "'";                                           // end href with a '
			s += $" title='{this.Name} BLB' target='_blank'";
			s += ">";                                           // End anchor attribute
			s += $"{BibleBookFormat.BCV(bookAndChapter!, verseNumber)}";
			s += "</a>";
			s += " <i class='fas fa-external-link-alt'></i>";
			return (MarkupString)s;
		}
		else
		{
			return (MarkupString)"<a href='https://www.blueletterbible.org> <i class='fas fa-external-link-alt'></i></a>";
		}
	}

	// used by Components\VerseSections\WordSegmentsCard.razor
	public MarkupString AnchorBCV(BookChapterVerse? bookChapterVerse)
	{
		if (bookChapterVerse is not null && bookChapterVerse.BookAndChapter.BibleBook is not null)
		{
			string
			s = "<a";                                           // Start anchor attribute
			s += " href='https://www.blueletterbible.org/";     // start href with a '
			s += $"{this.Name}/";
			s += $"{BibleBookFormat.BLB_HrefSuffix(bookChapterVerse)}"; //NKJV/Mal/2/4/t_bibles_2001

			//s += $"t_bibles_2001"; // or /s_50001
			
			s += "'";                                           // end href with a '
			s += $" title='{this.Name} BLB' target='_blank'";
			s += ">";                                           // End anchor attribute
			s += $"{BibleBookFormat.BCV(bookChapterVerse, useAbrv:false)}";
			s += "</a>";
			s += " <i class='fas fa-external-link-alt'></i>";
			return (MarkupString)s;
		}
		else
		{
			return (MarkupString)"<a href='https://www.blueletterbible.org> <i class='fas fa-external-link-alt'></i></a>";
		}
	}

	public MarkupString AnchorBCV(int book, int chapter, int verse)
	{
		BookChapterVerse? bcv = null;
		BookAndChapter? bc = new BookAndChapter(BibleBook.FromValue(book), chapter);
		if (bc is not null)
		{
			bcv = new BookChapterVerse(bc, verse);
			if (bcv is not null)
			{
				return AnchorBCV(bcv);
			}
			else
			{
				return (MarkupString)"<a href='https://www.blueletterbible.org> <i class='fas fa-external-link-alt'></i></a>";
			}
		}
		else
		{
			return (MarkupString)"<a href='https://www.blueletterbible.org> <i class='fas fa-external-link-alt'></i></a>";
		}
	}


}

// Ignore Spelling: KJV NKJV WLC

/*
s += $"{bookChapterVerse.BookAndChapter.BibleBook.Abrv} {bookChapterVerse.BookAndChapter.Chapter} {bookChapterVerse.Verse}";

public static class Constants
{
	public const string HREF = "https://www.blueletterbible.org";
}

*/