using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Maxi.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {
        
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    // public bool IsBusy
    // {
    //     get => isBusy;
    //     set
    //     {
    //         if (isBusy == value)
    //             return;

    //         isBusy = value;
    //         OnPropertyChanged();
    //         OnPropertyChanged(nameof(IsNotBusy));
    //     }
    // }

    public bool IsNotBusy => !IsBusy;

    // public string Title
    // {
    //     get => title;
    //     set
    //     {
    //         if (title == value)
    //             return;
    //         title = value;
    //         OnPropertyChanged();
    //     }
    // }

    // public event PropertyChangedEventHandler PropertyChanged;

    // public void PropertyChanged([CallMemberName]string name = null)
    // {
    //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    // }
}
