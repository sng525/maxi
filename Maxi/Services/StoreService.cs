using Maxi.Model;

namespace Maxi.Services;

public class StoreService
{
    HttpClient httpClient;

    public StoreService()
    {
        httpClient = new HttpClient();
    }
    public List<Store> storeList = new ();

    public async Task<List<Store>> GetStores()
    {
        if (storeList.Count > 0)
        {
            return storeList;
        }

        using var stream = await FileSystem.OpenAppPackageFileAsync("storeData.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync(); 
        storeList = JsonSerializer.Deserialize<List<Store>>(contents); 

        return storeList;
    }
}
