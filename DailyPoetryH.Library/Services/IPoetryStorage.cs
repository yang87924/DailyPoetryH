namespace DailyPoetryH.Library.Services;

//讀詩詞
public interface IPoetryStorage
{
    
    bool IsInitialized { get; }
    Task InitializeAsync();
}