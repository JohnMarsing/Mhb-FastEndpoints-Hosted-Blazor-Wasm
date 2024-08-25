using System.ComponentModel.DataAnnotations;

namespace MyHebrewBible.Client.Features.Articles.Search;

  public class HebrewStrongsFormVM
  {
	[Range(1, 8674, ErrorMessage = "Hebrew Strong's must be between 1 and 8674.")]
	public long Number { get; set; } // = 1;
}
