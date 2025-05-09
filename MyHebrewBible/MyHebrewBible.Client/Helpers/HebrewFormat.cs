﻿namespace MyHebrewBible.Client.Helpers;

// ToDo: Add similar logic for FinalEnum

public enum WordEnum
{
	SimpleSingle = 1,
	NrlPrefix = 2,
	NrlSuffix = 3,
	NrlPrefixAndSuffix = 4,
	Sat = 5,
	SatAndPaseq = 6
}

public class HebrewFormat
{
	// ToDo: Compare dupe code to Components\Report\Enums\Helper.cs
	public static string GetSpan(int wordEnumLong, string hebrew1, string hebrew2, string hebrew3)
	{
		WordEnum wordEnum = (WordEnum)wordEnumLong;

		return wordEnum switch
		{
			WordEnum.SimpleSingle => hebrew1,
			WordEnum.NrlPrefix => $"<span class='nrl'>{hebrew1}</span>{hebrew2}",
			WordEnum.NrlSuffix => $"{hebrew1}<span class='nrl'>{hebrew2}</span>",
			WordEnum.NrlPrefixAndSuffix => $"<span class='nrl'>{hebrew1}</span>{hebrew2}<span class='nrl'>{hebrew3}</span>",
			WordEnum.Sat => $"<span class='at-red'>{hebrew1}</span>",
			_ => $"<span class='at-red'>{hebrew1}</span> <span class='last-seg-type-paseq'>׀</span>"  // WordEnum.SatAndPaseq
		};
	}

	private const string Maqqef = "־";  // A Maqqef is a Hebrew hyphen

	// If the last part of the word is a Maqqef, don't add a space to the end of the word

	public static string CheckMaqqef(int wordEnumLong, string hebrew1, string hebrew2, string hebrew3)
	{
		WordEnum wordEnum = (WordEnum)wordEnumLong;

		return wordEnum switch
		{
			WordEnum.SimpleSingle => (hebrew1.EndsWith(Maqqef)) ? "" : " ",
			WordEnum.NrlPrefix => (hebrew2.EndsWith(Maqqef)) ? "" : " ",
			WordEnum.NrlSuffix => (hebrew2.EndsWith(Maqqef)) ? "" : " ",
			WordEnum.NrlPrefixAndSuffix => (hebrew3.EndsWith(Maqqef)) ? "" : " ",
			WordEnum.Sat => (hebrew1.EndsWith(Maqqef)) ? "" : " ",
			_ => (hebrew1.EndsWith(Maqqef)) ? "" : " "
		};
	}



}

// Ignore Spelling: Maqqef, Strongs