using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyHebrewBible.Client.Features.BookChapter.Enums;
using ButtonEnums = MyHebrewBible.Client.Features.BookChapter.Enums.ButtonsBCV;
using ButtonHelper = MyHebrewBible.Client.Features.BookChapter.Enums.Helper;
using GlobalEnums = MyHebrewBible.Client.Enums;
using LastVerseHelper = MyHebrewBible.Client.Enums.LastVerseHelper;
using System.Text;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public partial class Buttons3by4
{
	[Inject] public ILogger<Buttons3by4>? Logger { get; set; }
	[Inject] public required IJSRuntime JSRuntime { get; set; }

	[Parameter, EditorRequired] public GlobalEnums.BibleBook? BibleBook { get; set; }
	[Parameter, EditorRequired] public EventCallback<BookChapterVerse> OnBCVSelected { get; set; }

	protected StepState? StepState { get; set; }

	int LastVerse;
	PlaceValue? placeValue = new(); // ToDo: do I need one for SetupChapter and one for SetupVerse?
	protected Place? Place;



	protected override void OnParametersSet()
	{
		StepState = new StepState(BibleBook);

		ReturnedBCV = new BookChapterVerse(BibleBook, 1, 1); // default 
		LastVerse = LastVerseHelper.GetLastVerse(BibleBook, ReturnedBCV.Chapter);

		if (ReturnedBCV.BibleBook!.ChapterTens > 0)
		{
			Place = Place.Hundreds;
		}
		else
		{
			if (ReturnedBCV.BibleBook!.ChapterOnes > 9)
			{
				Place = Place.Hundreds;
			}
		}

		placeValue!.ResetAll();

		ActiveHundreds = -1; // ResetActive(Place.Hundreds);
		ActiveTens = -1;     // ResetActive(Place.Tens);
		ActiveOnes = -1;     // ResetActive(Place.Ones);
	}

	#region State
	/*
	ToDo: Create a state machine for this component 
	The purpose is for when the PlaceValue is set, to determine if we are focused on the Hundreds, Tens or Ones.
	*/
	protected bool SetupChapter;

	private void SetState(bool isChapterMode, bool makeDisabled)
	{
		if (isChapterMode)
		{
			SetupChapter = true;
		}
		else
		{
			SetupChapter = false;
		}
	}

	private void ReturnedPlace(Place place)
	{
		//Logger!.LogInformation("{Method}, number: {number}", nameof(ClickReset), number);
		placeValue!.ResetAll();
		//Set(Place.Tens, number);
	}

	#endregion

	BookChapterVerse? ReturnedBCV;

	private async Task ReturnedButtonSelected(NumberButtonVM vm)
	{
		if (SetupChapter)
		{
			if (vm.PlaceEnum == Place.Hundreds)
			{
				placeValue!.Hundreds = vm.Number; // placeValue!.Set(Place.Hundreds, vm.Number);
				ActiveHundreds = vm.Number;
			}
			else
			{
				if (vm.PlaceEnum == Place.Tens)
				{
					placeValue!.Tens = PlaceHelper.NotSetValue;  //placeValue!.Reset(Place.Ones);
					placeValue!.Tens = vm.Number;                // placeValue!.Set(Place.Tens, vm.Number);
					await Task.Delay(500);
					await JSRuntime.InvokeVoidAsync(JS.SetFocusToElement, Constants.SetFocusOnNumberButtonTens);
				}
				else
				{
					placeValue!.Ones = vm.Number;  //placeValue!.Set(Place.Ones, vm.Number);

					ReturnedBCV = ReturnedBCV! with { Chapter = placeValue!.Combine() };
					placeValue!.ResetAll();
					LastVerse = LastVerseHelper.GetLastVerse(ReturnedBCV!.BibleBook, ReturnedBCV.Chapter);
				}
			}
		}
		else
		{
			if (vm.PlaceEnum == Place.Hundreds)
			{
				placeValue!.Hundreds = vm.Number; // placeValue!.Set(Place.Hundreds, vm.Number);
				ActiveHundreds = vm.Number;
			}
			else
			{
				if (vm.PlaceEnum == Place.Tens)
				{
					placeValue!.Ones = PlaceHelper.NotSetValue; //placeValue!.Reset(Place.Ones);
					placeValue!.Ones = vm.Number;               //placeValue!.Set(Place.Tens, vm.Number);
					await JSRuntime.InvokeVoidAsync(JS.SetFocusToElement, Constants.SetFocusOnNumberButtonOnes);
				}
				else
				{
					placeValue!.Ones = vm.Number; // placeValue!.Set(Place.Ones, vm.Number);

					ReturnedBCV = ReturnedBCV! with { Verse = placeValue!.Combine() };

					await Task.Delay(1500);
					await OnBCVSelected.InvokeAsync(ReturnedBCV);
				}
			}
		}

		//Logger!.LogInformation("{Method}, returnedBCV: {returnedBCV}; SetupChapter: {SetupChapter}; vm: {vm}"
		//	, nameof(ReturnedButtonSelected), ReturnedBCV, SetupChapter, vm);

	}

	//protected NumberButtonVM? CurrentNumberButtonVM; // ToDo: why do I need this?
	//CurrentNumberButtonVM = vm; ToDo: why do I need this?


	protected string GetButtonClass(Place place, int btnNumber)
	{
		return $"btn {GetColor(place, btnNumber)}" +
		$" {GetDisabled(place, btnNumber)}" +
		$" {GetActive(place, btnNumber)}" +
		$" {ButtonHelper.GetDefaultButtonClass()}";
	}

	/*
	protected string GetButtonClassZero(Place place)
	{
		if (place == Place.Tens && SetupChapter && ReturnedBCV!.BibleBook!.ChapterTens == 0)
		{
			return $"btn {ButtonHelper.GetDisabledColor()} disabled {ButtonHelper.GetDefaultButtonClass()}";
		}
		else
		{
			return $"btn {GetColor(place, 0)} {GetDisabled(place, 0)} {GetActive(place, 0)} {ButtonHelper.GetDefaultButtonClass()}";
		}
	}
	*/

	protected string GetColor(Place place, int number)
	{
		if (place == Place.Hundreds)
		{
			return number == ReturnedBCV!.BibleBook!.ChapterHundreds ? ButtonEnums.Hundreds.ButtonColor : ButtonHelper.GetDisabledColor();
		}
		else
		{
			if (place == Place.Tens)
			{
				//return number == ReturnedBCV!.BibleBook!.ChapterHundreds ? ButtonEnums.Hundreds.ButtonColor : ButtonHelper.GetDisabledColor();
				return number <= ReturnedBCV!.BibleBook!.ChapterTens ? ButtonEnums.Tens.ButtonColor : ButtonHelper.GetDisabledColor();
			}
			else
			{
				if (placeValue!.Tens == -1)  // if higher order place has not been set than all lower order places must be disabled
				{
					return ButtonHelper.GetDisabledColor();  // represents disabled
				}
				else
				{
					//
					if (ReturnedBCV!.BibleBook!.ChapterIsWhole)
					{
						return ButtonEnums.Ones.ButtonColor;
					}
					else
					{
						return number <= ReturnedBCV!.BibleBook!.ChapterOnes ? ButtonEnums.Ones.ButtonColor : ButtonHelper.GetDisabledColor();
					}
				}

			}
		}
	}

	protected string GetDisabled(Place place, int number)
	{
		if (SetupChapter)
		{
			if (place == Place.Hundreds)
			{
				return number == ReturnedBCV!.BibleBook!.ChapterHundreds ? string.Empty : "disabled"; // ToDo: Review
			}
			else
			{
				if (place == Place.Tens)
				{
					return number <= ReturnedBCV!.BibleBook!.ChapterTens ? string.Empty : "disabled";
				}
				else
				{
					//if (tensPlace == -1)
					if (ReturnedBCV!.BibleBook!.ChapterTens != 0 && placeValue!.Tens == -1)
					{
						// if higher order has not been set than all lower orders are disabled
						return "disabled";
					}
					else
					{
						if (ReturnedBCV!.BibleBook!.ChapterIsWhole)
						{
							//return number <= ReturnedBCV!.BibleBook!.ChapterOnes ? string.Empty : "disabled";
							return "";
						}
						else
						{
							if (ReturnedBCV!.BibleBook!.ChapterTens > 0) // JKM
							{
								return number <= ReturnedBCV!.BibleBook!.ChapterOnes ? string.Empty : "disabled";
							}
							else
							{
								return "";
							}

						}
					}

				}
			}
		}

		if (!SetupChapter)
		{
			if (place == Place.Hundreds)
			{
				return number == LastVerseHelper.GetPlace(Place.Hundreds, LastVerse) ? string.Empty : "disabled";
			}
			else
			{
				if (place == Place.Tens)
				{
					return number == LastVerseHelper.GetPlace(Place.Tens, LastVerse) ? string.Empty : "disabled";
				}
				else // Place.Ones
				{
					if (placeValue!.Tens == -1)  //  tensPlace  if higher order has not been set than all lower orders are disabled
					{
						return "disabled";
					}
					else
					{
						if (LastVerseHelper.GetLastVerseIsWhole(LastVerse))
						{
							return "";
						}
						else
						{
							if (LastVerseHelper.GetPlace(Place.Tens, LastVerse) > 0) // JKM
							{
								return number <= LastVerseHelper.GetPlace(Place.Ones, LastVerse) ? string.Empty : "disabled";
							}
							else
							{
								return "";
							}
						}
					}
				}
			}
		}
		else
		{
			return "";
		}

	}

	/**/

	#region Active
	private int ActiveHundreds = -1;
	private int ActiveTens = -1;
	private int ActiveOnes = -1;

	public string GetActive(Place place, int number)
	{
		if (place == Place.Hundreds)
		{
			return number == ActiveHundreds ? " active" : "";
		}
		else
		{
			if (place == Place.Tens)
			{
				return number == ActiveTens ? " active" : "";
			}
			else // Place.Ones
			{
				//return number == ActiveOnes ? " active" : "";
				if (ActiveOnes == -1)  // This gets set to -1 by ResetActive()
				{
					return "";
				}
				else
				{
					return number == ActiveOnes ? " active" : "";
				}
			}
		}
	}
	#endregion



}