using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.Features.Parasha.Enums;

public static class Constants
{
	//1.1, Gen 1:1-19, Sep 29 2018
	public static DateTime TriennialSeedDate = DateTime.Parse("2021-10-02"); // 2021-09-25 Last date from previous triennial
	//public static DateTime TriennialSeedDate = DateTime.Parse("2024-09-28");

	public static DateTime GetUsersUTC()
	{
		DateTime utcNow = DateTime.UtcNow;
		return utcNow; //Console.WriteLine($"The current UTC time is: {utcNow}");
	}
	public static TimeSpan GetUsersUTCOffset() 
	{ 
		TimeZoneInfo localZone = TimeZoneInfo.Local;
		DateTimeOffset localTime = DateTimeOffset.Now;
		TimeSpan utcOffset = localZone.GetUtcOffset(localTime);
		return utcOffset;
	}

	public static DateTime GetNextShabbatDate()
	{
		DateTime yesterday = DateTime.UtcNow.AddHours(-24);  // For the server, it's like this... (31=24+ArizonaUtcMinus7)*-1
		int dayOfWeek = (7 + 5) % 7;
		int daysDifference = (int)(yesterday - new DateTime(1900, 1, 1)).TotalDays;
		int weeksDifference = daysDifference / 7;
		int daysToAdd = (weeksDifference * 7) + 7;
		DateTime result = new DateTime(1900, 1, 1).AddDays(daysToAdd + dayOfWeek);
		return result;
	}

	public static BibleBook GetBibleBookForNextShabbatDate()
	{
		return BibleBook.Deuteronomy;
	}

}