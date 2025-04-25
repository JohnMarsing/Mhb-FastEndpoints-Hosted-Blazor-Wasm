
using MyHebrewBible.Client.Helpers;
using System.Text;

namespace MyHebrewBible.Client.Enums;

public static class BibleBookHelper
{
	public static int GetScriptureId(BibleBook bibleBook, int chapter, int verse)
	{
		return Enums.BibleBook.List
			.Where(w => w.Value < bibleBook.Value)
			.Sum(b => b.LastVerses.Sum())                  // Sum verses from previous books
			+ bibleBook.LastVerses.Take(chapter - 1).Sum() // Sum verses from previous chapters in the current book
			+ verse;                                       // Add the current verse
	}

	public static string GetBCV(BibleBook bibleBook, int chapter, int verse, bool useTitle=true)
	{
		return $"{(useTitle ? bibleBook.Name : bibleBook.Abrv)} {chapter}:{verse}";
	}

	public static string GetUrl(BibleBook bibleBook, int chapter, int verse)
	{
		return $"/bookchapter/{bibleBook.Abrv}/{chapter}/{verse}/{GetScriptureId(bibleBook,chapter,verse)}";
	}

	public static string GetCodeGenInternalConst(BibleBook bibleBook, int chapter, int verse)
	{
		/* internal const int Genesis_01_01 = 1; */

		StringBuilder sb = new();
		sb.Append("internal const int ");
		sb.Append(GetBaseName(bibleBook, chapter, verse));
		sb.Append(" = ");
		sb.Append(GetScriptureId(bibleBook, chapter, verse));
		sb.Append(';');
		return sb.ToString() ;
	}
	
	public static string GetCodeGenPublicInstance(BibleBook bibleBook, int chapter, int verse)
	{
		/*	public static readonly Verse Genesis_01_01 = new Genesis_01_01SE();	 */

		StringBuilder sb = new();
		sb.Append("public static readonly Verse ");

		sb.Append(GetBaseName(bibleBook, chapter, verse));	

		sb.Append(" = new ");
		
		sb.Append("SE();");
		return sb.ToString();
	}

	private static string GetBaseName(BibleBook bibleBook, int chapter, int verse)
	{
		StringBuilder sb = new();
		sb.Append(bibleBook.Name);
		sb.Append('_');
		sb.AppendIfElse(bibleBook.Name == "Psalms", String.Format("{0:D3}", chapter), String.Format("{0:D2}", chapter));
		sb.Append('_');
		sb.AppendIfElse(bibleBook.Name == "Psalms", String.Format("{0:D3}", verse), String.Format("{0:D2}", verse));

		return sb.ToString();
	}

	/*
	#region Private Instantiation
	private sealed class Genesis_01_01SE : Verse
	{
		public Genesis_01_01SE() : base($"{nameof(Id.Genesis_01_01)}", Id.Genesis_01_01) { }
		public override VerseRecord VerseRecord => new(BibleBook.Genesis, 1, 1, 1);
	}
	 
	 */
	public static string GetCodeGenPrivateInstance(BibleBook bibleBook, int chapter, int verse)
	{
		StringBuilder sb = new();
		sb.Append("private sealed class ").Append(GetBaseName(bibleBook, chapter, verse)).Append("SE : Verse").Append(Environment.NewLine);
		sb.Append('{').Append(Environment.NewLine);

		sb.Append("  public ").Append(GetBaseName(bibleBook, chapter, verse)).Append("SE() : ")
		.Append("base($'{nameof(Id.").Append(GetBaseName(bibleBook, chapter, verse)).Append(", Id.").Append(GetBaseName(bibleBook, chapter, verse)).Append(") { }").Append(Environment.NewLine); 

		sb.Append("  public override VerseRecord VerseRecord => new(BibleBook.")
		.Append(bibleBook.Name).Append(", ").Append(chapter).Append(", ").Append(verse).Append(");").Append(Environment.NewLine);	

		sb.Append('}');
		return sb.ToString();
	}

}

