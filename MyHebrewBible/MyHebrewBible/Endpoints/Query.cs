using Dapper;
using MyHebrewBible.Database;
using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.Parasha.Enums;
using ArticleEnums = MyHebrewBible.Client.Features.Articles.Search.Enums;

namespace MyHebrewBible.Endpoints;

public class Query
{
	#region DI
	private readonly ILogger<Query> _logger;
	private readonly IDbConnectionFactory _connectionFactory;
	public DynamicParameters? Parms { get; set; }
	public Query(IDbConnectionFactory connectionFactory, ILogger<Query> logger)
	{
		_connectionFactory = connectionFactory;
		_logger = logger;
	}
	#endregion


	#region AlephTav
	public async Task<IEnumerable<AlephTavHebrewVerse?>> GetAlephTavHebrewVerses(long bookId, long chapter)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		string sql;
		if (chapter == 0)
		{
			Parms = new DynamicParameters(new { BookId = bookId });
			sql = Api.AlephTavHebrewVerses.Sql + " WHERE s.BookID=@BookId " + Api.AlephTavHebrewVerses.SqlOrderBy;
			var verseList = await connection.QueryAsync<AlephTavHebrewVerse>(sql, Parms);
			return verseList;
		}
		else
		{
			Parms = new DynamicParameters(new { BookId = bookId, Chapter = chapter });
			sql = Api.AlephTavHebrewVerses.Sql + " WHERE s.BookID=@BookId and s.Chapter=@Chapter " + Api.AlephTavHebrewVerses.SqlOrderBy;
			var verseList = await connection.QueryAsync<AlephTavHebrewVerse>(sql, Parms);
			return verseList;
		}
	}


	public async Task<IEnumerable<BibleVerseAT?>> GetAlephTavKjvVerses(long bookID, long chapter)
	{
		//_logger.LogDebug("{Method} Get B/C: {bookID}/{chapter}", nameof(GetAlephTavKjvVerses), bookID, chapter);
		using var connection = await _connectionFactory.CreateConnectionAsync();
		string sql;
		if (chapter == 0)
		{
			Parms = new DynamicParameters(new { BookId = bookID });
			sql = $"{Api.AlephTavKjvVerses.Sql} WHERE s.BookID=@BookId {Api.AlephTavKjvVerses.SqlOrderBy}";
			var verseList = await connection.QueryAsync<BibleVerseAT>(sql, Parms);
			return verseList;
		}
		else
		{
			Parms = new DynamicParameters(new { BookId = bookID, Chapter = chapter });
			sql = $"{Api.AlephTavKjvVerses.Sql} WHERE s.BookID=@BookId and s.Chapter=@Chapter {Api.AlephTavKjvVerses.SqlOrderBy}";
			var verseList = await connection.QueryAsync<BibleVerseAT>(sql, Parms);
			return verseList;

		}
	}

	public async Task<IEnumerable<AlephTavBookChapterWordPartContext?>> GetAlephTavWordPartContext(long bookId, long chapter)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BookId = bookId, Chapter = chapter });
		var verseList = await connection.QueryAsync<AlephTavBookChapterWordPartContext>(Api.AlephTavBookChapterWordPartContext.Sql, Parms);
		return verseList;
	}

	public async Task<IEnumerable<AlephTavTriennialWordPartContext?>> GetAlephTavTriennialWordPartContext(long triennialId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { TriennialId = triennialId });
		var verseList = await connection.QueryAsync<AlephTavTriennialWordPartContext>(Api.AlephTavTriennialWordPartContext.Sql, Parms);
		return verseList;
	}
	#endregion


	#region Articles
	public async Task<Article?> GetArticle(long id)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { Id = id });
		var article = await connection.QuerySingleOrDefaultAsync<Article>(Api.Article.Sql, Parms);
		return article;
	}

	public async Task<IEnumerable<ArticleList?>> GetArticleList(long filter)
	{
		ArticleEnums.Filter filterSmartEnum = ArticleEnums.Filter.FromValue((int)filter);
		string where = filterSmartEnum.Where;
		string sql = $"{Api.ArticleList.Sql} {where} {Api.ArticleList.SqlOrderBy}";
		using var connection = await _connectionFactory.CreateConnectionAsync();
		_logger.LogDebug("{Method} Sql: {sql}", nameof(ArticleList), sql);
		var articleList = await connection.QueryAsync<ArticleList>(sql);
		return articleList;
	}
	#endregion

	#region BibleVerse
	public async Task<IEnumerable<BibleVerseBC?>> GetBookChapter(long bookID, long chapter)
	{
		try
		{
			_logger.LogDebug("{ Method} Get B/C: {bookID}/{chapter}"
				, nameof(GetBookChapter), bookID, chapter);
			using var connection = await _connectionFactory.CreateConnectionAsync();
			Parms = new DynamicParameters(new { BookId = bookID, Chapter = chapter });
			var verseList = await connection.QueryAsync<BibleVerseBC>(Api.BookChapter.Sql, Parms);
			return verseList;
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method} Sql:{Sql}", nameof(GetBookChapter), Api.BookChapter.Sql);
			throw;
		}
	}


	public async Task<IEnumerable<Mitzvah?>> GetMitzvot(long bookId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BookId = bookId });
		var mitzvot = await connection.QueryAsync<Mitzvah>(Api.Mitzvah.Sql, Parms);
		return mitzvot;
	}

	public async Task<IEnumerable<BibleVerseBCV?>> GetVerseListByBCV(long bookId, long chapter, long begVerse, long endVerse)
	{
		try
		{
			_logger.LogDebug("{Method} QueryAsync BCVbVe: {BookId}/{Chapter}/{BegVerse}/{EndVerse}"
				, nameof(GetVerseListByBCV), bookId, chapter, begVerse, endVerse);
			using var connection = await _connectionFactory.CreateConnectionAsync();
			Parms = new DynamicParameters(new { BookId = bookId, Chapter = chapter, BegVerse = begVerse, EndVerse = endVerse });
			var versList = await connection.QueryAsync<BibleVerseBCV>(Api.VerseList.Sql, Parms);
			return versList;
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method} Sql:{Sql}", nameof(GetVerseListByBCV), Api.BookChapter.Sql);
			throw;
		}
	}

	#endregion

	/*
	### Note: `SqlOrderBy` is only needed if you need,  e.g., a custom `WHERE` clause

	```csharp
	string sql = $"{Api.Parasha.Sql} {Api.Parasha.SqlOrderBy}";
	_logger.LogDebug("{Method} triennialId: {triennialId}; sql: {sql}"
		, nameof(GetParasha), triennialId, sql);
	var versList = await connection.QueryAsync<Parasha>($"{Api.Parasha.Sql} {Api.Parasha.SqlOrderBy}", Parms);
	```
 */

	public async Task<IEnumerable<Parasha?>> GetParasha(long triennialId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { TriennialId = triennialId });
		var versList = await connection.QueryAsync<Parasha>(Api.Parasha.Sql, Parms);
		return versList;
	}

	public async Task<IEnumerable<BibleVerseId?>> GetVerseListBetweenIds(long begId, long endId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BegId = begId, EndId = endId });
		var versList = await connection.QueryAsync<BibleVerseId>(Api.VerseListBetweenIds.Sql, Parms);
		return versList;
	}


	#region WordPart
	public async Task<IEnumerable<WordPartByScriptureId?>> GetWordPartByScriptureId(long scriptureId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureId });
		var versList = await connection.QueryAsync<WordPartByScriptureId>(Api.WordPartByScriptureId.Sql, Parms);
		return versList;
	}

	public async Task<IEnumerable<WordPartByStrongs?>> GetWordPartsByStrongs(long scriptureID, long strongs)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureID, Strongs = strongs });
		var wordParts = await connection.QueryAsync<WordPartByStrongs>(Api.WordPartByStrongs.Sql, Parms);
		return wordParts;
	}

	public async Task<IEnumerable<WordPartKjv?>> GetWordPartKjv(long scriptureID)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureID });
		var wordParts = await connection.QueryAsync<WordPartKjv>(Api.WordPartKjv.Sql, Parms);
		return wordParts;
	}
	#endregion

}

// Ignore Spelling: strongs, Kjvs, Parms, atv, Mitzvot