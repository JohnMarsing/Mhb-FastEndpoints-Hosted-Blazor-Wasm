
namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class PlaceValueRecHelper // static
{
	/* 
	OnesPlaceZeroButtonIsDisabled
	True if...
	- both the parent (10's) and grand parent (100's) are null 
	- the parent (10's) already selected 0
	*/
	public static bool OnesPlaceZeroButtonIsDisabled(PlaceValueRec place)
	{
		if (place.Hundreds is null && place.Tens is null)
		{
			return true;
		}
		else
		{
			if (place.Tens == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}


	public static string Concatenate(PlaceValueRec place)
	{
		return $"Hun:{(place.Hundreds is null ? "X" : place.Hundreds)}, Tens:{(place.Tens is null ? "X" : place.Tens)}, Ones:{place.Ones}"; // , W:{(place.IsWhole ? "T" : "F")}
	}

	private static int EvalNullValues(int? hundredsOrTens)
	{
		if (hundredsOrTens is null) { return 0; }
		int i = (int)hundredsOrTens;
		return i == -1 ? 0 : i;
	}

	public static int Combine(PlaceValueRec place)
	{
		return EvalNullValues(place.Hundreds) * 100 + EvalNullValues(place.Tens) * 10 + place.Ones;
	}

}

