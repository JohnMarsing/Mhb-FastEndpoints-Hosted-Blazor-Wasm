using Spectre.Console;
using System.Data.SqlClient;
using Dapper;
using System.Text;

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
			new Text(stats.FinalFileName!).RightJustified()
		});

		AnsiConsole.WriteLine();
		AnsiConsole.Write(grid);
		AnsiConsole.WriteLine();
	}

	private static async Task ProcessDatabase(IProgress<ProgressInfo> progress, Stats stats)
	{
		string connectionString = "Data Source=JOHNSDELLDT\\SQLEXPRESS;Initial Catalog=TriennialCodeGen;Integrated Security=True";

		using (var connection = new SqlConnection(connectionString))
		{
			await connection.OpenAsync();  // connection.Open();

			const string  SQL = @"
			SELECT Value, RegionIdCodeGen, RegionInstanceCodeGen, SealedClassTop,
			TorahVerseCodeGen, HaftorahVerseCodeGen, BritVerseCodeGen 
			FROM TriennialCS";

			var result = connection.Query<ParashaEnumTorah>(SQL);

			UTF8Encoding encodingWithBOM = new UTF8Encoding(true); // with a BOM (Byte Order Mark) i.e. saving "With signature"

			using (var writer1 = new StreamWriter(Constants.Folder + Constants.TriennialCS_02_RegionId, false, encodingWithBOM))
			{
				await writer1.WriteLineAsync("	#region Id's");
				await writer1.WriteLineAsync("	private static class Id");
				await writer1.WriteLineAsync("	{");

				foreach (var item in result)
				{
					stats.RowsRead++;
					await writer1.WriteLineAsync($"{item.RegionIdCodeGen}");
					stats.RowsWritten = stats.RowsWritten + 2; // counter++;
					progress.Report(new ProgressInfo(.20));
				}
				await writer1.WriteLineAsync("	}");
				await writer1.WriteLineAsync("#endregion");
				await writer1.WriteLineAsync("");
			}

			using (var writer2 = new StreamWriter(Constants.Folder + Constants.TriennialCS_03_RegionInstance, false, encodingWithBOM))
			{
				await writer2.WriteLineAsync("#region Declared Public Instances");

				foreach (var item in result)
				{
					stats.RowsRead++;
					await writer2.WriteLineAsync($"{item.RegionInstanceCodeGen}");
					stats.RowsWritten = stats.RowsWritten + 2; // counter++;
					progress.Report(new ProgressInfo(.20));
				}
				await writer2.WriteLineAsync("");
				await writer2.WriteLineAsync("#endregion");
				await writer2.WriteLineAsync("");
			}

			using (var writer3 = new StreamWriter(Constants.Folder + Constants.TriennialCS_05_SealedClass, false, encodingWithBOM))
			{
				await writer3.WriteLineAsync("#region Private Instantiation");

				foreach (var item in result)
				{
					stats.RowsRead++;
					//await Task.Delay(50);
					await writer3.WriteLineAsync($"{item.SealedClassTop}");
					await writer3.WriteLineAsync($"{item.TorahVerseCodeGen}");
					await writer3.WriteLineAsync($"{item.HaftorahVerseCodeGen}");
					await writer3.WriteLineAsync($"{item.BritVerseCodeGen} {Environment.NewLine} }}");
					stats.RowsWritten = stats.RowsWritten + 4; // counter++;
					progress.Report(new ProgressInfo(.64));
				}
				await writer3.WriteLineAsync("");
				await writer3.WriteLineAsync("  #endregion");
				await writer3.WriteLineAsync("");
				await writer3.WriteLineAsync("}");
			}

			string? content;
			content =
				File.ReadAllText(Constants.Folder! + Constants.TriennialCS_01_Abstract_class) +
				File.ReadAllText(Constants.Folder! + Constants.TriennialCS_02_RegionId) +
				File.ReadAllText(Constants.Folder! + Constants.TriennialCS_03_RegionInstance) +
				File.ReadAllText(Constants.Folder! + Constants.TriennialCS_04_Constructor_ExtraFields) +
				File.ReadAllText(Constants.Folder! + Constants.TriennialCS_05_SealedClass);


			using (StreamWriter writer = new StreamWriter(Constants.Folder + stats.FinalFileName!, false, encodingWithBOM))
			{
				writer.Write(content);
			}

		}
	}

}



public class ParashaEnumTorah
{
	public int Value { get; set; }
	public string? RegionIdCodeGen { get; set; }
	public string? RegionInstanceCodeGen { get; set; }
	public string? SealedClassTop { get; set; }
	public string? TorahVerseCodeGen { get; set; }
	public string? HaftorahVerseCodeGen { get; set; }
	public string? BritVerseCodeGen { get; set; }
}


public static class Constants
{
	public const string? Folder = "C:\\Source\\repos\\FastEndpoints\\Mhb-FastEndpoints-Hosted-Blazor-Wasm-Backup\\055-Refactor-Triennial-to-TriennialCS\\";
	public const string? TriennialCS_01_Abstract_class = "TriennialCS_01_Abstract_class.txt";
	public const string? TriennialCS_02_RegionId = "TriennialCS_02_RegionId.txt";
	public const string? TriennialCS_03_RegionInstance = "TriennialCS_03_RegionInstance.txt";
	public const string? TriennialCS_04_Constructor_ExtraFields = "TriennialCS_04_Constructor_ExtraFields.txt";
	public const string? TriennialCS_05_SealedClass = "TriennialCS_05_SealedClass.txt";
}


public class Stats
{
	public int RowsRead { get; set; } = 0;
	public int RowsWritten { get; set; } = 0;
	public string? FinalFileName { get; set; } = "TriennialCS.txt";
}