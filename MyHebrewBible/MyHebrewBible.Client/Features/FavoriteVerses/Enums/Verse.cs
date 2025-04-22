using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.FavoriteVerses.Enums;

public abstract class Verse : SmartEnum<Verse>
{
	#region Id's
	private static class Id
	{
		internal const int Gen_1_1 = 1;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly Verse Gen_1_1 = new Gen_1_1SE();
	public static readonly Verse Gen_49_10 = new Gen_49_10SE();
	public static readonly Verse Psa_98_3 = new Psa_98_3SE();
	public static readonly Verse Psa_122_1_to_9 = new Psa_122_1_to_9SE();
	public static readonly Verse Isa_1_17_to_18 = new Isa_1_17_to_18SE();
	public static readonly Verse Isa_2_3_to_4 = new Isa_2_3_to_4SE();
	public static readonly Verse Isa_9_6 = new Isa_9_6SE();
	public static readonly Verse Isa_11_11_to_13 = new Isa_11_11_to_13SE();
	public static readonly Verse Isa_53_5_to_6 = new Isa_53_5_to_6SE();
	public static readonly Verse Jer_3_6_to_12 = new Jer_3_6_to_12SE();
	public static readonly Verse Exo_15_18 = new Exo_15_18SE();
	public static readonly Verse Jer_31_31_to_34 = new Jer_31_31_to_34SE();
	public static readonly Verse Exo_19_3_to_6 = new Exo_19_3_to_6SE();
	public static readonly Verse Exo_19_7_to_8 = new Exo_19_7_to_8SE();
	public static readonly Verse Exo_20_16_to_21 = new Exo_20_16_to_21SE();
	public static readonly Verse Exo_21_5_to_6 = new Exo_21_5_to_6SE();
	public static readonly Verse Eze_36_26_to_27 = new Eze_36_26_to_27SE();
	public static readonly Verse Eze_37_15_to_17 = new Eze_37_15_to_17SE();
	public static readonly Verse Eze_37_26 = new Eze_37_26SE();
	public static readonly Verse Hos_1_1_to_11 = new Hos_1_1_to_11SE();
	public static readonly Verse Hos_4_6 = new Hos_4_6SE();
	public static readonly Verse Mal_4_4_to_6 = new Mal_4_4_to_6SE();
	public static readonly Verse Mat_5_17_to_20 = new Mat_5_17_to_20SE();
	public static readonly Verse Mat_5_22_to_26 = new Mat_5_22_to_26SE();
	public static readonly Verse Mat_10_5_to_7 = new Mat_10_5_to_7SE();
	public static readonly Verse Mat_15_24 = new Mat_15_24SE();
	public static readonly Verse Mat_18_15_to_17 = new Mat_18_15_to_17SE();
	public static readonly Verse Mat_18_18_to_20 = new Mat_18_18_to_20SE();
	public static readonly Verse Mat_22_37_to_40 = new Mat_22_37_to_40SE();
	public static readonly Verse Exo_31_12_to_17 = new Exo_31_12_to_17SE();
	public static readonly Verse Joh_1_17 = new Joh_1_17SE();
	public static readonly Verse Joh_14_15 = new Joh_14_15SE();
	public static readonly Verse Rom_1_1 = new Rom_1_1SE();
	public static readonly Verse Co1_7_20_to_24 = new Co1_7_20_to_24SE();
	public static readonly Verse Gal_3_28_to_29 = new Gal_3_28_to_29SE();
	public static readonly Verse Eph_2_12_to_19 = new Eph_2_12_to_19SE();
	public static readonly Verse Col_2_14 = new Col_2_14SE();
	public static readonly Verse Ti1_1_4 = new Ti1_1_4SE();
	public static readonly Verse Ti2_2_15 = new Ti2_2_15SE();
	public static readonly Verse Gen_12_1_to_2 = new Gen_12_1_to_2SE();
	public static readonly Verse Jam_1_27 = new Jam_1_27SE();
	public static readonly Verse Pe1_2_9_to_10 = new Pe1_2_9_to_10SE();
	public static readonly Verse Rev_21_24_to_27 = new Rev_21_24_to_27SE();
	public static readonly Verse Lev_19_17_to_18 = new Lev_19_17_to_18SE();
	public static readonly Verse Lev_26_40_to_42 = new Lev_26_40_to_42SE();
	public static readonly Verse Gen_15_12_to_17 = new Gen_15_12_to_17SE();
	public static readonly Verse Num_13_31_to_32 = new Num_13_31_to_32SE();
	public static readonly Verse Deu_16_18_to_20 = new Deu_16_18_to_20SE();
	public static readonly Verse Deu_17_14_to_20 = new Deu_17_14_to_20SE();
	public static readonly Verse Deu_17_18_to_20 = new Deu_17_18_to_20SE();
	public static readonly Verse Deu_18_15_to_19 = new Deu_18_15_to_19SE();
	public static readonly Verse Deu_18_20 = new Deu_18_20SE();
	public static readonly Verse Deu_19_15 = new Deu_19_15SE();
	public static readonly Verse Deu_19_16_to_21 = new Deu_19_16_to_21SE();
	public static readonly Verse Deu_24_1_to_4 = new Deu_24_1_to_4SE();
	public static readonly Verse Gen_3_12_to_17 = new Gen_3_12_to_17SE();
	public static readonly Verse Gen_4_9_to_14 = new Gen_4_9_to_14SE();
	// SE=SmartEnum
	#endregion

	private Verse(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract int BegId { get; }
	public abstract int EndId { get; }
	public abstract int BookId { get; }
	public abstract string VerseName { get; }
	public abstract string VerseNameAbrv { get; }
	public abstract string BCV { get; }
	public abstract string VerseDescription { get; }
	public abstract string Commentary { get; }
	public abstract string ConcatenatedVerses { get; }
	public abstract bool HasExtraInfo { get; }
	#endregion

	#region Private Instantiation
	private sealed class Gen_1_1SE : Verse
	{
		public Gen_1_1SE() : base("Gen_1_1", 1) { }
		public override int BegId => 1;
		public override int EndId => 1;
		public override int BookId => 1;
		public override string VerseName => "Genesis 1:1";
		public override string VerseNameAbrv => "Gen 1:1";
		public override string BCV => $"Gen/1/1/{BegId}";
		public override string VerseDescription => "Creation";
		public override string Commentary => "Arguably the most important verse in scripture";
		public override string ConcatenatedVerses => "<sup>1</sup> In the beginning God created the heaven and the earth.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Gen_3_12_to_17SE : Verse
	{
		public Gen_3_12_to_17SE() : base("Gen_3_12_to_17", 2) { }
		public override int BegId => 68;
		public override int EndId => 73;
		public override int BookId => 1;
		public override string VerseName => "Genesis 3:12-17";
		public override string VerseNameAbrv => "Gen 3:12-17";
		public override string BCV => $"Gen/3/12/{BegId}"; //-17
		public override string VerseDescription => "Adam projects his problems on the woman and God";
		public override string Commentary => "This is the proximate cause of why we Adamites have found ourselves in &quot;the Bizarro world&quot;.";
		public override string ConcatenatedVerses => "<sup>12</sup> And the man said, The woman whom thou gavest to be with me, she gave me of the tree, and I did eat. <sup>13</sup> And the LORD God said unto the woman, What is this that thou hast done? And the woman said, The serpent beguiled me, and I did eat. <sup>14</sup> And the LORD God said unto the serpent, Because thou hast done this, thou art cursed above all cattle, and above every beast of the field; upon thy belly shalt thou go, and dust shalt thou eat all the days of thy life: <sup>15</sup> And I will put enmity between thee and the woman, and between thy seed and her seed; it shall bruise thy head, and thou shalt bruise his heel. <sup>16</sup> Unto the woman he said, I will greatly multiply thy sorrow and thy conception; in sorrow thou shalt bring forth children; and thy desire shall be to thy husband, and he shall rule over thee. <sup>17</sup> And unto Adam he said, Because thou hast hearkened unto the voice of thy wife, and hast eaten of the tree, of which I commanded thee, saying, Thou shalt not eat of it: cursed is the ground for thy sake; in sorrow shalt thou eat of it all the days of thy life;";
		public override bool HasExtraInfo => false;
	}
	private sealed class Gen_4_9_to_14SE : Verse
	{
		public Gen_4_9_to_14SE() : base("Gen_4_9_to_14", 3) { }
		public override int BegId => 89;
		public override int EndId => 94;
		public override int BookId => 1;
		public override string VerseName => "Genesis 4:9-14";
		public override string VerseNameAbrv => "Gen 4:9-14";
		public override string BCV => $"Gen/4/9/{BegId}"; //-14
		public override string VerseDescription => "Brother\'s Keeper";
		public override string Commentary => "Are you your brother\'s keeper";
		public override string ConcatenatedVerses => "<sup>9</sup> And the LORD said unto Cain, Where is Abel thy brother? And he said, I know not: Am I my brother's keeper? <sup>10</sup> And he said, What hast thou done? the voice of thy brother's blood crieth unto me from the ground. <sup>11</sup> And now art thou cursed from the earth, which hath opened her mouth to receive thy brother's blood from thy hand; <sup>12</sup> When thou tillest the ground, it shall not henceforth yield unto thee her strength; a fugitive and a vagabond shalt thou be in the earth. <sup>13</sup> And Cain said unto the LORD, My punishment is greater than I can bear. <sup>14</sup> Behold, thou hast driven me out this day from the face of the earth; and from thy face shall I be hid; and I shall be a fugitive and a vagabond in the earth; and it shall come to pass, that every one that findeth me shall slay me.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Gen_12_1_to_2SE : Verse
	{
		public Gen_12_1_to_2SE() : base("Gen_12_1_to_2", 4) { }
		public override int BegId => 300;
		public override int EndId => 301;
		public override int BookId => 1;
		public override string VerseName => "Genesis 12:1-2";
		public override string VerseNameAbrv => "Gen 12:1-2";
		public override string BCV => $"Gen/12/1/{BegId}"; //-2
		public override string VerseDescription => "God calls Abram";
		public override string Commentary => "A promise from God to Abram was made, was this conditional";
		public override string ConcatenatedVerses => "<sup>1</sup> Now the LORD had said unto Abram, Get thee out of thy country, and from thy kindred, and from thy father's house, unto a land that I will show thee: <sup>2</sup> And I will make of thee a great nation, and I will bless thee, and make thy name great; and thou shalt be a blessing:";
		public override bool HasExtraInfo => false;
	}
	private sealed class Gen_15_12_to_17SE : Verse
	{
		public Gen_15_12_to_17SE() : base("Gen_15_12_to_17", 5) { }
		public override int BegId => 373;
		public override int EndId => 378;
		public override int BookId => 1;
		public override string VerseName => "Genesis 15:12-17";
		public override string VerseNameAbrv => "Gen 15:12-17";
		public override string BCV => $"Gen/15/12/{BegId}"; //-17
		public override string VerseDescription => "The estate for Abram is created";
		public override string Commentary => "These verses bring up interesting questions with regard to what makes up the necessary elements of a contract/covenant";
		public override string ConcatenatedVerses => "<sup>12</sup> And when the sun was going down, a deep sleep fell upon Abram; and, lo, an horror of great darkness fell upon him. <sup>13</sup> And he said unto Abram, Know of a surety that thy seed shall be a stranger in a land that is not theirs, and shall serve them; and they shall afflict them four hundred years; <sup>14</sup> And also that nation, whom they shall serve, will I judge: and afterward shall they come out with great substance. <sup>15</sup> And thou shalt go to thy fathers in peace; thou shalt be buried in a good old age. <sup>16</sup> But in the fourth generation they shall come hither again: for the iniquity of the Amorites is not yet full. <sup>17</sup> And it came to pass, that, when the sun went down, and it was dark, behold a smoking furnace, and a burning lamp that passed between those pieces.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Gen_49_10SE : Verse
	{
		public Gen_49_10SE() : base("Gen_49_10", 6) { }
		public override int BegId => 1484;
		public override int EndId => 1484;
		public override int BookId => 1;
		public override string VerseName => "Genesis 49:10";
		public override string VerseNameAbrv => "Gen 49:10";
		public override string BCV => $"Gen/49/10/{BegId}";
		public override string VerseDescription => "Until Shiloh cometh, the sceptre, Judah, giver of law";
		public override string Commentary => "This has law written all over it, but what does it mean???";
		public override string ConcatenatedVerses => "<sup>10</sup> The sceptre shall not depart from Judah, nor a lawgiver from between his feet, until Shiloh come; and unto him shall the gathering of the people be.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Exo_15_18SE : Verse
	{
		public Exo_15_18SE() : base("Exo_15_18", 7) { }
		public override int BegId => 1939;
		public override int EndId => 1939;
		public override int BookId => 2;
		public override string VerseName => "Exodus 15:18";
		public override string VerseNameAbrv => "Exo 15:18";
		public override string BCV => $"Exo/15/18/{BegId}";
		public override string VerseDescription => "YHVH is the King of Israel";
		public override string Commentary => "These needs to be contrasted to what happened in 1<sup>st</sup> chapter 8, and latter on in the Declaration of Independence";
		public override string ConcatenatedVerses => "<sup>18</sup> The LORD shall reign for ever and ever.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Exo_19_3_to_6SE : Verse
	{
		public Exo_19_3_to_6SE() : base("Exo_19_3_to_6", 8) { }
		public override int BegId => 2030;
		public override int EndId => 2033;
		public override int BookId => 2;
		public override string VerseName => "Exodus 19:3-6";
		public override string VerseNameAbrv => "Exo 19:3-6";
		public override string BCV => $"Exo/19/3/{BegId}"; //-6

		public override string VerseDescription => "The promise of YHVH, i.e. the Offer, is given to Israel";
		public override string Commentary => "If Israel obeys the covenant, they shall be a peculiar treasure, a kingdom of priests for the nations";
		public override string ConcatenatedVerses => "<sup>3</sup> And Moses went up unto God, and the LORD called unto him out of the mountain, saying, Thus shalt thou say to the house of Jacob, and tell the children of Israel; <sup>4</sup> Ye have seen what I did unto the Egyptians, and how I bare you on eagles' wings, and brought you unto myself. <sup>5</sup> Now therefore, if ye will obey my voice indeed, and keep my covenant, then ye shall be a peculiar treasure unto me above all people: for all the earth is mine: <sup>6</sup> And ye shall be unto me a kingdom of priests, and an holy nation. These are the words which thou shalt speak unto the children of Israel.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Exo_19_7_to_8SE : Verse
	{
		public Exo_19_7_to_8SE() : base("Exo_19_7_to_8", 9) { }
		public override int BegId => 2034;
		public override int EndId => 2035;
		public override int BookId => 2;
		public override string VerseName => "Exodus 19:7-8";
		public override string BCV => $"Exo/19/7/{BegId}"; //-8
		public override string VerseNameAbrv => "Exo 19:7-8";
		public override string VerseDescription => "Offer accepted by Israel";
		public override string Commentary => "By having an offer and an acceptance which the meetings of the minds gives us a contract/covenant";
		public override string ConcatenatedVerses => "<sup>7</sup> And Moses came and called for the elders of the people, and laid before their faces all these words which the LORD commanded him. <sup>8</sup> And all the people answered together, and said, All that the LORD hath spoken we will do. And Moses returned the words of the people unto the LORD.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Exo_20_16_to_21SE : Verse
	{
		public Exo_20_16_to_21SE() : base("Exo_20_16_to_21", 10) { }
		public override int BegId => 2068;
		public override int EndId => 2073;
		public override int BookId => 2;
		public override string VerseName => "Exodus 20:16-21";
		public override string VerseNameAbrv => "Exo 20:16-21";
		public override string BCV => $"Exo/20/16/{BegId}"; //-21
		public override string VerseDescription => "Not to bear false witness";
		public override string Commentary => "An excellent quote from <b>Martin Luther</b> &quot;...[to] not deceitfully belie, betray, slander, nor defame our neighbor, but defend him, speak well of him, and <b>put the best construction on everything</b>&quot;.  See <sup>Deu 19:15-21, Jam 4:11</sup>";
		public override string ConcatenatedVerses => "<sup>16</sup> Thou shalt not bear false witness against thy neighbor. <sup>17</sup> Thou shalt not covet thy neighbor's house, thou shalt not covet thy neighbor's wife, nor his manservant, nor his maidservant, nor his ox, nor his ass, nor any thing that is thy neighbor's. <sup>18</sup> And all the people saw the thunderings, and the lightnings, and the noise of the trumpet, and the mountain smoking: and when the people saw it, they removed, and stood afar off. <sup>19</sup> And they said unto Moses, Speak thou with us, and we will hear: but let not God speak with us, lest we die. <sup>20</sup> And Moses said unto the people, Fear not: for God is come to prove you, and that his fear may be before your faces, that ye sin not. <sup>21</sup> And the people stood afar off, and Moses drew near unto the thick darkness where God was.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Exo_21_5_to_6SE : Verse
	{
		public Exo_21_5_to_6SE() : base("Exo_21_5_to_6", 11) { }
		public override int BegId => 2083;
		public override int EndId => 2084;
		public override int BookId => 2;
		public override string VerseName => "Exodus 21:5-6";
		public override string VerseNameAbrv => "Exo 21:5-6";
		public override string BCV => $"Exo/21/5/{BegId}"; //-6
		public override string VerseDescription => "For the servant whose ear is bored";
		public override string Commentary => "Is it required for the House of Israel to (at least symbolically) to become this type of servant";
		public override string ConcatenatedVerses => "<sup>5</sup> And if the servant shall plainly say, I love my master, my wife, and my children; I will not go out free: <sup>6</sup> Then his master shall bring him unto the judges; he shall also bring him to the door, or unto the door post; and his master shall bore his ear through with an awl; and he shall serve him for ever.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Exo_31_12_to_17SE : Verse
	{
		public Exo_31_12_to_17SE() : base("Exo_31_12_to_17", 12) { }
		public override int BegId => 2433;
		public override int EndId => 2438;
		public override int BookId => 2;
		public override string VerseName => "Exodus 31:12-17";
		public override string VerseNameAbrv => "Exo 31:12-17";
		public override string BCV => $"Exo/31/12/{BegId}"; //-17
		public override string VerseDescription => "my Sabbaths ye shall keep";
		public override string Commentary => "A blunt requirement for keeping the sabbath. It is a sign between Adonai and the children of Israel for ever";
		public override string ConcatenatedVerses => "<sup>12</sup> And the LORD spake unto Moses, saying, <sup>13</sup> Speak thou also unto the children of Israel, saying, Verily my sabbaths ye shall keep: for it is a sign between me and you throughout your generations; that ye may know that I am the LORD that doth sanctify you. <sup>14</sup> Ye shall keep the sabbath therefore; for it is holy unto you: every one that defileth it shall surely be put to death: for whosoever doeth any work therein, that soul shall be cut off from among his people. <sup>15</sup> Six days may work be done; but in the seventh is the sabbath of rest, holy to the LORD: whosoever doeth any work in the sabbath day, he shall surely be put to death. <sup>16</sup> Wherefore the children of Israel shall keep the sabbath, to observe the sabbath throughout their generations, for a perpetual covenant. <sup>17</sup> It is a sign between me and the children of Israel for ever: for in six days the LORD made heaven and earth, and on the seventh day he rested, and was refreshed.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Lev_19_17_to_18SE : Verse
	{
		public Lev_19_17_to_18SE() : base("Lev_19_17_to_18", 13) { }
		public override int BegId => 3299;
		public override int EndId => 3300;
		public override int BookId => 3;
		public override string VerseName => "Leviticus 19:17-18";
		public override string VerseNameAbrv => "Lev 19:17-18";
		public override string BCV => $"Lev/19/17/{BegId}"; //-18
		public override string VerseDescription => "Love thy neighbour as thyself";
		public override string Commentary => "See <sup>Mat 22:37-40</sup> where Yeshua quotes this verse and ties it with the <i>shema</i>; see also the <b>royal law</b> <sup>Jam 2:8</sup>";
		public override string ConcatenatedVerses => "<sup>17</sup> Thou shalt not hate thy brother in thine heart: thou shalt in any wise rebuke thy neighbor, and not suffer sin upon him. <sup>18</sup> Thou shalt not avenge, nor bear any grudge against the children of thy people, but thou shalt love thy neighbor as thyself: I am the LORD.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Lev_26_40_to_42SE : Verse
	{
		public Lev_26_40_to_42SE() : base("Lev_26_40_to_42", 14) { }
		public override int BegId => 3565;
		public override int EndId => 3567;
		public override int BookId => 3;
		public override string VerseName => "Leviticus 26:40-42";
		public override string VerseNameAbrv => "Lev 26:40-42";
		public override string BCV => $"Lev/26/40/{BegId}"; // -42
		public override string VerseDescription => "Confessing the iniquity of the Fathers";
		public override string Commentary => "A remedy in the Torah for re-contracting with YHVY; See the article Confessions_per_Lev_26_40_thru_42_The_Iniquity_of_the_Fathers.pdf (Article ID 215)";
		public override string ConcatenatedVerses => "<sup>40</sup> If they shall confess their iniquity, and the iniquity of their fathers, with their trespass which they trespassed against me, and that also they have walked contrary unto me; <sup>41</sup> And that I also have walked contrary unto them, and have brought them into the land of their enemies; if then their uncircumcised hearts be humbled, and they then accept of the punishment of their iniquity: <sup>42</sup> Then will I remember my covenant with Jacob, and also my covenant with Isaac, and also my covenant with Abraham will I remember; and I will remember the land.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Num_13_31_to_32SE : Verse
	{
		public Num_13_31_to_32SE() : base("Num_13_31_to_32", 15) { }
		public override int BegId => 4107;
		public override int EndId => 4108;
		public override int BookId => 4;
		public override string VerseName => "Numbers 13:31-32";
		public override string VerseNameAbrv => "Num 13:31-32";
		public override string BCV => $"Num/13/31/{BegId}"; //-32
		public override string VerseDescription => "The spies give an evil report";
		public override string Commentary => "This evil report is a pattern for the bill of divorce which happens centuries latter with the House of Israel";
		public override string ConcatenatedVerses => "<sup>31</sup> But the men that went up with him said, We be not able to go up against the people; for they are stronger than we. <sup>32</sup> And they brought up an evil report of the land which they had searched unto the children of Israel, saying, The land, through which we have gone to search it, is a land that eateth up the inhabitants thereof; and all the people that we saw in it are men of a great stature.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Deu_16_18_to_20SE : Verse
	{
		public Deu_16_18_to_20SE() : base("Deu_16_18_to_20", 16) { }
		public override int BegId => 5361;
		public override int EndId => 5363;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 16:18-20";
		public override string VerseNameAbrv => "Deu 16:18-20";
		public override string BCV => $"Deu/16/18/{BegId}"; //-20
		public override string VerseDescription => "Justice Justice";
		public override string Commentary => "Part of Due Process is to do justice justly";
		public override string ConcatenatedVerses => "<sup>18</sup> Judges and officers shalt thou make thee in all thy gates, which the LORD thy God giveth thee, throughout thy tribes: and they shall judge the people with just judgment. <sup>19</sup> Thou shalt not wrest judgment; thou shalt not respect persons, neither take a gift: for a gift doth blind the eyes of the wise, and pervert the words of the righteous. <sup>20</sup> That which is altogether just shalt thou follow, that thou mayest live, and inherit the land which the LORD thy God giveth thee.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_17_14_to_20SE : Verse
	{
		public Deu_17_14_to_20SE() : base("Deu_17_14_to_20", 17) { }
		public override int BegId => 5379;
		public override int EndId => 5385;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 17:14-20";
		public override string VerseNameAbrv => "Deu 17:14-20";
		public override string BCV => $"Deu/17/14/{BegId}"; //-20
		public override string VerseDescription => "Prophecy for the 1<sup>st</sup> Samuel ch. 8 type of King";
		public override string Commentary => "&quot;...you say, &quot;I will set over me a king like all the nations that are  around me&quot;";
		public override string ConcatenatedVerses => "<sup>14</sup> When thou art come unto the land which the LORD thy God giveth thee, and shalt possess it, and shalt dwell therein, and shalt say, I will set a king over me, like as all the nations that are about me; <sup>15</sup> Thou shalt in any wise set him king over thee, whom the LORD thy God shall choose: one from among thy brethren shalt thou set king over thee: thou mayest not set a stranger over thee, which is not thy brother. <sup>16</sup> But he shall not multiply horses to himself, nor cause the people to return to Egypt, to the end that he should multiply horses: forasmuch as the LORD hath said unto you, Ye shall henceforth return no more that way. <sup>17</sup> Neither shall he multiply wives to himself, that his heart turn not away: neither shall he greatly multiply to himself silver and gold. <sup>18</sup> And it shall be, when he sitteth upon the throne of his kingdom, that he shall write him a copy of this law in a book out of that which is before the priests the Levites: <sup>19</sup> And it shall be with him, and he shall read therein all the days of his life: that he may learn to fear the LORD his God, to keep all the words of this law and these statutes, to do them: <sup>20</sup> That his heart be not lifted up above his brethren, and that he turn not aside from the commandment, to the right hand, or to the left: to the end that he may prolong his days in his kingdom, he, and his children, in the midst of Israel.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Deu_17_18_to_20SE : Verse
	{
		public Deu_17_18_to_20SE() : base("Deu_17_18_to_20", 18) { }
		public override int BegId => 5383;
		public override int EndId => 5385;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 17:18-20";
		public override string VerseNameAbrv => "Deu 17:18-20";
		public override string BCV => $"Deu/17/18/{BegId}"; //-20
		public override string VerseDescription => "The King (The Sovereign) shall write a copy of the Torah";
		public override string Commentary => "&quot;...<sup>18</sup> he shall write him a copy of this law&quot; (see also <sup>Jos 8:32</sup>)...<sup>20</sup> &quot;That his heart be not lifted up above his brethren...&quot;";
		public override string ConcatenatedVerses => "<sup>18</sup> And it shall be, when he sitteth upon the throne of his kingdom, that he shall write him a copy of this law in a book out of that which is before the priests the Levites: <sup>19</sup> And it shall be with him, and he shall read therein all the days of his life: that he may learn to fear the LORD his God, to keep all the words of this law and these statutes, to do them: <sup>20</sup> That his heart be not lifted up above his brethren, and that he turn not aside from the commandment, to the right hand, or to the left: to the end that he may prolong his days in his kingdom, he, and his children, in the midst of Israel.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_18_15_to_19SE : Verse
	{
		public Deu_18_15_to_19SE() : base("Deu_18_15_to_19", 19) { }
		public override int BegId => 5400;
		public override int EndId => 5404;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 18:15-19";
		public override string VerseNameAbrv => "Deu 18:15-19";
		public override string BCV => $"Deu/18/15/{BegId}"; //-19
		public override string VerseDescription => "THE Prophet sent who is like God and Moses";
		public override string Commentary => "Regardless of who <i><b>Ha</b>Navi</i> is, verses 15 and 18 could be interpreted as someone who is like God and like man";
		public override string ConcatenatedVerses => "<sup>15</sup> The LORD thy God will raise up unto thee a Prophet from the midst of thee, of thy brethren, like unto me; unto him ye shall hearken; <sup>16</sup> According to all that thou desiredst of the LORD thy God in Horeb in the day of the assembly, saying, Let me not hear again the voice of the LORD my God, neither let me see this great fire any more, that I die not. <sup>17</sup> And the LORD said unto me, They have well spoken that which they have spoken. <sup>18</sup> I will raise them up a Prophet from among their brethren, like unto thee, and will put my words in his mouth; and he shall speak unto them all that I shall command him. <sup>19</sup> And it shall come to pass, that whosoever will not hearken unto my words which he shall speak in my name, I will require it of him.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_18_20SE : Verse
	{
		public Deu_18_20SE() : base("Deu_18_20", 20) { }
		public override int BegId => 5405;
		public override int EndId => 5405;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 18:20";
		public override string VerseNameAbrv => "Deu 18:20";
		public override string BCV => $"Deu/18/20/{BegId}";
		public override string VerseDescription => "The false prophet";
		public override string Commentary => "The &quot;Greek Jesus&quot; as described by antinomian Christianity is a false prophet because he &quot;did a way with the law&quot;  see also <sup>Deu 13:1-11</sup>";
		public override string ConcatenatedVerses => "<sup>20</sup> But the prophet, which shall presume to speak a word in my name, which I have not commanded him to speak, or that shall speak in the name of other gods, even that prophet shall die.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_19_15SE : Verse
	{
		public Deu_19_15SE() : base("Deu_19_15", 21) { }
		public override int BegId => 5422;
		public override int EndId => 5422;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 19:15";
		public override string VerseNameAbrv => "Deu 19:15";
		public override string BCV => $"Deu/19/15/{BegId}";
		public override string VerseDescription => "Truth as defined by Scripture";
		public override string Commentary => "&quot;...at the mouth of two witnesses, or at the mouth of three witnesses, shall the matter be established.&quot;  See also <sup>Deu 17:6</sup>, <sup>Num 35:30</sup>, <sup>Mat 18:16</sup>, <sup>Joh 8:17</sup>, <sup>2Co 13:1</sup>, <sup>1Ti 5:19</sup>, <sup>Heb 10:28</sup>";
		public override string ConcatenatedVerses => "<sup>15</sup> One witness shall not rise up against a man for any iniquity, or for any sin, in any sin that he sinneth: at the mouth of two witnesses, or at the mouth of three witnesses, shall the matter be established.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_19_16_to_21SE : Verse
	{
		public Deu_19_16_to_21SE() : base("Deu_19_16_to_21", 22) { }
		public override int BegId => 5423;
		public override int EndId => 5428;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 19:16-21";
		public override string VerseNameAbrv => "Deu 19:16-21";
		public override string BCV => $"Deu/19/16/{BegId}"; //-21
		public override string VerseDescription => "false witness and eye for an eye, tooth for tooth";
		public override string Commentary => "Regarding truth, scriptures is far more interested in its application to conflict resolution and not about hypothetical and philosophical / theological dissertations (see SCOTUS decision in <b>Ashwander vs TVA</b>). The context of the definition of truth (Deu 19:15).  See Exo 20:16";
		public override string ConcatenatedVerses => "<sup>16</sup> If a false witness rise up against any man to testify against him that which is wrong; <sup>17</sup> Then both the men, between whom the controversy is, shall stand before the LORD, before the priests and the judges, which shall be in those days; <sup>18</sup> And the judges shall make diligent inquisition: and, behold, if the witness be a false witness, and hath testified falsely against his brother; <sup>19</sup> Then shall ye do unto him, as he had thought to have done unto his brother: so shalt thou put the evil away from among you. <sup>20</sup> And those which remain shall hear, and fear, and shall henceforth commit no more any such evil among you. <sup>21</sup> And thine eye shall not pity; but life shall go for life, eye for eye, tooth for tooth, hand for hand, foot for foot.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Deu_24_1_to_4SE : Verse
	{
		public Deu_24_1_to_4SE() : base("Deu_24_1_to_4", 23) { }
		public override int BegId => 5527;
		public override int EndId => 5530;
		public override int BookId => 5;
		public override string VerseName => "Deuteronomy 24:1-4";
		public override string VerseNameAbrv => "Deu 24:1-4";
		public override string BCV => $"Deu/24/1/{BegId}"; //-4
		public override string VerseDescription => "Bill of Divorce";
		public override string Commentary => "Since this list is heavily geared towards <b>The House of Israel</b> and the fact that she was given a <b>Bill of Divorce</b>, it seemed prudent to include these relevant verses.  RSTNE: &quot;Only with the death of the husband can she remarry, which is why Yahshua died to release the bride back to the Father&quot;<sup>footnote 611<sup>";
		public override string ConcatenatedVerses => "<sup>1</sup> When a man hath taken a wife, and married her, and it come to pass that she find no favor in his eyes, because he hath found some uncleanness in her: then let him write her a bill of divorcement, and give it in her hand, and send her out of his house. <sup>2</sup> And when she is departed out of his house, she may go and be another man's wife. <sup>3</sup> And if the latter husband hate her, and write her a bill of divorcement, and giveth it in her hand, and sendeth her out of his house; or if the latter husband die, which took her to be his wife; <sup>4</sup> Her former husband, which sent her away, may not take her again to be his wife, after that she is defiled; for that is abomination before the LORD: and thou shalt not cause the land to sin, which the LORD thy God giveth thee for an inheritance.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Psa_98_3SE : Verse
	{
		public Psa_98_3SE() : base("Psa_98_3", 24) { }
		public override int BegId => 15494;
		public override int EndId => 15494;
		public override int BookId => 19;
		public override string VerseName => "Psalms 98:3";
		public override string VerseNameAbrv => "Psa 98:3";
		public override string BCV => $"Psa/98/3/{BegId}";
		public override string VerseDescription => "Powerful words jam packed in one verse";
		public override string Commentary => "<b>House of Israel</b> <i>scattered to the</i> ends of the earth, Standalone Aleph Tav <span class='at-red'>&#1488&#1461&#1514</span> next to <b>Salvation</b> from Elohim.  <br />Three verses down, Psa 98:6, it says to make a joyful noise to <span class='hebrew'>יהוה</span> <sup><b>Yehovah</b></sup>, <span class='hebrew'><span class='nrl'>הַ</span>מֶּלֶךְ</span> <sup><b>the King</b></sup>.";
		public override string ConcatenatedVerses => "<sup>3</sup> He hath remembered his mercy and his truth toward the house of Israel: all the ends of the earth have seen the salvation of our God.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Psa_122_1_to_9SE : Verse
	{
		public Psa_122_1_to_9SE() : base("Psa_122_1_to_9", 25) { }
		public override int BegId => 16091;
		public override int EndId => 16099;
		public override int BookId => 19;
		public override string VerseName => "Psalms 122:1-9";
		public override string VerseNameAbrv => "Psa 122:1-9";
		public override string BCV => $"Psa/122/1/{BegId}"; //-9

		public override string VerseDescription => "More on the covenant of ";
		public override string Commentary => "See the article <u>Pray-for-the-peace-of-Jerusalem-Psa-122.pdf</u>";
		public override string ConcatenatedVerses => "<sup>1</sup> I was glad when they said unto me, Let us go into the house of the LORD. <sup>2</sup> Our feet shall stand within thy gates, O Jerusalem. <sup>3</sup> Jerusalem is builded as a city that is compact together: <sup>4</sup> Whither the tribes go up, the tribes of the LORD, unto the testimony of Israel, to give thanks unto the name of the LORD. <sup>5</sup> For there are set thrones of judgment, the thrones of the house of David. <sup>6</sup> Pray for the peace of Jerusalem: they shall prosper that love thee. <sup>7</sup> Peace be within thy walls, and prosperity within thy palaces. <sup>8</sup> For my brethren and companions' sakes, I will now say, Peace be within thee. <sup>9</sup> Because of the house of the LORD our God I will seek thy good.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_1_17_to_18SE : Verse
	{
		public Isa_1_17_to_18SE() : base("Isa_1_17_to_18", 26) { }
		public override int BegId => 17672;
		public override int EndId => 17673;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 1:17-18";
		public override string VerseNameAbrv => "Isa 1:17-18";
		public override string BCV => $"Isa/1/17/{BegId}"; //-18
		public override string VerseDescription => "YHVH is a reasonable Elohim";
		public override string Commentary => "To reason with Elohim is implies that an offer is being made by Elohim to Israel. The context of is pure religion see <sup>Isa 1:17</sup> and <sup>Jam 1:27</sup>";
		public override string ConcatenatedVerses => "<sup>17</sup> Learn to do well; seek judgment, relieve the oppressed, judge the fatherless, plead for the widow. <sup>18</sup> Come now, and let us reason together, saith the LORD: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_2_3_to_4SE : Verse
	{
		public Isa_2_3_to_4SE() : base("Isa_2_3_to_4", 27) { }
		public override int BegId => 17689;
		public override int EndId => 17690;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 2:3-4";
		public override string VerseNameAbrv => "Isa 2:3-4";
		public override string BCV => $"Isa/2/3/{BegId}"; //-4
		public override string VerseDescription => "Judgment of the Nations, swords beat into plowhsares";
		public override string Commentary => "See the article <u>Prince-of-Peace-Sar-Shalom.doc</u>";
		public override string ConcatenatedVerses => "<sup>3</sup> And many people shall go and say, Come ye, and let us go up to the mountain of the LORD, to the house of the God of Jacob; and he will teach us of his ways, and we will walk in his paths: for out of Zion shall go forth the law, and the word of the LORD from Jerusalem. <sup>4</sup> And he shall judge among the nations, and shall rebuke many people: and they shall beat their swords into plowshares, and their spears into pruninghooks: nation shall not lift up sword against nation, neither shall they learn war any more.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_9_6SE : Verse
	{
		public Isa_9_6SE() : base("Isa_9_6", 28) { }
		public override int BegId => 17836;
		public override int EndId => 17836;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 9:6";
		public override string VerseNameAbrv => "Isa 9:6";
		public override string BCV => $"Isa/9/6/{BegId}";
		public override string VerseDescription => "Prince of Peace";
		public override string Commentary => "For there to be a Prince of Peace <i>Sar Shalom</i>, it seems there would have to be a Peace Covenant/Contract";
		public override string ConcatenatedVerses => "<sup>6</sup> For unto us a child is born, unto us a son is given: and the government shall be upon his shoulder: and his name shall be called Wonderful, Counsellor, The mighty God, The everlasting Father, The Prince of Peace.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_11_11_to_13SE : Verse
	{
		public Isa_11_11_to_13SE() : base("Isa_11_11_to_13", 29) { }
		public override int BegId => 17896;
		public override int EndId => 17898;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 11:11-13";
		public override string VerseNameAbrv => "Isa 11:11-13";
		public override string BCV => $"Isa/11/11/{BegId}"; //-13
		public override string VerseDescription => "Ephraim and Judah bury the hatchet";
		public override string Commentary => "...&quot;Ephraim shall not envy Judah, and Judah shall not vex Ephraim&quot; <sup>Isa 11:13</sup>";
		public override string ConcatenatedVerses => "<sup>11</sup> And it shall come to pass in that day, that the Lord shall set his hand again the second time to recover the remnant of his people, which shall be left, from Assyria, and from Egypt, and from Pathros, and from Cush, and from Elam, and from Shinar, and from Hamath, and from the islands of the sea. <sup>12</sup> And he shall set up an ensign for the nations, and shall assemble the outcasts of Israel, and gather together the dispersed of Judah from the four corners of the earth. <sup>13</sup> The envy also of Ephraim shall depart, and the adversaries of Judah shall be cut off: Ephraim shall not envy Judah, and Judah shall not vex Ephraim.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Isa_53_5_to_6SE : Verse
	{
		public Isa_53_5_to_6SE() : base("Isa_53_5_to_6", 30) { }
		public override int BegId => 18717;
		public override int EndId => 18718;
		public override int BookId => 23;
		public override string VerseName => "Isaiah 53:5-6";
		public override string VerseNameAbrv => "Isa 53:5-6";
		public override string BCV => $"Isa/53/5/{BegId}"; //-6
		public override string VerseDescription => "The suffering servant";
		public override string Commentary => "What can I say but Wow! You just have to read the whole chapter.  Also notice a very powerful Standalone <span class='text-danger'>Aleph Tav</span> in <sup>Isa 53:6</sup>.  There is all kinds of legal nuances going on in this chapter but I want to focus in on <sup>Isa 53:5</sup> where this servant\'s suffering results in <b>peace</b>.  Who is it that needs a covenant of Peace but <b>the Lost Sheep of the House of Israel</b> who was given a <b>Bill of Divorce</b>.";
		public override string ConcatenatedVerses => "<sup>5</sup> But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes we are healed. <sup>6</sup> All we like sheep have gone astray; we have turned every one to his own way; and the LORD hath laid on him the iniquity of us all.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Jer_3_6_to_12SE : Verse
	{
		public Jer_3_6_to_12SE() : base("Jer_3_6_to_12", 31) { }
		public override int BegId => 19009;
		public override int EndId => 19015;
		public override int BookId => 24;
		public override string VerseName => "Jeremiah 3:6-12";
		public override string VerseNameAbrv => "Jer 3:6-12";
		public override string BCV => $"Jer/3/6/{BegId}"; //-12
		public override string VerseDescription => "Bill of Divorce";
		public override string Commentary => "backsliding Israel committed adultery, put away, and given a bill of divorce";
		public override string ConcatenatedVerses => "<sup>6</sup> The LORD said also unto me in the days of Josiah the king, Hast thou seen that which backsliding Israel hath done? she is gone up upon every high mountain and under every green tree, and there hath played the harlot. <sup>7</sup> And I said after she had done all these things, Turn thou unto me. But she returned not. And her treacherous sister Judah saw it. <sup>8</sup> And I saw, when for all the causes whereby backsliding Israel committed adultery I had put her away, and given her a bill of divorce; yet her treacherous sister Judah feared not, but went and played the harlot also. <sup>9</sup> And it came to pass through the lightness of her whoredom, that she defiled the land, and committed adultery with stones and with stocks. <sup>10</sup> And yet for all this her treacherous sister Judah hath not turned unto me with her whole heart, but feignedly, saith the LORD. <sup>11</sup> And the LORD said unto me, The backsliding Israel hath justified herself more than treacherous Judah. <sup>12</sup> Go and proclaim these words toward the north, and say, Return, thou backsliding Israel, saith the LORD; and I will not cause mine anger to fall upon you: for I am merciful, saith the LORD, and I will not keep anger for ever.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Jer_31_31_to_34SE : Verse
	{
		public Jer_31_31_to_34SE() : base("Jer_31_31_to_34", 32) { }
		public override int BegId => 19723;
		public override int EndId => 19726;
		public override int BookId => 24;
		public override string VerseName => "Jeremiah 31:31-34";
		public override string VerseNameAbrv => "Jer 31:31-34";
		public override string BCV => $"Jer/31/31/{BegId}"; //-34
		public override string VerseDescription => "The renewed covenant is to both houses";
		public override string Commentary => "Another powerful two house set of verses";
		public override string ConcatenatedVerses => "<sup>31</sup> Behold, the days come, saith the LORD, that I will make a new covenant with the house of Israel, and with the house of Judah: <sup>32</sup> Not according to the covenant that I made with their fathers in the day that I took them by the hand to bring them out of the land of Egypt; which my covenant they brake, although I was an husband unto them, saith the LORD: <sup>33</sup> But this shall be the covenant that I will make with the house of Israel; After those days, saith the LORD, I will put my law in their inward parts, and write it in their hearts; and will be their God, and they shall be my people. <sup>34</sup> And they shall teach no more every man his neighbour, and every man his brother, saying, Know the LORD: for they shall all know me, from the least of them unto the greatest of them, saith the LORD: for I will forgive their iniquity, and I will remember their sin no more.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Eze_36_26_to_27SE : Verse
	{
		public Eze_36_26_to_27SE() : base("Eze_36_26_to_27", 33) { }
		public override int BegId => 21386;
		public override int EndId => 21387;
		public override int BookId => 26;
		public override string VerseName => "Ezekiel 36:26-27";
		public override string VerseNameAbrv => "Eze 36:26-27";
		public override string BCV => $"Eze/36/26/{BegId}"; //-27
		public override string VerseDescription => "New Heart, New Spirit";
		public override string Commentary => "What an awesome spiritual upgrade!  By doing so, we will walk in his statutes and judgments.  See the standalone Aleph Tav in verse 37 between cause and my statutes ";
		public override string ConcatenatedVerses => "<sup>26</sup> A new heart also will I give you, and a new spirit will I put within you: and I will take away the stony heart out of your flesh, and I will give you an heart of flesh. <sup>27</sup> And I will put my spirit within you, and cause you to walk in my statutes, and ye shall keep my judgments, and do them.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Eze_37_15_to_17SE : Verse
	{
		public Eze_37_15_to_17SE() : base("Eze_37_15_to_17", 34) { }
		public override int BegId => 21413;
		public override int EndId => 21415;
		public override int BookId => 26;
		public override string VerseName => "Ezekiel 37:15-17";
		public override string VerseNameAbrv => "Eze 37:15-17";
		public override string BCV => $"Eze/37/15/{BegId}"; //-17
		public override string VerseDescription => "The two sticks of Judah and Ephraim joined together in Elohim's hand";
		public override string Commentary => "Another powerful two house set of verses";
		public override string ConcatenatedVerses => "<sup>15</sup> The word of the LORD came again unto me, saying, <sup>16</sup> Moreover, thou son of man, take thee one stick, and write upon it, For Judah, and for the children of Israel his companions: then take another stick, and write upon it, For Joseph, the stick of Ephraim and for all the house of Israel his companions: <sup>17</sup> And join them one to another into one stick; and they shall become one in thine hand.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Eze_37_26SE : Verse
	{
		public Eze_37_26SE() : base("Eze_37_26", 35) { }
		public override int BegId => 21424;
		public override int EndId => 21424;
		public override int BookId => 26;
		public override string VerseName => "Ezekiel 37:26";
		public override string VerseNameAbrv => "Eze 37:26";
		public override string BCV => $"Eze/37/26/{BegId}";
		public override string VerseDescription => "The covenant of peace";
		public override string Commentary => "A covenant is a special form of contract, but a contract nonetheless therefore you need to view this from the perspective of law, see also <sup>Isa 11:13-14</sup>";
		public override string ConcatenatedVerses => "<sup>26</sup> Moreover I will make a covenant of peace with them; it shall be an everlasting covenant with them: and I will place them, and multiply them, and will set my sanctuary in the midst of them for evermore.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Hos_1_1_to_11SE : Verse
	{
		public Hos_1_1_to_11SE() : base("Hos_1_1_to_11", 36) { }
		public override int BegId => 22096;
		public override int EndId => 22106;
		public override int BookId => 28;
		public override string VerseName => "Hosea 1:1-11";
		public override string VerseNameAbrv => "Hos 1:1-11";
		public override string BCV => $"Hos/1/1/{BegId}"; //-11
		public override string VerseDescription => "The Bill of Divorce given to the House of Israel / &apos;Ephraim&apos;";
		public override string Commentary => "Adonai has had enough as Ephraim has refused to take to heart the warnings given to her so the Bill of Divorce is her judgment and sentence.";
		public override string ConcatenatedVerses => "<sup>1</sup> The word of the LORD that came unto Hosea, the son of Beeri, in the days of Uzziah, Jotham, Ahaz, and Hezekiah, kings of Judah, and in the days of Jeroboam the son of Joash, king of Israel. <sup>2</sup> The beginning of the word of the LORD by Hosea. And the LORD said to Hosea, Go, take unto thee a wife of whoredoms and children of whoredoms: for the land hath committed great whoredom, departing from the LORD. <sup>3</sup> So he went and took Gomer the daughter of Diblaim; which conceived, and bare him a son. <sup>4</sup> And the LORD said unto him, Call his name Jezreel; for yet a little while, and I will avenge the blood of Jezreel upon the house of Jehu, and will cause to cease the kingdom of the house of Israel. <sup>5</sup> And it shall come to pass at that day, that I will break the bow of Israel, in the valley of Jezreel. <sup>6</sup> And she conceived again, and bare a daughter. And God said unto him, Call her name Loruhamah: for I will no more have mercy upon the house of Israel; but I will utterly take them away. <sup>7</sup> But I will have mercy upon the house of Judah, and will save them by the LORD their God, and will not save them by bow, nor by sword, nor by battle, by horses, nor by horsemen. <sup>8</sup> Now when she had weaned Loruhamah, she conceived, and bare a son. <sup>9</sup> Then said God, Call his name Loammi: for ye are not my people, and I will not be your God. <sup>10</sup> Yet the number of the children of Israel shall be as the sand of the sea, which cannot be measured nor numbered; and it shall come to pass, that in the place where it was said unto them, Ye are not my people, there it shall be said unto them, Ye are the sons of the living God. <sup>11</sup> Then shall the children of Judah and the children of Israel be gathered together, and appoint themselves one head, and they shall come up out of the land: for great shall be the day of Jezreel.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Hos_4_6SE : Verse
	{
		public Hos_4_6SE() : base("Hos_4_6", 37) { }
		public override int BegId => 22140;
		public override int EndId => 22140;
		public override int BookId => 28;
		public override string VerseName => "Hosea 4:6";
		public override string VerseNameAbrv => "Hos 4:6";
		public override string BCV => $"Hos/4/6/{BegId}";
		public override string VerseDescription => "&apos;My people are destroyed for lack of knowledge...&apos;";
		public override string Commentary => "An oft quoted verse but only the first part is quoted not the rest.  The context of Hosea in the first chapter which describes the House of Israel getting the Bill of Divorce";
		public override string ConcatenatedVerses => "<sup>6</sup> My people are destroyed for lack of knowledge: because thou hast rejected knowledge, I will also reject thee, that thou shalt be no priest to me: seeing thou hast forgotten the law of thy God, I will also forget thy children.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Mal_4_4_to_6SE : Verse
	{
		public Mal_4_4_to_6SE() : base("Mal_4_4_to_6", 38) { }
		public override int BegId => 23143;
		public override int EndId => 23145;
		public override int BookId => 39;
		public override string VerseName => "Malachi 4:4-6";
		public override string VerseNameAbrv => "Mal 4:4-6";
		public override string BCV => $"Mal/4/4/{BegId}"; //-6
		public override string VerseDescription => "Shomer the Law of Moses, Elijah the prophet, hearts turned";
		public override string Commentary => "The 400 year gap of scripture from the Old Testament to the New.  As there is a Standalone Aleph Tav in the verse of the English Old Testament, there is also one in the last sentence";
		public override string ConcatenatedVerses => "<sup>4</sup> Remember ye the law of Moses my servant, which I commanded unto him in Horeb for all Israel, with the statutes and judgments. <sup>5</sup> Behold, I will send you Elijah the prophet before the coming of the great and dreadful day of the LORD: <sup>6</sup> And he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_5_17_to_20SE : Verse
	{
		public Mat_5_17_to_20SE() : base("Mat_5_17_to_20", 39) { }
		public override int BegId => 23252;
		public override int EndId => 23255;
		public override int BookId => 40;
		public override string VerseName => "Matthew 5:17-20";
		public override string VerseNameAbrv => "Mat 5:17-20";
		public override string BCV => $"Mat/5/17/{BegId}"; //-20
		public override string VerseDescription => "The Sermon on the Mount: The Law and the Prophets";
		public override string Commentary => "These verses are found in the heart of the sermon on the mount where <i>Yeshua</i> is teaching the <b>Torah</b> and is at the heart of what <b>MHB</b> is all about.";
		public override string ConcatenatedVerses => "<sup>17</sup> Think not that I am come to destroy the law, or the prophets: I am not come to destroy, but to fulfil. <sup>18</sup> For verily I say unto you, Till heaven and earth pass, one jot or one tittle shall in no wise pass from the law, till all be fulfilled. <sup>19</sup> Whosoever therefore shall break one of these least commandments, and shall teach men so, he shall be called the least in the kingdom of heaven: but whosoever shall do and teach them, the same shall be called great in the kingdom of heaven. <sup>20</sup> For I say unto you, That except your righteousness shall exceed the righteousness of the scribes and Pharisees, ye shall in no case enter into the kingdom of heaven.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Mat_5_22_to_26SE : Verse
	{
		public Mat_5_22_to_26SE() : base("Mat_5_22_to_26", 40) { }
		public override int BegId => 23257;
		public override int EndId => 23261;
		public override int BookId => 40;
		public override string VerseName => "Matthew 5:22-26";
		public override string VerseNameAbrv => "Mat 5:22-26";
		public override string BCV => $"Mat/5/22/{BegId}"; //-26
		public override string VerseDescription => "One who has ought with your breather can not draw near with their <i>korban</i> offering";
		public override string Commentary => "This is an advanced teaching";
		public override string ConcatenatedVerses => "<sup>22</sup> But I say unto you, That whosoever is angry with his brother without a cause shall be in danger of the judgment: and whosoever shall say to his brother, Raca, shall be in danger of the council: but whosoever shall say, Thou fool, shall be in danger of hell fire. <sup>23</sup> Therefore if thou bring thy gift to the altar, and there rememberest that thy brother hath ought against thee; <sup>24</sup> Leave there thy gift before the altar, and go thy way; first be reconciled to thy brother, and then come and offer thy gift. <sup>25</sup> Agree with thine adversary quickly, whiles thou art in the way with him; lest at any time the adversary deliver thee to the judge, and the judge deliver thee to the officer, and thou be cast into prison. <sup>26</sup> Verily I say unto thee, Thou shalt by no means come out thence, till thou hast paid the uttermost farthing.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Mat_10_5_to_7SE : Verse
	{
		public Mat_10_5_to_7SE() : base("Mat_10_5_to_7", 41) { }
		public override int BegId => 23423;
		public override int EndId => 23425;
		public override int BookId => 40;
		public override string VerseName => "Matthew 10:5-7";
		public override string VerseNameAbrv => "Mat 10:5-7";
		public override string BCV => $"Mat/10/5/{BegId}"; //-7
		public override string VerseDescription => "Yeshua commands the &apos;sent forth ones&apos; <sup>G649 <i>apostello</i></sup>) with a message";
		public override string Commentary => "This begs the question, who are <b>The Lost Sheep of the House of Israel</b>? ";
		public override string ConcatenatedVerses => "<sup>5</sup> These twelve Jesus sent forth, and commanded them, saying, Go not into the way of the Gentiles, and into any city of the Samaritans enter ye not: <sup>6</sup> But go rather to the lost sheep of the house of Israel. <sup>7</sup> And as ye go, preach, saying, The kingdom of heaven is at hand.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_15_24SE : Verse
	{
		public Mat_15_24SE() : base("Mat_15_24", 42) { }
		public override int BegId => 23658;
		public override int EndId => 23658;
		public override int BookId => 40;
		public override string VerseName => "Matthew 15:24";
		public override string VerseNameAbrv => "Mat 15:24";
		public override string BCV => $"Mat/15/24/{BegId}";
		public override string VerseDescription => "The identity of who Yeshua was sent for is given";
		public override string Commentary => "...&apos;<span class='text-danger'>I am not sent but unto the <b>lost sheep of the house of Israel</b></span>&apos;.  Again, this begs the question, who are <b>The Lost Sheep of the House of Israel</b> and what is special about them?  More precisely what is special and unique about them from a legal status perspective?";
		public override string ConcatenatedVerses => "<sup>24</sup> But he answered and said, I am not sent but unto the lost sheep of the house of Israel.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_18_15_to_17SE : Verse
	{
		public Mat_18_15_to_17SE() : base("Mat_18_15_to_17", 43) { }
		public override int BegId => 23743;
		public override int EndId => 23745;
		public override int BookId => 40;
		public override string VerseName => "Matthew 18:15-17";
		public override string VerseNameAbrv => "Mat 18:15-17";
		public override string BCV => $"Mat/18/15/{BegId}"; //-17
		public override string VerseDescription => "The due process of in house conflict resolution";
		public override string Commentary => "Yeshua gives us the process for resolving conflicts who are a member of your congregation";
		public override string ConcatenatedVerses => "<sup>15</sup> Moreover if thy brother shall trespass against thee, go and tell him his fault between thee and him alone: if he shall hear thee, thou hast gained thy brother. <sup>16</sup> But if he will not hear thee, then take with thee one or two more, that in the mouth of two or three witnesses every word may be established. <sup>17</sup> And if he shall neglect to hear them, tell it unto the church: but if he neglect to hear the church, let him be unto thee as an heathen man and a publican.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_18_18_to_20SE : Verse
	{
		public Mat_18_18_to_20SE() : base("Mat_18_18_to_20", 44) { }
		public override int BegId => 23746;
		public override int EndId => 23748;
		public override int BookId => 40;
		public override string VerseName => "Matthew 18:18-20";
		public override string VerseNameAbrv => "Mat 18:18-20";
		public override string BCV => $"Mat/18/18/{BegId}"; //-20
		public override string VerseDescription => "Binding in heaven and earth";
		public override string Commentary => "This is a <b>&apos;400 level&apos;</b> advanced teaching describing &apos;vertical&apos; jurisdictions and authority.  It is about the dichotomy of the heavenly realm and the earthly realm, between private matters and public matters.  See <sup>Mat 16:19</sup>";
		public override string ConcatenatedVerses => "<sup>18</sup> Verily I say unto you, Whatsoever ye shall bind on earth shall be bound in heaven: and whatsoever ye shall loose on earth shall be loosed in heaven. <sup>19</sup> Again I say unto you, That if two of you shall agree on earth as touching any thing that they shall ask, it shall be done for them of my Father which is in heaven. <sup>20</sup> For where two or three are gathered together in my name, there am I in the midst of them.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Mat_22_37_to_40SE : Verse
	{
		public Mat_22_37_to_40SE() : base("Mat_22_37_to_40", 45) { }
		public override int BegId => 23910;
		public override int EndId => 23913;
		public override int BookId => 40;
		public override string VerseName => "Matthew 22:37-40";
		public override string VerseNameAbrv => "Mat 22:37-40";
		public override string BCV => $"Mat/22/37/{BegId}"; //-40
		public override string VerseDescription => "The two great commandments given";
		public override string Commentary => "How do you love the Messiah <sup>Joh 14:14</sup>, but to keep his commandments.  Yeshua gives us the two <b>great</b> commandments <sup>Lev 19:17-18</sup> and <sup>Deu 6:4-5</sup> and then says <span class='text-danger'>On these two commandments hang <b>all</b> the <b>law</b> and the <b>prophets</b></span>.  The same verbiage used in <sup>Mat 5:17</sup>";
		public override string ConcatenatedVerses => "<sup>37</sup> Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind. <sup>38</sup> This is the first and great commandment. <sup>39</sup> And the second is like unto it, Thou shalt love thy neighbour as thyself. <sup>40</sup> On these two commandments hang all the law and the prophets.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Joh_1_17SE : Verse
	{
		public Joh_1_17SE() : base("Joh_1_17", 46) { }
		public override int BegId => 26062;
		public override int EndId => 26062;
		public override int BookId => 43;
		public override string VerseName => "John 1:17";
		public override string VerseNameAbrv => "Joh 1:17";
		public override string BCV => $"Joh/1/17/{BegId}";
		public override string VerseDescription => "The law of Moses and the Grace of Yeshua?";
		public override string Commentary => "This <i>but</i> is <b>butting</b> in! The but is added, and if removed, as it should be, the Torah compliments the grace and truth of the Messiah, if left in then it casts these ideas to be opposites of each other.  Moshe-Leads-you-to-Meshiach-Num-10-13, article #786";
		public override string ConcatenatedVerses => "<sup>17</sup> For the law was given by Moses, but grace and truth came by Jesus Christ.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Joh_14_15SE : Verse
	{
		public Joh_14_15SE() : base("Joh_14_15", 47) { }
		public override int BegId => 26684;
		public override int EndId => 26684;
		public override int BookId => 43;
		public override string VerseName => "John 14:15";
		public override string VerseNameAbrv => "Joh 14:15";
		public override string BCV => $"Joh/14/15/{BegId}";
		public override string VerseDescription => "How to love Yeshua but to keep his commandments.";
		public override string Commentary => "So what are his commandments? ";
		public override string ConcatenatedVerses => "<sup>15</sup> If ye love me, keep my commandments.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Rom_1_1SE : Verse
	{
		public Rom_1_1SE() : base("Rom_1_1", 48) { }
		public override int BegId => 27932;
		public override int EndId => 27932;
		public override int BookId => 45;
		public override string VerseName => "Romans 1:1";
		public override string VerseNameAbrv => "Rom 1:1";
		public override string BCV => $"Rom/1/1/{BegId}";
		public override string VerseDescription => "Legal Status of Paul: Bond Servant of Yeshua Messiah";
		public override string Commentary => "Romans 1:1-6 is Paul\'s calling card from which he is declaring his status.  If one were to ask Paul \'<i>Quo Warranto</i>\' (by what authority), could he not claim Exodus 21:5-6?";
		public override string ConcatenatedVerses => "<sup>1</sup> Paul, a servant of Jesus Christ, called to be an apostle, separated unto the gospel of God,";
		public override bool HasExtraInfo => false;
	}
	private sealed class Co1_7_20_to_24SE : Verse
	{
		public Co1_7_20_to_24SE() : base("Co1_7_20_to_24", 49) { }
		public override int BegId => 28508;
		public override int EndId => 28512;
		public override int BookId => 46;
		public override string VerseName => "1 Corinthians 7:20-24";
		public override string VerseNameAbrv => "1Co 7:20-24";
		public override string BCV => $"1Co/7/20/{BegId}"; //-24
		public override string VerseDescription => "Freeman, Paid for a Price";
		public override string Commentary => "Marsing\'s maxim: The perceived paradox to become free you have to become a bond servant; see <sup>1Co 6:20<sup>";
		public override string ConcatenatedVerses => "<sup>20</sup> Let every man abide in the same calling wherein he was called. <sup>21</sup> Art thou called being a servant? care not for it: but if thou mayest be made free, use it rather. <sup>22</sup> For he that is called in the Lord, being a servant, is the Lord's freeman: likewise also he that is called, being free, is Christ's servant. <sup>23</sup> Ye are bought with a price; be not ye the servants of men. <sup>24</sup> Brethren, let every man, wherein he is called, therein abide with God.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Gal_3_28_to_29SE : Verse
	{
		public Gal_3_28_to_29SE() : base("Gal_3_28_to_29", 50) { }
		public override int BegId => 29131;
		public override int EndId => 29132;
		public override int BookId => 48;
		public override string VerseName => "Galatians 3:28-29";
		public override string VerseNameAbrv => "Gal 3:28-29";
		public override string BCV => $"Gal/3/28/{BegId}"; //-29
		public override string VerseDescription => "Seed of Abraham, heirs according to the promise";
		public override string Commentary => "What does Paul mean when he says there is no distinction between Jew or Greek and how does this comport with Yeshua who said <span class='text-danger'>I am not sent but unto the <b>lost sheep of the house of Israel</b></span>&apos; <sup>Mat 15:24</sup> see also <sup>Mat 10:6</sup>";
		public override string ConcatenatedVerses => "<sup>28</sup> There is neither Jew nor Greek, there is neither bond nor free, there is neither male nor female: for ye are all one in Christ Jesus. <sup>29</sup> And if ye be Christ's, then are ye Abraham's seed, and heirs according to the promise.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Eph_2_12_to_19SE : Verse
	{
		public Eph_2_12_to_19SE() : base("Eph_2_12_to_19", 51) { }
		public override int BegId => 29242;
		public override int EndId => 29249;
		public override int BookId => 49;
		public override string VerseName => "Ephesians 2:12-19";
		public override string VerseNameAbrv => "Eph 2:12-19";
		public override string BCV => $"Eph/2/12/{BegId}"; //-19
		public override string VerseDescription => "Middle Wall of Partition Broken Down";
		public override string Commentary => "To much to comment on, see the Extra Page";
		public override string ConcatenatedVerses => "<sup>12</sup> That at that time ye were without Christ, being aliens from the commonwealth of Israel, and strangers from the covenants of promise, having no hope, and without God in the world: <sup>13</sup> But now in Christ Jesus ye who sometimes were far off are made nigh by the blood of Christ. <sup>14</sup> For he is our peace, who hath made both one, and hath broken down the middle wall of partition between us; <sup>15</sup> Having abolished in his flesh the enmity, even the law of commandments contained in ordinances; for to make in himself of twain one new man, so making peace; <sup>16</sup> And that he might reconcile both unto God in one body by the cross, having slain the enmity thereby: <sup>17</sup> And came and preached peace to you which were afar off, and to them that were nigh. <sup>18</sup> For through him we both have access by one Spirit unto the Father. <sup>19</sup> Now therefore ye are no more strangers and foreigners, but fellowcitizens with the saints, and of the household of God;";
		public override bool HasExtraInfo => true;
	}
	private sealed class Col_2_14SE : Verse
	{
		public Col_2_14SE() : base("Col_2_14", 52) { }
		public override int BegId => 29509;
		public override int EndId => 29509;
		public override int BookId => 51;
		public override string VerseName => "Colossians 2:14";
		public override string VerseNameAbrv => "Col 2:14";
		public override string BCV => $"Col/2/14/{BegId}";
		public override string VerseDescription => "Handwriting of ordinances nailing it to his cross";
		public override string Commentary => "To much to comment on, see the Extra Page";
		public override string ConcatenatedVerses => "<sup>14</sup> Blotting out the handwriting of ordinances that was against us, which was contrary to us, and took it out of the way, nailing it to his cross;";
		public override bool HasExtraInfo => true;
	}
	private sealed class Ti1_1_4SE : Verse
	{
		public Ti1_1_4SE() : base("Ti1_1_4", 53) { }
		public override int BegId => 29701;
		public override int EndId => 29701;
		public override int BookId => 54;
		public override string VerseName => "1 Timothy 1:4";
		public override string VerseNameAbrv => "1Ti 1:4";
		public override string BCV => $"1Ti/1/4/{BegId}";
		public override string VerseDescription => "Word study of edifying";
		public override string Commentary => "This word is <i>oikonomia</i> (Strong\'s <sup>G3622</sup>) which is where we get the word <b>economy</b><br />For more, see Economy-of-God-G3622-oikonomia-G3623-oikonomos-dispensation-steward.doc and The-Economy-of-God.doc";
		public override string ConcatenatedVerses => "<sup>4</sup> Neither give heed to fables and endless genealogies, which minister questions, rather than godly edifying which is in faith: so do.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Ti2_2_15SE : Verse
	{
		public Ti2_2_15SE() : base("Ti2_2_15", 54) { }
		public override int BegId => 29843;
		public override int EndId => 29843;
		public override int BookId => 55;
		public override string VerseName => "2 Timothy 2:15";
		public override string VerseNameAbrv => "2Ti 2:15";
		public override string BCV => $"2Ti/2/15/{BegId}";
		public override string VerseDescription => "Study to show thyself approved";
		public override string Commentary => "Two levels of study";
		public override string ConcatenatedVerses => "<sup>15</sup> Study to shew thyself approved unto God, a workman that needeth not to be ashamed, rightly dividing the word of truth.";
		public override bool HasExtraInfo => true;
	}
	private sealed class Jam_1_27SE : Verse
	{
		public Jam_1_27SE() : base("Jam_1_27", 55) { }
		public override int BegId => 30294;
		public override int EndId => 30294;
		public override int BookId => 59;
		public override string VerseName => "James 1:27";
		public override string VerseNameAbrv => "Jam 1:27";
		public override string BCV => $"Jam/1/27/{BegId}";
		public override string VerseDescription => "Pure religion";
		public override string Commentary => "The definition for <b>religion</b> as defined in scripture is found n this verse";
		public override string ConcatenatedVerses => "<sup>27</sup> Pure religion and undefiled before God and the Father is this, To visit the fatherless and widows in their affliction, and to keep himself unspotted from the world.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Pe1_2_9_to_10SE : Verse
	{
		public Pe1_2_9_to_10SE() : base("Pe1_2_9_to_10", 56) { }
		public override int BegId => 30409;
		public override int EndId => 30410;
		public override int BookId => 60;
		public override string VerseName => "1 Peter 2:9-10";
		public override string VerseNameAbrv => "1Pe 2:9-10";
		public override string BCV => $"1Pe/2/9/{BegId}"; //-10
		public override string VerseDescription => "chosen generation, royal priesthood, holy nation (quote Hosea ch 1)";
		public override string Commentary => "Whose Peters audience but to none other than the Lost Sheep of the House of Israel who were <i>Lo Ami</i> Not my People and  <i>Lo Ruchmah</i> no mercy See Hos 1:6-10";
		public override string ConcatenatedVerses => "<sup>9</sup> But ye are a chosen generation, a royal priesthood, an holy nation, a peculiar people; that ye should shew forth the praises of him who hath called you out of darkness into his marvellous light; <sup>10</sup> Which in time past were not a people, but are now the people of God: which had not obtained mercy, but now have obtained mercy.";
		public override bool HasExtraInfo => false;
	}
	private sealed class Rev_21_24_to_27SE : Verse
	{
		public Rev_21_24_to_27SE() : base("Rev_21_24_to_27", 57) { }
		public override int BegId => 31078;
		public override int EndId => 31081;
		public override int BookId => 66;
		public override string VerseName => "Revelation 21:24-27";
		public override string VerseNameAbrv => "Rev 21:24-27";
		public override string BCV => $"Rev/21/24/{BegId}"; //-27
		public override string VerseDescription => "Israel will judge the nations";
		public override string Commentary => "The tribes of Israel, a Kingdom of priests <sup>Exo 19:6</sup>, will adjudicate any matter that they receive from the Non-Israelite nations. What is the role of a priest but to be an intercessor between the people (the nations) and Elohim.";
		public override string ConcatenatedVerses => "<sup>24</sup> And the nations of them which are saved shall walk in the light of it: and the kings of the earth do bring their glory and honour into it. <sup>25</sup> And the gates of it shall not be shut at all by day: for there shall be no night there. <sup>26</sup> And they shall bring the glory and honour of the nations into it. <sup>27</sup> And there shall in no wise enter into it any thing that defileth, neither whatsoever worketh abomination, or maketh a lie: but they which are written in the Lamb's book of life.";
		public override bool HasExtraInfo => false;
	}
	#endregion
}
// ignore Spelling: BCV