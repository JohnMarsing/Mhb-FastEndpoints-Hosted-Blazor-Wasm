using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Helpers;

public class HtmlGeneration
{
	public static MarkupString CommentaryHeader(string subject)
	{
		return new MarkupString($@"
<div class='card-body py-1 text-center'>
	<div class='fs-4'>{subject}</div>
</div>
");
	}
	public static MarkupString TranscriptHeader(string footnote, string subject, string timestamp)
	{
		return new MarkupString($@"
<div class='d-flex justify-content-between'>
  <div class=''><sup class='pt-2'>JKM: {footnote}</sup></div>
	<div class='fs-4'>{subject}</div>
	<div class=''><sup class='text-black-50'>{timestamp}</sup></div></div>
</div>
");
	}

	public static MarkupString Verse(int i)
	{
		return new MarkupString($"<div class='col-1'><sup class='btn btn-outline-primary py-0 px-1'>{i}</sup></div>");
	}

	public static MarkupString VerseNoCol(int i)
	{
		return new MarkupString($"<sup class='text-primary fw-bold'>{i}</sup>");
	}


	public static MarkupString SubTitle(string s)
	{
		return new MarkupString($"<h6 class='mt-3 mb-3 text-end text-body-secondary pe-2'><i>{s}</i></h6>");
	}


	public static MarkupString TableHeading()
	{
		return new MarkupString($@"
<div class='row mb-4'>
	<div class='col-1 fw-bold text-decoration-underline'>#</div>
	<div class='col-3 fw-bold text-decoration-underline'>NG Translation</div>
	<div class='col-3 fw-bold text-decoration-underline'>KJV</div>
	<div class='col-4 fw-bold text-decoration-underline'>Hebrew Revelation</div>
	<div class='col-1 fw-bold text-decoration-underline'>fn</div>
</div>
");
	}

	public static MarkupString TableHeading3Cols()
	{
		return new MarkupString($@"
<div class='row mb-1 text-center'>
	<div class='col-4 fw-bold '>NG Translation</div>
	<div class='col-4 fw-bold'>KJV</div>
	<div class='col-4 fw-bold'>Hebrew Revelation</div>
</div>
");
		// text-decoration-underline
	}

	public static MarkupString TableHeading2Cols()
	{
		return new MarkupString($@"
<div class='row mb-1 text-center'>
	<div class='col-6 fw-bold '>NG Translation</div>
	<div class='col-6 fw-bold'>Hebrew Revelation</div>
</div>
");
	}


	public static MarkupString FootnoteJKM(string footnote, string subject, string timestamp)
	{
		return new MarkupString($@"
<div class='d-flex justify-content-between'>
  <div class=''><sup class='pt-2'>JKM: {footnote}</sup></div>
	<div class='fs-4'>{subject}</div>
	<div class=''><sup class='text-black-50'>{timestamp}</sup></div></div>
</div>
");
	}

	public static MarkupString FootnoteNG(int i)
	{
		return new MarkupString($"<sup class='text-danger fw-bold'>{i}</sup>");
	}
}

// Ignore Spelling: timestamp