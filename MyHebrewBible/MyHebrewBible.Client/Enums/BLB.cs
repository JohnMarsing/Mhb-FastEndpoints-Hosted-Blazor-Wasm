using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using MyHebrewBible.Client.Components;
using MyHebrewBible.Client.Features.BookChapter;

namespace MyHebrewBible.Client.Enums;

public abstract class BLB : SmartEnum<BLB>
{

	#region Id's
	private static class Id
	{
		internal const int kjv = 1;
		internal const int nkjv = 2;
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

	public static readonly BLB nkjv = new nkjvSE();
	// SE=SmartEnum

	#endregion


	private BLB(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Title { get; }
	#endregion


	#region Private Instantiation

	private sealed class kjvSE : BLB
	{
		public kjvSE() : base($"{nameof(Id.kjv)}", Id.kjv) { }
		public override string Title => "King James Version";
	}

	private sealed class nkjvSE : BLB
	{
		public nkjvSE() : base($"{nameof(Id.nkjv)}", Id.nkjv) { }
		public override string Title => "New King James Version";
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
			public override string Title => "Westminster Leningrad Codex"; // (WLC)
			public override string Title => "Brenton's English Septuagint"; // (BES)
			public override string Title => "Septuagint"; // (LXX)
			public override string Title => "Morphological Greek New Testament"; // (mGNT)
			public override string Title => "Textus Receptus"; // (TR)
			public override string Title => "Open New Arabic Version"; // (NAV)
			public override string Title => "Smith & Van Dyck"; // (SVD)
	*/

	#endregion

	// Deprecated
	public MarkupString Anchor(BookAndChapter? bookAndChapter, int verseNumber)
	{
		if (bookAndChapter is not null && bookAndChapter.BibleBook is not null)
		{
			string
			s = "<a";																						// Start anchor attribute
			s += " href='https://www.blueletterbible.org/";			// start href with a '
			s += $"{this.Name}/";
			s += $"{bookAndChapter!.BibleBook!.Abrv}/{bookAndChapter!.Chapter}/{verseNumber}/";
			s += $"t_bibles_2001";      
			s += "'";																						// end href with a '
			s += $" title='{this.Name} BLB' target='_blank'";
			s += ">";																						// End anchor attribute
			s += $"{bookAndChapter!.BibleBook.Abrv} {bookAndChapter!.Chapter} {verseNumber}";
			s += "</a>";
			s += " <i class='fas fa-external-link-alt'></i>";
			return (MarkupString)s;
		}
		else
		{
			return (MarkupString)"<a href='https://www.blueletterbible.org> <i class='fas fa-external-link-alt'></i></a>";
		}
	}

	public MarkupString AnchorBCVVM(BookChapterVerseVM? bookChapterVerseVM)
	{
		if (bookChapterVerseVM is not null && bookChapterVerseVM.BibleBook is not null)
		{
			string
			s = "<a";                                           // Start anchor attribute
			s += " href='https://www.blueletterbible.org/";     // start href with a '
			s += $"{this.Name}/";
			s += $"{bookChapterVerseVM!.BibleBook!.Abrv}/{bookChapterVerseVM!.Chapter}/{bookChapterVerseVM.Verse}/";
			s += $"t_bibles_2001";
			s += "'";                                           // end href with a '
			s += $" title='{this.Name} BLB' target='_blank'";
			s += ">";                                           // End anchor attribute
			s += $"{bookChapterVerseVM!.BibleBook.Abrv} {bookChapterVerseVM!.Chapter} {bookChapterVerseVM.Verse}";
			s += "</a>";
			s += " <i class='fas fa-external-link-alt'></i>";
			return (MarkupString)s;
		}
		else
		{
			return (MarkupString)"<a href='https://www.blueletterbible.org> <i class='fas fa-external-link-alt'></i></a>";
		}
	}

}


/*
public static class Constants
{
	public const string HREF = "https://www.blueletterbible.org";
}

*/