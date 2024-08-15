using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.Lists.Components;

public partial class SubNavBar
{
	bool collapseNavMenu = true;
	string? SubNavBarCssClass => collapseNavMenu ? "collapse" : null;
	void ToggleSubNavBar()
	{
		collapseNavMenu = !collapseNavMenu;
	}

	[Parameter] public MenuItems? ActiveMenuItem { get; set; }
	protected string NavBarColor = " navbar-light bg-light ";  

	string GetActive(MenuItems currentMenuItem)
	{
		return ActiveMenuItem == currentMenuItem ? " active" : "";
	}

}
