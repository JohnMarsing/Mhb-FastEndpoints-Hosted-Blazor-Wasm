namespace MyHebrewBible.Client.Features.Parasha.Enums;

public static class Constants
{
	public static DateTime TriennialSeedDate = DateTime.Parse("2021-10-02"); // 2021-09-25 Last date from previous triennial

	// Not used
	public static DateTime GetUsersUTC()
	{
		DateTime utcNow = DateTime.UtcNow;
		return utcNow; //Console.WriteLine($"The current UTC time is: {utcNow}");
	}

	// Not used
	public static TimeSpan GetUsersUTCOffset()
	{
		TimeZoneInfo localZone = TimeZoneInfo.Local;
		DateTimeOffset localTime = DateTimeOffset.Now;
		TimeSpan utcOffset = localZone.GetUtcOffset(localTime);
		return utcOffset;
	}

	// ToDo: probable need to remove `bool OverRideWithSaturday6PM` and `GetNextArizonaSaturday6PM` and write some unit tests
	public static DateTime GetNextShabbatDate(bool OverRideWithSaturday6PM = false)
	{
		TimeZoneInfo arizonaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Phoenix");
		DateTime utcNow;

		if (OverRideWithSaturday6PM)
		{
			utcNow = GetNextArizonaSaturday6PM();
		}
		else
		{
			utcNow = DateTime.UtcNow;
		}

		DateTime arizonaNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, arizonaTimeZone);

		int daysUntilSaturday = ((int)DayOfWeek.Saturday - (int)arizonaNow.DayOfWeek + 7) % 7;
		DateTime nextSaturday = arizonaNow.AddDays(daysUntilSaturday).Date;

		return nextSaturday;
	}

	// See comment above
	public static DateTime GetNextArizonaSaturday6PM()
	{
		DateTime utcNow = DateTime.UtcNow;

		TimeZoneInfo arizonaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Phoenix");
		DateTime arizonaNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, arizonaTimeZone);

		int daysUntilSaturday = ((int)DayOfWeek.Saturday - (int)arizonaNow.DayOfWeek + 7) % 7;
		DateTime nextSaturday = arizonaNow.AddDays(daysUntilSaturday).Date;

		DateTime nextSaturdayAt6PM = nextSaturday.AddHours(18);
		return nextSaturdayAt6PM;
	}

	public static string HoursAndDaysUntilNextShabbat()
	{
		DateTime startDate0 = DateTime.UtcNow;
		TimeZoneInfo arizonaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Phoenix");
		DateTime startDate1 = TimeZoneInfo.ConvertTimeFromUtc(startDate0, arizonaTimeZone);

		TimeSpan difference = GetNextShabbatDate() - startDate1;
		return string.Format("{0:%d} days and {0:%h} hours", difference);
	}

	public static DateTime GetNextArizonaSunday1AM()
	{
		DateTime utcNow = DateTime.UtcNow;

		TimeZoneInfo arizonaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Phoenix");
		DateTime arizonaNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, arizonaTimeZone);

		int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)arizonaNow.DayOfWeek + 7) % 7;
		DateTime nextSunday = arizonaNow.AddDays(daysUntilSunday).Date;

		DateTime nextSundayAt1AM = nextSunday.AddHours(1);
		return nextSundayAt1AM;
	}
	
}