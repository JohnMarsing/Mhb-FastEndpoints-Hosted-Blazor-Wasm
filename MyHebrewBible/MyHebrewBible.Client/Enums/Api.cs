using Ardalis.SmartEnum;
using ParashaEnums = MyHebrewBible.Client.Features.Parasha.Enums;

namespace MyHebrewBible.Client.Enums;

public abstract class Api : SmartEnum<Api>
{
	#region Id's
	private static class Id
	{
		internal const int Article = 1;
		internal const int BookChapter = 2;
		internal const int VerseList = 3;
		internal const int Parasha = 4;
		internal const int VerseListBetweenIds = 5;
		internal const int HebrewWords = 6;
		internal const int AlephTavHebrewVerses = 7;
		internal const int AlephTavKjvVerses = 8;
		internal const int AlephTavWordPartContext = 9; // 4 surrounding words of a SAT
		internal const int AlephTavTriennialWordPartContext = 10; 
	}
	#endregion

	#region  Declared Public Instances
	public static readonly Api Article = new ArticleSE();
	public static readonly Api BookChapter = new BookChapterSE();
	public static readonly Api Parasha = new ParashaSE();
	public static readonly Api VerseList = new VerseListSE();
	public static readonly Api VerseListBetweenIds = new VerseListBetweenIdsSE();
	public static readonly Api HebrewWords = new HebrewWordsSE();
	public static readonly Api AlephTavHebrewVerses = new AlephTavHebrewVersesSE();
	public static readonly Api AlephTavKjvVerses = new AlephTavKjvVersesSE();
	public static readonly Api AlephTavWordPartContext = new AlephTavWordPartContextSE();
	public static readonly Api AlephTavTriennialWordPartContext = new AlephTavTriennialWordPartContextSE();
	#endregion

	private Api(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract string EndPoint { get; }
	public abstract string Sql { get; }
	public abstract string SqlOrderBy { get; } // Note: `SqlOrderBy` is only needed if you need,  e.g., a custom `WHERE` clause
	#endregion

	#region Private Instantiation

	private sealed class ArticleSE : Api
	{
		public ArticleSE() : base($"{nameof(Id.Article)}", Id.Article) { }
		public override string EndPoint => "/article/{id:long}";
		public override string Sql => @"TODO";
		public override string SqlOrderBy => "";
	}

	private sealed class BookChapterSE : Api
	{
		public BookChapterSE() : base($"{nameof(Id.BookChapter)}", Id.BookChapter) { } 
		public override string EndPoint => "/bookchapter/{bookid:long}/{chapter:long}"; 
		public override string Sql => @"
		SELECT ID, BCV, Verse, VerseOffset, KJV, DescH, DescD  
		FROM Scripture
		WHERE BookID=@BookId and Chapter=@Chapter
		ORDER BY ID";
		public override string SqlOrderBy => "";
	}

	private sealed class VerseListSE : Api
	{
		public VerseListSE() : base($"{nameof(Id.VerseList)}", Id.VerseList) { }
		public override string EndPoint => "/verselist/{bookid:long}/{chapter:long}/{begverse:long}/{endverse:long}"; 
		public override string Sql => @"
SELECT ID, BCV, Verse, KJV, VerseOffset, DescH, DescD
FROM Scripture
WHERE BookId=@BookId AND Chapter=@Chapter AND Verse BETWEEN @BegVerse AND @EndVerse
ORDER BY ID";
		public override string SqlOrderBy => "";
		//DECLARE  @BookId int=1,  @Chapter int=12,  @BegVerse int=2,  @EndVerse int=3
	}

	private sealed class ParashaSE : Api
	{
		public ParashaSE() : base($"{nameof(Id.Parasha)}", Id.Parasha) { }
		public override string EndPoint => "/Parasha/{id:long}";
		public override string Sql => @"
SELECT s.ID, t.SectionId, t.RowCnt, t.VerseRange
, s.BCV, s.BookID, s.Chapter, s.Verse, s.KJV, s.VerseOffset, s.DescH, s.DescD
FROM  Scripture s
CROSS JOIN Triennial t 
wHERE t.Id = @TriennialId AND s.ID BETWEEN ScriptureID_Beg AND ScriptureID_End
ORDER BY s.ID
";
		public override string SqlOrderBy => "";   
	}

	private sealed class VerseListBetweenIdsSE : Api
	{
		public VerseListBetweenIdsSE() : base($"{nameof(Id.VerseListBetweenIds)}", Id.VerseListBetweenIds) { }  
		public override string EndPoint => "/VerseListBetweenIds/{begId:long}/{endId:long}"; 
		public override string Sql => @"
SELECT ID, BCV, Verse, KJV, VerseOffset, DescH, DescD
FROM Scripture
WHERE ID BETWEEN @BegId AND @EndId
ORDER BY ID";
		public override string SqlOrderBy => "";
		//DECLARE  @BookId int=1,  @Chapter int=12,  @BegVerse int=2,  @EndVerse int=3
	}

	private sealed class HebrewWordsSE : Api
	{
		public HebrewWordsSE() : base($"{nameof(Id.HebrewWords)}", Id.HebrewWords) { }
		public override string EndPoint => "/HebrewWords/{scriptureId:long}";
		public override string Sql => @"
SELECT ScriptureID, WordCount, SegmentCount, WordEnum, Hebrew1, Hebrew2, Hebrew3, KjvWord, Strongs, Transliteration, FinalEnum
FROM WordPart 
WHERE ScriptureID=@ScriptureID
ORDER BY WordCount";
		public override string SqlOrderBy => "";
		//DECLARE  @ScriptureID int=1
	}


	private sealed class AlephTavHebrewVersesSE : Api
	{
		public AlephTavHebrewVersesSE() : base($"{nameof(Id.AlephTavHebrewVerses)}", Id.AlephTavHebrewVerses) { }
		public override string EndPoint => "/alephtavhebrewverse/{bookid:long}/{chapter:long}";
		public override string Sql => @"
SELECT 
	s.Id AS ScriptureID, s.BCV, s.Chapter, s.Verse, wp.WordCount, wp.WordEnum
, wp.Hebrew1, wp.Hebrew2, wp.Hebrew3, wp.KjvWord, wp.Strongs, wp.Transliteration, wp.FinalEnum
, atv.HasTwo
FROM WordPart wp 
	INNER JOIN AlephTavVerse atv 
		ON wp.ScriptureID = atv.ScriptureID 
	INNER JOIN Scripture s 
		ON wp.ScriptureID = s.Id";
		public override string SqlOrderBy => " ORDER BY wp.ScriptureID, wp.WordCount";
		//DECLARE  @ScriptureID int=1
	}


	private sealed class AlephTavKjvVersesSE : Api
	{
		public AlephTavKjvVersesSE() : base($"{nameof(Id.AlephTavKjvVerses)}", Id.AlephTavKjvVerses) { }
		public override string EndPoint => "/alephtavkjvverse/{bookid:long}/{chapter:long}";
		public override string Sql => @"
SELECT  s.ID, s.BCV, s.Verse, s.VerseOffset, s.KJV, s.DescH, s.DescD  
FROM Scripture s
	INNER JOIN AlephTavVerse atv ON s.Id=atv.ScriptureID
";
		public override string SqlOrderBy => " ORDER BY s.ID";
		//DECLARE  @BookId int=1,  @Chapter int=17
	}


	private sealed class AlephTavWordPartContextSE : Api
	{
		public AlephTavWordPartContextSE() : base($"{nameof(Id.AlephTavWordPartContext)}", Id.AlephTavWordPartContext) { }
		public override string EndPoint => "/alephtavwordpartcontext/{bookid:long}/{chapter:long}";
		public override string Sql => @"
SELECT Id, BCV, BookID, Chapter, Verse
, ScriptureID, WordCount, SegmentCount, WordEnum
, Hebrew1, Hebrew2, Hebrew3
, KjvWord, Strongs, Transliteration, FinalEnum
FROM vwAlephTavVerseWordPart
WHERE BookID=@BookId and Chapter=@Chapter
ORDER BY Id
";
		public override string SqlOrderBy => "";  
	}


	private sealed class AlephTavTriennialWordPartContextSE : Api
	{
		public AlephTavTriennialWordPartContextSE() : base($"{nameof(Id.AlephTavTriennialWordPartContext)}", Id.AlephTavTriennialWordPartContext) { }
		public override string EndPoint => "/alephtavtriennialwordpartcontext/{triennialid:long}";
		public override string Sql => @"
SELECT Id, BCV, BookID, Chapter, Verse
, ScriptureID, WordCount, SegmentCount, WordEnum
, Hebrew1, Hebrew2, Hebrew3
, KjvWord, Strongs, Transliteration, FinalEnum --, TriennialId
FROM vwAlephTavTriennialWordPart
WHERE TriennialId=@TriennialId
ORDER BY Id
";
		public override string SqlOrderBy => "";
	}

	//SE

	#endregion

}
// Ignore Spelling: bookid verselist begverse endverse Nav, triennialid
