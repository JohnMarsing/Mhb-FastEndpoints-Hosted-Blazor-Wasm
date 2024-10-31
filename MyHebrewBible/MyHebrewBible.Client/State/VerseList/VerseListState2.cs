using Blazored.LocalStorage;
using MyHebrewBible.Client.Enums;

namespace MyHebrewBible.Client.State.VerseList;

public class VerseListState2
{
	//private readonly ILocalStorageService? localStorage;
	#region Constructor and DI
	private readonly ILogger Logger;
	private readonly ILocalStorageService? localStorage;

	public VerseListState2(ILocalStorageService localStorage, ILogger<AppState> logger)
	{
		this.localStorage = localStorage;
		Logger = logger;
		//Logger!.LogInformation("{Class}!{MethodEvent}", nameof(VerseListState2), "CTOR");
	}
	#endregion

	private const string KeyHeader = "verselists";
	private const string KeyBCV = "verselistbcv";
	private bool _isInitialized;
	private void NotifyStateHasChanged() => OnChange?.Invoke();
	public event Action? OnChange;

	private Header? _header;

	private DetailRecord? _detailRecord;
	private DetailRecord? _defaultDetailRecord;

	public async Task Initialize()
	{
		if (!_isInitialized)
		{
			_header = await localStorage!.GetItemAsync<Header>(KeyHeader);

			if (_header is null)
			{
				List<DetailRecord> dtls =
					[
						new DetailRecord(BibleBook.Genesis.Value, 1, 22, 22, "First use of word bless _barak_ <sup>H1288</sup>"),
										new DetailRecord(BibleBook.Genesis.Value, 12, 2, 3, "The _ricochet_ blessings")
					];
				_header = new Header(1, "Your First VerseList", dtls);
				await UpdateHeader(_header);
			}

			_detailRecord = await localStorage!.GetItemAsync<DetailRecord>(KeyBCV);

			if (_detailRecord is null)
			{
				_defaultDetailRecord = new DetailRecord(BibleBook.Genesis.Value, 12, 2, 3, "First verse list detail record");
				await UpdateBCV(_defaultDetailRecord);
			}
			
			_isInitialized = true;
		}
	}

	public Header GetHeader()
	{
		return _header!;
	}

	public async Task UpdateHeader(Header header)
	{
		await this.localStorage!.SetItemAsync(KeyHeader, header);
		_header = header;
		NotifyStateHasChanged();
	}


	public DetailRecord GetBCV()
	{
		return _detailRecord!;
	}

	public async Task UpdateBCV(DetailRecord detailRecord)
	{
		await this.localStorage!.SetItemAsync(KeyBCV, detailRecord);
		_detailRecord = detailRecord;
		NotifyStateHasChanged();
	}


}
