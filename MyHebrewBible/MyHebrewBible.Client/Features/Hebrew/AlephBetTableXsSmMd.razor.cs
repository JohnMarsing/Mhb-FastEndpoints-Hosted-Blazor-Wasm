using MyHebrewBible.Client.Features.Hebrew.Enums;

namespace MyHebrewBible.Client.Features.Hebrew;

public partial class AlephBetTableXsSmMd
{
	ModalDetails? Details = new ModalDetails();
	bool modalOpen = false;
	string modalClass = "modal";

	void ShowModal(HebrewChart hebrewChart)
	{
		Details!.Title = hebrewChart.Name + " " + hebrewChart.Hebrew;
		Details!.LiteralMeaning = hebrewChart.LiteralMeaning;
		Details!.SymbolicMeaning = hebrewChart.SymbolicMeaning;
		modalOpen = true;
		modalClass += " show";
		StateHasChanged();
	}

	void CloseModal()
	{
		modalOpen = false;
		modalClass = "modal";
		//Details = null;
	}
}

public class ModalDetails
{
	public string? Title { get; set; }
	public string? LiteralMeaning { get; set; }
	public string? SymbolicMeaning { get; set; }
}

