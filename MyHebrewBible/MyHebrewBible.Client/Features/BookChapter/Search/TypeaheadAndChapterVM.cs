using MyHebrewBible.Client.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyHebrewBible.Client.Features.BookChapter.Search;

public class TypeaheadAndChapterVM
{
	[Required]
	[Display(Name = "Book")]
	public BibleBook? SelectedBook { get; set; }

	[Required]
	[Range(1, 150, ErrorMessage = "Between {1} and {2}.")]
	public int Chapter { get; set; }
}
