using MyHebrewBible.Client.Components;

namespace MyHebrewBible.Client.Enums;

public static class BibleBookFormat
{
	public static string BC(BookAndChapter? bc, bool useAbrv = true)  // Genesis 1 or Gen 1
	{
		if (bc is null) return string.Empty;
		return $"{(useAbrv ? bc!.BibleBook!.Abrv : bc!.BibleBook!.Title)} {bc!.Chapter}";
	}


	public static string BCV(BookAndChapter? bc, int verse, bool useAbrv = true)
	{
		if (bc is null) return string.Empty;
		return $"{(useAbrv ? bc!.BibleBook!.Abrv : bc!.BibleBook!.Title)} {bc!.Chapter}:{verse}"; // Genesis 1:2
	}

	public static string BCV(MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad.BookChapterVerse? bcv, bool useAbrv = true)  // Genesis 1 or Gen 1
	{
		if (bcv is null) return string.Empty;
		return $"{(useAbrv ? bcv!.BibleBook!.Abrv : bcv!.BibleBook!.Title)} {bcv!.Chapter}";
	}

	public static string BCV(BookChapterVerse? bcv, bool useAbrv = true)
	{
		if (bcv is null) return string.Empty;
		return $"{(useAbrv ? bcv!.BookAndChapter.BibleBook!.Abrv : bcv!.BookAndChapter.BibleBook!.Title)} {bcv!.BookAndChapter.Chapter}:{bcv!.Verse}";
	}

	public static string BLB_HrefSuffix(BookAndChapter? bc, int verse)
	{
		if (bc is null) return string.Empty;
		return $"{bc!.BibleBook!.Abrv}/{bc!.Chapter}/{verse}/";
	}

	public static string BLB_HrefSuffix(BookChapterVerse? bcv)
	{
		if (bcv is null) return string.Empty;
		return $"{bcv!.BookAndChapter.BibleBook!.Abrv}/{bcv!.BookAndChapter.Chapter}/{bcv!.Verse}/";
	}

	/*
	ToDo: will I ever need this version?
	public static string BCV(BibleBook? bb, int chapter, int verse, bool useAbrv = true)
	{
		if (bb is null) return string.Empty;
		return $"{(useAbrv ? bb!.Abrv : bb!.Title)} {chapter}:{verse}";
	}
	*/
}

// Ignore Spelling: BCV Abrv BLB