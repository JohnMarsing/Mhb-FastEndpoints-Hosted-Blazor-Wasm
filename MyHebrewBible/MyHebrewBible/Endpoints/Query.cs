using Dapper;
using MyHebrewBible.Database;
using MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.Parasha.Enums;
//using ArticleEnums = MyHebrewBible.Client.Features.Articles.Search.Enums;

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

	public async Task<IEnumerable<BibleVerse?>> GetBookChapter(long bookID, long chapter)
	{
		try
		{
			_logger.LogDebug("{Method} Get B/C: {bookID}/{chapter}"
				, nameof(GetBookChapter), bookID, chapter);
			using var connection = await _connectionFactory.CreateConnectionAsync();
			Parms = new DynamicParameters(new { BookId = bookID, Chapter = chapter });
			var verseList = await connection.QueryAsync<BibleVerse>(Api.BookChapter.Sql, Parms);
			return verseList;
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method} Sql:{Sql}", nameof(GetBookChapter), Api.BookChapter.Sql);
			throw;
		}
	}

	public async Task<IEnumerable<BibleVerse?>> GetVerseListByBCV(long bookId, long chapter, long begVerse, long endVerse)
	{
		try
		{
			_logger.LogDebug("{Method} QueryAsync BCVbVe: {BookId}/{Chapter}/{BegVerse}/{EndVerse}"
				, nameof(GetVerseListByBCV), bookId, chapter, begVerse, endVerse);
			using var connection = await _connectionFactory.CreateConnectionAsync();
			Parms = new DynamicParameters(new { BookId = bookId, Chapter = chapter, BegVerse = begVerse, EndVerse = endVerse });
			var versList = await connection.QueryAsync<BibleVerse>(Api.VerseList.Sql, Parms);
			return versList;
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method} Sql:{Sql}", nameof(GetVerseListByBCV), Api.BookChapter.Sql);
			throw;
		}
	}


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

	public async Task<IEnumerable<BibleVerse?>> GetVerseListBetweenIds(long begId, long endId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BegId = begId, EndId = endId });
		var versList = await connection.QueryAsync<BibleVerse>(Api.VerseListBetweenIds.Sql, Parms);
		return versList;
	}


	public async Task<IEnumerable<WordPart?>> GetWordPartByScriptureId(long scriptureId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureId });
		var versList = await connection.QueryAsync<WordPart>(Api.HebrewWords.Sql, Parms);
		return versList;
	}

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


	public async Task<IEnumerable<BibleVerse?>> GetAlephTavKjvVerses(long bookID, long chapter)
	{
		//_logger.LogDebug("{Method} Get B/C: {bookID}/{chapter}", nameof(GetAlephTavKjvVerses), bookID, chapter);
		using var connection = await _connectionFactory.CreateConnectionAsync();
		string sql;
		if (chapter == 0)
		{
			Parms = new DynamicParameters(new { BookId = bookID });
			sql = $"{Api.AlephTavKjvVerses.Sql} WHERE s.BookID=@BookId {Api.AlephTavKjvVerses.SqlOrderBy}";
			var verseList = await connection.QueryAsync<BibleVerse>(sql, Parms);
			return verseList;
		}
		else
		{
			Parms = new DynamicParameters(new { BookId = bookID, Chapter = chapter });
			sql = $"{Api.AlephTavKjvVerses.Sql} WHERE s.BookID=@BookId and s.Chapter=@Chapter {Api.AlephTavKjvVerses.SqlOrderBy}";
			var verseList = await connection.QueryAsync<BibleVerse>(sql, Parms);
			return verseList;

		}
	}


	public async Task<IEnumerable<AlephTavWordPartContext?>> GetAlephTavWordPartContext(long bookId, long chapter)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BookId = bookId, Chapter = chapter });
		var verseList = await connection.QueryAsync<AlephTavWordPartContext>(Api.AlephTavWordPartContext.Sql, Parms);
		return verseList;
	}

	public async Task<IEnumerable<AlephTavWordPartContext?>> GetAlephTavTriennialWordPartContext(long triennialId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { TriennialId = triennialId});
		var verseList = await connection.QueryAsync<AlephTavWordPartContext>(Api.AlephTavTriennialWordPartContext.Sql, Parms);
		return verseList;
	}

}

// Ignore Spelling: strongs, Kjvs, Parms, atv, Mitzvot