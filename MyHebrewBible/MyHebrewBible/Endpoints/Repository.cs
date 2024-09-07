using Dapper;
using MyHebrewBible.Database;

namespace MyHebrewBible.Endpoints;

public class Repository
{
	private readonly IDbConnectionFactory _connectionFactory;
	public DynamicParameters? Parms { get; set; }

	public Repository(IDbConnectionFactory connectionFactory)
	{
		_connectionFactory = connectionFactory;
	}

	public async Task<IEnumerable<BibleVerse?>> GetBookChapter(long bookID, long chapter)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BookId = bookID, Chapter = chapter });
		var verseList = await connection.QueryAsync<BibleVerse>(@"
		SELECT ID, BCV, Verse, VerseOffset, KJV, DescH, DescD  
		FROM Scripture 
		WHERE BookID=@BookId and Chapter=@Chapter
		ORDER BY ID", Parms);

		return verseList;
	}

  public async Task<IEnumerable<WordPart?>> GetWordParts(long scriptureID)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureID});

		var wordParts = await connection.QueryAsync<WordPart>(@"
SELECT ScriptureID, WordCount, SegmentCount, WordEnum, Hebrew1, Hebrew2, Hebrew3, KjvWord, Strongs, Transliteration, FinalEnum
FROM WordPart 
WHERE ScriptureID=@ScriptureID
ORDER BY WordCount, SegmentCount
", Parms);

		return wordParts;
	}

  public async Task<IEnumerable<Mitzvah?>> GetMitzvot(long bookId)
  {
    using var connection = await _connectionFactory.CreateConnectionAsync();
    Parms = new DynamicParameters(new { BookId = bookId });

    var mitzvot = await connection.QueryAsync<Mitzvah>(@"
SELECT
ID, Detail, BegId, EndID, Verse, Descr, BookID, BookAbrv
FROM MitzVot
WHERE BookId=@BookId
ORDER BY BegId
", Parms);

    return mitzvot;
  }

  public async Task<IEnumerable<BibleVerse?>> GetVerseList(long begdId, long endId)
  {
    using var connection = await _connectionFactory.CreateConnectionAsync();
    Parms = new DynamicParameters(new { BegId = begdId, EndId = endId });

    var versList = await connection.QueryAsync<BibleVerse>(@"

SELECT ID, BCV, Verse, KJV, VerseOffset, DescH, DescD
FROM Scripture
WHERE ID BETWEEN @BegId AND @EndId
ORDER BY ID
", Parms);
		return versList;
  }

	public async Task<IEnumerable<BibleVerse?>> GetVerseListByBCV(long bookId, long chapter, long begVerse, long endVerse)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BookId = bookId, Chapter = chapter, BegVerse = begVerse, EndVerse = endVerse });

		//DECLARE  @BookId int=1,  @Chapter int=12,  @BegVerse int=2,  @EndVerse int=3
		//ToDo: I don't really need DescH and DescD
		var versList = await connection.QueryAsync<BibleVerse>(@"
SELECT ID, BCV, Verse, KJV, VerseOffset, DescH, DescD
FROM Scripture
WHERE BookId=@BookId AND Chapter=@Chapter AND Verse BETWEEN @BegVerse AND @EndVerse
ORDER BY ID
", Parms);

		return versList;
	}


	public async Task<IEnumerable<WordPart?>> GetWordPartsByStrongs(long scriptureID, long strongs)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureID, Strongs = strongs });

		var wordParts = await connection.QueryAsync<WordPart>(@"
SELECT ScriptureID, WordCount, SegmentCount, WordEnum, Hebrew1, Hebrew2, Hebrew3, KjvWord, Strongs, Transliteration, FinalEnum
FROM WordPart 
WHERE ScriptureID=@ScriptureID and Strongs=@Strongs
ORDER BY WordCount, SegmentCount
", Parms);

		return wordParts;
	}

	public async Task<IEnumerable<WordPartKjv?>> GetWordPartKjvs(long scriptureID)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureID });

		var wordParts = await connection.QueryAsync<WordPartKjv>(@"
SELECT ScriptureID, WordCount, Strongs, Word
FROM WordPartKjv
WHERE ScriptureID=@ScriptureID
ORDER BY WordCount
", Parms);

		return wordParts;
	}


	public async Task<Article?> GetArticle(long id)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { Id = id});
		var article = await connection.QuerySingleOrDefaultAsync<Article>(@"
SELECT a.Id, FileNameNoExt, Title, Details, DetailsMD, PrimaryScriptureId, CreateDate
, DocBlobID, PdfBlobID, IsPlaceHolder, IsFavorite, ExtraVerses, IsWordStudy, IsParasha
, s.BCV, s.BookID, s.Chapter, s.Verse
--, LEFT(BCV,3) AS BookAbrv
FROM Article a 
LEFT OUTER JOIN Scripture s ON a.PrimaryScriptureId = s.ID
WHERE a.Id = @Id", Parms);
		return article;
	}


	public async Task<IEnumerable<ArticleList?>> GetArticleList()
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		var articleList = await connection.QueryAsync<ArticleList>(@"
SELECT Id, Title, IsFavorite, IsPlaceHolder, IsParasha
FROM Article 
ORDER BY Id
");
		return articleList;
	}

}

// Ignore Spelling: strongs, Kjvs, Parms
