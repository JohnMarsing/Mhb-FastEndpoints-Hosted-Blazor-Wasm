﻿namespace MyHebrewBible.Endpoints;

public class Article
{
	public long Id { get; set; }
	public string? FileNameNoExt { get; set; }
	public string? Title { get; set; }
	//public string? Uri { get; set; }
	public string? Details { get; set; }
	public string? DetailsMD { get; set; }
	public long PrimaryScriptureId { get; set; }
	public DateTime CreateDate { get; set; }
	public long? DocBlobID { get; set; }
	public long? PdfBlobID { get; set; }
	public bool IsPlaceHolder { get; set; }
	public bool IsFavorite { get; set; }
	public long ExtraVerses { get; set; }
	public bool IsWordStudy { get; set; }
	public bool IsParasha { get; set; }
	public string? BCV { get; set; }
	public long BookID { get; set; }
	public long Chapter { get; set; }
	public long Verse { get; set; }
	//public string? BookAbrv { get; set; }

	public string IsFavoriteHtml
	{
		get
		{
			return $"{(IsFavorite ? "<span class='text-danger'><span class='fas fa-star'></span></span>" : "")}";
		}
	}

	public string RelatedVersesHtml
	{
		get
		{
			if (PrimaryScriptureId != 31102 && !String.IsNullOrEmpty(BCV))
			{
				if (ExtraVerses != 0)
				{
					return $"{BCV}-{Verse+ExtraVerses}";
				}
				else
				{
					return $"{BCV}";
				}

			} 
			else 
			{
				return "";
			}
		}
	}

}
