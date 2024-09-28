using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using TestSfListView.ViewModels;
//using CommunityToolkit.Maui;

namespace TestSfListView
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                //.UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });



#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();


            builder.ConfigureSyncfusionCore();

            return builder.Build();
        }
    }
}
