﻿using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.BookChapter.Enums;


public abstract class MenuItem : SmartEnum<MenuItem>
{
	#region Id's
	private static class Id
	{
		internal const int Edit = 1;
		internal const int Instructions = 2;
	}
	#endregion

	#region Declared Public Instances
	public static readonly MenuItem Edit = new EditSE();
	public static readonly MenuItem Instructions = new InstructionsSE();
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



	private sealed class EditSE : MenuItem
	{
		public EditSE() : base(nameof(Edit), Id.Edit) { }
		public override string Title => "Change Toolbar";
	}

	private sealed class InstructionsSE : MenuItem
	{
		public InstructionsSE() : base(nameof(Instructions), Id.Instructions) { }
		public override string Title => "Show Instructions";
	}
}
