using Blazored.LocalStorage;

using MyHebrewBible.Client.Features.Parasha.Enums;

namespace MyHebrewBible.Client.State;

public class ParashaState
{
	//private readonly ILogger<ParashaState>? Logger;

	#region Constructor and DI
	private readonly ILogger Logger;
	private readonly ILocalStorageService? localStorage;

	public ParashaState(ILocalStorageService localStorage, ILogger<AppState> logger)
	{
		this.localStorage = localStorage;
		Logger = logger;
		//Logger!.LogInformation("{Class}!{MethodEvent}", nameof(ParashaState), "CTOR");
	}
	#endregion

	private const string Key = "parasha-show-section-permutation";
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private Permutation defaultPermutation = Permutation.Torah;

	private int _permutation;

	public async Task Initialize()
	{
		//Logger!.LogWarning("{Method}, _isInitialized: {_isInitialized}", nameof(Initialize), _isInitialized);
		if (!_isInitialized)
		{
			var s = await localStorage!.GetItemAsync<string>(Key);
			if (s == null)
			{
				//Logger!.LogWarning("... s is null, using {defaultPermutation}, calling {Update}", defaultPermutation, nameof(Update));
				await Update(defaultPermutation);
			}
			else
			{
				bool _success = int.TryParse(s, out _permutation);
				if (_success)
				{
					//Logger!.LogWarning("calling {Update}, _permutation: {_permutation}", nameof(Update), _permutation);
					await Update((Permutation)_permutation);
					//await Update(_permutation);
				}
				else 
				{
					//Logger!.LogWarning("... TryParse failed, using {defaultPermutation}, calling {Update}", defaultPermutation, nameof(Update));
					await Update(defaultPermutation);
				}
			}
		}
	}

	public int Get()
	{
		//Logger!.LogInformation("{Method}, permutation: {permutation}", nameof(Get), _permutation); // DEBUG 
		return _permutation;
	}

	public async Task Update(Permutation permutation)
	{
		await this.localStorage!.SetItemAsync(Key, (int)permutation);
		_permutation = (int)permutation;
		//Logger!.LogError("{Method}, permutation: {permutation}", nameof(Update), permutation);
		NotifyStateHasChanged();
	}
}
