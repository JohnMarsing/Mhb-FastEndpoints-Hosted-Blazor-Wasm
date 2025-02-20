using Blazored.LocalStorage;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.State.BookChapter;

public class BookChapterState
{
	//private readonly ILocalStorageService? localStorage;

	#region Constructor and DI
	private readonly ILogger Logger;
	private readonly ILocalStorageService? localStorage;
	public BookChapterState(ILocalStorageService localStorage, ILogger<AppState> logger)
	{
		this.localStorage = localStorage;
		Logger = logger;
		//Logger!.LogInformation("{Class}!{MethodEvent}", nameof(ParashaState), "CTOR");
	}
	#endregion

	private const string Key = "biblebookidandchapter"; // Ignore Spelling: biblebookidandchapter
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private BibleBookIdAndChapter _defaultBibleBookIdAndChapter = new(BibleBook.Genesis.Value, 1, 1, "Gen-1-1-1");
	private BibleBookIdAndChapter? _bibleBookIdAndChapter;

	public async Task Initialize()
	{
		if (!_isInitialized)
		{
			_bibleBookIdAndChapter = await localStorage!.GetItemAsync<BibleBookIdAndChapter>(Key);
			if (_bibleBookIdAndChapter is not null)
			{
				await Update(_bibleBookIdAndChapter);
			}
			else
			{
				_bibleBookIdAndChapter = _defaultBibleBookIdAndChapter;
				await Update(_defaultBibleBookIdAndChapter);
			}

			_isInitialized = true;

		}
	}

	public BibleBookIdAndChapter Get()
	{
		return _bibleBookIdAndChapter!;
	}

	public async Task Update(BibleBookIdAndChapter bibleBookIdAndChapter)
	{
		await localStorage!.SetItemAsync(Key, bibleBookIdAndChapter);
		_bibleBookIdAndChapter = bibleBookIdAndChapter;
		NotifyStateHasChanged();
	}

}
