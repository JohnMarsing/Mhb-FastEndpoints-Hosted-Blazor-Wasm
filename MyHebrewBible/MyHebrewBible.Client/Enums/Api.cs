using Ardalis.SmartEnum;
using ParashaEnums = MyHebrewBible.Client.Features.Parasha.Enums;

namespace MyHebrewBible.Client.Enums;

public abstract class Api : SmartEnum<Api>
{
	#region  Declared Public Instances
	public static readonly Api BookChapter = new BookChapterSE();
	public static readonly Api Parasha = new ParashaSE();
	public static readonly Api VerseList = new VerseListSE();
	public static readonly Api VerseListBetweenIds = new VerseListBetweenIdsSE();
	#endregion

	private Api(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract Nav Nav { get; } // Not used
	public abstract string Route { get; }
	public abstract string EndPoint { get; }
	public abstract string Sql { get; }
	public abstract string SqlOrderBy { get; } // Not used
	#endregion

	#region Private Instantiation

	private sealed class BookChapterSE : Api
	{
		public BookChapterSE() : base(Nav.BookChapter.Name, Nav.BookChapter.Value) { } 
		public override Nav Nav => Nav.BookChapter;

		// This forces BookChapter!Index.razor to refresh the screen via NavigationManager
		public override string Route => $"{this.Name}/0/0/default"; 

		public override string EndPoint => "/bookchapter/{bookid:long}/{chapter:long}"; 
		public override string Sql => @"
		SELECT ID, BCV, Verse, VerseOffset, KJV, DescH, DescD  
		FROM Scripture
		WHERE BookID=@BookId and Chapter=@Chapter
		ORDER BY ID";
		public override string SqlOrderBy => "";
	}

	private sealed class ParashaSE : Api
	{
		public ParashaSE() : base(Nav.Parasha.Name, Nav.Parasha.Value) { }
		public override Nav Nav => Nav.Parasha;
		public override string Route => ParashaEnums.Constants.GetUrl()! ?? this.Name;  // /Parasha/{Id:int}/{Slug}
		public override string EndPoint => "";
		public override string Sql => "";
		public override string SqlOrderBy => "";
	}

	private sealed class VerseListSE : Api
	{
		public VerseListSE() : base(Nav.VerseList.Name, Nav.VerseList.Value) { }
		public override Nav Nav => Nav.VerseList;
		public override string Route => $"{this.Name}/0/0/0/0"; 
		public override string EndPoint => "/verselist/{bookid:long}/{chapter:long}/{begverse:long}/{endverse:long}"; 
		public override string Sql => @"
SELECT ID, BCV, Verse, KJV, VerseOffset, DescH, DescD
FROM Scripture
WHERE BookId=@BookId AND Chapter=@Chapter AND Verse BETWEEN @BegVerse AND @EndVerse
ORDER BY ID";
		public override string SqlOrderBy => "";
		//DECLARE  @BookId int=1,  @Chapter int=12,  @BegVerse int=2,  @EndVerse int=3
	}

	private sealed class VerseListBetweenIdsSE : Api
	{
		public VerseListBetweenIdsSE() : base(Nav.Empty.Name, Nav.Empty.Value) { }
		public override Nav Nav => Nav.Empty; // Nav.VerseListBetweenIds;
		public override string Route => "";
		public override string EndPoint => "/VerseListBetweenIds/{begId:long}/{endId:long}"; 
		public override string Sql => @"
SELECT ID, BCV, Verse, KJV, VerseOffset, DescH, DescD
FROM Scripture
WHERE ID BETWEEN @BegId AND @EndId
ORDER BY ID";
		public override string SqlOrderBy => "";
		//DECLARE  @BookId int=1,  @Chapter int=12,  @BegVerse int=2,  @EndVerse int=3
	}

	#endregion

}
// Ignore Spelling: bookid verselist begverse endverse
