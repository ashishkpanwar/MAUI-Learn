using MyApp.ViewModels;

namespace MyApp;

public partial class App : Application
{
    private readonly MainViewModel _mainViewModel;

    public App(MainViewModel mainViewModel)
    {
        InitializeComponent();
        _mainViewModel = mainViewModel;

        MainPage = new MainPage(_mainViewModel);
    }
}
