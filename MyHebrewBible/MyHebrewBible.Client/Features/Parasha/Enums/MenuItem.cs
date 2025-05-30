using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Parasha.Enums;


public abstract class MenuItem : SmartEnum<MenuItem>
{
	#region Id's
	private static class Id
	{
		internal const int Instructions = 1;
		internal const int ParashaList = 2;
	}
	#endregion

	#region Declared Public Instances
	public static readonly MenuItem Instructions = new InstructionsSE();
	public static readonly MenuItem ParashaList = new ParashaListSE();
	#endregion

	private MenuItem(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields 
	public abstract string Title { get; }
	
	/*
	//Properties 
	public string CardHeader => $"<h3 class='{HeaderColor}'<b>{Title}</b></h3>";
	*/

	#endregion


	private sealed class InstructionsSE : MenuItem
	{
		public InstructionsSE() : base(nameof(Instructions), Id.Instructions) { }
		public override string Title => "Instructions";
	}
		
	private sealed class ParashaListSE : MenuItem
	{
		public ParashaListSE() : base(nameof(ParashaList), Id.ParashaList) { }
		public override string Title => "Parasha List"; // Show Debug or Hide Debug
	}
	
}
