using MyHebrewBible.Client.Features.Parasha.Enums;

namespace MyHebrewBible.Client.Features.Parasha.TableOfContents;

public class TOC_VM()
{
	public List<TocRecord>? TableOfContentList { get; set; }

	public int GetTorahScriptureId()
	{
		return TableOfContentList!.Where(w => w.SectionId == ShowSection.Torah.Value).Select(s => s.ScriptureID_Beg).SingleOrDefault(1);
	}

	public int GetSectionCount(ShowSection showSection)
	{
		return TableOfContentList!.Where(w => w.SectionId == showSection.Value).Count();
	}

	public string? GetTorahVerseRange()
	{
		return TableOfContentList!.Where(w => w.SectionId == ShowSection.Torah.Value).Select(s => s.VerseRange).SingleOrDefault("Gen 1:1");
	}

}

// Ignore Spelling: TOC, VM