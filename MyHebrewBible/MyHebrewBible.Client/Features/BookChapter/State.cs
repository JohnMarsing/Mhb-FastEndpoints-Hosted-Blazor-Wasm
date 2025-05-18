using Blazored.LocalStorage;
using MyHebrewBible.Client.State;
using GlobalEnums = MyHebrewBible.Client.Enums;
using MyHebrewBible.Client.Features.BookChapter.Toolbar;
using MyHebrewBible.Client.Features.BookChapter.Enums;

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
	private const string KeyBcvList = "bc-bcv-list";
	private const string KeyUserSetting = "bc-user-setting-permutation";

	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private AbrvChapterVerse _DefaultAbrvChapterVerse = new("Gen", 1, 1, true, 0); //"Gen", 1, 1, 1);
	private AbrvChapterVerse? _AbrvChapterVerse = new("Gen", 1, 1, true, 0);  //"Gen", 1, 1, 1);

	//private Permutation = Enums.UserSetting.DefaultUserSetting;
	private int _UserSetting;

	private readonly List<BookChapterVerseHistory>? _DefaultBCVs =
				[
						new BookChapterVerseHistory(GlobalEnums.BibleBook.Deuteronomy.Value, 6, 4),
						new BookChapterVerseHistory(GlobalEnums.BibleBook.Leviticus.Value, 26, 40),
						new BookChapterVerseHistory(GlobalEnums.BibleBook.Matthew.Value, 5, 17)
				];
	private List<BookChapterVerseHistory>? _BCVs;
	private int _MaxBCVs = 10;

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

			var us = await localStorage!.GetItemAsync<string>(KeyUserSetting);
			if (us is null)
			{
			  //Logger!.LogWarning("... us is null, using {Default}, calling {UserSetting}", UserSetting.Default, nameof(UserSetting));
				await UpdateUserSetting(UserSetting.Default); 
			}
			else
			{
				bool _success = int.TryParse(us, out _UserSetting);
				if (!_success)
				{
					await UpdateUserSetting(UserSetting.Default);
				}
			}

			_BCVs = await localStorage!.GetItemAsync<List<BookChapterVerseHistory>>(KeyBcvList);
			if (_BCVs is not null)
			{
				await UpdateBCVs(_BCVs);
			}
			else
			{
				_BCVs = _DefaultBCVs;
				await localStorage!.SetItemAsync(KeyBcvList, _DefaultBCVs);
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
		//Logger!.LogInformation("{Method}, brvChapterVerse: {AbrvChapterVerse}", nameof(UpdateACV), abrvChapterVerse);
		await localStorage!.SetItemAsync(KeyACVId, abrvChapterVerse);
		_AbrvChapterVerse = abrvChapterVerse;
		NotifyStateHasChanged();
	}

	public int GetUserSetting()
	{
		//Logger!.LogInformation("{Method}, permutation: {permutation}", nameof(Get), _permutation); // DEBUG 
		return _UserSetting;
	}

	public async Task UpdateUserSetting(Permutation permutation)
	{
		await localStorage!.SetItemAsync(KeyUserSetting, (int)permutation);
		_UserSetting = (int)permutation;
		//Logger!.LogError("{Method}, permutation: {permutation}", nameof(UpdateUserSetting), permutation);
		NotifyStateHasChanged();
	}

	#region BCV
	public List<BookChapterVerseHistory> GetBCVs()
	{
		return _BCVs!;
	}

	// Called by Initialize if (!_isInitialized)
	private async Task UpdateBCVs(List<BookChapterVerseHistory> bookChapterVerses)
	{
		await localStorage!.SetItemAsync(KeyBcvList, bookChapterVerses);
		_BCVs = bookChapterVerses;
		NotifyStateHasChanged();
	}

	public async Task RemoveDuplicatesFromBcvList()
	{
		//Logger!.LogInformation("{Method}", nameof(RemoveDuplicatesFromBcvList));

		//if (_BCVs is null) { Logger!.LogInformation("..._BCVs is null; return"); return; }
		if (_BCVs is null) { return; }

		//Logger!.LogInformation("... old count: {Count}", _BCVs.Count());

		_BCVs = _BCVs!
			.GroupBy(x => new { x.BibleBookId, x.Chapter, x.Verse } )
			.Select(g => g.First())
			.ToList();
		
		//Logger!.LogInformation("... new count: {Count}", _BCVs.Count());

		await localStorage!.SetItemAsync(KeyBcvList, _BCVs);
		NotifyStateHasChanged();	
	}

	public async Task AddStoredAcvToBcvList()
	{
		BookChapterVerseHistory? _BCVH = ConvertStoredAcvToBcv();

		if (_BCVs is null) { return; }
		//if (_BCVs is null) { Logger!.LogInformation("{Method}; BCVs is null; return", nameof(AddStoredAcvToBcvList)); return; }

		if (!IsVerseAlreadyInList(_BCVH!))
		{
			if (_BCVs!.Count >= _MaxBCVs)
			{
				//Logger!.LogInformation("{Method}; BCVs.Count >= _MaxBCVs", nameof(AddStoredAcvToBcvList));
				_BCVs.RemoveAt(_BCVs.Count - 1);
			}

			_BCVs!.Insert(0, _BCVH!);
			await localStorage!.SetItemAsync(KeyBcvList, _BCVs);
			NotifyStateHasChanged();
		}
		else
		{
			//Logger!.LogInformation("{Method}; BCVH: {BCVH} is already in list", 	nameof(AddStoredAcvToBcvList), _BCVH);
		}
	}

	//private 
	public BookChapterVerseHistory? ConvertStoredAcvToBcv()
	{
		var (errMsg, _bibleBookId) = GlobalEnums.BibleBookDictionary.GetId(_AbrvChapterVerse!.Abrv);
		if (String.IsNullOrEmpty(errMsg))
		{
			return new BookChapterVerseHistory(_bibleBookId, _AbrvChapterVerse!.Chapter, _AbrvChapterVerse!.Verse);
		}
		else
		{
			return null;
		}
	}


	private bool IsVerseAlreadyInList(BookChapterVerseHistory bCVH)
	{
		int count = 0;
		count = _BCVs!
			.Where(w => w.BibleBookId == bCVH.BibleBookId)
			.Where(w => w.Chapter == bCVH.Chapter)
			.Where(w => w.Verse == bCVH.Verse)
			.Count();

		//Logger!.LogInformation("{Method}; bCVH:{bCVH}, Duplicate?:{TorF}", nameof(IsVerseAlreadyInList), bCVH, count > 0);
		return count > 0;
	}


	public async Task RemoveBCV(BookChapterVerseHistory bcv)
	{
		_BCVs!.Remove(bcv);
		await localStorage!.SetItemAsync(KeyBcvList, _BCVs);
		NotifyStateHasChanged();
	}
	#endregion
}
// Ignore Spelling: ctor, DI, Abrv, brv, BCV, ACV, bc, toolbar
