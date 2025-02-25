using Blazored.LocalStorage;
using MyHebrewBible.Client.Features.BookChapter;

namespace MyHebrewBible.Client.State.BookChapter;

public class BookChapterState
{
	//private readonly ILocalStorageService? localStorage;

	#region Constructor and DI
	private readonly ILogger Logger;
	private readonly ILocalStorageService? localStorage;
	public BookChapterState(ILocalStorageService localStorage, ILogger<AppState> logger)  //BookChapterState
	{
		this.localStorage = localStorage;
		Logger = logger;
		//Logger!.LogInformation("{MethodEvent}", "CTOR");
	}
	#endregion

	private const string Key = "bc-abrv-chapter-verse-id";
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private AbrvChapterVerse _DefaultAbrvChapterVerse = new("Gen", 1, 1, 0); //"Gen", 1, 1, 1);
	private AbrvChapterVerse? _AbrvChapterVerse = new("Gen", 1, 1, 0);  //"Gen", 1, 1, 1);

	public async Task Initialize()
	{
		if (!_isInitialized)
		{
			_AbrvChapterVerse = await localStorage!.GetItemAsync<AbrvChapterVerse>(Key);
			if (_AbrvChapterVerse is not null)
			{
				await Update(_AbrvChapterVerse);
			}
			else
			{
				_AbrvChapterVerse = _DefaultAbrvChapterVerse;
				await Update(_DefaultAbrvChapterVerse);
			}

			_isInitialized = true;

		}
	}

	public AbrvChapterVerse Get()
	{
		//Logger!.LogInformation("{Method}, _AbrvChapterVerse: {AbrvChapterVerse}", "Get", _AbrvChapterVerse);
		return _AbrvChapterVerse!;
	}

	public async Task Update(AbrvChapterVerse abrvChapterVerse)
	{
		//Logger!.LogInformation("{Method}, brvChapterVerse: {AbrvChapterVerse}", "Update", abrvChapterVerse);
		await localStorage!.SetItemAsync(Key, abrvChapterVerse);
		_AbrvChapterVerse = abrvChapterVerse;
		NotifyStateHasChanged();
	}

}
