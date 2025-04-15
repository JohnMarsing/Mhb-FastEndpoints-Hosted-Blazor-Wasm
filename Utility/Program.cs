using Utility;
using Utility.Jobs;

internal class Program
{
	private static async Task Main(string[] args)
	{
		var arguments = Helpers.ParseArguments(args);

		/*
		if (arguments.Count == 0 || arguments.ContainsKey("--help"))
		{
			Helpers.PrintHelp();
			return; 
		}
		*/

		// Example: Check if a specific argument is defined
		if (arguments.ContainsKey("--verbose"))
		{
			Console.WriteLine("Verbose mode enabled.");
		}

		// Example: Retrieve the value of a named argument
		if (arguments.TryGetValue("--output", out string outputValue))
		{
			Console.WriteLine($"Output file: {outputValue}");
		}


		//await ShowAnimation.Run();
		//ExportTriennialCSV.Run();
		HaggadahVerseExtractor.Run();
	}
}




