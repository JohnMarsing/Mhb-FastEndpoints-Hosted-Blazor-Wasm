using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Hebrew.Enums;

public abstract class Terms : SmartEnum<Terms>
{

	#region Id's

	private static class Id
	{
		internal const int Niqqud = 1;
		internal const int Holam = 2;
		internal const int Mappiq = 3;
		internal const int Dagesh = 4;
		internal const int DageshGrid = 5;
		internal const int DageshHazak = 6;
		internal const int Gutturals = 7;
		internal const int KubutzAndShuruk = 8;
		internal const int KtivHasarNiqqud = 9;
		internal const int HolamHaser = 10;
		internal const int MatresLectionis = 11;
		internal const int Shva = 12;
		internal const int PaleoHebrewAlephbet = 13;
		internal const int QereKetiv = 14;
	}
	#endregion

	private Terms(string name, int value) : base(name, value) { } // Constructor

	#region  Declared Public Instances
	public static readonly Terms Niqqud = new NiqqudSE();
	public static readonly Terms Holam = new HolamSE();
	public static readonly Terms Mappiq = new MappiqSE();
	public static readonly Terms Dagesh = new DageshSE();
	public static readonly Terms DageshGrid = new DageshGridSE();
	public static readonly Terms DageshHazak = new DageshHazakSE();
	public static readonly Terms Gutturals = new GutturalsSE();
	public static readonly Terms KubutzAndShuruk = new KubutzAndShurukSE();
	public static readonly Terms KtivHasarNiqqud = new KtivHasarNiqqudSE();
	public static readonly Terms HolamHaser = new HolamHaserSE();
	public static readonly Terms MatresLectionis = new MatresLectionisSE();
	public static readonly Terms Shva = new ShvaSE();
	public static readonly Terms PaleoHebrewAlephbet = new PaleoHebrewAlephbetSE();
	public static readonly Terms QereKetiv = new QereKetivSE();

	/*

	Resources
	*/
	// SE=SmartEnum
	#endregion

	#region Extra Fields

	public abstract string Title { get; }
	public abstract string Definition { get; }
	#endregion

	#region Private Instantiation

	private sealed class NiqqudSE : Terms
	{
		public NiqqudSE() : base($"{nameof(Id.Niqqud)}", Id.Niqqud) { }
		public override string Title => nameof(Id.Niqqud);
		public override string Definition => @"
<b>dotting</b> or <b>pointing</b> is a <a href='https://en.wikipedia.org/wiki/Diacritic'>diacritical</a> system of signs (<span class='hebrew small'>נִקּוּד</span> means point in Hebrew) to represent vowels (i.e. <b>Vowel Points</b>).
The most common system was created by the <a href='https://en.wikipedia.org/wiki/Masoretes'>Masoretes</a> of Tiberias in the second half of the first millennium AD in the Land of Israel.
<small><a href='https://en.wikipedia.org/wiki/Niqqud'><i class='fas fa-external-link-alt' aria-hidden='true'>&nbsp;</i><i class='fab fa-wikipedia-w' aria-hidden='true'></i></a></small>
";
	}

	private sealed class HolamSE : Terms
	{
		public HolamSE() : base($"{nameof(Id.Holam)}", Id.Holam) { }
		public override string Title => nameof(Id.Holam);
		public override string Definition => @"
<i>holam</i> (<span class=""hebrew small"">חוֹלָם</span>) is vowel sign represented by a dot above the upper left corner of the consonant letter that makes an &#0333 sound like boat
<small><a href=""https://en.wikipedia.org/wiki/Holam""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
		";
	}

	private sealed class MappiqSE : Terms
	{
		public MappiqSE() : base($"{nameof(Id.Mappiq)}", Id.Mappiq) { }
		public override string Title => nameof(Id.Mappiq);
		public override string Definition => @"
<i>mappiq</i> <span class=""hebrew small"">&#1488</span> (<span class=""hebrew small"">מפיק</span> which means ""causing to go out"" in Hebrew) is a vowel point which takes the form of a dot in the middle of a letter
(usually the <i>hey</i> <span class=""hebrew small"">ה</span>, and rarely the <i>aleph</i> <span class=""hebrew small"">&#1488</span>).
An identical point with a different phonetic function (marking different consonants) is called a <i>dagesh</i>.
<small><a href=""https://en.wikipedia.org/wiki/Mappiq""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
		";
	}

	private sealed class DageshSE : Terms
	{
		public DageshSE() : base($"{nameof(Id.Dagesh)}", Id.Dagesh) { }
		public override string Title => nameof(Id.Dagesh);
		public override string Definition => @"
				<i>dagesh</i> (<span class=""hebrew small"">דָּגֵשׁ</span>) means emphasis (plural <i>dagashim</i>) and is a vowel point which takes the form of a dot in the middle of a letter and has the effect of modifying the sound in one of two ways.
				An identical mark called <i>mappiq</i>, has a different phonetic function, and can be applied to different consonants;
				the same mark is also employed in the vowel <i>shuruk</i> <span class=""hebrew small"">&#1468</span>.
				The two functions of <i>dagesh</i> are distinguished as either <i>kal</i> (light) or <i>hazak</i> (strong).
				<br />&nbsp;&nbsp;<b><i>dagesh kal</i></b> may be placed inside the consonants <span class=""hebrew small"">ב</span> <i>bet</i>, <span class=""hebrew small"">ג</span> <i>gimel</i>,
				<span class=""hebrew small"">ד</span> <i>dalet</i>, <span class=""hebrew small"">כ</span> <i>kaf</i>, <span class=""hebrew small"">פ</span> <i>pe</i> and <span class=""hebrew small"">ת</span> <i>tav</i>.
				This is made into an acronmy called <b><i>BeGadKeFat</i></b>
				<small><a href=""https://en.wikipedia.org/wiki/Begadkefat""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
				&nbsp;<small><a href=""http://www.hebrew4christians.com/Grammar/Unit_One/Begedkephat_Letters/begedkephat_letters.html""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fa fa-university"" aria-hidden=""true""></i></a></small>
		";
	}


	private sealed class DageshGridSE : Terms
	{
		public DageshGridSE() : base($"{nameof(Id.DageshGrid)}", Id.DageshGrid) { }
		public override string Title => nameof(Id.DageshGrid);
		public override string Definition => @"
				<div class=""row mt-5"">
					<div class=""col-4"">
						In modern Hebrew three of these letters can have their sounds change dependent on the presence of a <i>dagesh</i> or not.
						The three are the <i>bet</i>, <i>caf</i> and <i>pey</i>, and without the <i>dagesh</i> their respective sounds are soften to the <i>vet</i>, <i>chaf</i> and <i>fey</i>.
					</div>

					<div class=""col-4"">
						<div class=""table-responsive"">
							<table class=""table table-condensed table-striped"">
								<tr>
									<th colspan=""2"">No Dagesh</th>
								</tr>
								<tr>
									<td>vet</td>
									<td class=""hebrew small text-center"">ב</td>
								</tr>
								<tr>
									<td>chaf</td>
									<td class=""hebrew small text-center"">כ</td>
								</tr>
								<tr>
									<td>fey</td>
									<td class=""hebrew small text-center"">פ</td>
								</tr>

							</table>
						</div>
					</div>

					<div class=""col-4"">
						<div class=""table-responsive"">
							<table class=""table table-condensed table-striped"">
								<tr>
									<th colspan=""2"">With Dagesh</th>
								</tr>
								<tr>
									<td>bet</td>
									<td class=""hebrew small text-center"">בּ</td>
								</tr>
								<tr>
									<td>caf</td>
									<td class=""hebrew small text-center"">כּ</td>
								</tr>
								<tr>
									<td>pey</td>
									<td class=""hebrew small text-center"">פּ</td>
								</tr>
							</table>
						</div>
					</div>

				</div>
		";
	}


	private sealed class DageshHazakSE : Terms
	{
		public DageshHazakSE() : base($"{nameof(Id.DageshHazak)}", Id.DageshHazak) { }
		public override string Title => nameof(Id.DageshHazak);
		public override string Definition => @"
&nbsp;&nbsp;<b><i>dagesh hazak</i></b> (<span class=""hebrew small"">דגש חזק</span>) may be placed in almost any letter, this indicated a doubling of that consonant in the pronunciation of pre-modern Hebrew.
The following letters, the gutturals, almost never have a <i>dagesh</i>.
A few instances of <i>resh</i> with <i>dagesh</i> are masoretically recorded in the Hebrew Bible, as well as a few cases of aleph with a dagesh, such as in Lev 23:17.
<small><a href=""https://en.wikipedia.org/wiki/Dagesh""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
&nbsp;<small><a href=""http://www.hebrew4christians.com/Grammar/Unit_Three/Dotted_Letters/dotted_letters.html""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fa fa-university"" aria-hidden=""true""></i></a></small>
		";
	}


	private sealed class GutturalsSE : Terms
	{
		public GutturalsSE() : base($"{nameof(Id.Gutturals)}", Id.Gutturals) { }
		public override string Title => nameof(Id.Gutturals);
		public override string Definition => @"
The Hebrew gutturals are <span class=""hebrew small"">א</span> <i>aleph</i>, <span class=""hebrew small"">ה</span> <i>hey</i>, <span class=""hebrew small"">ח</span> <i>chet</i>,
<span class=""hebrew small"">ע</span> <i>ayin</i>, <span class=""hebrew small"">ר</span> <i>resh</i>.
&nbsp;<small><a href=""http://www.hebrew4christians.com/Grammar/Unit_One/Guttural_Letters/guttural_letters.html""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fa fa-university"" aria-hidden=""true""></i></a></small>
		";
	}

	private sealed class KubutzAndShurukSE : Terms
	{
		public KubutzAndShurukSE() : base($"{nameof(Id.KubutzAndShuruk)}", Id.KubutzAndShuruk) { }
		public override string Title => "Kubutz and Shuruk";
		public override string Definition => @"
both of these letters represent the <b>u</b> sound like b<u>oo</u>t.  <i>Kubutz</i> has three dots underneath like here (using a bet)... <span class=""hebrew gray"">&#1489</span><span class=""hebrew vp"">&#1467</span>
<i>shuruk</i> always uses the letter <i>vav</i> with a dot in the middle and to the left of it like... <span class=""hebrew gray"">&#1493</span><span class=""hebrew vp"">&#1468</span>.
<br />The dot is identical to the grammatically different signs unicode <a href=""http://www.fileformat.info/info/unicode/char/05BC/index.htm"">#1468</a> (<i>dagesh</i> and <i>mapiq</i>),
Shuruk itself is a vowel sign, so if the letter before the vav doesn't have its own vowel sign then the vav with the dot is a Shuruk and otherwise it is a vav with a Dagesh or a Mappiq.
Furthermore, the Mappiq only appears at the end of the word and only in the letter He (ה)     {exception with the Aleph}
<small><a href=""https://en.wikipedia.org/wiki/Kubutz_and_Shuruk""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
		";
	}

	private sealed class KtivHasarNiqqudSE : Terms
	{
		public KtivHasarNiqqudSE() : base($"{nameof(Id.KtivHasarNiqqud)}", Id.KtivHasarNiqqud) { }
		public override string Title => "Ktiv Hasar Niqqud";
		public override string Definition => @"
are the rules for writing Hebrew without vowel pointers (<i>niqqud</i>), often replacing them with <i>matres lectionis</i>.
<span class=""hebrew small"">כתיב חסר ניקוד</span> literally means ""spelling lacking niqqud"", colloquially known as <i>ktiv male</i> <span class=""hebrew small"">כתיב מלא</span>
To avoid confusion, the Hebrew consonants <i>vav</i> <span class=""hebrew small"">&#1493</span> and sometimes the <i>hey</i> <span class=""hebrew small"">&#1492</span> or <i>yood</i> are doubled in the middle of words.
<small><a href=""https://en.wikipedia.org/wiki/Ktiv_hasar_niqqud""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
		";
	}

	private sealed class HolamHaserSE : Terms
	{
		public HolamHaserSE() : base($"{nameof(Id.HolamHaser)}", Id.HolamHaser) { }
		public override string Title => "Holam Haser";
		public override string Definition => @"
is written as <i>vav</i> <span class=""hebrew small"">&#1493</span> in text without <i>niqqud</i> (vowel points).
		";
	}

	private sealed class MatresLectionisSE : Terms
	{
		public MatresLectionisSE() : base($"{nameof(Id.MatresLectionis)}", Id.MatresLectionis) { }
		public override string Title => "Matres Lectionis";
		public override string Definition => @"
Hebrew used to only contain consonant letters which can be confusion because it can be read differently so some of the consonant letters were used for the indication of long vowels.
The long vowel used is <i>vav</i> <span class=""hebrew small"">&#1493</span> and sometimes the <i>hey</i> <span class=""hebrew small"">&#1492</span> or <i>yood</i> <span class=""hebrew small"">&#1497</span> are used.
This thing came to be known as <i>matres lectionis</i> (Latin mothers of reading).
<small><a href=""https://en.wikipedia.org/wiki/Mater_lectionis""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
		";
	}

	private sealed class ShvaSE : Terms
	{
		public ShvaSE() : base($"{nameof(Id.Shva)}", Id.Shva) { }
		public override string Title => nameof(Id.Shva);
		public override string Definition => @"
Here is a link for this.
<small><a href=""https://en.wikipedia.org/wiki/Shva""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
&nbsp;<i>Shva Nach</i> (the resting, or silent <i>shva</i>)
&nbsp;<small><a href=""http://www.hebrew4christians.com/Grammar/Unit_Three/Sheva_Nach/sheva_nach.html""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fa fa-university"" aria-hidden=""true""></i></a></small>
		";
	}

	private sealed class PaleoHebrewAlephbetSE : Terms
	{
		public PaleoHebrewAlephbetSE() : base($"{nameof(Id.PaleoHebrewAlephbet)}", Id.PaleoHebrewAlephbet) { }
		public override string Title => "Paleo Hebrew Alephbet";
		public override string Definition => @"
Here is a link for this.
<small><a href=""https://en.wikipedia.org/wiki/Paleo-Hebrew_alphabet""><i class=""fas fa-external-link-alt"" aria-hidden=""true"">&nbsp;</i><i class=""fab fa-wikipedia-w"" aria-hidden=""true""></i></a></small>
		";
	}

	private sealed class QereKetivSE : Terms
	{
		public QereKetivSE() : base($"{nameof(Id.QereKetiv)}", Id.QereKetiv) { }
		public override string Title => "QereKetiv";
		public override string Definition => @"
The most important of the Masoretic notes are those that detail the <b><i>Qere</i></b> <span class=""hebrew small"">קְרֵי </span><sup>(what is <b>read</b>)</sup> and <b><i>Ketiv</i></b> <span class=""hebrew small"">כְּתִיב </span><sup>(what is <b>written</b>)</sup>
that are located in the Masorah parva in the outside margins of BHS. Given that the Masoretes would not alter the sacred consonantal text,
the <i>Kethiv-Qere</i> notes were a way of ""correcting"" or commenting on the text for any number of reasons
(grammatical, theological, aesthetic, etc.) deemed important by the copyist.
<a href=""#"" title=""Pratico and Van Pelt, Basics of Biblical Hebrew, Zondervan. 2001. p406ff"">[22]</a>
<a href=""https://en.wikipedia.org/wiki/Masoretic_Text#Numerical_Masorah"">Source </a> <i class=""fas fa-external-link-alt"">&nbsp;</i><i class=""fab fa-wikipedia-w""></i>.
For a more detailed page see <a href=""https://en.wikipedia.org/wiki/Qere_and_Ketiv""><i>Qere Ketiv</i></a> <i class=""fas fa-external-link-alt"">&nbsp;</i><i class=""fab fa-wikipedia-w""></i>.
<br />See <a href=""Hebrew/QereKetiv"">list</a> <i class=""fa fa-link"">&nbsp;</i>of verses.
		";
	}

	#endregion
}
