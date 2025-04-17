using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.Haggadah;

public static class Helper
{
	public const string pClass = "fs-5";
	public const string p4CenterBoldClass = "fs-4 text-center fw-bold";

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

	public static string ParagraphIndent(string body)
	{
		const string ps = "<p class='fs-5 mt-1 ms-3'>";
		const string pe = "</p>";
		return ($"{ps}{body}{pe}");
	}

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

	//, int begId, int endId, bool isEnglish = true
	//public static string VerseParagraph(string title, string body)
	//{
	//	const string ps = "<p class='bg-primary-subtle fs-5 p-2 ms-3'>";
	//	const string pe = "</p>";
	//	const string ts = "<b>";
	//	const string te = "</b><br />";
	//	const string q = "<i class='fas fa-quote-left'></i>";
	//	//const string sups = "<sup class='text-primary fw-bold'>";
	//	//const string supe = "</sup>";

	//	return (@$"
	//		{ps}
	//		  {ts}{title}{te}{q}
	//			{body}
	//		{pe}");
	//}


	//public static string Paragraph(string body) 
	//{
	//	const string ps = "<p class='fs-5'>";
	//	const string pe = "</p>";
	//	return ($"{ps}{body}{pe}");
	//}

	//public static string Title(string body)
	//{
	//	const string ps = "<p class='fs-5'>";
	//	const string pe = "</p>";
	//	return ($"{ps}{body}{pe}");
	//}
}

// Ignore spelling: Lector, Líder, ps, pe, ss, se