using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Utility.Jobs;

public static class ExportTriennialCSV
{
	public static void Run()
	{
		var records = new List<Reading>();
		var config = new CsvConfiguration(CultureInfo.InvariantCulture)
		{
			HasHeaderRecord = true,
		};

		foreach (var item in Triennial.List.ToList().OrderBy(o => o.Value))
		{
			records.Add(new Reading(item.Value, item.Date.ToString(DateFormat.YYYY_MM_DD_Slash), item.TorahAbrv.Trim(), item.Haftorah, item.Brit));
		}

		string folder = "C:\\Source\\repos\\FastEndpoints\\Mhb-FastEndpoints-Hosted-Blazor-Wasm-Backup\\033-new-Utility-console\\";
		using (var writer = new StreamWriter(folder + "TriennialSmartEnum.csv"))
		using (var csv = new CsvWriter(writer, config)) // , CultureInfo.InvariantCulture
		{
			csv.WriteRecords(records);  //Triennial.List.ToList().OrderBy(o => o.Date)
		}

	}
	/*
	*/
}
