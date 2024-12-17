namespace MyHebrewBible.Client.Features.AlephTav.Enums;

public enum SectionStatus
{
	Loading,
	Hebrew_Table_Not_Shown,  // Initial, FocusScriptureId==0
	Hebrew_Table_Shown_Has_Top,
	Hebrew_Table_Shown_Has_Bottom,
	Hebrew_Table_Shown_Has_Top_And_Bottom
}
