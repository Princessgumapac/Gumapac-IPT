using GUMAPAC_MAUI.Components.Enpoint;
using Microsoft.Extensions.Logging;

namespace GUMAPAC_MAUI
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

            builder.Services.AddMauiBlazorWebView();


            var baseAddress = "https://rochemagsayo-001-site55.jtempurl.com/myprofile";
            builder.Services.AddSingleton(sp =>
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (m, c, ch, e) => true
                };
                return new HttpClient(handler) { BaseAddress = new Uri(baseAddress) };
            });

            builder.Services.AddSingleton<InfoEndpoints>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
