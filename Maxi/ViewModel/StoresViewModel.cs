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
}
