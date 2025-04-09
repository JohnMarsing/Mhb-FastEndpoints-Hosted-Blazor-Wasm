using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.Haggadah;

public class Helper
{
	public static MarkupString TableHeading2Cols()
	{
		return new MarkupString($@"
<div class='row mb-1 text-center'>
	<div class='col-6 fw-bold '>English</div>
	<div class='col-6 fw-bold'>Spanish</div>
</div>
");
	}
}
