//using Microsoft.AspNetCore.Components;

namespace Utility;

public static class DateFormat
{
	public const string ddd_mm_dd = "ddd, MM/dd";  //ddd, MM/dd/yyyy
	public const string mm_dd = "MM/dd";
	public const string MMM_d = "MMM d";
	public const string MM_dd_HH_mm = "MM/dd HH:mm";
	public const string MM_dd_hh_mm = "MM/dd hh:mm";
	public const string dd = "dd";
	public const string dddd_dd_MMMM = "dddd, dd MMMM";
	public const string dddd_MMMM_dd = "dddd, MMMM dd ";
	public const string ddd_MMMM_dd_YYYY = "ddd, MMMM dd, yyyy";
	public const string ddd_MMM_dd_YYYY = "ddd, MMM dd, yyyy";
	public const string YYYY_MM_DD = "yyyy-MM-dd";
	public const string YYYY_MM_DD_Slash = "yyyy/MM/dd";
	public const string FeastDayPlanner = "ddd, MMM dd";
	public const string YYYY_MM_DD_hh_mm = "yyyy-MM-dd hh:mm";
}

public static class ParashaFacts
{
	//public abstract BibleBookPrevNext NavigationPrevious(int Chapter);
	//public abstract BibleBookPrevNext NavigationNext(int Chapter);

	public const int FirstParashaId = 1;
	public const int LastParashaId = 157;
}

public static class Constants
{

	public static string CurrentReadDateTextFormat(DateTime readDate)
	{
		DateTime compareDate = DateTime.Today;
		if (readDate >= compareDate & readDate <= compareDate.AddDays(6))
		{
			return "text-danger";
		}
		else
		{
			return "";
		}
	}

	public static DateTime TriennialSeedDate = DateTime.Parse("2021-10-02"); // 2021-09-25 Last date from previous triennial
	//public static DateTime TriennialSeedDate = DateTime.Parse("2024-10-26");

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

	/*
	public static MarkupString DaysFromOrToShabbat(DateTime dt)
	{
		TimeSpan timeSpan = dt - GetNextShabbatDate();
		int days = timeSpan.Days;
		if (days < 0)
		{
				return (MarkupString)$" <b>{Math.Abs(days)}</b> days <b class='text-danger'>before</b> next Shabbat";
		}
		else 
		{
			if (days > 0)
			{
				return (MarkupString)$" <b>{Math.Abs(days)}</b> days <b class='text-primary'>after</b> next Shabbat";
			}
			else 
			{
				return (MarkupString)$" today is Shabbat! <b class='text-success fs-5'>Shabbat Shalom!</b>";
			}
		}
	}
	*/

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