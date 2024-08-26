namespace MyHebrewBible.Endpoints;

public class ArticleList
{
	public long Id { get; set; }
	public string? Title { get; set; }
	public bool IsPlaceHolder { get; set; }
	public bool IsFavorite { get; set; }
	public bool IsWordStudy { get; set; }
	public bool IsParasha { get; set; }

	/*
	Fiter ver. 2.0	
	public long BookID { get; set; }
	public long Chapter { get; set; }
	public long Verse { get; set; }
	public string? BCV { get; set; }

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
	 
	*/

	/*
	Do I need this?
	public string IsFavoriteHtml
	{
		get
		{
			return $"{(IsFavorite ? "<span class='text-danger'><span class='fas fa-star'></span></span>" : "")}";
		}
	}
	*/
}
