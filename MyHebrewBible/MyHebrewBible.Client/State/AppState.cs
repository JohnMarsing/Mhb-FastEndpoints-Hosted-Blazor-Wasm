using Blazored.LocalStorage;
//using Microsoft.Extensions.Logging;

namespace MyHebrewBible.Client.State;

// ToDo: this isn't being used as of yet
public class AppState
{
	#region Constructor and DI
	//private readonly ILogger? Logger;
	private readonly ISyncLocalStorageService? localStorage;  // ILocalStorageService?
	public IBookChapterState? BookChapterState { get; }

	public AppState(ISyncLocalStorageService localStorage, IBookChapterState bookChapterState) //, ILogger<AppState> logger
	{
		//Logger = logger;
		this.localStorage = localStorage;
		BookChapterState = bookChapterState;

		//Logger!.LogInformation("ctor of {Project}!{Class}", nameof(MyHebrewBible.Client), nameof(AppState));
	}
	#endregion

	private bool _isInitialized;

	public void Initialize()
	{
		//Logger!.LogInformation("{Class}!{Method}, _isInitialized: {_isInitialized}", nameof(AppState), nameof(Initialize), _isInitialized);
		if (!_isInitialized)
		{
			try
			{
				//BookChapterState!.Initialize();
				_isInitialized = true;

				BibleBookIdAndChapter? _bibleBookIdAndChapter = BookChapterState!.Get();
				if (_bibleBookIdAndChapter is null)
				{
					//Logger!.LogWarning("{ Class}!{Method}, _bookAndChapter is null after trying to Get from local storage", nameof(AppState), nameof(Initialize));
				}
				/*
				else
				{
					Logger!.LogInformation("...
				}
				*/
			}
			catch (Exception) // ex
			{
				//Logger!.LogError(ex, "{Class}!{Method}", nameof(AppState), nameof(Initialize));
			}

		}
	}
}

// Ignore Spelling: App