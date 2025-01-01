using Spectre.Console;
using System.Data.SqlClient;
using Dapper;

internal class Program
{
	record ProgressInfo(double BookTaskIncrease);

	class AnsiConsoleProgress
	{
		private readonly ProgressTask _taskBook;
		private readonly object _consoleLock = new object();

		public AnsiConsoleProgress(ProgressTask taskBook)
		{
			_taskBook = taskBook;
		}

		public void ReportProgress(ProgressInfo info)
		{
			lock (_consoleLock)
			{
				_taskBook.Increment(info.BookTaskIncrease);
			}
		}
	}

	public static async Task Main(string[] args)
	{
		AnsiConsole.MarkupLine("[blue]Start BuildTriennialSmartEnum [/]");
		AnsiConsole.WriteLine();

		Stats stats = new Stats();

		try
		{
			await AnsiConsole.Progress()
			.StartAsync(async ctx =>
			{
				var task1 = ctx.AddTask("[green]Processing Triennials[/]");
				var ansiProgress = new AnsiConsoleProgress(task1);
				var progress = new Progress<ProgressInfo>(ansiProgress.ReportProgress);
				await ProcessDatabase(progress, stats);
			});
		}
		catch (Exception ex)
		{
			AnsiConsole.WriteLine();
			AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
			AnsiConsole.WriteLine();
		}
		finally
		{
			PrintStats(stats);
			AnsiConsole.Write(
				new FigletText("Finished")
				.Centered()
				.Color(Color.Aqua));
		}

	}

	private static void PrintStats(Stats stats)
	{
		var grid = new Grid();
		grid.AddColumn();
		grid.AddColumn();
		grid.AddColumn();

		// Add header row 
		grid.AddRow(new Text[]{
			new Text("Rows Read", new Style(Color.Red, Color.Black)).Centered(),  //.LeftJustified(),
			new Text("Rows Written", new Style(Color.Green, Color.Black)).Centered(),
			new Text("New File", new Style(Color.Blue, Color.Black)).RightJustified()
		});

		// Add content row 
		grid.AddRow(new Text[]{
			new Text(stats.RowsRead.ToString()).Centered(),
			new Text(stats.RowsWritten.ToString()).Centered(),
			new Text(stats.FileName!).RightJustified()
		});

		AnsiConsole.WriteLine();
		AnsiConsole.Write(grid);
		AnsiConsole.WriteLine();
	}

	private static async Task ProcessDatabase(IProgress<ProgressInfo> progress, Stats stats)
	{
		string connectionString = "Data Source=JOHNSDELLDT\\SQLEXPRESS;Initial Catalog=Triennial;Integrated Security=True";

		using (var connection = new SqlConnection(connectionString))
		{
			await connection.OpenAsync();  // connection.Open();
			var sql = "SELECT Value, RegionIdCodeGen, RegionInstanceCodeGen, ClassCodeGen, TorahVerseCodeGen, HaftorahVerseCodeGen, BritVerseCodeGen FROM ParashaEnumTorah";
			var result = connection.Query<ParashaEnumTorah>(sql);

			using (var writer = new StreamWriter(stats.FileName!)) //folder + "TriennialSmartEnum.txt"
			{
				await writer.WriteLineAsync("");

				await writer.WriteLineAsync("#region Private Instantiation");

				foreach (var item in result)
				{
					stats.RowsRead++;
					//await Task.Delay(50);
					await writer.WriteLineAsync($"{item.ClassCodeGen}");
					await writer.WriteLineAsync($"{item.TorahVerseCodeGen}");
					await writer.WriteLineAsync($"{item.HaftorahVerseCodeGen}");
					await writer.WriteLineAsync($"{item.BritVerseCodeGen} {Environment.NewLine} }}");  
					stats.RowsWritten = stats.RowsWritten + 4; // counter++;
					progress.Report(new ProgressInfo(.64));
				}
				await writer.WriteLineAsync("");
				await writer.WriteLineAsync("#endregion");

			}
		}
	}
}


public class ParashaEnumTorah
{
	public int Value { get; set; }
	public string? RegionIdCodeGen { get; set; }
	public string? RegionInstanceCodeGen { get; set; }
	public string? ClassCodeGen { get; set; }
	public string? TorahVerseCodeGen { get; set; }
	public string? HaftorahVerseCodeGen { get; set; }
	public string? BritVerseCodeGen { get; set; }
}

public class Stats
{
	public int RowsRead { get; set; } = 0;
	public int RowsWritten { get; set; } = 0;
	//public string? FileName { get; set; } = "C:\\Source\\repos\\FastEndpoints\\Mhb-FastEndpoints-Hosted-Blazor-Wasm-Backup\\034-CodeGen-Triennial-SmartEnum-class\\" + "TriennialSmartEnum.txt";
	public string? FileName { get; set; } = "C:\\Source\\repos\\FastEndpoints\\Mhb-FastEndpoints-Hosted-Blazor-Wasm-Backup\\054-rebuild-TriennialSmartEnum\\Database-Changes-CodeGen\\" + "TriennialSmartEnum.txt";
}