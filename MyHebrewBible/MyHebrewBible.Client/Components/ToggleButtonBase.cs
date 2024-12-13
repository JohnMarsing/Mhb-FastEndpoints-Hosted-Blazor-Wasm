using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Components;

public class ToggleButtonBase : ComponentBase
{
	protected bool ShowDetails { get; set; } = false;

	[Parameter] public EventCallback<bool> OnShowDetails { get; set; }

	protected void Toggle()
	{
		ShowDetails = !ShowDetails;
		OnShowDetails.InvokeAsync(ShowDetails);
	}

	protected string GetButtonClass() => ShowDetails ? "btn btn-success" : "btn btn-outline-secondary";
	protected string GetIcon() => ShowDetails ? "fas fa-chevron-up" : "fas fa-chevron-down";

}
