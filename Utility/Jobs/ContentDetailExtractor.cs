using System.Text.RegularExpressions;

namespace Utility.Jobs;

public static class HaggadahVerseExtractor
{
	public static void Run()
	{
		string readFilePath = "C:\\Source\\repos\\FastEndpoints\\Mhb-FastEndpoints-Hosted-Blazor-Wasm-Backup\\071-Haggadah\\ExtractVerses\\ContentDetail.cs";
		string writeFilePath = "C:\\Source\\repos\\FastEndpoints\\Mhb-FastEndpoints-Hosted-Blazor-Wasm-Backup\\071-Haggadah\\ExtractVerses\\Verses.txt";

		// Regex to match <p> elements with the specific class
		string pattern = @"<p class='bg-primary-subtle fs-5 p-2 ms-3'>(.*?)</p>";

		string fileContent;
		using (var reader = new StreamReader(readFilePath))
		{
			fileContent = reader.ReadToEnd();
		}

		// Find matches using the regex
		var matches = Regex.Matches(fileContent, pattern, RegexOptions.Singleline);
		Console.WriteLine($"Matched: {matches.Count}");

		// Write matches to the output file
		using (StreamWriter writer = new StreamWriter(writeFilePath))
		{
			foreach (Match match in matches)
			{
				writer.WriteLine(match.Groups[1].Value.Trim());
				writer.WriteLine(); // Add a blank line between entries
			}
		}
	}

	// Simulated source of the ContentDetail class as a string
		/*
		 Replace ContentDetailSource with this file "C:\Source\repos\FastEndpoints\Mhb-FastEndpoints-Hosted-Blazor-Wasm-Backup\071-Haggadah\ExtractVerses\ContentDetail.cs"
		 */
		//private static string ContentDetailSource = 
		//@"
		//   // Paste the full ContentDetail.cs file content here as a string
		// ";
}