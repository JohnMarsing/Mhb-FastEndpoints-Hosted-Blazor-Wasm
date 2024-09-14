using Blazored.LocalStorage;
using MyHebrewBible.Client.Features.Parasha.Enums;

namespace MyHebrewBible.Client.Features.Parasha.State;

public interface IParashaState
{
	event Action? OnChange;
	//void Initialize(); ToDo: This is only called by AppState, and AppState is never called
	Task<bool> Get(LocalStorage key);
	Task Update(bool toggles, LocalStorage key);
}

public class ParashaState : IParashaState
{
	#region Constructor and DI
	private readonly ILogger Logger;
	private readonly ILocalStorageService? localStorage;

	public ParashaState(ILocalStorageService localStorage, ILogger<ParashaState> logger)
	{
		this.localStorage = localStorage;
		Logger = logger;
		Logger!.LogInformation("{Class}!{MethodEvent}", nameof(ParashaState), "CTOR");
	}
	#endregion

	//private bool _isInitialized; NOT USED
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	// public void Initialize()  {   } ToDo: This is only called by AppState, and AppState is never called

	public async Task<bool> Get(LocalStorage localStorage)
	{
		Logger!.LogInformation("{Class}!{Method}; key: {key}"
		, nameof(ParashaState), nameof(Get), localStorage.Key);

		bool? _toggleNullable; 
		bool returnToggleDefault = false;
		try
		{
			_toggleNullable = await this.localStorage!.GetItemAsync<bool?>(localStorage.Key);
			if (_toggleNullable is null)
			{
				await this.localStorage!.SetItemAsync(localStorage.Key, false);
			}
			returnToggleDefault = _toggleNullable ?? false;
		}
		catch (Exception ex)
		{
			Logger!.LogError(ex, "{Class}!{Method}, key: {key}"
			, nameof(ParashaState), nameof(Get), localStorage.Key);
		}

		return returnToggleDefault;
	}

	public async Task Update(bool toggle, LocalStorage localStorage) 
	{
		try
		{
			Logger!.LogInformation("{Class}!{Method}", nameof(ParashaState), nameof(Update));
			await this.localStorage!.SetItemAsync(localStorage.Key, toggle);
			NotifyStateHasChanged();
			Logger!.LogInformation("{Class}!{Method}, localStorage: {localStorage}", nameof(ParashaState), nameof(Update), localStorage.Name);
		}
		catch (Exception ex)
		{
			Logger!.LogError(ex, "{Class}!{Method}", nameof(ParashaState), nameof(Update));
		}

	}

}
