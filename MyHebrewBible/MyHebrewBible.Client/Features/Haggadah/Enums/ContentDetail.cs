using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.Haggadah.Enums;

public abstract class ContentDetail : SmartEnum<ContentDetail>
{
	#region Id's
	private static class Id
	{
		internal const int Introduction01 = 1;
		internal const int Introduction02 = 2;
		internal const int Introduction03 = 3;

		internal const int FirstPassover01 = 4;
		internal const int FirstPassover02 = 5;
		internal const int FirstPassover03 = 6;
		internal const int FirstPassover04 = 7;
		internal const int FirstPassover05 = 8;
		internal const int FirstPassover06 = 9;
		internal const int FirstPassover07 = 10;
		internal const int FirstPassover08 = 11;

		internal const int PassoverDeliverance01 = 12;

		internal const int StoryOfRedemption01 = 13;
		internal const int StoryOfRedemption02 = 14;
		internal const int StoryOfRedemption03 = 15;
		internal const int StoryOfRedemption04 = 16;
		internal const int StoryOfRedemption05 = 17;
		internal const int StoryOfRedemption06 = 18;
		internal const int StoryOfRedemption07 = 19;
		internal const int StoryOfRedemption08 = 20;
		internal const int StoryOfRedemption09 = 21;
		internal const int StoryOfRedemption10 = 22;

		internal const int Matzah01 = 23;
		internal const int Matzah02 = 24;
		internal const int Matzah03 = 25;

		internal const int FirstCup01 = 26;
		internal const int FirstCup02 = 27;
		internal const int FirstCup03 = 28;

		internal const int SecondCup01 = 29;
		internal const int SecondCup02 = 30;
		internal const int SecondCup03 = 31;

		internal const int ThirdCup01 = 32;
		internal const int ThirdCup02 = 33;

		internal const int FourthCup01 = 34;
		internal const int FourthCup02 = 35;
		internal const int FourthCup03 = 36;
		internal const int FourthCup04 = 37;

		internal const int Charoset = 38;

		internal const int Dinner01 = 39;
		internal const int Dinner02 = 40;
		internal const int Dinner03 = 41;
		internal const int Dinner04 = 42;

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
	public static readonly ContentDetail Introduction01 = new Introduction01SE();
	public static readonly ContentDetail Introduction02 = new Introduction02SE();
	public static readonly ContentDetail Introduction03 = new Introduction03SE();

	public static readonly ContentDetail FirstPassover01 = new FirstPassover01SE();
	public static readonly ContentDetail FirstPassover02 = new FirstPassover02SE();
	public static readonly ContentDetail FirstPassover03 = new FirstPassover03SE();
	public static readonly ContentDetail FirstPassover04 = new FirstPassover04SE();
	public static readonly ContentDetail FirstPassover05 = new FirstPassover05SE();
	public static readonly ContentDetail FirstPassover06 = new FirstPassover06SE();
	public static readonly ContentDetail FirstPassover07 = new FirstPassover07SE();
	public static readonly ContentDetail FirstPassover08 = new FirstPassover08SE();

	public static readonly ContentDetail PassoverDeliverance01 = new PassoverDeliverance01SE();

	public static readonly ContentDetail StoryOfRedemption01 = new StoryOfRedemption01SE(); // Reader 1
	public static readonly ContentDetail StoryOfRedemption02 = new StoryOfRedemption02SE(); // Reader 2
	public static readonly ContentDetail StoryOfRedemption03 = new StoryOfRedemption03SE(); // Reader 3
	public static readonly ContentDetail StoryOfRedemption04 = new StoryOfRedemption04SE(); // Leader
	public static readonly ContentDetail StoryOfRedemption05 = new StoryOfRedemption05SE(); // Reader 4
	public static readonly ContentDetail StoryOfRedemption06 = new StoryOfRedemption06SE(); // Leader
	public static readonly ContentDetail StoryOfRedemption07 = new StoryOfRedemption07SE(); // Reader 5
	public static readonly ContentDetail StoryOfRedemption08 = new StoryOfRedemption08SE(); // Reader 6
	public static readonly ContentDetail StoryOfRedemption09 = new StoryOfRedemption09SE(); // Reader 7
	public static readonly ContentDetail StoryOfRedemption19 = new StoryOfRedemption10SE(); // Leader

	public static readonly ContentDetail Matzah01 = new Matzah01SE(); // Leader
	public static readonly ContentDetail Matzah02 = new Matzah02SE(); // Reader
	public static readonly ContentDetail Matzah03 = new Matzah03SE(); // Leader

	public static readonly ContentDetail FirstCup01 = new FirstCup01SE();
	public static readonly ContentDetail FirstCup02 = new FirstCup02SE();
	public static readonly ContentDetail FirstCup03 = new FirstCup03SE();

	public static readonly ContentDetail SecondCup01 = new SecondCup01SE();
	public static readonly ContentDetail SecondCup02 = new SecondCup02SE();
	public static readonly ContentDetail SecondCup03 = new SecondCup03SE();

	public static readonly ContentDetail ThirdCup01 = new ThirdCup01SE();
	public static readonly ContentDetail ThirdCup02 = new ThirdCup02SE();

	public static readonly ContentDetail FourthCup01 = new FourthCup01SE();
	public static readonly ContentDetail FourthCup02 = new FourthCup02SE();
	public static readonly ContentDetail FourthCup03 = new FourthCup03SE();
	public static readonly ContentDetail FourthCup04 = new FourthCup04SE();

	public static readonly ContentDetail Charoset = new CharosetSE();

	public static readonly ContentDetail Dinner01 = new Dinner01SE();
	public static readonly ContentDetail Dinner02 = new Dinner02SE();
	public static readonly ContentDetail Dinner03 = new Dinner03SE();
	public static readonly ContentDetail Dinner04 = new Dinner04SE();

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
	public abstract MarkupString EngBody { get; }
	public abstract MarkupString EspBody { get; }
	#endregion

	#region Private Instantiation

	private sealed class Introduction01SE : ContentDetail
	{
		public Introduction01SE() : base($"{nameof(Id.Introduction01)}", Id.Introduction01) { }
		public override int ParentId => Content.Introduction;
		public override MarkupString EngBody => (MarkupString)(@"<h3 class='mb-3 text-center'>Welcome to the Feast of Passover</h3>");
		public override MarkupString EspBody => (MarkupString)(@"<h3 class='mb-3 text-center'>Bienvenidos a la Fiesta de Pascua</h3>");
	}

	private sealed class Introduction02SE : ContentDetail
	{
		public Introduction02SE() : base($"{nameof(Id.Introduction02)}", Id.Introduction02) { }
		public override int ParentId => Content.Introduction;
		public override MarkupString EngBody => (MarkupString)(@"<h3 class='mb-3 text-center text-primary'>A celebration of the rescue of the House of Israel (Ephraim)");
		public override MarkupString EspBody => (MarkupString)(@"<h3 class='mb-3 text-center text-primary'>Una celebración del rescate de la Casa de Israel (Efraím)</h3>");
	}

	private sealed class Introduction03SE : ContentDetail
	{
		public Introduction03SE() : base($"{nameof(Id.Introduction03)}", Id.Introduction03) { }
		public override int ParentId => Content.Introduction;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='text-center text-danger fs-5 mb-3'>Come my beloved and celebrate the festival of our redemption</p>

			<p class='text-center text-danger fs-5 my-1'>Where bondage bows to freedom </p>
			<p class='text-center text-danger fs-5 my-1'>Where darkness bows to light</p>
			<p class='text-center text-danger fs-5 my-1'>Where despair bows to hope</p>
			<p class='text-center text-danger fs-5 mt-1 mb-3'>Where death bows to life</p>

			<p class='text-center text-danger fs-5 my-1'>Where faith overcomes fear</p>
			<p class='text-center text-danger fs-5 my-1'>Where good overcomes evil</p>
			<p class='text-center text-danger fs-5 my-1'>Where truth overcomes falsehood</p>
			<p class='text-center text-danger fs-5 mt-1 mb-3'>Where joy overcomes anger</p>

			<p class='text-center text-danger fs-5 my-1'>Where pride is replaced by humility</p>
			<p class='text-center text-danger fs-5 my-1'>Where apathy is replaced by love</p>
			<p class='text-center text-danger fs-5 my-1'>Where chaos is replaced by shalom</p>
			<p class='text-center text-danger fs-5 my-1'>Where rebellion is replaced by obedience</p>		
			");

		public override MarkupString EspBody => (MarkupString)(@"
			<p class='text-center text-danger fs-5 mb-3'>Ven, amado mío, y celebra la conmemoracion de nuestra redención</p>

			<p class='text-center text-danger fs-5 my-1'>Donde la esclavitud se inclina ante la libertad</p>
			<p class='text-center text-danger fs-5 my-1'>Donde la oscuridad se inclina ante la luz</p>
			<p class='text-center text-danger fs-5 my-1'>Donde la desesperanza se inclina ante la esperanza</p>
			<p class='text-center text-danger fs-5 mt-1 mb-3'>Donde la muerte se inclina ante la vida</p>

			<p class='text-center text-danger fs-5 my-1'>Donde la fe vence al miedo</p>
			<p class='text-center text-danger fs-5 my-1'>Donde el bien vence al mal</p>
			<p class='text-center text-danger fs-5 my-1'>Donde la verdad vence a la falsedad</p>
			<p class='text-center text-danger fs-5 mt-1 mb-3'>Donde la alegría vence a la ir</p>

			<p class='text-center text-danger fs-5 my-1'>Donde el orgullo es reemplazado por la humanidad</p>
			<p class='text-center text-danger fs-5 my-1'>Donde la apatía es reemplazada por el amor</p>
			<p class='text-center text-danger fs-5 my-1'>Donde el caos es reemplazado por el shalom</p>
			<p class='text-center text-danger fs-5 my-1'>Donde la rebelión es reemplazada por la obediencia</p>		

			");
	}


	private sealed class FirstPassover01SE : ContentDetail
	{
		public FirstPassover01SE() : base($"{nameof(Id.FirstPassover01)}", Id.FirstPassover01) { }
		public override int ParentId => Content.FirstPassover;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger'>Reader 1:</span> 
				Long ago our forefathers lived in a land beyond the Euphrates River called Mesopotamia.  
				There, a descendant of Shem named Abram was told by God to go to a land called Canaan. 
				So Abram along with his wife  Sarai and many from Haran journeyed to Canaan. 
				There, God told Abraham that He would have many descendants and would live in that land and made an everlasting covenant with him. 
				Abram became Abraham.
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector 1:</span> 
				Hace mucho tiempo, nuestros antepasados vivieron en una tierra más allá del río Éufrates llamada Mesopotamia. 
				Allí, un descendiente de Sem llamado Abram recibió de Dios la instrucción de ir a una tierra llamada Canaán. 
				Así que Abram, junto con su esposa Sarai y muchos de Harán, viajaron a Canaán. 
				Allí, Dios le dijo a Abraham que tendría muchos descendientes y viviría en esa tierra, y estableció con él un pacto eterno. 
				Abram se convirtió en Abraham.
			</p>
			");
	}

	private sealed class FirstPassover02SE : ContentDetail
	{
		public FirstPassover02SE() : base($"{nameof(Id.FirstPassover02)}", Id.FirstPassover02) { }
		public override int ParentId => Content.FirstPassover;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader 2:</span> 
				Abraham’s grandson Jacob had 12 sons who became the 12 tribes of Israel. 
				The 11th son, Joseph, was envied by his brothers, thrown into a pit then sold to slave traders and was brought to Egypt.  
				There he  became 2nd in command of all Egypt and in charge of the nations food supply. 
				During a great famine, all of Joseph’s family moved down to Egypt. 
				Joseph’s purpose for being sold into slavery was shown to him and he revealed himself to his brothers.
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector 2:</span> 
				El nieto de Abraham, Jacob, tuvo 12 hijos que se convirtieron en las 12 tribus de Israel. 
				El undécimo hijo, José, fue envidiado por sus hermanos, arrojado a un pozo y luego vendido a traficantes de esclavos que lo llevaron a Egipto. 
				Allí se convirtió en el segundo al mando de todo Egipto y encargado del suministro de alimentos de la nación. 
				Durante una gran hambruna, toda la familia de José se trasladó a Egipto. 
				El propósito de José al ser vendido como esclavo le fue revelado, y él se dio a conocer a sus hermanos.
			</p>
			");
	}

	private sealed class FirstPassover03SE : ContentDetail
	{
		public FirstPassover03SE() : base($"{nameof(Id.FirstPassover03)}", Id.FirstPassover03) { }
		public override int ParentId => Content.FirstPassover;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader 3:</span> 
				Many years later, the Egyptians began to look upon the people of Jacob/Israel as slaves and made life very difficult for them. Then they cried out to God for deliverance. They remembered Abraham and the promises that God gave him and they prayed in desperation for a deliverer who would rescue them from their oppression.
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector 3:</span> 
				Muchos años después, los egipcios comenzaron a considerar al pueblo de Jacob/Israel como esclavos y les hicieron la vida muy difícil. Entonces clamaron a Dios por liberación. Recordaron a Abraham y las promesas que Dios le había dado, y oraron desesperadamente por un libertador que los rescatara de su opresión.
			</p>
			");
	}

	private sealed class FirstPassover04SE : ContentDetail
	{
		public FirstPassover04SE() : base($"{nameof(Id.FirstPassover04)}", Id.FirstPassover04) { }
		public override int ParentId => Content.FirstPassover;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader 4:</span> 
				God sent Moses, a Levite, and in a burning bush told him to confront the Pharaoh to <b>Let my people go</b>.
				Pharaoh ignored Moses’ plea’s, so God caused 10 plagues to destroy Egypt. 
				The 10th plague, the death of the firstborn, finally caused Pharaoh to let them go.  
				In preparation for this last plague, God told the Israelites to choose a spotless lamb one year old. 
				Four days later they would kill the lamb and put some of its blood on the doorposts of their homes and eat the roasted lamb with bitter herbs and unleavened bread. 
				And they were not to leave any of it until morning, and what remains of it until morning you are to burn with fire. 
				This meal was eaten in a hurry with their sandals on and their bags packed and ready to leave Egypt. 
				They were ready for the tenth and final judgment, the death of all the firstborn in Egypt. 
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector 4:</span> 
				Dios envió a Moisés, un levita, y en una zarza ardiente le dijo que confrontara al Faraón con las palabras: <b>Deja ir a mi pueblo</b>.
				El Faraón ignoró las súplicas de Moisés, por lo que Dios envió 10 plagas para destruir Egipto. 
				La décima plaga, la muerte de los primogénitos, finalmente obligó al Faraón a dejarlos ir. 
				En preparación para esta última plaga, Dios instruyó a los israelitas a elegir un cordero sin mancha de un año. 
				Cuatro días después, debían matar al cordero, poner parte de su sangre en los postes de las puertas de sus casas y comer el cordero asado con hierbas amargas y pan sin levadura. 
				No debían dejar nada hasta la mañana, y lo que quedara debían quemarlo con fuego. 
				Esta comida se comió apresuradamente, con sandalias puestas y bolsas empacadas, listos para salir de Egipto. 
				Estaban preparados para el décimo y último juicio, la muerte de todos los primogénitos en Egipto.
			</p>
			");
	}

	private sealed class FirstPassover05SE : ContentDetail
	{
		public FirstPassover05SE() : base($"{nameof(Id.FirstPassover05)}", Id.FirstPassover05) { }
		public override int ParentId => Content.FirstPassover;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader 5:</span> 
				And it came to  pass at midnight, all the firstborn in the land of Egypt died, even the cattle. 
				<mark>“But when I see the blood on the lintel and doorposts of the houses where you live, 
				I will pass over you and no plague will befall you to destroy you and you will be spared”</mark>.
				Without the death of the lamb and the spreading of its blood, the children of Israel would have suffered the judgment of God.
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector 5:</span> 
				Y sucedió que a medianoche murieron todos los primogénitos en la tierra de Egipto, incluso el ganado. 
				<mark>“Pero cuando vea la sangre en el dintel y los postes de las puertas de las casas donde viven, 
				pasaré sobre ustedes y ninguna plaga los alcanzará para destruirlos, y serán salvados”</mark>. 
				Sin la muerte del cordero y la aplicación de su sangre, los hijos de Israel habrían sufrido el juicio de Dios.
			</p>
			");
	}

	private sealed class FirstPassover06SE : ContentDetail
	{
		public FirstPassover06SE() : base($"{nameof(Id.FirstPassover06)}", Id.FirstPassover06) { }
		public override int ParentId => Content.FirstPassover;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader 6:</span> 
				The Israelites left Egypt and were led by a pillar of cloud by day and of fire by night to a camp on a sandy shore on an arm of the Red Sea. 
				Back in Egypt, Pharaoh changed his mind again and took horses and chariots to chase after the Israelites. 
				Seeing the Egyptians coming, the people were terrified. Moses told the people, 
				“do not be afraid, stand firm and see the deliverance of the Yehovah today. The Egyptians you see today, you will never see again. Yehovah will fight for you.”
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector 6:</span> 
				Los israelitas dejaron Egipto y fueron guiados por una columna de nube de día y de fuego de noche hasta un campamento en una costa arenosa en un brazo del Mar Rojo. 
				En Egipto, el Faraón cambió de opinión nuevamente y tomó caballos y carros para perseguir a los israelitas. 
				Al ver a los egipcios acercarse, el pueblo se aterrorizó. Moisés les dijo: 
				“No teman, manténganse firmes y vean la liberación de Yahvé hoy. Los egipcios que ven hoy, nunca los volverán a ver. Yahvé peleará por ustedes.”
			</p>
			");
	}

	private sealed class FirstPassover07SE : ContentDetail
	{
		public FirstPassover07SE() : base($"{nameof(Id.FirstPassover07)}", Id.FirstPassover07) { }
		public override int ParentId => Content.FirstPassover;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader 7:</span> 
				Then God said to Moses, 
				“Raise your staff and stretch out your arm over the sea to divide the water so that the Israelites can go through the sea on dry ground.” 
				Then the sea drew back and dry land appeared. 
				The Israelites went through the sea on dry ground with a wall of water to the left and to the right. 
				The Egyptians chased after them and followed them into the sea. 
				And God caused the wheels on the chariots to come off and threw the Egyptian army into confusion. 
				And the Egyptians said, 
				“Let us get away from the Israelites because God is fighting for them.”
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector 7:</span> 
				Entonces Dios le dijo a Moisés: 
				“Levanta tu vara y extiende tu brazo sobre el mar para dividir las aguas, para que los israelitas puedan pasar por el mar en tierra seca”. 
				Entonces el mar se retiró y apareció tierra seca. 
				Los israelitas atravesaron el mar en tierra seca con una pared de agua a la izquierda y a la derecha. 
				Los egipcios los persiguieron y los siguieron hacia el mar. 
				Y Dios hizo que las ruedas de los carros se salieran y arrojó al ejército egipcio en confusión. 
				Y los egipcios dijeron: 
				“Huyamos de los israelitas porque Dios está luchando por ellos”.
			</p>
			");
	}

	private sealed class FirstPassover08SE : ContentDetail
	{
		public FirstPassover08SE() : base($"{nameof(Id.FirstPassover08)}", Id.FirstPassover08) { }
		public override int ParentId => Content.FirstPassover;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader 8:</span> 
				Then God said to Moses, 
				“Stretch out your hand over the sea so that the waters may flow back over the Egyptians.”
				And God swept them all under the sea. 
				Not one of them survived.  
				That day God saved his people and the people saw the great power of Yehovah our GOD. 
				The people feared the Yehovah and put their trust in Him and Moses his servant.
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector 8:</span> 
				Entonces Dios le dijo a Moisés: 
				“Extiende tu mano sobre el mar para que las aguas vuelvan sobre los egipcios.” 
				Y Dios los arrastró a todos bajo el mar. 
				Ninguno de ellos sobrevivió. 
				Ese día Dios salvó a su pueblo y el pueblo vio el gran poder de Yahvé nuestro DIOS. 
				El pueblo temió a Yahvé y puso su confianza en Él y en Moisés, su siervo.
			</p>
			");
	}

	private sealed class PassoverDeliverance01SE : ContentDetail
	{
		public PassoverDeliverance01SE() : base($"{nameof(Id.PassoverDeliverance01)}", Id.PassoverDeliverance01) { }
		public override int ParentId => Content.PassoverDeliverance;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>ALL READ:</span> 
				Yehovah brought Yisrael out, 
				led them through the wilderness, revealed His Presence at Mount Sinai, and gave to them the Torah. 
				He instructed them to build the Tabernacle and established a Priesthood to serve Him. 
				Neither their shoes nor their clothes were worn out. 
				He fed them with manna, gave them water from the Rock, 
				defeated their enemies before them and brought them into <i>Eretz Yisrael</i>. 
				Yehovah did what He promised to do; He delivered them.
			</p>
			<p class='fs-4 text-center fw-bold'>
			  He will ALSO do what He has promised to do to deliver the House of Israel from its dilemma in the nations. 
			</p>
			");

		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>TODOS LEEN:</span> 
				Yahvé sacó a Yisrael, los guió a través del desierto, reveló Su Presencia en el Monte Sinaí y les dio la Torá. 
				Les instruyó que construyeran el Tabernáculo y estableció un Sacerdocio para servirle. 
				Ni sus zapatos ni sus ropas se desgastaron. 
				Los alimentó con maná, les dio agua de la Roca, 
				derrotó a sus enemigos delante de ellos y los llevó a <i>Eretz Yisrael</i>. 
				Yahvé hizo lo que prometió; los liberó.
			</p>
				
			<p class='fs-4 text-center fw-bold'>
			  También hará lo que ha prometido para liberar a la Casa de Israel de su dilema en las naciones.
			</p>
			");
	}


	private sealed class StoryOfRedemption01SE : ContentDetail
	{
		public StoryOfRedemption01SE() : base($"{nameof(Id.StoryOfRedemption01)}", Id.StoryOfRedemption01) { }
		public override int ParentId => Content.StoryOfRedemption;

		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader 1:</span>
			Many years after the children of Israel entered the Land promised to them in the covenant with Abraham, 
			the tribes of Israel were in turmoil and conflict with each other.
			A portion of the tribes from the north were called The House of Israel and led by the tribe of Ephraim, the tribe of Joseph’s son.  
			The southern tribes were called The House of Judah. 
			From this is where we get the term Jews. 
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector 1:</span> 
			Muchos años después de que los hijos de Israel entraran en la Tierra prometida en el pacto con Abraham, 
			las tribus de Israel estaban en conflicto y turmoil entre sí. 
			Una porción de las tribus del norte fueron llamadas La Casa de Israel y lideradas por la tribu de Efraím, la tribu del hijo de José. 
			Las tribus del sur fueron llamadas La Casa de Judá. 
			De aquí es donde obtenemos el término judíos.
		</p>
		");
	}

	private sealed class StoryOfRedemption02SE : ContentDetail
	{
		public StoryOfRedemption02SE() : base($"{nameof(Id.StoryOfRedemption02)}", Id.StoryOfRedemption02) { }
		public override int ParentId => Content.StoryOfRedemption;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader 2:</span> 
			The northern  tribes separated from their brothers in the south and were led down a path of rebellion by Jeroboam, a king from the tribe of Ephraim. 
			They quickly descended into idolatry and apostasy  and built  altars in Dan and Bethel to replace Jerusalem and created a false priesthood to go with their idol worship.  
			They even made golden calves and lifted them up as gods to the people like the incident at Mt.Sinai. 
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector 2:</span>
			Las tribus del norte se separaron de sus hermanos del sur y fueron conducidas por un camino de rebelión por Jeroboam, un rey de la tribu de Efraím. 
			Rápidamente descendieron a la idolatría y la apostasía y construyeron altares en Dan y Betel para reemplazar a Jerusalén y crearon un sacerdocio falso para acompañar su adoración de ídolos. 
			Incluso hicieron becerros de oro y los elevaron como dioses para el pueblo, como el incidente en el Monte Sinaí.
		</p>
		");
	}

	private sealed class StoryOfRedemption03SE : ContentDetail
	{
		public StoryOfRedemption03SE() : base($"{nameof(Id.StoryOfRedemption03)}", Id.StoryOfRedemption03) { }
		public override int ParentId => Content.StoryOfRedemption;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader 3:</span> 
			The northern tribes cut themselves off from Judah and in a declaration said, 
			“What portion do we have in David? We have no heritage in the son of Jesse.” <sup>(1 Kings 12:16)</sup>
			In verse 19 it says, 
			“So Israel (the House of Israel) has been in rebellion against the House of David (Judah) to this day.”
			God then declares in <sup>1 Kings 12:24</sup>  “this thing is of me”.
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector 3:</span> 
			Las tribus del norte se aislaron de Judá y en una declaración dijeron: 
			“¿Qué porción tenemos en David? No tenemos herencia en el hijo de Isaí.” <sup>(1 Reyes 12:16)</sup>
			En el versículo 19 dice: 
			“Así que Israel (la Casa de Israel) ha estado en rebelión contra la Casa de David (Judá) hasta este día.”
			Entonces Dios declara en <sup>1 Reyes 12:24</sup> “esto es de mí”.
		</p>
		");
	}

	private sealed class StoryOfRedemption04SE : ContentDetail
	{
		public StoryOfRedemption04SE() : base($"{nameof(Id.StoryOfRedemption04)}", Id.StoryOfRedemption04) { }
		public override int ParentId => Content.StoryOfRedemption;

		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5 fw-bold my-3'>The Bitter Herbs - Maror</p>

		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span>
			 <sup>2 Kings 14:26</sup> “For Yehovah saw the affliction of Israel, which was very bitter; and whether bond or free, there was no helper for Israel.”
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5 fw-bold my-3'>Las Hierbas Amargas - Maror</p>

		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> 
			<sup>2 Reyes 14:26 </sup> “Porque Yahvé vio la aflicción de Israel, que era muy amarga; y ya fuera siervo o libre, no había ayudador para Israel.”
		</p>
		");
	}

	private sealed class StoryOfRedemption05SE : ContentDetail
	{
		public StoryOfRedemption05SE() : base($"{nameof(Id.StoryOfRedemption05)}", Id.StoryOfRedemption05) { }
		public override int ParentId => Content.StoryOfRedemption;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader 4:</span> 
			We weep for the bitterness our ancestors felt as they experienced anger and rejection from Judah and throughout their years of rebellion against God. 
			It must have been an increasingly lonely existence for them as they plunged themselves more deeply into spiritual darkness and distress.
			They had no way to be set-free as they had rejected the path of freedom that God had given them in His Torah.
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector 4:</span>
			Lloramos por la amargura que sintieron nuestros antepasados al experimentar ira y rechazo de Judá y a lo largo de sus años de rebelión contra Dios. 
			Debió haber sido una existencia cada vez más solitaria para ellos mientras se sumían más profundamente en la oscuridad y la angustia espiritual. 
			No tenían manera de liberarse, ya que habían rechazado el camino de libertad que Dios les había dado en Su Torá.
		</p>
		");
	}

	private sealed class StoryOfRedemption06SE : ContentDetail
	{
		public StoryOfRedemption06SE() : base($"{nameof(Id.StoryOfRedemption06)}", Id.StoryOfRedemption06) { }
		public override int ParentId => Content.StoryOfRedemption;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span>
			Blessed are You Yehovah our Elohim, King of the universe, 
			Who has sanctified us with His commandments, and commanded us to observe the eating of bitter herbs.  
			<span class='fw-light fst-italic'>(Take enough to bring you to tears)</span>
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> 
			Bendito eres Tú, Yahvé nuestro Elohim, Rey del universo, 
			Quien nos ha santificado con Sus mandamientos y nos ha ordenado observar el consumo de hierbas amargas. 
			<span class='fw-light fst-italic'>(Toma suficiente para que te haga llorar)</span>
		</p>
		");
	}

	private sealed class StoryOfRedemption07SE : ContentDetail
	{
		public StoryOfRedemption07SE() : base($"{nameof(Id.StoryOfRedemption07)}", Id.StoryOfRedemption07) { }
		public override int ParentId => Content.StoryOfRedemption;

		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5 fw-bold my-3'>Eat the Bitter herbs (with matzah)</p>
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader 5:</span>
			So God had a plan to use the rebellious House of Israel to redeem the world by sowing them into the nations. 
			Yehovah divorced them and cast them out of the Land and they were stripped of their identity and memory of ever having been part of Israel. 
			<span class='fw-bold text-decoration-underline'>This is much worse than exile.</span>
			<span class='text-danger fw-bold'>It is destruction of identity.</span>
			They cannot return and God cannot receive them back without a great plan of redemption. 
			Which of course He has!
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5 fw-bold my-3'>Come las Hierbas Amargas (con matzá)</p>
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector 5:</span> 
			Entonces Dios tuvo un plan para usar a la rebelde Casa de Israel para redimir al mundo al sembrarlos entre las naciones. 
			Yahvé los divorció y los expulsó de la Tierra, y fueron despojados de su identidad y memoria de haber sido parte de Israel. 
			<span class='fw-bold text-decoration-underline'>Esto es mucho peor que el exilio.</span>
			<span class='text-danger fw-bold'>Es la destrucción de la identidad.</span>
			No pueden regresar y Dios no puede recibirlos de vuelta sin un gran plan de redención. 
			¡Que por supuesto Él tiene!
		</p>
		");
	}

	private sealed class StoryOfRedemption08SE : ContentDetail
	{
		public StoryOfRedemption08SE() : base($"{nameof(Id.StoryOfRedemption08)}", Id.StoryOfRedemption08) { }
		public override int ParentId => Content.StoryOfRedemption;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader 6:</span> 
			The fate of Ephraim was to not be a people any longer and not be betrothed to Yehovah. 
			The first sign of the redemption of the House of Israel from the nations where they had been banished and sifted is with the promise of a Renewed covenant
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Jeremiah 31:31-33</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>31</sup> “Behold, days are coming,” declares Yehovah, “when I will cut a renewed covenant with the house of Israel and with the house of Judah,
			<sup class='text-primary fw-bold'>32</sup> not like the covenant which I cut with their fathers in the day I took them by the hand to bring them out of the land of Egypt, My covenant which they broke, but I was a husband to them,” declares Yehovah. 
			<sup class='text-primary fw-bold'>33</sup> “But this is the covenant which I will cut with the house of Israel after those days,” declares Yehovah: 
			“I will put My law within them, and on their heart I will write it; and I will be their God, and they shall be My people”.
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector 6:</span>
		</p>
		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Jeremías 31:31-33</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>31</sup> “He aquí, vienen días,' declara Yahvé, 'cuando cortaré un nuevo pacto con la casa de Israel y con la casa de Judá,  
			<sup class='text-primary fw-bold'>32</sup> no como el pacto que corté con sus padres el día que los tomé de la mano para sacarlos de la tierra de Egipto, Mi pacto que ellos rompieron, aunque Yo fui un esposo para ellos,' declara Yahvé.
			<sup class='text-primary fw-bold'>33</sup> “Pero este es el pacto que cortaré con la casa de Israel después de esos días,' declara Yahvé: 
			'Pondré Mi ley dentro de ellos, y en su corazón la escribiré; y Yo seré su Dios, y ellos serán Mi pueblo'”.
		</p>
		");
	}

	private sealed class StoryOfRedemption09SE : ContentDetail
	{
		public StoryOfRedemption09SE() : base($"{nameof(Id.StoryOfRedemption09)}", Id.StoryOfRedemption09) { }
		public override int ParentId => Content.StoryOfRedemption;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader 7:</span> 
			Yeshua, the Messiah of Israel,  would come and walk among the people as a man and initiate the return of Ephraim by cutting a Renewed Covenant by His own blood to redeem the House of Israel and The House of Judah because they had broken the old marriage covenant. 
			It would be a new MARRIAGE covenant and His resurrection would allow Him to remarry the divorced House of Israel. 
			This is the gospel of the Kingdom, God’s master plan to rescue and redeem Ephraim from the nations and restore the broken bride of Israel.
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector 7:</span>
			Yeshua, el Mesías de Israel, vendría y caminaría entre el pueblo como hombre e iniciaría el retorno de Efraím al cortar un Nuevo Pacto con Su propia sangre para redimir a la Casa de Israel y a la Casa de Judá porque habían roto el antiguo pacto matrimonial. 
			Sería un nuevo pacto de MATRIMONIO y Su resurrección le permitiría volver a casarse con la Casa de Israel divorciada. 
			Este es el evangelio del Reino, el plan maestro de Dios para rescatar y redimir a Efraím de las naciones y restaurar a la novia rota de Israel.
		</p>
		");
	}

	private sealed class StoryOfRedemption10SE : ContentDetail
	{
		public StoryOfRedemption10SE() : base($"{nameof(Id.StoryOfRedemption10)}", Id.StoryOfRedemption10) { }
		public override int ParentId => Content.StoryOfRedemption;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span> 
		</p>
		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Luke 22:19-20</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>19</sup> And when He had taken some bread and given thanks, He broke it and gave it to them, saying, 
			“This is My body which is given for you. Do this in remembrance of Me.” 
			<sup class='text-primary fw-bold'>20</sup> And in the same way He took the cup after they had eaten, saying, 
			“This cup which is poured out for you is the renewed covenant in My blood.”
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> 
		</p>
		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Lucas 22:19-20</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>19</sup> Y cuando hubo tomado pan y dado gracias, lo partió y se lo dio, diciendo: 
			“Este es Mi cuerpo que es dado por ustedes. Hagan esto en memoria de Mí.” 
			<sup class='text-primary fw-bold'>20</sup> Y de la misma manera tomó la copa después de haber comido, diciendo: 
			“Esta copa que es derramada por ustedes es el nuevo pacto en Mi sangre.”
		</p>
		");
	}


	private sealed class Matzah01SE : ContentDetail
	{
		public Matzah01SE() : base($"{nameof(Id.Matzah01)}", Id.Matzah01) { }
		public override int ParentId => Content.Matzah;

		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>LEADER:</span>
			Our people left Egypt in such haste that their bread dough did not have time to rise and they did not take their leavened lump with them. 
			They ate unleavened bread.  
			Messiah is our unleavened bread as He is without sin.
		</p>
		<p class='fs-5'>
			Tonight, we eat Matzah to recognize Yeshua our Messiah, Who has rescued us and whose Spirit causes us to walk in His ways of Torah. 
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span>
			Nuestro pueblo dejó Egipto con tanta prisa que su masa de pan no tuvo tiempo de leudar y no llevaron consigo su masa leudada. 
			Comieron pan sin levadura. El Mesías es nuestro pan sin levadura, ya que Él está sin pecado.  
		</p>
		<p class='fs-5'>
			Esta noche, comemos Matzá para reconocer a Yeshua nuestro Mesías, Quien nos ha rescatado y cuyo Espíritu nos hace caminar en Sus caminos de la Torá.
		</p>

		");
	}

	private sealed class Matzah02SE : ContentDetail
	{
		public Matzah02SE() : base($"{nameof(Id.Matzah02)}", Id.Matzah02) { }
		public override int ParentId => Content.Matzah;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader:</span> 
		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>John 6:35, 38, 51</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>35</sup> Yeshua says. “I am the bread of life...”<br />
			<sup class='text-primary fw-bold'>38</sup> “For I have come down from heaven, not to do My own will, but the will of Him who sent Me.”<br />
			<sup class='text-primary fw-bold'>51</sup> “I am the living  bread which came down from heaven. If anyone eats of this bread, he will live forever, and the bread that I shall give is My flesh which I shall give for the life of the world.”
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector:</span>
		</p>
		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Juan 6:35, 38, 51</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>35</sup> Yeshua dice. “Yo soy el pan de vida....”<br />
			<sup class='text-primary fw-bold'>38</sup> “Porque he descendido del cielo, no para hacer Mi propia voluntad, sino la voluntad de Aquel que me envió.”<br />
			<sup class='text-primary fw-bold'>51</sup> “Yo soy el pan vivo que descendió del cielo. Si alguien come de este pan, vivirá para siempre, y el pan que daré es Mi carne, que daré por la vida del mundo.”
		</p>
		");
	}

	private sealed class Matzah03SE : ContentDetail
	{
		public Matzah03SE() : base($"{nameof(Id.Matzah03)}", Id.Matzah03) { }
		public override int ParentId => Content.Matzah;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span> 
			Blessed are You Yehovah our Elohim, King of the universe Who brings forth Bread from the Earth…
		</p>
		<p class='fs-4 fw-bold my-3'>Eat the Matzah</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-'>
			<span class='text-success fw-bold'>Líder:</span>
			Bendito eres Tú, YHWH nuestro Elohim, Rey del universo, Quien saca el Pan de la Tierra...
		</p>
		<p class='fs-4 fw-bold my-3'>Come el Matzá</p>
		");
	}

	private sealed class FirstCup01SE : ContentDetail
	{
		public FirstCup01SE() : base($"{nameof(Id.FirstCup01)}", Id.FirstCup01) { }
		public override int ParentId => Content.FirstCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span> 
			We drink this cup in gratitude for our Messiah Yeshua coming down from heaven and becoming a man, 
			to show us how to live and then dying for our sins and rising from the dead to offer us forgiveness and a new  relationship with our Father in heaven. 
			The first marriage covenant, which Ephraim broke, is dissolved 
			<span class='text-decoration-underline fw-bold'>so all could be born anew to a new and better covenant with our resurrected (new) Groom and King</span>.
			This is the CUP of the New Heart and New Spirit of the Renewed Covenant.
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> 
			Bebemos esta copa en gratitud por nuestro Mesías Yeshua que descendió del cielo y se hizo hombre, 
			para mostrarnos cómo vivir y luego morir por nuestros pecados y resucitar de entre los muertos para ofrecernos perdón y una nueva relación con nuestro Padre en el cielo. 
			El primer pacto matrimonial, que Efraím rompió, se disuelve 
			<span class='text-decoration-underline fw-bold'>para que todos puedan nacer de nuevo en un pacto nuevo y mejor con nuestro Novio y Rey resucitado (nuevo)</span>.
			Esta es la COPA del Nuevo Corazón y Nuevo Espíritu del Nuevo Pacto.
		</p>
		");
	}

	private sealed class FirstCup02SE : ContentDetail
	{
		public FirstCup02SE() : base($"{nameof(Id.FirstCup02)}", Id.FirstCup02) { }
		public override int ParentId => Content.FirstCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span> <br />
			<i class='fas fa-quote-left'></i> Blessed are You Yehovah our Elohim, King of the universe Who creates the fruit of the Vine 
			We toast to the Renewed Covenant that Messiah gave us to rescue us and redeem us!
		</p>
		
		<p class='fs-5'>
			<span class='text-danger fw-bold'>All Shout</span> 
			<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
			<i class='fas fa-long-arrow-alt-right'></i>
			DRINK THE CUP <i class='text-danger fas fa-wine-glass-alt'></i>
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> <br />
			<i class='fas fa-quote-left '></i> Bendito eres Tú, YHWH nuestro Elohim, Rey del universo, Quien crea el fruto de la Vid.
		</p>
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Todos gritan</span> 
			<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
			<i class='fas fa-long-arrow-alt-right'></i>
			BEBEN LA COPA <i class='text-danger fas fa-wine-glass-alt'></i>
		</p>
		");
	}

	private sealed class FirstCup03SE : ContentDetail
	{
		public FirstCup03SE() : base($"{nameof(Id.FirstCup03)}", Id.FirstCup03) { }
		public override int ParentId => Content.FirstCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader:</span> 
			Another fate of Ephraim in <b>Hosea 1:6</b> is receiving NO MERCY from God. 
			God has declared that He is no longer her husband in Hosea 2:2.  
			God is calling Ephraim to repent so that He may have mercy upon her. But she does not repent.There is no hope for Ephraim to return to God. 
		</p>
		");
		// And she conceived again, and bare a daughter. And God said unto him, Call her name Loruhamah: for I will no more have mercy upon the house of Israel; but I will utterly take them away.

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector:</span> 
			Otro destino de Efraím en <b>Oseas 1:6</b> es no recibir MISERICORDIA de Dios. Dios ha declarado que ya no es su esposo en Oseas 2:2. Dios está llamando a Efraím a arrepentirse para que pueda tener misericordia de ella. Pero ella no se arrepiente. No hay esperanza para que Efraím regrese a Dios.
		</p>
		");
	}


	private sealed class SecondCup01SE : ContentDetail
	{
		public SecondCup01SE() : base($"{nameof(Id.SecondCup01)}", Id.SecondCup01) { }
		public override int ParentId => Content.SecondCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span>
			Come back(repent) to me Ephraim and I will have MERCY on you --
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Jeremiah 31:20</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>20</sup>  
			“Is Ephraim My dear son? Indeed, as often as I have spoken against him, 
			I certainly still remember him; Therefore My inmost being yearns for him; I will surely have mercy on him,” declares Yehovah.
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>1 Peter 2:10</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>10</sup> ...” you had NOT RECEIVED MERCY, but now you have RECEIVED MERCY.”
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Jeremiah 12:15</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>15</sup> ... And after I have uprooted them , I will again have compassion on them...
		</p>

		<p class='fs-5'>
			<span class='text-danger fw-bold'>All Shout</span> 
			<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
			<i class='fas fa-long-arrow-alt-right'></i>
			DRINK THE CUP <i class='text-danger fas fa-wine-glass-alt'></i>
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> 
			Vuelve (arrepiéntete) a mí, Efraím, y tendré MISERICORDIA de ti --  
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Jeremías 31:20</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>20</sup>  
			“¿Es Efraím Mi hijo querido? En verdad, tantas veces como he hablado contra él, 
			ciertamente aún lo recuerdo; por eso Mis entrañas anhelan por él; seguramente tendré misericordia de él,” declara Yahvé. 
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>1 Pedro 2:10</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>10</sup> ...” no HABÍAN RECIBIDO MISERICORDIA, pero ahora HAN RECIBIDO MISERICORDIA.”
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Jeremías 12:15</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>15</sup> ... Y después de haberlos desarraigado, volveré a tener compasión de ellos....
		</p>
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Todos gritan</span> 
			<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
			<i class='fas fa-long-arrow-alt-right'></i>
			BEBEN LA COPA <i class='text-danger fas fa-wine-glass-alt'></i>
		</p>

		");
	}

	private sealed class SecondCup02SE : ContentDetail
	{
		public SecondCup02SE() : base($"{nameof(Id.SecondCup02)}", Id.SecondCup02) { }
		public override int ParentId => Content.SecondCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader:</span> 
			As a final fateful blow to Ephraim, the Northern Kingdom or House of Israel, were to lose their identity as Israel. 
			They would become <i>Lo-Ammi</i>, NOT MY PEOPLE. 
			They would be stripped of all associations with and memories of the God of Israel and in fact God says He will take from them the things of Torah, 
			since they had called the Torah and its instructions a strange thing. <br />
			<b>Hosea 2:11-12</b> says, “I will also  cease  all her joy, Her feasts, her new moons, her Sabbaths, and all her appointed times. 
			And I will make desolate her vines and fig trees. ...”
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector:</span> 
			Como un golpe final fatídico para Efraím, el Reino del Norte o Casa de Israel, debían perder su identidad como Israel. 
			Se convertirían en  <i>Lo-Ammi</i>, NO MI PUEBLO. 
			Serían despojados de todas las asociaciones y recuerdos del Dios de Israel y, de hecho, Dios dice que les quitará las cosas de la Torá, ya que habían llamado a la Torá 
			y sus instrucciones algo extraño. <br />
			<b>Oseas 2:11-12</b> dice: “También haré cesar toda su alegría, sus fiestas, sus lunas nuevas, sus sábados y todas sus citas señaladas. 
			Y dejaré desoladas sus viñas y sus higueras. ...”
		</p>
		");
	}

	private sealed class SecondCup03SE : ContentDetail
	{
		public SecondCup03SE() : base($"{nameof(Id.SecondCup03)}", Id.SecondCup03) { }
		public override int ParentId => Content.SecondCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader:</span> 
			But God has begun to restore Ephraim’s identity thru the gospel of the Kingdom message that Yeshua preached.
			Ephraim has not known who he is because of a long-term curse put upon him by God.
			The first step back in this process of return is to acknowledge Yeshua as LORD and savior and return to keeping His word.
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector:</span> 
			Pero Dios ha comenzado a restaurar la identidad de Efraím a través del mensaje del evangelio del Reino que Yeshua predicó. 
			Efraím no ha sabido quién es debido a una maldición a largo plazo impuesta por Dios. 
			El primer paso de regreso en este proceso de retorno es reconocer a Yeshua como SEÑOR y salvador y volver a guardar Su palabra.
		</p>
		");
	}


	private sealed class ThirdCup01SE : ContentDetail
	{
		public ThirdCup01SE() : base($"{nameof(Id.ThirdCup01)}", Id.ThirdCup01) { }
		public override int ParentId => Content.ThirdCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span>
			We are set-free to know our identity in Messiah, aka, in Israel 
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Hosea 1:9</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>9</sup>  
			And Yehovah said, “Name him Lo-ammi, for you are not My people, and I am not your God.” 
		</p>		

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>1 Peter 2:10</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>10</sup>  
			Which in time past were not a people, but are now the people of God...
		</p>		

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Hosea 1:10</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>10</sup>  
			...and it will be that in the place where it is said to them “You are not My people,” It will be said to them, “You are the sons of the living God.”
			<sup>(also Romans 9:25-26)</sup>
		</p>

		<p class='fs-5'>
			We embrace our new identity as the Israel of God, a people who had not known who they were for over 2730 years, but now we do.
			We toast to knowing our identity as the House of Israel thru the blood of Messiah Yeshua 
		</p>

		<p class='fs-5'>
			<span class='text-danger fw-bold'>All Shout</span> 
			<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
			<i class='fas fa-long-arrow-alt-right'></i>
			DRINK THE CUP <i class='text-danger fas fa-wine-glass-alt'></i>
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> 
			Somos liberados para conocer nuestra identidad en el Mesías, también conocida como en Israel. 
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Oseas 1:9</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>9</sup>  
			Y Yahvé dijo: “Nómbrenlo Lo-ammi, porque ustedes no son Mi pueblo, y Yo no soy su Dios.”
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>1 Peter 2:10</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>10</sup>  
			Que en tiempos pasados no eran un pueblo, pero ahora son el pueblo de Dios...
		</p>		

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Oseas 1:0</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>10</sup>  
			...Y será que en el lugar donde se les dijo “No son Mi pueblo,” se les dirá, “Son los hijos del Dios viviente.”
			<sup>(también Romanos 9:25-26)</sup>  
		</p>		

		<p class='fs-5'>
			Abrazamos nuestra nueva identidad como el Israel de Dios, un pueblo que no sabía quiénes eran durante más de 2730 años, pero ahora lo sabemos.
			Brindamos por conocer nuestra identidad como la Casa de Israel a través de la sangre del Mesías Yeshua
		</p>
		
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Todos gritan</span> 
			<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
			<i class='fas fa-long-arrow-alt-right'></i>
			BEBEN LA COPA <i class='text-danger fas fa-wine-glass-alt'></i>
		</p>
		");
	}

	private sealed class ThirdCup02SE : ContentDetail
	{
		public ThirdCup02SE() : base($"{nameof(Id.ThirdCup02)}", Id.ThirdCup02) { }
		public override int ParentId => Content.ThirdCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Reader:</span> 
			Very closely aligned with a return to identity is the keeping of God’s instructions. 
			We just  read that Ephraim had called God’s Torah a strange thing in Hosea.
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Jeremiah 31:19</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>19</sup>
			“For after my turning back I repented, And after I was instructed I slapped myself on the thigh. 
			I was ashamed and even humiliated because I carried the disgrace of my youth [as a nation]”
		</p>		

		<p class='fs-5'>
			Our testimonies of returning to God’s Instructions confirm this call to be the born again Ephraim because of his renewed covenant.
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Psalms 78:9-11</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>11</sup>
			The children of Ephraim  didn't keep God's covenant, and refused to walk in his law. They forgot his acts; His wondrous works that he had shown them. 
		</p>		
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>Lector:</span> 
			Muy alineado con un retorno a la identidad está el guardar las instrucciones de Dios. 
			Acabamos de leer que Efraím había llamado a la Torá de Dios algo extraño en Oseas.
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Jeremías 31:19</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>19</sup>
			“Porque después de mi regreso me arrepentí, y después de ser instruido me golpeé el muslo. 
			Me avergoncé y hasta me humillé porque cargué con la desgracia de mi juventud [como nación].”
		</p>

		<p class='fs-5'>
			Nuestros testimonios de regresar a las Instrucciones de Dios confirman este llamado a ser el Efraím nacido de nuevo debido a su nuevo pacto.
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Salmo 78:9-11</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>11</sup>
			Los hijos de Efraím no guardaron el pacto de Dios y se negaron a caminar en su ley. Olvidaron sus actos; Sus obras maravillosas que les había mostrado.
		</p>		
		");
	}


	private sealed class FourthCup01SE : ContentDetail
	{
		public FourthCup01SE() : base($"{nameof(Id.FourthCup01)}", Id.FourthCup01) { }
		public override int ParentId => Content.FourthCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span>
			(there is Liberty in God's perfect Law)
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>James 1:25</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>25</sup>  
			But the one who looks into the perfect law, the law of liberty, and perseveres, being no hearer who forgets but a doer who acts, he will be blessed in his doing.
		</p>

		<ul class='fs-5'>
			<li>We are set-free to know God's Holy instructions.</li>
			<li>Ephraim can now call God's instructions good, right, holy and spiritual.</li>
			<li>We can say with David in Psalm 119</li>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> 
			(hay Libertad en la Ley perfecta de Dios)
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Santiago 1:25</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>25</sup>  
			Pero el que mira en la ley perfecta, la ley de la libertad, y persevera, no siendo un oidor que olvida sino un hacedor que actúa, será bendecido en su hacer.
		</p>

		<ul class='fs-5'>
			<li>Somos liberados para conocer las Santas instrucciones de Dios.</li>
			<li>Efraím ahora puede llamar a las instrucciones de Dios buenas, justas, santas y espirituales.</li>
			<li>Podemos decir con David en Salmo 119:12-16:</li>
		");
	}

	private sealed class FourthCup02SE : ContentDetail
	{
		public FourthCup02SE() : base($"{nameof(Id.FourthCup02)}", Id.FourthCup02) { }
		public override int ParentId => Content.FourthCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>All Read:</span> 
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Psalm 119:12-16</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>12</sup>
			Blessed are You, O Yehovah; Teach me Your statutes.
			<sup class='text-primary fw-bold'>13</sup>
			With my lips I have recounted All the judgments of Your mouth.
			<sup class='text-primary fw-bold'>14</sup>
			I have rejoiced in the way of Your testimonies, As much as in all riches.
			<sup class='text-primary fw-bold'>15</sup>
			I will muse upon Your precepts And look upon Your ways.
			<sup class='text-primary fw-bold'>16</sup>
			I shall delight in Your statutes; I shall not forget Your word.
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>All Leer:</span> 
		</p>

		<p class='bg-primary-subtle fs-5 p-2 ms-3'>
			<b>Salmo 119:12-16</b><br />
			<i class='fas fa-quote-left'></i> 
			<sup class='text-primary fw-bold'>12</sup>
			Bendito eres Tú, Oh Yahvé; Enséñame Tus estatutos.
			<sup class='text-primary fw-bold'>13</sup>
			Con mis labios he relatado Todos los juicios de Tu boca.
			<sup class='text-primary fw-bold'>14</sup>
			Me he regocijado en el camino de Tus testimonios, Tanto como en todas las riquezas.
			<sup class='text-primary fw-bold'>15</sup>
			Meditaré en Tus preceptos Y miraré Tus caminos.
			<sup class='text-primary fw-bold'>16</sup>
			Me deleitaré en Tus estatutos; No olvidaré Tu palabra.
		</p>
		");
	}

	private sealed class FourthCup03SE : ContentDetail
	{
		public FourthCup03SE() : base($"{nameof(Id.FourthCup03)}", Id.FourthCup03) { }
		public override int ParentId => Content.FourthCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Leader:</span>
			 We toast to joyfully to receiving God’s Holy Instructions 
		</p>
		
		<p class='fs-5'>
			<span class='text-danger fw-bold'>All Shout</span> 
			<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
			<i class='fas fa-long-arrow-alt-right'></i>
			DRINK THE CUP <i class='text-danger fas fa-wine-glass-alt'></i>
		</p>

		<p class='fs-5'>
			 By our redemption thru the power of the blood of the Lamb of God and the giving of His Holy Spirit we have been set-free 
			 from the bondage of the sins that caused Ephraim Israel to be divorced from Yehovah and sifted among the nations. WE HAVE BEEN REDEEMED!
		</p>

		<p class='fs-5'>
			We will all say together this phrase for each item 1-10, one at a time:	
		</p>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-success fw-bold'>Líder:</span> 
			Brindamos con alegría por recibir las Santas Instrucciones de Dios  
		</p>

		<p class='fs-5'>
			<span class='text-danger fw-bold'>Todos gritan</span> 
			<span class='badge bg-danger text-white'> L'Chaim <i class='fas fa-exclamation'></i></span> 
			<i class='fas fa-long-arrow-alt-right'></i>
			BEBEN LA COPA <i class='text-danger fas fa-wine-glass-alt'></i>
		</p>


		<p class='fs-5'>
			 Por nuestra redención a través del poder de la sangre del Cordero de Dios y la entrega de Su Espíritu Santo, hemos sido liberados 
			 de la esclavitud de los pecados que causaron que Efraím Israel fuera divorciado de Yahvé y tamizado entre las naciones. ¡HEMOS SIDO REDIMIDOS!
		</p>

		<p class='fs-5'>
			Todos diremos juntos esta frase para cada ítem del 1 al 10, uno a la vez:
		</p>
		");
	}

	private sealed class FourthCup04SE : ContentDetail
	{
		public FourthCup04SE() : base($"{nameof(Id.FourthCup04)}", Id.FourthCup04) { }
		public override int ParentId => Content.FourthCup;
		public override MarkupString EngBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>All Shout</span> <i class='fas fa-level-down-alt'></i>
		</p>

		<div class='bg-danger-subtle p-2'>
			<p class='fs-5 fst-italic'>
				By His blood we have been set-free from... <u>1-10</u> ...<b>HalleluYah!</b>
			</p>
			<ol class='fs-5'>
				<li>...sin & rebellion</li>
				<li>...anger, bitterness & resentment</li>
				<li>...fear</li>
				<li>...division (from Judah)</li>
				<li>...lies  - (from false teachers and our forefathers)</li>
				<li>...false religious systems with their false gods and false holidays,</li>
				<li>...curses - (the long term curses put on us by Yehovah because of our rebellion)</li>
				<li>...blindness  -  (anti Torah beliefs and identity)</li>
				<li>...calling ourselves gentiles (identity)</li>
				<li>...being jealous of Judah, anti Judah attitudes and behavior</li>
			</ol>
		</div>
		");

		public override MarkupString EspBody => (MarkupString)(@"
		<p class='fs-5'>
			<span class='text-danger fw-bold'>All Gritan:</span> <i class='fas fa-level-down-alt'></i>
		</p>

		<div class='bg-danger-subtle p-2'>
			<p class='fs-5 fst-italic'>
				Por Su sangre hemos sido liberados de... <u>1-10</u>, ...<b>¡HalleluYah!</b>
			</p>

			<ol class='fs-5'>
				<li>...pecado y rebelión  </li>
				<li>...ira, amargura y resentimiento</li>
				<li>...miedo</li>
				<li>...división (de Judá)</li>
				<li>...mentiras - (de falsos maestros y nuestros antepasados)</li>
				<li>...sistemas religiosos falsos con sus dioses falsos y fiestas falsas,</li>
				<li>...maldiciones - (las maldiciones a largo plazo puestas sobre nosotros por Yahvé debido a nuestra rebelión)</li>
				<li>...ceguera - (creencias e identidad anti-Torá)</li>
				<li>...llamarnos gentiles (identidad)</li>
				<li>...estar celosos de Judá, actitudes y comportamientos anti-Judá</li>
			</ol>
		</div>
		");
	}


	private sealed class CharosetSE : ContentDetail
	{
		public CharosetSE() : base($"{nameof(Id.Charoset)}", Id.Charoset) { }
		public override int ParentId => Content.Charoset;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-success fw-bold'>Leader:</span> 
				Now we enjoy the sweetness of Freedom and Salvation 
				Blessed are You, LORD our God and Messiah Yeshua for allowing us to taste the sweetness of freedom and setting us free from the sins of Jeroboam. In Yeshua’s Name we pray. 
			</p>
			<p class='fs-5'>EAT SOME SWEET CHAROSETW/MATZAH</p>

			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-success fw-bold'>Líder:</span> 
				Ahora disfrutamos de la dulzura de la Libertad y la Salvación  
				Bendito eres Tú, SEÑOR nuestro Dios y Mesías Yeshua por permitirnos saborear la dulzura de la libertad y liberarnos de los pecados de Jeroboam. 
				En el Nombre de Yeshua oramos.
			</p>
			
			<p class='fs-5'>
			</p>
			
			");
	}


	private sealed class Dinner01SE : ContentDetail
	{
		public Dinner01SE() : base($"{nameof(Id.Dinner01)}", Id.Dinner01) { }
		public override int ParentId => Content.Dinner;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>All:</span> 
				Blessing God AFTER the meal
			</p>

			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Deuteronomy 8:10</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>10</sup>  
					Blessed are You, Yehovah our Elohim, King of the universe, who feeds the entire world in His goodness, 
					with grace, with kindness, with mercy. He gives food to all flesh, His kindness forever it endures. 
					And through His great goodness we have never lacked, may we never lack for food for all of eternity.  
					For the sake of His great Name, because He is God who feeds and sustains and benefits all and prepares food for all of His creatures which He has created. 
					Blessed are You, Yehovah, Who feeds all. 
					Amein.
			</p>	
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Todos:</span> 
				Bendiciendo a Dios DESPUÉS de la comida
			</p>

			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Deuteronomio 8:10</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>10</sup>  
				Bendito eres Tú, Yahvé nuestro Elohim, Rey del universo, quien alimenta al mundo entero en Su bondad, con gracia, 
				con bondad, con misericordia. Él da comida a toda carne, Su bondad para siempre perdura. 
				Y por Su gran bondad nunca nos ha faltado, que nunca nos falte comida por toda la eternidad. 
				Por el bien de Su gran Nombre, porque Él es Dios que alimenta y sostiene y beneficia a todos y prepara comida para todas Sus criaturas que Él ha creado. 
				Bendito eres Tú, Yahvé, Quien alimenta a todos. 
				Amén.
			</p>	
			");
	}

	private sealed class Dinner02SE : ContentDetail
	{
		public Dinner02SE() : base($"{nameof(Id.Dinner02)}", Id.Dinner02) { }
		public override int ParentId => Content.Dinner;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span> 
				In our Renewed Covenant redemption, we are called to become a Holy people and a nation who was once an unholy nation.  
				We are called to be obedient children.  				
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>1 Peter 1:14-15</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>14</sup>  
				“As obedient children, do not conform to the evil desires of your former ignorance,  
				<sup class='text-primary fw-bold'>15</sup>  
				but like the Holy One who called you, be holy yourselves also in all your behavior.” 
			</p>	
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span> 
				En nuestra redención del Nuevo Pacto, estamos llamados a convertirnos en un pueblo santo y una nación que antes era una nación impía. 
				Estamos llamados a ser hijos obedientes.
			</p>

			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>1 Pedro 1:14-15</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>14</sup>  
				“Como hijos obedientes, no se conformen a los deseos malignos de su antigua ignorancia, 
				<sup class='text-primary fw-bold'>15</sup>
				sino como el Santo que los llamó, sean santos también en todo su comportamiento.”
			</p>	
			");
	}

	private sealed class Dinner03SE : ContentDetail
	{
		public Dinner03SE() : base($"{nameof(Id.Dinner03)}", Id.Dinner03) { }
		public override int ParentId => Content.Dinner;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span> 
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Leviticus 20:7-8</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>7</sup>  
				And you shall set yourselves apart, and shall be set apart, for I am Yehovah your Elohim, and you shall guard My laws and do them. 
				<sup class='text-primary fw-bold'>8</sup>  
				I am Yehovah, Who sets you apart.
			</p>	
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span> 
			</p>

			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Levítico 20:7-8</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>7</sup>  
				Y ustedes se apartarán, y estarán apartados, porque Yo soy Yahvé su Elohim,
				<sup class='text-primary fw-bold'>8</sup>
				y guardarán Mis leyes y las harán. Yo soy Yahvé, Quien los aparta.
			</p>	
			");
	}

	private sealed class Dinner04SE : ContentDetail
	{
		public Dinner04SE() : base($"{nameof(Id.Dinner04)}", Id.Dinner04) { }
		public override int ParentId => Content.Dinner;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span> 
			</p>
			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Hosea 14:4-5</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>4</sup>  
				I will heal their turning away from Me; I will love them freely, For My anger has turned away from them
				<sup class='text-primary fw-bold'>5</sup>  
				I will be like the dew to Israel; He will flourish like the lily, And he will [fn]take root like the cedars of Lebanon
			</p>	
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span> 
			</p>

			<p class='bg-primary-subtle fs-5 p-2 ms-3'>
				<b>Oseas 14:4-5</b><br />
				<i class='fas fa-quote-left'></i> 
				<sup class='text-primary fw-bold'>4</sup>  
				Sanaré su apartamiento de Mí; los amaré libremente, porque Mi ira se ha apartado de ellos.
				<sup class='text-primary fw-bold'>5</sup>
				Seré como el rocío para Israel; florecerá como el lirio, y echará raíces como los cedros del Líbano.
			</p>	
			");
	}


	private sealed class FifthCup01SE : ContentDetail
	{
		public FifthCup01SE() : base($"{nameof(Id.FifthCup01)}", Id.FifthCup01) { }
		public override int ParentId => Content.FifthCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}


	private sealed class SixthCup01SE : ContentDetail
	{
		public SixthCup01SE() : base($"{nameof(Id.SixthCup01)}", Id.SixthCup01) { }
		public override int ParentId => Content.SixthCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SixthCup02SE : ContentDetail
	{
		public SixthCup02SE() : base($"{nameof(Id.SixthCup02)}", Id.SixthCup02) { }
		public override int ParentId => Content.SixthCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SixthCup03SE : ContentDetail
	{
		public SixthCup03SE() : base($"{nameof(Id.SixthCup03)}", Id.SixthCup03) { }
		public override int ParentId => Content.SixthCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SixthCup04SE : ContentDetail
	{
		public SixthCup04SE() : base($"{nameof(Id.SixthCup04)}", Id.SixthCup04) { }
		public override int ParentId => Content.SixthCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SixthCup05SE : ContentDetail
	{
		public SixthCup05SE() : base($"{nameof(Id.SixthCup05)}", Id.SixthCup05) { }
		public override int ParentId => Content.SixthCup;
		public override MarkupString EngBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Reader:</span>
			</p>
			<p class='fs-5'>
			It is not enough to be reconciled to our God, for our destiny in not heaven,  but a return to our covenant land. 
			The reunion with Judah will most likely be in the Land under the authority of the King. 
			This is when the One New Man is finally manifest. It is another way of saying the One Stick in the Father’s hand is the One New Man mentioned by Paul in <u>Ephesians 2:15</u>. 
			The One New Man is the Israel of Yehovah! HalelluYah!.
			</p>
			");
		public override MarkupString EspBody => (MarkupString)(@"
			<p class='fs-5'>
				<span class='text-danger fw-bold'>Lector:</span>
			</p>
			<p class='fs-5'>
				No basta con reconciliarnos con nuestro Dios, porque nuestro destino no es el cielo, sino un regreso a nuestra tierra del pacto. 
				La reunión con Judá probablemente será en la Tierra bajo la autoridad del Rey. 
				Aquí es cuando el Hombre Nuevo finalmente se manifiesta. Es otra forma de decir que el Palo Único en la mano del Padre es el Hombre Nuevo mencionado por Pablo en Efesios 2:15.
				¡El Hombre Nuevo es el Israel de Yahvé! ¡HalleluYah!
			</p>
			");
	}

	private sealed class SixthCup06SE : ContentDetail
	{
		public SixthCup06SE() : base($"{nameof(Id.SixthCup06)}", Id.SixthCup06) { }
		public override int ParentId => Content.SixthCup;
		public override MarkupString EngBody => (MarkupString)(@"
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

			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}


	private sealed class SeventhCup01SE : ContentDetail
	{
		public SeventhCup01SE() : base($"{nameof(Id.SeventhCup01)}", Id.SeventhCup01) { }
		public override int ParentId => Content.SeventhCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SeventhCup02SE : ContentDetail
	{
		public SeventhCup02SE() : base($"{nameof(Id.SeventhCup02)}", Id.SeventhCup02) { }
		public override int ParentId => Content.SeventhCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SeventhCup03SE : ContentDetail
	{
		public SeventhCup03SE() : base($"{nameof(Id.SeventhCup03)}", Id.SeventhCup03) { }
		public override int ParentId => Content.SeventhCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SeventhCup04SE : ContentDetail
	{
		public SeventhCup04SE() : base($"{nameof(Id.SeventhCup04)}", Id.SeventhCup04) { }
		public override int ParentId => Content.SeventhCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SeventhCup05SE : ContentDetail
	{
		public SeventhCup05SE() : base($"{nameof(Id.SeventhCup05)}", Id.SeventhCup05) { }
		public override int ParentId => Content.SeventhCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SeventhCup06SE : ContentDetail
	{
		public SeventhCup06SE() : base($"{nameof(Id.SeventhCup06)}", Id.SeventhCup06) { }
		public override int ParentId => Content.SeventhCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class SeventhCup07SE : ContentDetail
	{
		public SeventhCup07SE() : base($"{nameof(Id.SeventhCup07)}", Id.SeventhCup07) { }
		public override int ParentId => Content.SeventhCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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

			");
	}


	private sealed class SeventhCup08SE : ContentDetail
	{
		public SeventhCup08SE() : base($"{nameof(Id.SeventhCup08)}", Id.SeventhCup08) { }
		public override int ParentId => Content.SeventhCup;
		public override MarkupString EngBody => (MarkupString)(@"
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
			");
		public override MarkupString EspBody => (MarkupString)(@"
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
			");
	}

	private sealed class NextYearSE : ContentDetail
	{
		public NextYearSE() : base($"{nameof(Id.NextYear)}", Id.NextYear) { }
		public override int ParentId => Content.NextYear;
		public override MarkupString EngBody => (MarkupString)(@"
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
		");
		public override MarkupString EspBody => (MarkupString)(@"
		");
	}
	#endregion

}

// Ignore Spelling: Matzah Charoset