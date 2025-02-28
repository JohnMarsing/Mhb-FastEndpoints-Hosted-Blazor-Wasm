namespace MyHebrewBible.Client.Enums;

public class BibleBookDictionary
{

	public static (string, int) GetId(string abrv)
	{
		if (_dictionary.TryGetValue(abrv, out int id))
		{
			return ("", id);	
		}
		else
		{
			return ($"{nameof(BibleBook)} abrv: {abrv} NOT FOUND?  (◡︵◡); inside: {nameof(BibleBookDictionary)}!{nameof(GetId)}", 0); 
		}
	}

	private static readonly Dictionary<string, int> _dictionary = new()
	{
		[BibleBook.Genesis.Abrv] = 1,
		[BibleBook.Exodus.Abrv] = 2,
		[BibleBook.Leviticus.Abrv] = 3,
		[BibleBook.Numbers.Abrv] = 4,
		[BibleBook.Deuteronomy.Abrv] = 5,
		[BibleBook.Joshua.Abrv] = 6,
		[BibleBook.Judges.Abrv] = 7,
		[BibleBook.Ruth.Abrv] = 8,
		[BibleBook.FirstSamuel.Abrv] = 9,
		[BibleBook.SecondSamuel.Abrv] = 10,
		[BibleBook.FirstKings.Abrv] = 11,
		[BibleBook.SecondKings.Abrv] = 12,
		[BibleBook.FirstChronicles.Abrv] = 13,
		[BibleBook.SecondChronicles.Abrv] = 14,
		[BibleBook.Ezra.Abrv] = 15,
		[BibleBook.Nehemiah.Abrv] = 16,
		[BibleBook.Esther.Abrv] = 17,
		[BibleBook.Job.Abrv] = 18,
		[BibleBook.Psalms.Abrv] = 19,
		[BibleBook.Proverbs.Abrv] = 20,
		[BibleBook.Ecclesiastes.Abrv] = 21,
		[BibleBook.SongofSolomon.Abrv] = 22,
		[BibleBook.Isaiah.Abrv] = 23,
		[BibleBook.Jeremiah.Abrv] = 24,
		[BibleBook.Lamentations.Abrv] = 25,
		[BibleBook.Ezekiel.Abrv] = 26,
		[BibleBook.Daniel.Abrv] = 27,
		[BibleBook.Hosea.Abrv] = 28,
		[BibleBook.Joel.Abrv] = 29,
		[BibleBook.Amos.Abrv] = 30,
		[BibleBook.Obadiah.Abrv] = 31,
		[BibleBook.Jonah.Abrv] = 32,
		[BibleBook.Micah.Abrv] = 33,
		[BibleBook.Nahum.Abrv] = 34,
		[BibleBook.Habakkuk.Abrv] = 35,
		[BibleBook.Zephaniah.Abrv] = 36,
		[BibleBook.Haggai.Abrv] = 37,
		[BibleBook.Zechariah.Abrv] = 38,
		[BibleBook.Malachi.Abrv] = 39,
		[BibleBook.Matthew.Abrv] = 40,
		[BibleBook.Mark.Abrv] = 41,
		[BibleBook.Luke.Abrv] = 42,
		[BibleBook.John.Abrv] = 43,
		[BibleBook.Acts.Abrv] = 44,
		[BibleBook.Romans.Abrv] = 45,
		[BibleBook.FirstCorinthians.Abrv] = 46,
		[BibleBook.SecondCorinthians.Abrv] = 47,
		[BibleBook.Galatians.Abrv] = 48,
		[BibleBook.Ephesians.Abrv] = 49,
		[BibleBook.Philippians.Abrv] = 50,
		[BibleBook.Colossians.Abrv] = 51,
		[BibleBook.FirstThessalonians.Abrv] = 52,
		[BibleBook.SecondThessalonians.Abrv] = 53,
		[BibleBook.FirstTimothy.Abrv] = 54,
		[BibleBook.SecondTimothy.Abrv] = 55,
		[BibleBook.Titus.Abrv] = 56,
		[BibleBook.Philemon.Abrv] = 57,
		[BibleBook.Hebrews.Abrv] = 58,
		[BibleBook.James.Abrv] = 59,
		[BibleBook.FirstPeter.Abrv] = 60,
		[BibleBook.SecondPeter.Abrv] = 61,
		[BibleBook.FirstJohn.Abrv] = 62,
		[BibleBook.SecondJohn.Abrv] = 63,
		[BibleBook.ThirdJohn.Abrv] = 64,
		[BibleBook.Jude.Abrv] = 65,
		[BibleBook.Revelation.Abrv] = 66
	};
}
