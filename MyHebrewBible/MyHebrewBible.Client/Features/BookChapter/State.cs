﻿using Blazored.LocalStorage;
using MyHebrewBible.Client.State;

namespace MyHebrewBible.Client.Features.BookChapter;

public class State
{
	//private readonly ILocalStorageService? localStorage;

	#region Constructor and DI
	private readonly ILogger Logger;
	private readonly ILocalStorageService? localStorage;
	public State(ILocalStorageService localStorage, ILogger<AppState> logger)  //BookChapterState
	{
		this.localStorage = localStorage;
		Logger = logger;
		//Logger!.LogInformation("{MethodEvent}", "CTOR");
	}
	#endregion

	private const string KeyACVId = "bc-abrv-chapter-verse-id";
	private const string KeyToolbar = "bc-toolbar";
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private AbrvChapterVerse _DefaultAbrvChapterVerse = new("Gen", 1, 1, true, 0); //"Gen", 1, 1, 1);
	private AbrvChapterVerse? _AbrvChapterVerse = new("Gen", 1, 1, true, 0);  //"Gen", 1, 1, 1);

	//public const string ToolbarNumericPad = "numeric-pad";
	//public const string ToolbarDynamicButtons = "dynamic-buttons";
	//private string _DefaultToolbar = ToolbarNumericPad;

	//private Enums.MenuItem _DefaultMenuItem = Enums.MenuItem.ShowDebugPicker;
	//private Enums.MenuItem _MenuItem; 

	public async Task Initialize()
	{
		if (!_isInitialized)
		{
			_AbrvChapterVerse = await localStorage!.GetItemAsync<AbrvChapterVerse>(KeyACVId);
			if (_AbrvChapterVerse is not null)
			{
				await UpdateACV(_AbrvChapterVerse);
			}
			else
			{
				_AbrvChapterVerse = _DefaultAbrvChapterVerse;
				await UpdateACV(_DefaultAbrvChapterVerse);
			}

			//_MenuItem = await localStorage!.GetItemAsync<string>(KeyToolbar) ?? _DefaultMenuItem;
			//if (!String.IsNullOrEmpty(_MenuItem))
			//{
			//	await UpdateToolbar(_MenuItem);
			//}
			//else
			//{
			//	_MenuItem = _DefaultMenuItem;
			//	await UpdateToolbar(_DefaultMenuItem);
			//}



			_isInitialized = true;

		}
	}

	public AbrvChapterVerse GetACV()
	{
		//Logger!.LogInformation("{Method}, _AbrvChapterVerse: {AbrvChapterVerse}", "Get", _AbrvChapterVerse);
		return _AbrvChapterVerse!;
	}

	public async Task UpdateACV(AbrvChapterVerse abrvChapterVerse)
	{
		//Logger!.LogInformation("{Method}, brvChapterVerse: {AbrvChapterVerse}", "Update", abrvChapterVerse);
		await localStorage!.SetItemAsync(KeyACVId, abrvChapterVerse);
		_AbrvChapterVerse = abrvChapterVerse;
		NotifyStateHasChanged();
	}


	//public Enums.MenuItem GetShowDebugPicker()
	//{
	//	return _MenuItem!;
	//}

	//public async Task UpdateToolbar(Enums.MenuItem showDebugPicker)
	//{
	//	await localStorage!.SetItemAsync(KeyToolbar, showDebugPicker);
	//	_MenuItem = showDebugPicker;
	//	NotifyStateHasChanged();
	//}

}
// Ignore Spelling: ctor, DI, Abrv, brv, BCV, ACV, bc, toolbar
