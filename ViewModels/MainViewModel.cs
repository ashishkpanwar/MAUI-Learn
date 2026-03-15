using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string message = "Initial Message";

    [RelayCommand]
    private void ClickMe()
    {
        Message = "Button Clicked!";
    }
}