using Spectre.Console;
using System.Data.SQLite;
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
		AnsiConsole.MarkupLine("[blue]Start CopySqliteDB [/]");
		AnsiConsole.WriteLine();

		Stats stats = new Stats();

		try
		{
			await AnsiConsole.Progress()
			.StartAsync(async ctx =>
			{
				var task1 = ctx.AddTask("[green]Processing CopySqliteDB[/]");
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

		// Add header row 
		grid.AddRow(new Text[]{
			new Text("Rows Copied", new Style(Color.Red, Color.Black)).Centered(),  //.LeftJustified(),
			new Text("Table Name", new Style(Color.Blue, Color.Black)).RightJustified()
		});

		// Add content row 
		grid.AddRow(new Text[]{
			new Text(stats.RowsCopied.ToString()).Centered(),
			new Text(stats.TableName!.ToString()).Centered(),
		});

		AnsiConsole.WriteLine();
		AnsiConsole.Write(grid);
		AnsiConsole.WriteLine();
	}


	private static async Task ProcessDatabase(IProgress<ProgressInfo> progress, Stats stats)
	{
		string tableName = "";
		int rowsCopied = 0;
		string readConnectionString = $"Data Source={Constants.ReadFolder}MhbSqliteBigInt.db;Version=3;";
		string writeConnectionString = $"Data Source={Constants.WriteFolder}MhbSqlite.db;Version=3;";

		using (var readConnection = new SQLiteConnection(readConnectionString))
		using (var writeConnection = new SQLiteConnection(writeConnectionString))
		{
			await readConnection.OpenAsync();
			await writeConnection.OpenAsync();

			using (var transaction = writeConnection.BeginTransaction())
			{
				try
				{
					await writeConnection.ExecuteAsync($"ATTACH DATABASE '{Constants.ReadFolder}MhbSqliteBigInt.db' AS SourceDb");

					/*
					tableName = "Scripture";	
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					transaction.Commit();

					stats.TableName = tableName;	
					stats.RowsCopied = rowsCopied;


					tableName = "WordPart";
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					transaction.Commit();

					stats.TableName = tableName;
					stats.RowsCopied = rowsCopied;
					progress.Report(new ProgressInfo(.20));

					tableName = "WordPartKjv";
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					transaction.Commit();

					stats.TableName = tableName;
					stats.RowsCopied = rowsCopied;

					tableName = "AlephTavVerse";
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					stats.TableName = tableName;
					stats.RowsCopied = rowsCopied;
					progress.Report(new ProgressInfo(.10));

					tableName = "AlephTavVerseWordPart";
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					stats.TableName = tableName;
					stats.RowsCopied = rowsCopied;
					progress.Report(new ProgressInfo(.10));

					tableName = "Article";
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					stats.TableName = tableName;
					stats.RowsCopied = rowsCopied;
					progress.Report(new ProgressInfo(.10));

					tableName = "JotAndTittle";
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					stats.TableName = tableName;
					stats.RowsCopied = rowsCopied;
					progress.Report(new ProgressInfo(.10));

					tableName = "Mitzvot";
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					stats.TableName = tableName;
					stats.RowsCopied = rowsCopied;
					progress.Report(new ProgressInfo(.10));
					*/

					tableName = "Triennial";
					rowsCopied = await writeConnection.ExecuteAsync(@$"
                        INSERT INTO {tableName}
                        SELECT * FROM SourceDb.{tableName}
                    ");
					stats.TableName = tableName;
					stats.RowsCopied = rowsCopied;
					progress.Report(new ProgressInfo(.10));


					transaction.Commit();

				}
				catch (Exception ex)
				{
					//transaction.Rollback();
					AnsiConsole.WriteLine();
					AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
					AnsiConsole.WriteLine();
				}
				finally
				{
					await writeConnection.ExecuteAsync($"DETACH DATABASE SourceDb");
				}
				
			}
		}
	}



	/*

	*/
}