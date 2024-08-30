
### From `LivingMessiah.Web`
- C:\Users\JohnM\source\repos\LivingMessiahBlazor\LivingMessiah.Web\Data\Helper.cs

Used by...
- `public async Task<PsalmAndProverbCurrentQuery> GetPsalmAndProverbCurrentQuery()`
- `public async Task<PsalmAndProverbCurrentVM> GetCurrentPsalmAndProverb()`
- `public async Task<List<vwPsalmsAndProverbs>> GetPsalmsAndProverbsList()`

```csharp
using System;

namespace LivingMessiah.Web.Data;

public static class Helper
{
	public static (string CompareDate, bool IsDayOfWeekSaturday) CurrentShabbatDate()
	{
		DateTime CompareDate = DateTime.Today;
		string sCompareDate = DateTime.Today.ToString("yyyy-MM-dd") + " 12:00:00 AM";
		bool isDayOfWeekSaturday = CompareDate.DayOfWeek == DayOfWeek.Saturday ? true : false;
		return (sCompareDate, isDayOfWeekSaturday);
	}

	public static string? Scrub(string? notes)
	{
		if (!string.IsNullOrEmpty(notes))
		{
			return notes.Replace("\"", string.Empty).Replace("'", string.Empty);
		}
		else
		{
			return string.Empty;
		}
	}
}
```

See also `DateUtil.cs`
- C:\Users\JohnM\source\repos\LivingMessiahBlazor\LivingMessiah.Web\Infrastructure\DateUtil.cs