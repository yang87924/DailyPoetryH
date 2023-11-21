namespace DailyPoetryH.Library.Services;

public class PoetryStorage : IPoetryStorage
{
    public const string DbName = "poetrydb.sqlite3";

    public static readonly string PoetryDbPath =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder
                .LocalApplicationData), DbName);
    private readonly IPreferenceStorage _preferenceStorage;

    public PoetryStorage(IPreferenceStorage mockPreferenceStorage)
    {
        _preferenceStorage = mockPreferenceStorage;
    }

    public bool IsInitialized =>_preferenceStorage.Get(PoetryStorageConstant.DbVersionKey, 0) 
                                == PoetryStorageConstant.Version;

    public async Task InitializeAsync()
    {
        throw new NotImplementedException();
    }
} 

public static class PoetryStorageConstant
{
    public const String DbVersionKey=
        nameof(PoetryStorageConstant)+"."+nameof(DbVersionKey);
    public const int Version=1;
}