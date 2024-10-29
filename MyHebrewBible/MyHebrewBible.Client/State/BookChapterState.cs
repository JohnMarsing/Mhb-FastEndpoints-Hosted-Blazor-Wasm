using Blazored.LocalStorage;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.State;

public class BookChapterState
{
	#region Constructor and DI
	private readonly ILocalStorageService? localStorage;

	public BookChapterState(ILocalStorageService localStorage)  
	{
		this.localStorage = localStorage;
	}
	#endregion

	private const string Key = "biblebookidandchapter";
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private BibleBookIdAndChapter _bibleBookIdAndChapter;
	private BibleBookIdAndChapter _bibleBookIdAndChapterDefault = new(BibleBook.Genesis.Value, 1);

	public async Task Initialize()
	{
		if (!_isInitialized)
		{
			_bibleBookIdAndChapter = await localStorage!.GetItemAsync<BibleBookIdAndChapter>(Key);
			if (_bibleBookIdAndChapter is null)
			{
				_bibleBookIdAndChapter = _bibleBookIdAndChapterDefault;
			}

			_isInitialized = true;
			NotifyStateHasChanged();
		}
	}

	public BibleBookIdAndChapter Get()
	{
		return _bibleBookIdAndChapter!;
	}

	public void Update(BibleBookIdAndChapter bibleBookIdAndChapter)  
	{
		localStorage!.SetItemAsync(Key, bibleBookIdAndChapter);
		NotifyStateHasChanged();
	}

}