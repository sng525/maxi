using System.Diagnostics;
using Maxi.Model;
using Maxi.Services;

namespace Maxi.ViewModel;

public partial class StoresViewModel : BaseViewModel
{
    StoreService storeService;
    public ObservableCollection<Store> Stores { get; } = new();
    public StoresViewModel(StoreService storeService)
    {
        Title = "Store List";
        this.storeService = storeService;
    }

    [RelayCommand]
    async Task GetStoresAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;
            var stores = await storeService.GetStores();

            if (Stores.Count != 0)
                Stores.Clear();

            foreach (var store in stores)
            {
                Stores.Add(store);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error", "Unable to get stores", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}
