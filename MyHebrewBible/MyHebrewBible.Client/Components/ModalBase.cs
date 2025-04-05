using Microsoft.AspNetCore.Components;

public class ModalBase : ComponentBase
{
	protected bool modalOpen = false;
	protected string modalClass = "modal";
	protected bool ModalIsNotShownToggle = true;

	protected void ShowModal()
	{
		modalOpen = true;
		ModalIsNotShownToggle = false;
		modalClass += " show";
		StateHasChanged();
	}

	protected void CloseModal()
	{
		modalOpen = false;
		ModalIsNotShownToggle = true;
		modalClass = "modal";
		StateHasChanged();
	}


}

public static class ModalConstant
{
	public const string HeaderColor = "bg-warning";
	public const string ContentColor = " border-danger";
	public const string BodyColor = "";  // bg-warning-subtle
	public const string FooterColor = "bg-dark-subtle text-black-50";  //  bg-light
	public const string Size = "modal-sm"; // MediaQuery == MediaQuery.Xs ? "modal-sm" : "modal-md";
}	
