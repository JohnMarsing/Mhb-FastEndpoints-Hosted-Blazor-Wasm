using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using MyHebrewBible.Client.Components;

namespace MyHebrewBible.Client.Features.Articles;

public partial class Details
{
	[Inject] public ILogger<Details>? Logger { get; set; }
	[Inject] public ApiClient? Api { get; set; }
	[Inject] public IToastService? Toast { get; set; }

	[Parameter, EditorRequired] public long ArticleId { get; set; }

	protected Article? article;
	private VerseRangeDTO? VerseRangeDTO; 

	protected bool TurnSpinnerOff = false;

	protected override async Task OnParametersSetAsync()
	{
		Logger!.LogInformation("{Class}!{Method}; ArticleId: {ArticleId}", nameof(Details), nameof(OnParametersSetAsync), ArticleId);
		try
		{
			article = await Api!.GetArticleAsync(ArticleId);
		}
		catch (Exception)
		{
			// ToDo: figure out how to do Fast-Endpoints Union Types / TypedResults-thinga-muh-jigger
		}

		if (article is null)
		{
			Toast!.ShowWarning($"Article Id {ArticleId} not found");
		}
		else
		{
			if (!String.IsNullOrEmpty(article.RelatedVersesHtml))
			{
				VerseRangeDTO = new VerseRangeDTO(article.PrimaryScriptureId, article.PrimaryScriptureId + article.ExtraVerses, article.RelatedVersesHtml);
			}

			//Toast!.ShowInfo($"Article Id {ArticleId} FileNameNoExt: {article.FileNameNoExt}");
			//Logger!.LogInformation("{FileNameNoExt} | {PrimaryScriptureId}; BlobIDs {DocBlobID}!{PdfBlobID}",
			//	article.FileNameNoExt, article.PrimaryScriptureId, article.DocBlobID, article.PdfBlobID);
		}

		TurnSpinnerOff = true;
	}

}