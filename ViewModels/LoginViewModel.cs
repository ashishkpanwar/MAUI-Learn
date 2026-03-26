using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyApp.Services;

namespace MyApp.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    private readonly AuthService _authService;

    public LoginViewModel(AuthService authService)
    {
        _authService = authService;
    }

    [ObservableProperty]
    private string username = string.Empty;

    [ObservableProperty]
    private string password = string.Empty;

    [ObservableProperty]
    private bool isBusy;

    [ObservableProperty]
    private string errorMessage = string.Empty;

    public bool HasErrors => !string.IsNullOrWhiteSpace(ErrorMessage);

    public bool IsNotBusy => !IsBusy;

    [RelayCommand]
    private async Task Login()
    {
        if (IsBusy)
            return;

        IsBusy = true;
        ErrorMessage = string.Empty;

        try
        {
            // NOTE: Replace this with a real call in production.
            await Shell.Current.GoToAsync("//MainPage");
            // var result = await _authService.LoginAsync(Username, Password);
            // if (!string.IsNullOrEmpty(result.Token))
            // {
            //     await Shell.Current.GoToAsync("//MainPage");
            // }
            // else
            // {
            //     ErrorMessage = "Invalid login.";
            // }
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message;
        }
        finally
        {
            IsBusy = false;
            OnPropertyChanged(nameof(HasErrors));
        }
    }
}
