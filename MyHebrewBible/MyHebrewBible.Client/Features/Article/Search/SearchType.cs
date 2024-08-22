using MyHebrewBible.Client.Features.Article.Search.Enums;

namespace MyHebrewBible.Client.Features.Article;

public record SearchType(StrongsType StrongsType, long ArticleId);