using Blazored.LocalStorage;

namespace MyHebrewBible.Client.State;

public class AppState 
{
	public BookChapterState? BookChapterState { get; }
	public ParashaState? ParashaState { get; }

	#region Constructor and DI
	private readonly ILogger? Logger;
	private readonly ILocalStorageService?  localStorage; 

	public AppState(ILocalStorageService localStorage, ILogger<AppState> logger) 
	{
		Logger = logger;
		this.localStorage = localStorage;
		BookChapterState = new BookChapterState(localStorage);
		ParashaState = new ParashaState(localStorage, logger);
		//Logger!.LogInformation("ctor of {Project}!{Class}", nameof(MyHebrewBible.Client), nameof(AppState));
	}
	#endregion

	private bool _isInitialized;

	public async Task Initialize()
	{
		//Logger!.LogInformation("{Method}, _isInitialized: {_isInitialized}", nameof(Initialize), _isInitialized);
		if (!_isInitialized)
		{
			try
			{
				await BookChapterState!.Initialize();
				await ParashaState!.Initialize();
				//Logger!.LogWarning("{Method} ParashaState.Get: {ParashaState}"
				//	, nameof(Initialize), ParashaState.Get());
				_isInitialized = true;
			}
			catch (Exception ex) 
			{
				Logger!.LogError(ex, "{Class}!{Method}", nameof(AppState), nameof(Initialize));
			}

		}
	}
}

// Ignore Spelling: App