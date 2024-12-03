using Dapper;
using MyHebrewBible.Database;
using MyHebrewBible.Client.Enums;
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

	public async Task<IEnumerable<BibleVerse?>> GetVerseListBetweenIds(long begId, long endId)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BegId = begId, EndId = endId });
		var versList = await connection.QueryAsync<BibleVerse>(Api.VerseListBetweenIds.Sql, Parms);
		return versList;
	}
}

// Ignore Spelling: strongs, Kjvs, Parms, atv, Mitzvot