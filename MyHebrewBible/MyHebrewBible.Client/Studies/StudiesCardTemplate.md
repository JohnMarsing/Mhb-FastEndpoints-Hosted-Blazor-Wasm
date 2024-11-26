# Studies Card Template

```html
@using BLBEnum=MyHebrewBible.Client.Enums
@using MyHebrewBible.Client.Helpers

<div class="card border-info my-2">

	<div class="card-body py-1">
		<p class="card-title">@HtmlGeneration.TranscriptHeader("F", "TITLE", "30:25")</p>
	</div>

	<!-- COMMENTS -->
	<div class="card-body py-1">

		<p class="card-text">
			<b>T-Bone</b>: 
			<b>Nehemia</b>:
			<b>AJ Bernard</b>:
			CONTENT
		</p>

		<p class="card-text"><b>SPEAKER</b>:CONTENT</p>

	</div>
</div>

@code }
  string HebrewSize = "hebrew"; // hebrew30
}
```