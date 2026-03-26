using MyApp.ViewModels;

namespace MyApp.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        try
        {
            BindingContext = App.Services.GetRequiredService<LoginViewModel>();
        }
        catch (Exception ex)
        {
            // For debugging, you can set a breakpoint here or log the exception
            Console.WriteLine($"Error setting BindingContext: {ex.Message}");
            // Fallback: create a simple ViewModel or show error
        }
    }
}
