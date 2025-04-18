using Ardalis.SmartEnum;
using MyHebrewBible.Client.Features.Haggadah;


namespace MyHebrewBible.Client.Features.Haggadah.Enums;

public abstract class ContentDetailDELETE : SmartEnum<ContentDetailDELETE>
{
	#region Id's
	private static class Id
	{
		
	}
	#endregion


	#region  Declared Public Instances

	#endregion


	private ContentDetailDELETE(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract int ParentId { get; }
	public abstract string EngBody { get; }
	public abstract string EspBody { get; }
	#endregion

	#region Private Instantiation



	#endregion

}

// Ignore Spelling: Matzah Charoset