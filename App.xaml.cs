using System;
using Microsoft.Extensions.DependencyInjection;
using MyApp.ViewModels;
using MyApp.Views;

namespace MyApp;

public partial class App : Application
{
    public static IServiceProvider Services { get; private set; } = null!;

    public App(IServiceProvider services)
    {
        InitializeComponent();
        Services = services;

        MainPage = new AppShell();
		
    }
}
