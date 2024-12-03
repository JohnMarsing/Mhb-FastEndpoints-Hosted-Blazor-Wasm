using Microsoft.AspNetCore.Components;
using MyHebrewBible.Client.State;

namespace MyHebrewBible.Client;

public partial class CascadingAppState
{
	[Inject] public AppState? AppState { get; set; }

	[Parameter] public RenderFragment? ChildContent { get; set; }

	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		if (firstRender)
		{
			await AppState!.Initialize();
		}
	}

}

// Ignore Spelling: App