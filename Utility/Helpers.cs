namespace Utility;

public static class Helpers
{

	/*
	[C#: Console App that Accepts Command-Line Arguments](https://www.pietschsoft.com/post/2024/04/23/csharp-console-accept-commandline-arguments)
	*/
	public static Dictionary<string, string> ParseArguments(string[] args)
	{
		var arguments = new Dictionary<string, string>();

		foreach (var arg in args)
		{
			// Split the argument by '=' to handle key/value pairs
			string[] parts = arg.Split('=');

			// Check if the argument is in the format "key=value"
			if (parts.Length == 2)
			{
				arguments[parts[0]] = parts[1];
			}
			// If not, assume it's just a named argument without a value
			else
			{
				arguments[arg] = null;
			}
		}

		return arguments;
	}

	public static void PrintHelp()
	{
		Console.WriteLine("Help:");
		Console.WriteLine("------");
		Console.WriteLine("Usage: CommandLineApp [options]");
		Console.WriteLine();
		Console.WriteLine("Options:");
		Console.WriteLine("  --help             Display this help message");
		Console.WriteLine("  --verbose          Enable verbose mode");
		Console.WriteLine("  --output=<file>    Specify output file");
	}


}
