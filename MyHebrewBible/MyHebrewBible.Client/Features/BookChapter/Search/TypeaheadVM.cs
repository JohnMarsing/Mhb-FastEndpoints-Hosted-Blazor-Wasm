using MyHebrewBible.Client.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyHebrewBible.Client.Features.BookChapter.Search;

public class TypeaheadVM
{
    [Required]
    [Display(Name = "Book")]
    public BibleBook? SelectedBook { get; set; }

    /*
		There is no event we expose to hook onto for clearing the typeahead. 
		One way you could achieve this is by using the setter of the property which is bound to the typeahead, 
		when you clear the Country typeahead we reset the bound value to its default, 
		when that happens you could then trigger a clear of the City typeahead. 
		Does that make sense?
		https://github.com/Blazored/Typeahead/issues/167
	*/

    //private BibleBook? _bibleBook;
    //public BibleBook SelectedBook
    //{
    //	get => _bibleBook!;
    //	set
    //	{
    //		_bibleBook = value;

    //		if (_bibleBook is null)
    //		{
    //			/*
    //			ToDo: what action goes here?
    //			I want to send back to BookChapter!Index.razor that the BlazoredTypeahead was deselected (cleared)
    //			Index.razor!ReturnedBookFilter will react by clearing the chapter buttons and Psalms Chapter InputNumber
    //			[Parameter] public EventCallback<BibleBook> OnBookFilterSelected { get; set; }
    //			*/
    //		}
    //	}
    //}
}
