using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls;
using SchoolApp.ViewModels;
using SchoolApp.Views;

namespace SchoolApp
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


    		builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<ContentPage>();
           builder.Services.AddSingleton<AboutPage>();


           
            builder.Services.AddSingleton<LoginPageViewModel>();
            //builder.Services.AddSingleton<HomePageViewModel>();

            return builder.Build();
        }
    }
}
