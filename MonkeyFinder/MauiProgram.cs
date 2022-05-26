namespace MonkeyFinder;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));

        var services = builder.Services
            .AddSingleton<HttpClient>()
            .AddSingleton<MonkeyService>()
            .AddSingleton<MonkeysViewModel>()
            .AddSingleton<MainPage>();

        return builder.Build();
    }
}
