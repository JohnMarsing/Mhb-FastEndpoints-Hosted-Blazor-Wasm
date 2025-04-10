using Blazored.LocalStorage;
using MyHebrewBible.Client.State;
using GlobalEnums = MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.BookChapter.Toolbar;

namespace MyHebrewBible.Client.Features.Haggadah;

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

	private const string KeyHaggadah = "hag-lang-id";

	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private int _LanguageId;

	public async Task Initialize()
	{
		if (!_isInitialized)
		{
			int? i = await localStorage!.GetItemAsync<int>(KeyHaggadah);
			if (i is null || i == 0)
			{
				await UpdateLanguage(Enums.DisplayLanguage.English.Value);  // _DefaultLanguageId;
			}
			else
			{
				_LanguageId = i.Value;
			}
			_isInitialized = true;
		}
	}

	public async Task UpdateLanguage(int languageId)
	{
		_LanguageId = languageId;
		await localStorage!.SetItemAsync(KeyHaggadah, _LanguageId);
		NotifyStateHasChanged();
	}
	
	public int Get()
	{
		//Logger!.LogInformation("{Method}, permutation: {permutation}", nameof(Get), _permutation); // DEBUG 
		return _LanguageId;
	}
}
