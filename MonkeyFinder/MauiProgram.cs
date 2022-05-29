namespace MonkeyFinder;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"));

        var services = builder.Services
            .AddSingleton(Connectivity.Current)
            .AddSingleton(Geolocation.Default)
            .AddSingleton(Map.Default)

            .AddSingleton<HttpClient>()
            .AddSingleton<MonkeyService>()

            .AddSingleton<MonkeysViewModel>()
            .AddTransient<MonkeyDetailsViewModel>()

            .AddSingleton<MainPage>()
            .AddTransient<DetailsPage>();

        return builder.Build();
    }
}
