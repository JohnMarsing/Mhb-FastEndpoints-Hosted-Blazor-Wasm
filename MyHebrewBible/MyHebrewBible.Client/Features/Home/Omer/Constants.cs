namespace MyHebrewBible.Client.Features.Home.Omer;

public static class Constants
{
	// Days added to Dates._12_Passover
	public const int DaysAdded = 2; // If Sadducee interpretation, it's always 2

	public static DateTime Date { get; set; } =
		DateTime.Parse(Dates._12_Passover).AddDays(DaysAdded);

	public static string FirstDayAfterTheSabbath = Date.ToString("d");

	public static int CountInDays()
	{
		DateTime start = Date;
		start = start.AddDays(-1);
		DateTime cur = DateTime.Now;

		TimeSpan difference = cur - start;
		int days = (int)difference.TotalDays;
		return days;
	}

	public static class Dates
	{
		public const string _12_Passover = "4/12/2025";
	}

}

// Ignore Spelling: Pdfs