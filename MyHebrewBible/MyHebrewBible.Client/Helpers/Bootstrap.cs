namespace MyHebrewBible.Client.Helpers;

public static class Widths
{
	//	style ="width: 18rem;"
	//https://getbootstrap.com/docs/5.3/utilities/sizing/
	public const string w100 = "w-100"; // 100%
	public const string w75 = "w-75"; // 75%
	public const string w50 = "w-50"; // 50%
	public const string w25 = "w-25"; // 25%
	public const string w0 = "w-0"; // 0%
}

/*
### [Relative to Viewport Width and Height](https://getbootstrap.com/docs/5.3/utilities/sizing/#relative-to-the-viewport)
<div class="min-vw-100">Min-width 100vw</div>
<div class="min-vh-100">Min-height 100vh</div>
<div class="vw-100">Width 100vw</div>
<div class="vh-100">Height 100vh</div> 
 */

/*
public static class Heights
{
	//https://getbootstrap.com/docs/5.3/utilities/sizing/
	public const string h100 = "h-100"; // 100%
	public const string h75 = "h-75"; // 75%
	public const string h50 = "h-50"; // 50%
	public const string h25 = "h-25"; // 25%
	public const string h0 = "h-0"; // 0%
}

public static class TextAlignments
{
	public const string Start = "text-start"; // left
	public const string End = "text-end"; // right
	public const string Center = "text-center";
	public const string Justify = "text-justify";
	public const string Wrap = "text-wrap";
	public const string Break = "text-break";
}

public static class Display
{
	public const string None = "d-none"; // display: none;
	public const string Inline = "d-inline"; // display: inline;
	public const string InlineBlock = "d-inline-block"; // display: inline-block;
	public const string Block = "d-block"; // display: block;
	public const string Flex = "d-flex"; // display: flex;
	public const string Grid = "d-grid"; // display: grid;
	public const string Table = "d-table"; // display: table;
	public const string TableRow = "d-table-row"; // display: table-row;
	public const string TableCell = "d-table-cell"; // display: table-cell;
}	
*/


public static class TextColors
{
	public const string Primary = "text-primary";
	public const string Secondary = "text-secondary";
	public const string Success = "text-success";
	public const string Danger = "text-danger";
	public const string Warning = "text-warning";
	public const string Info = "text-info";
	public const string Light = "text-light bg-dark";
	public const string Muted = "text-muted";
	public const string Dark = "text-dark";
	public const string Body = "text-body";
	public const string BodySecondary = "text-body-secondary";
	public const string BodyTertiary = "text-body-tertiary";
	public const string Black = "text-black";
	public const string White = "text-white bg-dark";
	public const string Black50 = "text-black-50";
	public const string White50 = "text-white-50";
}

public static class BtnSize
{
	public const string Lg = "btn-lg";
	public const string Md = "btn-md";
	public const string Sm = "btn-sm";
}

public static class BtnGroupSize
{
	public const string Lg = "btn-group-lg";
	public const string Md = "btn-group-md";
	public const string Sm = "btn-group-sm";
}

public static class BtnColors
{
	public const string Primary = "btn-primary";
	public const string Secondary = "btn-secondary";
	public const string Success = "btn-success";
	public const string Danger = "btn-danger";
	public const string Warning = "btn-warning";
	public const string Info = "btn-info";
	public const string Light = "btn-light";
	public const string Dark = "btn-dark";
	public const string Link = "btn-link";
	//public const string Tertiary = "btn-tertiary"; 
}

public static class BtnOutlineColors
{
	public const string Primary = "btn-outline-primary";
	public const string Secondary = "btn-outline-secondary";
	public const string Success = "btn-outline-success";
	public const string Danger = "btn-outline-danger";
	public const string Warning = "btn-outline-warning";
	public const string Info = "btn-outline-info";
	public const string Light = "btn-outline-light";
	public const string Dark = "btn-outline-dark";
	public const string Link = "btn-outline-link";
}

//public static class BackGroundAndText
public static class BgAndText
{
public const string Primary = "bg-primary text-white";
public const string PrimarySubtle = "bg-primary-subtle text-primary-emphasis";
public const string Secondary = "bg-secondary text-white";
public const string SecondarySubtle = "bg-secondary-subtle text-secondary-emphasis";
public const string Success = "bg-success text-white";
public const string SuccessSubtle = "bg-success-subtle text-success-emphasis";
public const string Danger = "bg-danger text-white";
public const string DangerSubtle = "bg-danger-subtle text-danger-emphasis";
public const string Warning = "bg-warning text-dark";
public const string WarningSubtle = "bg-warning-subtle text-warning-emphasis";
public const string Info = "bg-info text-dark";
public const string InfoSubtle = "bg-info-subtle text-info-emphasis";
public const string Light = "bg-light text-dark";
public const string LightSubtle = "bg-light-subtle text-light-emphasis";
public const string Dark = "bg-dark text-white";
public const string DarkSubtle = "bg-dark-subtle text-dark-emphasis";
public const string BodySecondary = "bg-body-secondary";
public const string BodyTertiary = "bg-body-tertiary";
public const string Body = "bg-body text-body";
public const string Black = "bg-black text-white";
public const string White = "bg-white text-dark";
public const string Transparent = "bg-transparent text-body";
}

public static class Borders
{
	public const string Primary = "border-primary";
	public const string PrimarySubtle = "border-primary-subtle";
	public const string Secondary = "border-secondary";
	public const string SecondarySubtle = "border-secondary-subtle";
	public const string Success = "border-success";
	public const string SuccessSubtle = "border-success-subtle";
	public const string Danger = "border-danger";
	public const string DangerSubtle = "border-danger-subtle";
	public const string Warning = "border-warning";
	public const string WarningSubtle = "border-warning-subtle";
	public const string Info = "border-info";
	public const string InfoSubtle = "border-info-subtle";
	public const string Light = "border-light";
	public const string LightSubtle = "border-light-subtle";
	public const string Dark = "border-dark";
	public const string DarkSubtle = "border-dark-subtle";
	public const string Black = "border-black";
	public const string White = "border-white";
}


public static class BorderEdges
{
	/*
	 <span class="border-top"></span>
	 <span class="border border-0"></span>
	 */
	public const string Top = "border-top";
	public const string Bottom = "border-bottom";
	public const string Start = "border-start"; 
	public const string End = "border-end"; 
}

public static class BorderWidths
{
	public const string w0 = "border-0";
	public const string w1 = "border-1";
	public const string w2 = "border-2";
	public const string w3 = "border-3";
	public const string w4 = "border-4";
	public const string w5 = "border-5";
}

//AllTopBotStartEnd
public static class BorderRadius
{
	public const string Rounded = "rounded";
	public const string RoundedTop = "rounded-top";
	public const string RoundedBottom = "rounded-bottom";
	public const string RoundedStart = "rounded-start"; 
	public const string RoundedEnd = "rounded-end"; 
}

/*
public static class BorderRoundedSizes
{
	public const string r0 = "rounded-0";
	public const string r1 = "rounded-1";
	public const string r2 = "rounded-2";
	public const string r3 = "rounded-3";
	public const string r4 = "rounded-4";
	public const string r5 = "rounded-5";
	public const string Pill = "rounded-pill";
	public const string Circle = "rounded-circle"; 
}

public static class BorderRoundedCirclePill
{
	public const string Bottom = "rounded-bottom-1";
	public const string Start = "rounded-start-2";
	public const string EndCircle = "rounded-end-circle";
	public const string StartPill = "rounded-start-pill";
	public const string Top = "rounded-5 rounded-top-0";  // ???
}
*/

// Ignore spelling: bg

