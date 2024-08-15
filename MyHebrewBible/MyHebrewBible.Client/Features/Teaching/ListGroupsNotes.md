

LivingMessiahBlazor/LivingMessiah.Web/Pages/Home/SukkotButton.razor

```html
<div class="list-group">

	<a href="@LivingMessiah.Web.Links.Sukkot.Index"
		 title="@LivingMessiah.Web.Links.Sukkot.Title"
		 class="list-group-item list-group-item-danger ">
		<i class="@LivingMessiah.Web.Links.Sukkot.Icon fa-fw fa-3x" aria-hidden="true"></i>
		<span class="home-page-xs"><b>@LivingMessiah.Web.Links.Sukkot.Title</b></span>
	</a>

</div>
```


LivingMessiahBlazor/LivingMessiah.Web/Pages/Articles/Articles.razor
```html
@page "/Articles"
@using Page = LivingMessiah.Web.Links.Articles

<PageTitle>@Page.Title</PageTitle>

@*	border-bottom*@
<div class="pb-2 mt-4 mb-2">
	<h2><span class="text-warning @Page.Icon"></span> @Page.Title</h2>
</div>

<div class="list-group">
	@*<a href="#" class="list-group-item list-group-item-action active">Active Example</a>*@
	<a class="list-group-item list-group-item-action list-group-item-warning"
		 href="@LivingMessiah.Web.Links.Articles.MakingChallahBread.Index">
		<i class="fas fa-link"></i> @LivingMessiah.Web.Links.Articles.MakingChallahBread.Title
	</a>
	<a class="list-group-item list-group-item-action list-group-item-warning"
		 href="@LivingMessiah.Web.Links.Articles.Prepared.Index">
		<i class="fas fa-link"></i> @LivingMessiah.Web.Links.Articles.Prepared.Title
	</a>
	<a class="list-group-item list-group-item-action list-group-item-warning"
		 href="@LivingMessiah.Web.Links.Articles.Pesach.Index">
		<i class="fas fa-link"></i> Pesach
	</a>
	@* ToDo: Fix CreateTagHelper reference <a class="list-group-item list-group-item-action list-group-item-warning" href="PesachRP"><i class="fas fa-link"></i>  @CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>()</a>*@
	@*<a href="#" class="list-group-item list-group-item-action disabled" tabindex="-1" aria-disabled="true">Disabled Example</a>*@
</div>
```


LivingMessiahBlazor/LivingMessiah.Web/Pages/Articles/Prepared.razor
```html
@page "/articles/Prepared"

@using Page = LivingMessiah.Web.Links.Articles

<PageTitle>@Page.Prepared.Title</PageTitle>

<BreadCrumbs Href="@Page.Index" 
						 ParentTitle="@Page.Title" 
						 Title="@Page.Prepared.Title" 
						 Icon="@Page.Prepared.Icon">
</BreadCrumbs>

<h5>A Thought on Preparing</h5>

<div class="float-end">
	<img src="@Blobs.UrlRoot("Polly.jpg")" class="rounded-circle" alt="Polly" />
	<div class="caption">
		<p>by Polly Webb</p>
	</div>
</div>

<p>
	The Hebrew word, <i>Asa</i> (Ayin, Shin, Hey) is used many times through out The Scriptures to depict one who sees a need and
	is fulfilling it or is being directed to fulfill a present need that is seen by someone else.
</p>
<p>
	Psalms 78:8 instructs me not to be like my ancestors, a stubborn and rebellious generation that did not <b>prepare their hearts</b>.
	I am instructed in 1 Peter 3:15 <b>to be prepared</b> in humility and fear, to give a reason for the hope that I have.
	John 14:2 Yahushua speaks of a place in His Fathers house that He is <b>going to prepare</b> for me.
	And Revelation 12:6,14 speaks of a place in the wilderness <b>prepared by YHWH</b> for the woman to flee where she would be taken care of.
	These are just a few examples of preparing I see through out Scripture.
</p>
<p>
	Participating in a Sabbath rest requires advanced preparations in several areas, my home, meal plans, personal attention,
	spiritual needs (prayer, fasting, study, meditation) and assembly gatherings.
</p>
<p>
	In order to properly prepare for a task or event I need to be able to see what it is that I am preparing for.
	Preparing becomes a lifestyle, not a one time event.
	May The Spirit of YHWH open my heart and hands daily for what may be required of me.
</p>
<p>
	Prior to the Fall Feasts my family takes a closer look at ourselves,
	physically and spiritually looking for  areas in need of attention, improvement, repentance and restoration.
</p>
<p>
	Here is a short check list of some of the areas we examine-<br />
	&nbsp;<b>Spiritually -</b><br />
	&nbsp;&nbsp;- Is my relationship with my Creator, YHWH in order?<br />
	&nbsp;&nbsp;- Is my relationship with my family, friends,neighbors in order?<br />
	&nbsp;&nbsp;- Is The Word of God the standard I govern every thought and deed?<br />
	&nbsp;&nbsp;- Am I giving thanks for <b>ALL</b> things?<br />
	&nbsp;<b>Physically -</b><br />
	&nbsp;&nbsp;- I am prepared to stay or go if I am required?<br />
	&nbsp;&nbsp;- Is my purse or daily use back pack equipped with what I need if I could not get back home today?<br />
	&nbsp;&nbsp;- Is my 3 day (72 hour) grab and go bag ready?<br />
	&nbsp;&nbsp;- Do I have a 3 week supply of food, water and necessary supplies in my home in the event I had to shelter in place?<br />
	&nbsp;&nbsp;- Are my priority lists made in advance if I had to grab and go and only had 5, 15 or 30 minutes?<br />
	&nbsp;&nbsp;- Do I know where I would go and have I made prior arrangements to do so?<br />
</p>
<p>
	Below is a helpful list my family has complied and divided into 5 areas of preparation.
	Use it for your next camping trip or as a tool in your preparation planner to fill your priority needs as you walk out your lifestyle of being prepared.
</p>
<p>
	May we be prepared to have our names written in The Lambs Book of Life and may we prepare for the return of our Savior.
</p>
<br />

<div class="table-responsive">
	<table class="table table-striped">
		<tr>
			<th>Water & Food</th>
			<th>Shelter, Fire, Light & Electricity</th>
			<th>Health, Medical & Sanitation</th>
		</tr>
		<tr><td>Filtration & Purification System</td><td>Tent, Poles, Stakes, String, Rope</td><td>First Aid Kit</td></tr>

		<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>
	</table>
</div>

<div class="table-responsive">
	<table class="table table-striped">
		<tr>
			<th>Communication, Documents & Travel</th>
			<th>Tools & Helpful Supplies</th>
		</tr>
		<tr><td>Cell Phones, Chargers</td><td>72 Hour Back Pack</td></tr>

	</table>

</div>

```