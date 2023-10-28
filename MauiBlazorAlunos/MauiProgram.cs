using MauiBlazorAlunos.Data;
using MauiBlazorAlunos.Services;
using Microsoft.Extensions.Logging;

namespace MauiBlazorAlunos
{
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

            builder.Services.AddSingleton<IAlunoService,AlunoService>();

            builder.Services.AddMauiBlazorWebView();

		    builder.Services.AddBlazorWebViewDeveloperTools();
		    builder.Logging.AddDebug();

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}