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

	public async Task<IEnumerable<BookChapter?>> GetBookChapter(long bookID, long chapter)
	{
		using var connection = await _connectionFactory.CreateConnectionAsync();
		Parms = new DynamicParameters(new { BookId = bookID, Chapter = chapter });
		var verseList = await connection.QueryAsync<BookChapter>(@"
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

}

// Ignore Spelling: strongs, Kjvs, Parms
