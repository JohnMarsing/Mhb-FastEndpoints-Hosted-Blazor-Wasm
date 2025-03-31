using Blazored.LocalStorage;
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
	private const string KeyPickerDebug = "bc-picker-debug";
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private AbrvChapterVerse _DefaultAbrvChapterVerse = new("Gen", 1, 1, true, 0); //"Gen", 1, 1, 1);
	private AbrvChapterVerse? _AbrvChapterVerse = new("Gen", 1, 1, true, 0);  //"Gen", 1, 1, 1);

	private bool _DefaultKeyPickerDebug = false;
	private bool _PickerDebug = false;

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

			var pd = await localStorage!.GetItemAsync<bool?>(KeyPickerDebug);
			if (pd is not null)
			{
				_PickerDebug = pd.Value;
				//await TogglePickerDebug();
			}
			else
			{
				_PickerDebug = _DefaultKeyPickerDebug;
				await TogglePickerDebug();
			}


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


	public bool GetPickerDebug()
	{
		return _PickerDebug!;
	}

	public async Task TogglePickerDebug()
	{
		_PickerDebug = !_PickerDebug;
		await localStorage!.SetItemAsync(KeyPickerDebug, _PickerDebug);
		NotifyStateHasChanged();
	}
}
// Ignore Spelling: ctor, DI, Abrv, brv, BCV, ACV, bc, toolbar
