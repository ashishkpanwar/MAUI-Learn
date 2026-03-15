using MyApp.Services;
using MyApp.ViewModels;

namespace MyApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Register Services
		builder.Services.AddSingleton<ApiService>();
		builder.Services.AddSingleton<AuthService>();

		// Register ViewModels
		builder.Services.AddSingleton<MainViewModel>();

		return builder.Build();
	}
}
