using MyHebrewBible.Client.Features.BookChapter.Enums;

namespace MyHebrewBible.Client.Features.BookChapter.Toolbar.NumberPad;

public class PlaceValue
{
	public int Hundreds;
	public int Tens;
	public int Ones;

	public int Combine()
	{
		int hp = Hundreds == -1 ? 0 : Hundreds;
		int tp = Tens == -1 ? 0 : Tens;
		return (hp * 100) + (tp * 10) + Ones;
	}

	public void ResetAll()
	{
		Hundreds = -1;
		Tens = -1;
		Ones = -1;
	}
}