using Dapper;
using MyHebrewBible.Database;
using ArticleEnums = MyHebrewBible.Client.Features.Articles.Search.Enums;

namespace MyHebrewBible.Endpoints;

public class Repository
{
	private readonly ILogger<Repository> _logger;
	private readonly IDbConnectionFactory _connectionFactory;
	public DynamicParameters? Parms { get; set; }

	public Repository(IDbConnectionFactory connectionFactory, ILogger<Repository> logger)
	{
		_connectionFactory = connectionFactory;
		_logger = logger;
	}

	#region GetBookChapter
	private const string SqlGetBookChapter = @"
		SELECT ID, BCV, Verse, VerseOffset, KJV, DescH, DescD  
		FROM Scripture
		WHERE BookID=@BookId and Chapter=@Chapter
		ORDER BY ID";

	public async Task<IEnumerable<BibleVerse?>> GetBookChapter(long bookID, long chapter)
	{
		try
		{
			_logger.LogDebug("{Method} Get B/C: {bookID}/{chapter}"
				, nameof(GetBookChapter), bookID, chapter);
			using var connection = await _connectionFactory.CreateConnectionAsync();
			Parms = new DynamicParameters(new { BookId = bookID, Chapter = chapter });
			var verseList = await connection.QueryAsync<BibleVerse>(SqlGetBookChapter, Parms);
			return verseList;
		}
		catch (Exception ex)
		{ 
			_logger!.LogError(ex, "{Method} Sql:{Sql}", nameof(GetBookChapter), SqlGetBookChapter);
			throw;
		}
	}
	#endregion

	public async Task<IEnumerable<WordPart?>> GetWordParts(long scriptureID)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureID });

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

	#region AlephTavHebrewVerse
	private const string alephTavHebrewVerseSelect = @"
SELECT 
	s.Id AS ScriptureID, s.BCV, s.Chapter, s.Verse, wp.WordCount, wp.WordEnum
, wp.Hebrew1, wp.Hebrew2, wp.Hebrew3, wp.KjvWord, wp.Strongs, wp.Transliteration, wp.FinalEnum
, atv.HasTwo
FROM WordPart wp 
	INNER JOIN AlephTavVerse atv 
		ON wp.ScriptureID = atv.ScriptureID 
	INNER JOIN Scripture s 
		ON wp.ScriptureID = s.Id
		";

	private const string alephTavHebrewVerseOrderBy = "ORDER BY wp.ScriptureID, wp.WordCount";

	public async Task<IEnumerable<AlephTavHebrewVerse?>> GetAlephTavHebrewVerses(long bookId, long chapter)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		if (chapter == 0)
		{
			Parms = new DynamicParameters(new { BookId = bookId });
			var verseList = await connection.QueryAsync<AlephTavHebrewVerse>(
				$"{alephTavHebrewVerseSelect} WHERE s.BookID=@BookId {alephTavHebrewVerseOrderBy}", Parms);
			return verseList;
		}
		else
		{
			Parms = new DynamicParameters(new { BookId = bookId, Chapter = chapter });
			var verseList = await connection.QueryAsync<AlephTavHebrewVerse>(
				$"{alephTavHebrewVerseSelect} WHERE s.BookID=@BookId and s.Chapter=@Chapter {alephTavHebrewVerseOrderBy}", Parms);
			return verseList;
		}
		#endregion

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
		Parms = new DynamicParameters(new { Id = id });
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


	public async Task<IEnumerable<ArticleList?>> GetArticleList(long filter)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();

		const string select = "SELECT Id, Title FROM Article ";
		const string order = " ORDER BY Title";

		ArticleEnums.Filter filterSmartEnum = ArticleEnums.Filter.FromValue((int)filter);
		string where = filterSmartEnum.Where;
		string sql = $"{select} {where} {order}";

		var articleList = await connection.QueryAsync<ArticleList>(sql);
		return articleList;
	}

}

// Ignore Spelling: strongs, Kjvs, Parms, atv, Mitzvot
