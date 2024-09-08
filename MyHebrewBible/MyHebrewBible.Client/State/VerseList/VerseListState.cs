using Blazored.LocalStorage;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.State.VerseList;

public interface IVerseListState
{
	event Action? OnChange;
	//void Initialize();  ToDo: This is only called by AppState, and AppState is never called
	Header GetHeader();
	void UpdateHeader(Header Header);
	DetailRecord GetBCV();  //
	void UpdateBCV(DetailRecord BCV);
}

public class VerseListState : IVerseListState
{
	#region Constructor and DI
	private readonly ILogger Logger;
	private readonly ISyncLocalStorageService? localStorage;

	public VerseListState(ISyncLocalStorageService localStorage, ILogger<VerseListState> logger)
	{
		this.localStorage = localStorage;
		Logger = logger;
		Logger!.LogInformation("{Class}!{MethodEvent}", nameof(VerseListState), "CTOR");
	}
	#endregion

	private const string Key = "verselists";
	private const string KeyBCV = "verselistbcv";
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;
	Header? _header;
	DetailRecord? _detailRecord;


	// public void Initialize()  {   } ToDo: This is only called by AppState, and AppState is never called

	public Header GetHeader()
	{
		Logger!.LogInformation("{Class}!{MethodEvent}", nameof(VerseListState), nameof(GetHeader));
		try
		{
			_header = localStorage!.GetItem<Header>(Key);

			if (_header is null)
			{
				List<DetailRecord> dtls = 
					[
						new DetailRecord(BibleBook.Genesis.Value, 1, 22, 22, "First use of word bless _barak_ <sup>H1288</sup>"),
						new DetailRecord(BibleBook.Genesis.Value, 12, 2, 3, "The _ricochet_ blessings")
					];
				_header = new Header(1, "Your First VerseList", dtls);
			}

		}
		catch (Exception ex)
		{
			Logger!.LogError(ex, "{Class}!{Method}, Key: {Key}, trying to call localStorage!.GetItem<Profile>(Key)"
			, nameof(VerseListState), nameof(GetHeader), Key);
		}
		return _header!;
	}

	public void UpdateHeader(Header Header)
	{
		try
		{
			localStorage!.SetItem(Key, Header);
			NotifyStateHasChanged();
		}
		catch (Exception ex)
		{
			Logger!.LogError(ex, "{Class}!{Method}" , nameof(VerseListState), nameof(UpdateHeader));
		}

	}


	public DetailRecord GetBCV()
	{
		Logger!.LogInformation("{Class}!{MethodEvent}", nameof(VerseListState), nameof(GetBCV));
		try
		{
			_detailRecord = localStorage!.GetItem<DetailRecord>(KeyBCV);

			if (_detailRecord is null)
			{
				_detailRecord = new DetailRecord(BibleBook.Genesis.Value,12,2,3,"First verse list detail record");
				localStorage!.SetItem(KeyBCV, _detailRecord);
			}

		}
		catch (Exception ex)
		{
			Logger!.LogError(ex, "{Class}!{Method}, KeyBCV: {KeyBCV}, trying to call localStorage!.GetItem<Profile>(KeyBCV)"
			, nameof(VerseListState), nameof(GetBCV), KeyBCV);
		}
		return _detailRecord!;
	}

	public void UpdateBCV(DetailRecord detailRecord)
	{
		try
		{
			localStorage!.SetItem(KeyBCV, detailRecord);
			NotifyStateHasChanged();
		}
		catch (Exception ex)
		{
			Logger!.LogError(ex, "{Class}!{Method}", nameof(VerseListState), nameof(UpdateBCV));
		}

	}



}