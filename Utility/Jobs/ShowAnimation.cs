namespace Utility.Jobs;

public class ShowAnimation
{
	public static async Task Run() // ShowConsoleAnimation
	{
		string[] animations = ["| -", "/ \\", "- |", "\\ /"];
		for (int i = 0; i < 20; i++)
		{
			foreach (string s in animations)
			{
				Console.Write(s);
				await Task.Delay(50);
				Console.Write("\b\b\b");
			}
		}
		Console.WriteLine();

		var index = new Random().Next(Data.GetData().Length - 1);
		Console.WriteLine(Data.GetData()[index]);

	}

}
