using System.ComponentModel.DataAnnotations;

namespace MyHebrewBible.Client.Features.Articles.Search;

public class ArticleIdFormVM
{
    [Range(1, 9999, ErrorMessage = "Article Id must be between 1 and 9999.")]
    public long Id { get; set; }
}
