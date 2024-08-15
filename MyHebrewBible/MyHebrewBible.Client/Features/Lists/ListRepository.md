```csharp
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Bible.Domain;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Bible.Data
{
	public class ListRepository : BaseRepositoryAsync, IListRepository
	{
		const int maxTop = 500;

		public ListRepository(IConfiguration config, ILogger<ListRepository> logger) : base(config, logger)
		{
		}

		public string BaseSqlDump
		{
			get { return base.SqlDump; }
		}

		public async Task<List<Mitzvah>> GetMitzvotByBookAsync(int bookId)
		{
			base.Parms = new DynamicParameters(new { BookId = bookId });
			base.Sql = $@"
SELECT  TOP 700 ID, Detail, ScriptureID_Beg, ScriptureID_End, Verse, Descr
FROM ListMitzVot
WHERE BookId = @BookId
ORDER BY ID
";
			return await WithConnectionAsync(async connection =>
			{
				var verses = await connection.QueryAsync<Mitzvah>(sql: base.Sql, param: base.Parms);
				return verses.ToList();
			});
		}

		public async Task<List<JotAndTittle>> GetAllJotAndTittleAsync()
		{
			base.Sql = $@"
SELECT  TOP 200 ID, ScriptureID, Verse, Notes, HTMLFormatEng
FROM ListJotAndTittle
ORDER BY ScriptureID
";
			return await WithConnectionAsync(async connection =>
			{
				var verses = await connection.QueryAsync<JotAndTittle>(sql: base.Sql);
				return verses.ToList();
			});
		}

		public async Task<List<EmendationBook>> GetEmendationBooksAsync()
		{
			base.Sql = $@"
SELECT  b.ID as BookID, b.Abrv AS BookAbrv, b.Title AS BookTitle, COUNT(*) AS RowCnt
FROM ListEmendation e
INNER JOIN Book b ON e.ScriptureID between b.ScriptureID_Beg and b.ScriptureID_End
GROUP BY b.ID, b.Abrv, b.Title
ORDER BY B.id

";
			return await WithConnectionAsync(async connection =>
			{
				var rows = await connection.QueryAsync<EmendationBook>(sql: base.Sql);
				return rows.ToList();
			});
		}

		public async Task<List<Emendation>> GetAllEmendationsAsync()
		{
			base.Sql = $@"
SELECT TOP 200 e.ID, e.Detail, e.ScriptureID, Verse, b.ID as BookID, b.Abrv AS BookAbrv
, REPLACE(REPLACE(Verse,' ', '-'),':', '-') AS Slug
FROM ListEmendation e
INNER JOIN Book b ON e.ScriptureID between b.ScriptureID_Beg and b.ScriptureID_End
ORDER BY e.ScriptureID, e.Detail
";
			return await WithConnectionAsync(async connection =>
			{
				var rows = await connection.QueryAsync<Emendation>(sql: base.Sql);
				return rows.ToList();
			});
		}

	}
}

```