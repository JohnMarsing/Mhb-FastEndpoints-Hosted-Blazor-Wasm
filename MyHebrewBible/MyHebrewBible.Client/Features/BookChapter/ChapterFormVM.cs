using System.ComponentModel.DataAnnotations;

namespace MyHebrewBible.Client.Features.BookChapter;

public class ChapterFormVM
{
	[Required]
	[Range(1, 150,
	ErrorMessage = "Between {1} and {2}.")] 
	public int Chapter { get; set; }
}
