using Dapper;
using MyHebrewBible.Database;
using MyHebrewBible.Client.Enums;
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
	public async Task<IEnumerable<AlephTavHebrewVerse?>> GetAlephTavHebrewVerses(int bookId, int chapter)
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


	public async Task<IEnumerable<BibleVerseAT?>> GetAlephTavKjvVerses(int bookID, int chapter)
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
	#endregion

	#region Articles
	public async Task<Article?> GetArticle(int id)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { Id = id });
		var article = await connection.QuerySingleOrDefaultAsync<Article>(Api.Article.Sql, Parms);
		return article;
	}

	public async Task<IEnumerable<ArticleList?>> GetArticleList(int filter)
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
	public async Task<IEnumerable<BookChapterWithAT?>> GetBookChapterWithAT(int bookID, int chapter)
	{
		_logger.LogDebug("{Method} Get B/C: {bookID}/{chapter}", nameof(GetBookChapterWithAT), bookID, chapter);
		try
		{
			using (var connection = await _connectionFactory.CreateConnectionAsync())
			{
				Parms = new DynamicParameters(new { BookId = bookID, Chapter = chapter });

				// first call the detail record set because it's more likely than not it will be empty.
				// if it is empty, then we can skip the second call.
				var wordPart = await connection.QueryAsync<CommonDtos.WordPart>(Api.BookChapterWithAT.SqlDetail, Parms);

				if (wordPart is not null && wordPart.Any())
				{
					var sciptureList = await connection.QueryAsync<BookChapterWithAT>(Api.BookChapterWithAT.Sql, Parms);

					// join the two lists by using a LINQ query expression
					var query =
							from s in sciptureList
							join wp in wordPart
							on s.ID equals wp.ScriptureID into wpGroup
							select new BookChapterWithAT
							{
								ID = s.ID,
								BCV = s.BCV,
								Verse = s.Verse,
								VerseOffset = s.VerseOffset,
								KJV = s.KJV,
								DescH = s.DescH,
								DescD = s.DescD,
								WordPartList = wpGroup.ToList()
							};
					return query;
				}
				else
				{
					// the detail record set is empty, so we can skip the second call
					var sciptureList = await connection.QueryAsync<BookChapterWithAT>(Api.BookChapterWithAT.Sql, Parms);
					return sciptureList;
				}
			}
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method} Sql:{Sql}", nameof(GetBookChapterWithAT), Api.BookChapterWithAT.Sql);
			throw;
		}
	}
	#endregion

	public async Task<IEnumerable<Mitzvah?>> GetMitzvot(int bookId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BookId = bookId });
		var mitzvot = await connection.QueryAsync<Mitzvah>(Api.Mitzvah.Sql, Parms);
		return mitzvot;
	}

	public async Task<IEnumerable<BibleVerseBCV?>> GetVerseListByBCV(int bookId, int chapter, int begVerse, int endVerse)
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
			_logger!.LogError(ex, "{Method} Sql:{Sql}", nameof(GetVerseListByBCV), Api.VerseList.Sql);
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

	public async Task<IEnumerable<ParashaWithAT?>> GetParashaWithAT(int triennialId)
	{
		_logger.LogDebug("{Method} Get ParashaId : {triennialId}", nameof(GetParashaWithAT), triennialId);
		try
		{
			using (var connection = await _connectionFactory.CreateConnectionAsync())
			{
				Parms = new DynamicParameters(new { TriennialId = triennialId });
				var wordPart = await connection.QueryAsync<CommonDtos.WordPart>(Api.ParashaWithAT.SqlDetail, Parms);
				if (wordPart is not null && wordPart.Any())
				{
					var sciptureList = await connection.QueryAsync<ParashaWithAT>(Api.ParashaWithAT.Sql, Parms);

					// join the two lists by using a LINQ query expression
					var query =
							from s in sciptureList
							join wp in wordPart
							on s.ID equals wp.ScriptureID into wpGroup
							select new ParashaWithAT
							{
								ID = s.ID,
								SectionId = s.SectionId,
								GroupCount = s.GroupCount,
								ScriptureID_Beg = s.ScriptureID_Beg,
								VerseRange = s.VerseRange,
								BCV = s.BCV,
								BookID = s.BookID,
								Chapter = s.Chapter,
								Verse = s.Verse,
								VerseOffset = s.VerseOffset,
								KJV = s.KJV,
								DescH = s.DescH,
								DescD = s.DescD,
								WordPartList = wpGroup.ToList()
							};
					return query;
				}
				else
				{
					// the detail record set is empty, so we can skip the second call
					var sciptureList = await connection.QueryAsync<ParashaWithAT>(Api.ParashaWithAT.Sql, Parms);
					return sciptureList;
				}
			}
		}

		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method} Sql:{Sql}", nameof(GetBookChapterWithAT), Api.BookChapterWithAT.Sql);
			throw;
		}
	}

	public async Task<IEnumerable<TableRowCount?>> GetTableRowCount()
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		var tableRowCounts = await connection.QueryAsync<TableRowCount>(Api.TableRowCount.Sql);
		return tableRowCounts;
	}

	public async Task<IEnumerable<BibleVerseId?>> GetVerseListBetweenIds(int begId, int endId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BegId = begId, EndId = endId });
		var versList = await connection.QueryAsync<BibleVerseId>(Api.VerseListBetweenIds.Sql, Parms);
		return versList;
	}


	#region WordPart
	public async Task<IEnumerable<WordPartByScriptureId?>> GetWordPartByScriptureId(int scriptureId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureId });
		var versList = await connection.QueryAsync<WordPartByScriptureId>(Api.WordPartByScriptureId.Sql, Parms);
		return versList;
	}

	public async Task<IEnumerable<WordPartByStrongs?>> GetWordPartsByStrongs(int scriptureID, int strongs)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureID, Strongs = strongs });
		var wordParts = await connection.QueryAsync<WordPartByStrongs>(Api.WordPartByStrongs.Sql, Parms);
		return wordParts;
	}

	public async Task<IEnumerable<WordPartKjv?>> GetWordPartKjv(int scriptureID)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { ScriptureID = scriptureID });
		var wordParts = await connection.QueryAsync<WordPartKjv>(Api.WordPartKjv.Sql, Parms);
		return wordParts;
	}
	#endregion

}

// Ignore Spelling: strongs, Kjvs, Parms, atv, Mitzvot