using System.ComponentModel.DataAnnotations;

namespace MyHebrewBible.Client.Features.Typeahead;

public class FormExample
{
	[Required]
	public Person SelectedPerson { get; set; }
}
