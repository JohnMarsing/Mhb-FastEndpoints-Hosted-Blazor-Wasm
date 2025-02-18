using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Endpoints;

public class TableRowCountRequest
{
	public int Id { get; set; }
}

public class GetTableRowCounts : Endpoint<TableRowCountRequest, IEnumerable<TableRowCount>>
{
	public override void Configure()
	{
		Get(Api.TableRowCount.EndPoint);
		AllowAnonymous();
	}

	#region DI
	private readonly Query _db;
	private readonly ILogger<GetTableRowCounts> _logger;
	public GetTableRowCounts(Query query, ILogger<GetTableRowCounts> logger)
	{
		_db = query;
		_logger = logger;
	}
	#endregion


	public override async Task HandleAsync(TableRowCountRequest request, CancellationToken c)
	{
		//_logger.LogDebug("{Method} Id: {Id}", nameof(HandleAsync), request.Id);
		_logger.LogDebug("{Method}", nameof(HandleAsync));
		try
		{
			IEnumerable<TableRowCount?> tableRowCount = await _db.GetTableRowCount();
			await SendAsync(tableRowCount!);
		}
		catch (Exception ex)
		{
			_logger!.LogError(ex, "{Method}", nameof(HandleAsync));
			throw;
		}
	}
}

public record TableRowCount
{
	public int RowCnt { get; init; }
	public string? Name { get; init; }
}
// Ignore Spelling: Cnt, Mitzvot