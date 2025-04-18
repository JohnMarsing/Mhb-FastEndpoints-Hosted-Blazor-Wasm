using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.Haggadah;

public static class Helper
{
	public const string pClass = "fs-5";
	public const string p4CenterBoldClass = "fs-4 text-center fw-bold";

	private const string green = "text-success";
	private const string red = "text-danger";
	private const string bold = "fw-bold";
	private const string size5 = "fs-5";
	private const string size4 = "fs-4";
	private const string size3 = "fs-3";
	private const string center = "text-center";
	private const string iconLevelDown = "<i class='fas fa-level-down-alt'></i>";
	private const string iconArrowDown = "<i class='fas fa-long-arrow-alt-down'></i>";

	public const string VerseClass = "bg-primary-subtle fs-5 p-2 ms-3";
	public const string VerseIcon = "<i class='fas fa-quote-left'></i>";
	public const string VerseSupClass = "text-primary fw-bold";
	public const string VerseSupClassHebrew = "text-black-50";

	public static MarkupString Leader(string role)  // Leader or Líder
	{
		const string s1 = "<span class='text-success fw-bold'>";
		const string s2 = "</span>";
		return new MarkupString($"{s1}{role}:{s2}");
	}

	public static MarkupString ParagraphAllRead(string role = "All Read")
	{
		const string s1 = "<span class='fs-5 text-danger fw-bold'>";
		const string s2 = "</span>";
		return new MarkupString($"{s1}{role}:{s2}");
	}

	public static MarkupString ParagraphSetFree(string role) // All Shout or Todos Gritan	
	{
		return new MarkupString(@$"
		<p class='{size3} {center}'>
		<sub>{iconArrowDown}</sub> <span class='{red} {bold}'>{role}</span> <sub>{iconArrowDown}</sub>
		</p>
		");
	}

	public static MarkupString ParagraphLeader(string role) 
	{
		const string ps = "<p class='fs-5 mb-1'>";
		const string pe = "</p>";
		return new MarkupString(@$"
		{ps}
		<span class='{green} {bold}'>{role}</span>
		{pe}
		");
	}

	public static MarkupString ParagraphReader(string role, int readerNumber)
	{
		return new MarkupString(@$"
		<p class='{size5} mb-1'>
		<span class='{red} {bold}'>{role} {readerNumber}</span>
		</p>
		");
	}
	/*
	 ⬇️
	 ⤵️
	 <i class='{iconLevelDown}'></i> 
	*/

	public static MarkupString Reader(string role, int readerNumber) // Reader or Lector	
	{
		const string s1 = "<span class='text-danger fw-bold'>";
		const string s2 = "</span>";
		return new MarkupString($"{s1}{role} {readerNumber}:{s2}");
	}

	public static MarkupString Toast(string instruction = "All Shout") // "Todos Gritan"
	{
		const string ps = "<p class='fs-3 text-center'>";
		const string ss = "<span class='badge bg-danger text-white'>"; // instruction
		const string toast = "L'Chaim";
		const string se = "<i class='fas fa-exclamation'></i></span> ";
		const string pe = "</p>";
		const string icon = "<i class='text-danger fas fa-wine-glass-alt'></i>";
		return new MarkupString(@$"
			{ps}
			<span class='text-danger fw-bold'>{instruction}</span>
			{ss}{toast}{se}{icon}
			{pe}");
	}

}

// Ignore spelling: Lector, Líder, ps, pe, ss, se