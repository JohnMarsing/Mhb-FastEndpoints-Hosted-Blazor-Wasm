using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Enums;

public class BibleAnchors
{
	public static MarkupString StrongsH_td(long strongs)
	{
		return (MarkupString)(LexiconAnchor("H", LongToInt(strongs), "", false));
	}

	// ToDo: duplicate code
	private static int LongToInt(long l)
	{
		return (l <= int.MaxValue && l >= int.MinValue) ? (int)l : 1;
	}

	public static MarkupString StrongsH(int strongs, string transliteration, bool superscript = true)
	{
		//return (MarkupString)"<a href='https://www.blueletterbible.org> <i class='fas fa-external-link-alt'></i></a>";
		return (MarkupString)(LexiconAnchor("H", strongs, transliteration, superscript));
	}

	public static MarkupString StrongsG(int strongs, string transliteration, bool superscript = true)
	{
		return (MarkupString)(LexiconAnchor("G", strongs, transliteration, superscript));
	}

	private static string LexiconAnchor(string HorG, int strongs, string translit, bool superscript)
	{
		const string a1 = "<a href='https://www.blueletterbible.org/lexicon/";
		string result;
		result = $"{a1}{HorG}{strongs}/kjv/{(HorG == "H" ? "wlc/" : "tr/")}0-1/' target='_blank'>{HorG}{strongs}</a> <i class='fas fa-external-link-alt'></i>";

		if (!String.IsNullOrEmpty(translit))
		{
			result = $"<i>{translit}</i> " + result;
		}

		if (superscript)
		{
			result = "<sup>" + result + "</sup>";
		}

		return result;
	}

}

// Ignore Spelling: Strongs