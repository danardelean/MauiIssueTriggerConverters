using APPMAUI44.Core.Interface;
using APPMAUI44.Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace APPMAUI44;

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

		builder.Services.AddTransient(typeof(MainPage));
        builder.Services.AddTransient(typeof(MainViewModel));
		builder.Services.AddSingleton<IMainThread, APPMAUI44.Service.MainThread>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

