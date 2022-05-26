namespace MonkeyFinder;

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
            });

        var services = builder.Services;

        services.AddSingleton<HttpClient>();

        services.AddSingleton<MonkeyService>();
        services.AddSingleton<MonkeysViewModel>();
        services.AddSingleton<MainPage>();

        return builder.Build();
    }
}
