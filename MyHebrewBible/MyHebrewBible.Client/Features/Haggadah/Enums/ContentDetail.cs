using Ardalis.SmartEnum;
using MyHebrewBible.Client.Features.Haggadah;


namespace MyHebrewBible.Client.Features.Haggadah.Enums;

public abstract class ContentDetail : SmartEnum<ContentDetail>
{
	#region Id's
	private static class Id
	{
		internal const int FifthCup01 = 43;

		internal const int SixthCup01 = 44;
		internal const int SixthCup02 = 45;
		internal const int SixthCup03 = 46;
		internal const int SixthCup04 = 47;
		internal const int SixthCup05 = 48;
		internal const int SixthCup06 = 49;

		internal const int SeventhCup01 = 50;
		internal const int SeventhCup02 = 51;
		internal const int SeventhCup03 = 52;
		internal const int SeventhCup04 = 53;
		internal const int SeventhCup05 = 54;
		internal const int SeventhCup06 = 55;
		internal const int SeventhCup07 = 56;
		internal const int SeventhCup08 = 57;

		internal const int NextYear = 58;
	}
	#endregion


	#region  Declared Public Instances
	public static readonly ContentDetail FifthCup01 = new FifthCup01SE();

	public static readonly ContentDetail SixthCup01 = new SixthCup01SE();
	public static readonly ContentDetail SixthCup02 = new SixthCup02SE();
	public static readonly ContentDetail SixthCup03 = new SixthCup03SE();
	public static readonly ContentDetail SixthCup04 = new SixthCup04SE();
	public static readonly ContentDetail SixthCup05 = new SixthCup05SE();
	public static readonly ContentDetail SixthCup06 = new SixthCup06SE();

	public static readonly ContentDetail SeventhCup01 = new SeventhCup01SE();
	public static readonly ContentDetail SeventhCup02 = new SeventhCup02SE();
	public static readonly ContentDetail SeventhCup03 = new SeventhCup03SE();
	public static readonly ContentDetail SeventhCup04 = new SeventhCup04SE();
	public static readonly ContentDetail SeventhCup05 = new SeventhCup05SE();
	public static readonly ContentDetail SeventhCup06 = new SeventhCup06SE();
	public static readonly ContentDetail SeventhCup07 = new SeventhCup07SE();
	public static readonly ContentDetail SeventhCup08 = new SeventhCup08SE();

	public static readonly ContentDetail NextYear = new NextYearSE();

	#endregion


	private ContentDetail(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract int ParentId { get; }
	public abstract string EngBody { get; }
	public abstract string EspBody { get; }
	#endregion

	#region Private Instantiation



	private sealed class FifthCup01SE : ContentDetail
	{
		public FifthCup01SE() : base($"{nameof(Id.FifthCup01)}", Id.FifthCup01) { }
		public override int ParentId => Content.FifthCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-success fw-bold'>Leader:</span> 
				We renounce all false gods and idols, false holidays and worship only the one true God of Israel. 
			</p>

			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Galatians 5:22-23</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>22</sup>  
				...[and pursue the] fruits of the Spirit of God, which are love, joy, peace, forbearance, kindness, goodness, faithfulness, 
				<sup class='text-primary fw-bold'>23</sup>  
				gentleness and self-control. Against such things there is no law.
			</p>

			<p class='fs-5'>
				<span class='text-danger fw-bold'>All Shout</span> 
				<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
				<i class='fas fa-long-arrow-alt-right'></i>
				DRINK THE CUP <i class='text-danger fas fa-wine-glass-alt'></i>
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-success fw-bold'>Líder:</span> 
				Renunciamos a todos los dioses falsos e ídolos, fiestas falsas y adoramos solo al único Dios verdadero de Israel.
			</p>

			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Gálatas 5:22-23</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>22</sup>  
				...Deseamos vivir vidas apartadas para Él y perseguir los frutos del Espíritu de Dios, que son amor, gozo, paz, paciencia, bondad, benignidad, fidelidad, 
				<sup class='text-primary fw-bold'>23</sup>  
				mansedumbre y autocontrol. Contra tales cosas no hay ley.
			</p>
			
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Todos gritan</span> 
				<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
				<i class='fas fa-long-arrow-alt-right'></i>
				BEBEN LA COPA <i class='text-danger fas fa-wine-glass-alt'></i>
			</p>
			";
	}


	private sealed class SixthCup01SE : ContentDetail
	{
		public SixthCup01SE() : base($"{nameof(Id.SixthCup01)}", Id.SixthCup01) { }
		public override int ParentId => Content.SixthCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-success fw-bold'>Leader:</span> 
				We are reconciled to God. Let us also prepare ourselves to be reconciled to our brother Judah. 
			</p>

			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span>
			</p>
			
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Ezekiel 37:15-23</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>15</sup>  
				The word of Yehovah came again to me saying,
				<sup class='text-primary fw-bold'>16</sup>  
				“Now as for you, son of man, take for yourself one stick and write on it, ‘For Judah and for the sons of Israel, his companions’; 
				then take another stick and write on it, ‘For Joseph, the stick of Ephraim and all the house of Israel, his companions.’ 
				<sup class='text-primary fw-bold'>17</sup>  
				Then draw them together for yourself one to another into one stick, that they may become one in your hand. 
				<sup class='text-primary fw-bold'>18</sup>
				And when the sons of your people speak to you saying, ‘Will you not declare to us what you mean by these?’
				<sup class='text-primary fw-bold'>19</sup>
				say to them, ‘Thus says Master Yehovah, “Behold, I will take the stick of Joseph, which is in the hand of Ephraim, and the tribes of Israel, his companions; 
				and I will put them with it, with the stick of Judah, and make them one stick, and they will be one in My hand.”’ 
				<sup class='text-primary fw-bold'>20</sup>
				And the sticks on which you write will be in your hand before their eyes. 
				<sup class='text-primary fw-bold'>21</sup>
				And speak to them, ‘Thus says Master Yehovah, “Behold, I will take the sons of Israel from among the nations where they have gone, 
				and I will gather them from every side and bring them into their own land; 
				<sup class='text-primary fw-bold'>22</sup>
				and I will make them one nation in the land, on the mountains of Israel; and one king will be king for all of them; 
				and they will no longer be two nations and no longer be divided into two kingdoms. 
				<sup class='text-primary fw-bold'>23</sup>
				They also will no longer defile themselves with their idols or with their detestable things or with any of their transgressions; 
				but I will save them from all their places of habitation in which they have sinned, and I will cleanse them. And they will be My people, and I will be their God.
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-success fw-bold'>Líder:</span> 
				Renunciamos a todos los dioses falsos e ídolos, fiestas falsas y adoramos solo al único Dios verdadero de Israel.
			</p>

			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span>
			</p>
			
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Ezequiel 37:15-23</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>15</sup>  
				La palabra de Yahvé vino nuevamente a mí diciendo,  
				<sup class='text-primary fw-bold'>16</sup>  
				Ahora, hijo de hombre, toma para ti un palo y escribe en él, 'Para Judá y para los hijos de Israel, sus compañeros'; 
				luego toma otro palo y escribe en él, 'Para José, el palo de Efraím y toda la casa de Israel, sus compañeros.'
				<sup class='text-primary fw-bold'>17</sup>  
				Luego júntalos uno con otro en un solo palo, para que se conviertan en uno en tu mano.
				<sup class='text-primary fw-bold'>18</sup>
				Y cuando los hijos de tu pueblo te hablen diciendo, '¿No nos declararás qué quieres decir con esto?' 
				<sup class='text-primary fw-bold'>19</sup>
				diles, 'Así dice el Maestro Yahvé, He aquí, tomaré el palo de José, que está en la mano de Efraím, y las tribus de Israel, sus compañeros; 
				y los pondré con él, con el palo de Judá, y los haré un solo palo, y serán uno en Mi mano.' 
				<sup class='text-primary fw-bold'>20</sup>
				Y los palos en los que escribas estarán en tu mano ante sus ojos. 
				<sup class='text-primary fw-bold'>21</sup>
				Y habla con ellos, 'Así dice el Maestro Yahvé, He aquí, tomaré a los hijos de Israel de entre las naciones donde han ido, 
				y los reuniré de todos lados y los traeré a su propia tierra;
				<sup class='text-primary fw-bold'>22</sup>
				y los haré una nación en la tierra, en las montañas de Israel; y un rey será rey para todos ellos; 
				y ya no serán dos naciones ni estarán divididos en dos reinos. 
				<sup class='text-primary fw-bold'>23</sup>
				Tampoco se contaminarán más con sus ídolos ni con sus cosas detestables ni con ninguna de sus transgresiones; 
				pero los salvaré de todos sus lugares de habitación en los que han pecado, y los limpiaré. Y serán Mi pueblo, y Yo seré su Dios.
			</p>
			";
	}

	private sealed class SixthCup02SE : ContentDetail
	{
		public SixthCup02SE() : base($"{nameof(Id.SixthCup02)}", Id.SixthCup02) { }
		public override int ParentId => Content.SixthCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Isaiah 11:12, 16</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>12</sup>  
				“He will raise a signal for the nations and will assemble the banished of Israel,  and gather the dispersed of Judah from the four corners of the earth.  
				<sup class='text-primary fw-bold'>13</sup>
				The jealousy of Ephraim shall depart and those who harass Judah shall be cut off;  Ephraim shall not be jealous of Judah, and Judah shall not harass Ephraim.  
				<sup class='text-primary fw-bold'>16</sup>  
				And there will be a highway from Assyria for the remnant that remains of his people,  as there was for Israel when they came up from the land of Egypt.”
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Isaías 11:12-13, 16</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>12</sup>  
				Él levantará una señal para las naciones y reunirá a los desterrados de Israel, y juntará a los dispersos de Judá desde los cuatro rincones de la tierra. 
				<sup class='text-primary fw-bold'>13</sup>  
				Los celos de Efraím se apartarán y los que acosan a Judá serán cortados; Efraím no estará celoso de Judá, y Judá no acosará a Efraím.
				<sup class='text-primary fw-bold'>16</sup>  
				Y habrá un camino desde Asiria para el remanente que queda de su pueblo, como lo hubo para Israel cuando subieron de la tierra de Egipto.
			</p>
			";
	}

	private sealed class SixthCup03SE : ContentDetail
	{
		public SixthCup03SE() : base($"{nameof(Id.SixthCup03)}", Id.SixthCup03) { }
		public override int ParentId => Content.SixthCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremiah 50:4-5</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>4</sup>  
				“In those days and in that time, declares the LORD, the people of Israel and the people of Judah shall come together, weeping as they come, and they shall seek the LORD their God. 
				<sup class='text-primary fw-bold'>5</sup>
				They shall ask the way to Tsiyon [Zion], their faces toward it,  
				'Come and let us join ourselves to Yehovah, in an everlasting Covenant, never to be forgotten.'
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremías 50:4-5</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>4</sup>  
				En esos días y en ese tiempo, declara el SEÑOR, los pueblos de Israel y los pueblos de Judá vendrán juntos, llorando mientras vienen, y buscarán al SEÑOR su Dios. 
				Preguntarán el camino a Tsiyon [Sión], con sus rostros hacia allá, 
				<sup class='text-primary fw-bold'>5</sup>
				'Vengan y unámonos a YHWH, en un Pacto eterno, nunca olvidado.'
			</p>
			";
	}

	private sealed class SixthCup04SE : ContentDetail
	{
		public SixthCup04SE() : base($"{nameof(Id.SixthCup04)}", Id.SixthCup04) { }
		public override int ParentId => Content.SixthCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Zechariah 10:6</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>6</sup>  
				“I will strengthen the house of Judah, and I will save the house of Joseph. 
				I will bring them back because I have compassion on them, and they shall be as though I had not rejected them, 
				for I am the LORD their God and I will answer them.
			</p>
			<p class='fs-5 text-black-50 ms-3'>Read Zechariah 12:7-10</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Zacarías 10:6</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>6</sup>  
				Fortificaré la casa de Judá, y salvaré la casa de José. 
				Los traeré de vuelta porque tengo compasión de ellos, y serán como si no los hubiera rechazado, 
				porque Yo soy el SEÑOR su Dios y les responderé.
			</p>
			<p class='fs-5 text-black-50 ms-3'>Lee Zacarías 12:7-10</p>
			";
	}

	private sealed class SixthCup05SE : ContentDetail
	{
		public SixthCup05SE() : base($"{nameof(Id.SixthCup05)}", Id.SixthCup05) { }
		public override int ParentId => Content.SixthCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span>
			</p>
			<p class='fs-5'>
			It is not enough to be reconciled to our God, for our destiny in not heaven,  but a return to our covenant land. 
			The reunion with Judah will most likely be in the Land under the authority of the King. 
			This is when the One New Man is finally manifest. It is another way of saying the One Stick in the Father’s hand is the One New Man mentioned by Paul in <u>Ephesians 2:15</u>. 
			The One New Man is the Israel of Yehovah! HalelluYah!.
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span>
			</p>
			<p class='fs-5'>
				No basta con reconciliarnos con nuestro Dios, porque nuestro destino no es el cielo, sino un regreso a nuestra tierra del pacto. 
				La reunión con Judá probablemente será en la Tierra bajo la autoridad del Rey. 
				Aquí es cuando el Hombre Nuevo finalmente se manifiesta. Es otra forma de decir que el Palo Único en la mano del Padre es el Hombre Nuevo mencionado por Pablo en Efesios 2:15.
				¡El Hombre Nuevo es el Israel de Yahvé! ¡HalleluYah!
			</p>
			";
	}

	private sealed class SixthCup06SE : ContentDetail
	{
		public SixthCup06SE() : base($"{nameof(Id.SixthCup06)}", Id.SixthCup06) { }
		public override int ParentId => Content.SixthCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>All:</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Revelation 5:9-10</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>9</sup>  
				And they sang a new song, saying, 'You are worthy to take the scroll, and to open its seals, 
				because You were slain, and have redeemed us to Elohim by Your blood out of every tribe and tongue and people and nation, 
				<sup class='text-primary fw-bold'>10</sup>
				and made us sovereigns and priests to our Elohim, and we shall reign upon the Earth.
			</p>

			<p class='fs-5'>
				<span class='text-danger fw-bold'>All Shout</span> 
				<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
				<i class='fas fa-long-arrow-alt-right'></i>
				DRINK THE CUP <i class='text-danger fas fa-wine-glass-alt'></i>
			</p>

			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span>
			</p>

			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Apocalipsis 5:9-10</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>9</sup>  
				Y cantaron un cántico nuevo, diciendo, 'Tú eres digno de tomar el rollo y abrir sus sellos, 
				porque fuiste inmolado, y nos has redimido para Elohim por Tu sangre de cada tribu y lengua y pueblo y nación, 
				<sup class='text-primary fw-bold'>10</sup>
				y nos hiciste soberanos y sacerdotes para nuestro Elohim, y reinaremos sobre la Tierra.'
			</p>

			<p class='fs-5'>
				<span class='text-danger fw-bold'>Todos gritan</span> 
				<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
				<i class='fas fa-long-arrow-alt-right'></i>
				BEBEN LA COPA <i class='text-danger fas fa-wine-glass-alt'></i>
			</p>
			";
	}


	private sealed class SeventhCup01SE : ContentDetail
	{
		public SeventhCup01SE() : base($"{nameof(Id.SeventhCup01)}", Id.SeventhCup01) { }
		public override int ParentId => Content.SeventhCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-success fw-bold'>Leader:</span> 
			</p>
			
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremiah 3:18</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>18</sup>  
				In those days the house of Judah shall join the house of Israel, 
				and together they shall come from the land of the north to the land that I gave your fathers for a heritage
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-success fw-bold'>Líder:</span> 
			</p>
			
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremías 3:18</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>18</sup>  
				In those days the house of Judah shall join the house of Israel, 
				and together they shall come from the land of the north to the land that I gave your fathers for a heritage
			</p>
			";
	}

	private sealed class SeventhCup02SE : ContentDetail
	{
		public SeventhCup02SE() : base($"{nameof(Id.SeventhCup02)}", Id.SeventhCup02) { }
		public override int ParentId => Content.SeventhCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader: 1</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremiah 50:19</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>19</sup>  
				And I will return Israel back to his pasture, and he will graze on Carmel and Bashan, 
				and his desire will be satisfied in the hill country of Ephraim and Gilead. 
			</p>
			<p class='fs-4 fw-bold text-center'>
				A <mark>Greater Exodus</mark> than the one from Egypt is coming
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector: 1</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremías 50:19</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>19</sup>  
				Y devolveré a Israel a su pasto, y pastará en Carmelo y Basán, 
				y su deseo se satisfará en la región montañosa de Efraím y Galaad.
			</p>
			<p class='fs-4 fw-bold text-center'>
				Un <mark>Éxodo Mayor</mark> que el de Egipto está por venir
			</p>
			";
	}

	private sealed class SeventhCup03SE : ContentDetail
	{
		public SeventhCup03SE() : base($"{nameof(Id.SeventhCup03)}", Id.SeventhCup03) { }
		public override int ParentId => Content.SeventhCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader: 2</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremiah 16:14-15</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>14</sup>
				Therefore behold, days are coming, declares Yehovah, 
				“when it will no longer be said, ‘As Yehovah lives, who brought up the sons of Israel out of the land of Egypt,’ 
				<sup class='text-primary fw-bold'>15</sup>
				but, ‘As Yehovah lives, who brought up the sons of Israel from the land of the north and from all the lands where He had banished them.’ 
				For I will return them to their own land which I gave to their fathers.”
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector: 2</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremías 16:14-15</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>14</sup>
				Por tanto, he aquí, vienen días, declara Yahvé, 
				“cuando ya no se dirá, 'Vive Yahvé, que sacó a los hijos de Israel de la tierra de Egipto,' 
				<sup class='text-primary fw-bold'>15</sup>
				sino, 'Vive Yahvé, que sacó a los hijos de Israel de la tierra del norte y de todas las tierras donde los había desterrado.' 
				Porque los devolveré a su propia tierra que di a sus padres.”
			</p>
			";
	}

	private sealed class SeventhCup04SE : ContentDetail
	{
		public SeventhCup04SE() : base($"{nameof(Id.SeventhCup04)}", Id.SeventhCup04) { }
		public override int ParentId => Content.SeventhCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader: 3</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Ezekiel 36:24-25</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>24</sup>
				And I shall take you from among the gentiles, and I shall gather you out of all lands, and I shall bring you into our own land. 
				<sup class='text-primary fw-bold'>25</sup>
				And I shall sprinkle clean water on you, and you shall be clean from all your filthiness, and from all your idols I cleanse you
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector: 3</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Ezequiel 36:24-25</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>24</sup>
				Y los tomaré de entre los gentiles, y los reuniré de todas las tierras, y los traeré a su propia tierra.
				<sup class='text-primary fw-bold'>25</sup>
				Y rociaré agua limpia sobre ustedes, y quedarán limpios de toda su inmundicia, y de todos sus ídolos los limpiaré.
			</p>
			";
	}

	private sealed class SeventhCup05SE : ContentDetail
	{
		public SeventhCup05SE() : base($"{nameof(Id.SeventhCup05)}", Id.SeventhCup05) { }
		public override int ParentId => Content.SeventhCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader: 4</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremiah 31:7-8</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>7</sup>
				For thus says Yehovah, Sing aloud with gladness for Jacob, And shout among the head of the nations;  
				Make it heard, give praise, and say, ‘O Yehovah, save Your people, The remnant <span class='hebrew text-danger fw-bold'>אֵת</span> of Israel. 
				<sup class='text-primary fw-bold'>8</sup>
				Behold, I will bring them from the north country and gather them from the farthest parts of the earth, 
				among them the blind and the lame, the pregnant woman and she who is in labor, together; a great company, they shall return here.
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector: 4</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Jeremías 31:7-8</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>7</sup>
				Porque así dice Yahvé, Canten con alegría por Jacob, Y griten entre la cabeza de las naciones; 
				Hagan que se oiga, den alabanza, y digan, 'Oh Yahvé, salva a Tu pueblo, El remanente <span class='hebrew text-danger fw-bold'>אֵת</span> de Israel.
				<sup class='text-primary fw-bold'>8</sup>
				He aquí, los traeré del país del norte y los reuniré de las partes más lejanas de la tierra, 
				entre ellos el ciego y el cojo, la mujer embarazada y la que está en trabajo de parto, juntos; una gran compañía, regresarán aquí.
			</p>
			";
	}

	private sealed class SeventhCup06SE : ContentDetail
	{
		public SeventhCup06SE() : base($"{nameof(Id.SeventhCup06)}", Id.SeventhCup06) { }
		public override int ParentId => Content.SeventhCup;
		public override string EngBody =>@"
			<p class='fs-5'>	
				<span class='text-success fw-bold'>Leader:</span><br />
				We drink joyfully of this last cup in expectation of the coming of the Kingdom of our Messiah Yeshua and of the Restoration of All Israel.<br />
				Let us toast to completing our journey from the nations back to our homeland. 
			</p>

			<p class='fs-5'>
				<span class='text-danger fw-bold'>All Shout</span> 
				<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
				<i class='fas fa-long-arrow-alt-right'></i>
				DRINK THE CUP <i class='text-danger fas fa-wine-glass-alt'></i>
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>	
				<span class='text-success fw-bold'>Leader:</span><br />
				Bebemos con alegría de esta última copa en expectativa de la venida del Reino de nuestro Mesías Yeshua y de la Restauración de Todo Israel.<br />
				Brindemos por completar nuestro viaje desde las naciones de regreso a nuestra patria.
			</p>
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Todos gritan</span> 
				<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
				<i class='fas fa-long-arrow-alt-right'></i>
				BEBEN LA COPA <i class='text-danger fas fa-wine-glass-alt'></i>
			</p>
			";
	}

	private sealed class SeventhCup07SE : ContentDetail
	{
		public SeventhCup07SE() : base($"{nameof(Id.SeventhCup07)}", Id.SeventhCup07) { }
		public override int ParentId => Content.SeventhCup;
		public override string EngBody =>@"
			<p class='fs-5'>	
				<span class='text-success fw-bold'>Leader:</span><br />
				Those of us who understand our true identity in Messiah, aka “in Israel”,  have begun to cry out for our final deliverance.  
				We are tired of Egypt and our long exile, even in this abundant and prosperous land, for we now yearn for the Land of our Fathers. 
				We are drawn to our Roots, to our Fathers ancient paths, to our heritage, to our true identity, and most importantly, to our awesome Bride-Groom of Messiah. 
			</p>
			<p class='fs-5'>
				We desire that Heaven hear us, breaking the boundaries that limit us, 
				and that Yehovah send our Messiah to lead us HOME, where our inward spirit is leading us.
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>	
				<span class='text-success fw-bold'>Líder:</span><br />
				Aquellos de nosotros que entendemos nuestra verdadera identidad en el Mesías, también conocida como “en Israel”, hemos comenzado a clamar por nuestra liberación final.
				Estamos cansados de Egipto y de nuestro largo exilio, incluso en esta tierra abundante y próspera, porque ahora anhelamos la Tierra de nuestros Padres. 
				Nos sentimos atraídos por nuestras Raíces, por los caminos antiguos de nuestros Padres, por nuestra heredad, por nuestra verdadera identidad, y lo más importante, por nuestro impresionante Novio del Mesías.
			</p>
			<p class='fs-5'>
				Deseamos que el Cielo nos escuche, rompiendo los límites que nos restringen, 
				y que YHWH envíe a nuestro Mesías para guiarnos a CASA, donde nuestro espíritu interior nos está llevando.
			</p>

			";
	}


	private sealed class SeventhCup08SE : ContentDetail
	{
		public SeventhCup08SE() : base($"{nameof(Id.SeventhCup08)}", Id.SeventhCup08) { }
		public override int ParentId => Content.SeventhCup;
		public override string EngBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader: 5</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Revelation 22:17, 20</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>17</sup>
				And the Spirit and the bride say, “Come.” And let the one who hears say, “Come.” And let the one who is thirsty come. 
				Let the one who wishes to receive the water of life  without cost.
				<sup class='text-primary fw-bold'>20</sup>
				He who bears witness to these things says, “Yes, I am coming quickly.” Amen. Come, Master Yeshua!
			</p>
			";
		public override string EspBody =>@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector: 5</span>
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Apocalipsis 22:17, 20</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>17</sup>
				Y el Espíritu y la novia dicen, “Ven.” Y que el que oye diga, “Ven.” Y que el que tenga sed venga. 
				Que el que desee reciba el agua de la vida sin costo.
				<sup class='text-primary fw-bold'>20</sup>
				El que da testimonio de estas cosas dice, “Sí, vengo pronto.” Amén. ¡Ven, Maestro Yeshua!'
			</p>
			";
	}

	private sealed class NextYearSE : ContentDetail
	{
		public NextYearSE() : base($"{nameof(Id.NextYear)}", Id.NextYear) { }
		public override int ParentId => Content.NextYear;
		public override string EngBody =>@"
		<h3 class='mt-5 mb-3 text-center'>Exodus Verses</h3>
			<p class=' fs-5'>
				<b>Exodus 12 1-6</b><br />
			</p>
		<div class='bg-danger-subtle p-2'>
			<p class='fs-5 fst-italic'>10 Plagues</p>
			<ol class='fs-5'>
				<li>Water turned to blood -  <a href='/BookChapter/Exo/7/14/1700'>Exodus 7:14-24</a></li>
				<li>Frogs -                  <a href='/BookChapter/Exo/8/1/1712'>Exodus 8:1-15</a></li> </li>
				<li>Lice (or gnats) -        <a href='/BookChapter/Exo/8/16/1727'>Exodus 8:16-19</a></li>
				<li>Flies (or swarms) -      <a href='/BookChapter/Exo/8/20/1731'>Exodus 8:20-32</a></li>
				<li>Livestock diseased -     <a href='/BookChapter/Exo/9/1/1744'>Exodus 9:1-7</a></li>
				<li>Boils -                  <a href='/BookChapter/Exo/9/8/1751'>Exodus 9:8-12</a></li>
				<li>Hail -                   <a href='/BookChapter/Exo/9/13/1756'>Exodus 9:13-35</a></li>
				<li>Locusts -                <a href='/BookChapter/Exo/10/1/1779'>Exodus 10:1-20</a></li>
				<li>Darkness -               <a href='/BookChapter/Exo/10/21/1799'>Exodus 10:21-29</a></li>
				<li>Death of the firstborn - <a href='/BookChapter/Exo/11/10/1808'>Exodus 11:1-10</a>; <a href='/BookChapter/Exo/12/29/1846'>Exodus 12:29-36</a> </li>
			</ol>
		</div>
			<ol class='fs-5 mt-5'>
			<li>
				<a href='https://myhebrewbible5.blob.core.windows.net/mhb-container/Article/Acts-12-4-The-one-and-only-occurrence-of-Easter-in-the-King-James.pdf' target='_blank'>
				Acts 12:4 - the one and only occurrence of Easter in the KJB (PDF)
				</a>
			</li>
			<li>
				<a href='https://myhebrewbible5.blob.core.windows.net/mhb-container/Article/Acts-12-4-Easter-only-in-KJV-G3957-H6453-BLB-Translations.jpg' target='_blank'>
					Acts 12:4 Word Study of Easter (Image)
				</a>
			</li>		
		</ol>
		";
		public override string EspBody =>@"
		";
	}
	#endregion

}

// Ignore Spelling: Matzah Charoset