using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.Haggadah;

public static class Helper
{
	//, int begId, int endId, bool isEnglish = true
	public static string VerseParagraph(string title, string body)
	{
		const string ps = "<p class='bg-primary-subtle fs-5 p-2 ms-3'>";
		const string pe = "</p>";
		const string ts = "<b>";
		const string te = "</b><br />";
		const string q = "<i class='fas fa-quote-left'></i>";
		//const string sups = "<sup class='text-primary fw-bold'>";
		//const string supe = "</sup>";

		return (@$"
			{ps}
			  {ts}{title}{te}{q}
				{body}
			{pe}");
	}

	//public static string Title(string body)
	//{
	//	const string ps = "<p class='fs-5'>";
	//	const string pe = "</p>";
	//	return ($"{ps}{body}{pe}");
	//}



	public static string Leader(string role)  // Leader or Líder
	{
		const string s1 = "<span class='text-success fw-bold'>";
		const string s2 = "</span>";
		return ($"{s1}{role}:{s2}");
	}

	/*
	 			<p class='fs-5 text-danger fw-bold'>
				ALL READ:
				....
				</p>


	 */

	public static string ParagraphAllRead(string role = "All Read") // Todo Leer, Todos Gritan
	{
		const string ps = "<p class='fs-5 text-danger fw-bold>";
		const string pe = "</p>";
		return ($"{ps}{role}:{pe}");
	}

	public static string ParagraphIndent(string body)
	{
		const string ps = "<p class='fs-5 mt-1 ms-3'>";
		const string pe = "</p>";
		return ($"{ps}{body}{pe}");
	}

	public static string Reader(string role, int readerNumber) // Reader or Lector	
	{
		const string s1 = "<span class='text-danger fw-bold'>";
		const string s2 = "</span>";
		return ($"{s1}{role} {readerNumber}:{s2}");
	}

	public static string Paragraph(string body) 
	{
		const string ps = "<p class='fs-5'>";
		const string pe = "</p>";
		return ($"{ps}{body}{pe}");
	}

	public static string Toast(string instruction = "All Shout") // "Todos Gritan"
	{
		const string ps = "<p class='fs-5' text-center>";
		const string ss = "<span class='badge bg-danger text-white'>"; // instruction
		const string toast = "L'Chaim";
		const string se = "<i class='fas fa-exclamation'></i></span> ";
		const string pe = "</p>";
		const string icon = "<i class='text-danger fas fa-wine-glass-alt'></i>";
		return (@$"
			{ps}
			{instruction}
			{ss}{toast}{se}{icon}
			{pe}");
	}


}
// Ignore spelling: Lector, Líder, ps, pe, ss, se