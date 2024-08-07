using Blazored.LocalStorage;
//using Microsoft.Extensions.Logging;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.State;

public interface IBookChapterState
{
	event Action? OnChange;
	void Initialize();
	BibleBookIdAndChapter Get();
	void Update(BibleBookIdAndChapter bibleBookIdAndChapter);
}

public class BookChapterState : IBookChapterState
{
#region Constructor and DI
	//private readonly ILogger Logger;
	private readonly ISyncLocalStorageService? localStorage;

	public BookChapterState(ISyncLocalStorageService localStorage) //, ILogger<BookChapterState> logger
	{
		this.localStorage = localStorage;
		//Logger = logger;
		//Logger!.LogInformation("{Class}!{MethodEvent}", nameof(BookChapterState), "CTOR");
	}
#endregion

	private const string Key = "biblebookidandchapter";
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;
	BibleBookIdAndChapter? _bibleBookIdAndChapter; 

	public void Initialize()
	{
		//Logger!.LogInformation("{Class}!{Method}, _isInitialized: {_isInitialized}", 
		//	nameof(BookChapterState), nameof(Initialize), _isInitialized);
		if (!_isInitialized)
		{
			try
			{
				_bibleBookIdAndChapter = localStorage!.GetItem<BibleBookIdAndChapter>(Key);
				if (_bibleBookIdAndChapter is null)
				{
					_bibleBookIdAndChapter = new BibleBookIdAndChapter(BibleBook.Genesis.Value, 1); 
				}

				_isInitialized = true;
				NotifyStateHasChanged();
			}
			catch (Exception ex)
			{
				//Logger!.LogError(ex, "{Class}!{Method}", nameof(BookChapterState), nameof(Initialize));
			}
		}
	}

	public BibleBookIdAndChapter Get()
	{
		try
		{
			_bibleBookIdAndChapter = localStorage!.GetItem<BibleBookIdAndChapter>(Key);
		}
		catch (Exception ex)
		{
			//Logger!.LogError(ex, "{Class}!{Method}, Key: {Key}, trying to call localStorage!.GetItem<Profile>(Key)"
			//, nameof(BookChapterState), nameof(Get), Key);
		}
		return _bibleBookIdAndChapter!;
	}

	public void Update(BibleBookIdAndChapter bibleBookIdAndChapter) 
	{
		try
		{
			localStorage!.SetItem(Key, bibleBookIdAndChapter);
			NotifyStateHasChanged();
		}
		catch (Exception ex)
		{
			//Logger!.LogError(ex, "{Class}!{Method}" , nameof(BookChapterState), nameof(Update));
		}

	}

}
